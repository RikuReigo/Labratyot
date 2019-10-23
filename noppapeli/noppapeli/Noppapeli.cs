using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;


namespace noppapeli
{
    class Program
    {
        public static int randomnumber()
        {
            Random rnd = new Random();
            int noppa1 = rnd.Next(1, 7);
            int noppa2 = rnd.Next(1, 7);
            Console.WriteLine("noppa 1: " + noppa1 + " ja noppa 2: " + noppa2);
            int tulos1 = noppa1 + noppa2;
            Console.WriteLine("yhteis tulos: " + tulos1);
            return tulos1;

        }



        static void Main(string[] args)
        {
            int peli = 1;
            int tulos = 0;
            int tilanne = 0;

            while (peli < 2)
            {
                Console.WriteLine("Let's play dice game. Press enter to start");
                Console.WriteLine("Peli sisältää viisi kierrosta nopan heittoa.");
                Console.ReadKey();
                try
                {
                    for (int i = 0; i < 5; i++)
                    {
                        tulos = randomnumber();
                        tilanne = tilanne + tulos;
                        Console.WriteLine("");
                        Console.WriteLine("kokonais tulos: " + tilanne);
                        Console.WriteLine("Paina jotain nappia jatkaaksesi.");
                        Console.ReadKey();
                    }
                }
                catch
                {
                    Console.WriteLine("Something went wrong");
                }
                finally
                {
                    Console.WriteLine("Otetaanko uusi peli? paina K jatkaaksesi");
                    string lopetus = Console.ReadLine();
                    if (lopetus == "k")
                    {
                        Console.WriteLine("jatketaan");
                    }
                    else
                        peli++;
                }
            }
        }
    }
}
