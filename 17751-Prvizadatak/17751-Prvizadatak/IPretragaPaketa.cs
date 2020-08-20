using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17751_Prvizadatak
{
    interface IPretragaPaketa
    {

        List<FizickoLice> pretraga1(FizickoLice f );
        List<ObicniPaketi> pretraga2(ObicniPaketi o);
        List<SpecijalniPaketi> pretraga3(SpecijalniPaketi s);
        double obracunTroskova();




    }
}
