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
        insertData insrtd = new insertData();
        public Projekt()
        {
            InitializeComponent();
        }
        //Wenn die  „Speichern“ button gedrückt wird, werden die Daten mithilfe der Methode „insertprojekt“ aus der Klasse „insertdata“ mit Daten aus den Textboxen in die Datenbank geschrieben      
        private void speichernButton_Click(object sender, EventArgs e)
        {
            insrtd.InsertProjekt(txtProjektName.Text, dateTimePicker1.Text, dateTimePicker2.Text, txtBeschreibung.Text);
        }

    }
}
