using System;

namespace while_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 45;
            string ab;
            int d = 0;
            int[] c = new int[5];

            Console.WriteLine("Pelataan lottoa");

            while (a != b)
            {
                Console.WriteLine("Syötä lotto luku");
                a = Convert.ToInt32(Console.ReadLine());
                c[d] = a;
                Console.WriteLine(a);
                d++;
                Console.WriteLine("Paina enter jatkaaksesi, L lopettaaksesi pelin.");
                ab = Console.ReadLine();
                if (ab == "l")
                {
                    return;
                }
                else
                    Console.WriteLine("Peli jatkuu");
            }
            Console.WriteLine("Game Over");
            Console.ReadKey();
        }
    }
}
