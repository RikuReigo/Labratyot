using System;

namespace For_laskin
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            int y;
            Console.Write("Anna luku valilta 1-10: ");
            y = Convert.ToInt32(Console.ReadLine());
            for (; ; )
            {
                if (x < 11)
                {
                    Console.WriteLine(x + " * " + y + " = " + x * y + "\t" + x + " / " + y + " = " + x / y + "\t" + x + " % " + y + " = " + x % y);
                    x++;
                }
                else
                    break;
            }

        }
    }
}
