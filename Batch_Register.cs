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
    public partial class Batch_Register : Form
    {
        SqlConnection workers_database_connection, main_database_connection;

        public Batch_Register(SqlConnection workers_database_connection, SqlConnection main_database_connection)
        {
            InitializeComponent();
            this.workers_database_connection = workers_database_connection;
            this.main_database_connection = main_database_connection;
        }

        private void Batch_Register_Load(object sender, EventArgs e)
        {
            try
            {
                string queryContracts = "SELECT C_id FROM dbo.Contract"; 
                using (SqlDataAdapter adapter = new SqlDataAdapter(queryContracts, main_database_connection))
                {
                    DataTable contractTable = new DataTable();
                    adapter.Fill(contractTable);

                    comboBox1.DataSource = contractTable;
                    comboBox1.DisplayMember = "C_id";
                    comboBox1.ValueMember = "C_id";
                    comboBox1.SelectedIndex = -1;
                }

                string queryCarModels = "SELECT Car_Model_Id FROM dbo.CarModel";
                using (SqlDataAdapter adapter = new SqlDataAdapter(queryCarModels, main_database_connection))
                {
                    DataTable carModelTable = new DataTable();
                    adapter.Fill(carModelTable);

                    comboBox2.DataSource = carModelTable;
                    comboBox2.DisplayMember = "Car_Model_Id";
                    comboBox2.ValueMember = "Car_Model_Id";
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
            if (comboBox1.SelectedIndex == -1 || comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a Contract ID and Car Model ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int contractId = Convert.ToInt32(comboBox1.SelectedValue);
            int carModelId = Convert.ToInt32(comboBox2.SelectedValue);

            try
            {
                string insertBatchQuery = @"
            INSERT INTO dbo.Batch (ContractC_Id, CarModelCar_Model_Id)
            OUTPUT INSERTED.Batch_Id
            VALUES (@ContractId, @CarModelId)";

                using (SqlCommand cmd = new SqlCommand(insertBatchQuery, main_database_connection))
                {
                    cmd.Parameters.AddWithValue("@ContractId", contractId);
                    cmd.Parameters.AddWithValue("@CarModelId", carModelId);

                    if (main_database_connection.State != ConnectionState.Open)
                    {
                        main_database_connection.Open();
                    }

                    int batchId = (int)cmd.ExecuteScalar(); 
                    MessageBox.Show($"Batch registered successfully with ID: {batchId}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while registering batch: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
