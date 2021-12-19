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
        public static MySqlConnection connMaster;

        public static MySqlConnection DataSource()
        {
            connMaster = new MySqlConnection($"datasource=kompetenzdatenbank.mysql.database.azure.com;port=3306;username=kompetenzdb@kompetenzdatenbank;password=Kompetenz2021;database=kompetenzdb");
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
