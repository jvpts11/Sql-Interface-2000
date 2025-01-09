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

namespace Sql_Interactor
{
    public partial class Add_Client : Form
    {
        SqlConnection workers_database_connection, main_database_connection;

        public Add_Client(SqlConnection workers_database_connection, SqlConnection main_database_connection)
        {
            InitializeComponent();
            this.workers_database_connection = workers_database_connection;
            this.main_database_connection = main_database_connection;
        }

        private void Add_Client_Load(object sender, EventArgs e)
        {

        }

        private void button_See_Registered_Postal_Codes_Click(object sender, EventArgs e)
        {
            if (main_database_connection != null)
            {
                try
                {
                    string query = "Select Postal_Code from dbo.PostalCode\r\nJoin JJJ_International_Workers.dbo.[Postal Code] on [Postal Code].PC=Postal_Code";
                    SqlDataAdapter adapter = new SqlDataAdapter(query,main_database_connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    QueryResult queryresult = new QueryResult(dt);
                    queryresult.Show();
                }
                catch (Exception ex) 
                {
                    Console.Write("Could not execute query due to error: "+ex.Message);
                }
            }
        }

        private void button_Add_Client_Click(object sender, EventArgs e)
        {

        }
    }
}
