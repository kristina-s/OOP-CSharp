using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class08_homework
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public byte Age { get; set; }
        public Gender PersonGender { get; set; }

        public Person(string firstName, string lastName, byte age, Gender PersonGender)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.PersonGender = PersonGender;
        }

        public virtual void GetInfo()
        {
            Console.WriteLine($"Name: {this.FirstName} {this.LastName}, Age: {this.Age}, Gender: {this.PersonGender} ");
        }

    }
}
