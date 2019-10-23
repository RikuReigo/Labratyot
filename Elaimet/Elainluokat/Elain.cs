using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elainluokat
{
    public abstract class Elain
    {
        private string nimi;
        private int ika;
        private bool lihansyoja;
        public string aantele;

        public Elain()
        {
            nimi = "";
            ika = 0;
            lihansyoja = true;
            aantele = "umpf";
        }
        public string Nimi
        {
            get
            {
                return nimi;
            }

            set
            {
                nimi = value;
            }
        }

        public int Ika
        {
            get
            {
                return ika;
            }

            set
            {
                ika = value;
            }

        }

        public bool Vore
        {
            get
            {
                return lihansyoja;
            }

            set
            {
                bool syote = value;
                if (syote == true)
                {
                    lihansyoja = true;
                }
                else
                    lihansyoja = false;
            }
        }

        public virtual string Aantele
        {
            get
            {
                return aantele;
            }
            set
            {
                aantele = value;
            }
        }
    }
}
