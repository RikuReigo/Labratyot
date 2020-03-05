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
        TableLayoutPanel gameboard;
        int Rowcount = 4;
        int Columncount =4;
        float[] size = new float[] { 50f, 33f, 25f, 20f, 16f };
        Button presskey;

        Random positioner = new Random();

        List<string> icon = new List<string>()
        {
            "i","i","s","s","a","a","v","v","(","(","/","/","r","r","z","z"
        };

        List<string> shape = new List<string>()
        {
            "g","g","c","c","n","n","x","x","y","y","l","l","N","N","O","O"
        };

        List<string> building = new List<string>()
        {
            "t","t","B","B","C","C","F","F","G","G","H","H","S","S","M","M"
        };

        List<string> vehicle = new List<string>()
        {
            "b","b","f","f","h","h","j","j","o","o","p","p","v","v","T","T"
        };
        public Form1()
        {
            InitializeComponent();
        }

        Label firstClicked, secondClicked;

        private void createGameBoardhere()
        {
            int decider = Rowcount - 1;
            gameboard = new TableLayoutPanel();
            gameboard.Location = new System.Drawing.Point(20, 30);
            gameboard.Size = new System.Drawing.Size(455, 455);
            gameboard.BackColor = SystemColors.ActiveCaption;
            gameboard.ColumnCount = Columncount;
            //gameboard.ForeColor = SystemColors.ActiveCaption;
            gameboard.RowCount = Rowcount;
            Controls.Add(gameboard);

            for (int x = 0; x < Columncount; x++)
            {
                gameboard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, size[decider]));

                for (int y = 0; y < Rowcount; y++)
                {
                    if (x == 0)
                    {
                        gameboard.RowStyles.Add(new RowStyle(SizeType.Percent, size[decider]));
                    }
                    presskey = new Button();
                    presskey.Dock = DockStyle.Fill;
                    //presskey.Text = "c";
                    gameboard.Controls.Add(presskey , x, y);
                    presskey.Font = new Font("Webdings", 38, FontStyle.Bold);
                    //gameboard.Controls.Add(new Label { Text = "c", Anchor = AnchorStyles.Bottom, AutoSize = true }, x, y);
                }

            }
        }

        private void assignSymbolsToSquares(List<string> labelBox)
        {
            int randomNumber;
            Label label;
            Random random = new Random();

            for (int i = 0; i < gameboard.Controls.Count; i++)
            {
                if (gameboard.Controls[i].Text == null)
                {
                    gameboard.Controls[i].Text = "i";
                }
                else
                    continue;

                randomNumber = random.Next(0, labelBox.Count);
                gameboard.Controls[i].Text = labelBox[randomNumber];
                labelBox.RemoveAt(randomNumber);
            }
        }

        private void vehicleGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createGameBoardhere();
            assignSymbolsToSquares(vehicle);

        }

        private void shapeGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createGameBoardhere();
            assignSymbolsToSquares(shape);
        }

        private void sportGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createGameBoardhere();
            assignSymbolsToSquares(building);
        }

        private void iconGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createGameBoardhere();
            assignSymbolsToSquares(icon);
        }
    }
}
