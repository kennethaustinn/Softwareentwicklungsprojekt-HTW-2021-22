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
        Connection con = new Connection();
        public MitarbeiterPassword()
        {
            InitializeComponent();
        }

        //Diese Methode besteht darin, das Mitarbeiterpasswort in der Datenbank basierend auf ihrem Namen in der Datenbank zu ändern
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
