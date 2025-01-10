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
    public partial class Regist_Car_Model : Form
    {
        SqlConnection workers_database_connection, main_database_connection;

        public Regist_Car_Model(SqlConnection workers_database_connection, SqlConnection main_database_connection)
        {
            InitializeComponent();
            this.workers_database_connection = workers_database_connection;
            this.main_database_connection = main_database_connection;
        }

        private void Regist_Car_Model_Load(object sender, EventArgs e)
        {
            //dar display ás manufactores na comboBox
            if (main_database_connection != null)
            {
                string query = "SELECT F_id, F_name FROM Manufacturer";
                SqlDataAdapter adapter = new SqlDataAdapter(query, main_database_connection);
                DataTable dt = new DataTable();

                try
                {
                    adapter.Fill(dt);

                    // Configurar o DataSource para associar IDs aos nomes
                    comboBox1.DataSource = dt;
                    comboBox1.DisplayMember = "F_name"; // O nome exibido na ComboBox
                    comboBox1.ValueMember = "F_id"; // O ID associado ao nome
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Could not load car models: " + ex.Message, "Error");
                }
            }
            else
            {
                MessageBox.Show("Database connection is not initialized.", "Error");
            }

           
        }

        private void Add_Car_Model_Button_Click(object sender, EventArgs e)
        {
            // Verificar se a manufacter é valida
            string manufactorName = comboBox1.Text;
            if (!IsManufactorValid(manufactorName))
            {
                MessageBox.Show("Invalid Car Model. Please select a valid model from the list.", "Sql Interactor 2000");
                return;
            }
        }

        //funçao para verificar
        private bool IsManufactorValid(string manufactor)
        {
            string query = "SELECT COUNT(*) FROM Manufacturer WHERE F_name = @F_name";

            using (SqlCommand command = new SqlCommand(query, main_database_connection))
            {
                command.Parameters.AddWithValue("@F_name", manufactor);
                int count = (int)command.ExecuteScalar();
                return count > 0;
            }
        }
    }
}
