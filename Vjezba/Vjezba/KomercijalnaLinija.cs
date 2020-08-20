using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vjezba
{
    public class KomercijalnaLinija : Linija
    {
        Int32 brojZaustavljanja;
        double fiksnacijena = 800;
        
        public KomercijalnaLinija(DateTime datumPolaska, int brojSjedista, int brojZaustavljanja) : base(datumPolaska, brojSjedista)
        {
           this. brojZaustavljanja = brojZaustavljanja;
        }
        public int BrojZaustavljanja { get => brojZaustavljanja; set => brojZaustavljanja = value; }

        public override string ToString()
        {
            return "ID: " + ID + "\nDatum polaska: " + DatumPolaska.ToString() + "\nBroj sjedista: " + BrojSjedista + "\nBroj zaustavljanja: " + BrojZaustavljanja;  
        }
        public override Double ObracunajCijenu()
        {
            if (DatumPolaska.DayOfWeek.ToString().Equals("Saturday") || DatumPolaska.DayOfWeek.ToString().Equals("Sunday"))
                    return fiksnacijena * 0.75;

            return fiksnacijena;
            
        }

    }
}

