using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvioPrevoz
{
    interface IPretraga
    {
        List<Avioni> pretraga1(string sifra);

        List<Avioni> pretraga2(Avioni a);
        
    }
}
