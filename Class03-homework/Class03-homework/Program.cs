using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class03_homework
{
    class Program
    {
        static void Main(string[] args)
        {
            //task 01
            //Console.WriteLine("Enter a number: ");
            //int a = int.Parse(Console.ReadLine());
            //for (int i=1; i<=a; i++)
            //{
            //    if(i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.ReadLine();

            //task 02
            //Console.WriteLine("Enter a number larger than 5: ");
            //int b = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= b; i++)
            //{
            //    if ((i % 3 == 0) && (i % 2 == 0))
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.ReadLine();

            //task 03
            //Console.WriteLine("Enter a more digit number:");
            //string myString = Console.ReadLine();
            ////Console.WriteLine(myString.Length);
            //var myNewArray = myString.ToCharArray();
            ////Console.WriteLine(myNewArray);
            //int product01 = 1;
            //for (int i = 0; i < myNewArray.Length; i++)
            //{
            //    string newStr = myNewArray[i].ToString();
            //    product01 *= int.Parse(newStr);
            //}
            //Console.WriteLine("Product of the digits is: {0}", product01);
            //Console.ReadLine();

            //task 04
            //Console.WriteLine("Enter a number: ");
            //int d = int.Parse(Console.ReadLine());
            //int sum01 = 0;
            //for (int i = 1; i <= d; i++)
            //{
            //    if(i % 2 == 0)
            //    {
            //        sum01 += i;
            //    }
            //}
            //Console.WriteLine("The sum is: {0}", sum01);
            //Console.ReadLine();

            //task 05
            //Console.WriteLine("Enter a number: ");
            //int e = int.Parse(Console.ReadLine());
            //int sum02 = 0;
            //for (int i = 1; i <= e; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        sum02 += i;
            //    }
            //}
            //Console.WriteLine("The sum is: {0}", sum02);
            //Console.ReadLine();

            //task 06
            //Console.WriteLine("Enter a number: ");
            //int f = int.Parse(Console.ReadLine());
            //int sum03 = 0;
            //for (int i = 1; i <= f; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        sum03 += i;
            //    }
            //}
            //Console.WriteLine("The sum is: {0}", sum03);
            //Console.ReadLine();

            //task 07
            //char[] myArray01 = new char[4] { 'a', 'b', 'c', 'd' };
            //Array.Reverse(myArray01);
            //Console.WriteLine(myArray01);
            //Console.ReadLine();

            //task 08
            //string[] string01 = new string[4] { "cat", "dog", "elephant", "tiger" };
            //string[] string02 = new string[4] { "dog", "cat", "tiger", "lion" };
            //if ((string01.Length > string02.Length) || (string01.Length < string02.Length))
            //{
            //    Console.WriteLine("Arrays not equal!");
            //}
            //else
            //{
            //    for (int i = 0; i < string01.Length; i++)
            //    {
            //        if (string01[i] != string02[i])
            //        {
            //            Console.WriteLine("Arrays not equal!");
            //            break;
            //        }
            //    }
            //}
            //Console.ReadLine();

            //task 09
            //for(int k=1; k<=1000; k++)
            //{
            //    string myString = k.ToString();
            //    var myNewArray02 = myString.ToCharArray();
            //    int sum05 = 0;
            //    for (int i = 0; i < myNewArray02.Length; i++)
            //    {
            //        string newStr = myNewArray02[i].ToString();
            //        sum05 += int.Parse(newStr);
            //    }
            //    if(k%sum05 == 0)
            //    {
            //        Console.Write("{0} ", k);
            //    }
            //};
            //Console.ReadLine();


            //task 10
            //for (int k = 1; k <= 1000; k++)
            //{
            //    string myString = k.ToString();
            //    var myNewArray02 = myString.ToCharArray();
            //    int product02 = 1;
            //    for (int i = 0; i < myNewArray02.Length; i++)
            //    {
            //        string newStr = myNewArray02[i].ToString();
            //        product02 *= int.Parse(newStr);
            //    }
            //    if (k % product02 == 0)
            //    {
            //        Console.Write("{0} ", k);
            //    }
            //};
            //Console.ReadLine();

            //task 11
            //for(int m = 11; m < 99; m++)
            //{
            //    string myString02 = m.ToString();
            //    var myNewArray03 = myString02.ToCharArray();
            //    string w = myNewArray03[0].ToString();
            //    string v = myNewArray03[1].ToString();
            //    int x = int.Parse(w);
            //    int y = int.Parse(v);
            //    if (x > y)
            //    {
            //        Console.WriteLine(m);
            //    }
            //}
            //Console.ReadLine();

            //task 12
            for( int n = 1; n<=100; n++)
            {
                if((n % 3 == 0) && (n % 5 == 0))
                {
                    Console.WriteLine("FizzBuzz");
                }
                if(n % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                if(n % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                
                Console.WriteLine(n);
            }
            Console.ReadLine();
        }
    }
}
