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
        SqlConnection main_database_connection;

        protected class Client
        {
            public long nif;
            public string firstName;
            public string lastName;
            public int income;
            public string postalCode;
            public int countryId;

            public Client(long nif, string firstName, string lastName, int income, string postalCode, int countryId)
            {
                this.nif = nif;
                this.firstName = firstName;
                this.lastName = lastName;
                this.income = income;
                this.postalCode = postalCode;
                this.countryId = countryId;
            }
        }

        public Add_Client(SqlConnection workers_database_connection, SqlConnection main_database_connection)
        {
            InitializeComponent();
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
                    string query = @"Select Postal_Code from dbo.PostalCode 
                                    Join JJJ_International_Workers.dbo.[Postal Code] on [Postal Code].PC=Postal_Code";
                    SqlDataAdapter adapter = new SqlDataAdapter(query,main_database_connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    QueryResult queryresult = new QueryResult(dt);
                    queryresult.ShowDialog();
                }
                catch (Exception ex) 
                {
                    Console.Write("Could not execute query due to error: "+ex.Message);
                }
            }
        }

        private void button_Add_Client_Click(object sender, EventArgs e)
        {
            try
            {
                string postal_code = textBox_Postal_Code.Text;
                int country_id = GetCountryIdByPostalCode(postal_code);

                if(country_id == -1)
                {
                    string countryName = PromptForCountryName();
                    if (string.IsNullOrWhiteSpace(countryName))
                    {
                        MessageBox.Show("Country name is needed in order to insert postal code","Sql Interactor 2000");
                        return;
                    }

                    country_id = InsertCountry(countryName);
                    InsertPostalCode(postal_code, country_id);
                }

                Client client = new Client(
                    long.Parse(textBox_Client_Id_Number.Text),
                    textBox_Client_First_Name.Text,
                    textBox_Client_Last_Name.Text,
                    int.Parse(textBox_Declared_Income.Text),
                    postal_code,
                    country_id);

                insertClient(client);

            }catch(Exception ex) 
            {
                Console.WriteLine("Could not insert client due to error: " + ex.Message);
            }
            
        }

        private int GetCountryIdByPostalCode(string postalCode)
        {
            string query = @"
                SELECT CountryCountry_id 
                FROM PostalCode
                JOIN [Address] ON PostalCode.Postal_Code = Address.PostalCodePostal_Code
                WHERE PostalCode.Postal_Code = @PostalCode";

            using (SqlCommand cmd = new SqlCommand(query, main_database_connection))
            {
                cmd.Parameters.AddWithValue("@PostalCode", postalCode);
                object result = cmd.ExecuteScalar();
                return result != null ? Convert.ToInt32(result) : -1;
            }
        }

        private string PromptForCountryName()
        {
            return Microsoft.VisualBasic.Interaction.InputBox(
                "The Postal code isn't associated with any country, please insert Country name:",
                "Insert Country name",
                "");
        }

        private int InsertCountry(string countryName)
        {
            // Verifica se o país já existe
            string checkCountryQuery = "SELECT Country_Id FROM Country WHERE CountryName = @CountryName";
            using (SqlCommand checkCmd = new SqlCommand(checkCountryQuery, main_database_connection))
            {
                checkCmd.Parameters.AddWithValue("@CountryName", countryName);
                object result = checkCmd.ExecuteScalar();

                if (result != null)
                {
                    // Se o país já existir, retorna o ID encontrado
                    Console.WriteLine("Country already exists: " + countryName);
                    return Convert.ToInt32(result);
                }
            }

            // Obter o último Country_Id
            string getCountryIdQuery = "SELECT TOP 1 Country_Id FROM Country ORDER BY Country_Id DESC";
            int lastCountryId = 1; // Valor padrão para o primeiro ID, caso a tabela esteja vazia

            using (SqlCommand getIdCmd = new SqlCommand(getCountryIdQuery, main_database_connection))
            {
                object result = getIdCmd.ExecuteScalar();
                if (result != null)
                {
                    lastCountryId = Convert.ToInt32(result) + 1;
                }
            }

            string insertCountryQuery = "INSERT INTO Country (Country_id,CountryName) VALUES(@Country_Id, @CountryName)";
            using(SqlCommand cmd = new SqlCommand(insertCountryQuery, main_database_connection))
            {
                cmd.Parameters.AddWithValue("@Country_Id",lastCountryId);
                cmd.Parameters.AddWithValue("@CountryName",countryName);
                Console.WriteLine("Inserted country: " + lastCountryId + ", " + countryName);
                return (int)cmd.ExecuteScalar();
            }
        }

        private string promptForAddressline()
        {
            return Microsoft.VisualBasic.Interaction.InputBox(
                "Insert Postal code Address line:",
                "Insert Address Line",
                "");
        }

        private string promptForLocation()
        {
            return Microsoft.VisualBasic.Interaction.InputBox(
                "Insert Postal Code's city:",
                "Insert City",
                "");
        }

        private void InsertPostalCode(string postalCode, int countryId)
        {
            string address = promptForAddressline();
            string location = promptForLocation();
            string insertPostalCodeQuery = "Insert into PostalCode(Postal_Code,[Location]) Values(@PostalCode,@Location)";
            string insertAddressQuery = "Insert into [Address](CountryCountry_id,PostalCodePostal_Code,AddressLine) Values(@CountryId,@PostalCode,@Address)";

            using (SqlCommand cmd = new SqlCommand(insertPostalCodeQuery,main_database_connection))
            {
                cmd.Parameters.AddWithValue("@PostalCode",postalCode);
                cmd.Parameters.AddWithValue("@Location",location);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Inserted postal code: " + postalCode + ", " + location);
            }

            using(SqlCommand cmd = new SqlCommand(insertAddressQuery,main_database_connection))
            {
                cmd.Parameters.AddWithValue("@CountryId",countryId);
                cmd.Parameters.AddWithValue("@PostalCode",postalCode);
                cmd.Parameters.AddWithValue("@Address",address);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Inserted Address: " + countryId + ", " + postalCode + ", " + address);
            }
        }

        private void insertClient(Client client)
        {

            if (DoesClientExist(client.nif))
            {
                MessageBox.Show($"Client with NIF {client.nif} already exists in the database.", "Sql Interactor 2000", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlCommand cmd = new SqlCommand("InsertCustomer", main_database_connection))
            {

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@NIF", client.nif);
                cmd.Parameters.AddWithValue("@F_Name", client.firstName);
                cmd.Parameters.AddWithValue("@L_Name", client.lastName);
                cmd.Parameters.AddWithValue("@Income", client.income);
                cmd.Parameters.AddWithValue("@PostalCode", client.postalCode);
                cmd.Parameters.AddWithValue("@CountryID",  client.countryId);
                cmd.ExecuteNonQuery();

                Console.WriteLine("Customer inserted \nIdNumber: " + client.nif + "\nFirst Name: " + client.firstName + "\nLast Name: " + client.lastName + "\nIncome: "+ client.income+"\nCountry id: " + client.countryId);
                MessageBox.Show("Client added with success.","Sql Interactor 2000",MessageBoxButtons.OK);
            }
        }

        private bool DoesClientExist(long nif)
        {
            string query = "SELECT COUNT(*) FROM Customer WHERE NIF = @NIF";

            using (SqlCommand cmd = new SqlCommand(query, main_database_connection))
            {
                cmd.Parameters.AddWithValue("@NIF", nif);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }
    }
}
