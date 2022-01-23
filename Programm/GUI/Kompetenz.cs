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

        //Wenn die  „Speichern“ button gedrückt wird, werden die Daten mithilfe der Methode „insertkompetenz“ aus der Klasse „insertdata“ mit Daten aus den Textboxen in die Datenbank geschrieben      

        private void speichernButton_Click(object sender, EventArgs e)
        {
            insrtd.InsertKompetenz(txtKompetenzName.Text, txtBezeichnung.Text, txtAlternativeBezeichnung.Text, txtBeschreibung.Text);
        }
    }
}
