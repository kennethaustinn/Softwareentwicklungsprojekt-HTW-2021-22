using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace GUI
{
    public partial class Login : Form
    {
        Connection con = new Connection();
        

        public static Login login = new Login();
        public Login()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            SelectData(txtUsername.Text, txtPassword.Text);
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
            catch (Exception)
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
        /// <summary>
        /// Diese Methode uberprüft die Login Datei in MySQL Database, die schon angegeben (Benutzername und Passwort) 
        /// </summary>
        /// <param name="userInsert"></param>
        /// <param name="passInsert"></param>
        /// <returns></returns>
        private string SelectData(string userInsert, string passInsert)
        {
            try
            {
                Connection.DataSource();
                con.connOpen();
                MySqlCommand command = new MySqlCommand();
                command.CommandText = ("select * from mitarbeiter where (Benutzername, Hashedpasswort) = (@name, @password)");
                command.Parameters.AddWithValue("@name", userInsert);
                command.Parameters.AddWithValue("@password", Encrypt.HashString(passInsert));
                command.Connection = Connection.connMaster;
                MySqlDataReader reader = command.ExecuteReader();

               if (reader.Read())
                {
                    // Uberprüft ob es ein Administrator und Mitarbeiter
                    if (reader[8].ToString() == "Administrator")
                    {
                        this.Hide();
                        Hauptseite.hauptseite.NeueMitarbeiterButton.Show();
                        Hauptseite.hauptseite.MitarbeiterListeButton.Show();
                        Hauptseite.hauptseite.Username.Text = reader[1].ToString();
                        Hauptseite.hauptseite.ShowDialog();
                    }
                    else if (reader[8].ToString() == "Mitarbeiter")
                    {
                        this.Hide();
                        Hauptseite.hauptseite.NeueMitarbeiterButton.Hide();
                        Hauptseite.hauptseite.MitarbeiterListeButton.Hide();                       
                        Hauptseite.hauptseite.Username.Text = reader[1].ToString();
                        Hauptseite.hauptseite.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Rolle falsch eingegeben! Nur Mitarbeiter oder Administrator", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                else
                {
                    MessageBox.Show("Passwort falsch oder Sie haben kein Konto", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                return userInsert + passInsert;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
            finally
            {
                con.connClose();
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
