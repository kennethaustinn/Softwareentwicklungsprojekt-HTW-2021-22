using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using RestAPI.Models;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjektController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public ProjektController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        /// <summary>
        /// Ein Request um die Datei von Projekt Tabelle in der Datenbank aufrufen
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public JsonResult Get()
        {
            string query = @"
                    SELECT Projekt_ID, name, Start, Ende, Beschreibung FROM projekt";
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
        /// Ein Request um eine Datei in dem Projekt Tabelle von der Datenbank einzufügen
        /// </summary>
        /// <param name="pro"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult Post(Projekt pro)
        {
            string query = @"
                    insert into projekt(Projekt_ID, name, Start, Ende, Beschreibung) values (@Projekt_ID, @name, @Start, @Ende, @Beschreibung)";
            DataTable table = new DataTable();
            string sqlDatasource = _configuration.GetConnectionString("KompetenzDatenbankcon");
            MySqlDataReader myReader;
            using (MySqlConnection mycon = new MySqlConnection(sqlDatasource))
            {
                mycon.Open();
                using (MySqlCommand myCommand = new MySqlCommand(query, mycon))
                {
                    myCommand.Parameters.AddWithValue("@Projekt_ID", pro.Projekt_ID);
                    myCommand.Parameters.AddWithValue("@name", pro.Name);
                    myCommand.Parameters.AddWithValue("@Start", pro.Start);
                    myCommand.Parameters.AddWithValue("@Ende", pro.Ende);
                    myCommand.Parameters.AddWithValue("@Beschreibung", pro.Beschreibung);
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);

                    myReader.Close();
                    mycon.Close();
                }
            }
            return new JsonResult("Added");
        }

        /// <summary>
        /// Ein Request um eine Datei in dem Projekt Tabelle von der Datenbank zu editieren
        /// </summary>
        /// <param name="pro"></param>
        /// <returns></returns>
        [HttpPut]
        public JsonResult put(Projekt pro)
        {
            string query = @"
                    update projekt set name = @name where Projekt_ID = @Projekt_ID";
            DataTable table = new DataTable();
            string sqlDatasource = _configuration.GetConnectionString("KompetenzDatenbankcon");
            MySqlDataReader myReader;
            using (MySqlConnection mycon = new MySqlConnection(sqlDatasource))
            {
                mycon.Open();
                using (MySqlCommand myCommand = new MySqlCommand(query, mycon))
                {
                    myCommand.Parameters.AddWithValue("@Projekt_ID", pro.Projekt_ID);
                    myCommand.Parameters.AddWithValue("@name", pro.Name);
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);

                    myReader.Close();
                    mycon.Close();
                }
            }
            return new JsonResult("Updated");
        }

        /// <summary>
        /// Ein Request um eine Datei in dem Projekt Tabelle von der Datenbank zu entfernen
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public JsonResult delete(int id)
        {
            string query = @"
                    delete from projekt where Projekt_ID = @Projekt_ID";
            DataTable table = new DataTable();
            string sqlDatasource = _configuration.GetConnectionString("KompetenzDatenbankcon");
            MySqlDataReader myReader;
            using (MySqlConnection mycon = new MySqlConnection(sqlDatasource))
            {
                mycon.Open();
                using (MySqlCommand myCommand = new MySqlCommand(query, mycon))
                {
                    myCommand.Parameters.AddWithValue("@Projekt_ID", id);
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
