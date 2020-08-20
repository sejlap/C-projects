using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NMK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Width = 450;
            this.Height = 380;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen p = new Pen(Color.Black);
            Brush b = new SolidBrush(Color.White);
            Brush myBrush = new SolidBrush(Color.Red);
            g.DrawEllipse(p, 20, 30, 150, 70);
            e.Graphics.FillEllipse(b, 21, 31, 149, 69);
            

            Font drawFont = new Font("Arial", 22);
            String drawString = "NMK";
            SolidBrush drawBrush = new SolidBrush(Color.Red);
            e.Graphics.DrawString(drawString, drawFont, drawBrush, 60.0F, 50.0F);

            Pen pen1 = new Pen(Color.Green);
            Brush b2 = new SolidBrush(Color.Red);
            e.Graphics.FillEllipse(b2,40, 55, 20, 20);

            e.Graphics.FillEllipse(b2, 85, 30, 20, 20);

            e.Graphics.FillEllipse(b2, 85, 80, 20,20);

            e.Graphics.FillEllipse(b2, 130, 55, 20, 20);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Form Registracija_pacijenta = new Form();
            Registracija_pacijenta.ShowDialog();


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Form Doc = new Form();
            
        }
    }
}
