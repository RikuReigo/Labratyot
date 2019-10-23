using System;

namespace Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal summa = 0M;
            int x = 5;
            int[] numerot = new int[x];

            for (int a = 0; a < x; a++)
            {
                Console.WriteLine("Syötä luku");
                int c = Int32.Parse(Console.ReadLine());
                numerot[a] = c;
            }

            foreach (int b in numerot)
            {
                
                summa += b;
            }

            decimal keskiarvo = summa / numerot.Length;
            Console.WriteLine("Keskiarvo on : " + keskiarvo);
            Console.WriteLine();
        }
    }
}
