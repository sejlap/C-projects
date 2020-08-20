using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17751_Prvizadatak
{
    public class ObicniPaketi : Paketi
    {
        public ObicniPaketi(string sifraPaket, int tezinaPaket) : base (sifraPaket, tezinaPaket)
        {

        }

        public override double obracunTroskova()
        {
             double iznos=0;
             double cijenaIsporuke = 0.5;
            iznos += TezinaPaket*  cijenaIsporuke + 20;
            return iznos;
        }
    }
}
