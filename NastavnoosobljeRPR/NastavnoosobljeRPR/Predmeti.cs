using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NastavnoosobljeRPR
{
    public class Predmeti
    {
        string naziv, sifra;

        public string Naziv { get => naziv; set => naziv = value;  }
        public string Sifra { get => sifra; set => sifra = value; }

        public Predmeti(string naziv, string sifra)
        {
            Naziv = naziv;
            Sifra = sifra;
            
        }
    }
}
