using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GUI
{
    public partial class ProjektDetail : Form
    {
        public ProjektDetail()
        {
            InitializeComponent();
        }

        private void ProjektDetail_Load(object sender, EventArgs e)
        {
            DateTime start = DateTime.Parse(labelStartDatum.Text);
            DateTime ende = DateTime.Parse(labelEndeDatum.Text);
            TimeSpan duration = ende - start;
            labelLaufzeit.Text = duration.ToString("dd") + " Tag";
        }

    }
}
