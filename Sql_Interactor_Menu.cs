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
        public Sql_Interactor_Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dbInstance = DatabaseConnectionHandler.GetInstance();
            SqlConnection connection = dbInstance.GetConnection();
        }
    }
}
