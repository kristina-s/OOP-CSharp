using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Admin:Person
    {
        public Admin(string firstName, string lastName):base(firstName, lastName, Role.Admin)
        {
         
        }
        public void AddAdmin(List<Admin> list, string userFName, string userLName)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Admin ad;
                ad = list[i];
                if ((ad.FirstName == userFName) && (ad.LastName == userLName))
                {
                    Console.WriteLine("An admin with such name and last name already exists!");
                    break;
                }
                else if ((ad.FirstName != userFName) && (ad.LastName != userLName))
                {
                    list.Add(new Admin(userFName, userLName));
                    Console.WriteLine("New admin added!");
                    Console.WriteLine("\n");
                    break;
                }
            }
            foreach (var item in list)
            {
                Console.WriteLine(item.GetFullName());
            }
        }
        public void RemoveAdmin(List<Admin> list, Admin ad)
        {
            list.Remove(ad);
            Console.WriteLine("\n");
            foreach (var item in list)
            {
                Console.WriteLine(item.GetFullName());
            }
        }

        public void AddTrainer(List<Trainer> list, string userFName, string userLName)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Trainer tr;
                tr = list[i];
                if ((tr.FirstName == userFName) && (tr.LastName == userLName))
                {
                    Console.WriteLine("A trainer with such name and last name already exists!");
                    break;
                }
                else if ((tr.FirstName != userFName) && (tr.LastName != userLName))
                {
                    list.Add(new Trainer(userFName, userLName));
                    Console.WriteLine("New trainer added!");
                    Console.WriteLine("\n");
                    break;
                }
            }
            foreach (var item in list)
            {
                Console.WriteLine(item.GetFullName());
            }
        }
        public void RemoveTrainer(List<Trainer> list, Trainer tr)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if ((list[i].FirstName == tr.FirstName) && (list[i].LastName == tr.LastName))
                {
                    list.Remove(list[i]);
                    Console.WriteLine("Trainer removed!");
                    Console.WriteLine("\n");
                    break;
                }
            }
            foreach (var item in list)
            {
                Console.WriteLine(item.GetFullName());
            }
        }
        public void AddStudent(List<Student> list, string userFName, string userLName)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Student st;
                st = list[i];
                if ((st.FirstName == userFName) && (st.LastName == userLName))
                {
                    Console.WriteLine("A student with such name and last name already exists!");
                    break;
                }
                else if ((st.FirstName != userFName) && (st.LastName != userLName))
                {
                    list.Add(new Student(userFName, userLName));
                    Console.WriteLine("New student added!");
                    Console.WriteLine("\n");
                    break;
                }
            }
            foreach (var item in list)
            {
                Console.WriteLine(item.GetFullName());
            }
        }

        public void RemoveStudent(List<Student> list, Student st)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if ((list[i].FirstName == st.FirstName) && (list[i].LastName == st.LastName))
                {
                    list.Remove(list[i]);
                    Console.WriteLine("Student removed!");
                    Console.WriteLine("\n");
                    break;
                }
            }
            foreach (var item in list)
            {
                Console.WriteLine(item.GetFullName());
            }
        }
        //public void AddStudent(Student st)
        //{

        //}
    }
}
