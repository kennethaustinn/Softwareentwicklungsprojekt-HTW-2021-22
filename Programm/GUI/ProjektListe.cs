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
        Connection con = new Connection();
        public ProjektListe()
        {
            InitializeComponent();
        }

        private void ProjektListe_Shown(object sender, EventArgs e)
        {
            ProjektListeTable.DataSource = GetProjektList();
        }

        private DataTable GetProjektList()
        {
            DataTable projektliste = new DataTable();
            Connection.DataSource();
            con.connOpen();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = ("select * from projekt");
            command.Connection = Connection.connMaster;
            MySqlDataReader reader = command.ExecuteReader();
            projektliste.Load(reader);
            return projektliste;

        }


        private void ProjektListeTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                ProjektDetail form1 = new ProjektDetail();
                form1.labelProjektName.Text = this.ProjektListeTable.CurrentRow.Cells[3].Value.ToString();
                form1.labelStartDatum.Text = this.ProjektListeTable.CurrentRow.Cells[4].Value.ToString();
                form1.labelEndeDatum.Text = this.ProjektListeTable.CurrentRow.Cells[5].Value.ToString();
                form1.labelBeschreibung.Text = this.ProjektListeTable.CurrentRow.Cells[6].Value.ToString();
                form1.ShowDialog();
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Projekt form1 = new Projekt();
            form1.ShowDialog();
        }
    }
}
