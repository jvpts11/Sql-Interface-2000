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
    public partial class Sql_Interactor_Login_Screen : Form
    {
        private SqlConnection workers_database_connection = new SqlConnection(@"Data Source=DESKTOP-OND0HNG;Initial Catalog=JJJ_International_Workers;Integrated Security=True;Trust Server Certificate=True");

        public Sql_Interactor_Login_Screen()
        {
            InitializeComponent();
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            String user_id, birth_date, f_name, l_name;
            Functions function;
            user_id = textBox_User_Id.Text;
            birth_date = textBox_Password.Text;

            try
            {
                string loginQuerry = "Select W_id, F_Name, L_Name, Birth_Date, FunctionF_Id from Worker where W_Id = '"+textBox_User_Id.Text+"' and Birth_Date = '"+textBox_Password.Text+ "'";
                SqlDataAdapter adapter = new SqlDataAdapter(loginQuerry, workers_database_connection);

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if(dt.Rows.Count > 0 )
                {
                    DataRow row = dt.Rows[0];
                    user_id = textBox_User_Id.Text;
                    f_name = row["F_Name"].ToString();
                    l_name = row["L_Name"].ToString();
                    birth_date = textBox_Password.Text;
                    function = (Functions)row["FunctionF_Id"];

                    Worker w = new Worker(int.Parse(user_id), f_name, l_name, DateTime.Parse(birth_date), function);
                    

                    Sql_Interactor_Menu menu = new Sql_Interactor_Menu(w, workers_database_connection);
                    menu.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid login" + ex.Message);
            }
        }

        private void button_Clear_Text_Click(object sender, EventArgs e)
        {
            
        }
    }
}
