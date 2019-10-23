using System;

namespace merkin_tarkistus
{
    class Program
    {
        static void Main(string[] args)
        {
            int liikkuu = 1;
            ConsoleKeyInfo syote;
            char merkki;
            while (liikkuu < 2)
            {
                
                try
                {

                    Console.WriteLine("Syötä jokin merkki");
                    syote = Console.ReadKey();
                    merkki = syote.KeyChar;
                    Console.WriteLine(" ");

                    if (Char.IsDigit(merkki))
                    {
                        Console.WriteLine("merkki on numero. ");
                        Console.WriteLine(merkki);
                        Console.ReadKey();
                    }
                    else if (Char.IsUpper(merkki))
                    {
                        Console.WriteLine("Merkki on iso kirjain. ");
                        Console.WriteLine(merkki);
                        Console.ReadKey();
                    }
                    else if (Char.IsLower(merkki))
                    {
                        Console.WriteLine("Merkki on pieni kirjain. ");
                        Console.WriteLine(merkki);
                        Console.ReadKey();
                    }
                    else if (Char.IsSymbol(merkki))
                    {
                        Console.WriteLine("Merkki on symboli. ");
                        Console.WriteLine(merkki);
                        Console.ReadKey();
                    }
                    else if (Char.IsSeparator(merkki))
                    {
                        Console.WriteLine("Merkki on tyhjä. ");
                        Console.WriteLine(merkki);
                        Console.ReadKey();
                    }

                }
                catch
                {
                    Console.WriteLine("Tapahtui virhe. Yrittäkää uudelleen");
                }
                finally
                {
                    Console.WriteLine("Haluatko jatkaa? paina N sulkeaksesi");
                    string sulku = Console.ReadLine();
                    if (sulku == "n")
                    {
                        liikkuu++;
                    }
                
                    else
                    {
                        Console.WriteLine("Jatketaan");
                    }
                }
            }
        }
    }
}
