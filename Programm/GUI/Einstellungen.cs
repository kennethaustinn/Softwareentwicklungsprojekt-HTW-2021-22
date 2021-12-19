using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GUI
{
    public partial class Einstellungen : Form
    {
        Connection con = new Connection();
        public Einstellungen()
        {
            InitializeComponent();
        }

        private void buttonChangeBenutzername_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.DataSource();
                con.connOpen();
                MySqlCommand command = new MySqlCommand();
                command.CommandText = ("update mitarbeiter set Benutzername ='" + txtBenutzername.Text + "' where Benutzername ='" + Hauptseite.hauptseite.Username.Text + "'");
                command.Connection = Connection.connMaster;
                command.ExecuteNonQuery();
                txtBenutzername.Text =  "";
                MessageBox.Show("Benutzername aktualisiert");
                con.connClose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void buttonChangePasswort_Click(object sender, EventArgs e)
        {
            Connection.DataSource();
            con.connOpen();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = ("select * from mitarbeiter where Hashedpasswort ='" + Encrypt.HashString(txtAltPassword.Text) + "'and Benutzername ='" + Hauptseite.hauptseite.Username.Text + "'");
            command.Connection = Connection.connMaster;
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                con.connClose();
                if (txtNewPassword.Text == txtComNewPassword.Text)
                {
                    try
                    {
                        con.connOpen();
                        command.CommandText = ("update mitarbeiter set Hashedpasswort ='" + Encrypt.HashString(txtNewPassword.Text) + "', Saltedpasswort ='" + Encrypt.SaltString(txtNewPassword.Text) + "' where Benutzername ='" + Hauptseite.hauptseite.Username.Text + "'");
                        command.Connection = Connection.connMaster;
                        command.ExecuteNonQuery();
                        txtAltPassword.Text = "";
                        txtNewPassword.Text = "";
                        txtComNewPassword.Text = "";
                        MessageBox.Show("Passwort aktualisiert");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Passwort nicht gleich! Bitte versuchen Sie es nochmal erneut", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNewPassword.Text = "";
                    txtComNewPassword.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Altes Passwort Falsch! Bitte versuchen Sie es erneut", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAltPassword.Text = "";
                txtNewPassword.Text = "";
                txtComNewPassword.Text = "";
            }
            con.connClose();

        }
    }
}
