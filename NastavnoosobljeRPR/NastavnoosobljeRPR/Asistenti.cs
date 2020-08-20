using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NastavnoosobljeRPR
{
    public class Asistenti : NastavnoOsoblje
    {
        string naucniStepen, tekuceSkolovanje;
        public string Naucnistepen { get => naucniStepen; set => naucniStepen = value; }
        public string TekuceSkolovanje { get => tekuceSkolovanje; set => tekuceSkolovanje = value; }

        public Asistenti(string ime, string prezime, List<Predmeti> predmeti, int godinauposlenja, int godinasticanjaDiplome, string naucniStepen, string tekuceSkolovanje) :
            base(ime, prezime, predmeti, godinauposlenja, godinasticanjaDiplome)
        {
            Naucnistepen = naucniStepen;
            TekuceSkolovanje = tekuceSkolovanje;
        }
    }
}
