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
            Random ageroll = new Random();
            for (int i = 0; i < 10; i++)
            {
                Koira koira = new Koira();
                koira.Ika = ageroll.Next(1, 16);
                Kissa kissa = new Kissa();
                kissa.Ika = ageroll.Next(1, 11);

                Console.WriteLine("Koira on " + koira.Ika + " vuotias, Kissa on " + kissa.Ika + " vuotias");

                if (koira.Ika > kissa.Ika)
                {
                    Console.WriteLine("Koira on vanhempi");
                }
                else if (koira.Ika < kissa.Ika)
                {
                    Console.WriteLine("Kissa on vanhempi");
                }
                else
                    Console.WriteLine("Koira ja kissa ovat yhtä vanhoja");
            }
        }
    }
}
