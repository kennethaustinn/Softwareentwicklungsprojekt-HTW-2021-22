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
            connMaster = new MySqlConnection($"server=kompetenzdb.mysql.database.azure.com; port=3306;username=neueadmin;password=Kompetenz_2021;database=kompetenzdb");
            return connMaster;

        }
        /// <summary>
        /// Connection wird mit dieser Methode geöffnet
        /// </summary>
        public void connOpen()
        {
            DataSource();
            connMaster.Open();
        }
        /// <summary>
        /// Connection wird mit dieser Methode geschlossen
        /// </summary>
        public void connClose()
        {
            DataSource();
            connMaster.Close();
        }

    }
}
