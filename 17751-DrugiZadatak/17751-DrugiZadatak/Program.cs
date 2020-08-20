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

namespace _17751_DrugiZadatak
{
    class Program
    {
        private readonly object prikazPasswordLabel;

        public object Controls { get; private set; }

        static void dugme_pritisnuto(Object o, EventArgs e)

        {
            MessageBox.Show("Izabrali ste:");
        }

        static void Main()
        {
            Form f = new Form();
            f.Size = new System.Drawing.Size(300, 300);
            f.Text = "Forma";
            CheckBox checkBox1 = new CheckBox();
            checkBox1.Appearance = Appearance.Normal;
            checkBox1.Location = new System.Drawing.Point(186, 186);
            checkBox1.Text = "Java";
            checkBox1.AutoCheck = true;
            checkBox1.CheckedChanged += new System.EventHandler(dugme_pritisnuto);
            CheckBox checkBox2 = new CheckBox();
            checkBox2.Appearance = Appearance.Normal;
            checkBox2.Location = new System.Drawing.Point(200, 200);
            checkBox2.Text = "C#";
            checkBox2.AutoCheck = true;
            checkBox2.CheckedChanged += new System.EventHandler(dugme_pritisnuto);
           

            Button klikButton = new Button();
            klikButton.Text = "Klikni";
            klikButton.Location = new System.Drawing.Point(120, 120);
            klikButton.Size = new System.Drawing.Size(50, 30);

            klikButton.Click += new EventHandler(dugme_pritisnuto);
            f.Controls.Add(klikButton);

            Application.Run(f);
        }

      

        
        private void prikazButto3_Click(object sender, EventArgs e)
        {
            CheckBox checkBox3 = new CheckBox();
            checkBox3.Appearance = Appearance.Normal;
            checkBox3.Location = new System.Drawing.Point(186, 186);
            checkBox3.Text = "C++";
            checkBox3.AutoCheck = true;
            checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChangedState);
        }

        private void checkBox3_CheckedChangedState(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        private void prikazButton4_Click(object sender, EventArgs e)
        {
            CheckBox checkBox4 = new CheckBox();
            checkBox4.Appearance = Appearance.Normal;
            checkBox4.Location = new System.Drawing.Point(186, 186);
            checkBox4.Text = "C++";
            checkBox4.AutoCheck = true;
            checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChangedState);
        }

        private void checkBox4_CheckedChangedState(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }


        static void dugme_pritisnuto1(Object o, EventArgs e)

        {
            MessageBox.Show("Izabrali ste: ");

        }




    }

}

      
