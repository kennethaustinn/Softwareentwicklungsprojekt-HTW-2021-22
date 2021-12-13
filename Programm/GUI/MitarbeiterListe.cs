using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class MitarbeiterListe : Form
    {
        public MitarbeiterListe()
        {
            InitializeComponent();
        }

        private void MitarbeiterListe_Shown(object sender, EventArgs e)
        {
            MitarbeiterListeTable.Rows.Add(
                new object[]
                {
                    1,
                    "Mustermann",
                    "Müller",
                    "Design",
                    "Bildverarbeitung"
                }
                );
            MitarbeiterListeTable.Rows.Add(
               new object[]
               {
                    2,
                    "Morris",
                    "Philip",
                    "Coding",
                    "Programmierung"
               }
               );
        }


        private void MitarbeiterListeTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                Profile form1 = new Profile();
                form1.ShowDialog();
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            
            Hauptseite.hauptseite.openChildForm(new NeueMitarbeiter());
        }
    }
}
