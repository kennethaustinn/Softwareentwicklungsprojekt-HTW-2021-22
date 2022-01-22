using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class Kompetenz : Form
    {
        insertData insrtd = new insertData();
        public Kompetenz()
        {
            InitializeComponent();
        }

        private void speichernButton_Click(object sender, EventArgs e)
        {
            insrtd.InsertKompetenz(txtKompetenzName.Text, txtBezeichnung.Text, txtAlternativeBezeichnung.Text, txtBeschreibung.Text);
        }
    }
}
