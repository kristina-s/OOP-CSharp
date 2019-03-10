    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class04_more_homework
{
    class Program
    {
        static void Main(string[] args)
        {
            //task 01
            Console.WriteLine("Enter some text:");
            string str01 = Console.ReadLine();
            CheckPalindrome(str01);
            Console.WriteLine("-----------------------------------------");

            //task 02
            int[] numbers01 = new int[10] { 4, 77, -96, 555, 123, 0, -18, 76, -905, 22 };
            Console.WriteLine("Max in the array is {0}", FindMaxInArray(numbers01));
            Console.WriteLine("-----------------------------------------");


            //task03
            Console.WriteLine("Enter some text:");
            string str02 = Console.ReadLine();
            Console.WriteLine("Pick 1 to count digits, or pick 2 to count vowels!");
            char choice = char.Parse(Console.ReadLine());
            FIndDigitsOrVowels(str02, choice);
            Console.WriteLine("-----------------------------------------");


            //task 04
            Console.WriteLine("Enter some text:");
            string str03 = Console.ReadLine();
            char[] chrArr = str03.ToCharArray();
            ToLowerToUpper(str03);
            Console.WriteLine("\n");
            Console.WriteLine("-----------------------------------------");


            //task 05
            Console.WriteLine("Enter a character: ");
            string c = Console.ReadLine();
            char b = char.Parse(c);
            CheckCharacterIsLetter(b);
            Console.WriteLine("-----------------------------------------");


            //task 06
            Console.WriteLine("Enter some text: ");
            string str04 = Console.ReadLine();
            Console.WriteLine("Enter the characters to search and count:");
            string subStr04 = Console.ReadLine();
            Console.WriteLine("There are {0} occurences of the pattern {1} in the string: {2}.", CheckSubstringOccurences(str04, subStr04), subStr04, str04);
            Console.WriteLine("-----------------------------------------");

            //task 07
            Console.WriteLine("Enter the base number:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the power:");
            int y = int.Parse(Console.ReadLine());
            double result = CalculatePower(x, y);
            Console.WriteLine("Number {0} on the power of {1} is {2}.", x, y, result);
            Console.WriteLine("-----------------------------------------");


            //task 08 and task 09
            DateTime dt = DateTime.Now;
            Console.WriteLine("Now {0}", dt);
            Console.WriteLine("Enter number of days to add: ");
            int d = int.Parse(Console.ReadLine());
            Console.WriteLine("It will be {0} after {1} day(s)!", CalculateWhatDay(d), d);
            Console.WriteLine("\n");
            Console.WriteLine("Enter number of years: ");
            int f = int.Parse(Console.ReadLine());
            Console.WriteLine("It was {0} before {1} year(s)!", CalculateWhatDayPast(f), f);
            Console.ReadLine();


        }
        #region All the Functions

        public static void CheckPalindrome(string a)
        {
            string back = new string(a.Reverse().ToArray());
            if(a == back)
            {
                Console.WriteLine("It's palindrome!");
            }
            else
            {
                Console.WriteLine("It's NOT a palindrome!");
            }
        }

        public static int FindMaxInArray(int[] array)
        {
            int max = Int32.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                int value = array[i];
                if (value > max)
                {
                    max = value;
                }
            }
            return max;
        }
        

        private static void FIndDigitsOrVowels(string a, char choice)
        {

            int numCount = 0;
            int vowCount = 0;

            switch (choice)
            {
                case '1':
                    foreach (var elem in a)
                    {
                        char e = elem;
                        if (a.All(Char.IsDigit))
                        {
                            numCount++;
                        }
                    };
                    Console.WriteLine($"There are {numCount} digits in the string!");
                    break;
                   

                case '2':
                    foreach (var item in a)
                    {
                        char g = item;
                        switch (item)
                        {
                            case 'a':
                                vowCount++;
                                break;
                            case 'e':
                                vowCount++;
                                break;
                            case 'i':
                                vowCount++;
                                break;
                            case 'o':
                                vowCount++;
                                break;
                            case 'u':
                                vowCount++;
                                break;
                        }
                        
                    }
                    Console.WriteLine($"There are {vowCount} vowels in the string!");
                    break;
            }
        }

        public static void ToLowerToUpper(string a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                char ch = a[i];
                if (Char.IsLower(ch)) 
                    Console.Write(Char.ToUpper(ch));
                else
                    Console.Write(Char.ToLower(ch)); 
            }
        }
        
        public static void CheckCharacterIsLetter (char b)
        {
            if (Char.IsLetter(b))
            {
                if (Char.IsLower(b))
                {
                    Console.WriteLine("Character is a letter and it's lowercase!");
                }else if (Char.IsUpper(b))
                {
                    Console.WriteLine("Character is a letter and it's UPPERCASE!");
                }
            }
            else
            {
                Console.WriteLine("Character is NOT a letter!");
            }
        }

        public static int CheckSubstringOccurences(string text, string part)
        {
            int count = 0;
            int i = 0;
            while ((i = text.IndexOf(part, i)) != -1)
            {
                i += part.Length;
                count++;
            }
            return count;
        }

        public static double CalculatePower(int a, int b)
        {
            if (b == 0)
            {
                return 1;
            }
            else
            {
                return (a * CalculatePower(a, b - 1));
            }
        }

        public static string CalculateWhatDay(int a)
        {
            DateTime dt = DateTime.Now;
            DateTime newDate = dt.AddDays(a);
            string dayOfWeek = newDate.DayOfWeek.ToString();
            return dayOfWeek;
        }

        public static string CalculateWhatDayPast(int a)
        {
            DateTime dt = DateTime.Now;
            DateTime newDate = dt.AddYears(-a);
            string dayOfWeek = newDate.DayOfWeek.ToString();
            return dayOfWeek;
        }
        #endregion
    }
}
