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
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
