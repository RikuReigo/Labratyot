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
            List<string> elainkunta = new List<string>();
            List<string> kissat = new List<string>();
            List<string> koirat = new List<string>();
            List<string> papukaijat = new List<string>();
            List<string> hevoset = new List<string>();

            for (int i = 1; i < 13; i++)
            {
                if (i == 1 || i == 7 || i == 10)
                {
                    Kissa2 kisuli = new Kissa2();
                    Console.WriteLine("Eläin on kissa");

                    Console.WriteLine("Anna nimi");
                    kisuli.Nimi = Console.ReadLine();

                    Console.WriteLine("Anna ikä");
                    kisuli.Ika = int.Parse(Console.ReadLine());

                    Console.WriteLine("Onko lihansyöjä? kirjoita true tai false");
                    kisuli.Vore = Convert.ToBoolean(Console.ReadLine());

                    Console.WriteLine("Onko karvoitusta");
                    kisuli.Karvoitus = Console.ReadLine();

                    elainkunta.Add("Nimi: " + kisuli.Nimi + " Ikä: " + kisuli.Ika);
                    kissat.Add("Nimi: " + kisuli.Nimi + " Ikä: " + kisuli.Ika + " Onko Lihansyöjä: " + kisuli.Vore + " Onko karvoitus: " + kisuli.Karvoitus);
                }
                else if (i == 2 || i == 5 || i == 11)
                {
                    Koira2 koiruli = new Koira2();
                    Console.WriteLine("Eläin on koira");

                    Console.WriteLine("Anna nimi");
                    koiruli.Nimi = Console.ReadLine();

                    Console.WriteLine("Anna ikä");
                    koiruli.Ika = int.Parse(Console.ReadLine());

                    Console.WriteLine("Onko lihansyöjä? kirjoita true tai false");
                    koiruli.Vore = Convert.ToBoolean(Console.ReadLine());

                    Console.WriteLine("Onko karvoitusta");
                    koiruli.Karvoitus = Console.ReadLine();

                    elainkunta.Add("Nimi: " + koiruli.Nimi + " Ikä: " + koiruli.Ika);
                    koirat.Add("Nimi: " + koiruli.Nimi + " Ikä: " + koiruli.Ika + " Onko Lihansyöjä: " + koiruli.Vore + " Onko karvoitus: " + koiruli.Karvoitus);
                }
                else if (i == 3 || i == 6 || i == 9)
                {
                    Papukaija papukaija = new Papukaija();
                    Console.WriteLine("Eläin on papukaija");

                    Console.WriteLine("Anna nimi");
                    papukaija.Nimi = Console.ReadLine();

                    Console.WriteLine("Anna ikä");
                    papukaija.Ika = int.Parse(Console.ReadLine());

                    Console.WriteLine("Onko lihansyöjä? kirjoita true tai false");
                    papukaija.Vore = Convert.ToBoolean(Console.ReadLine());

                    Console.WriteLine("Onko sulkia");
                    papukaija.Sulat = Console.ReadLine();

                    elainkunta.Add("Nimi: " + papukaija.Nimi + " Ikä: " + papukaija.Ika);
                    papukaijat.Add("Nimi: " + papukaija.Nimi + " Ikä: " + papukaija.Ika + " Onko lihansyöjä: " + papukaija.Vore + " Onko sulkia: " + papukaija.sulat);
                }
                else if (i == 4 || i == 8 || i == 12)
                {
                    Hevonen2 heppa = new Hevonen2();
                    Console.WriteLine("Eläin on hevonen");

                    Console.WriteLine("Anna nimi");
                    heppa.Nimi = Console.ReadLine();

                    Console.WriteLine("Anna ikä");
                    heppa.Ika = int.Parse(Console.ReadLine());

                    Console.WriteLine("Onko lihansyöjä? kirjoita true tai false");
                    heppa.Vore = Convert.ToBoolean(Console.ReadLine());

                    Console.WriteLine("Onko karvoitusta");
                    heppa.Karvoitus = Console.ReadLine();

                    elainkunta.Add("Nimi: " + heppa.Nimi + " Ikä: " + heppa.Ika);
                    hevoset.Add("Nimi: " + heppa.Nimi + " Ikä: " + heppa.Ika + " Onko Lihansyöjä: " + heppa.Vore + " Onko karvoitus: " + heppa.Karvoitus);
                }
                Console.WriteLine("");
            }

            Console.WriteLine("");
            foreach (string tieto in elainkunta)
            {
                Console.WriteLine(tieto);
            }

            Console.WriteLine("");
            Console.WriteLine("Koirat");
            foreach (string kaverit in koirat)
            {
                Console.WriteLine(kaverit);
            }

            Console.WriteLine("");
            Console.WriteLine("Kissat");
            foreach (string pallot in kissat)
            {
                Console.WriteLine(pallot);
            }

            Console.WriteLine("");
            Console.WriteLine("Papukaijat");
            foreach (string pavut in papukaijat)
            {
                Console.WriteLine(pavut);
            }

            Console.WriteLine("");
            Console.WriteLine("Hevoset");
            foreach (string hepat in hevoset)
            {
                Console.WriteLine(hepat);
            }
        }
    }
}
