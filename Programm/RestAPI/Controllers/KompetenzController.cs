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
    public class KompetenzController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public KompetenzController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        /// <summary>
        /// Ein Request um die Datei von Kompetenz Tabelle in der Datenbank aufrufen
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public JsonResult Get()
        {
            string query = @"
                    SELECT Kompetenz_ID, name, Bezeichnung, Alternativebezeichnung, Beschreibung FROM kompetenz";
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
        /// Ein Request um eine Datei in dem Kompetenz Tabelle von der Datenbank einzufügen
        /// </summary>
        /// <param name="kom"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult Post(Kompetenz kom)
        {
            string query = @"
                    insert into Kompetenz(Kompetenz_ID, name, Bezeichnung, Alternativebezeichnung, Beschreibung) values (@Kompetenz_ID, @name, @Bezeichnung, @Alternativebezeichnung, @Beschreibung)";
            DataTable table = new DataTable();
            string sqlDatasource = _configuration.GetConnectionString("KompetenzDatenbankcon");
            MySqlDataReader myReader;
            using (MySqlConnection mycon = new MySqlConnection(sqlDatasource))
            {
                mycon.Open();
                using (MySqlCommand myCommand = new MySqlCommand(query, mycon))
                {
                    myCommand.Parameters.AddWithValue("@Kompetenz_ID", kom.Kompetenz_ID);
                    myCommand.Parameters.AddWithValue("@name", kom.Name);
                    myCommand.Parameters.AddWithValue("@Bezeichnung", kom.Bezeichnung);
                    myCommand.Parameters.AddWithValue("@Alternativebezeichnung", kom.Alternativebezeichnung);
                    myCommand.Parameters.AddWithValue("@Beschreibung", kom.Beschreibung);              
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);

                    myReader.Close();
                    mycon.Close();
                }
            }
            return new JsonResult("Added");
        }

        /// <summary>
        /// Ein Request um eine Datei in dem Kompetenz Tabelle von der Datenbank zu editieren
        /// </summary>
        /// <param name="kom"></param>
        /// <returns></returns>
        [HttpPut]
        public JsonResult put(Kompetenz kom)
        {
            string query = @"
                    update kompetenz set name = @name where Kompetenz_Id = @Kompetenz_ID";
            DataTable table = new DataTable();
            string sqlDatasource = _configuration.GetConnectionString("KompetenzDatenbankcon");
            MySqlDataReader myReader;
            using (MySqlConnection mycon = new MySqlConnection(sqlDatasource))
            {
                mycon.Open();
                using (MySqlCommand myCommand = new MySqlCommand(query, mycon))
                {
                    myCommand.Parameters.AddWithValue("@Kompetenz_ID", kom.Kompetenz_ID);
                    myCommand.Parameters.AddWithValue("@name", kom.Name);
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);

                    myReader.Close();
                    mycon.Close();
                }
            }
            return new JsonResult("Updated");
        }

        /// <summary>
        /// in Request um eine Datei in dem Kompetenz Tabelle von der Datenbank zu entfernen
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public JsonResult delete(int id)
        {
            string query = @"
                    delete from kompetenz where Kompetenz_ID = @Kompetenz_ID";
            DataTable table = new DataTable();
            string sqlDatasource = _configuration.GetConnectionString("KompetenzDatenbankcon");
            MySqlDataReader myReader;
            using (MySqlConnection mycon = new MySqlConnection(sqlDatasource))
            {
                mycon.Open();
                using (MySqlCommand myCommand = new MySqlCommand(query, mycon))
                {
                    myCommand.Parameters.AddWithValue("@Kompetenz_ID", id);
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
