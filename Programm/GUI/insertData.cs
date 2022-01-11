using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace GUI { 
    class insertData
    {
        Connection con = new Connection();
        Encrypt en = new Encrypt();
        /// <summary>
        /// Einfügen neue User wird durch dieser Methode gemacht. Jeder Eingabe wird in MySQL gelagert durch die Connection mit MySQL 
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
                command.CommandText = "INSERT INTO mitarbeiter (Benutzername, Hashedpasswort,Saltedpasswort, Vorname, Name, Aufgabenbereich, Abteilung, Rolle) values (@benutzername ,@hashpassword, @saltpassword,@vorname,@name ,@aufgabenbereich ,@abteilung ,@rolle)";
                command.Parameters.AddWithValue("@benutzername", benutzerInsert);
                command.Parameters.AddWithValue("@hashpassword", Encrypt.HashString(passInsert));
                command.Parameters.AddWithValue("@saltpassword", Encrypt.SaltString(passInsert));
                command.Parameters.AddWithValue("@vorname", vornameInsert);
                command.Parameters.AddWithValue("@name", nameInsert);
                command.Parameters.AddWithValue("@aufgabenbereich", aufgabenInsert);
                command.Parameters.AddWithValue("@abteilung", abteilungInsert);
                command.Parameters.AddWithValue("@rolle", rolleInsert);
                command.Connection = Connection.connMaster;
                command.ExecuteNonQuery();
                System.Windows.Forms.MessageBox.Show("Account created");
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
    }
}
