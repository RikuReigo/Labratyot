using System;

namespace Taulukko_3
{
    class Program
    {
        static void Main(string[] args)
        {
        start:


            Console.WriteLine("Montako tuotetta lisätään? (Max 10) ");
            int t = Convert.ToInt32(Console.ReadLine());
            t++;
            string[] tuote = new string[10];

            decimal[] hinta = new decimal[10];

            int[] maara = new int[10];

            int v = 0;

            for (int x = 1; x < t; x++)
            {
                for (int nimi = v; nimi < x; nimi++)
                {

                    Console.WriteLine("Anna tuotteen nimi");
                    string b = Console.ReadLine();

                    tuote[nimi] = b;
                }
                for (int ah = v; ah < x; ah++)
                {
                    Console.WriteLine("Anna tuotteen hinta");
                    decimal c = Convert.ToDecimal(Console.ReadLine());

                    hinta[ah] = c;

                }

                for (int num = v; num < x; num++)
                {
                    Console.WriteLine("Anna tuotteen määrä");
                    int a = Convert.ToInt32(Console.ReadLine());

                    maara[num] = a;

                }
                for (int i = 0; i < tuote.Length; i++)
                {
                    Console.WriteLine(tuote[i] + "\t" + hinta[i] + "\t" + maara[i]);
                }


                v++;

            }

            Console.WriteLine("Paina j jatkaaksesi, s sulkeaksesi ohjelman.");
            string jatko = Console.ReadLine();
            if (jatko == "j")
            {
                goto start;
            }
            else if (jatko == "s")
            {
                return;
            }
        }
    }
}
