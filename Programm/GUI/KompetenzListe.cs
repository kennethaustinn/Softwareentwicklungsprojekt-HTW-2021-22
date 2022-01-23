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
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KompetenzListe_Shown(object sender, EventArgs e)
        {
            KompetenzListeTable.DataSource = GetKompetenzList("");
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
        /// 
        /// </summary>
        /// <param name="valueToSearch"></param>
        /// <returns></returns>
        private DataTable GetKompetenzList(string valueToSearch)
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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void iconButton1_Click(object sender, EventArgs e)
        {
            Kompetenz form1 = new Kompetenz();
            form1.ShowDialog();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void iconButton3_Click(object sender, EventArgs e)
        {
            KompetenzListeTable.DataSource = GetKompetenzList("");
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            KompetenzListeTable.DataSource = GetKompetenzList("");
        }
    }
}
