using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17751Zadatak
{
    public class Predstave
    {
       
        string imeAutora;
        string prezimeAutora;
        int brojglumaca;
        DateTime datum;
        string sifra;

        public Predstave(string imeAutora, string prezimeAutora, int brojglumaca, DateTime datum, string sifra)
        {
            this.imeAutora = imeAutora;
            this.prezimeAutora = prezimeAutora;
            this.brojglumaca = brojglumaca;
        }

        public string Imeautora { get => imeAutora; set => imeAutora = value; }
        public string Prezimeautora { get => prezimeAutora; set => prezimeAutora = value; }
        public int BrojGlumaca { get => brojglumaca; set => brojglumaca = value; }
        public DateTime Datum { get => datum; set => datum = value; }
        public string Sifra { get => sifra; set => sifra = value; }
     
    }
}
