using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HumanResourceInformationSystem.EntityClasses;

namespace HumanResourceInformationSystem.Adapter
{
    public class DatabaseAdapter
    {
        // create static function in here
        //datebase information
        private const string db = "kit206";
        private const string user = "kit206";
        private const string pass = "kit206";
        private const string server = "alacritas.cis.utas.edu.au";

        private static MySqlConnection conn;

        private static void SQLConnection()
        {
            // create connection via connection string
            string connectionString = String.Format("Database={0};Data Source={1};User Id={2};Password={3}", db, server, user, pass);
            conn = new MySqlConnection(connectionString);
        }

        //Close reader
        private static void CloseReader(MySqlDataReader rdr)
        {
            if (rdr != null)
            {
                rdr.Close();
            }
        }

        //Close Connection
        public static void CloseConnection(MySqlConnection conn)
        {
            if (conn != null)
            {
                conn.Close();
            }
        }

        // static function start hear
        
        // Retrieve Staff list information from Database
        public static List<Staff> RetrieveStaffList()
        {
            SQLConnection();
            MySqlDataReader rdr = null;
            List<Staff> staffs = new List<Staff>();

            try
            {
                // Open the connection
                conn.Open();
                // 1. Instantiate a new command with a query and connection
                MySqlCommand cmd = new MySqlCommand("select id, given_name, family_name, title, category from staff", conn);
                // 2. Call Execute reader to get query results
                rdr = cmd.ExecuteReader();
                // print the CategoryName of each record
                while (rdr.Read())
                {
                    Staff staff = new Staff(rdr.GetInt32(0), rdr.GetString(1), rdr.GetString(2), rdr.GetString(3), (Category) Enum.Parse(typeof(Category) ,rdr.GetString(4)));
                    Console.WriteLine("Retrive from database: " + staff);
                    staffs.Add(staff);
                }
            }
            finally
            {
                // close the reader
                CloseReader(rdr);
                // Close the connection
                CloseConnection(conn);
            }

            return staffs;
        }
    }
}
