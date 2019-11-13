using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Käyttöliittymä_10
{
    public partial class Form1 : Form
    {
        Bitmap image1;
        bool _mouseleftdown;
        Point piste = new Point(0, 0);

        protected bool DoubleBufferedField { get => DoubleBuffered; set => DoubleBuffered = value; }
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs args)
        {
            DoubleBuffered = true;
            image1 = new Bitmap(Properties.Resources.GetImage);
            image1.MakeTransparent(image1.GetPixel(0, 0));
            args.Graphics.DrawImage(image1, piste);
            

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        { 
            
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
            if (_mouseleftdown == false)
            piste = e.Location;
            Invalidate();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
