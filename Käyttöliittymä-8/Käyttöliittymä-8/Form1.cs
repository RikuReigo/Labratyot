using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Käyttöliittymä_8
{
    public partial class Form1 : Form
    {
        Dictionary<string, string> Hakemisto;
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Create Dictionary
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Hakemisto = new Dictionary<string, string>();
        }
        /// <summary>
        /// Add Label and text into dictionary
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void button2_Click(object sender, EventArgs e)
        {
            Hakemisto.Add(textBox1.Text,textBox2.Text);
        }
        /// <summary>
        /// Search for label and text into dictionary
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void button3_Click(object sender, EventArgs e)
        {
            string lukija = Hakemisto[textBox3.Text];
            textBox4.Text = lukija;
        }
        
    }
}
