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

        public string InsertData(string userInsert, string passInsert)
        {
            try
            {
                Connection.DataSource();
                con.connOpen();
                MySqlCommand command = new MySqlCommand();
                command.CommandText = "INSERT INTO users (userName, Password) values (@name , @password)";
                command.Parameters.AddWithValue("@name", userInsert);
                command.Parameters.AddWithValue("@password", Encrypt.HashString(passInsert));
                command.Connection = Connection.connMaster;
                command.ExecuteNonQuery();
                System.Windows.Forms.MessageBox.Show("Account created");
                con.connClose();

                return userInsert + passInsert;


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
