using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistracijaKlubova
{
    public class Klub
    {
        string naziv;
        int godinaOsnivanja;
        string mjesto;
        string sifra;
        public Klub(string naziv, int godinaOsnivanja, string mjesto, string sifra)
        {
            this.naziv = naziv;
            this.godinaOsnivanja = godinaOsnivanja;
            this.mjesto = mjesto;
            this.sifra = sifra;
        }

        public string Naziv { get => naziv; set => naziv = value; }
        public int GodinaOsnivanja { get => godinaOsnivanja; set => godinaOsnivanja = value; }
        public string Mjesto { get => mjesto; set => mjesto = value; }
        public string Sifra { get => sifra; set => sifra = value; }
    }
}
