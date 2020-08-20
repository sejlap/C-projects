using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17751Zadatak
{
    public class FizickaLica: Lica
    {
        public FizickaLica(string ime, string prezime, DateTime datumrodj) : base(ime, prezime, datumrodj)
        {
        }
        int maxprodaja = 20;

        public override double prodajaKarata()
        {
            double cijena = 0;
            double brojkarata=0;
            if (brojkarata > 10) cijena += 10 * brojkarata * 0.9;
            return cijena;

        }
    }
}

   