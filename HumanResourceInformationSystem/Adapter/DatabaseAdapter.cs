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

        // Retrieve Staff Details information from Database
        public static List<StaffDetail> RetrieveStaffDetail()
        {
            SQLConnection();
            MySqlDataReader rdr = null;
            List<StaffDetail> _staffs = new List<StaffDetail>();

            try
            {
                // Open the connection
                conn.Open();
                // 1. Instantiate a new command with a query and connection
                MySqlCommand cmd = new MySqlCommand("select id, given_name, family_name, title, campus, phone, room, email, photo, category from staff", conn);
                // 2. Call Execute reader to get query results
                rdr = cmd.ExecuteReader();
                // print the CategoryName of each record
                while (rdr.Read())
                {
                    StaffDetail _staffDetail = new StaffDetail(rdr.GetInt32(0), rdr.GetString(1), rdr.GetString(2), rdr.GetString(3), (Campus)Enum.Parse(typeof(Campus), rdr.GetString(4)), rdr.GetString(5), rdr.GetString(6), rdr.GetString(7), rdr.GetString(8), (Category)Enum.Parse(typeof(Category), rdr.GetString(9)));
                    //Console.WriteLine("Retrive from database: " + _staffDetail);
                    _staffs.Add(_staffDetail);
                }
            }
            finally
            {
                // close the reader
                CloseReader(rdr);
                // Close the connection
                CloseConnection(conn);
            }

            return _staffs;
        }

        //get consultation hours
        public static List<Consultation> RetrieveConsultation()
        {
            SQLConnection();
            MySqlDataReader rdr = null;
            List<Consultation> _listConsulation = new List<Consultation>();

            try
            {
                // Open the connection
                conn.Open();
                // 1. Instantiate a new command with a query and connection
                MySqlCommand cmd = new MySqlCommand("select staff_id, day, start, end from consultation", conn);
                // 2. Call Execute reader to get query results
                rdr = cmd.ExecuteReader();
                // print the CategoryName of each record
                while (rdr.Read())
                {
                    Consultation _consultation = new Consultation(rdr.GetInt32(0), (DayOfWeek)Enum.Parse(typeof(DayOfWeek), rdr.GetString(1)), Convert.ToDateTime(rdr.GetString(2)), Convert.ToDateTime(rdr.GetString(3)));
                    _listConsulation.Add(_consultation);
                }
            }
            finally
            {
                // close the reader
                CloseReader(rdr);
                // Close the connection
                CloseConnection(conn);
            }

            return _listConsulation;
        }

        //get all class by staff ID
        public static List<Class> RetrieveClasses()
        {
            SQLConnection();
            MySqlDataReader rdr = null;
            List<Class> _listClasses = new List<Class>();

            try
            {
                // Open the connection
                conn.Open();
                // 1. Instantiate a new command with a query and connection
                MySqlCommand cmd = new MySqlCommand("select staff, day, start, end from class", conn);
                // 2. Call Execute reader to get query results
                rdr = cmd.ExecuteReader();
                // print the CategoryName of each record
                while (rdr.Read())
                {
                    Class _class = new Class(rdr.GetInt32(0), (Weekday)Enum.Parse(typeof(Weekday), rdr.GetString(1)), rdr.GetTimeSpan(2), rdr.GetTimeSpan(3));
                    _listClasses.Add(_class);
                }
            }
            finally
            {
                // close the reader
                CloseReader(rdr);
                // Close the connection
                CloseConnection(conn);
            }

            return _listClasses;
        }

        // get all units
        public static List<Unit> RetrieveUnits()
        {
            SQLConnection();
            MySqlDataReader rdr = null;
            List<Unit> _listUnits = new List<Unit>();

            try
            {
                // Open the connection
                conn.Open();
                // 1. Instantiate a new command with a query and connection
                MySqlCommand cmd = new MySqlCommand("select * from unit", conn);
                // 2. Call Execute reader to get query results
                rdr = cmd.ExecuteReader();
                // print the CategoryName of each record
                while (rdr.Read())
                {
                    Unit _unit = new Unit(rdr.GetString(0), rdr.GetString(1), rdr.GetInt32(2));
                    _listUnits.Add(_unit);
                }
            }
            finally
            {
                // close the reader
                CloseReader(rdr);
                // Close the connection
                CloseConnection(conn);
            }

            return _listUnits;
        }

        //get all classes under the certain unit.
        public static List<Class> RetrieveClassesByUnit(Unit unit)
        {
            SQLConnection();
            MySqlDataReader rdr = null;
            List<Class> listClasses = new List<Class>();

            try
            {
                // Open the connection
                conn.Open();
                // 1. Instantiate a new command with a query and connection
                MySqlCommand cmd = new MySqlCommand("select * from class where unit_code = '" + unit.Code + "'", conn);
                // 2. Call Execute reader to get query results
                rdr = cmd.ExecuteReader();
                // print the CategoryName of each record
                while (rdr.Read())
                {
                    Class _class = new Class(rdr.GetString(0), 
                        (Campus)Enum.Parse(typeof(Campus), rdr.GetString(1)),
                        (Weekday)Enum.Parse(typeof(Weekday), rdr.GetString(2)),
                        rdr.GetTimeSpan(3),
                        rdr.GetTimeSpan(4),
                        (UnitType)Enum.Parse(typeof(UnitType), rdr.GetString(5)),
                        rdr.GetString(6),
                        rdr.GetInt32(7),
                        RetrieveStaffNameByID(rdr.GetInt32(7)));
                    Console.WriteLine(_class.ToString());
                    listClasses.Add(_class);
                }
            }
            finally
            {
                // close the reader
                CloseReader(rdr);
                // Close the connection
                CloseConnection(conn);
            }

            return listClasses;
        }

        //get the specific staff's name by providing an id.
        //it is used for showing real name instead of an id in the class table
        private static string RetrieveStaffNameByID(int id)
        {
            SQLConnection();
            MySqlDataReader rdr = null;
            string staffName = "";

            try
            {
                // Open the connection
                conn.Open();
                // 1. Instantiate a new command with a query and connection
                MySqlCommand cmd = new MySqlCommand("select given_name, family_name, title from staff where id = '" + id + "'", conn);
                // 2. Call Execute reader to get query results
                rdr = cmd.ExecuteReader();
                // print the CategoryName of each record
                while (rdr.Read())
                {
                    staffName = String.Format("{0}, {1} ({2})", rdr.GetString(0), rdr.GetString(1), rdr.GetString(2));
                    Console.WriteLine(id + " " + staffName);
                }
            }
            finally
            {
                // close the reader
                CloseReader(rdr);
                // Close the connection
                CloseConnection(conn);
            }

            return staffName;
        }
    }
}
