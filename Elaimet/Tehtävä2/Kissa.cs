using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elaimet
{
    class Kissa
    {
        private int ika;
        public string nimi;

        public Kissa()
        {
            nimi = "Bianca";
            ika = 3;
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
    }
}
