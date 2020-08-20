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
    public partial class Karton : Form
    {
        public Karton()
        {
            InitializeComponent();
        }

        private void Karton_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form Tip = new Form();
            Tip.ShowDialog();
        }
    }
}
