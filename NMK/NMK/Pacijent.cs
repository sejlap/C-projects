using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    public abstract class Pacijent
    {
        internal int brojPosjeta = 0;
        internal double dug;

        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatRodjenja { get; set; }
        public string MatBroj { get; set; }
        public string Spol { get; set; }
        public string Adresa { get; set; }
        public string BracnoStanje { get; set; }
        public DateTime DatPrijema { get; set; }

        public Pacijent(String Ime, String Prezime, int MaticniBroj, String Spol, String Adresa, String BracnoStanje, DateTime DatPrijema, DateTime DatRodjenja)
        {
            this.Ime = Ime;
            this.Prezime = Prezime;
            this.DatRodjenja = DatRodjenja;
            this.MatBroj = MatBroj;
            this.Spol = Spol;
            this.Adresa = Adresa;
            this.BracnoStanje = BracnoStanje;
            this.DatPrijema = DatPrijema;


        }


        public abstract void UpisiUkarton();

    }
}