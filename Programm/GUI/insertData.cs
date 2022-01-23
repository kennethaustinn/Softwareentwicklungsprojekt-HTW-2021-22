using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace GUI { 
    public class insertData
    {
        /// <summary>
        /// Sucht die Connection bzw. ruft die Klasse ab.
        /// </summary>
        Connection con = new Connection();

        /// <summary>
        /// Das Einfügen eines neuen Benutzer erfolgt mit dieser Methode. Jeder Eingabe wird in MySQL gespeichert mit dem Connection via MySQL 
        /// </summary>
        /// <param name="benutzerInsert"> Die Benutzername des Users</param>
        /// <param name="passInsert"> Das Passwort des Users</param>
        /// <param name="vornameInsert"> Die Vorname des Users</param>
        /// <param name="nameInsert"> Die Nachname des Users</param>
        /// <param name="aufgabenInsert">Die Aufgabenbereich des Users</param>
        /// <param name="abteilungInsert"> Die Abteilung des Users</param>
        /// <param name="rolleInsert">Die Rolle des Users</param>
        /// <returns> Ergibt sich die angegebene Parameter zurück als Zeichnen ob es erfolgreich in der Datenbank gespeichert oder nicht</returns>
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
        /// Das Einfügen einer neuen Kompetenz erfolgt mit dieser Methode. Jeder Eingabe wird in 
        /// MySQL gespeichert mit dem Connection via MySQL
        /// </summary>
        /// <param name="name"> Die Name der Kompetenz</param>
        /// <param name="bezeichnung"> Die Bezeichnung der Kompetenz</param>
        /// <param name="alternativebezeichnung"> Die Alternativebezeichnung der Kompetenz</param>
        /// <param name="beschreibung"> Die Beschreibung der Kompetenz</param>
        /// <returns> Ergibt sich die angegebene Parameter zurück als Zeichnen ob es erfolgreich in der Datenbank gespeichert oder nicht</returns>
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
        /// <param name="name"> Die Name des Projekts</param>
        /// <param name="start"> Das Startdatum des Projekts</param>
        /// <param name="ende"> Das Endedatum des Projekts</param>
        /// <param name="beschreibung"> Die Beschreibung des Projekts</param>
        /// <returns> Ergibt sich die angegebene Parameter zurück als Zeichnen ob es erfolgreich in der Datenbank gespeichert oder nicht</returns>
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
