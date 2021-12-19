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
        // Für das Erstellen einer Connection mit MýSQL
        public static MySqlConnection connMaster;
        /// <summary>
        /// Die Connection wird mit dem beliebigen Datenbank verbunden nämlich hier der Fall mit Azure Datenbank
        /// </summary>
        /// <returns></returns>
        public static MySqlConnection DataSource()
        {
            connMaster = new MySqlConnection($"datasource=kompetenzdatenbank.mysql.database.azure.com;port=3306;username=kompetenzdb@kompetenzdatenbank;password=Kompetenz2021;database=kompetenzdb");
            return connMaster;

        }
        // Connection wird mit dieser Methode geöffnet
        public void connOpen()
        {
            DataSource();
            connMaster.Open();
        }
        // Connection wird mit dieser Methode geschlossen
        public void connClose()
        {
            DataSource();
            connMaster.Close();
        }

    }
}
