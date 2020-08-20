using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvioPrevoz
{
    public class TeretniAvioni : Avioni
    {
        int kapacitet;
        public TeretniAvioni(string vrsta, int brojSjedista, string id, int kapacitet) : base(vrsta, brojSjedista, id)
        {
            kapacitet = Kapacitet;
        }

        public int Kapacitet { get => kapacitet; set => kapacitet = value; }
        public override string ToString()
        {
            return "Vrsta aviona " + Vrsta + "\n ID aviona: " + ID +
                "\n Broj sjedista: " + BrojSjedista + "\n Ukupni kapacitet: " + Kapacitet;
        }
    }
}
