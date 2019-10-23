using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace laivanupotus
{
    class Program
    {
        public static string[,] playerfire(string[,] playerhit)
        {
            Console.WriteLine("Give first coordinate (0-4)");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Give second coordinate (0-4)");
            int y = int.Parse(Console.ReadLine());
            playerhit[x, y] = "X";
            return playerhit;
        }
        /* player 1 hit grid */

        public static string[,] player2fire(string[,] player2hit)
        {
            Random rnd = new Random();
            int x = rnd.Next(0, 5);
            int y = rnd.Next(0, 5);
            player2hit[x, y] = "X";
            return player2hit;
        }
        /* player 2 (computer) hit grid */

        public static string[,] playerplacement(string[,] playergrid)
        {
            Console.WriteLine("Give first coordinate (0-4)");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Give second coordinate (0-4)");
            int y = int.Parse(Console.ReadLine());
            playergrid[x, y] = "S";
            return playergrid;

        }
        /* player 1 ship placement into ship grid*/

        public static string[,] player2placement(string[,] player2grid)
        {
            Random rnd = new Random();
            int x = rnd.Next(0, 5);
            int y = rnd.Next(0, 5);
            player2grid[x, y] = "S";
            return player2grid;
        }
        /* Player 2 (computer) ship placement into ship grid. */

        public static string playercompare(string[,] playerhit, string[,] player2grid)
        {
            string hitormiss = "Miss!";
            for (int x = 0; x < 5; x++)
            {
                for (int y = 0; y < 5; y++)
                {
                    if (player2grid[x, y].Equals("S") && playerhit[x, y].Equals("X"))
                    {
                        hitormiss = "Hit!";
                        break;
                    }

                }
            }

            return hitormiss;
        }
        /* Compares player 1:s hit grid to player 2:s ship grid */

        public static string player2compare(string[,] player2hit, string[,] playergrid)
        {
            string hitormiss = "Miss!";
            for (int x = 0; x < 5; x++)
            {
                for (int y = 0; y < 5; y++)
                {
                    if (playergrid[x, y].Equals("S") && player2hit[x, y].Equals("X"))
                    {
                        hitormiss = "Hit!";
                        break;
                    }

                }
            }

            return hitormiss;
        }
        /* Compares player 2 (computer) hit grid to player 1:s ship grid. */
        
        static void Main(string[] args)
        {
            int cont = 1;
            string winner = "playing";
            string hitormiss = "no";

            string[,] playergrid = new string[5, 5] { { "O", "O", "O", "O", "O" }, { "O", "O", "O", "O", "O" }, { "O", "O", "O", "O", "O" }, { "O", "O", "O", "O", "O" }, { "O", "O", "O", "O", "O" }, };
            string[,] player2grid = new string[5, 5] { { "O", "O", "O", "O", "O" }, { "O", "O", "O", "O", "O" }, { "O", "O", "O", "O", "O" }, { "O", "O", "O", "O", "O" }, { "O", "O", "O", "O", "O" }, };
            string[,] playerhit = new string[5, 5] { { "O", "O", "O", "O", "O" }, { "O", "O", "O", "O", "O" }, { "O", "O", "O", "O", "O" }, { "O", "O", "O", "O", "O" }, { "O", "O", "O", "O", "O" }, };
            string[,] player2hit = new string[5, 5] { { "O", "O", "O", "O", "O" }, { "O", "O", "O", "O", "O" }, { "O", "O", "O", "O", "O" }, { "O", "O", "O", "O", "O" }, { "O", "O", "O", "O", "O" }, };

            while (cont < 2)
            {

                

                player2grid = player2placement(player2grid); // Computer places their ship.

                Console.WriteLine("Let's play battleships");
                Console.WriteLine("Player 1 place your ship");

                playergrid = playerplacement(playergrid); // player places their ship

                do
                {

                    try
                    {




                        playerhit = playerfire(playerhit); // player chooses firing target.

                        hitormiss = player2compare(playerhit, player2grid); //compare hit and ship grid to determine hit or miss.

                        Console.WriteLine(hitormiss);

                        if (hitormiss == "Hit!") // player 1 win announce.
                        {
                            winner = "player1";
                            Console.WriteLine("Winner is " + winner);
                            break;
                            
                        }

                        player2hit = player2fire(player2hit); // player 2 chooses firing target.

                        hitormiss = playercompare(player2hit, playergrid); // compare hit and ship grid to determine hit or miss.

                        Console.WriteLine(hitormiss);

                        if (hitormiss == "Hit!") // player 2 win announce.
                        {
                            winner = "player2";
                            Console.WriteLine("Winner is " + winner);
                            break;
                        }

                        for (int p1 = 0; p1 < 5; p1++) // player hitboard print.
                        {
                            Console.Write(playerhit[p1, 0] + " ");
                            Console.Write(playerhit[p1, 1] + " ");
                            Console.Write(playerhit[p1, 2] + " ");
                            Console.Write(playerhit[p1, 3] + " ");
                            Console.Write(playerhit[p1, 4] + " ");
                            Console.WriteLine("");
                        }
                        Console.WriteLine(" ");

                        for (int p2 = 0; p2 < 5; p2++) //player 2 hitboard print.
                        {
                            Console.Write(player2hit[p2, 0] + " ");
                            Console.Write(player2hit[p2, 1] + " ");
                            Console.Write(player2hit[p2, 2] + " ");
                            Console.Write(player2hit[p2, 3] + " ");
                            Console.Write(player2hit[p2, 4] + " ");
                            Console.WriteLine("");
                        }

                    }
                    catch
                    {
                        Console.WriteLine("Error has occured");
                        Console.ReadKey();
                    }
                } while (winner != "player1" || winner != "player2");


                Console.WriteLine("Do you want to play another round? Type y to play again.");
                string conti = Console.ReadLine();
                if (conti == "y")
                {
                    Console.WriteLine("New game.");
                }
                else
                    cont++;
            }

            Console.WriteLine("Closing program.");
        }
    }
}
