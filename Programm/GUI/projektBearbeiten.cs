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
    public partial class projektBearbeiten : Form
    {
        /// <summary>
        /// Sucht die Connection bzw. ruft die Klasse ab.
        /// </summary>
        Connection con = new Connection();
        /// <summary>
        /// Für das Form projektBearbeiten wird erst alle die Sachen von dem Designer initialisiert 
        /// </summary>
        public projektBearbeiten()
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
                command.CommandText = ("update projekt set Start ='" + dateTimePicker1.Text + "', ende ='" + dateTimePicker2.Text + "', beschreibung ='" +txtBeschreibung.Text +"' where name = '" + this.labelProjektName.Text + "'");
                command.Connection = Connection.connMaster;
                command.ExecuteNonQuery();
                MessageBox.Show("Projekt aktualisiert");
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
