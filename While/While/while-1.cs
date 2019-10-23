using System;

namespace While
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int x = 1;
            int[] b = new int[x];
            Console.WriteLine("Syötä lotto luku");
            int luku = Convert.ToInt32(Console.ReadLine());

            while (a == 45 && b[x] < 6)
            {
                Console.WriteLine("Syötä lotto luku");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(b[x] = a);
                x++;
            }
            Console.ReadKey();
        }
    }
}
