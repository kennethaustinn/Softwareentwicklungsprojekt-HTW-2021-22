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
    public partial class Einstellungen : Form
    {
        Connection con = new Connection();
        public Einstellungen()
        {
            InitializeComponent();
        }

        private void buttonChangeBenutzername_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.DataSource();
                con.connOpen();
                MySqlCommand command = new MySqlCommand();
                command.CommandText = ("update mitarbeiter set Benutzername ='" + txtBenutzername.Text + "' where Benutzername ='" + Hauptseite.hauptseite.Username.Text + "'");
                command.Connection = Connection.connMaster;
                command.ExecuteNonQuery();
                MessageBox.Show("Benutzername aktualisiert");
                con.connClose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
