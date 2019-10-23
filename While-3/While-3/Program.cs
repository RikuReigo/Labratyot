using System;

namespace While_3
{
    class Program
    {
        private static int Tervehdys(string nimi)

        {

            Console.WriteLine("Tervetuloa ohjelmaan " + nimi + "!");
            Console.WriteLine("Kuinka vanha olet");
            int ika = int.Parse(Console.ReadLine());
            return ika;
        }



        static void Main(string[] args)

        {
            start:
            int mies = 1;
            int nainen = 2;
            int v;
            int a13 = 14;
            int a25 = 26;
            int a56 = 57;

            

            int ika;
            Console.WriteLine("Kirjoita 1 jos olet mies, 2 jos olet nainen.");
            v = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Anna Etunimi:");
            String etunimi = Console.ReadLine();
            Console.WriteLine("Anna Sukunimi");
            string sukunimi = Console.ReadLine();
            string nimi = etunimi + " " + sukunimi;
            ika = Tervehdys(nimi);
            Console.WriteLine(ika);


            

            if (mies == v)
            {
                if (ika < a13)
                { Console.WriteLine("Mita poitsu"); }
                else if (ika < a25)
                { Console.WriteLine("Mita nuori mies"); }
                else if (ika < a56)
                { Console.WriteLine("Mita mies parhaassa iassa"); }
                else
                { Console.WriteLine("Mita vanha ukko"); }
                Console.ReadKey();
                Console.WriteLine();
                goto start;
            }

            else if (nainen == v)
            {
                
                if (ika < a13)
                { Console.WriteLine("Mita Tytsy"); }
                else if (ika < a25)
                { Console.WriteLine("Mita nuori nainen"); }
                else if (ika < a56)
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
