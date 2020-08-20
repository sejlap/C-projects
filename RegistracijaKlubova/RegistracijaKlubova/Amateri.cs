using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistracijaKlubova
{
    public class Amateri : Igraci
    {
        string drugiSportovi;

        public Amateri(string ime, string prezime, int godinaRodjenja, string maticniBroj, string sifraKluba, string drugiSportovi) :
           base(ime, prezime, godinaRodjenja, maticniBroj, sifraKluba)
        {
            drugiSportovi = DrugiSportovi;
        }
        public string DrugiSportovi { get => drugiSportovi; set => drugiSportovi = value; }
    }

}
