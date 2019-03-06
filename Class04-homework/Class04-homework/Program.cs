using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class04_homework
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 01
            //task 01
            Console.WriteLine("Enter a number: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Factorial from {0} is {1}.", x, Factorial(x));
            // so rekurzivnata
            //Console.WriteLine("Factorial from {0} is {1}.", x, Factorial02(x));
            #endregion

            #region Task 02
            //Create datetime            
            DateTime dt = new DateTime(2018, 02, 21, 18, 50, 23, 230);

            //Example how it looks like in the output
            var t = String.Format("{0:t}", dt); // "6:50 PM" ShortTime
            //Console.WriteLine(t);
            var d = String.Format("{0:d}", dt); // 2/21/2018
            //Console.WriteLine(d);
            var T = String.Format("{0:T}", dt); // 6:50:23 PM - time with seconds
            //Console.WriteLine(T);
            var D = String.Format("{0:D}", dt); // Wednesday, February 21, 2018 - date with day of week
            //Console.WriteLine(D);
            var f = String.Format("{0:f}", dt); // Wednesday, February 21, 2018 6:50 PM - date with day of week and short time
            //Console.WriteLine(f);            
            var F = String.Format("{0:F}", dt); // "Wednesday, February 21, 2018 6:50:23 PM"
            //Console.WriteLine(F);
            var g = String.Format("{0:g}", dt); // 2/21/2018 6:50 PM - date time with numbers
            //Console.WriteLine(g);
            var G = String.Format("{0:G}", dt); // 2/21/2018 6:50:23 PM - date time with numbers plus seconds
            //Console.WriteLine(G);
            var m = String.Format("{0:m}", dt); // February 21 - month and day
            //Console.WriteLine(m);
            var y = String.Format("{0:y}", dt); // February 2018 - month and year
            //Console.WriteLine(y);
            var r = String.Format("{0:r}", dt); // Wed, 21 Feb 2018 18:50:23 GMT
            //Console.WriteLine(r);
            var s = String.Format("{0:s}", dt); // 2018-02-21T18:50:23
            //Console.WriteLine(s);
            var u = String.Format("{0:u}", dt); // 2018-02-21 18:50:23Z
            //Console.WriteLine(u);

            Console.WriteLine("--------------");

            DateTime TimeNow = DateTime.Now;
            DateTime TimeUtc = DateTime.UtcNow;
            DateTime TimeToday = DateTime.Today;
            Console.WriteLine("Current DateTime: {0} ", TimeNow);  	// Current DateTime: 3/6/2019 9:11:46 PM
            Console.WriteLine("UTC DateTime:     {0} ", TimeUtc); 	// UTC DateTime:     3/6/2019 8:12:02 PM
            Console.WriteLine("Today:            {0} ", TimeToday); // Today:            3/6/2019 12:00:00 AM
            Console.WriteLine();

            DateTime yesterday;
            yesterday = TimeNow.AddDays(-1);
            Console.WriteLine("Yesterday: {0}", yesterday);								// Yesterday: 3/5/2019 9:12:33 PM
            Console.WriteLine("The day before yesterday {0}", yesterday.TimeOfDay);		// The day before yesterday 21:12:43.7488707
            Console.WriteLine("Minus 2 hours: {0}", TimeNow.AddHours(-2));              // Minus 2 hours: 3/6/2019 7:12:56 PM

            int mDays = DateTime.DaysInMonth(2016, 2);
            Console.WriteLine("Month Feb, 2016 has {0} days.", mDays);							// Month Feb, 2016 has 29 days.
            Console.WriteLine("Month Feb, 2018 has {0} days.", DateTime.DaysInMonth(2018, 2));	// Month Feb, 2018 has 28 days.
            Console.ReadLine();
            #endregion

            #region Task 03
            Console.WriteLine("Enter some text: ");
            string myString = Console.ReadLine();
            
            Console.WriteLine("Your text has got {0} spaces.", myString.Count(Char.IsWhiteSpace));
            //first remove if there are extra white spaces!!!!!!!!
            string newStr = RemoveExtraSpaces(myString);
            string[] arrStr = newStr.Split(' ');
            Console.WriteLine("Your text has got {0} words.", arrStr.Length);
            Console.WriteLine("Your text's total length is: {0}", myString.Length);

            Console.ReadLine();
            #endregion
        }

        #region Functions Factorial
        static long Factorial(int a)
        {
            if (a == 0)
            {
                return 1;
            }
            long res = 1;
            for (int i = 2; i <= a; i++)
            {
                res = res * i;
            }
            return res;
        }
        // ovde moze neli i rekurzivnata sto ja si ja ucevme na JS
        static long Factorial02(int a)
        {
            if (a == 0)
            {
                return 1;
            }
            else
            {
                return a * Factorial02(a - 1);
            }
        }
        #endregion

        #region Function to remove extra spaces
        static string RemoveExtraSpaces(string input)
        {
            input = input.Trim();
            string output = "";
            bool WasLastCharSpace = false;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ' ' && WasLastCharSpace)
                    continue;
                WasLastCharSpace = input[i] == ' ';
                output += input[i];
            }
            return output;
        }
        #endregion

    }
}
