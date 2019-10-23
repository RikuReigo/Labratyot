using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using Elainluokat;

namespace Elainluokat
{
    public class Kissa2 : Nisakkaat
    {
        public override string Aantele
        {
            get
            {
                aantele = "meow"; return aantele;
            }
        }

        public void Kehrää()
        {
            Console.WriteLine("Kehrääkö kissa? kirjoita 1 jos kissa kehrää.");
            int kehräys = int.Parse(Console.ReadLine());
            if (kehräys == 1)
                Console.WriteLine("Khrrrr");
            else
                Console.WriteLine("");
        }
    }
}
