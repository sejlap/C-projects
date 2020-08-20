using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NastavnoosobljeRPR
{
    public abstract class NastavnoOsoblje
    {
        string ime, prezime;
        List<Predmeti> predmeti;
        int godinauposlenja, godinasticanjaDiplome;

        public NastavnoOsoblje(string ime, string prezime, List<Predmeti> predmeti, int godinauposlenja, int godinasticanjaDiplome)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.predmeti = predmeti;
            this.godinauposlenja = godinauposlenja;
            this.godinasticanjaDiplome = godinasticanjaDiplome;

        }
        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public List<Predmeti> Predmeti { get => predmeti; set => predmeti = value; }
        public int GodinaUposlenja { get => godinauposlenja; set => godinauposlenja = value; }
        public int GodinaSticanjaDiplome { get => godinasticanjaDiplome; set => godinasticanjaDiplome = value; }


    }

}