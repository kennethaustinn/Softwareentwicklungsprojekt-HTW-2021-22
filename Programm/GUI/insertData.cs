using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace GUI { 
    public class insertData
    {
        Connection con = new Connection();
        Encrypt en = new Encrypt();
        /// <summary>
        /// Das Einfügen eines neuen Benutzer erfolgt mit dieser Methode. Jeder Eingabe wird in MySQL gespeichert mit dem Connection via MySQL 
        /// </summary>
        /// <param name="benutzerInsert"></param>
        /// <param name="passInsert"></param>
        /// <param name="vornameInsert"></param>
        /// <param name="nameInsert"></param>
        /// <param name="aufgabenInsert"></param>
        /// <param name="abteilungInsert"></param>
        /// <param name="rolleInsert"></param>
        /// <returns></returns>
        public string InsertData(string benutzerInsert, string passInsert, string vornameInsert, string nameInsert, string aufgabenInsert, string abteilungInsert, string rolleInsert)
        {
            try
            {
                Connection.DataSource();
                con.connOpen();
                MySqlCommand command = new MySqlCommand();
                command.CommandText = "INSERT INTO mitarbeiter (Benutzername, passwort,Saltedpasswort, Vorname, Name, Aufgabenbereich, Abteilung, Rolle, Deaktiviert) values (@benutzername ,@passwort, @saltpassword,@vorname,@name ,@aufgabenbereich ,@abteilung ,@rolle, false)";
                command.Parameters.AddWithValue("@benutzername", benutzerInsert);
                command.Parameters.AddWithValue("@passwort", Encrypt.HashString(passInsert));
                command.Parameters.AddWithValue("@saltpassword", Encrypt.SaltString(passInsert));
                command.Parameters.AddWithValue("@vorname", vornameInsert);
                command.Parameters.AddWithValue("@name", nameInsert);
                command.Parameters.AddWithValue("@aufgabenbereich", aufgabenInsert);
                command.Parameters.AddWithValue("@abteilung", abteilungInsert);
                command.Parameters.AddWithValue("@rolle", rolleInsert);
                command.Connection = Connection.connMaster;
                command.ExecuteNonQuery();
                con.connClose();

                return benutzerInsert + passInsert + vornameInsert + nameInsert + aufgabenInsert + abteilungInsert + rolleInsert;


            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                con.connClose();
            }
        }

        /// <summary>
        /// Das Einfügen einer neuen Kompetenz erfolgt mit dieser Methode. Jeder Eingabe wird in MySQL gespeichert mit dem Connection via MySQL
        /// </summary>
        /// <param name="name"></param>
        /// <param name="bezeichnung"></param>
        /// <param name="alternativebezeichnung"></param>
        /// <param name="beschreibung"></param>
        /// <returns></returns>
        public string InsertKompetenz(string name, string bezeichnung, string alternativebezeichnung, string beschreibung)
        {
            try
            {
                Connection.DataSource();
                con.connOpen();
                MySqlCommand command = new MySqlCommand();
                command.CommandText = "INSERT INTO Kompetenz (Name, Bezeichnung, Alternativebezeichnung, Beschreibung) values (@name, @bezeichnung, @alternativebezeichnung ,@beschreibung)";
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@bezeichnung", bezeichnung);
                command.Parameters.AddWithValue("@alternativebezeichnung", alternativebezeichnung);
                command.Parameters.AddWithValue("@beschreibung", beschreibung);
                command.Connection = Connection.connMaster;
                command.ExecuteNonQuery();
                con.connClose();

                return name + bezeichnung + alternativebezeichnung + beschreibung;

            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                con.connClose();
            }
        }
        /// <summary>
        /// Das Einfügen eines neuen Projekts erfolgt über diese Methode. Jeder Eingabe wird in MySQL gespeichert mit dem Connection via MySQL
        /// </summary>
        /// <param name="name"></param>
        /// <param name="start"></param>
        /// <param name="ende"></param>
        /// <param name="beschreibung"></param>
        /// <returns></returns>
        public string InsertProjekt(string name, string start, string ende, string beschreibung)
        {
            try
            {
                Connection.DataSource();
                con.connOpen();
                MySqlCommand command = new MySqlCommand();
                command.CommandText = "INSERT INTO Projekt (Name, start, ende, Beschreibung) values (@name, @start, @ende ,@beschreibung)";
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@start", start);
                command.Parameters.AddWithValue("@ende", ende);
                command.Parameters.AddWithValue("@beschreibung", beschreibung);
                command.Connection = Connection.connMaster;
                command.ExecuteNonQuery();
                con.connClose();

                return name + start + ende + beschreibung;


            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                con.connClose();
            }
        }
    }
}
