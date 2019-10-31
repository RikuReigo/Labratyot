using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Käyttöliittymä_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread omasaie;
            omasaie = new Thread(new ThreadStart(this.SaieProceduuri));
            omasaie.Start();

            /*int tavoite = Convert.ToInt32(lukuloota.Text);
            kirjoitusloota.Text = "1";
            for (int i = 1; i < tavoite; i++) 
            {
                
                int numero = Convert.ToInt32(kirjoitusloota.Text);
                numero++;
                kirjoitusloota.Update();
                kirjoitusloota.Text = Convert.ToString(numero);
                Thread.Sleep(1000);
            }*/
        }
        
        private void SaieProceduuri()
        {
            int kierrokset = Convert.ToInt32(lukuloota.Text);
            for (int i = 0; i < kierrokset; i++)
            {
                string numero = (i+1).ToString();
                this.AsetaTeksti(numero);
                Thread.Sleep(100);
            }
        }

        delegate void StringArgReturningVoidDelegate(string texti);

        private void AsetaTeksti(string texti)
        {
            if (this.kirjoitusloota.InvokeRequired)

            { 

                StringArgReturningVoidDelegate d = new StringArgReturningVoidDelegate(AsetaTeksti);

                this.Invoke(d, new object[] { texti });

            }

            else

            {
                this.kirjoitusloota.Text = texti;
            }
        }
    }
}
