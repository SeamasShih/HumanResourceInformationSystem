using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        private MySqlConnection conn;

        public SQLConnection()
        {
            // create connection via connection string
            string connectionString = String.Format("Database={0};Data Source={1};User Id={2};Password={3}", db, server, user, pass);
            conn = new MySqlConnection(connectionString);
        }

        //Close reader
        public void closeReader(MySqlDataReader rdr)
        {
            if (rdr != null)
            {
                rdr.Close();
            }
        }

        //Close Connection
        public void closeConnection(MySqlConnection conn)
        {
            if (conn != null)
            {
                conn.Close();
            }
        }

        // static function start hear

    }
}
