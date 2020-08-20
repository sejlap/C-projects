using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17751_Prvizadatak
{
    public abstract class Paketi
    {
        string sifraPaket;
        int tezinaPaket;

        public Paketi(string sifraPaket, int tezinaPaket)
        {
            this.sifraPaket = sifraPaket;
            this.tezinaPaket = tezinaPaket;
        }

        public string SifraPaket { get => sifraPaket; set => sifraPaket = value;  }
        public int  TezinaPaket { get => tezinaPaket; set => tezinaPaket = value; }

        public abstract double obracunTroskova();


    }
}
