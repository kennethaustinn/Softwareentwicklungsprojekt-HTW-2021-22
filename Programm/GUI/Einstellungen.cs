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
        /// <summary>
        /// Sucht die Connection bzw. ruft die Klasse ab.
        /// </summary>
        Connection con = new Connection();
        /// <summary>
        /// Für das Form Einstellungen wird erst alle die Sachen von dem Designer initialisiert 
        /// </summary>
        public Einstellungen()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Ein Clickevent damit wird die geänderte Benutzername aktualisiert und in der Datenbank gespeichert
        /// mit einer Verbindung von MySQL
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                MessageBox.Show("Benutzername aktualisiert");
                Hauptseite.hauptseite.Username.Text = txtBenutzername.Text;
                txtBenutzername.Text = "";
                con.connClose();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        /// <summary>
        /// Mit diesem Event wird das alte Password vergleicht ob die Eingabe schon genau wie die in der Datenbank und auch das zwei neue Passwort
        /// wurde verglichen. Wenn alles klappt dann wird das Passwort aktualisiert und in der Datenbank gespeichert mit einer Verbindung von MySQL
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonChangePasswort_Click(object sender, EventArgs e)
        {
            Connection.DataSource();
            con.connOpen();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = ("select * from mitarbeiter where Passwort ='" + Encrypt.HashString(txtAltPassword.Text) + "'and Benutzername ='" + Hauptseite.hauptseite.Username.Text + "'");
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
                        command.CommandText = ("update mitarbeiter set Passwort ='" + Encrypt.HashString(txtNewPassword.Text) + "', Saltedpasswort ='" + Encrypt.SaltString(txtNewPassword.Text) + "' where Benutzername ='" + Hauptseite.hauptseite.Username.Text + "'");
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
