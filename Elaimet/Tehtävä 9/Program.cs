using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Elainluokat;

namespace Elaimet
{
    class Program
    {
        static void Main(string[] args)
        {
            Hevonen2 hevonen = new Hevonen2();
            Kissa2 kisuli = new Kissa2();
            Koira2 koiruli = new Koira2();
            Papukaija papukaija = new Papukaija();

            Console.WriteLine(hevonen.Aantele);
            Console.WriteLine(kisuli.Aantele);
            Console.WriteLine(koiruli.Aantele);
            Console.WriteLine(papukaija.Aantele);
        }
    }
}
