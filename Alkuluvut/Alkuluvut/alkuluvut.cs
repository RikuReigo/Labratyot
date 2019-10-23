using System;

namespace Alkuluvut
{
    class Program
    {
        static void Main(string[] args)
        {
            int close = 1;

            int[] arr = new int[] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29 };
            int number;

            do
            {
                try
                {
                    Console.WriteLine("Give a number");
                    number = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Does your number match with primes: {0}",
                        Array.Exists(arr, element => element == number));

                    int[] arr2 = Array.FindAll(arr, x => x <= number);

                    Console.WriteLine("Primes up to " + number + " are: ");

                    for(int i = 0; i < arr2.Length; i++)
                    {
                        Console.WriteLine("{0}" , arr2[i]);
                    }

                    Console.WriteLine("Do you want to continue program? Type y for yes.");
                    string end = Console.ReadLine();
                    if (end == "y")
                    {
                        Console.WriteLine("Program continues");
                    }
                    else if (end != "y")
                    {
                        close++;
                        Console.WriteLine("Closing Program");
                    }
                }
                catch
                {
                    Console.WriteLine("Your input could not be read.");
                }
            } while (close < 2);
        }
    }
}
