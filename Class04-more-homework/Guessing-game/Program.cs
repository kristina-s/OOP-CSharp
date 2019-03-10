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
            Console.WriteLine("Choose among: EASY, NORMAL and DIFFICULT for difficulty level");
            string difficulty = Console.ReadLine().ToLower();

            //call the function
            GuessingGame(difficulty);

            Console.WriteLine("If you like to play again press OK, but if you like to quit press STOP");
            string newChoice = Console.ReadLine().ToLower();
            if (newChoice == "ok")
            {
                Console.WriteLine("Choose difficulty:");
                string newDiff = Console.ReadLine().ToLower();
                GuessingGame(newDiff);
            }
            else if (newChoice == "stop")
            {
                Console.WriteLine("Game over!");
            }

            Console.ReadLine();

        }
        public static void GuessingGame(string diff)
        {
            Random rm = new Random();
            switch (diff)
            {
                //case EASY-------------------------------------
                case "easy":
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
                case "normal":
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
                case "hard":
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
