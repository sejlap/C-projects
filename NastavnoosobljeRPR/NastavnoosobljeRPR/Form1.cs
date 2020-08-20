using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NastavnoosobljeRPR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            bool validan = true;
            if (textBox1.Text == "") errorProvider1.SetError(textBox1, "Sifra ne smije ostati prazna");
            if (textBox1.Text.Length != 7)
            {
                errorProvider1.SetError(textBox1, "Sifra mora sadrzavatai 7 karaktera");
                validan = false;
            }
            else 

                for(int i=0; i<2; i++)
                {
                    if(Char.IsNumber(i))
                    {
                        errorProvider1.SetError(textBox1, "Sifra mora sadrzavatai prva dva kaaraktera koja su slovo);
                        validan = false;
                    }
                }


            else errorProvider1.SetError(textBox1, "");
                
        }

        public Boolean ValidirajSifru(string x)
        {
            if (x.Length != 7) return false;
            if ((Char.IsNumber(x[0]) || Char.IsNumber(x[1])))  return false;
            int sum = 0, digit = 0;
            for(int i=2; i<=7; i++)
            {
                {
                    digit = getDigitFromChar(x[i]);
                    if (digit == -1)
                        return false;
                    sum += digit;
                }
                if (sum > 9)
                    return false;
                else
                    return true;
            }
        }

        private int getDigitFromChar(char v)
        {
            throw new NotImplementedException();
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (textBox2.Text == "") errorProvider1.SetError(textBox2, "Naziv ne smije ostati prazno");
            else errorProvider1.SetError(textBox2, "");

        }

        private void textBox2_TextAlignChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            if (textBox3.Text == "") errorProvider1.SetError(textBox3, "Ime ne smije ostati prazno");
            else errorProvider1.SetError(textBox3, "");

        }

        private void textBox4_Validating(object sender, CancelEventArgs e)
        {
            if (textBox4.Text == "") errorProvider1.SetError(textBox4, "Diploma ne smije ostati prazno");
            else errorProvider1.SetError(textBox4, "");
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_Validating(object sender, CancelEventArgs e)
        {
            if (textBox5.Text == "") errorProvider1.SetError(textBox5, "Uposlen ne smije ostati prazno");
            else errorProvider1.SetError(textBox5, "");
        }

        
  
            }
        }

  

