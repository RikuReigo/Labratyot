using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using Elainluokat;

namespace Elaimet
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Kissa kissa = new Kissa();
            // luodaan uusi olio

            Console.WriteLine("Give this cat a name.");
            kissa.Nimi = Console.ReadLine();

            Console.WriteLine("Name " + kissa.Nimi);

            Console.WriteLine("How old is it?");
            kissa.Ika = int.Parse(Console.ReadLine());
            //Anna olion nimi ja ika

            Console.WriteLine("Name " + kissa.Nimi + " Age " + kissa.Ika);

            Console.ReadKey();

            Kissa kisuli = new Kissa();
            // luodaan uusi olio
            
            //Tulosta nyt olion nimi ja ika, jotta varmistat uuden olion luonnin.
            Console.WriteLine("Give this cat a name.");
            kisuli.Nimi = Console.ReadLine();

            Console.WriteLine("Name " + kisuli.Nimi);

            Console.WriteLine("How old is it?");
            kisuli.Ika = int.Parse(Console.ReadLine());
            //Anna olion nimi ja ika

            Console.WriteLine("Name " + kisuli.Nimi + " Age " + kisuli.Ika);

            Console.ReadKey();
        }
    }
}

