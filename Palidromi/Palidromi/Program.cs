using System;

namespace Palidromi
{
    class Program
    {
        static void Main(string[] args)
        {
            string pali = "";
            int raise = 0;
            int check = 0;
            Console.WriteLine("Hello, Welcome to my program");
            Console.WriteLine("Insert a word and we will check if it is a Palidrome.");
            string text = Console.ReadLine();
            char[] original = text.ToCharArray();
            char[] reverse = new char[text.Length];
            
            for(int i = original.Length - 1; i > -1; --i )
            {
                reverse[raise] = original[i];
                raise++;
            }

            foreach(char c in original)
            {
                Console.Write($"{c}");
            }

            Console.WriteLine("");

            foreach(char c in reverse)
            {
                Console.Write($"{c}");
            }

            Console.WriteLine("");

            for (int j = 0; j < reverse.Length; j++)
            {
                if (reverse[check] == original[check])
                {
                    check++;
                    pali = "ispali";
                }
                else if(reverse[check] != original[check])
                {
                    
                    pali = "notpali";
                    break;
                }
                
            }

            if (pali == "ispali")
            {
                Console.WriteLine("Word you have given is a Palidrome.");
            }
            else if (pali == "notpali")
            {
                Console.WriteLine("Word you have given is not Palidrome.");
            }
            
        }
    }
}
