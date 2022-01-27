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
    public partial class ProjektListe : Form
    {
        /// <summary>
        /// Sucht die Connection bzw. ruft die Klasse ab.
        /// </summary>
        Connection con = new Connection();
        /// <summary>
        /// Form der Projekt Liste
        /// </summary>
        public ProjektListe()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Wenn das Formular angezeigt wird, ruft die Funktion die GetProjektList als Datasource für die Datagridview auf
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProjektListe_Shown(object sender, EventArgs e)
        {
            Connection.DataSource();
            con.connOpen();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = ("select * from mitarbeiter where benutzername= '" + Hauptseite.hauptseite.Username.Text + "'");
            command.Connection = Connection.connMaster;
            MySqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                // Uberprüft ob es ein Administrator und Mitarbeiter
                if (reader[8].ToString() == "Administrator")
                {
                    ProjektListeTable.DataSource = GetProjektListAdministrator("");
                }
                else
                {
                    ProjektListeTable.DataSource = GetProjektListMitarbeiter("");
                }
            }
        }

        /// <summary>
        /// Diese Funktion ruft die Projekt Daten aus der Datenbank ab und fügt sie als DataTable in die Datagridview ein
        /// </summary>
        /// <param name="valueToSearch"></param>
        /// <returns></returns>
        private DataTable GetProjektListAdministrator(string valueToSearch)
        {
            DataTable projektliste = new DataTable();
            Connection.DataSource();
            con.connOpen();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = ("select Projekt_ID, Name, Start, Ende, Beschreibung from projekt where CONCAT (Projekt_ID, Name, Start, Ende) like '%" + textBox1.Text + "%'");
            command.Connection = Connection.connMaster;
            MySqlDataReader reader = command.ExecuteReader();
            projektliste.Load(reader);
            return projektliste;

        }
        private DataTable GetProjektListMitarbeiter(string valueToSearch)
        {
            DataTable KompetenzListe = new DataTable();
            Connection.DataSource();
            con.connOpen();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = ("select projekt.projekt_ID, projekt.Name, projekt.start, projekt.ende, projekt.Beschreibung from projekt, mitarbeiter_hat_projekt, mitarbeiter " +
                    "where mitarbeiter.Mitarbeiter_ID = mitarbeiter_hat_projekt.Zugeordnete_Mitarbeiter " +
                    "and projekt.Projekt_ID = mitarbeiter_hat_projekt.Zugeordnete_Projekt and benutzername = '" + Hauptseite.hauptseite.Username.Text + "'");
            command.Connection = Connection.connMaster;
            MySqlDataReader reader = command.ExecuteReader();
            KompetenzListe.Load(reader);
            return KompetenzListe;
        }
        /// <summary>
        /// Ein Click handler wenn das Anzeigen gedrückt wird, werden die ausgewählten Projekt in der nächsten Form angezeigt
        /// und wird die Daten vom Datenbank aufgerufen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProjektListeTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                ProjektDetail form1 = new ProjektDetail();
                form1.labelProjektName.Text = this.ProjektListeTable.CurrentRow.Cells[2].Value.ToString();
                form1.labelStartDatum.Text = this.ProjektListeTable.CurrentRow.Cells[3].Value.ToString();
                form1.labelEndeDatum.Text = this.ProjektListeTable.CurrentRow.Cells[4].Value.ToString();
                form1.labelBeschreibung.Text = this.ProjektListeTable.CurrentRow.Cells[5].Value.ToString();
                form1.ShowDialog();
            }
        }
        /// <summary>
        /// Wenn der Administrator auf diese Button klickt, kann er der Datenbank eine neue Projekt hinzufügen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void iconButton1_Click(object sender, EventArgs e)
        {
            Projekt form1 = new Projekt();
            form1.ShowDialog();
        }
        /// <summary>
        /// Lade die Seite neu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void iconButton3_Click(object sender, EventArgs e)
        {
            Connection.DataSource();
            con.connOpen();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = ("select * from mitarbeiter where benutzername= '" + Hauptseite.hauptseite.Username.Text + "'");
            command.Connection = Connection.connMaster;
            MySqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                // Uberprüft ob es ein Administrator und Mitarbeiter
                if (reader[8].ToString() == "Administrator")
                {
                    ProjektListeTable.DataSource = GetProjektListAdministrator("");
                }
                else
                {
                    ProjektListeTable.DataSource = GetProjektListMitarbeiter("");
                }
            }
        }
        /// <summary>
        /// Filtern  die Datagridview mit der Eingabe aus dem Texbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            Connection.DataSource();
            con.connOpen();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = ("select * from mitarbeiter where benutzername= '" + Hauptseite.hauptseite.Username.Text + "'");
            command.Connection = Connection.connMaster;
            MySqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                // Uberprüft ob es ein Administrator und Mitarbeiter
                if (reader[8].ToString() == "Administrator")
                {
                    ProjektListeTable.DataSource = GetProjektListAdministrator("");
                }
                else
                {
                    ProjektListeTable.DataSource = GetProjektListMitarbeiter("");
                }
            }
        }
    }
}
