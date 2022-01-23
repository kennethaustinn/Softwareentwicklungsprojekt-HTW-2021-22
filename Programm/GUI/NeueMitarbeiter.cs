 using System;
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
        /// <summary>
        /// ruft die Klasse insert data ab.
        /// </summary>
        insertData insrtd = new insertData();
        /// <summary>
        /// Für das Form NeueMitarbeiter wird erst alle die Sachen von dem Designer initialisiert 
        /// </summary>
        public NeueMitarbeiter()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Mit dem Event wird das Password Character lesbar wenn das Passwort Button gedrückt wird
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void iconButton1_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
        }
        /// <summary>
        /// Mit dem Event wird das Password Character únlesbar wenn das Passwort Button nicht mehr gedrückt wird
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void iconButton1_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        /// <summary>
        /// mit dem Event wird die ganze Eingabe in der Klasse insertData weitergeleitet und dort in Datenbank gespeichert
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void speichernButton_Click(object sender, EventArgs e)
        {
            if(txtUser.Text==""|| txtPassword.Text == "")
            {
                MessageBox.Show("Bitte die Benutzername und oder Passwort unbedingt ausfüllen!!");
            }
            insrtd.InsertData(txtUser.Text, txtPassword.Text, txtVorname.Text, txtName.Text, txtAufgabenbereich.Text, txtAbteilung.Text, comboRolle.Text);
            MessageBox.Show("Account erstellt");
        }

    }
}
