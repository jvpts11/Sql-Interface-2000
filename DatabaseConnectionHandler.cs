using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace Sql_Interactor
{
    internal class DatabaseConnectionHandler
    {

        private static DatabaseConnectionHandler instance;
        private SqlConnection connection;
        private static readonly object _lock = new object();
        private readonly string connectionString = @"Data Source=DESKTOP-OND0HNG;Initial Catalog=JJJ_International;Integrated Security=True;Trust Server Certificate=True";

        private DatabaseConnectionHandler()
        {
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
                MessageBox.Show("Connection stablished with success","Connection to database",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Connection failed due to: {ex.Message}", "Connection to database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static DatabaseConnectionHandler GetInstance() 
        { 
            if(instance == null)
            {
                lock(_lock)
                {
                    if(instance == null)
                    {
                        instance = new DatabaseConnectionHandler();
                    }
                }
            }
            return instance;
        }

        public SqlConnection GetConnection()
        {
            if(connection == null|| connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
            return connection;
        }

        public void CloseConnection()
        {
            if(connection != null || connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
                MessageBox.Show("Connection closed.", "Connection to database", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
