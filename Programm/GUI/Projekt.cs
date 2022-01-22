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
       
        private void speichernButton_Click(object sender, EventArgs e)
        {
            insrtd.InsertProjekt(txtProjektName.Text, dateTimePicker1.Text, dateTimePicker2.Text, txtBeschreibung.Text);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
