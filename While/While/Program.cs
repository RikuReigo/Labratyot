using System;

namespace While
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            Console.WriteLine("Syötä alku luku");
            int luku = Convert.ToInt32(Console.ReadLine());

            while (a < 100)
            {
                Console.WriteLine("Syötä seuraava luku");
                b = Convert.ToInt32(Console.ReadLine());
                luku = b + luku;
                a = luku;
                Console.WriteLine(a);
            }
            Console.ReadKey();
        }
    }
}
