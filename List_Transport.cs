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
    public partial class List_Transport : Form
    {
        SqlConnection workers_database_connection, main_database_connection;

        public List_Transport(SqlConnection workers_database_connection, SqlConnection main_database_connection)
        {
            InitializeComponent();
            this.workers_database_connection = workers_database_connection;
            this.main_database_connection = main_database_connection;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadEntries();
        }

        private void LoadEntries()
        {
            try
            {
                string query = @"
                    SELECT 
                        te.Entry_id AS 'Entry ID',
                        t.T_Register AS 'Transport Register',
                        p.Product_Name AS 'Product Name',
                        te.Quantity AS 'Quantity'
                    FROM 
                        TransportEntry te
                    INNER JOIN 
                        T_Register t ON te.TransportT_id = t.T_id
                    INNER JOIN 
                        Products p ON te.Product_id = p.Product_id";
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, main_database_connection))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    QueryResult queryResultForm = new QueryResult(dt);
                    queryResultForm.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading entries: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
