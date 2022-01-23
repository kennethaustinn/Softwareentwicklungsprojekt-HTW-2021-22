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

        private void ProjektListe_Shown(object sender, EventArgs e)
        {
            ProjektListeTable.DataSource = GetProjektList("");
        }


        private DataTable GetProjektList(string valueToSearch)
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

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Projekt form1 = new Projekt();
            form1.ShowDialog();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            ProjektListeTable.DataSource = GetProjektList("");
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            ProjektListeTable.DataSource = GetProjektList("");
        }
    }
}
