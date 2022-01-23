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

        private void MitarbeiterListe_Shown(object sender, EventArgs e)
        {
            MitarbeiterListeTable.DataSource = GetEmployeesList("");
        }

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

        private void MitarbeiterListeTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                Connection.DataSource();
                con.connOpen();
                MySqlCommand command = new MySqlCommand();
                command.CommandText = ("select * from mitarbeiter where Benutzername = '" + this.MitarbeiterListeTable.CurrentRow.Cells[2].Value.ToString() + "'");
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
                        form1.iconButton3.Hide();
                        form1.iconButton4.Text = "Konto deaktivieren";
                        form1.ShowDialog();
                    }
                }

            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

            Hauptseite.hauptseite.openChildForm(new NeueMitarbeiter());
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            MitarbeiterListeTable.DataSource = GetEmployeesList("");
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            MitarbeiterListeTable.DataSource = GetEmployeesList("");
        }
    }
}
