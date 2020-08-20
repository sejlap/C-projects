using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17751Zadatak
{
    public abstract class Lica
    {
        string ime;
        string prezime;
        DateTime datumrodj;

        public Lica(string ime, string prezime, DateTime datumrodj)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.datumrodj = datumrodj;
        }

        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public DateTime DatumRodj { get => datumrodj; set => datumrodj = value; }
        public abstract double prodajaKarata();
    }

    
}
