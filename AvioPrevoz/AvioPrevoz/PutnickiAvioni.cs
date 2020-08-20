using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvioPrevoz
{
    public class PutnickiAvioni : Avioni
    {
   

        public PutnickiAvioni(string vrsta, int brojSjedista, string id): base(vrsta,brojSjedista, id)
        {
           
        }

        public override string ToString()
        {
            return "Vrsta aviona " + Vrsta + "\n ID aviona: " + ID +
                "\n Broj sjedista: " + BrojSjedista;
        }
    }
}
