using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace GUI
{
    class Connection
    {
        static string server = "127.0.0.1;";
        static string database = "test;";
        static string Uid = "kenneth;";
        static string password = "test123;";

        public static MySqlConnection connMaster;

        public static MySqlConnection DataSource()
        {
            connMaster = new MySqlConnection($"server={server} database ={database} Uid= {Uid} password={password}");
            return connMaster;

        }
        public void connOpen()
        {
            DataSource();
            connMaster.Open();
        }
        public void connClose()
        {
            DataSource();
            connMaster.Close();
        }

    }
}
