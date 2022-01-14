using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using RestAPI.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;

namespace RestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MitarbeiterController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public MitarbeiterController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        /// <summary>
        /// Ein Request um die Datei von Mitarbeiter Tabelle in der Datenbank aufrufen
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public JsonResult Get()
        {
            string query = @"
                    SELECT Mitarbeiter_ID, name, Vorname, Abteilung FROM mitarbeiter";
            DataTable table = new DataTable();
            string sqlDatasource = _configuration.GetConnectionString("KompetenzDatenbankcon");
            MySqlDataReader myReader;
            using (MySqlConnection mycon = new MySqlConnection(sqlDatasource))
            {
                mycon.Open();
                using (MySqlCommand myCommand = new MySqlCommand(query, mycon))
                {
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);

                    myReader.Close();
                    mycon.Close();
                }
            }
            return new JsonResult(table);
        }

        /// <summary>
        /// Ein Request um eine Datei in dem Mitarbeiter Tabelle von der Datenbank einzufügen
        /// </summary>
        /// <param name="mit"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult Post(Mitarbeiter mit)
        { 
            string query = @"
                    insert into Mitarbeiter(Benutzername, Passwort, Aufgabenbereich, Rolle, name, Mitarbeiter_ID, vorname, Abteilung) values (@Benutzername,@Passwort,@Aufgabenbereich,@Rolle, 
                                @name,@Mitarbeiter_ID,@vorname,@Abteilung)";
            DataTable table = new DataTable();
            string sqlDatasource = _configuration.GetConnectionString("KompetenzDatenbankcon");
            MySqlDataReader myReader;
            using (MySqlConnection mycon = new MySqlConnection(sqlDatasource))
            {
                mycon.Open();
                using (MySqlCommand myCommand = new MySqlCommand(query, mycon))
                {
                    myCommand.Parameters.AddWithValue("@Benutzername", mit.Benutzername);
                    myCommand.Parameters.AddWithValue("@Passwort", mit.Passwort);
                    myCommand.Parameters.AddWithValue("@Aufgabenbereich", mit.Aufgabenbereich);
                    myCommand.Parameters.AddWithValue("@Rolle", mit.Rolle);
                    myCommand.Parameters.AddWithValue("@Abteilung", mit.Abteilung);
                    myCommand.Parameters.AddWithValue("@Mitarbeiter_ID", mit.Mitarbeiter_ID);
                    myCommand.Parameters.AddWithValue("@name", mit.Name);
                    myCommand.Parameters.AddWithValue("@vorname", mit.Vorname);
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);

                    myReader.Close();
                    mycon.Close();
                }
            }
            return new JsonResult("Added");
        }

        /// <summary>
        /// Ein Request um eine Datei in dem Mitarbeiter Tabelle von der Datenbank zu editieren
        /// </summary>
        /// <param name="mit"></param>
        /// <returns></returns>
        [HttpPut]
        public JsonResult put(Mitarbeiter mit)
        {
            string query = @"
                    update mitarbeiter set name = @name where Mitarbeiter_ID = @Mitarbeiter_ID";
            DataTable table = new DataTable();
            string sqlDatasource = _configuration.GetConnectionString("KompetenzDatenbankcon");
            MySqlDataReader myReader;
            using (MySqlConnection mycon = new MySqlConnection(sqlDatasource))
            {
                mycon.Open();
                using (MySqlCommand myCommand = new MySqlCommand(query, mycon))
                {
                    myCommand.Parameters.AddWithValue("@Mitarbeiter_ID", mit.Mitarbeiter_ID);
                    myCommand.Parameters.AddWithValue("@name", mit.Name);
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);

                    myReader.Close();
                    mycon.Close();
                }
            }
            return new JsonResult("Updated");
        }

        /// <summary>
        /// Ein Request um eine Datei in dem Mitarbeiter Tabelle von der Datenbank zu entfernen
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public JsonResult delete(int id)
        {
            string query = @"
                    delete from mitarbeiter where Mitarbeiter_ID = @Mitarbeiter_ID";
            DataTable table = new DataTable();
            string sqlDatasource = _configuration.GetConnectionString("KompetenzDatenbankcon");
            MySqlDataReader myReader;
            using (MySqlConnection mycon = new MySqlConnection(sqlDatasource))
            {
                mycon.Open();
                using (MySqlCommand myCommand = new MySqlCommand(query, mycon))
                {
                    myCommand.Parameters.AddWithValue("@Mitarbeiter_ID", id);
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    mycon.Close();
                }
            }
            return new JsonResult("Deleted");

        }
    }
}
