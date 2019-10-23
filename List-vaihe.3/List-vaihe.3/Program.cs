using System;
using System.Collections.Generic;

namespace list_vaihe_2
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> oppilas = new List<string>();


            string a;
            string b;

            Console.WriteLine("Oppilas lista");
            start:
            Console.WriteLine("Anna etunimi");
            a = Console.ReadLine();
            Console.WriteLine("Anna sukunimi");
            b = Console.ReadLine();
            oppilas.Add(b + "\t" + a);

            Console.WriteLine(" ");
            Console.WriteLine("Haluatko Lisätä toisen oppilaan? kyllä(k)/ei(e)");
            string c = Console.ReadLine();

            if (c == "k")
            {
                Console.WriteLine("Jatketaan.");
                Console.ReadKey();
                goto start;
            }
            else if (c == "e")
            {
                Console.WriteLine("Haluatko nähdä (A)aakkosittain vai (K)käänteisittäin? Älä kirjoita mitään nähdäksesi lisäys järjestyksessä");
                string j = Console.ReadLine();

                if (j == "a")
                {
                    oppilas.Sort();
                }
                else if (j == "k")
                {
                    oppilas.Sort();

                    oppilas.Reverse();
                }
            }
            
                Console.WriteLine("Montako oppilasta haluat nähdä? Anna luvuksi nolla nahdaksesi kaikki.");
                int pituus = Convert.ToInt32(Console.ReadLine());
                if (pituus > 0)
                for (int d = 0; d < pituus; d++)
                {
                    Console.WriteLine(oppilas[d]);
                }
                else
                    foreach (string nimi in oppilas)
                    {
                    Console.WriteLine(nimi);
                    }
            Console.WriteLine("Haluatko lisätä oppilaita listaan? kyllä(k)/ei(e)");
            c = Console.ReadLine();
            if (c == "k")
            {
                Console.WriteLine("Jatketaan.");
                Console.ReadKey();
                goto start;
            }
            else if (c == "e")
            {
                foreach (string nimi in oppilas)
                {
                    Console.WriteLine(nimi);
                }
                Console.ReadKey();
                return;
            }
            else
                return;
        }
    }
}
