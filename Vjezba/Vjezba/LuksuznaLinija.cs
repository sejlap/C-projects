using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vjezba
{
    public class LuksuznaLinija : Linija
    {
        double  cijena = 900;
        string tipVoza;
        Int32 tipUsluge;


        public LuksuznaLinija(DateTime datumPolaska, int brojSjedista, string tipVoza, int tipUslugge) : base(datumPolaska, brojSjedista)
        {
            TipVoza = tipVoza;
            TipUsluge = tipUsluge;

        }

        public string TipVoza { get => tipVoza; set => tipVoza = value; }
        public int TipUsluge { get => tipUsluge; set => tipUsluge = value; }

        public override string ToString()
        {
            return "ID: " + ID + "\nDatum polaska: " + DatumPolaska.ToString() + "\nBroj sjedista: " + BrojSjedista + "\nTip voza: " + TipVoza + "\nTip usluge:" + TipUsluge;
        }

        public override double ObracunajCijenu()
        {
            if (DatumPolaska.Hour > 13 && DatumPolaska.Hour < 18)
                return cijena + tipUsluge*10;
            return cijena;
        }


    }
}
