using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistracijaKlubova
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (textBox1.Text == "") errorProvider1.SetError(textBox1, "Ime ne smije ostati prazno");
            else errorProvider1.SetError(textBox1, "");
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (textBox2.Text == "") errorProvider1.SetError(textBox1, "Prezime ne smije ostati prazno");
            else errorProvider1.SetError(textBox2, "");
        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            if (textBox3.Text == "") errorProvider1.SetError(textBox3, "Datum rodjenja ne smije ostati prazan");
            else errorProvider1.SetError(textBox3, "");
        }

        public bool jesuLiPrvaTriNeparna(string x)
        {
            bool jesuNeparni = true;
            for(int i=0; i<=x.Length; i++)
            {
                if (x[i].Equals("2") || x[i].Equals("4") || x[i].Equals("6") || x[i].Equals("8") || x[i].Equals("0"))
                {
                    jesuNeparni = false;
                    break;
                }
            }
            return jesuNeparni;
        }

        public Boolean OdgovarajuLiMjestu(string x)
        {
            string mjesto = "";
            for (int i = 0; i < textBox9.Text.Length; i++)
            {
                if (i < 3) mjesto += textBox9.Text[i];

            }
            Boolean y = true;
            string sifra = "";
            for (int i = 0; i < x.Length; i++)
            {
                if (i >= 3 && i <= 5)
                {
                    sifra += x[i];
                }
            }
            if (!sifra.Equals(mjesto)) return true;
            return false;
        }

    }









}
}

