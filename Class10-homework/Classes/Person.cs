using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Role PersonRole { get; set; }

        public Person()
        {

        }
        public Person(string firstName, string lastName, Role personRole)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.PersonRole = personRole;
        }
        public string GetFullName()
        {
            return $"{this.FirstName} {this.LastName}";
        }
    }
}
