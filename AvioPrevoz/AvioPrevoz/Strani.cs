using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvioPrevoz
{
    public class Strani : Klijenti
    {
        string grad;
        string drzava;
        public Strani(string ime, string prezime, string grad, int id, DateTime datumrodjenja, string drzava) :
            base(ime, prezime, datumrodjenja, id)
        {

            grad = Grad;
            drzava = Drzava;
        }

        public string Grad { get => grad; set => grad = value; }
        public string Drzava { get => drzava; set => drzava = value; }
        public override double obracunCijene(Avioni a)
        {
            double cijena = 0;
            if (a.GetType() == typeof(PutnickiAvioni)) cijena = (a.I.KrajniDatum.Day - a.I.PocetniDatum.Day) * 150;
            else if (a.GetType() == typeof(Strani)) cijena = (a.I.KrajniDatum.Day - a.I.PocetniDatum.Day) * 250;
            else if (a.GetType() == typeof(TeretniAvioni)) cijena = (a.I.KrajniDatum.Day - a.I.PocetniDatum.Day) * 350;

            if ((a.I.PocetniDatum.Day.Equals("Subota") || a.I.PocetniDatum.Day.Equals("Nedjelja"))
                && a.GetType() == typeof(Domaci)) cijena += 500;
            else if ((a.I.PocetniDatum.Day.Equals("Subota") || a.I.PocetniDatum.Day.Equals("Nedjelja"))
                && a.GetType() == typeof(Strani)) cijena += 700;

            if (kaucijaDomaci < cijena) cijena -= kaucijaDomaci;

            return cijena;

        }
    }
}
