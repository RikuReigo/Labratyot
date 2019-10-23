using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace funktiot

{

    class Program

    {

        private static int Pienin(int eka, int toka, int kolmas)

        {
            int[] pieni = new int[3];
            pieni[0] = eka;
            pieni[1] = toka;
            pieni[2] = kolmas;

            Array.Sort(pieni);

            int pieninLuku = pieni[0];

            return pieninLuku;

            // oma koodi 

        }

        private static int Suurin(int eka, int toka, int kolmas)

        {
            
            int[] suuri = new int[3];
            suuri[0] = eka;
            suuri[1] = toka;
            suuri[2] = kolmas;

            Array.Sort(suuri);

            Array.Reverse(suuri);

            int suurinLuku = suuri[0];

            return suurinLuku;
            
            // oma koodi 

        }



        static void Main(string[] args)

        {
            bool res;
            int ans;
            int luku1, luku2, luku3, suurinLuku, pieninLuku;

            string syote;

            start:

            Console.WriteLine("Anna eka luku:");

            syote = Console.ReadLine();
            res = Int32.TryParse(syote, out ans);
            if (res)
            {
                
            }
            else
            {
                Console.WriteLine("Syöte ei täsmää");
                goto start;
            }
            luku1 = int.Parse(syote);

            Console.WriteLine("Anna toka luku:");

            syote = Console.ReadLine();
            res = Int32.TryParse(syote, out ans);
            if (res)
            {

            }
            else
            {
                Console.WriteLine("Syöte ei täsmää");
                goto start;
            }
            luku2 = int.Parse(syote);

            Console.WriteLine("Anna kolmas luku:");

            syote = Console.ReadLine();
            res = Int32.TryParse(syote, out ans);
            if (res)
            {

            }
            else
            {
                Console.WriteLine("Syöte ei täsmää");
                goto start;
            }
            luku3 = int.Parse(syote);

            suurinLuku = Suurin(luku1, luku2, luku3);

            pieninLuku = Pienin(luku1, luku2, luku3);


            Console.WriteLine("Suurin luku on: " + suurinLuku);
            Console.WriteLine("Pienin luku on: " + pieninLuku);
            Console.ReadKey();
            Console.WriteLine(" ");
            Console.WriteLine("Haluatko kokeilla uudestaan? Y/N");
            string jatko = Console.ReadLine();
            if (jatko == "y")
            {
                goto start;
            }
            else
                return;
            //Kutsu tässä Pienin ja Suurin ohjelmia ja anna niille parametreina luku1, luku2 ja luku3. 

            // Ota aliohjelmien tulokset talteen suurinLuku ja pieninLuku muuttujiin. Tulosta lopuksi tulokset 





        }

    }

}
