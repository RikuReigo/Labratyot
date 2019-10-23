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
            Kissa2 kisuli = new Kissa2();

            Console.WriteLine("Mikä on Kissan nimi?");
            kisuli.Nimi = Console.ReadLine();

            Console.WriteLine("Kuinka vanha Kissa on?");
            kisuli.Ika = int.Parse(Console.ReadLine());

            Console.WriteLine("Onko eläin lihansyöjä? kirjoita joko true tai false");
            kisuli.Vore = Boolean.Parse(Console.ReadLine());

            Console.WriteLine("Kissan nimi on {0}", kisuli.Nimi);
            Console.WriteLine("kissa on {0} vuotta vanha", kisuli.Ika);
            Console.WriteLine("Onko lihansyoja? {0}", kisuli.Vore);

            kisuli.Kehrää();
            Console.ReadKey();

            Koira2 koiruli = new Koira2();

            Console.WriteLine("Mikä on koiran nimi?");
            koiruli.Nimi = Console.ReadLine();

            Console.WriteLine("Kuinka vanha koira on?");
            koiruli.Ika = int.Parse(Console.ReadLine());

            Console.WriteLine("Onko eläin lihansyöjä? kirjoita joko true tai false");
            koiruli.Vore = Boolean.Parse(Console.ReadLine());

            Console.WriteLine("Koiran nimi on {0}", koiruli.Nimi);
            Console.WriteLine("Koira on {0} vuotta vanha", koiruli.Ika);
            Console.WriteLine("Onko lihansyoja? {0}",koiruli.Vore);
            Console.ReadKey();
        }
    }
}
