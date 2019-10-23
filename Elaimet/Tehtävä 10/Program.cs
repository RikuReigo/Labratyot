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
            Koira2 koiruli = new Koira2();
            Papukaija papukaija = new Papukaija();

            Console.WriteLine("Anna papukaijalle nimi");
            papukaija.Nimi = Console.ReadLine();
            Console.WriteLine("Anna papukaijalle ikä");
            papukaija.Ika = int.Parse(Console.ReadLine());
            Console.WriteLine("Onko papukaijalla sulat? kylla/ei.");
            papukaija.Sulat = Console.ReadLine();

            Console.WriteLine("Papukaijan nimi on: {0}", papukaija.Nimi);
            Console.WriteLine("Papukaija on {0} vuotta vanha", papukaija.Ika);
            Console.WriteLine("onko papukaijalla sulat? {0}", papukaija.Sulat);

            Console.ReadKey();

            Console.WriteLine("Anna koiralle nimi");
            koiruli.Nimi = Console.ReadLine();
            Console.WriteLine("Anna koiralle ikä");
            koiruli.Ika = int.Parse(Console.ReadLine());
            Console.WriteLine("Onko koiralla karvoitusta? kylla/ei.");
            koiruli.Karvoitus = Console.ReadLine();

            Console.WriteLine("Koiran nimi on: {0}", koiruli.Nimi);
            Console.WriteLine("Koira on {0} vuotta vanha", koiruli.Ika);
            Console.WriteLine("onko koiralla karvoitusta? {0}", koiruli.Karvoitus);
        }
    }
}
