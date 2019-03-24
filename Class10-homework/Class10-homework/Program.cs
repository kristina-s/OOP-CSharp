using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes;

namespace Class10_homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Academy webDev = new Academy("Web Development");

            #region Create admins, trainers and students
           
            webDev.Admins.Add(new Admin("Orce", "Petreski"));
            webDev.Admins.Add(new Admin("Dejan", "Zdravkovski"));
            webDev.Admins.Add(new Admin("Vesna", "Ivanovska"));
                       
            webDev.Trainers.Add(new Trainer("Dragan", "Gelevski"));
            webDev.Trainers.Add(new Trainer("Jane", "Dimeski"));
            webDev.Trainers.Add(new Trainer("Wekoslav", "Stefanovski"));
            webDev.Trainers.Add(new Trainer("Risto", "Panchevski"));

            Subject s1 = new Subject("HTML/CSS");
            Subject s2 = new Subject("JavaScript Basic");
            Subject s3 = new Subject("JavaScript Advanced");
            Subject s4 = new Subject("C# Basic");
            Subject s5 = new Subject("C# Advanced");
            Subject s6 = new Subject("SQL");
            Student st01 = new Student("Kristina", "Spasevska");
            st01.ListOfSubjects.Add(s1);
            st01.ListOfSubjects.Add(s3);
            st01.ListOfSubjects.Add(s4);
            st01.ListOfGrades.Add(9);
            st01.ListOfGrades.Add(10);
            st01.ListOfGrades.Add(8);          
            Student st02 = new Student("Valentina", "Palkovska");
            st02.ListOfSubjects.Add(s2);
            st02.ListOfSubjects.Add(s1);
            st02.ListOfSubjects.Add(s6);
            st02.ListOfGrades.Add(8);
            st02.ListOfGrades.Add(10);
            st02.ListOfGrades.Add(7);
            Student st03 = new Student("Tose", "Todorovski");
            st03.ListOfSubjects.Add(s3);
            st03.ListOfSubjects.Add(s4);
            st03.ListOfSubjects.Add(s5);
            st03.ListOfGrades.Add(10);
            st03.ListOfGrades.Add(9);
            st03.ListOfGrades.Add(8);
            Student st04 = new Student("Todor", "Janevski");
            st04.ListOfSubjects.Add(s2);
            st04.ListOfSubjects.Add(s1);
            st04.ListOfSubjects.Add(s3);
            st04.ListOfGrades.Add(6);
            st04.ListOfGrades.Add(7);
            st04.ListOfGrades.Add(8);
            Student st05 = new Student("Natasha", "Andova");
            st05.ListOfSubjects.Add(s3);
            st05.ListOfSubjects.Add(s6);
            st05.ListOfSubjects.Add(s4);
            st05.ListOfGrades.Add(8);
            st05.ListOfGrades.Add(6);
            st05.ListOfGrades.Add(7);
            Student st06 = new Student("Gjorgji", "Kungulovski");
            st06.ListOfSubjects.Add(s4);
            st06.ListOfSubjects.Add(s6);
            st06.ListOfSubjects.Add(s5);
            st06.ListOfGrades.Add(10);
            st06.ListOfGrades.Add(10);
            st06.ListOfGrades.Add(8);
            Student st07 = new Student("Kristijan", "Kitevski");
            st07.ListOfSubjects.Add(s2);
            st07.ListOfSubjects.Add(s6);
            st07.ListOfSubjects.Add(s4);
            st07.ListOfGrades.Add(9);
            st07.ListOfGrades.Add(9);
            st07.ListOfGrades.Add(10);
            Student st08 = new Student("Jane", "Kostov");
            st08.ListOfSubjects.Add(s6);
            st08.ListOfSubjects.Add(s1);
            st08.ListOfSubjects.Add(s4);
            st08.ListOfGrades.Add(9);
            st08.ListOfGrades.Add(8);
            st08.ListOfGrades.Add(10);
            Student st09 = new Student("Nikola", "Tabakoski");
            st09.ListOfSubjects.Add(s6);
            st09.ListOfSubjects.Add(s2);
            st09.ListOfSubjects.Add(s1);
            st09.ListOfGrades.Add(7);
            st09.ListOfGrades.Add(9);
            st09.ListOfGrades.Add(10);
            Student st10 = new Student("Riste", "Arsov");
            st10.ListOfSubjects.Add(s2);
            st10.ListOfSubjects.Add(s1);
            st10.ListOfSubjects.Add(s5);
            st10.ListOfGrades.Add(10);
            st10.ListOfGrades.Add(8);
            st10.ListOfGrades.Add(7);

            webDev.Students.Add(st01);           
            webDev.Students.Add(st02);
            webDev.Students.Add(st03);
            webDev.Students.Add(st04);
            webDev.Students.Add(st05);
            webDev.Students.Add(st06);
            webDev.Students.Add(st07);
            webDev.Students.Add(st08);
            webDev.Students.Add(st09);
            webDev.Students.Add(st10);
            //foreach (var item in webDev.Students)
            //{
            //    foreach (var grade in item.ListOfGrades)
            //    {
            //        Console.Write($"{grade} ");
            //    }
            //    Console.WriteLine("\n");

            //}
            #endregion

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("-----------------------Web Academy------------------------");
            Console.WriteLine("This is an application for admins, trainers and students of the Web Academy.");
            Console.WriteLine("Follow the instructions after each step to use this app!");
            Console.WriteLine("-----------------------------------------------------------");
            Console.ResetColor();

            webDev.Start();

            Console.ReadKey();
        }
    }
}
