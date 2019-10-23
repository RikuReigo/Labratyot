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
            Koira koira = new Koira();

            Console.WriteLine("Name your dog.");
            koira.Nimi = Console.ReadLine();
            Console.WriteLine("Your dog's name is set into: " + koira.Nimi);

            Console.WriteLine("Rename your dog");
            koira.Nimi = Console.ReadLine();
            Console.WriteLine("Your dog's name is set into: " + koira.Nimi);
        }
    }
}
