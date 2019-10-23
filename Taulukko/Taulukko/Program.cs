using System;

namespace Taulukko
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Montako hedelmää haluat nähdä? (Max 3)");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Monenko hedelmän hinnan haluat nähdä? (1 = 2, 2 = 5, 3 =10");
            int numtwo = Convert.ToInt32(Console.ReadLine());


            int[] taulukolme = new int[4];
            taulukolme [0] = 0;
            taulukolme [1] = 2;
            taulukolme [2] = 5;
            taulukolme [3] = 10;

            decimal[] taulukaksi = new decimal[4];
            taulukaksi [0] = 0.00M;
            taulukaksi [1] = 0.70M;
            taulukaksi [2] = 2.30M;
            taulukaksi [3] = 0.85M;

            string[] tauluyksi = new string[4];
            tauluyksi [0] = "PlaceHolder";
            tauluyksi [1] = "Omena";
            tauluyksi [2] = "Ananas";
            tauluyksi [3] = "Banaani";


            for (int i = 1; i < tauluyksi.Length; i++)
            {
                if (i <= num)
                {
                    Console.WriteLine(tauluyksi[i] + ", " + "\t" + "Yhteishinta on" + "\t" + (taulukaksi[i] * taulukolme[numtwo]) + "€, ");
                }
                else
                    break;
            }

            Console.ReadKey();
            return;
        }
    }
}
