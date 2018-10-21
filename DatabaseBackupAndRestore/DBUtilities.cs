using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseBackupAndRestore
{
    public static class DBUtilities
    {
        private static MySqlConnection con;

        public static bool BackupDatabase(string file)
        {
            Console.WriteLine(file);
            try
            {
                using (con = DBConnection.GetConnection())
                {
                    using (MySqlCommand com = new MySqlCommand())
                    {
                        using (MySqlBackup backup = new MySqlBackup(com))
                        {
                            com.Connection = con;
                            if (con.State.ToString() == "Closed")
                                con.Open();
                            backup.ExportToFile(file);
                            con.Close();
                            return true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Utilities | Caught an exception while executing BackupDatabase(" + file + ") : " + ex);
                return false;
            }
        }

        public static bool RestoreDatabase(string file)
        {
            Console.WriteLine(file);
            try
            {
                using (con = DBConnection.GetConnection())
                {
                    using (MySqlCommand com = new MySqlCommand())
                    {
                        using (MySqlBackup backup = new MySqlBackup(com))
                        {
                            com.Connection = con;
                            if (con.State.ToString() == "Closed")
                                con.Open();
                            backup.ImportFromFile(file);
                            con.Close();
                            return true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Utilities | Caught an exception while executing RestoreDatabase(" + file + ") : " + ex);
                return false;
            }
        }
    }
}
