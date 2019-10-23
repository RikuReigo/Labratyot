using System;

namespace If_lauseet
{
    class Program
    {
        static void Main(string[] args)
        {
            start:

            int mies = 1;
            int nainen = 2;
            int v;
            int I;
            int a13 = 14;
            int a25 = 26;
            int a56 = 57;

            Console.WriteLine("Kirjoita 1 jos olet mies, 2 jos olet nainen.");
            v = Convert.ToInt32(Console.ReadLine());

            if(mies == v)
            {
               Console.WriteLine("Kuinka vanha herra on?");
                I = Convert.ToInt32(Console.ReadLine());
                if(I < a13)
                { Console.WriteLine("Mita poitsu"); }
                else if(I < a25)
                { Console.WriteLine("Mita nuori mies"); }
                else if(I < a56)
                { Console.WriteLine("Mita mies parhaassa iassa"); }
                else
                { Console.WriteLine("Mita vanha ukko"); }
                Console.ReadKey();
                Console.WriteLine();
                goto start;
            }

            else if(nainen == v)
            {
               Console.WriteLine("Kuinka vanha rouva on?");
                I = Convert.ToInt32(Console.ReadLine());
                if (I < a13)
                { Console.WriteLine("Mita Tytsy"); }
                else if (I < a25)
                { Console.WriteLine("Mita nuori nainen"); }
                else if (I < a56)
                { Console.WriteLine("Mita rouva parhaassa iassa"); }
                else
                { Console.WriteLine("Mita vanha akka"); }
                Console.ReadKey();
                Console.WriteLine();
                goto start;
            }

            else
            {
               Console.WriteLine("Error gender not found. Press any button to continue.");
                Console.ReadKey();
                Console.WriteLine();
                goto start;
            }
        }
    }
}
