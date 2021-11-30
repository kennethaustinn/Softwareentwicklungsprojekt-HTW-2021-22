﻿using GUI.Properties;
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
    public partial class MitarbeiterHauptseite : Form
    {

        public static MitarbeiterHauptseite mitarbeiterHauptseite = new MitarbeiterHauptseite();

        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        public MitarbeiterHauptseite()
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

        private void openChildForm(Form childForm)
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

        private void ProfileButton_Click(object sender, EventArgs e)
        {
            Profile form1 = new Profile();
            form1.ShowDialog();
        }

        private void HomeLogo_Click(object sender, EventArgs e)
        {

            Reset();
            currentChildForm.Close();
        }

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

        //Minimize
        private void iconButton3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        //Maximize
        private void iconButton2_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        //Close
        private void iconButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void EinstellungenButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.Black);
            openChildForm(new Einstellungen());
        }

        private void MitarbeiterHauptseite_Load(object sender, EventArgs e)
        {
          TimeLabel.Text = DateTime.Now.ToLongTimeString();
          DateLabel.Text = DateTime.Now.ToLongDateString();
        }

        private void DateTimer_Tick(object sender, EventArgs e)
        {
            TimeLabel.Text = DateTime.Now.ToLongTimeString();
            DateTimer.Start();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login form1 = new Login();
            form1.ShowDialog();
            this.Close();
        }
    }
}
