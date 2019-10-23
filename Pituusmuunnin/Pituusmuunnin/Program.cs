using System;

namespace Pituusmuunnin
{
    class Program
    {
        static void Main(string[] args)
        {
            double z, x = 100, y = 160934, v = 91, m = 2;

            Console.WriteLine("Kuinka pitka olet");
            z = int.Parse(Console.ReadLine());
            Console.WriteLine("olet " + z / x + " metria " + z / y + " mailia " + z / v + " jaardia " + z / m + " tuumaa pitka");
            Console.ReadKey();

        }
    }
}
