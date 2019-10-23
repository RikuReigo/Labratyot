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
            Kissa kisu = new Kissa();
            //Tässä luot luokasta olion


            Console.WriteLine("Name " + kisu.Nimi + " Age " + kisu.Ika);
            //Tulosta olion nimi ja ika

            Kissa kissa = new Kissa();
            // luodaan uusi olio

            Console.WriteLine("Give this cat a name.");
            kissa.Nimi = Console.ReadLine();

            Console.WriteLine("How old is it?");
            kissa.Ika = int.Parse(Console.ReadLine());
            //Anna olion nimi ja ika

            Console.WriteLine("Name " + kisu.Nimi + " Age " + kisu.Ika);
            Console.WriteLine("Name " + kissa.Nimi + " Age " + kissa.Ika);
            Console.ReadKey();
            //Tulosta nyt olion nimi ja ika, jotta varmistat uuden olion luonnin.

        }
    }
}
