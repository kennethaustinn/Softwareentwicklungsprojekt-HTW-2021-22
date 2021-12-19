﻿ using System;
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
        /// <summary>
        /// mit dem Event wird die ganze Eingabe in der Klasse insertData weitergeleitet und dort in Datenbank gespeichert
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void iconButton3_Click(object sender, EventArgs e)
        {
            if(txtUser.Text==""|| txtPassword.Text == "")
            {
                MessageBox.Show("Bitte die Benutzername und oder Passwort unbedingt ausfüllen!!");
            }
            insrtd.InsertData(txtUser.Text, txtPassword.Text, txtVorname.Text, txtName.Text, txtAufgabenbereich.Text, txtAbteilung.Text, txtRolle.Text);
        }

        private void iconButton1_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
        }

        private void iconButton1_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }
    }
}
