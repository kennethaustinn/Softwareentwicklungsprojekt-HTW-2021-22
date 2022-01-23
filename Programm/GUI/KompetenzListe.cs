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
        Connection con = new Connection();
        public KompetenzListe()
        {
            InitializeComponent();
        }

        private void KompetenzListe_Shown(object sender, EventArgs e)
        {
            KompetenzListeTable.DataSource = GetKompetenzList();
        }

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

 

        private DataTable GetKompetenzList()
        {
            DataTable KompetenzListe = new DataTable();
            Connection.DataSource();
            con.connOpen();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = ("select * from Kompetenz");
            command.Connection = Connection.connMaster;
            MySqlDataReader reader = command.ExecuteReader();
            KompetenzListe.Load(reader);
            return KompetenzListe;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Kompetenz form1 = new Kompetenz();
            form1.ShowDialog();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            KompetenzListeTable.DataSource = GetKompetenzList();
        }
    }
}
