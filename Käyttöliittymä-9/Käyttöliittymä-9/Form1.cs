using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Käyttöliittymä_9
{
    public partial class MainForm : Form
    {
        Point piste = new Point(0,0);
        bool _mouseleftdown;
        public MainForm()
        {
            InitializeComponent();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Paint (object sender, PaintEventArgs e)
        {
            Graphics Graf = e.Graphics;

            Graf.FillEllipse(Brushes.IndianRed, piste.X - 4, piste.Y - 8, 49, 49);

            Graf.DrawEllipse(Pens.Black, piste.X - 4, piste.Y - 8, 49, 49);

            Graf.DrawLine(Pens.Black, piste.X + 21, piste.Y + 41,

            piste.X + 21, piste.Y + 131);

            Graf.DrawLine(Pens.Black, piste.X - 30, piste.Y + 60,

            piste.X + 70, piste.Y + 60);

            Graf.DrawLine(Pens.Black, piste.X + 21, piste.Y + 131,

            piste.X - 30, piste.Y + 181);

            Graf.DrawLine(Pens.Black, piste.X + 21, piste.Y + 131,

            piste.X + 70, piste.Y + 181);

            DrawCordinates(Graf);
        }

        private void DrawCordinates(Graphics Graf)

        {
            Graf.DrawString("(" + piste.X + " ," + piste.Y + ")",

                            new Font("Arial", 14, System.Drawing.FontStyle.Regular),

                            new SolidBrush(Color.Black), 8, 30);
        }
        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)

            {

                piste = e.Location;

                Invalidate();

            }
        }

        private void OnMouseDown(object sender, MouseEventArgs e) 
        {
            _mouseleftdown = true;
        }

        private void OnMouseMove(object sender, MouseEventArgs e) 
        {
            if (_mouseleftdown == true)
            {
               piste = e.Location;


               Invalidate();
            }
        }

        private void OnMouseUp(object sender, MouseEventArgs e) 
        {
            _mouseleftdown = false;
        }

        private void MainForm_MouseDown2(object sender, MouseEventArgs e)

        {

            if (e.Button == MouseButtons.Left)

            {

                piste = e.Location;

                Invalidate();

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            piste.X = Convert.ToInt32(textBox1.Text);
            piste.Y = Convert.ToInt32(textBox2.Text);

            Invalidate();
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                piste.Y--;
            }
            else if (e.KeyCode == Keys.S)
            {
                piste.Y++;
            }
            else if (e.KeyCode == Keys.A)
            {
                piste.X--;
            }
            else if (e.KeyCode == Keys.D)
            {
                piste.X++;
            }
        }

        private void MainForm_KeyUp(object sender, KeyEventArgs e)
        {
            Invalidate();
        }
    }
}

