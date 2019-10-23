using System;

namespace tekstin_käsittely
{
    class Program
    {
        static void Main(string[] args)
        {
            int liikkuu = 1;

            while (liikkuu < 2)
            {
                Console.WriteLine("Kirjoita jokin sana.");
                string syote = Console.ReadLine();
                char[] teksti = syote.ToCharArray();

                Console.WriteLine("");
                int index = syote.IndexOf("a", 0, teksti.Length);

                if (index >= 0)
                {
                    index++;
                    Console.WriteLine("Ensimmäinen (a) kirjaimen järjestys luku on " + index);
                    Console.WriteLine("");
                }
                else if (index == -1)
                {
                    Console.WriteLine("Teksti ei sisällä (a) kirjainta");
                }

                try
                {

                    for (int i = 0; i < teksti.Length; i++)
                    {

                        Console.Write(teksti[i]);

                    }

                    Console.WriteLine(" ");

                    for (int x = 0; x < teksti.Length; x++)
                    {

                        Console.Write(teksti[x] + " ");

                    }

                    Console.WriteLine(" ");
                    Array.Reverse(teksti);

                    for (int c = 0; c < teksti.Length; c++)
                    {

                        Console.Write(teksti[c] + " ");

                    }

                    Console.WriteLine(" ");
                    Console.WriteLine("Kokeillaanko uudestaan? Y/N");
                    string jatkuu = Console.ReadLine();
                    if (jatkuu == "y")
                    {
                        Console.ReadKey();
                    }
                    else if (jatkuu == "n")
                    {
                        liikkuu++;
                    }


                }
                catch
                {
                    Console.WriteLine("tapahtui virhe.");
                }
            }
        }
    }
}