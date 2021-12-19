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
