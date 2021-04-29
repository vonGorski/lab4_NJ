using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab44.modele
{
    public class Zmiana
    {
        public int ID { get; set; }

        public Kierowca KIEROWCA { get; set;}

        public Telefon TELEFON { get; set; }

        public Car SAMOCHOD { get; set; }
    }
}
