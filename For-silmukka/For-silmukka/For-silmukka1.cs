using System;

namespace For_silmukka
{
    class Program
    {
        static void Main(string[] args)
        {

            int a;

            Console.WriteLine("Anna luku");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("aloitus numero on" + Console.ReadLine());

            int b = a + 10;

            for (;;)
            {
                if (a < b)
                {
                    Console.WriteLine(a);
                    a++;
                }
                else
                    break;
            }
        }
    }
}
