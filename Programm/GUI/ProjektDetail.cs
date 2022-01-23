using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class ProjektDetail : Form
    {
        public ProjektDetail()
        {
            InitializeComponent();
        }

        //Beim Laden der Seite von Projektdetail wird die Dauer des Projekts mit der Methode Timespan berechnet und in LabelLaufzeit geschrieben
        private void ProjektDetail_Load(object sender, EventArgs e)
        {
            DateTime start = DateTime.Parse(labelStartDatum.Text);
            DateTime ende = DateTime.Parse(labelEndeDatum.Text);
            TimeSpan duration = ende - start;
            labelLaufzeit.Text = duration.ToString("dd") + " Tag";
        }

        //Wenn die  „Bearbeiten“ Button gedrückt wird, wird die Seite zum Bearbeiten des Projekts geöffnet und die Textbox auf der Seite „Projekt bearbeiten“ sind bereits mit den Daten jedes Projekts beschrieben
        private void iconButton3_Click(object sender, EventArgs e)
        {
            projektBearbeiten form1 = new projektBearbeiten();
            form1.labelProjektName.Text = this.labelProjektName.Text;
            form1.txtBeschreibung.Text = this.labelBeschreibung.Text;
            form1.dateTimePicker1.Text = this.labelStartDatum.Text;
            form1.dateTimePicker2.Text = this.labelEndeDatum.Text;
            form1.ShowDialog();
            this.Close();
        }
    }
}
