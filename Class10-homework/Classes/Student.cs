using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Student:Person
    {
        public List<Subject> ListOfSubjects { get; set; }
        public List<int> ListOfGrades { get; set; }


        public Student(string firstName, string lastName) : base(firstName, lastName, Role.Student)
        {
            this.ListOfSubjects = new List<Subject>();
            this.ListOfGrades = new List<int>();
        }
        
    }
}
