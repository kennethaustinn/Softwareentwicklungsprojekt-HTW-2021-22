using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class KompetenzDetail : Form
    {
        /// <summary>
        /// Für das Form Kompetenz Detail wird erst alle die Sachen von dem Designer initialisiert 
        /// </summary>
        public KompetenzDetail()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Eventclick wenn das Button gedrückt wird, wird die Seite zum Bearbeiten des Kompetenzs geöffnet
        /// und die Textbox auf der Seite „Kompetenz bearbeiten“ sind bereits mit den Daten jedes Kompetenzs beschrieben
        /// <summary>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void iconButton3_Click(object sender, EventArgs e)
        {
            kompetenzBearbeiten form1 = new kompetenzBearbeiten();
            form1.labelKompetenzName.Text = this.labelKompetenzName.Text;
            form1.txtBezeichnung.Text = this.labelBezeichnung.Text;
            form1.txtAlternativeBezeichnung.Text = this.labelAlternative.Text;
            form1.txtBeschreibung.Text = this.labelBeschreibung.Text;
            form1.ShowDialog();
            this.Close();
        }
    }
}
