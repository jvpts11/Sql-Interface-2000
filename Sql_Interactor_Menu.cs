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
    
    public partial class Sql_Interactor_Menu : Form
    {
        Worker worker;
        SqlConnection workers_database_connection, connection;

        public Sql_Interactor_Menu(Worker user, SqlConnection workers_database_connection)
        {
            InitializeComponent();
            worker = user;
            this.workers_database_connection = workers_database_connection;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dbInstance = DatabaseConnectionHandler.GetInstance();
            connection = dbInstance.GetConnection();
        }

        private void Sql_Interactor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            {
                workers_database_connection.Close();
                if(connection != null)
                {
                    connection.Close();
                }

                Application.Exit();
            }
        }
    }
}
