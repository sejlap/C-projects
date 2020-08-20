using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17751_Prvizadatak
{
    public class SpecijalniPaketi : Paketi
    {
        public SpecijalniPaketi(string sifraPaket, int tezinaPaket) : base(sifraPaket, tezinaPaket)
        {

        }
        public override double obracunTroskova()
        {
            double iznos = 0;
            double cijenaIsporuke = 0.5;
            if (TezinaPaket < 10)
            {
                iznos += (TezinaPaket * cijenaIsporuke + 20)* 1.3; //uvecano za 30%
            }
            else if(TezinaPaket >= 10)
            {
                iznos+= (TezinaPaket * cijenaIsporuke + 20) * 1.4; //uvecano za 40%
               
            }
            else if (TezinaPaket == 20)
            {
                iznos += (TezinaPaket * cijenaIsporuke + 20) * 1.1; //uvecano za 10%

            }
            return iznos;

        }

    }
}