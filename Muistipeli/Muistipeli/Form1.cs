using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Muistipeli
{
    public partial class Form1 : Form
    {

        Random random = new Random();

        List<String> Images = new List<string>()
        {"!","!","N","N",",",",","k","k","O","O","v","v","W","W","z","z"};

        List<String> Vehicles = new List<String>()
        {"f","f","h","h","j","j","p","p","b","b","v","v","o","o","t","t","u","u"};

        List<String> Shapes = new List<string>()
        {"a","a","d","d","g","g","n","n","r","r","x","x","Y","Y",".",".","*","*"};

        Label FirstClick, SecondClick;

       

        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Label_click(object sender, EventArgs e)
        {

            if (FirstClick != null && SecondClick != null)
                return;

            Label ClickedLabel = sender as Label;

            if (ClickedLabel == null)
                return;

            if (ClickedLabel.ForeColor == Color.Black)
                return;

            if (FirstClick == null)
            {
                FirstClick = ClickedLabel;
                FirstClick.ForeColor = Color.Black;
                return;
            }

            SecondClick = ClickedLabel;
            SecondClick.ForeColor = Color.Black;

            CheckForWinner();

            if (FirstClick.Text == SecondClick.Text)
            {
                FirstClick = null;
                SecondClick = null;
            }
            else
                timer1.Start();
           }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            FirstClick.ForeColor = FirstClick.BackColor;
            SecondClick.ForeColor = SecondClick.BackColor;

            FirstClick = null;
            SecondClick = null;
        }

        private void CheckForWinner() 
        {
            Label labelcheck;
            for (int u = 0; u < tableLayoutPanel1.Controls.Count; u++)
            {
                labelcheck = tableLayoutPanel1.Controls[u] as Label;

                if (labelcheck != null && labelcheck.ForeColor == labelcheck.BackColor)
                    return;
            }

            MessageBox.Show("You have won!");
            Close();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void imagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AssignIconsTosquares(Images);
        }

        private void shapesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AssignIconsTosquares(Shapes);
        }

        private void vehiclesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AssignIconsTosquares(Vehicles);
        }

        private void AssignIconsTosquares(List<String>Icons)
        {
            Label label;
            int RandomNUmber;

            for (int i = 0; i < tableLayoutPanel1.Controls.Count; i++)
            {
                if (tableLayoutPanel1.Controls[i] is Label)
                { label = (Label)tableLayoutPanel1.Controls[i]; }
                else
                    continue;

                RandomNUmber = random.Next(0, Icons.Count);
                label.Text = Icons[RandomNUmber];

                Icons.RemoveAt(RandomNUmber);
            }

        }
    }
}
