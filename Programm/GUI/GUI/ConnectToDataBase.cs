using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    class ConnectToDataBase
    {
        private string connectionString;
        private List<string[]> informationenList = new List<string[]>();
     

        public ConnectToDataBase() // connect to server 
        {
            this.connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=kompetenzdb;"; // test = databas_name

        }

        public void Read()
        {
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
                        string[] zeile = { reader.GetString(0), reader.GetString(1) , reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5) };

                        
                        informationenList.Add(zeile); // Mitarbeitern jetzt hier gespeichert
                    } 
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
        public void Create(int Mitarbeiter_ID, String Vorname , String Name ,String Aufgabenbereich , String Abteilung , String Rolle) // user einfugen
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
            catch(Exception ex )
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
            MySqlCommand commandToDatabase = new MySqlCommand(command, databasConnection);// comand in database übermitlen
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

    }

    }
  
