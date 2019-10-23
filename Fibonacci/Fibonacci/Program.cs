using System;

namespace Fibonacci
{
    class Program
    {

        public static int Fibonacci(int val1, int val2, int val3, int n) //Fibonacci.
        {
            for (int i = 2; i < n; i++)
            {
                val3 = val1 + val2;
                Console.Write(val3 + " ");
                val1 = val2;
                val2 = val3;
            }

            return val3;
        }
        /* Fibonacci subroutine.*/ 


        static void Main(string[] args)
        {
            int tilt = 1;
            while (tilt < 2)
            {

                try
                {
                    int value1 = 0, value2 = 1, value3 = 0, n;

                    Console.WriteLine("Give Fibonacci it's numerical lenght");
                    n = int.Parse(Console.ReadLine());

                    Console.WriteLine("Fibonacci series test"); 
                    Console.Write(value1 + " " + value2 + " ");

                    int text = Fibonacci(value1, value2, value3, n); // subroutine for Fibonacci.
                    Console.WriteLine("");
                    Console.WriteLine("Last value is: " + text); //Gives last value in Fibonacci.
                }

                catch
                {
                    Console.WriteLine("Value not found");
                }

                try
                {
                    /*Program continuation system.*/
                    Console.WriteLine("Do you want to continue? (y/n)");
                    string answer = Console.ReadLine();

                    if(answer == "y")
                    {
                        Console.WriteLine("Program continues");
                    }
                    else if(answer == "n")
                    {
                        Console.WriteLine("Closing program");
                        tilt++;
                    }
                }

                catch
                {
                    Console.WriteLine("Error occured. Closing Program");
                    tilt++;
                }
            }
        }
    }
}
