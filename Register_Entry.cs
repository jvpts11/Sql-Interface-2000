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
    public partial class Register_Entry : Form
    {
        SqlConnection workers_database_connection, main_database_connection;

        public Register_Entry(SqlConnection workers_database_connection, SqlConnection main_database_connection)
        {
            InitializeComponent();
            this.workers_database_connection = workers_database_connection;
            this.main_database_connection = main_database_connection;
        }

        private void Register_Entry_Load(object sender, EventArgs e)
        {
            try
            {
                string queryTransport = "SELECT T_id, T_Register FROM Transport";
                using (SqlDataAdapter adapter = new SqlDataAdapter(queryTransport, main_database_connection))
                {
                    DataTable transportTable = new DataTable();
                    adapter.Fill(transportTable);
                    comboBox1.DataSource = transportTable;
                    comboBox1.DisplayMember = "T_Register"; 
                    comboBox1.ValueMember = "T_id"; 
                    comboBox1.SelectedIndex = -1; 
                }

                string queryProducts = "SELECT Product_id, Product_Name FROM Products";
                using (SqlDataAdapter adapter = new SqlDataAdapter(queryProducts, main_database_connection))
                {
                    DataTable productTable = new DataTable();
                    adapter.Fill(productTable);
                    comboBox2.DataSource = productTable;
                    comboBox2.DisplayMember = "Product_Name"; 
                    comboBox2.ValueMember = "Product_id"; 
                    comboBox2.SelectedIndex = -1; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1 || comboBox2.SelectedIndex == -1 || string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please fill all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int transportId = Convert.ToInt32(comboBox1.SelectedValue);
                int productId = Convert.ToInt32(comboBox2.SelectedValue);
                int quantity = Convert.ToInt32(textBox1.Text);

                string insertEntryQuery = @"
                    INSERT INTO TransportEntry (TransportT_id, Product_id, Quantity)
                    VALUES (@TransportId, @ProductId, @Quantity)";

                using (SqlCommand cmd = new SqlCommand(insertEntryQuery, main_database_connection))
                {
                    cmd.Parameters.AddWithValue("@TransportId", transportId);
                    cmd.Parameters.AddWithValue("@ProductId", productId);
                    cmd.Parameters.AddWithValue("@Quantity", quantity);

                    if (main_database_connection.State != ConnectionState.Open)
                    {
                        main_database_connection.Open();
                    }

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Entry registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while registering entry: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
