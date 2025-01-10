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
    public partial class Batch_Search : Form
    {
        SqlConnection workers_database_connection, main_database_connection;

        public Batch_Search(SqlConnection workers_database_connection, SqlConnection main_database_connection)
        {
            InitializeComponent();
            this.workers_database_connection = workers_database_connection;
            this.main_database_connection = main_database_connection;
        }

        private void Batch_Search_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string batchId = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(batchId))
            {
                MessageBox.Show("Please enter a Batch ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string query = @"
                    SELECT Batch_id, ContractC_id, CarModelCar_Model_Id
                    FROM Batch
                    WHERE Batch_id = @BatchId";

                using (SqlCommand cmd = new SqlCommand(query, main_database_connection))
                {
                    cmd.Parameters.AddWithValue("@BatchId", batchId);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable results = new DataTable();
                    adapter.Fill(results);

                    if (results.Rows.Count > 0)
                    {
                        QueryResult queryResult = new QueryResult(results);
                        queryResult.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("No batch found with the specified ID.", "Batch Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while searching for batch: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
