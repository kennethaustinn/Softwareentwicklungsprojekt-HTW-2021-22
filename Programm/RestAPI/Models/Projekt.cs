using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAPI.Models
{
    //Ein Anforderungstext für das JSON-Dokument und die Struktur dieses JSON-Dokuments (Projekt)
    public class Projekt
    {
        public int Projekt_ID { get; set; }
        public string Name { get; set; }
        public DateTime Start { get; set; }
        public DateTime Ende { get; set; }
        public string Beschreibung { get; set; }
  
    }
}
