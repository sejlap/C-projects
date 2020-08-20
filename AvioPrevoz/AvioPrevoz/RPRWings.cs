using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.Windows.Forms;

namespace AvioPrevoz
{
    public class RPRWings : IPretraga
    {
        List<Avioni> avioni;
        List<Klijenti> klijenti;
        List<Avioni> iznajmljeniAvioni;
        Iznajmljivanje i;

        public RPRWings(List<Avioni> avioni, List<Klijenti> klijenti, Iznajmljivanje i, List<Avioni> av)
        {
            Avioni = avioni;
            Klijenti = klijenti;
            IznajmljeniAvioni = av;
            I = i;
        }

        public RPRWings()
        {
            avioni = new List<Avioni>();
            iznajmljeniAvioni = new List<Avioni>();
            i = new Iznajmljivanje();
            klijenti = new List<Klijenti>();
        }
        public List<Avioni> Avioni { get => avioni; set => avioni = value; }
        public List<Klijenti> Klijenti { get => klijenti; set => klijenti = value; }
        public Iznajmljivanje I { get => i; set => i = value; }
        public List<Avioni> IznajmljeniAvioni { get => iznajmljeniAvioni; set => iznajmljeniAvioni = value; }
        public void dodajKlijenta(Klijenti k)
        {
            klijenti.Add(k);
        }
        public void dodajAvion(Avioni a)
        {
            avioni.Add(a);
        }

        public List<Avioni> pretraga1(string sifra)
        {
            return avioni.FindAll(x => x.ID == sifra);
        }
        public List<Avioni> pretraga2(Avioni a)
        {
            return avioni.FindAll(x => x.Vrsta == a.Vrsta && x.BrojSjedista == a.BrojSjedista);
        }

        public List<Klijenti> provjeraKlijenta(int sifra)
        {
            return klijenti.FindAll(x => x.IDK == sifra);
        }
        delegate void Delegat1(int sifraa);
        delegate void Delegat2(Avioni a);

        public void iznajmiVozilo(Klijenti k, Avioni a)
        {
            bool jesteKlijent = false;
            foreach (Klijenti kl1 in Klijenti.Where(kl1 => k.IDK == kl1.IDK))
            {
                jesteKlijent = true;
                break;
            }
            if (jesteKlijent)
            {
                List<Avioni> lista = pretraga1(a.ID);
                if (lista.Count > 0)
                {
                    foreach (Avioni avion in lista)
                    {
                        Console.WriteLine(avion.ToString());
                        Console.WriteLine("\n");
                    }

                    DateTime pocDatum = DateTime.Now;
                    int god, m, d;
                    Console.WriteLine("Unesite pocetni datum iznajmljivanja:");
                    Console.WriteLine("Godina: ");
                    Int32.TryParse(Console.ReadLine(), out god);
                    Console.WriteLine("Mjesec: ");
                    Int32.TryParse(Console.ReadLine(), out m);
                    Console.WriteLine("Dan: ");
                    Int32.TryParse(Console.ReadLine(), out d);
                    try
                    {
                        pocDatum = new DateTime(god, m, d);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                        Console.ReadLine();
                    }

                    DateTime krDatum = DateTime.Now;
                    int god2, m2, d2;
                    Console.WriteLine("Unesite krajnji datum iznajmljivanja:");
                    Console.WriteLine("Godina: ");
                    Int32.TryParse(Console.ReadLine(), out god2);
                    Console.WriteLine("Mjesec: ");
                    Int32.TryParse(Console.ReadLine(), out m2);
                    Console.WriteLine("Dan: ");
                    Int32.TryParse(Console.ReadLine(), out d2);
                    try
                    {
                        krDatum = new DateTime(god2, m2, d2);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                        Console.ReadLine();
                    }
                    string idAv;
                    Console.WriteLine("ID aviona: ");
                    idAv = Console.ReadLine();

                    foreach (Avioni x in lista.Where(x => x.ID == idAv))
                    {
                        x.I.PocetniDatum = pocDatum;
                        x.I.KrajniDatum = krDatum;
                        Avioni.Add(x);
                    }
                }
            }
            else
            {
                Form form = new Form();
                TextBox mojTextBox = new TextBox();
                mojTextBox.Size = new Size(169, 20);
                mojTextBox.Location = new Point(75, 166);
                form.Controls.Add(mojTextBox);
                mojTextBox.Font = new Font("Arial", 14);
                mojTextBox.Text = "Pretraga nije vratila rezultat";
            }
           
             }

         }
    }





      

   

       























