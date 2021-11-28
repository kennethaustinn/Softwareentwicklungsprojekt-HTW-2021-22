using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class KompetenzListe : Form
    {
        public KompetenzListe()
        {
            InitializeComponent();
        }


        private void ProjektListeTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                Kompetenz form1 = new Kompetenz();
                form1.ShowDialog();
            }
        }

        private void KompetenzListe_Shown(object sender, EventArgs e)
        {
            ProjektListeTable.Rows.Add(
            new object[]
            {
                    1,
                    "Kompetenzdatenbank",
            }
            );
            ProjektListeTable.Rows.Add(
               new object[]
               {
                    2,
                    "Webapplikation",
               }
               );
        }
    }
}
