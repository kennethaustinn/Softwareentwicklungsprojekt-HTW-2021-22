using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
using RestAPI;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Threading.Tasks;
using System.Net;
using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace GUI
{
    public partial class MitarbeiterListe : Form
    {
        /// <summary>
        /// Sucht die Connection bzw. ruft die Klasse ab.
        /// </summary>
        Connection con = new Connection();
        /// <summary>
        /// Form der Mitarbeiter Liste
        /// </summary>
        public static MitarbeiterListe mitarbeiterListe = new MitarbeiterListe();
        /// <summary>
        /// Für das Form Mitarbeiter Liste wird erst alle die Sachen von dem Designer initialisiert 
        /// </summary>
        public MitarbeiterListe()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Wenn das Formular angezeigt wird, ruft die Funktion die GetEmployeesList als Datasource für die Datagridview auf
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MitarbeiterListe_Shown(object sender, EventArgs e)
        {
            MitarbeiterListeTable.DataSource = GetEmployeesList("");
        }
        /// <summary>
        /// Diese Funktion ruft die Mitarbeiter Daten aus der Datenbank ab und fügt sie als DataTable in die Datagridview ein
        /// </summary>
        /// <param name="valueToSearch"></param>
        /// <returns></returns>
        private DataTable GetEmployeesList(string valueToSearch)
        {
            DataTable dtEmployees = new DataTable();
            Connection.DataSource();
            con.connOpen();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = ("select Mitarbeiter_ID, Benutzername, Name, Vorname, Abteilung, Aufgabenbereich from mitarbeiter where CONCAT (Mitarbeiter_ID, Name,vorname,benutzername,Abteilung,Aufgabenbereich) like '%" + textBox1.Text + "%'");
            command.Connection = Connection.connMaster;
            MySqlDataReader reader = command.ExecuteReader();
            dtEmployees.Load(reader);
            return dtEmployees;
        }

        /// <summary>
        /// Ein Click handler wenn das Anzeigen gedrückt wird, werden die ausgewählten Mitarbeiter in der nächsten Form angezeigt
        /// und wird die Daten vom Datenbank aufgerufen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MitarbeiterListeTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                Connection.DataSource();
                con.connOpen();
                MySqlCommand command = new MySqlCommand();
                command.CommandText = ("select * from mitarbeiter where Mitarbeiter_ID = '" + this.MitarbeiterListeTable.CurrentRow.Cells[1].Value.ToString() + "'");
                command.Connection = Connection.connMaster;
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    if (reader[9].ToString() == "True")
                    {
                        Profile form1 = new Profile();
                        form1.labelBenutzername.Text = this.MitarbeiterListeTable.CurrentRow.Cells[2].Value.ToString();
                        form1.labelName.Text = this.MitarbeiterListeTable.CurrentRow.Cells[3].Value.ToString();
                        form1.labelVorname.Text = this.MitarbeiterListeTable.CurrentRow.Cells[4].Value.ToString();
                        form1.labelAbteilung.Text = this.MitarbeiterListeTable.CurrentRow.Cells[5].Value.ToString();
                        form1.labelAufgabenbereich.Text = this.MitarbeiterListeTable.CurrentRow.Cells[6].Value.ToString();
                        form1.label2.Text = GetKompetenz();
                        form1.label9.Text = GetProjekt();
                        form1.iconButton3.Hide();
                        form1.iconButton4.Text = "Konto aktivieren";
                        form1.iconButton4.BackColor = Color.SpringGreen;
                        form1.iconButton4.IconChar = FontAwesome.Sharp.IconChar.User;
                        form1.ShowDialog();
                    }
                    else
                    {
                        Profile form1 = new Profile();
                        form1.labelBenutzername.Text = this.MitarbeiterListeTable.CurrentRow.Cells[2].Value.ToString();
                        form1.labelName.Text = this.MitarbeiterListeTable.CurrentRow.Cells[3].Value.ToString();
                        form1.labelVorname.Text = this.MitarbeiterListeTable.CurrentRow.Cells[4].Value.ToString();
                        form1.labelAbteilung.Text = this.MitarbeiterListeTable.CurrentRow.Cells[5].Value.ToString();
                        form1.labelAufgabenbereich.Text = this.MitarbeiterListeTable.CurrentRow.Cells[6].Value.ToString();
                        form1.label2.Text = GetKompetenz();
                        form1.label9.Text = GetProjekt();
                        form1.iconButton3.Hide();
                        form1.iconButton4.Text = "Konto deaktivieren";
                        form1.ShowDialog();
                    }
                }

            }
        }
        private string GetKompetenz()
        {
            Connection.DataSource();
            con.connOpen();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = ("select kompetenz.Name from kompetenz, mitarbeiter_hat_kompetenz, mitarbeiter " +
                "where kompetenz.Kompetenz_ID = mitarbeiter_hat_kompetenz.Zugeordnete_Kompetenz " +
                "and mitarbeiter.Mitarbeiter_ID = mitarbeiter_hat_kompetenz.Zugeordnete_Mitarbeiter and Mitarbeiter_ID = '" + this.MitarbeiterListeTable.CurrentRow.Cells[1].Value.ToString() + "'");
            command.Connection = Connection.connMaster;
            MySqlDataReader reader = command.ExecuteReader();
            reader.Read();
            string a = reader[0].ToString();
            return a;
        }

        private string GetProjekt()
        {
            Connection.DataSource();
            con.connOpen();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = ("select projekt.Name from projekt, mitarbeiter_hat_projekt, mitarbeiter " +
                "where mitarbeiter.Mitarbeiter_ID = mitarbeiter_hat_projekt.Zugeordnete_Mitarbeiter " +
                "and projekt.Projekt_ID = mitarbeiter_hat_projekt.Zugeordnete_Projekt and Mitarbeiter_ID = '" + this.MitarbeiterListeTable.CurrentRow.Cells[1].Value.ToString() + "'");
            command.Connection = Connection.connMaster;
            MySqlDataReader reader = command.ExecuteReader();
            reader.Read();
            string a = reader[0].ToString();
            return a;
        }

        /// <summary>
        /// Wenn der Administrator auf diese Button klickt, das Formular von Neumitarbeiter wird angezeigt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void iconButton1_Click(object sender, EventArgs e)
        {
            Hauptseite.hauptseite.openChildForm(new NeueMitarbeiter());
        }
        /// <summary>
        /// Lade die Seite neu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void iconButton3_Click(object sender, EventArgs e)
        {
            MitarbeiterListeTable.DataSource = GetEmployeesList("");
        }
        /// <summary>
        /// Filtern  die Datagridview mit der Eingabe aus dem Texbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            MitarbeiterListeTable.DataSource = GetEmployeesList("");
        }
    }
}
