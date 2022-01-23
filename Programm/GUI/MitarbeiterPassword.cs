using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GUI
{
    public partial class MitarbeiterPassword : Form
    {
        /// <summary>
        /// Sucht die Connection bzw. ruft die Klasse ab.
        /// </summary>
        Connection con = new Connection();
        /// <summary>
        /// Für das Form Mitarbeiter Password wird erst alle die Sachen von dem Designer initialisiert 
        /// </summary>
        public MitarbeiterPassword()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Diese Event Click besteht darin, das Mitarbeiterpasswort in der Datenbank verändert
        /// durch das Connection mit Datenbank
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void speichernButton_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.DataSource();
                con.connOpen();
                MySqlCommand command = new MySqlCommand();
                con.connOpen();
                command.CommandText = ("update mitarbeiter set Passwort ='" + Encrypt.HashString(txtPassword.Text) + "' where name ='" + this.labelName.Text + "'");
                command.Connection = Connection.connMaster;
                command.ExecuteNonQuery();
                MessageBox.Show("Passwort aktualisiert");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
