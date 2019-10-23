using System;

namespace tre_catch_finally
{
    class Program
    {
        
        private static int Jakolasku (int eka, int toka)
        {
            
            int jaettava = eka, jakaja = toka, tulos;
            try
            {
                tulos = jaettava / jakaja;
                Console.WriteLine(jaettava + " / " + jakaja + " = " + tulos);
                return tulos;
            }
            catch (DivideByZeroException)
            {
                tulos = 0;
                Console.WriteLine("Virhe havaittu, yrititte jakaa ." + tulos);
                return tulos;
            }
            finally
            {
                Console.Write("Tuloksesi on = ");   
            }

        }



        static void Main(string[] args)
        {

            int jaettava, jakaja, tulos = 0;
            
            string ensin, toinen;
            try
            {
            Console.WriteLine("Anna jaettava luku");
            ensin = Console.ReadLine();
            jaettava = int.Parse(ensin);

            
            Console.WriteLine("Anna jakava luku");
            toinen = Console.ReadLine();
            jakaja = int.Parse(toinen);

            tulos = Jakolasku(jaettava, jakaja);
            }
            
            catch (FormatException)
            {
                Console.WriteLine("Virhe havaittu, antamanne arvo ei ole luku");
            }

            finally
            {
                Console.WriteLine(tulos);
                Console.WriteLine("Kiitos ohjelman kokeilemisesta.");
                Console.WriteLine("Ohjelma sulkeutuu.");
                Console.ReadKey();
            }

        }
    }
}
