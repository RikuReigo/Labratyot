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
        /// <summary>
        /// Create point for picture and create dragging command.
        /// </summary>
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
        /// <summary>
        /// Draw the stickman!
        /// </summary>
        /// <param name="Graf"></param>

        private void DrawCordinates(Graphics Graf)

        {
            Graf.DrawString("(" + piste.X + " ," + piste.Y + ")",

                            new Font("Arial", 14, System.Drawing.FontStyle.Regular),

                            new SolidBrush(Color.Black), 8, 30);
        }
        /// <summary>
        /// Give coordinates for draving.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)

            {

                piste = e.Location;

                Invalidate();

            }
        }
        /// <summary>
        /// Relocate stickman to mouse coordinates. (Deactivated)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void OnMouseDown(object sender, MouseEventArgs e) 
        {
            _mouseleftdown = true;
        }
        /// <summary>
        /// Activate Dragging command.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnMouseMove(object sender, MouseEventArgs e) 
        {
            if (_mouseleftdown == true)
            {
               piste = e.Location;


               Invalidate();
            }
        }
        /// <summary>
        /// Drag the picture around by holding left mouse down.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void OnMouseUp(object sender, MouseEventArgs e) 
        {
            _mouseleftdown = false;
        }
        /// <summary>
        /// Deactiavate dragging.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

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
        /// <summary>
        /// Set picture to given coordinates
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Have a hike with the stickman. Press WASD keys to move him around (slowly)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void MainForm_KeyUp(object sender, KeyEventArgs e)
        {
            Invalidate();
        }
    }
}

