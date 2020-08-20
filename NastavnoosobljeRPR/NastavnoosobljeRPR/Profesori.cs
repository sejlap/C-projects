using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NastavnoosobljeRPR
{
    public class Profesori : NastavnoOsoblje
    {
        public Profesori(string ime, string prezime, List<Predmeti> predmeti, int godinauposlenja, int godinasticanjaDiplome) :
           base(ime, prezime, predmeti, godinauposlenja, godinasticanjaDiplome)
        {
        }
    }

    //dodati metodu ogranicenja tj. da profesor ne smije predavati vise od 2 predmeta
}
