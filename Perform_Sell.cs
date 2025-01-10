using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Microsoft.Data.SqlClient;

namespace Sql_Interactor
{
    public partial class Perform_Sell : Form
    {

        SqlConnection workers_database_connection, main_database_connection;

        public Perform_Sell(SqlConnection workers_database_connection, SqlConnection main_database_connection)
        {
            InitializeComponent();
            this.workers_database_connection = workers_database_connection;
            this.main_database_connection = main_database_connection;
        }

        private void Perform_Sell_Load(object sender, EventArgs e)
        {
            //dar display as Stores
            if (workers_database_connection != null)
            {
                string query = "Select Store_id from Store";
                SqlDataAdapter adapter = new SqlDataAdapter(query, main_database_connection);
                DataTable dt = new DataTable();
                try
                {
                    adapter.Fill(dt);
                    foreach (DataRow row in dt.Rows)
                    {
                        comboBox3.Items.Add(row["Store_id"]);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Couldnt load stores" + ex.Message);
                }
            }
            if (workers_database_connection != null)
            {
                string query = "Select S_Type_id from SellType";
                SqlDataAdapter adapter = new SqlDataAdapter(query, main_database_connection);
                DataTable dt = new DataTable();
                try
                {
                    adapter.Fill(dt);
                    foreach (DataRow row in dt.Rows)
                    {
                        comboBox1.Items.Add(row["S_Type_id"]);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Couldnt load sell types" + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string carPlate = textBox5.Text.Trim().ToUpper();
                string dealerId = textBox3.Text.Trim();
                string storeId = comboBox3.SelectedItem?.ToString();
                string sellValue = textBox1.Text.Trim();
                string sellDate = textBox2.Text.Trim();

                // Validação Matrícula
                if (string.IsNullOrEmpty(carPlate) || !CarExists(carPlate))
                {
                    MessageBox.Show("A matrícula não existe ou está inválida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validação Dealer
                if (string.IsNullOrEmpty(dealerId) || !DealerIsAuthorized(dealerId))
                {
                    MessageBox.Show("O Dealer especificado não existe ou não está autorizado a realizar vendas.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validação Store
                if (string.IsNullOrEmpty(storeId) || !StoreExists(storeId))
                {
                    MessageBox.Show("A loja especificada não existe.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validação Valor
                if (!decimal.TryParse(sellValue, out decimal value) || value <= 0)
                {
                    MessageBox.Show("Insere um valor válido (apenas números positivos).", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validação Data
                if (!DateTime.TryParseExact(sellDate, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime date))
                {
                    MessageBox.Show("Insere uma data válida no formato dd/MM/yyyy.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                MessageBox.Show("Validação concluída. Dados prontos para processamento.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool CarExists(string carPlate)
        {
            const string query = "SELECT COUNT(1) FROM Car WHERE Car_Plate = @CarPlate";

            using (SqlCommand cmd = new SqlCommand(query, main_database_connection))
            {
                cmd.Parameters.Add(new SqlParameter("@CarPlate", SqlDbType.VarChar) { Value = carPlate });
                return ExecuteScalarCommand(cmd) > 0;
            }
        }

        private bool DealerIsAuthorized(string dealerId)
        {
            const string query = @"
        SELECT COUNT(1)
        FROM JJJ_International_Workers.dbo.Worker
        WHERE W_Id = @DealerId AND FunctionF_Id IN (1, 5, 8, 10, 11, 12, 13)";

            using (SqlCommand cmd = new SqlCommand(query, main_database_connection))
            {
                cmd.Parameters.Add(new SqlParameter("@DealerId", SqlDbType.Int) { Value = dealerId });
                return ExecuteScalarCommand(cmd) > 0;
            }
        }

        private bool StoreExists(string storeId)
        {
            const string query = "SELECT COUNT(1) FROM Store WHERE Store_Id = @StoreId";

            using (SqlCommand cmd = new SqlCommand(query, main_database_connection))
            {
                cmd.Parameters.Add(new SqlParameter("@StoreId", SqlDbType.Int) { Value = storeId });
                return ExecuteScalarCommand(cmd) > 0;
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
