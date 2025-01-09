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
    public partial class QueryResult : Form
    {
        public QueryResult(DataTable queryResult)
        {
            InitializeComponent();
            Data_grid_Query_Result.DataSource = queryResult;
        }

        private void QueryResult_Load(object sender, EventArgs e)
        {

        }

        private void QueryResult_Closing(object sender, EventArgs e) 
        {
            this.Dispose();
        }
    }
}
