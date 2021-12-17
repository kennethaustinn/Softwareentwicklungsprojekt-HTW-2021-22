using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAPI.Models
{
    public class Kompetenz
    {
        public int Kompetenz_ID { get; set; }
        public string Name { get; set; }
        public string Bezeichnung { get; set; }
        public string Alternativebezeichnung { get; set; }
        public string Beschreibung { get; set; }
    }
}
