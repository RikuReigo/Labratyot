using System;

namespace taulukko_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Overwatch Sankari taulukko");

            string[,] sankari = new string[5, 4]
            {{"Hero", "Role", "Health", "Armor"}, {"Ana", "support", "200", "0" } ,{"Bastion","Defense","200","0"}, {"Brigit","support","200","50" }, {"D.va","Tank","400","200" } };

            Console.WriteLine(sankari[0, 0]);
            Console.WriteLine(sankari[1, 0]);
            Console.WriteLine(sankari[2, 0]);
            Console.WriteLine(sankari[3, 0]);
            Console.WriteLine(sankari[4, 0]);
            start:
            for (; ; )
            {

                Console.WriteLine("which hero do you choose?(Write name)");
                string x = Console.ReadLine();

                if (x == "Ana")
                {
                    Console.WriteLine(sankari[1, 0] + "\t" + sankari[1, 1] + "\t" + sankari[1, 2] + "\t" + sankari[1, 3]);
                    goto again;
                }
                else if (x == "Bastion")
                {
                    Console.WriteLine(sankari[2, 0] + "\t" + sankari[2, 1] + "\t" + sankari[2, 2] + "\t" + sankari[2, 3]);
                    goto again;
                }
                else if (x == "Brigit")
                {
                    Console.WriteLine(sankari[3, 0] + "\t" + sankari[3, 1] + "\t" + sankari[3, 2] + "\t" + sankari[3, 3]);
                    goto again;
                }
                else if (x == "D.va")
                {
                    Console.WriteLine(sankari[4, 0] + "\t" + sankari[4, 1] + "\t" + sankari[4, 2] + "\t" + sankari[4, 3]);
                    goto again;
                }
                else
                    Console.WriteLine("Error, press enter to quit, type restart to try again");
                string q = Console.ReadLine();
                if (q == "restart")
                {
                }
                else if (q != " ")
                {
                    return;
                }
                again:
                Console.WriteLine("Would you like to try another hero? Y/N");
                string r = Console.ReadLine();
                if (r == "y" || r == "Y")
                {
                    goto start;
                }
                if (r == "n" || r == "N")
                    return;
                else
                    return;
            }
        }
    }
}
