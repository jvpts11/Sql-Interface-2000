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
    public partial class Register_Transport : Form
    {
        SqlConnection workers_database_connection, main_database_connection;

        public Register_Transport(SqlConnection workers_database_connection, SqlConnection main_database_connection)
        {
            InitializeComponent();
            this.workers_database_connection = workers_database_connection;
            this.main_database_connection = main_database_connection;
        }

        private void Register_Transport_Load(object sender, EventArgs e)
        {
            try
            {
                string queryTransportTypes = "SELECT T_Type_id, T_Type FROM TransportType";

                using (SqlDataAdapter adapter = new SqlDataAdapter(queryTransportTypes, main_database_connection))
                {
                    DataTable transportTypeTable = new DataTable();
                    adapter.Fill(transportTypeTable);

                    comboBox1.DataSource = transportTypeTable;
                    comboBox1.DisplayMember = "T_Type"; 
                    comboBox1.ValueMember = "T_Type_id";
                    comboBox1.SelectedIndex = -1; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading transport types: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string transportRegister = textBox1.Text.Trim();
            if (comboBox1.SelectedIndex == -1 || string.IsNullOrEmpty(transportRegister))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int transportTypeId = Convert.ToInt32(comboBox1.SelectedValue);

            try
            {
                string insertTransportQuery = @"
                    INSERT INTO Transport (T_Register, TransportTypeT_Type_id)
                    VALUES (@TransportRegister, @TransportTypeId)";

                using (SqlCommand cmd = new SqlCommand(insertTransportQuery, main_database_connection))
                {
                    cmd.Parameters.AddWithValue("@TransportRegister", transportRegister);
                    cmd.Parameters.AddWithValue("@TransportTypeId", transportTypeId);

                    if (main_database_connection.State != ConnectionState.Open)
                    {
                        main_database_connection.Open();
                    }

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Transport registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error registering transport: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
