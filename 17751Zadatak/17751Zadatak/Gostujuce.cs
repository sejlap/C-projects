using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17751Zadatak
{
    public class Gostujuce : Predstave
    {
        public Gostujuce(string imeAutora, string prezimeAutora, int brojglumaca, DateTime datum, string sifra) :
            base(imeAutora, prezimeAutora, brojglumaca, datum, sifra)
        {
        }
    }
}
