using System;

namespace Helikopteri
{
    class Program
    {


        private static int luggage(int max, int cur)
        {
            int maxcap = max;
            int curcap = cur;
            int capleft = maxcap - curcap;
            Console.WriteLine("Maximum capacity is " + maxcap);
            return capleft;

        }



        private static int passenger(int one, int two)
        { 
            int maxpop = two;
            int curpop = one;
            int popleft = maxpop - curpop;
            return popleft;
        }



        static void Main(string[] args)
        {
            
            int close = 1;
            string end;

            try
            {
                Console.WriteLine("Instruction! helicopters recommended passenger count is 4 ");
                Console.WriteLine("and maximum luggage weight is 100 kilograms. You can fit one ");
                Console.WriteLine("more passenger but that reduces capacity by 80 kilograms, or you ");
                Console.WriteLine("can have one less passenger to increase the capacity by 80 kilograms");
                Console.WriteLine("");
                while (close < 2)
                {
                    int maxppl; // passengers, counts for 80kg
                    int curppl = 0; //passenger count
                    int maxcapa = 100; // kg 
                    int curcapa = 0; // luggage weight in kg
                    int remcapa; // previous passenger luggage weight;
                    int newcapa; // passengers luggage
                    int passengers;
                    int luggages;
                    int lugcou = 0;

                    Console.WriteLine("Start by giving the count of passengers");
                    maxppl = int.Parse(Console.ReadLine());
                    // Determine maximum amount of passengers and calculate maximum capacity
                    if (maxppl == 3)
                    {
                        maxcapa = maxcapa + 80;
                    }
                    else if (maxppl == 5)
                    {
                        maxcapa = maxcapa - 80;
                    }
                    else if (maxppl == 2)
                    {
                        maxcapa = maxcapa + 160;
                    }
                    else if (maxppl == 1)
                    {
                        maxcapa = maxcapa + 240;
                    }

                    do
                    {

                        Console.WriteLine("Do we add another passenger? Y/N");
                        string neet = (Console.ReadLine());
                        if (neet == "y" && curppl < maxppl)
                        {
                            curppl++; // add passenger
                            passengers = passenger(curppl, maxppl); // take passenger subroutine
                            Console.WriteLine("Currently we have " + (passengers) + "seats remaining");

                            Console.WriteLine("Does passenger have luggage? Y/N");
                            string lugsyn = Console.ReadLine();

                            if (lugsyn == "y" && curcapa < maxcapa) //check if there is luggage
                            {
                                Console.WriteLine("Passengers luggage count"); // ask for luggage count
                                lugcou = int.Parse(Console.ReadLine());
                                Console.WriteLine("Do you want to give each luggages weight invidually? Y /N"); // ask if we have invidual or combined weight
                                string checkup = Console.ReadLine();

                                if (checkup == "y")
                                {
                                    for (int i = 0; i < lugcou; i++)
                                    {
                                        Console.WriteLine("How much does passengers " + (i + 1) + " luggage weight"); // give invidual weight
                                        newcapa = int.Parse(Console.ReadLine());
                                        curcapa = curcapa + newcapa;
                                    }

                                    newcapa = curcapa;
                                    luggages = luggage(maxcapa, newcapa); // calculate capacity
                                    remcapa = maxcapa - luggages;
                                    Console.WriteLine("Currently used capacity is " + remcapa);
                                    Console.WriteLine("We still have " + (maxcapa - curcapa) + " kilograms of capacity");

                                }

                                else if (checkup == "n")
                                {
                                    Console.WriteLine("How much does passengers luggages weight"); // give combined luggage weight
                                    newcapa = int.Parse(Console.ReadLine());

                                    curcapa = curcapa + newcapa;
                                    luggages = luggage(maxcapa, newcapa); // calculate capacity
                                    remcapa = maxcapa - luggages;
                                    Console.WriteLine("Currently used capacity is " + remcapa);
                                    Console.WriteLine("We still have " + (maxcapa - curcapa) + " kilograms of capacity");
                                }

                                else
                                    Console.WriteLine("Error has occured, wrong input.");


                            }
                            else if (lugsyn == "n")
                            {
                                Console.WriteLine("No more luggage added");
                            }
                            else
                                Console.WriteLine("Error has occured, wrong input.");
                        }

                        else if (neet == "n")
                        {
                            maxppl = maxppl - 1;
                            maxcapa = maxcapa + 80;
                        }
                        else if (neet != "y" || neet != "n") // error breaker.
                        {
                            curppl = maxppl;
                            Console.WriteLine("Error has occured, wrong input. Restarting");
                        }

                        Console.WriteLine("Currently we have " + curppl + " passengers and " + (maxcapa-curcapa) + " kilograms of capacity");
                        // final passenger count and capacity.
                        if (curppl == maxppl && curcapa < maxcapa)
                        {
                            Console.WriteLine("Flight approved");
                        }

                        else if (curppl > maxppl || maxcapa < curcapa)
                        {
                            Console.WriteLine("Flight capacity exceeded, flight permission denied.");
                        }
                        
                    } while (curppl < maxppl && curcapa < maxcapa);

                    Console.WriteLine("Are we done? press N to close program");
                    end = Console.ReadLine();
                    if (end == "n")
                    {
                        close++;
                        Console.WriteLine("Closing program");
                    }
                    else
                        Console.WriteLine("Continuing program");
                    Console.ReadKey();

                }
            }
            catch
            {
                Console.WriteLine("Error has occured, closing program");
            }
            finally
            {
                Console.WriteLine("");
                Console.WriteLine("Thank you for using helicopter airlines");
            }
            
        }
    }
}
