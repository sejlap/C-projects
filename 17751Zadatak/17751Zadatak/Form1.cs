using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.Threading;


namespace _17751Zadatak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        Predstave f;
        List<Prodaja> p;
        List<Prodaja> Prodaj;
        List<Predstave> Predstave;
        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            if (textBox3.Text.Length <7) errorProvider1.SetError(textBox3, "Broj glumaca mora biti veci od 7");
          
            else errorProvider1.SetError(textBox6, "");
        }

        private void textBox4_Validating(object sender, CancelEventArgs e)
        {
            if ( Convert.ToInt32(textBox4.Text.ToString()) >= 2000 && Convert.ToInt32(textBox4.Text.ToString()) <= 2017 )
                errorProvider1.SetError(textBox8, "Datum izvodjenja prestave treba biti izmedju 200 i 2017.");
            else errorProvider1.SetError(textBox8, "");
        }
        public Boolean jesuLiParne(string x)
        {
            Boolean y = true;
            int suma = 0;
            for (int i = 0; i < x.Length; i++)
            {
                if (i > 2 && i < 7 && (x[i].Equals("1") || x[i].Equals("3") || x[i].Equals("5") || x[i].Equals("7") || x[i].Equals("9")) && (suma+= x[i])<10)
                {
                    y = false;
                    break;
                }
            }
            return y;
        }


        public Boolean OdgovarajuLiMjestu(string x)
        {
            string mjesto = "";
            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                if (i < 3) mjesto += textBox1.Text[i];

            }
            Boolean y = true;
            string sifra = "";
            for (int i = 0; i < x.Length; i++)
            {
                if (i >= 1 && i <= 2)
                {
                    sifra += x[i];
                }
            }
            if (!sifra.Equals(mjesto)) return true;
            return false;
        }

        private void textBox5_Validating(object sender, CancelEventArgs e)
        {
            if (textBox5.Text.Length != 7) errorProvider1.SetError(textBox5, "Sifra pozorista mora sadrzavati 7 karaktera!");

            else if (OdgovarajuLiMjestu(textBox5.Text.ToString()))
                errorProvider1.SetError(textBox5, "Prva dva karaktera sifre moraju biti prva dva karaktera naziva pozorista!");

            else if (jesuLiParne(textBox5.Text.ToString())) errorProvider1.SetError(textBox5, "trebaju biti parne cifre ciji zbir ne smije preci 10!");
            else errorProvider1.SetError(textBox5, "");
        }



        //upis u datoteku
        private void button1_Click(object sender, EventArgs e)
        {
           
                if (!File.Exists("predstave.dat"))
                {
                    try
                    {
                        FileStream fs = new FileStream("pitanja.dat", FileMode.Create);
                        BinaryFormatter x = new BinaryFormatter();
                        foreach (Predstave i in Predstave)
                                x.Serialize(fs, i);

                        fs.Close();
                    }
                    catch (Exception ex)
                    {
                    MessageBox.Show(ex.Message);
                }
                }
                else
                {
                    try
                    {
                        FileStream fs = new FileStream("pitanja.dat", FileMode.Append);
                        BinaryFormatter x = new BinaryFormatter();
                        foreach (Predstave i in Predstave)
                        x.Serialize(fs, i);
                    fs.Close();
                    }
                    catch (Exception ex)
                    {
                    MessageBox.Show(ex.Message);
                }
                }
            }

        //upsi u xml

        private void button2_Click(object sender, EventArgs e)
        {

            if (!File.Exists("prodaja.xml"))
            {
                try
                {
                    XmlSerializer xs = new XmlSerializer(typeof(List<Prodaja>));
                    FileStream fs = new FileStream("prodaja.xml", FileMode.Create);
                    //xs.Serialize(fs, p.Prodaj);
                    fs.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    XmlSerializer xs = new XmlSerializer(typeof(List<Prodaja>));
                    FileStream fs = new FileStream("prodaja.xml", FileMode.Append);
                  //  xs.Serialize(fs, p.Prodaj);
                    fs.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        //NITI
        private void prikazisvafizickaLicaItem_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(() => PrikaziFizickaLica()) { IsBackground = true };
            t.Start();

        }

        private int broj_fizickihLica;
        private Thread nit;
        private StreamReader file;

        private void PrikaziFizickaLica()
        {
            String path=" ";
           file = new StreamReader(path);
            String line;
            broj_fizickihLica = 0;

            while ((line = file.ReadLine()) != null)
            {
                if (line.Contains("<FizickaLica>"))
                    broj_fizickihLica++;
                Thread.Sleep(200);
            }

            file.Close();
            MessageBox.Show("Broj fizickih lica je:" + broj_fizickihLica);
        }


    }
}
    