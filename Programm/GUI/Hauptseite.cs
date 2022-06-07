using GUI.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;

namespace GUI
{
    //  Zu Hilfe für die Interaktion jeweilige Forms und Panel wurde diese Quelle verwendet : 
    public partial class Hauptseite : Form
    {
        /// <summary>
        /// Form der Hauptseite
        /// </summary>
        public static Hauptseite hauptseite = new Hauptseite();

        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
    
        /// <summary>
        /// Sucht die Connection bzw. ruft die Klasse ab.
        /// </summary>
        Connection con = new Connection();
        /// <summary>
        /// Für das Form Hauptseite wird erst alle die Sachen von dem Designer initialisiert
        /// Sowie das Button Border für das Panel Menu wird hier initialisiert.
        /// </summary>
        public Hauptseite()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelSideMenu.Controls.Add(leftBorderBtn);

            //ControlBox entfernen
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        /// <summary>
        /// initialisiert das Button, das gerade gedrückt wird wo auf dem MenuForm aktiv ist,
        /// hier ändert sich die Farbe das aktuelle Button und das Bild Format ändert sich auch nach rechte Seite
        /// nach dem Text im Button 
        /// </summary>
        /// <param name="senderBtn">als Parameter hier ist das gerade gedrückte Button wird im object
        /// als sender Button geliefert</param>
        /// <param name="color"> als Parameter ist die Farbe gedrückte Button geliefert</param>
        public void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                //left Border Button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                //Icon Current Form
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                currentChildFormText.Text = currentBtn.Text;
            }
        }
        /// <summary>
        /// Diese Methode wird verwendet, um die gerade aktive Button zu deaktivieren,
        /// damit sie in das normale Format zurückkehrt.
        /// </summary>
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.ForeColor = Color.WhiteSmoke;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        /// <summary>
        /// Wird das Form im PanelChildForm hier neue abgerufen und angezeigt. Mit dem Parameter Form
        /// die man gerade gedrückt von dem beliebigen Button.
        /// </summary>
        /// <param name="childForm"> aktuelles Form, das wir angeklickt haben </param>
        public void openChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(childForm);
            panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        /// <summary>
        /// Ein Eventhandler wenn das Button Neue Mitarbeiter angeklickt dann wird das Neue Mitarbeiter Form geladen,
        /// sowie der Neue Mitarbeiter im PanelMenu wird aktualisiert
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NeueMitarbeiterButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.Black);
            openChildForm(new NeueMitarbeiter());
        }
        /// <summary>
        /// Ein Eventhandler wenn das Button Mitarbeiter Liste angeklickt dann wird das Mitarbeiter Liste Form geladen,
        /// sowie die Mitarbeiter Liste im PanelMenu wird aktualisiert
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MitarbeiterListeButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.Black);
            openChildForm(new MitarbeiterListe());
        }
        /// <summary>
        /// Ein Eventhandler wenn das Button Projekt Liste angeklickt dann wird das Projekt Liste Form geladen,
        /// sowie das Projekt Liste im PanelMenu wird aktualisiert
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProjekteListeButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.Black);
            openChildForm(new ProjektListe());
        }
        /// <summary>
        /// Ein Eventhandler wenn das Button Kompetenz angeklickt dann wird das Kompetenz Form geladen,
        /// sowie das Kompetenz Button im PanelMenu wird aktualisiert
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KompetenzListeButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.Black);
            openChildForm(new KompetenzListe());
        }
        /// <summary>
        /// Ein Eventhandler wenn das Button Einstellungen angeklickt dann wird das Einstellungen Form geladen,
        /// sowie das Einstellungen Button im PanelMenu wird aktualisiert
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EinstellungenButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.Black);
            openChildForm(new Einstellungen());
        }
        /// <summary>
        /// Ein Eventhandler wenn das Button Home angeklickt dann wird das Home Form geladen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HomeLogo_Click(object sender, EventArgs e)
        {
            Reset();
            currentChildForm.Close();           
        }
        /// <summary>
        /// setzt die aktuell aktive Button durch Aufruf einer DisableButton Methode
        /// </summary>
        private void Reset()
        {
            if (currentChildForm != null)
            {
                DisableButton();
                currentChildForm.Close();
                leftBorderBtn.Visible = false;
                iconCurrentChildForm.IconChar = IconChar.Home;
                currentChildFormText.Text = "Home";
            }
        }

        /// <summary>
        /// Drag Form
        /// </summary>
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
        /// <summary>
        /// Ein Eventhandler damit man das Form sich verschieben kann
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        /// <summary>
        /// Mit dem Clickevent kann man das aktuelle Form minimeren
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        /// <summary>
        /// Mit dem Clickevent kann man das aktuelle Form maximieren
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }    
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }
        /// <summary>
        /// Um das Applikation zu schliessen durch das Click des X Buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Mit dem Event wird das Datum und die Uhrzeit in der Hauptseite angezeigt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AdministratorHauptseite_Load(object sender, EventArgs e)
        {
            //DateTimer.Start();
            TimeLabel.Text = DateTime.Now.ToLongTimeString();
            DateLabel.Text = DateTime.Now.ToLongDateString();
        }
        /// <summary>
        /// Hier wird das aktuelle Datum und Zeit geladen in UI
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DateTimer_Tick(object sender, EventArgs e)
        {
            TimeLabel.Text = DateTime.Now.ToLongTimeString();
            DateTimer.Start();
        }

        /// <summary>
        /// Ein Clickevent damit wird das neue Profilform der Benutzer angezeigt mit den Daten 
        /// aus der Datenbank mit der Verbindung von MySQL
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProfileButton_Click(object sender, EventArgs e)
        {

            try
            {
            Connection.DataSource();
            con.connOpen();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = ("select * from mitarbeiter where Benutzername = '"+ Username.Text +"'");
            command.Connection = Connection.connMaster;
            MySqlDataReader reader = command.ExecuteReader();
            reader.Read();
            Profile form1 = new Profile();           
            form1.labelBenutzername.Text = reader[1].ToString();
            form1.labelName.Text = reader[5].ToString();
            form1.labelVorname.Text = reader[4].ToString();
            form1.labelAufgabenbereich.Text = reader[6].ToString();
            form1.labelAbteilung.Text = reader[7].ToString();
            form1.label2.Text = GetKompetenz();
            form1.label9.Text = GetProjekt();
            form1.iconButton1.Hide();
            form1.iconButton2.Hide();
            form1.iconButton4.Hide();
            form1.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private string GetKompetenz()
        {
            Connection.DataSource();
            con.connOpen();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = ("select kompetenz.Name from kompetenz, mitarbeiter_hat_kompetenz, mitarbeiter " +
                "where kompetenz.Kompetenz_ID = mitarbeiter_hat_kompetenz.Zugeordnete_Kompetenz " +
                "and mitarbeiter.Mitarbeiter_ID = mitarbeiter_hat_kompetenz.Zugeordnete_Mitarbeiter and benutzername = '" + Username.Text + "'");
            command.Connection = Connection.connMaster;
            MySqlDataReader reader = command.ExecuteReader();
            reader.Read();
            string a = reader[0].ToString();
            return a;
        }

        private string GetProjekt()
        {
            Connection.DataSource();
            con.connOpen();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = ("select projekt.Name from projekt, mitarbeiter_hat_projekt, mitarbeiter " +
                "where mitarbeiter.Mitarbeiter_ID = mitarbeiter_hat_projekt.Zugeordnete_Mitarbeiter " +
                "and projekt.Projekt_ID = mitarbeiter_hat_projekt.Zugeordnete_Projekt and benutzername = '" + Username.Text + "'");
            command.Connection = Connection.connMaster;
            MySqlDataReader reader = command.ExecuteReader();
            reader.Read();
            string a = reader[0].ToString();
            return a;
        }

        /// <summary>
        /// Ein Clickevent, der Benutzer wird von der Hauptseite ausgeloggt  und zurück zum Login
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LogoutButton_Click(object sender, EventArgs e)
        {
            Reset();
            this.Hide();
            Login m = new Login();
            m.Show();
         }

        private void iconPictureBox2_Click(object sender, EventArgs e)
        {
            
            MonthCalendar monthCalendar = new MonthCalendar();
            iconPictureBox2.Controls.Add(monthCalendar);
        }
    }
}
