using System;

namespace Matikkapeli
{
    class Program
    {
        public static int Plusmath(int random1, int random2) // plus math task subroutine
        {
            int answer = random1 + random2;
            int planswer;
            int cw = 0;

            Console.WriteLine("Task is: " + random1 + " + " + random2 + " = ?");
            Console.Write("What is the answer?: ");
            planswer = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            if (planswer == answer)
            {
                Console.WriteLine("Correct");
                cw = 1;
                return cw;
            }
            else if (planswer != answer)
            {
                Console.WriteLine("Answer is wrong");
                cw = 2;
                return cw;
            }
            else
                return cw;
        }

        public static int Minusmath(int random1, int random2) // Minus math task subroutine
        {
            int answer = random1 - random2;
            int planswer;
            int cw = 0;

            Console.WriteLine("Task is: " + random1 + " - " + random2 + " = ?");
            Console.Write("What is the answer?: ");
            planswer = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            if (planswer == answer)
            {
                Console.WriteLine("Correct");
                cw = 1;
                return cw;
            }
            else if (planswer != answer)
            {
                Console.WriteLine("Answer is wrong");
                cw = 2;
                return cw;
            }
            else
                return cw;
        }

        public static int Divisionmath(decimal random1, decimal random2) // Division math task subroutine
        {
            decimal answer = random1 / random2;
            decimal planswer;
            int cw = 0;

            Console.WriteLine("Task is: " + random1 + " / " + random2 + " = ?");
            Console.Write("What is the answer?: ");
            planswer = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            if (planswer == answer)
            {
                Console.WriteLine("Correct");
                cw = 1;
                return cw;
            }
            else if (planswer != answer)
            {
                Console.WriteLine("Answer is wrong");
                cw = 2;
                return cw;
            }
            else
                return cw;
        }

        public static int Multimath(int random1, int random2) //Multiplication math task subroutine
        {
            int answer = random1 * random2;
            int planswer;
            int cw = 0;

            Console.WriteLine("Task is: " + random1 + " * " + random2 + " = ?");
            Console.Write("What is the answer?: ");
            planswer = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            if (planswer == answer)
            {
                Console.WriteLine("Correct");
                cw = 1;
                return cw;
            }
            else if (planswer != answer)
            {
                Console.WriteLine("Answer is wrong");
                cw = 2;
                return cw;
            }
            else
                return cw;
        }


        public static int Randomizer1(int random1)
        {
            Random nmbr = new Random();
            random1 = nmbr.Next(1, 31);
            return random1;
        }
        /* Randomize first task number */


        public static int Randomizer2(int random2)
        {
            Random nmbr = new Random();
            random2 = nmbr.Next(1, 31);
            return random2;
        }
        /* Randomize second task number */


        static void Main(string[] args)
        {
            int programclose = 1; //program continuation int
            int random1 = 0; //random number 1
            int random2 = 0; //random number 2
            int pointcounter = 0; //pointcounter
            int answer; //get subroutine Correct/Wrong
            decimal rand1; //decimal for division
            decimal rand2; //decimal for division

            Console.WriteLine("Welcome to Mathematics game!");
            Console.WriteLine("In this program, you are tasked with mathematic problems.");
            Console.WriteLine("For each correct answer you gain points.");
            Console.WriteLine("No, these points don't have any real worth.");

            do // Run program until told to close
            {
                try
                {
                    for (int i = 0; i < 200; i++) //run until 200 
                    {
                        random1 = Randomizer1(random1); //picks first random number

                        random2 = Randomizer2(random2); //picks second random number

                        Console.WriteLine("Choose from plus(1), minus(2), division(3) and multiplication(4) tasks. ");
                        int taskask = int.Parse(Console.ReadLine()); // choose what type of math task you want to try

                        if (taskask == 1) 
                        {
                            answer = Plusmath(random1, random2); //Send to plus type math task subroutine
                            
                            if (answer == 1)
                            {
                                pointcounter++;
                                Console.WriteLine("Your current point count is: " + pointcounter);
                            }
                            else if (answer != 1)
                            {
                                Console.WriteLine("Your current point count is: " + pointcounter);
                            }
                        }
                        else if (taskask == 2)
                        {
                            answer = Minusmath(random1, random2); //Send to plus type math task subroutine

                            if (answer == 1)
                            {
                                pointcounter++;
                                Console.WriteLine("Your current point count is: " + pointcounter);
                            }
                            else if (answer != 1)
                            {
                                Console.WriteLine("Your current point count is: " + pointcounter);
                            }
                        }
                        else if (taskask == 3)
                        {
                            rand1 = random1;
                            rand2 = random2;

                            if (rand1 < rand2)
                            {
                                answer = Divisionmath(rand2, rand1); //Send to division type math task subroutine

                                if (answer == 1)
                                {
                                    pointcounter++;
                                    Console.WriteLine("Your current point count is: " + pointcounter);
                                }
                                else if (answer != 1)
                                {
                                    Console.WriteLine("Your current point count is: " + pointcounter);
                                }
                            }
                            else if (rand2 < rand1)
                            {
                                answer = Divisionmath(rand1, rand2); //Send to division type math task subroutine

                                if (answer == 1)
                                {
                                    pointcounter++;
                                    Console.WriteLine("Your current point count is: " + pointcounter);
                                }
                                else if (answer != 1)
                                {
                                    Console.WriteLine("Your current point count is: " + pointcounter);
                                }
                            }

                        }
                        else if (taskask == 4)
                        {
                            answer = Multimath(random1, random2); //Send to multiplication type math task subroutine

                            if (answer == 1)
                            {
                                pointcounter++;
                                Console.WriteLine("Your current point count is: " + pointcounter);
                            }
                            else if (answer != 1)
                            {
                                Console.WriteLine("Your current point count is: " + pointcounter);
                            }
                        }
                        else
                            Console.WriteLine("That task does not exist.");

                        Console.WriteLine("");
                        Console.WriteLine("Do you want to continue? y/n"); //Ask for continuation of program.
                        string quit = Console.ReadLine();

                        if (quit == "y") //Program continuation
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Continuing program");
                        }
                        else if (quit == "n") //Program closure
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Closing program");
                            i = 200;
                            programclose++;
                        }
                    }
                }
                catch
                {
                    Console.WriteLine("Something went wrong");
                }
                finally
                {
                    Console.WriteLine("Your current point count is: " + pointcounter);
                }
            } while (programclose < 2);
        }
    }
}
