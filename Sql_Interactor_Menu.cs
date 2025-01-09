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
            var dbInstance = DatabaseConnectionHandler.GetInstance();
            connection = dbInstance.GetConnection();

            string welcome_name = "Welcome " + worker.F_Name + " " + worker.L_Name;

            Label_Welcome.Text = welcome_name;

            if (worker.Function == Functions.Seller || worker.Function == Functions.Cleaner)
            {
                carAddModelToolStripMenuItem.Visible = false;
                carRegisterToolStripMenuItem.Visible = false;
                batchRegisterToolStripMenuItem.Visible = false;
                transportationToolStripMenuItem.Visible = false;
                warehousesToolStripMenuItem.Visible = false;
                storesToolStripMenuItem.Visible = false;
                employeeToolStripMenuItem.Visible = false;
                projectToolStripMenuItem.Visible = false;

            }
            else if (worker.Function == Functions.Stock_worker)
            {
                clientToolStripMenuItem.Visible = false;
                sellToolStripMenuItem.Visible = false;
                transportationToolStripMenuItem.Visible = false;
                warehousesToolStripMenuItem.Visible = false;
                storesToolStripMenuItem.Visible = false;
                employeeToolStripMenuItem.Visible = false;
                projectToolStripMenuItem.Visible = false;
            }
            else if (worker.Function == Functions.Stock_manager)
            {
                clientToolStripMenuItem.Visible = false;
                sellToolStripMenuItem.Visible = false;
                transportationRegisterEntryToolStripMenuItem.Visible = false;
                transportationRegisterTransportToolStripMenuItem.Visible = false;
                warehousesToolStripMenuItem.Visible = false;
                storesToolStripMenuItem.Visible = false;
                projectToolStripMenuItem.Visible = false;
            }else if (worker.Function == Functions.Store_manager)
            {
                clientToolStripMenuItem.Visible = false;
                sellToolStripMenuItem.Visible = false;
                batchToolStripMenuItem.Visible = false;
                transportationRegisterEntryToolStripMenuItem.Visible = false;
                transportationRegisterTransportToolStripMenuItem.Visible = false;
                transportationListEntriesToolStripMenuItem.Visible = false;
                warehousesToolStripMenuItem.Visible = false;
                storesToolStripMenuItem.Visible = false;
                projectToolStripMenuItem.Visible = false;
            }else if (worker.Function == Functions.Logistics_manager)
            {
                clientToolStripMenuItem.Visible = false;
                sellToolStripMenuItem.Visible = false;
                warehousesAddToolStripMenuItem.Visible = false;
                storesToolStripMenuItem.Visible = false;
                projectToolStripMenuItem.Visible = false;
            }else if (worker.Function == Functions.Engineer)
            {
                warehousesAddToolStripMenuItem.Visible = false;
                storesToolStripMenuItem.Visible = false;
                projectToolStripMenuItem.Visible = false;
                transportationRegisterEntryToolStripMenuItem.Visible = false;
                transportationRegisterTransportToolStripMenuItem.Visible = false;
                batchRegisterToolStripMenuItem.Visible = false;
            }

            Console.WriteLine("Menu Initialized");
        }

        private void Sql_Interactor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                workers_database_connection.Close();
                if (connection != null)
                {
                    connection.Close();
                }

                Application.Exit();
            }
        }

        private string GetTableName(string query)
        {
            string[] words = query.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int index = Array.IndexOf(words, "FROM");
            if (index >= 0 && index < words.Length - 1)
            {
                return words[index + 1];
            }
            return string.Empty;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DialogResult r = MessageBox.Show("Are you sure you want to exit the program?", "Sql Interactor 2000", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (r == DialogResult.OK)
            {
                workers_database_connection.Close();
                if (connection != null)
                {
                    connection.Close();
                }

                Application.Exit();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sql Interactor by João Tavares, José Lima and João Manuel ", "Sql Interactor 2000", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Button_See_Sells_Click(object sender, EventArgs e)
        {
            if (connection != null)
            {
                try
                {
                    string query = "Select * from Sell";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    Data_grid_Menu.DataSource = dt;

                    label_Table_Name.Text = GetTableName(query);
                    Console.WriteLine("Query performed: " + query);

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error performing operation, error: " + ex.Message);
                    MessageBox.Show("Error loading data. ", "Sql Interactor 2000", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Can't perform operation. ", "Sql Interactor 2000", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Button_See_Clients_Click(object sender, EventArgs e)
        {
            if (connection != null)
            {
                try
                {
                    string query = "Select * from Customer";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    Data_grid_Menu.DataSource = dt;

                    string tablename = GetTableName(query);

                    label_Table_Name.Text = tablename;
                    Console.WriteLine("Query performed: " + query);

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error performing operation, error: " + ex.Message);
                    MessageBox.Show("Error loading data. ", "Sql Interactor 2000", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Can't perform operation. ", "Sql Interactor 2000", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Button_Insurance_Click(object sender, EventArgs e)
        {
            if (connection != null)
            {
                try
                {
                    string query = "Select * from InsuranceContract";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    Data_grid_Menu.DataSource = dt;

                    string tablename = GetTableName(query);

                    label_Table_Name.Text = tablename;
                    Console.WriteLine("Query performed: " + query);

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error performing operation, error: " + ex.Message);
                    MessageBox.Show("Error loading data. ", "Sql Interactor 2000", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Can't perform operation. ", "Sql Interactor 2000", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Button_Simulations_Click(object sender, EventArgs e)
        {
            if (connection != null)
            {
                try
                {
                    string query = "Select * from Simulation";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    Data_grid_Menu.DataSource = dt;

                    string tablename = GetTableName(query);

                    label_Table_Name.Text = tablename;
                    Console.WriteLine("Query performed: " + query);

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error performing operation, error: " + ex.Message);
                    MessageBox.Show("Error loading data. ", "Sql Interactor 2000", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Can't perform operation. ", "Sql Interactor 2000", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Button_See_Manufacturers_Click(object sender, EventArgs e)
        {
            if (connection != null)
            {
                try
                {
                    string query = "Select * from Manufacturer";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    Data_grid_Menu.DataSource = dt;

                    string tablename = GetTableName(query);

                    label_Table_Name.Text = tablename;
                    Console.WriteLine("Query performed: " + query);

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error performing operation, error: " + ex.Message);
                    MessageBox.Show("Error loading data. ", "Sql Interactor 2000", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Can't perform operation. ", "Sql Interactor 2000", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Button_See_Stores_Click(object sender, EventArgs e)
        {
            if (connection != null)
            {
                try
                {
                    string query = "Select * from Store";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    Data_grid_Menu.DataSource = dt;

                    string tablename = GetTableName(query);

                    label_Table_Name.Text = tablename;
                    Console.WriteLine("Query performed: " + query);

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error performing operation, error: " + ex.Message);
                    MessageBox.Show("Error loading data. ", "Sql Interactor 2000", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Can't perform operation. ", "Sql Interactor 2000", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
