using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab44.modele
{
    public class Kierowca
    {
        public int ID { get; set; }

        public string IMIE {get; set;}

    public string NAZWISKO {get; set;}

public int WIEK  {get; set;}

public string PLEC { get; set; }

        public ICollection<Zmiana> ZMIANY { get; set; }
    }
}
