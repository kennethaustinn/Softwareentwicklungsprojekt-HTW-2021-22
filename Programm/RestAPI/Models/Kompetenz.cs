using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAPI.Models
{
    //Ein Anforderungstext für das JSON-Dokument und die Struktur dieses JSON-Dokuments (Kompetenz)
    public class Kompetenz
    {
        public int Kompetenz_ID { get; set; }
        public string Name { get; set; }
        public string Bezeichnung { get; set; }
        public string Alternativebezeichnung { get; set; }
        public string Beschreibung { get; set; }
    }
}
