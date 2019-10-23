using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using Elainluokat;

namespace Elaimet
{
    public class Koira
    {
        private int ika;
        public string nimi;

        public Koira()
        {
            nimi = "Haukku";
            ika = 0;
        }

        public string Nimi
        {
            get
            {
                return nimi;
            }
            set
            {
                string myString = value;
                myString = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(myString.ToLower());
                value = myString;
                if (value != "Musti")
                {
                    nimi = value;
                }
                else
                    Console.WriteLine("Name not set");
                
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
                if (value >= 0)
                {
                    ika = value;
                }
                else
                    Console.WriteLine("age out of bounds");
            }
        }
    }
}
