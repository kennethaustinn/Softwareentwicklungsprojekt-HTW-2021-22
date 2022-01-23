using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class Projekt : Form
    {
        /// <summary>
        /// ruft die Klasse insert data ab.
        /// </summary>
        insertData insrtd = new insertData();
        /// <summary>
        /// Für das Form Projekt wird erst alle die Sachen von dem Designer initialisiert 
        /// </summary>
        public Projekt()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Ein Click event wenn die  „Speichern“ button gedrückt wird, werden die Mitarbeiter 
        /// Datei im Datenbank mit den Daten von dieser Seite geschrieben
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void speichernButton_Click(object sender, EventArgs e)
        {
            insrtd.InsertProjekt(txtProjektName.Text, dateTimePicker1.Text, dateTimePicker2.Text, txtBeschreibung.Text);
            MessageBox.Show("Projekt hinzugefügt");
        }

    }
}
