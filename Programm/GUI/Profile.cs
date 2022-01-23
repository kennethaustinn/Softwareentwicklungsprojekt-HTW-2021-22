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

        private void iconButton3_Click(object sender, EventArgs e)
        {
            profileBearbeiten form1 = new profileBearbeiten();
            form1.txtAbteilung.Text = this.labelAbteilung.Text;
            form1.txtAufgabenbereich.Text = this.labelAufgabenbereich.Text;
            form1.txtName.Text = this.labelName.Text;
            form1.txtVorname.Text = this.labelVorname.Text;
            form1.ShowDialog();
            this.Close();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            MitarbeiterPassword form2 = new MitarbeiterPassword();
            form2.labelName.Text = this.labelName.Text;
            form2.labelVorname.Text = this.labelVorname.Text;
            form2.ShowDialog();
            this.Close();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            if (iconButton4.Text == "Konto deaktivieren")
            {
                try
                {
                    Connection.DataSource();
                    con.connOpen();
                    MySqlCommand command = new MySqlCommand();
                    command.CommandText = ("update mitarbeiter set Deaktiviert = true where name ='" + this.labelName.Text + "'");
                    command.Connection = Connection.connMaster;
                    command.ExecuteNonQuery();
                    MessageBox.Show("Account deaktiviert");
                    con.connClose();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    Connection.DataSource();
                    con.connOpen();
                    MySqlCommand command = new MySqlCommand();
                    command.CommandText = ("update mitarbeiter set Deaktiviert = false where name ='" + this.labelName.Text + "'");
                    command.Connection = Connection.connMaster;
                    command.ExecuteNonQuery();
                    MessageBox.Show("Account aktiviert");
                    con.connClose();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
