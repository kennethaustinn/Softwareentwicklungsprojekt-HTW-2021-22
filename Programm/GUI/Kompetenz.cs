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
        /// <summary>
        /// ruft die Klasse insert data ab.
        /// </summary>
        insertData insrtd = new insertData();
        /// <summary>
        /// Für das Form Kompetenz wird erst alle die Sachen von dem Designer initialisiert 
        /// </summary>
        public Kompetenz()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Click event für Speichern button wenn die gedrückt wird, werden die Daten mithilfe der Methode „insertkompetenz“ 
        /// aus der Klasse „insertdata“ mit Daten
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void speichernButton_Click(object sender, EventArgs e)
        {
            insrtd.InsertKompetenz(txtKompetenzName.Text, txtBezeichnung.Text, txtAlternativeBezeichnung.Text, txtBeschreibung.Text);
            MessageBox.Show("Kompetenz hinzugefügt");
        }
    }
}
