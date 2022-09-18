 using System;

namespace ConsoleApp39
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string user;
            int random;
            
           
           

            Random random1 = new Random();
            int rndm = random1.Next(1, 4);
            bool playagain = true;

            while (playagain)
            {
                int scoreplayer = 0;
                int scoreuser = 0;

                while (scoreplayer < 3 && scoreuser < 3)
                { 
                    Console.WriteLine("pls choose ROCK,PAPER,SCISSOR");
                    string player = Console.ReadLine().ToUpper();


                    switch (rndm)
                    {
                        case 1:
                            user = "ROCK";
                            Console.WriteLine("USER chose ROCK");
                            if (player == "ROCK")
                            {
                                Console.WriteLine("Draw");
                            }
                            else if (player == "SCISSOR")
                            {
                                Console.WriteLine("user won");
                                scoreplayer++;
                            }
                            else if (player == "PAPER")
                            {
                                Console.WriteLine("player won");
                                scoreplayer++;
                            }
                            break;
                        case2:
                            user = "PAPER";
                            Console.WriteLine("USER chose PAPER");
                            if (player == "PAPER")
                            {
                                Console.WriteLine("DRAW");
                            }
                            else if (player == "SCISSORS")
                            {
                                Console.WriteLine("player won");
                                scoreplayer++;
                            }
                            else if (player == "ROCK")
                            {
                                Console.WriteLine("user won");
                                scoreuser++;
                            }
                            break;
                        case 3:
                            user = "SCISSOR";
                            Console.WriteLine("USER chose SCISSOR");
                            if (player == "SCISSOR")
                            {
                                Console.WriteLine("Draw");

                            }
                            else if (player == "ROCK")
                            {
                                Console.WriteLine("player won");
                                scoreplayer++;
                            }
                            else if (player == "PAPER")
                            {
                                Console.WriteLine("user won");
                                scoreuser++;
                            }
                            break;

                           default:
                            Console.WriteLine("invalid");
                            break;

                    }
                    Console.WriteLine("\n\n SCORES :\tPLAYER:\t{0}\tCPU:\t{1}", scoreplayer, scoreuser);

                }
                if (scoreplayer == 3)
                {
                    Console.WriteLine("player won:)");
                }
                if (scoreuser == 3)
                {
                    Console.WriteLine("user won:)");
                }

                string loop = Console.ReadLine();
                if (loop == "y")
                {
                    playagain = true;
                    Console.Clear();
                }
                else if (loop == "n")
                {
                    playagain = false;
                }
            }
        }
    }
}
