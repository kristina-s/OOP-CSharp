using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class08_homework
{
    public class Student:Person
    {
        public int Id { get; set; }
        public string Group { get; set; }
        public string Course { get; set; }

        public Student(string firstName, string lastName, byte age, Gender PersonGender, int id, string group, string course):base(firstName, lastName, age, PersonGender)
        {
            this.Id = id;
            this.Group = group;
            this.Course = course;
        }

        public override void GetInfo()
        {
            Console.WriteLine($"Full name:{this.FirstName} {this.LastName}, ID: {this.Id}, Group: {this.Group}");
        }
    }
}
