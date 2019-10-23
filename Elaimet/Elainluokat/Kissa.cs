using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using Elainluokat;

namespace Elainluokat
{
    public class Kissa
    {
        private int ika;
        public string nimi;
        

        public Kissa()
        {
            nimi = "Bianca";
            ika = 0;
        }

        public void Kehrää()
        {
            Console.WriteLine("Hrrrr");
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
                if (value != "Hilda")
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
