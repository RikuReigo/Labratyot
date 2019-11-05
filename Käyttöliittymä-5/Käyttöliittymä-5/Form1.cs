using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Käyttöliittymä_5
{
    public partial class Form1 : Form
    {
        int x = 10;
        int[] numerotaulukko;
        int setIndex;
        int viewIndex;
        int tallennanum;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            x = Convert.ToInt32(arraynluonti.Text);
            numerotaulukko = new int[x];
        }

        private void Tallenna_Click(object sender, EventArgs e)
        {
            tallennanum = Convert.ToInt32(tallennettavanum.Text);
            setIndex = Convert.ToInt32(tallennuspaik.Text);

            numerotaulukko[setIndex] = tallennanum; 
        }

        private void Etsi_Click(object sender, EventArgs e)
        {
            if (viewIndex < numerotaulukko.Length)
            {
                viewIndex = Convert.ToInt32(Etsintänum.Text);
                textBox1.Text = Convert.ToString(numerotaulukko[viewIndex]);
            }
            else
                textBox1.Text = "Error";
        }
    }
}
