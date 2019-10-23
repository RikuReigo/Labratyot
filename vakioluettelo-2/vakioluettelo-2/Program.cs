using System;

namespace Vakioluettelo
{
    class Program
    {

        enum tehtava
        { lisaaika = 1, lisaanimi, naytaika, naytanimi, suljohjelma }


        static void Main(string[] args)
        {
            int ikasi = 0;
            string nimesi = "";
            int liikkuu = 1;
            DateTime date1 = DateTime.Now;
            var date2 = new DateTime();

            Console.WriteLine("Tervetuloa ohjelmaan, siirry valikossa valitsemalla numero");

            while (liikkuu < 2)
            {

                try
                {
                    Console.WriteLine((int)tehtava.lisaaika + ". \t syötä syntymäpäiväsi");
                    Console.WriteLine((int)tehtava.lisaanimi + ". \t syötä nimesi");
                    Console.WriteLine((int)tehtava.naytaika + ". \t näytä ikäsi");
                    Console.WriteLine((int)tehtava.naytanimi + ". \t näytä nimesi");
                    Console.WriteLine((int)tehtava.suljohjelma + ". \t sulje ohjelma");
                    int syote = int.Parse(Console.ReadLine());

                    if (syote == 1)
                    {
                        Console.WriteLine("Anna oma syntymäpäiväsi");
                        date2 = DateTime.Parse(Console.ReadLine());
                        ikasi = date1.Year - date2.Year;
                    }
                    else if (syote == 2)
                    {
                        Console.WriteLine("Anna oma nimesi");
                        nimesi = Console.ReadLine();
                    }
                    else if (syote == 3)
                    {
                        Console.WriteLine("Olet " + ikasi + " vuotias");
                    }
                    else if (syote == 4)
                    {
                        Console.WriteLine("Nimesi on " + nimesi);
                    }
                    else if (syote == 5)
                    {
                        liikkuu++;
                    }
                }
                catch
                {
                    Console.WriteLine("Tapahtui virhe, käytittehän numeroa valikossa?");
                }

            }
        }
    }
}
