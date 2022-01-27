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
    public partial class KompetenzListe : Form
    {
        /// <summary>
        /// Sucht die Connection bzw. ruft die Klasse ab.
        /// </summary>
        Connection con = new Connection();
        /// <summary>
        /// Für das Form KompetenzListe wird erst alle die Sachen von dem Designer initialisiert 
        /// </summary>
        public KompetenzListe()
        {
            InitializeComponent();
        }
            /// <summary>
            /// Wenn das Formular angezeigt wird, ruft die Funktion die GetKompetenzliste als Datasource für die Datagridview auf
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void KompetenzListe_Shown(object sender, EventArgs e)
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
                        KompetenzListeTable.DataSource = GetKompetenzListAdministrator("");
                    }
                    else
                    {
                        KompetenzListeTable.DataSource = GetKompetenzListMitarbeiter("");
                    }
                }
            }
            /// <summary>
            /// Ein Click handler wenn das Anzeigen gedrückt wird, werden die ausgewählten Kompetenz in der nächsten Form angezeigt
            /// und wird die Daten vom Datenbank aufgerufen
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void KompetenzListeTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {
                var senderGrid = (DataGridView)sender;

                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                    e.RowIndex >= 0)
                {
                    KompetenzDetail form1 = new KompetenzDetail();
                    form1.labelKompetenzName.Text = this.KompetenzListeTable.CurrentRow.Cells[2].Value.ToString();
                    form1.labelBezeichnung.Text = this.KompetenzListeTable.CurrentRow.Cells[3].Value.ToString();
                    form1.labelAlternative.Text = this.KompetenzListeTable.CurrentRow.Cells[4].Value.ToString();
                    form1.labelBeschreibung.Text = this.KompetenzListeTable.CurrentRow.Cells[5].Value.ToString();
                    form1.ShowDialog();
                }
            }
            /// <summary>
            /// Diese Funktion ruft die Kompetenz Daten aus der Datenbank ab und fügt sie als DataTable in die Datagridview ein
            /// </summary>
            /// <param name="valueToSearch"></param>
            /// <returns></returns>
            private DataTable GetKompetenzListAdministrator(string valueToSearch)
            {
                DataTable KompetenzListe = new DataTable();
                Connection.DataSource();
                con.connOpen();
                MySqlCommand command = new MySqlCommand();
                command.CommandText = ("select Kompetenz_ID, Name, Bezeichnung, Alternativebezeichnung, Beschreibung from Kompetenz where CONCAT (Kompetenz_ID, Name, Bezeichnung, Alternativebezeichnung) like '%" + textBox1.Text + "%'");
                command.Connection = Connection.connMaster;
                MySqlDataReader reader = command.ExecuteReader();
                KompetenzListe.Load(reader);
                return KompetenzListe;
            }

            private DataTable GetKompetenzListMitarbeiter(string valueToSearch)
            {
                DataTable KompetenzListe = new DataTable();
                Connection.DataSource();
                con.connOpen();
                MySqlCommand command = new MySqlCommand();
                command.CommandText = ("select kompetenz.Kompetenz_ID, kompetenz.Name, kompetenz.Bezeichnung, kompetenz.Alternativebezeichnung, kompetenz.Beschreibung from kompetenz, mitarbeiter_hat_kompetenz, mitarbeiter " +
                    "where kompetenz.Kompetenz_ID = mitarbeiter_hat_kompetenz.Zugeordnete_Kompetenz " +
                    "and mitarbeiter.Mitarbeiter_ID = mitarbeiter_hat_kompetenz.Zugeordnete_Mitarbeiter and benutzername = '" + Hauptseite.hauptseite.Username.Text + "'");
                command.Connection = Connection.connMaster;
                MySqlDataReader reader = command.ExecuteReader();
                KompetenzListe.Load(reader);
                return KompetenzListe;
            }
            /// <summary>
            /// Wenn der Administrator auf diese Button klickt, kann er der Datenbank eine neue Kompetenz hinzufügen
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void iconButton1_Click(object sender, EventArgs e)
            {
                Kompetenz form1 = new Kompetenz();
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
                    KompetenzListeTable.DataSource = GetKompetenzListAdministrator("");
                }
                else
                {
                    KompetenzListeTable.DataSource = GetKompetenzListMitarbeiter("");
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
                    KompetenzListeTable.DataSource = GetKompetenzListAdministrator("");
                }
                else
                {
                    KompetenzListeTable.DataSource = GetKompetenzListMitarbeiter("");
                }
            }
        }
        }
    }

