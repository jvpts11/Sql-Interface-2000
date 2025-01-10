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
    public partial class DeleteClient : Form
    {
        SqlConnection main_database_connection;

        public DeleteClient(SqlConnection main_database_connection)
        {
            InitializeComponent();
            this.main_database_connection = main_database_connection;
        }

        private void button_Delete_Customer_Click(object sender, EventArgs e)
        {
            try
            {
                long customer_id = long.Parse(textBox_Customer_Id_Number.Text);

                using (SqlCommand cmd = new SqlCommand("DeleteCustomer", main_database_connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@NIF", customer_id);

                    if (main_database_connection.State != ConnectionState.Open)
                    {
                        main_database_connection.Open();
                    }

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Client and it's registers where deleted from Database",
                        "Sql Interactor 2000", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Console.WriteLine("Client deleted from Database: " + customer_id);
                }   
            }
            catch (Exception ex)
            {
                Console.WriteLine("An unexpected error occurred: " + ex.Message);
            }
        }

        private void button_See_Customers_Click(object sender, EventArgs e)
        {
            string query = "Select NIF, F_Name, L_Name, CountryName from Customer\r\nJoin Country on Customer.CountryCountry_id = Country.Country_id";
            try
            {
                DataTable dt = new DataTable();
                using(SqlCommand cmd = new SqlCommand(query,main_database_connection))
                {

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
                QueryResult qr = new QueryResult(dt);
                qr.ShowDialog();
                Console.WriteLine("Query Executed: " + query);
            }
            catch(Exception ex)
            {
                Console.WriteLine("An Unexpected error occurred when querrying in Customer Table: "+ex.Message);
                MessageBox.Show("An unexpected error occurred.","Sql Interactor 2000", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

        private void button_Search_Customer_Click(object sender, EventArgs e)
        {
            CustomerSearchBy search = new CustomerSearchBy(main_database_connection);
            search.Show();
        }
    }
}
