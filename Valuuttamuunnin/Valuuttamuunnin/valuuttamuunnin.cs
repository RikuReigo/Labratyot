using System;

namespace Valuuttamuunnin
{
    class Program
    {
        static void Main(string[] args)
        {
            double e;
            double d = 1.12;
            double dol;
            double eu = 0.89;

            Console.WriteLine("Syota varallisuus Euroina");
            e = int.Parse(Console.ReadLine());
            Console.WriteLine(e + " Euroa on " + e * d + "$ Dollaria");
            Console.WriteLine("Kuinka monta Dollaria tarvitsisit?");
            dol = int.Parse(Console.ReadLine());
            Console.WriteLine(dol + "$ dollariin vaihtaaksesi tarvitset " + dol * eu + " Euroa");
        }
    }
}
