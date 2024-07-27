using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CAAP_ADMIN
{
    internal class ConnectDB
    {

        public string server = "localhost";
        public string database = "db_caap";
        public string username = "root";
        public string password = "";

        public MySqlConnection conn;

        public bool Connect()
        {
            try
            {
                string connectionString = $"Server={server};UserID={username};Password={password};Database={database}";
                conn = new MySqlConnection(connectionString);
                conn.Open();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Failed: " + ex.Message);
                return false;
            }
        }

    }
}
