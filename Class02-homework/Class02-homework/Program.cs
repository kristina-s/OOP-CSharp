using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class02_homework
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Find out what is behind door: 1, 2 or 3 by entering the appropriate number!");
            //byte x = byte.Parse(Console.ReadLine());
            //switch (x)
            //{
            //    case 1:
            //        Console.WriteLine("You got a new car!");
            //        break;
            //    case 2:
            //        Console.WriteLine("You got a new plane!");
            //        break;
            //    case 3:
            //        Console.WriteLine("You got a new bike!");
            //        break;
            //    default:
            //        Console.WriteLine("No door with that number!");
            //        break;
            //}
            //Console.ReadLine();

            Console.WriteLine("Enter the first number:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the third number:");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the fourth number:");
            int d = int.Parse(Console.ReadLine());
            int res = (a + b + c + d) / 4;
            Console.WriteLine($"The average of {a}, {b}, {c} and {d} is: {res}");
            Console.ReadLine();
        }
    }
}
