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

namespace GUI
{
    public partial class AdministratorHauptseite : Form
    { 

    public static AdministratorHauptseite administratorHauptseite = new AdministratorHauptseite();

    private IconButton currentBtn;
    private Panel leftBorderBtn;
    private Form currentChildForm;
    public AdministratorHauptseite()
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

    private void ActivateButton(object senderBtn, Color color)
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

        

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (currentChildForm != null)
                currentChildForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(childForm);
            panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void NeueMitarbeiterButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.Black);
            openChildForm(new NeueMitarbeiter());
        }

        private void MitarbeiterListeButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.Black);
            openChildForm(new MitarbeiterListe());
        }

        private void ProjekteListeButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.Black);
            openChildForm(new ProjektListe());
        }

        private void KompetenzListeButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.Black);
            openChildForm(new KompetenzListe());
        }

        private void EinstellungenButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.Black);
            openChildForm(new Einstellungen());
        }

        private void HomeLogo_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
            Reset();
        }

        private void Reset()
        {
            if (activeForm != null)
            {
                DisableButton();
                activeForm.Close();
                leftBorderBtn.Visible = false;
                iconCurrentChildForm.IconChar = IconChar.Home;
                currentChildFormText.Text = "Home";
            }
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

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

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        //private int ImageNumber = 1;

        //private void Slide()
        //{
        //    if (ImageNumber == 4)
        //    {
        //        ImageNumber = 1;
        //    }
        //    string imagestring = $"_{ImageNumber}";
        //    pictureBox3.Image = (Image)Resources.ResourceManager.GetObject(imagestring);
        //    ImageNumber++;
        //}

        //private void timer1_Tick(object sender, EventArgs e)
        //{
        //    Slide();
        //}

    }
}
