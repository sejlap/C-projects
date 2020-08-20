using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17751Zadatak
{
    public class PravnaLica : Lica
    {
        public PravnaLica(string ime, string prezime, DateTime datumrodj) : base(ime, prezime, datumrodj)
        {
        }
        int maxprodaja = 100;

        public override double prodajaKarata()
        {
            double cijena = 0;
            double brojkarata = 0;
            if (brojkarata >=50) cijena += 10 * brojkarata * 0.85;
            return cijena;

        }
    }
}
