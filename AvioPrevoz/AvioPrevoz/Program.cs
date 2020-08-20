using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvioPrevoz
{
    class Program
    {
       static RPRWings r = new RPRWings(); 
        static void Main(string[] args)
        {
           // RPRWings r = new RPRWings();
            string ulaz;
            int izbor;
            do
            {
                Console.WriteLine("Dobro došli! Odaberite jednu od opcija: \n");
                Console.WriteLine("1.Unos vozila");
                Console.WriteLine("2.Unos klijenta");
                Console.WriteLine("3.Iznajmljivanje");
                Console.WriteLine("4.Povrat aviona i placanje");
                Console.WriteLine("5.Ispis liste obavijesti");
                Console.WriteLine("6.Izlaz");
                do
                {
                    Console.WriteLine("Unos: ");
                    ulaz = Console.ReadLine();
                    Int32.TryParse(ulaz, out izbor);
                    if (izbor < 1 || izbor > 6)
                    {
                        Console.WriteLine("\nNiste izabrali ispravnu opciju. Molimo Vas da pokusate ponovo!");
                        Console.WriteLine("Unos: ");
                        ulaz = Console.ReadLine();
                        Int32.TryParse(ulaz, out izbor);
                    }
                }
                while (izbor < 1 || izbor > 6);
                switch (izbor)
                {
                    case 1:
                        {
                            Console.WriteLine("Pritisnite 1 za putnicki avion ili 2 za teretni: ");
                            string b = Console.ReadLine();
                            if (b.Equals("1"))
                            {
                                Console.WriteLine("Unesite vrstu aviona: ");
                                String vrsta = Console.ReadLine();
                                Console.WriteLine("Unesite broj sjedista: ");
                                string broj = Console.ReadLine();
                                int x = 0;
                                Int32.TryParse(broj, out x);
                                Console.WriteLine("Unesite identifikacijski broj: ");
                                String id = Console.ReadLine();
                                PutnickiAvioni a = new PutnickiAvioni(vrsta,x,id);
                                r.dodajAvion(a);
                            }
                            else
                            {
                                Console.WriteLine("Unesite vrstu aviona: ");
                                String vrsta = Console.ReadLine();
                                Console.WriteLine("Unesite broj sjedista: ");
                                string broj = Console.ReadLine();
                                int x = 0;
                                Int32.TryParse(broj, out x);
                                Console.WriteLine("Unesite identifikacijski broj: ");
                                String id = Console.ReadLine();
                                Console.WriteLine("Unesite ukupni kapacitet u kilogramima: ");
                                string kg1 = Console.ReadLine();
                                int kg2 = 0;
                                Int32.TryParse(kg1, out kg2);
                                TeretniAvioni a = new TeretniAvioni(vrsta, x, id, kg2);
                                r.dodajAvion(a);
                            }

                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Pritisnite 1 za klijente domace drzavljane ili 2 za klijente strane drzavljane: ");
                            string b = Console.ReadLine();
                            if (b.Equals("1"))
                            {
                                Console.WriteLine("Unesite ime klijenta: ");
                                String ime = Console.ReadLine();
                                Console.WriteLine("Unesite prezime klijenta: ");
                                String prezime = Console.ReadLine();
                                DateTime datumRodjenja = DateTime.Now;
                                int god, m, d;
                                Console.WriteLine("Unes*ite datum rodjenja klijenta:");
                                Console.WriteLine("Godina: ");
                                Int32.TryParse(Console.ReadLine(), out god);
                                Console.WriteLine("Mjesec: ");
                                Int32.TryParse(Console.ReadLine(), out m);
                                Console.WriteLine("Dan: ");
                                Int32.TryParse(Console.ReadLine(), out d);
                                try
                                {
                                    datumRodjenja = new DateTime(god, m, d);
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine(ex.ToString());
                                    Console.ReadLine();
                                }
                                Console.WriteLine("Unesite id: ");
                                string broj = Console.ReadLine();
                                int x = 0;
                                Int32.TryParse(broj, out x);

                                Domaci k = new Domaci(ime, prezime, datumRodjenja, x);
                                r.dodajKlijenta(k);
                            }
                            else
                            {
                                Console.WriteLine("Unesite ime klijenta: ");
                                String ime = Console.ReadLine();
                                Console.WriteLine("Unesite prezime klijenta: ");
                                String prezime = Console.ReadLine();
                                DateTime datumRodjenja = DateTime.Now;
                                int god, m, d;
                                Console.WriteLine("Unesite datum rodjenja klijenta:");
                                Console.WriteLine("Godina: ");
                                Int32.TryParse(Console.ReadLine(), out god);
                                Console.WriteLine("Mjesec: ");
                                Int32.TryParse(Console.ReadLine(), out m);
                                Console.WriteLine("Dan: ");
                                Int32.TryParse(Console.ReadLine(), out d);
                                try
                                {
                                    datumRodjenja = new DateTime(god, m, d);
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine(ex.ToString());
                                    Console.ReadLine();
                                }
                                Console.WriteLine("Unesite id: ");
                                string broj = Console.ReadLine();
                                int x = 0;
                                Int32.TryParse(broj, out x);
                                Console.WriteLine("Unesite grad stanovanja: ");
                                String grad = Console.ReadLine();
                                Console.WriteLine("Unesite drzavu stanovanja: ");
                                String drzava = Console.ReadLine();

                               Strani k = new Strani(ime, prezime,grad,x, datumRodjenja,drzava);
                                r.dodajKlijenta(k);
                            }
                            break;
                        }
                    case 6:
                        {
                            Environment.Exit(0);
                            break;
                        }
                }
            }
            while (izbor != 8);

            Console.ReadLine();
        }
    }

}

