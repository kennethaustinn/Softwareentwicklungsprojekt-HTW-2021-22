using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace GUI
{
    public partial class Login : Form
    {
        public static Login login = new Login();
        public Login()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "mitarbeiter")
            {
                this.Hide();
                MitarbeiterHauptseite.mitarbeiterHauptseite.ShowDialog();
                this.Close();
            }
            else
            {
                this.Hide();
                AdministratorHauptseite.administratorHauptseite.ShowDialog();
                this.Close();
            }
        }

        private void txtUsername_Click(object sender, EventArgs e)
        {
            txtUsername.BackColor = Color.White;
            panel3.BackColor = Color.White;
            txtPassword.BackColor = Color.WhiteSmoke;
            panel4.BackColor = Color.WhiteSmoke;
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtUsername.BackColor = Color.WhiteSmoke;
            panel3.BackColor = Color.WhiteSmoke;
            txtPassword.BackColor = Color.White;
            panel4.BackColor = Color.White;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconPictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
        }

        private void iconPictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }
        }

        private void VisitLink()
        {
            // Change the color of the link text by setting LinkVisited
            // to true.
            linkLabel1.LinkVisited = true;
            //Call the Process.Start method to open the default browser
            //with a URL:
            Process.Start("https://www.google.com/");
        }


    }
}
