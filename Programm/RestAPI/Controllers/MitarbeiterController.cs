using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
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

        [HttpGet]
        public JsonResult Get()
        {
            string query = @"
                    SELECT Mitarbeiter_ID, name, Vorname, Abteilung FROM mitarbeiter";
            DataTable table = new DataTable();
            string sqlDatasource = _configuration.GetConnectionString("KompetenzDatenbankcon");
            MySqlDataReader myReader;
            using(MySqlConnection mycon = new MySqlConnection(sqlDatasource))
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
    }
}
