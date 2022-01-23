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
    public partial class projektBearbeiten : Form
    {
        Connection con = new Connection();
        public projektBearbeiten()
        {
            InitializeComponent();
        }

        private void speichernButton_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.DataSource();
                con.connOpen();
                MySqlCommand command = new MySqlCommand();
                command.CommandText = ("update projekt set Start ='" + dateTimePicker1.Text + "', ende ='" + dateTimePicker2.Text + "', beschreibung ='" +txtBeschreibung.Text +"' where name = '" + this.labelProjektName.Text + "'");
                command.Connection = Connection.connMaster;
                command.ExecuteNonQuery();
                MessageBox.Show("Projekt aktualisiert");
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
