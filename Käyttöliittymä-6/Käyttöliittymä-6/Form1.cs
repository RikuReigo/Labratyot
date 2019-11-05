using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Käyttöliittymä_6
{
    public partial class Form1 : Form
    {
        int[] playerRivi;
        int[] lottorivi;
        int pituus = 7;
        int tulos = 0;
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown8_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lottorivi = new int[pituus];
            for (int i = 0; i < pituus; i++)
            {
                int tallenna = rnd.Next(1, 41);
                bool Contains = lottorivi.Contains(tallenna);
                if (!Contains)
                {
                    lottorivi[i] = tallenna;
                }
                else
                    i--;
                
            }
            Array.Sort(lottorivi);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            playerRivi = new int[9];
            playerRivi[0] = Convert.ToInt32(lotto1.Text);
            playerRivi[1] = Convert.ToInt32(lotto2.Text);
            playerRivi[2] = Convert.ToInt32(lotto3.Text);
            playerRivi[3] = Convert.ToInt32(lotto4.Text);
            playerRivi[4] = Convert.ToInt32(lotto5.Text);
            playerRivi[5] = Convert.ToInt32(lotto6.Text);
            playerRivi[6] = Convert.ToInt32(lotto7.Text);

            playerRivi[7] = Convert.ToInt32(Bonus1.Text);
            playerRivi[8] = Convert.ToInt32(Bonus2.Text);

            Array.Sort(playerRivi);
            
            for (int c = 0; c < lottorivi.Length; c++)
            {
                for (int k = 0; k < playerRivi.Length; k++)
                {
                    if (lottorivi[c] == playerRivi[k])
                    {
                        tulos++;
                    }
                    else
                    {

                    }
                }
            }
            string lopputulos = Convert.ToString(tulos);
            MessageBox.Show(lopputulos);
        }
    }
}
