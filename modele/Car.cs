using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab44.modele
{
    public class Car
    {
     public int ID { get; set; }
     public string NAZWA { get; set; }
     public string PRODUCENT { get; set; }
     public string NRREJ { get; set; }

        public ICollection<Zmiana> ZMIANY { get; set; }
    }
}
