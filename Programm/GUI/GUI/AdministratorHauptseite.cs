using GUI.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace GUI
{
    public partial class AdministratorHauptseite : Form
    { 

    public static AdministratorHauptseite administratorHauptseite = new AdministratorHauptseite();

    private IconButton currentBtn;
    private Panel leftBorderBtn;
    public AdministratorHauptseite()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelSideMenu.Controls.Add(leftBorderBtn);
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

        private void NeueMitarbeiterButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.Black);
        }

        private void MitarbeiterListeButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.Black);
        }

        private void ProjekteListeButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.Black);
        }

        private void KompetenzListeButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.Black);
        }

        private void EinstellungenButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.Black);
        }

        private void HomeLogo_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            currentChildFormText.Text = "Home";
        }







        // Image Sliding Main Menu

        //private int ImageNumber = 1;

        //private void Slide()
        //{
        //    if(ImageNumber == 4)
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
