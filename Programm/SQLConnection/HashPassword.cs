using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace SQLConnection
{
    class HashPassword
    {

        public HashPassword()
        {

        }



        public static string Hashpassword(string password) {

            SHA1CryptoServiceProvider shal = new SHA1CryptoServiceProvider();
            byte[] passwordByts = Encoding.ASCII.GetBytes(password);
            byte[] encryptedbyts = shal.ComputeHash(passwordByts);
            return Convert.ToBase64String(encryptedbyts);

        }
            public void importHashPasswordTODataBase(string password)
        { 
            string PasswordAsHash = Hashpassword(password); 
            string command = $"insert into mitarbeiter values ({PasswordAsHash})";
            MySqlConnection databasConnection = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=kompetenzdb;");
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
    }
}
