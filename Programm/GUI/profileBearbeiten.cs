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
    public partial class profileBearbeiten : Form
    {
        Connection con = new Connection();
        public profileBearbeiten()
        {
            InitializeComponent();
        }

        //Wenn die  „Speichern“ button gedrückt wird, werden die Mitarbeiter Datei im Datenbank mit den Daten von dieser Seite geschrieben
        private void speichernButton_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.DataSource();
                con.connOpen();
                MySqlCommand command = new MySqlCommand();
                command.CommandText = ("update mitarbeiter set name ='" + txtName.Text + "',Vorname ='" + txtVorname.Text + "', abteilung ='" + txtAbteilung.Text + "',aufgabenbereich ='" + txtAufgabenbereich.Text + "' where Benutzername = '"+Hauptseite.hauptseite.Username.Text+"'");
                command.Connection = Connection.connMaster;
                command.ExecuteNonQuery();
                MessageBox.Show("Profile aktualisiert");
                con.connClose();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
