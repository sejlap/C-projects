using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17751_Prvizadatak
{
    public class Upis : IPretragaPaketa
    {
        List<ObicniPaketi> obicnipaketi;
        List<SpecijalniPaketi> specijalnipaketi;
        List<FizickoLice> fizickolice;
        List<PravnoLice> pravnolice;
        ObicniPaketi ob;
        public Upis(List<ObicniPaketi> obicnipaketi, List<SpecijalniPaketi> specijalnipaketi)
        {
            this.obicnipaketi = obicnipaketi;
            this.specijalnipaketi = specijalnipaketi;
        }

        public Upis()
        {
            obicnipaketi = new List<ObicniPaketi>();
            specijalnipaketi = new List<SpecijalniPaketi>();
        }

        public void dodajObicni(ObicniPaketi o)
        {
            obicnipaketi.Add(o);
        }
        public void dodajSpecijalni(SpecijalniPaketi s)
        {
            specijalnipaketi.Add(s);
        }

        public List<FizickoLice> pretraga1(FizickoLice f)
        {

            return fizickolice.FindAll(x => x.ImePrimaoca == f.ImePrimaoca && x.PrezimePrimoca == f.PrezimePrimoca);

        }
        public List<ObicniPaketi> pretraga2(ObicniPaketi o)
        {

            return obicnipaketi.FindAll(x => x.SifraPaket == o.SifraPaket);

        }

        public List<SpecijalniPaketi> pretraga3(SpecijalniPaketi s)
        {

            return specijalnipaketi.FindAll(x => x.SifraPaket == s.SifraPaket);

        }

        delegate void Delegat1(ObicniPaketi o);

        public double obracunTroskova()
        {
            double iznos = 0;
            double cijenaIsporuke = 0.5;
            iznos += ob.TezinaPaket * cijenaIsporuke + 20;
            return iznos;
            int n;

            int min = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (iznos < min) iznos = min;
                }
            }


        }
        public void daLiPostojiPaket(ObicniPaketi o)
        {
            List<ObicniPaketi> l1 = pretraga2(o);
            if (l1.Count != 0)
            {
                Console.WriteLine("Troskovi isporuke su: ");
                double iznos = obracunTroskova();

            }

        }

        public void daLiJePrimaocNadjen(FizickoLice f)
        {
            List<FizickoLice> l2 = pretraga1(f);
            if (l2.Count == 0)

            {
                Console.WriteLine("Ostavit cemo vam poruku preko sljedece sifre: ");
                Random sifra= new Random();

                Console.WriteLine("Sa ovom sifrom mozete evidentirati novi datum i adresu isporuke. ");
            }

            



        }


        
    }



}