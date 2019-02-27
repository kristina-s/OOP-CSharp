using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class02_bonus
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter degrees celsius: ");
            int t = int.Parse(Console.ReadLine());

            if (t < 0)
            {
                Console.WriteLine("Freezing weather!");
            }else if ((t > 0) && (t < 10))
            {
                Console.WriteLine("Very cold weather!");
            }else if ((t >= 10) && (t < 20))
            {
                Console.WriteLine("Cold weather!");
            }else if ((t >= 20) && (t < 30))
            {
                Console.WriteLine("Normal temperature!");
            }else if ((t >= 30) && (t < 40))
            {
                Console.WriteLine("It's hot!");
            }else if (t >= 40)
            {
                Console.WriteLine("It's very hot!");
            }
            Console.ReadLine();

        }
    }
}
