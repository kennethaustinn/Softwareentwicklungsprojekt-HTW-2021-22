using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class ProjektListe : Form
    {
        public ProjektListe()
        {
            InitializeComponent();
        }

        private void ProjektListe_Shown(object sender, EventArgs e)
        {
            ProjektListeTable.Rows.Add(
             new object[]
             {
                    1,
                    "Kompetenzdatenbank",
                    "6 Monate",
             }
             );
            ProjektListeTable.Rows.Add(
               new object[]
               {
                    2,
                    "Webapplikation",
                    "3 Monate"
               }
               );
        }


        private void ProjektListeTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                Projekt form1 = new Projekt();
                form1.ShowDialog();
            }
        }
    }
}
