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
        /// <summary>
        /// Sucht die Connection bzw. ruft die Klasse ab.
        /// </summary>
        Connection con = new Connection();
        /// <summary>
        /// Form der Profile
        /// </summary>
        public static Profile profile = new Profile();
        /// <summary>
        /// Für das Form Profile wird erst alle die Sachen von dem Designer initialisiert 
        /// </summary>
        public Profile()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Ein Event Click wenn das loschen Button gedrückt wird, werden eine Bestätigung angezeigt ob man das Konto löschen wird
        /// und wenn ja dann wird das Konto vom Datenbank gelöscht mit Verbindung mit MySQL (nur Admin kann das machen)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void iconButton2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sind Sie sicher das Konto zu löschen?", "Kompetenzdatenbank", MessageBoxButtons.OKCancel,
                       MessageBoxIcon.Information) == DialogResult.OK)
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
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
        /// <summary>
        /// Ein Event Click wenn das bearbeiten Button gedrückt wird, werden eine Form angezeigt damit man ihre Konto bearbeitenn kann
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Ein Event Click wenn das Passwort bearbeiten Button gedrückt wird, werden eine neue Form für das 
        /// bearbeiten der Mitarbeiter angezeigt (nur Admin kann das hier machen)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void iconButton1_Click(object sender, EventArgs e)
        {
            MitarbeiterPassword form2 = new MitarbeiterPassword();
            form2.labelName.Text = this.labelName.Text;
            form2.labelVorname.Text = this.labelVorname.Text;
            form2.ShowDialog();
            this.Close();
        }
        /// <summary>
        /// Ein Event Click wenn das Deaktivieren Button gedrückt wird, werden eine Bestätigung angezeigt ob man das Konto deaktivieren wird
        /// und wenn ja dann wird das Konto vom Datenbank deaktiviert mit Verbindung mit MySQL (nur Admin kann das machen)
        /// und auch angezeigt wenn das Konto doch deaktiviert kann man dann wieder aktivieren mit Verbindung MySQL
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void iconButton4_Click(object sender, EventArgs e)
        {
            
                if (iconButton4.Text == "Konto deaktivieren")
                {
                if (MessageBox.Show("Sind Sie sicher das Konto zu deaktivieren?", "Kompetenzdatenbank", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Information) == DialogResult.OK)
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
                }
                else
                {
                if (MessageBox.Show("Sind Sie sicher das Konto zu aktivieren?", "Kompetenzdatenbank", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Information) == DialogResult.OK)
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
}
