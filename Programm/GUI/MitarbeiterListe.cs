using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
using RestAPI;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Threading.Tasks;
using System.Net;

namespace GUI
{
    public partial class MitarbeiterListe : Form
    {
        public MitarbeiterListe()
        {
            InitializeComponent();
        }

        private async void MitarbeiterListe_Shown(object sender, EventArgs e)
        {
            //HttpClient clint = new HttpClient();
            //clint.BaseAddress = new Uri("https://localhost:44340/");
            //HttpResponseMessage response = clint.GetAsync("api/mitarbeiter").Result;
            //var emp = response.Content.ReadAsAsync<IEnumerable<RestAPI.Models.Mitarbeiter>>.Result;
            //MitarbeiterListeTable.DataSource = emp;
            //string strurltest = string.Format("https://localhost:44340/api/mitarbeiter");
            //WebRequest requestObjGet = WebRequest.Create(strurltest);
            //requestObjGet.Method = "GET";
            //HttpWebRequest responsObjGet = null;
            //responsObjGet = (HttpWebResponse)requestObjGet.GetResponse();
            //var responce = await RestHelper.GetALL();
            //MitarbeiterListeTable.DataSource = responce;
        }


        private void MitarbeiterListeTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                Profile form1 = new Profile();
                form1.ShowDialog();
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            
            Hauptseite.hauptseite.openChildForm(new NeueMitarbeiter());
        }
    }
}
