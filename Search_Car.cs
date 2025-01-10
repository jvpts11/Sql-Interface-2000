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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sql_Interactor
{
    public partial class Search_Car : Form
    {
        SqlConnection workersDatabaseConnection, mainDatabaseConnection;

        public Search_Car(SqlConnection workersDatabaseConnection, SqlConnection mainDatabaseConnection)
        {
            InitializeComponent();
            this.workersDatabaseConnection = workersDatabaseConnection;
            this.mainDatabaseConnection = mainDatabaseConnection;
        }

        private void Search_Car_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string carId = textBox1.Text.Trim();
            string carPlate = textBox2.Text.Trim();

            try
            {
                string query = @"
                    SELECT Car_Id, Car_Plate, Car_Year, CarColorCar_color_id, CarModelCar_Model_Id
                    FROM Car
                    WHERE (@CarId IS NULL OR Car_Id = @CarId)
                      AND (@CarPlate IS NULL OR Car_Plate = @CarPlate)";

                using (SqlCommand cmd = new SqlCommand(query, mainDatabaseConnection))
                {
                    cmd.Parameters.AddWithValue("@CarId", string.IsNullOrEmpty(carId) ? (object)DBNull.Value : carId);
                    cmd.Parameters.AddWithValue("@CarPlate", string.IsNullOrEmpty(carPlate) ? (object)DBNull.Value : carPlate);

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
                        MessageBox.Show("No cars found.", "Sql Interactor 2000", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred during the search: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string carId = textBox1.Text.Trim(); // Retrieve Car ID from input
            string carPlate = textBox2.Text.Trim().ToUpper(); // Retrieve Car Plate and convert to uppercase

            try
            {
                // Validation: Ensure at least one search parameter is provided
                if (string.IsNullOrEmpty(carId) && string.IsNullOrEmpty(carPlate))
                {
                    MessageBox.Show("Please provide a Car ID or Car Plate to search.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Query to check if the car exists
                const string existenceQuery = @"
            SELECT COUNT(1) 
            FROM Car
            WHERE (@CarId IS NULL OR Car_Id = @CarId)
              AND (@CarPlate IS NULL OR Car_Plate = @CarPlate)";

                using (SqlCommand cmd = new SqlCommand(existenceQuery, mainDatabaseConnection))
                {
                    cmd.Parameters.AddWithValue("@CarId", string.IsNullOrEmpty(carId) ? (object)DBNull.Value : carId);
                    cmd.Parameters.AddWithValue("@CarPlate", string.IsNullOrEmpty(carPlate) ? (object)DBNull.Value : carPlate);

                    if (mainDatabaseConnection.State != ConnectionState.Open)
                    {
                        mainDatabaseConnection.Open();
                    }

                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    if (count == 0)
                    {
                        MessageBox.Show("No car matches the provided details.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }

                // Query to fetch car details
                const string fetchQuery = @"
            SELECT Car_Id, Car_Plate, Car_Year, CarColorCar_color_id AS Color_ID, CarModelCar_Model_Id AS Model_ID
            FROM Car
            WHERE (@CarId IS NULL OR Car_Id = @CarId)
              AND (@CarPlate IS NULL OR Car_Plate = @CarPlate)";

                using (SqlCommand fetchCmd = new SqlCommand(fetchQuery, mainDatabaseConnection))
                {
                    fetchCmd.Parameters.AddWithValue("@CarId", string.IsNullOrEmpty(carId) ? (object)DBNull.Value : carId);
                    fetchCmd.Parameters.AddWithValue("@CarPlate", string.IsNullOrEmpty(carPlate) ? (object)DBNull.Value : carPlate);

                    SqlDataAdapter adapter = new SqlDataAdapter(fetchCmd);
                    DataTable results = new DataTable();
                    adapter.Fill(results);

                    // Display results in QueryResult form
                    QueryResult queryResult = new QueryResult(results);
                    queryResult.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred during the search: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (mainDatabaseConnection.State == ConnectionState.Open)
                {
                    mainDatabaseConnection.Close();
                }
            }
        }
    }
}
