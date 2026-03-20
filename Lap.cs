using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJack.dokumentumok
{
     public class Lap
    {
        public int Id { get; set; }
        public string Nev { get; set; }
        public int Ertek { get; set; }
        public Lap(int id, string nev, int ertek)
        {
            Id = id;
            Nev = nev;
            Ertek = ertek;
        }
    }
}
