using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guessing_game
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the Guess The Number game!");
            Console.WriteLine("\n");
            Console.WriteLine(@"Choose among: EASY (press 1), NORMAL (press 2) and DIFFICULT (press 3) for difficulty level");
            int difficulty = int.Parse(Console.ReadLine());

            //call the function
            GuessingGame(difficulty);

            Console.WriteLine("If you like to play again press OK, but if you like to quit press STOP");
            string newChoice = Console.ReadLine().ToLower();
            if (newChoice == "ok")
            {
                Console.WriteLine("Choose difficulty:");
                string newDiff = Console.ReadLine().ToLower();
                Console.WriteLine("\n");
                GuessingGame(newDiff);
            }
            else if (newChoice == "stop")
            {
                Console.WriteLine("Game over!");
            }

            Console.ReadLine();

        }
        public static void GuessingGame(int diff)
        {
            Random rm = new Random();
            switch (diff)
            {
                //case EASY-------------------------------------
                case 1:
                    Console.WriteLine("You have chosen level EASY and you have to guess numbers between 1 - 100.");
                    Console.WriteLine("\n");
                    Console.WriteLine("You have 9 tries!");
                    Console.WriteLine("\n");


                    int luckyNum = rm.Next(0, 100);

                    for (int i = 0; i < 9; i++)
                    {
                        Console.WriteLine("Your try number {0}: ", i + 1);
                        int userNum = int.Parse(Console.ReadLine());
                        int difference = userNum - luckyNum;
                        if (userNum == luckyNum)
                        {
                            Console.WriteLine("You've nailed it. Number entered {0}", userNum);
                            break;
                        }
                        else
                        {
                            if (userNum > luckyNum)
                            {
                                if ((userNum - luckyNum) > 20)
                                {
                                    Console.WriteLine("You're a lot higher than the lucky number! Number entered: {0}", userNum); ;
                                }
                                else
                                {
                                    Console.WriteLine("You're not so high than the lucky number! Number entered: {0}", userNum);

                                }
                                //Console.WriteLine("You're higher than the lucky number! Number entered: {0}", userNum);
                            }
                            else if (userNum < luckyNum)
                            {
                                if ((luckyNum - userNum) > 20)
                                {
                                    Console.WriteLine("You're a lot lower than the lucky number! Number entered: {0}", userNum);
                                }
                                else
                                {
                                    Console.WriteLine("You're not so low than the lucky number! Number entered: {0}", userNum);

                                }
                                //Console.WriteLine("You're lower than the lucky number! Number entered: {0}", userNum);
                            }
                        }

                    }
                    break;

                //case NORMAL---------------------------------------------
                case 2:
                    Console.WriteLine("You have chosen level NORMAL and you have to guess numbers between 1 - 500.");
                    Console.WriteLine("\n");
                    Console.WriteLine("You have 7 tries!");
                    Console.WriteLine("\n");

                    int luckyNum02 = rm.Next(0, 500);

                    for (int i = 0; i < 7; i++)
                    {
                        Console.WriteLine("Your try number {0}: ", i + 1);
                        int userNum = int.Parse(Console.ReadLine());
                        int difference = userNum - luckyNum02;
                        if (userNum == luckyNum02)
                        {
                            Console.WriteLine("You've nailed it. Number entered {0}", userNum);
                            break;
                        }
                        else
                        {
                            if (userNum > luckyNum02)
                            {
                                if ((userNum - luckyNum02) > 20)
                                {
                                    Console.WriteLine("You're a lot higher than the lucky number! Number entered: {0}", userNum); ;
                                }
                                else
                                {
                                    Console.WriteLine("You're not so high than the lucky number! Number entered: {0}", userNum);

                                }
                            }
                            else if (userNum < luckyNum02)
                            {
                                if ((luckyNum02 - userNum) > 20)
                                {
                                    Console.WriteLine("You're a lot lower than the lucky number! Number entered: {0}", userNum);
                                }
                                else
                                {
                                    Console.WriteLine("You're not so low than the lucky number! Number entered: {0}", userNum);

                                }
                            }
                        }
                    }
                    break;

                //case HARD---------------------------------------
                case 3:
                    Console.WriteLine("You have chosen level DIFFICULT and you have to guess numbers between 1 - 1000.");
                    Console.WriteLine("\n");
                    Console.WriteLine("You have 5 tries!");
                    Console.WriteLine("\n");

                    int luckyNum03 = rm.Next(0, 1000);

                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine("Your try number {0}: ", i + 1);
                        int userNum = int.Parse(Console.ReadLine());
                        int difference = userNum - luckyNum03;
                        if (userNum == luckyNum03)
                        {
                            Console.WriteLine("You've nailed it. Number entered {0}", userNum);
                            break;
                        }
                        else
                        {
                            if (userNum > luckyNum03)
                            {
                                if ((userNum - luckyNum03) > 20)
                                {
                                    Console.WriteLine("You're a lot higher than the lucky number! Number entered: {0}", userNum); ;
                                }
                                else
                                {
                                    Console.WriteLine("You're not so high than the lucky number! Number entered: {0}", userNum);
                                }
                            }
                            else if (userNum < luckyNum03)
                            {
                                if ((luckyNum03 - userNum) > 20)
                                {
                                    Console.WriteLine("You're a lot lower than the lucky number! Number entered: {0}", userNum);
                                }
                                else
                                {
                                    Console.WriteLine("You're not so low than the lucky number! Number entered: {0}", userNum);
                                }
                            }
                        }
                    }
                    break;
            }
            Console.ReadLine();
        }
    }
}
