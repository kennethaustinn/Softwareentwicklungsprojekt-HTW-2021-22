using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class NeueMitarbeiter : Form
    {
        insertData insrtd = new insertData();
        Connection con = new Connection();
        public NeueMitarbeiter()
        {
            InitializeComponent();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            insrtd.InsertData(textUser.Text, textPass.Text);
        }
    }
}
