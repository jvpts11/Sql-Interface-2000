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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sql_Interactor
{
    public partial class Undo_Sell : Form
    {

        SqlConnection workers_database_connection, main_database_connection;

        public Undo_Sell(SqlConnection workers_database_connection, SqlConnection main_database_connection)
        {
            InitializeComponent();
            this.workers_database_connection = workers_database_connection;
            this.main_database_connection = main_database_connection;
        }

        private void Undo_Sell_Load(object sender, EventArgs e)
        {
            if (workers_database_connection != null)
            {
                string query = "Select StoreStore_id from Sell";
                SqlDataAdapter adapter = new SqlDataAdapter(query, main_database_connection);
                DataTable dt = new DataTable();
                try
                {
                    adapter.Fill(dt);
                    foreach (DataRow row in dt.Rows)
                    {
                        comboBox1.Items.Add(row["StoreStore_id"]);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Couldnt load stores" + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string sellId = textBox1.Text.Trim();
                string carPlate = textBox2.Text.Trim().ToUpper();
                string customerNIF = textBox4.Text.Trim();
                string storeId = comboBox1.SelectedItem?.ToString();
                string dealerId = textBox5.Text.Trim();

                if (string.IsNullOrEmpty(sellId) || !SellExists(sellId))
                {
                    MessageBox.Show("A venda especificada não existe.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!ValidateSellDetails(sellId, carPlate, customerNIF, storeId, dealerId))
                {
                    MessageBox.Show("Os dados fornecidos não correspondem à venda registada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (UndoSell(sellId))
                {
                    MessageBox.Show("A venda foi revertida com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro ao reverter a venda.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool SellExists(string sellId)
        {
            const string query = "SELECT COUNT(1) FROM Sell WHERE S_ID = @SellID";

            using (SqlCommand cmd = new SqlCommand(query, main_database_connection))
            {
                cmd.Parameters.Add(new SqlParameter("@SellID", SqlDbType.Int) { Value = sellId });
                return ExecuteScalarCommand(cmd) > 0;
            }
        }

        private bool ValidateSellDetails(string sellId, string carPlate, string customerNIF, string storeId, string dealerId)
        {
            const string query = @"
            SELECT COUNT(1)
            FROM Sell S
            INNER JOIN Car C ON S.CarCar_id = C.Car_id
            WHERE S.S_ID = @SellID
            AND C.Car_Plate = @CarPlate
            AND S.CustomerNIF = @CustomerNIF
            AND S.StoreStore_ID = @StoreID
            AND S.DealerD_ID = @DealerID";

            using (SqlCommand cmd = new SqlCommand(query, main_database_connection))
            {
                cmd.Parameters.Add(new SqlParameter("@SellID", SqlDbType.Int) { Value = sellId });
                cmd.Parameters.Add(new SqlParameter("@CarPlate", SqlDbType.VarChar) { Value = carPlate });
                cmd.Parameters.Add(new SqlParameter("@CustomerNIF", SqlDbType.BigInt) { Value = customerNIF });
                cmd.Parameters.Add(new SqlParameter("@StoreID", SqlDbType.Int) { Value = storeId });
                cmd.Parameters.Add(new SqlParameter("@DealerID", SqlDbType.VarChar) { Value = dealerId });

                if (main_database_connection.State != ConnectionState.Open)
                {
                    main_database_connection.Open();
                }

                object result = cmd.ExecuteScalar();
                return result != null && int.TryParse(result.ToString(), out int count) && count > 0;
            }
        }

        private bool UndoSell(string sellId)
        {
            const string deleteInsuranceQuery = "DELETE FROM InsuranceContract WHERE SellS_id = @SellID";
            const string deleteSellQuery = "DELETE FROM Sell WHERE S_ID = @SellID";

            using (SqlCommand cmd1 = new SqlCommand(deleteInsuranceQuery, main_database_connection))
            using (SqlCommand cmd2 = new SqlCommand(deleteSellQuery, main_database_connection))
            {
                cmd1.Parameters.Add(new SqlParameter("@SellID", SqlDbType.Int) { Value = sellId });
                cmd2.Parameters.Add(new SqlParameter("@SellID", SqlDbType.Int) { Value = sellId });

                if (main_database_connection.State != ConnectionState.Open)
                {
                    main_database_connection.Open();
                }
                cmd1.ExecuteNonQuery();
                int rowsAffected = cmd2.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }

        private int ExecuteScalarCommand(SqlCommand cmd)
        {
            if (main_database_connection.State != ConnectionState.Open)
            {
                main_database_connection.Open();
            }

            try
            {
                object result = cmd.ExecuteScalar();
                return result != null && int.TryParse(result.ToString(), out int count) ? count : 0;
            }
            finally
            {
                main_database_connection.Close();
            }
        }
    }
}
