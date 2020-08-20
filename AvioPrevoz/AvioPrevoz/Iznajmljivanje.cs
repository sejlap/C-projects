using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvioPrevoz
{
    
        public class Iznajmljivanje
        {
            Klijenti k;

            DateTime pocetniDatum, krajniDatum;
            public Iznajmljivanje(Klijenti k, DateTime poc, DateTime kr)
            {
                K = k;

                PocetniDatum = poc;
                KrajniDatum = kr;
            }
            public Iznajmljivanje() { }

            public Klijenti K { get => k; set => k = value; }
            public DateTime PocetniDatum { get => pocetniDatum; set => pocetniDatum = value; }
            public DateTime KrajniDatum { get => krajniDatum; set => krajniDatum = value; }



        }
    }



