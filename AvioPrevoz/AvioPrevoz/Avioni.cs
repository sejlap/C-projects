using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvioPrevoz
{
   public abstract class Avioni
    {
        string vrsta;
        int brojSjedista;
        string id;
        Iznajmljivanje i;
        public Avioni(string vrsta, int brojSjedista, string id)
        {
            vrsta = Vrsta;
            brojSjedista = BrojSjedista;
            id = ID;
        }

        public Iznajmljivanje I { get => i; set => i = value; }
        public String Vrsta { get => vrsta; set => vrsta = value; }
        public int BrojSjedista { get => brojSjedista; set => brojSjedista = value; }
        public string ID { get => id; set => id = value; }
        public abstract string ToString();

        public virtual char  kreirajID()
        {
            char x='a'; //zbog inicijalizacije
            for(int i=0; i<=8; i++)
            {
                if (((ID[i] >= 'a' && ID[i] <= 'z') || (ID[i] >= 1 && ID[i] <= 5)) && ID.Length <= 8)
                    x = ID[i];
            }
            return x;
        }
      

    }
}
