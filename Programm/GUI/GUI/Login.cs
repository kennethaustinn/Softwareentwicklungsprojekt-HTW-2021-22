using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Login : Form
    {
        public static Login login = new Login();
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtUsername.Focus();
        }

        private void checkbxShowPas_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbxShowPas.Checked)
            {
                txtPassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            //timer1.Start();
            this.Hide();
            //int counter = 0;
            //counter++;
            //Wilkommen form2 = new  Wilkommen();
            //form2.ShowDialog();
            //if (counter == 10)
            //   timer1.Stop();
            //this.Hide();
            AdministratorHauptseite.administratorHauptseite.ShowDialog();
            this.Close();

        }
    }
}
