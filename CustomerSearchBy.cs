using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sql_Interactor
{
    public partial class CustomerSearchBy : Form
    {
        SqlConnection main_database_connection;
        public CustomerSearchBy(SqlConnection main_database_connection)
        {
            InitializeComponent();
            this.main_database_connection = main_database_connection;
            
        }

        private void CustomerSearchBy_Load(object sender, EventArgs e)
        {
            LoadCountries();
            //comboBox_Country_Options.SelectedIndexChanged += comboBox_Countries_SelectedIndexChanged;
            LoadPostalCodes();
        }

        private void LoadCountries()
        {
            string query = "Select Country_id,CountryName from Country order by Country_id";
            SqlDataAdapter adapter = new SqlDataAdapter(query,main_database_connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            comboBox_Country_Options.DataSource = dt;
            comboBox_Country_Options.DisplayMember = "CountryName";
            comboBox_Country_Options.ValueMember = "Country_Id";
            comboBox_Country_Options.SelectedIndex = -1;
        }

        private void LoadPostalCodes()
        {
            string query = "Select Postal_Code from PostalCode";
            SqlDataAdapter adapter = new SqlDataAdapter(query, main_database_connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            comboBox_Postal_Code.DataSource = dt;
            comboBox_Postal_Code.DisplayMember = "Postal_Code";
            comboBox_Postal_Code.SelectedIndex = -1;
        }

        private void button_Search_By_Click(object sender, EventArgs e)
        {
            try
            {
                using(SqlCommand cmd = new SqlCommand("SearchCustomers", main_database_connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@NIF", string.IsNullOrWhiteSpace(textBox_Customer_Id.Text) ? (object)DBNull.Value : long.Parse(textBox_Customer_Id.Text));
                    cmd.Parameters.AddWithValue("@FirstName", string.IsNullOrWhiteSpace(textBox_First_Name.Text) ? (object)DBNull.Value : textBox_First_Name.Text);
                    cmd.Parameters.AddWithValue("@LastName", string.IsNullOrWhiteSpace(textBox_Last_Name.Text) ? (object)DBNull.Value : textBox_Last_Name.Text);

                    cmd.Parameters.AddWithValue("@FirstNameContains", checkBox_First_Name_Has.Checked ? checkBox_First_Name_Has.Text : (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@LastNameContains", checkBox_Last_Name_Has.Checked ? textBox_Last_Name.Text : (object)DBNull.Value);

                    cmd.Parameters.AddWithValue("@CountryID", comboBox_Country_Options.SelectedIndex == -1 ? (object)DBNull.Value : (int)comboBox_Country_Options.SelectedValue);
                    cmd.Parameters.AddWithValue("@PostalCode", comboBox_Postal_Code.SelectedIndex == -1 ? (object)DBNull.Value : comboBox_Postal_Code.Text);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable results = new DataTable();
                    adapter.Fill(results);

                    if (results.Rows.Count > 0)
                    {
                        QueryResult result = new QueryResult(results);
                        result.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("No customers found.", "Sql Interactor 2000", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("The error occured during search: "+ex.Message);
                MessageBox.Show($"An error occurred", "Sql Interactor 2000", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox_Countries_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Country_Options.SelectedValue != null)
            {
                try
                {
                    
                    if (comboBox_Country_Options.SelectedValue is DataRowView dataRowView)
                    {
                        
                        int selectedCountryId = Convert.ToInt32(dataRowView.Row["CountryCountry_id"]);
                        LoadPostalCodesByCountry(selectedCountryId);
                    }
                    else
                    {
                        int selectedCountryId = (int)comboBox_Country_Options.SelectedValue;
                        LoadPostalCodesByCountry(selectedCountryId);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: "+ex.Message);
                    MessageBox.Show("An error occurred while processing the selected country.", "Sql Interactor 2000", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                comboBox_Country_Options.DataSource = null;
            }
        }

        private void LoadPostalCodesByCountry(int countryId)
        {
            try
            {
                string query = "SELECT PostalCodePostal_Code FROM [Address] WHERE CountryCountry_id = @Country_Id";
                using (SqlCommand cmd = new SqlCommand(query, main_database_connection))
                {
                    cmd.Parameters.AddWithValue("@Country_Id", countryId);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable postalCodes = new DataTable();
                    adapter.Fill(postalCodes);

                    comboBox_Postal_Code.DataSource = postalCodes;
                    comboBox_Postal_Code.DisplayMember = "PostalCodePostal_Code";
                    comboBox_Postal_Code.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading postal codes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
