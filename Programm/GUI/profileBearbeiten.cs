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
        /// <summary>
        /// Sucht die Connection bzw. ruft die Klasse ab.
        /// </summary>
        Connection con = new Connection();
        /// <summary>
        /// Für das Form profileBearbeiten wird erst alle die Sachen von dem Designer initialisiert 
        /// </summary>
        public profileBearbeiten()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Ein Click event wenn die  „Speichern“ button gedrückt wird, werden die Mitarbeiter 
        /// Datei im Datenbank mit den Daten von dieser Seite geschrieben
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
