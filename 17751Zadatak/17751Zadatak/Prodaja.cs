using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17751Zadatak
{
    [Serializable]
    class Prodaja
    {
        internal decimal cijena;
        string komejeProdana;
        int brojProdanih;
        DateTime datumProdaje;
        int vrijemeProdaje;
        string predstavazaProdane;
        List<Prodaja> prodaja;
        public Prodaja(string komejeProdana, int brojProdanih, DateTime datumProdaje, int vrijemeProdaje, string predstavazaProdane)
        {
            this.komejeProdana = komejeProdana;
            this.brojProdanih = brojProdanih;
            this.datumProdaje = datumProdaje;
            this.vrijemeProdaje = vrijemeProdaje;
            this.predstavazaProdane = predstavazaProdane;
        }

        public string KomejeProdana { get => komejeProdana; set => komejeProdana = value; }
        public int BrojProdanih { get => brojProdanih; set => brojProdanih = value; }
       public  DateTime DatumProdaje { get => datumProdaje; set=> datumProdaje = value; }
        public int VrijemeProdaje { get => vrijemeProdaje; set => vrijemeProdaje = value; }
       public  string PredstavazaProdane { get => predstavazaProdane; set=> predstavazaProdane = value; }
        public List<Prodaja> Prodaj{ get => prodaja; set => prodaja = value; }

    }
}
