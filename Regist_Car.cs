using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
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
            if (main_database_connection != null)
            {
                string query = "SELECT Car_Model_Id, Model_Name FROM CarModel";
                SqlDataAdapter adapter = new SqlDataAdapter(query, main_database_connection);
                DataTable dt = new DataTable();

                try
                {
                    adapter.Fill(dt);

                    // Configurar o DataSource para associar IDs aos nomes
                    comboBox1.DataSource = dt;
                    comboBox1.DisplayMember = "Model_Name"; // O nome exibido na ComboBox
                    comboBox1.ValueMember = "Car_Model_Id"; // O ID associado ao nome
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
            //dar display às CarColors na comboBox
            if (main_database_connection != null)
            {
                string query = "SELECT Car_color_id, Color_Name FROM CarColor";
                SqlDataAdapter adapter = new SqlDataAdapter(query, main_database_connection);
                DataTable dt = new DataTable();
                try
                {
                    adapter.Fill(dt);

                    // Configurar o DataSource para associar IDs aos nomes
                    comboBox2.DataSource = dt;
                    comboBox2.DisplayMember = "Color_Name"; // Nome exibido na ComboBox
                    comboBox2.ValueMember = "Car_color_id"; // ID associado ao nome
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Could not load car colors: " + ex.Message, "Error");
                }
            }
            else
            {
                MessageBox.Show("Database connection is not initialized.", "Error");
            }

            //display aos anos
            for (int i = 1950; i <= 2025; i++)
            {
                comboBox3.Items.Add(i);
            }
        }

        private void Regist_Car_Button_Click(object sender, EventArgs e)
        {
            // Validar a matrícula
            string carPlate = textBox1.Text;
            if (carPlate.Length > 9)
            {
                MessageBox.Show("Invalid Car Plate. Please ensure it is 9 characters or fewer.", "Sql Interactor 2000");
                return;
            }

            // Verificar se o modelo do carro é válido
            string carModel = comboBox1.Text;
            if (!IsCarModelValid(carModel))
            {
                MessageBox.Show("Invalid Car Model. Please select a valid model from the list.", "Sql Interactor 2000");
                return;
            }

            // Verificar se a cor do carro é válida
            string carColor = comboBox2.Text;
            if (!IsCarColorValid(carColor))
            {
                MessageBox.Show("Invalid Car Color. Please select a valid color from the list.", "Sql Interactor 2000");
                return;
            }

            // Validar o ano do carro
            string carYearText = comboBox3.Text;
            if (!int.TryParse(carYearText, out int carYear) || carYear < 1950 || carYear > 2025)
            {
                MessageBox.Show("Invalid Car Year. Please select a valid year.", "Sql Interactor 2000");
                return;
            }

            // Obter os IDs do modelo e da cor
            int carModelId = GetCarModelId(carModel);
            int carColorId = GetCarColorId(carColor);

            if (carModelId == -1 || carColorId == -1)
            {
                MessageBox.Show("Failed to retrieve IDs for model or color. Please try again.", "Sql Interactor 2000");
                return;
            }

            // Inserir os dados no banco de dados
            InsertCarData(carPlate, carYear, carColorId, carModelId);
        }

        // Função para verificar se o car_model é válido
        private bool IsCarModelValid(string carModel)
        {
            string query = "SELECT COUNT(*) FROM CarModel WHERE Model_Name = @Model_Name";

            using (SqlCommand command = new SqlCommand(query, main_database_connection))
            {
                command.Parameters.AddWithValue("@Model_Name", carModel);
                int count = (int)command.ExecuteScalar();
                return count > 0;
            }
        }

        // Função para verificar se a car_color é válida
        private bool IsCarColorValid(string carColor)
        {
            string query = "SELECT COUNT(*) FROM CarColor WHERE Color_Name = @Color_Name";

            using (SqlCommand command = new SqlCommand(query, main_database_connection))
            {
                command.Parameters.AddWithValue("@Color_Name", carColor);
                int count = (int)command.ExecuteScalar();
                return count > 0;
            }
        }

        // Obter o ID do modelo de carro com base no nome
        private int GetCarModelId(string carModel)
        {
            string query = "SELECT Car_Model_Id FROM CarModel WHERE Model_Name = @Model_Name";

            using (SqlCommand command = new SqlCommand(query, main_database_connection))
            {
                command.Parameters.AddWithValue("@Model_Name", carModel);
                object result = command.ExecuteScalar();
                return result != null ? Convert.ToInt32(result) : -1;
            }
        }

        // Obter o ID da cor do carro com base no nome
        private int GetCarColorId(string carColor)
        {
            string query = "SELECT Car_color_id FROM CarColor WHERE Color_Name = @Color_Name";

            using (SqlCommand command = new SqlCommand(query, main_database_connection))
            {
                command.Parameters.AddWithValue("@Color_Name", carColor);
                object result = command.ExecuteScalar();
                return result != null ? Convert.ToInt32(result) : -1;
            }
        }

        //função para inserir car
        private void InsertCarData(string carPlate, int carYear, int carColorId, int carModelId)
        {
            // converter year(int) to (date)
            string carYearAsDate = $"{carYear}-01-01";

            string query = "INSERT INTO Car (Car_Plate, Car_Year, CarColorCar_color_id, CarModelCar_Model_Id) " +
                           "VALUES (@CarPlate, @CarYear, @CarColorId, @CarModelId)";

            using (SqlCommand command = new SqlCommand(query, main_database_connection))
            {
                command.Parameters.AddWithValue("@CarPlate", carPlate);
                command.Parameters.AddWithValue("@CarYear", carYearAsDate);
                command.Parameters.AddWithValue("@CarColorId", carColorId);
                command.Parameters.AddWithValue("@CarModelId", carModelId);

                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Car registered successfully!", "Sql Interactor 2000");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while registering the car: {ex.Message}", "Error");
                }
            }
        }
    }
}

