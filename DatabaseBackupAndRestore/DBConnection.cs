using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace DatabaseBackupAndRestore
{
    public static class DBConnection
    {
        private static String SERVER;
        private static String DATABASE;
        private static String USERNAME;
        private static String PASSWORD;

        public static void SetConnection(string server, string database, string username, string password) {
            SERVER = server; DATABASE = database; USERNAME = username; PASSWORD = password;
        }

        private static void Connect(out MySqlConnection con)
        {
            try
            {
                MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
                builder.Server = SERVER;
                builder.UserID = USERNAME;
                builder.Password = PASSWORD;
                builder.Database = DATABASE;
                builder.SslMode = MySqlSslMode.None;

                String connString = builder.ToString();
                builder = null;

                Console.WriteLine(connString);
                con = new MySqlConnection(connString);
            }
            catch (Exception ex)
            {
                Console.WriteLine("DBConnection | Caught an exception while executing Connect() : " + ex);
                con = null;
            }
        }

        public static MySqlConnection GetConnection()
        {
            MySqlConnection newcon = null;
            Connect(out newcon);
            return newcon;

        }
    }
}
