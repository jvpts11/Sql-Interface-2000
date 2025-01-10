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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sql_Interactor
{
    public partial class SearchSell : Form
    {
        SqlConnection workers_database_connection, main_database_connection;

        public SearchSell(SqlConnection workers_database_connection, SqlConnection main_database_connection)
        {
            InitializeComponent();
            this.workers_database_connection = workers_database_connection;
            this.main_database_connection = main_database_connection;
        }

        private void SearchSell_Load(object sender, EventArgs e)
        {
            string query = "SELECT Store_id FROM Store";
            SqlDataAdapter adapter = new SqlDataAdapter(query, main_database_connection);
            DataTable dt = new DataTable();
            try
            {
                adapter.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    comboBox1.Items.Add(row["Store_id"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível carregar as lojas: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string carPlate = string.IsNullOrWhiteSpace(textBox1.Text) ? null : textBox1.Text.Trim();
            string customerNIF = string.IsNullOrWhiteSpace(textBox3.Text) ? null : textBox3.Text.Trim();
            string storeId = comboBox1.SelectedItem == null ? null : comboBox1.SelectedItem.ToString();
            string sellId = string.IsNullOrWhiteSpace(textBox4.Text) ? null : textBox4.Text.Trim();

            DataTable result = SearchSellRecords(carPlate, customerNIF, storeId, sellId);
            if (result.Rows.Count > 0)
            {
                QueryResult queryResultForm = new QueryResult(result);
                queryResultForm.ShowDialog(); 
            }
            else
            {
                MessageBox.Show("Nenhuma venda encontrada.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private DataTable SearchSellRecords(string carPlate, string customerNIF, string storeId, string sellId)
        {
            const string query = "SearchSell";

            using (SqlCommand cmd = new SqlCommand(query, main_database_connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@CarPlate", SqlDbType.VarChar) { Value = (object)carPlate ?? DBNull.Value });
                cmd.Parameters.Add(new SqlParameter("@CustomerNIF", SqlDbType.BigInt) { Value = string.IsNullOrEmpty(customerNIF) ? DBNull.Value : Convert.ToInt64(customerNIF) });
                cmd.Parameters.Add(new SqlParameter("@StoreID", SqlDbType.Int) { Value = string.IsNullOrEmpty(storeId) ? DBNull.Value : Convert.ToInt32(storeId) });
                cmd.Parameters.Add(new SqlParameter("@SellID", SqlDbType.Int) { Value = string.IsNullOrEmpty(sellId) ? DBNull.Value : Convert.ToInt32(sellId) });

                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable resultTable = new DataTable();
                    try
                    {
                        adapter.Fill(resultTable);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao executar a pesquisa: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    return resultTable;
                }
            }
        }
    }
}