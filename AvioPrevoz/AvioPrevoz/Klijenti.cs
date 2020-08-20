using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvioPrevoz
{
    public abstract class Klijenti
    {
        string ime;
        string prezime;
        DateTime datumrodjenja;
        int id; //treba imati 7 cifara

        public Klijenti(string ime, string prezime, DateTime datumrodjenja, int id)
        {
            ime = Ime;
            prezime = Prezime;
            datumrodjenja = DatumRodjenja;
            id = IDK;
        }

        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public DateTime DatumRodjenja { get => datumrodjenja; set => datumrodjenja = value; }
        public int IDK {  get=> id; set => id = value; }
        public abstract double obracunCijene(Avioni a);



    }
}
