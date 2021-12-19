using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAPI.Models
{
    //Ein Anforderungstext für das JSON-Dokument und die Struktur dieses JSON-Dokuments (Mitarbeiter)
    public class Mitarbeiter
    {
        public int Mitarbeiter_ID { get; set; }        
        public string Name { get; set; }
        public string Vorname { get; set; }
        public string Abteilung { get; set; }
        public string Passwort { get; set; }
        public string Benutzername { get; set; }
        public string Aufgabenbereich { get; set; }
        public string Rolle { get; set; }

    }
}
