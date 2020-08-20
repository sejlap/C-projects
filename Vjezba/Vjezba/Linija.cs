using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vjezba
{
    public abstract class Linija
    {
        static Int64 globalID;
        DateTime datumPolaska;
        Int64 id;
        Int32 brojSjedista;

        public Linija(DateTime datumPolaska, int brojSjedista)
        {
            DatumPolaska = datumPolaska;
            id =globalID+1;
            globalID += 1;
            BrojSjedista = brojSjedista;
        }

        public DateTime DatumPolaska { get => datumPolaska; set => PostaviDatum(value); }
        public long ID { get => id;  }//svaki ima razlicit id zato ne postavljamo setter
        public int BrojSjedista { get=>brojSjedista;  set => brojSjedista = value; }

            void PostaviDatum(DateTime dt)
        {
            if (dt.Hour >= 0 && dt.Hour < 3)
                throw new Exception("Datum polaska ne smije biti izmedju 00.00 i 3.00 ");
            datumPolaska = dt;
        }
        public abstract Double ObracunajCijenu();

    }
}
