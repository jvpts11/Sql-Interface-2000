using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sql_Interactor
{
    public partial class Regist_Car : Form
    {
        SqlConnection workers_database_connection, main_database_connection;

        public Regist_Car(SqlConnection workers_database_connection, SqlConnection main_database_connection)
        {
            InitializeComponent();
            this.workers_database_connection = workers_database_connection;
            this.main_database_connection = main_database_connection;
        }

        private void Regist_Car_Load(object sender, EventArgs e)
        {
            //dar display aos CarModels na comboBox
            if (workers_database_connection != null)
            {
                string query = "Select Model_Name from CarModel";
                SqlDataAdapter adapter = new SqlDataAdapter(query, main_database_connection);
                DataTable dt = new DataTable();
                try
                {
                    adapter.Fill(dt);
                    foreach (DataRow row in dt.Rows)
                    {
                        comboBox1.Items.Add(row["Model_Name"]);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Couldnt load car models"+ex.Message);
                }
            }
            //dar display às CarColors na comboBox
            if (workers_database_connection != null)
            {
                string query = "Select Color_Name from CarColor";
                SqlDataAdapter adapter = new SqlDataAdapter(query, main_database_connection);
                DataTable dt = new DataTable();
                try
                {
                    adapter.Fill(dt);
                    foreach (DataRow row in dt.Rows)
                    {
                        comboBox2.Items.Add(row["Color_Name"]);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Couldnt load car colors"+ex.Message);
                }
            }
            //display aos anos
            for (int i = 1950; i <= 2025; i++)
            {
                comboBox3.Items.Add(i);
            }
        }

        private void Regist_Car_Button_Click(object sender, EventArgs e)
        {
            //filtrar matriculas para 9 digitos ou menos
            string car_plate = textBox1.Text;
            if (car_plate.Length > 9)
            {
                MessageBox.Show("Invalid Car Plate", "Sql Interactor 2000");
                return;
            }
            //verificar se modelo de carro é valido
            string car_model = comboBox1.Text;
            string query = "Select Model_Name from CarModel Where Nome = @Nome";

        }
    }
}
