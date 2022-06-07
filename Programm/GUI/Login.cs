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
using System.Runtime.InteropServices;

namespace GUI
{
    public partial class Login : Form
    {
        /// <summary>
        /// Form der Login
        /// </summary>
        public static Login login = new Login();
        /// <summary>
        /// Für das Form Login wird erst alle die Sachen von dem Designer initialisiert 
        /// </summary>
        public Login()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Clickevent für Login es würde hier eine Verbindung mit dem Rest API aufgerufen und die Eingabe wurde
        /// mit dem Methode Select Data in Datenbank überprüft
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginButton_Click(object sender, EventArgs e)
        {
            
            RestHelper restHelper = new RestHelper();
            restHelper.endPoint = "https://localhost:44340/api/mitarbeiter/";
            string strResponse = string.Empty;
            strResponse = restHelper.makeRequest();
            restHelper.userName = txtUsername.Text;
            restHelper.password = txtPassword.Text;
            SelectData(txtUsername.Text, txtPassword.Text);
        }
        /// <summary>
        /// Mit dem Clickevent wird die Hintergrundsfarbe von dem Usernametextbox sich geändert
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtUsername_Click(object sender, EventArgs e)
        {
            txtUsername.BackColor = Color.White;
            panel3.BackColor = Color.White;
            txtPassword.BackColor = Color.WhiteSmoke;
            panel4.BackColor = Color.WhiteSmoke;
        }
        /// <summary>
        /// Mit dem Clickevent wird die Hintergrundsfarbe von dem Passwordtextbox sich geändert
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtUsername.BackColor = Color.WhiteSmoke;
            panel3.BackColor = Color.WhiteSmoke;
            txtPassword.BackColor = Color.White;
            panel4.BackColor = Color.White;
        }
        /// <summary>
        /// Um das Applikation zu schliessen durch das Click des X Buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Mit dem Event wird das Password Character lesbar wenn das Schloss Icon noch gedrückt wird
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void iconPictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
        }
        /// <summary>
        /// Mit dem Event wird das Password Character unlesbar wenn das Schloss Icon nicht mehr gedrückt wird
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void iconPictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }
        /// <summary>
        /// Wenn das Link geklickt wird diesem Event durchgeführt und das Web wird geöffnet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            // Ändern die Farbe des Linktextes, indem das besuchte Link auf true setzen
            linkLabel1.LinkVisited = true;
            // Es rüft sich die Methode Process.Start auf, um den Standardbrowser mit einer URL zu öffnen
            Process.Start("https://www.google.com/");
        }
        /// <summary>
        /// Diese Methode uberprüft die Mitarbeiter Datei in MySQL Database, die schon angegeben (Benutzername und Passwort) 
        /// </summary>
        /// <param name="userInsert"> Die angegebene Benutzername vom Benutzer bei Login</param>
        /// <param name="passInsert"> Das angegebene Passwort vom Benutzer bei Login</param>
        /// <returns> Ergibt sich die angegebene Benutzername und das Passwort zurück als Zeichnen ob es erfolgreich in der Datenbank gespeichert oder nicht</returns>
        /// 
        private string SelectData(string userInsert, string passInsert)
        {
            Connection con = new Connection();
            try
            {
                Connection.DataSource();
                con.connOpen();
                MySqlCommand command = new MySqlCommand();
                command.CommandText = ("select * from mitarbeiter where (Benutzername, passwort) = (@name, @password)");
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
                        Hauptseite.hauptseite.labelName.Text = reader[5].ToString();
                        Hauptseite.hauptseite.ShowDialog();
                    }
                    else if (reader[8].ToString() == "Mitarbeiter")
                    {
                        if (reader[9].ToString() == "False")
                        {
                            this.Hide();
                            Hauptseite.hauptseite.NeueMitarbeiterButton.Hide();
                            Hauptseite.hauptseite.MitarbeiterListeButton.Hide();
                            Hauptseite.hauptseite.Username.Text = reader[1].ToString();
                            Hauptseite.hauptseite.labelName.Text = reader[5].ToString();
                            Hauptseite.hauptseite.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Konto Deaktiviert, Bitte melden Sie sich bei Administrator", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }                                            
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

            finally
            {
                con.connClose();
            }
        }
        /// <summary>
        /// Mit dem Clickevent kann man das aktuelle Form minimeren
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void iconButton1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        /// <summary>
        /// Um das Message vom Ort der Panel schicken kann
        /// </summary>
        /// <param name="hWnd"> Ort die Panel</param>
        /// <param name="wMsg"> Message damit man zur system command schicken kann</param>
        /// <param name="wParam"> movement von links nach rechts </param>
        /// <param name="lParam"> movement von oben nach unten </param>
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
