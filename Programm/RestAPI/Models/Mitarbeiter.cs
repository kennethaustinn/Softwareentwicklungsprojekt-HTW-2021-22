using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAPI.Models
{
    public class Mitarbeiter
    {
        public int Mitarbeiter_ID { get; set; }        
        public string Name { get; set; }
        public string Vorname { get; set; }
        public string Abteilung { get; set; }

    }
}
