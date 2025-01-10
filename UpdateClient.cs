using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Sql_Interactor
{
    public partial class UpdateClient : Form
    {
        SqlConnection main_database_connection;
        DataTable currentCustomerData;
        public UpdateClient(SqlConnection main_database_connection)
        {
            InitializeComponent();
            this.main_database_connection = main_database_connection;

            LoadComboBoxes();
        }

        private void UpdateClient_Load(object sender, EventArgs e)
        {

        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBox_Client_Id_Number.Text))
                {
                    MessageBox.Show("Insert a valid NIF", "Sql Interactor 2000", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                long nif = long.Parse(textBox_Client_Id_Number.Text);
                string query = @"
                    SELECT C.F_Name, C.L_Name, C.Income, C.CountryCountry_id, C.PostalCodePostal_Code
                    FROM Customer C
                    WHERE C.NIF = @NIF";

                DataTable customerTable = new DataTable();
                using (SqlCommand cmd = new SqlCommand(query, main_database_connection))
                {
                    cmd.Parameters.AddWithValue("@NIF", nif);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(customerTable);
                    }
                }

                if (customerTable.Rows.Count == 0)
                {
                    MessageBox.Show("Customer not found.", "Sql Interactor 2000", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                DataRow customerRow = customerTable.Rows[0];
                textBox_First_Name.Text = customerRow["F_Name"].ToString();
                textBox_Last_Name.Text = customerRow["L_Name"].ToString();
                textBox_Income.Text = customerRow["Income"].ToString();

                comboBox_Country.SelectedValue = customerRow["CountryCountry_id"];

                comboBox_Postal_Code.SelectedValue = customerRow["PostalCodePostal_Code"];

                currentCustomerData = customerTable;
                Console.WriteLine("Nif: " + nif);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                MessageBox.Show($"Error searching data.", "Sql Interactor 2000", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadComboBoxes()
        {
            try
            {
                string countryQuery = "SELECT Country_id, CountryName FROM Country";
                DataTable countryTable = new DataTable();
                using (SqlCommand cmd = new SqlCommand(countryQuery, main_database_connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(countryTable);
                }

                comboBox_Country.DataSource = countryTable;
                comboBox_Country.DisplayMember = "CountryName";  
                comboBox_Country.ValueMember = "Country_id";     


                string postalCodeQuery = "SELECT Postal_Code, Location FROM PostalCode";
                DataTable postalCodeTable = new DataTable();
                using (SqlCommand cmd = new SqlCommand(postalCodeQuery, main_database_connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(postalCodeTable);
                }

                comboBox_Postal_Code.DataSource = postalCodeTable;
                comboBox_Postal_Code.DisplayMember = "Postal_Code"; 
                comboBox_Postal_Code.ValueMember = "Postal_Code";
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                MessageBox.Show($"An unexpected error occurred.", "Sql Interactor 2000", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void button_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentCustomerData == null || currentCustomerData.Rows.Count == 0)
                {
                    MessageBox.Show("Insert data in order to search.", "Sql Interactor 2000", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string newFirstName = textBox_First_Name.Text;
                string newLastName = textBox_Last_Name.Text;
                int newIncome = int.Parse(textBox_Income.Text);
                int newCountry = (int)comboBox_Country.SelectedValue;
                string newPostalCode = comboBox_Postal_Code.SelectedValue.ToString();

                DataRow row = currentCustomerData.Rows[0];
                if (newFirstName == row["F_Name"].ToString() &&
                    newLastName == row["L_Name"].ToString() &&
                    newIncome == Convert.ToInt32(row["Income"]) &&
                    newCountry == Convert.ToInt32(row["CountryCountry_id"]) &&
                    newPostalCode == row["PostalCodePostal_Code"].ToString())
                {
                    MessageBox.Show("No changes have been made", "Sql Interactor 2000", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                using (SqlCommand cmd = new SqlCommand("UpdateCustomer", main_database_connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@NIF", long.Parse(textBox_Client_Id_Number.Text));
                    cmd.Parameters.AddWithValue("@FName", newFirstName);
                    cmd.Parameters.AddWithValue("@LName", newLastName);
                    cmd.Parameters.AddWithValue("@Income", newIncome);
                    cmd.Parameters.AddWithValue("@CountryId", newCountry);
                    cmd.Parameters.AddWithValue("@PostalCode", newPostalCode);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Data updated with success", "Sql Interactor 2000", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                MessageBox.Show($"Error Saving Data. {ex.Message}", "Sql Interactor 2000", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
