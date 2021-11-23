using GUI.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class AdministratorHauptseite : Form
    { 

    public static AdministratorHauptseite administratorHauptseite = new AdministratorHauptseite();

    private int ImageNumber = 1;
    public AdministratorHauptseite()
        {
            InitializeComponent();
            this.pictureBox3.Show();
        }

        private void Slide()
        {
            if(ImageNumber == 4)
            {
                ImageNumber = 1;
            }
            string imagestring = $"_{ImageNumber}";
            pictureBox3.Image = (Image)Resources.ResourceManager.GetObject(imagestring);
            ImageNumber++;
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login.login.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new NeueMitarbeiter());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Slide();
        }

    }
}
