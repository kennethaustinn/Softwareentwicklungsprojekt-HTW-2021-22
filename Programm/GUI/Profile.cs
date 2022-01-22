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
    public partial class Profile : Form
    {
        Connection con = new Connection();

        public static Profile profile = new Profile();
        public Profile()
        {
            InitializeComponent();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.DataSource();
                con.connOpen();
                MySqlCommand command = new MySqlCommand();
                command.CommandText = "delete from mitarbeiter where benutzername = '" + this.labelBenutzername.Text + "';";
                command.Connection = Connection.connMaster;
                command.ExecuteNonQuery();
                MessageBox.Show("Account deleted");
                con.connClose();
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
