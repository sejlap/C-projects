using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistracijaKlubova
{
    public class Igraci
    {
        string ime;
        string prezime;
        int godinaRodjenja;
        string maticniBroj;
        string sifraKluba;

        public Igraci(string ime, string prezime, int godinaRodjenja, string maticniBroj, string sifraKluba)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.godinaRodjenja = godinaRodjenja;
            this.maticniBroj = maticniBroj;
            this.sifraKluba = sifraKluba;
        }

        public string Ime { get => ime; set => ime = value;  }
        public string Prezime { get => prezime; set => prezime = value;  }
        public int GodinaRodjenja { get => godinaRodjenja; set => godinaRodjenja = value; }
        public string MaticniBroj { get => maticniBroj; set => maticniBroj = value; }
        public string SifraKluba { get => sifraKluba; set => sifraKluba = value; }



    }
}
