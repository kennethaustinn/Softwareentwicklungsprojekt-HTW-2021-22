using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace SQLConnection
{
    class ConnectToDataBase
    {


        private string connectionString;
        private List<string[]> informationenList = new List<string[]>(); // {"22"  , "zak"}

        // class mitarbeirt : vornme , .......
        public ConnectToDataBase() // connect to server 
        {
            Console.WriteLine("Versuchen zu verbinden mit der Datenbank: 127.0.0.1:3306 mit der User root");
            this.connectionString = "datasource=127.0.0.1;port=3306;username=root;password=7744Radman;database=kompetenzdb;"; // test = databas_name
            Console.WriteLine("Verbindung mit dem Datenbank erfolgreich");
            Read();

        }


        public void Read() // lesen informationen 
        {
            Console.WriteLine("Versuchen zu lesen von der Datenbank ...");

            string command = $"select * from  mitarbeiter";// user
            MySqlConnection databasConnection = new MySqlConnection(connectionString); // Verbindung erstellen // mydatabase
            MySqlCommand commandToDatabase = new MySqlCommand(command, databasConnection);// comand in database übermitlen
            commandToDatabase.CommandTimeout = 60;
            MySqlDataReader reader; // um die informationen von Tabelle zu lesen

            try
            {// überprufen 
                // offnen database
                databasConnection.Open(); // die Verbindung wird richtig hergestellt 

                reader = commandToDatabase.ExecuteReader(); // wird die Befehl richtig gelesen und gegeben


                if (reader.HasRows) // prufen ob mein Table nicht leer
                {

                    while (reader.Read()) // lese jede zeile // 1232 , zakaria
                    {
                        string[] zeile = { (reader.GetString(0)), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5) };
                        // int id = Int32.Parse(reader.GetString(0)); // "22" ->22
                        // klass mitarbeiter 
                        informationenList.Add(zeile); // Mitarbeitern jetzt hier gespeichert
                    }
                    MessageBox.Show("alle angegebene information ist richtig gelesen");
                }
                else
                {
                    MessageBox.Show("die Tablle ist leer");

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }
        public void Create(int Mitarbeiter_ID, String Vorname, String Name, String Aufgabenbereich, String Abteilung, String Rolle) // user einfugen
        {
            string command = $"insert into mitarbeiter values({Mitarbeiter_ID},{Vorname},{Name}" +
                $",{Aufgabenbereich},{Abteilung} ,{Rolle})"; // values wird als textbox.text von user gegeben
            MySqlConnection databasConnection = new MySqlConnection(connectionString);
            MySqlCommand commandToDatabase = new MySqlCommand(command, databasConnection);
            commandToDatabase.CommandTimeout = 60;
            MySqlDataReader myReader;

            try
            {
                databasConnection.Open();
                myReader = commandToDatabase.ExecuteReader();

                MessageBox.Show("wird user eingefugt");


                databasConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        public void Update(int Mitarbeiter_ID, String Vorname, String Name, String Aufgabenbereich, String Abteilung, String Rolle) // user einfugen

        {
            string command = $"Update mitarbeiter set Vorname={Vorname} , Name={Name} ,Aufgabenbereich={Aufgabenbereich}" +
                $", Abteilung={Abteilung},Rolle={Rolle} where Mitarbeiter_ID={Mitarbeiter_ID}";

            MySqlConnection databasConnection = new MySqlConnection(connectionString); // Verbindung erstellen // mydatabase
            MySqlCommand commandToDatabase = new MySqlCommand(command, databasConnection);// comand in database übermitlen
            commandToDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databasConnection.Open();
                reader = commandToDatabase.ExecuteReader();

                MessageBox.Show("wird die Daten von  Mitarbeiter geaendert  ");


                databasConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        //delet(2)
        public void Delete(int Mitarbeiter_ID)
        {
            string command = $"Delete from mitarbeiter where Mitarbeiter_ID = {Mitarbeiter_ID} ";

            MySqlConnection databasConnection = new MySqlConnection(connectionString); // Verbindung erstellen // mydatabase
            MySqlCommand commandToDatabase = new MySqlCommand(command, databasConnection); // comand in database übermitlen
            commandToDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databasConnection.Open();
                reader = commandToDatabase.ExecuteReader();

                MessageBox.Show($"Mitarbeiter mit Mitarbeiter_ID: {Mitarbeiter_ID} wurde gealoscht");


                databasConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }



        public void Projektanlegen(int Projekt_ID , string Name , DateTime Start , DateTime Ende , string Beschreibung)

        {

            string command = $"insert into projekt values({Projekt_ID},{Name},{Start}" +
               $",{Ende},{Beschreibung})"; // values wird als textbox.text von user gegeben
            MySqlConnection databasConnection = new MySqlConnection(connectionString);
            MySqlCommand commandToDatabase = new MySqlCommand(command, databasConnection);
            commandToDatabase.CommandTimeout = 60;
            MySqlDataReader myReader;

            try
            {
                databasConnection.Open();
                myReader = commandToDatabase.ExecuteReader();

                MessageBox.Show("wird Projekt angelegt");
                

                databasConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void ProjektEnfernen(int Projekt_ID)

        {

            string command = $"Delete from projekt where Projekt_ID = {Projekt_ID} ";

            MySqlConnection databasConnection = new MySqlConnection(connectionString); // Verbindung erstellen // mydatabase
            MySqlCommand commandToDatabase = new MySqlCommand(command, databasConnection); // comand in database übermitlen
            commandToDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databasConnection.Open();
                reader = commandToDatabase.ExecuteReader();

                MessageBox.Show($"Projekt mit Projekt_ID: {Projekt_ID} wurde gealoscht");


                databasConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public void Passwortandern(int Mitarbeiter_ID , string Passwort)
        {
            string hashpasswort = HashPassword.Hashpassword(Passwort);
            string command = $"Update mitarbeiter set passwort={hashpasswort}  where Mitarbeiter_ID={Mitarbeiter_ID}";

            MySqlConnection databasConnection = new MySqlConnection(connectionString); // Verbindung erstellen // mydatabase
            MySqlCommand commandToDatabase = new MySqlCommand(command, databasConnection);// comand in database übermitlen
            commandToDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databasConnection.Open();
                reader = commandToDatabase.ExecuteReader();

                MessageBox.Show("die Passwort wird richtig geandert");


                databasConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }









        }



        public void kompetenz(int Kompetenz_ID)
        {

            string command = $"select * from  kompetenz where Kompetenz_ID = {Kompetenz_ID}";
            MySqlConnection databasConnection = new MySqlConnection(connectionString); // Verbindung erstellen // mydatabase
            MySqlCommand commandToDatabase = new MySqlCommand(command, databasConnection);// comand in database übermitlen
            commandToDatabase.CommandTimeout = 60;
            MySqlDataReader reader; // um die informationen von Tabelle zu lesen

            try
            {// überprufen 
                // offnen database
                databasConnection.Open(); // die Verbindung wird richtig hergestellt 

                reader = commandToDatabase.ExecuteReader(); // wird die Befehl richtig gelesen und gegeben


                if (reader.HasRows) // prufen ob mein Table nicht leer
                {

                    while (reader.Read()) // lese jede zeile // 1232 , zakaria
                    {
                        string[] zeile = { (reader.GetString(0)), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5) };
                        // int id = Int32.Parse(reader.GetString(0)); // "22" ->22
                        // klass mitarbeiter 
                        informationenList.Add(zeile); // Mitarbeitern jetzt hier gespeichert
                    }
                    MessageBox.Show("alle angegebene information ist richtig gelesen");
                }
                else
                {
                    MessageBox.Show("die Tablle ist leer");

                }




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }







    }

}
