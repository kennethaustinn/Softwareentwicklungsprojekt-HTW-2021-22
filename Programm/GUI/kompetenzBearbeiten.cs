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
    public partial class kompetenzBearbeiten : Form
    {
        /// <summary>
        /// Sucht die Connection bzw. ruft die Klasse ab.
        /// </summary>
        Connection con = new Connection();
        /// <summary>
        /// Für das Form Kompetenzbearbeiten wird erst alle die Sachen von dem Designer initialisiert 
        /// </summary>
        public kompetenzBearbeiten()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Ein Clickhandler wenndie  „Speichern“ button gedrückt wird, werden die Kompetenz Datei
        /// im Datenbank mit den Daten von dieser Seite geschrieben
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
                command.CommandText = ("update kompetenz set bezeichnung ='" + txtBezeichnung.Text + "', alternativebezeichnung ='" + txtAlternativeBezeichnung.Text + "',beschreibung ='" + txtBeschreibung.Text + "' where name = '" + this.labelKompetenzName.Text + "'");
                command.Connection = Connection.connMaster;
                command.ExecuteNonQuery();
                MessageBox.Show("Kompetenz aktualisiert");
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
