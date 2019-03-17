using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Class08_homework
{
    class Program
    {
        public static void PrintListInfo(List<Student> collection, string name)
        {
            Console.WriteLine($"Printing list: {name}");
            foreach (var item in collection)
            {
                item.GetInfo();
            }
        }

        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("Kristina", "Spasevska", 31, Gender.female, 1, "G1", "HTML-CSS"));
            students.Add(new Student("Valentina", "Palkovska", 35, Gender.female, 2, "G2", "JSB"));
            students.Add(new Student("Tose", "Todorovski", 28, Gender.male, 3, "G3", "JSA"));
            students.Add(new Student("Andrijan", "Nikolovski", 20, Gender.male, 4, "G4", "CS"));
            students.Add(new Student("Natasha", "Andova", 36, Gender.female, 5, "G5", "CSA"));

            students.Add(new Student("Dejan", "Angelov", 25, Gender.male, 6, "G1", "HTML-CSS"));
            students.Add(new Student("Rolan", "Bajrami", 35, Gender.male, 7, "G2", "JSB"));
            students.Add(new Student("Monika", "Georgievska", 24, Gender.female, 8, "G3", "JSA"));
            students.Add(new Student("Jovan", "Jovanovski", 25, Gender.male, 9, "G4", "CSB"));
            students.Add(new Student("Goran", "Kuzmanovski", 27, Gender.male, 10, "G5", "CSA"));

            students.Add(new Student("Todor", "Janevski", 37, Gender.male, 11, "G1", "HTML-CSS"));
            students.Add(new Student("Dalibor", "Lebanov", 28, Gender.male, 12, "G2", "JSB"));
            students.Add(new Student("Viktorija", "Stefanovska", 39, Gender.female, 13, "G3", "JSA"));
            students.Add(new Student("Vladimir", "Jankovikj", 31, Gender.male, 14, "G4", "CSB"));
            students.Add(new Student("Kristina", "Pavlovska", 19, Gender.female, 15, "G5", "CSA"));

            students.Add(new Student("Marija", "Rumenovska", 23, Gender.female, 16, "G1", "HTML-CSS"));
            students.Add(new Student("Jane", "Kostov", 25, Gender.male, 17, "G2", "JSB"));
            students.Add(new Student("Riste", "Arsov", 38, Gender.male, 18, "G3", "JSA"));
            students.Add(new Student("Nikola", "Tabakovski", 32, Gender.male, 19, "G4", "CSB"));
            students.Add(new Student("Gjorgji", "Kungulovski", 32, Gender.male, 20, "G5", "CSA"));

            List<Student> female = students
                .Where(x => x.PersonGender == Gender.female)
                .ToList();
            PrintListInfo(female, "Female students");

            List<Student> male = students
                .Where(x => x.PersonGender == Gender.male)
                .ToList();
            PrintListInfo(male, "Male students");

            Console.WriteLine("Enter a letter:");
            string userLetter = Console.ReadLine().ToUpper();
            List<Student> firstLetter = students
                .Where(x => x.FirstName.StartsWith(userLetter))
                .ToList();
            PrintListInfo(firstLetter, $"Students that start with letter {userLetter}");

            Console.WriteLine("Enter a group:");
            string userGroup = Console.ReadLine();
            List<Student> chosenGroup = students
                .Where(x => x.Group == userGroup)
                .ToList();
            if (chosenGroup.Count == 0)
            {
                Console.WriteLine("No student in such group");
            }
            else
            {
                PrintListInfo(chosenGroup, $"Students in group = {userGroup}");
            }

            Console.WriteLine("Enter an ID:");
            int userId = int.Parse(Console.ReadLine());
            List<Student> chosenId = students
                .Where(x => x.Id == userId)
                .ToList();
            if(chosenId.Count == 0)
            {
                Console.WriteLine("No student with such Id");
            }
            else
            {
                PrintListInfo(chosenId, $"Students with Id = {userId}");
            }
            Console.ReadLine();
        }
    }
}
