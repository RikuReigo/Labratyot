using System;

namespace For_Lotto
{
    class Program
    {
        static void Main(string[] args)
        {
            uusipeli:

            int pelin, lotto, kierros = 1;
            Random voitto = new Random();

            Console.WriteLine("Pelataan lottoa. valitse numero väliltä 1-50");
            pelin = Convert.ToInt32(Console.ReadLine());

            for (int haet = pelin; kierros < 6; kierros++)
            {
                Console.WriteLine("kierros " + kierros);
                    lotto = voitto.Next(1, 51);
                    Console.WriteLine("numeronne on " + haet + ". Lotto numero on; " + lotto);

                if (haet == lotto)
                    {
                            Console.WriteLine("Onneksi olkoon, te voititte!");
                        break;             
                    }

                else if (haet > 50)
                    {
                        Console.WriteLine("Luku ei kelpaa, yrittäkää uudelleen.");
                            Console.ReadKey();
                        goto uusipeli;
                    }
                else
                    Console.WriteLine("Ei voittoa, painakaa enter jatkaaksenne.");
                Console.ReadKey();

            }

            Console.Write("Paina k pelataksesi uudestaan, e lopettaaksesi.");
            string jatko = Console.ReadLine();
            if (jatko == "k")
            {
                goto uusipeli;
            }
            else
                return;
                
        }
    }
}
