using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kayttoliittyma_1
{
    public partial class Elokuvasovellus : Form
    {
        public Elokuvasovellus()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tämän Sovelluksen on tehnyt Riku Juvonen", "Info", MessageBoxButtons.OK);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = 0;
            DateTime datetime = DateTime.Now;
            textBox1.Text = Convert.ToString(id);
            textBox2.Text = "[syötä elokuvan nimi]";
            textBox3.Text = datetime.ToString("yyyy");
            textBox4.Text = "0";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void poistuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "[syötä elokuvan nimi]")
            {
                textBox2.Text = string.Empty;
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            if (textBox3.Text == datetime.ToString("yyyy"))
            {
                textBox3.Text = string.Empty;
            }
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "0") {
                textBox4.Text = string.Empty;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "[syötä elokuvan nimi]";
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            if (textBox3.Text == "")
            {
                textBox3.Text = datetime.ToString("yyyy");
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox4.Text = "0";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

                int number;
            if (textBox3.Text == "" || textBox4.Text == "")
            {
                if (textBox3.Text != "")
                {

                }
                else
                    MessageBox.Show("Et ole syöttänyt mitään Julkaisuvuosi kenttään");

                if (textBox4.Text != "")
                {

                }
                else
                    MessageBox.Show("Et ole syöttänyt mitään Kesto kenttään");
            }

            else if (textBox3.Text != "" || textBox4.Text != "")
            {
                if (int.TryParse(textBox3.Text, out number))
                {
                    MessageBox.Show("Kaikki OK");
                }
                else
                    MessageBox.Show("Julkaisuvuosi ei ole numeroita!");

                if (int.TryParse(textBox4.Text, out number))
                {
                    MessageBox.Show("Kaikki OK");
                }
                else
                    MessageBox.Show("Kesto ei ole numeroita!");
            }
            else
                MessageBox.Show("Kaikki OK");
            
        }
    }
}
