using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17751_Prvizadatak
{
    public abstract class Lice
    {
        string imePrimaoca;
        string prezimePrimaoca;
        string adresaIsporuke;

        public Lice(string imePrimaoca, string prezimePrimaoca, string adresaIsporuke)
        {
            this.imePrimaoca = imePrimaoca;
            this.prezimePrimaoca = prezimePrimaoca;
            this.adresaIsporuke = adresaIsporuke;
        }

        public string ImePrimaoca { get => imePrimaoca; set => imePrimaoca = value; }
        public string PrezimePrimoca { get => prezimePrimaoca; set => prezimePrimaoca = value; }
        public string AdresaIsporuke { get => adresaIsporuke; set => adresaIsporuke = value; }

    }
}
