using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistracijaKlubova
{
    public class Profesionalci : Igraci
    {
        int godinaPocetka;
        public Profesionalci(string ime, string prezime, int godinaRodjenja, string maticniBroj, string sifraKluba, int godinaPocetka) :
            base(ime, prezime, godinaRodjenja, maticniBroj, sifraKluba)
        {
            godinaPocetka = GodinaPocetka;
        }
        public int GodinaPocetka { get => godinaPocetka; set => godinaPocetka = value; }
    }
}
