using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Academy
    {
        public string Name { get; set; }
        public List<Admin> Admins { get; set; }
        public List<Trainer> Trainers { get; set; }
        public List<Student> Students { get; set; }
        public Admin currentAdmin { get; set; }
        public Student currentStudent { get; set; }


        public Academy()
        {
            this.Admins = new List<Admin>();
            this.Trainers = new List<Trainer>();
            this.Students = new List<Student>();
        }
        public Academy(string name) : this()
        {
            this.Name = name;
        }

        public void Start()
        {
            Console.WriteLine("Enter your first name:");
            string userFirstName = Console.ReadLine().Trim();
            Console.WriteLine("Enter your last name:");
            string userLastName = Console.ReadLine().Trim();
            Console.WriteLine($"{userFirstName} {userLastName}, choose your role in the academy: ");

            Console.WriteLine("Press 1 for Admin");
            Console.WriteLine("Press 2 for Trainer");
            Console.WriteLine("Press 3 for Student");
            try
            {
                int userRole = int.Parse(Console.ReadLine());
                if ((userRole == 1) || (userRole == 2) || (userRole == 3))
                {
                    Console.WriteLine("-----------------------------------------");
                }
                else
                {
                    throw new FormatException("You have entered a number different than 1, 2 or 3!");
                }


                switch (userRole)
                {
                    //ADMIN CASE OPTIONS------------------------------
                    case 1:
                        for (int i = 0; i < this.Admins.Count; i++)
                        {
                            Admin userAdm = new Admin(userFirstName, userLastName);
                            Admin ad;
                            ad = this.Admins[i];

                            if ((ad.FirstName == userAdm.FirstName) && (ad.LastName == userAdm.LastName))
                            {
                                Console.WriteLine("You are one of the admins in the academy!");
                                this.currentAdmin = this.Admins[i];
                                break;
                            }
                            else if ((ad.FirstName != userAdm.FirstName) && (ad.LastName != userAdm.LastName))
                            {
                                Admin newAdm = new Admin(userFirstName, userLastName);
                                this.Admins.Add(newAdm);
                                this.currentAdmin = newAdm;
                                Console.WriteLine("You are added as a new admin in the academy!");
                                break;
                            }
                        }

                        Console.WriteLine($"Welcome admin, {userFirstName} {userLastName}!");
                        Console.WriteLine("-----------------------------------------");

                        ChooseAdminOptions(userFirstName, userLastName);
                        Console.WriteLine("-----------------------------------------");
                        break;

                    //TRAINER CASE OPTIONS--------------------------------------
                    case 2:
                        for (int i = 0; i < this.Trainers.Count; i++)
                        {
                            Trainer userTr = new Trainer(userFirstName, userLastName);
                            Trainer tr;
                            tr = this.Trainers[i];

                            if ((tr.FirstName == userTr.FirstName) && (tr.LastName == userTr.LastName))
                            {
                                Console.WriteLine("You are one of the trainers in the academy!");
                                break;
                            }
                            else if ((tr.FirstName != userTr.FirstName) && (tr.LastName != userTr.LastName))
                            {
                                Trainer newTr = new Trainer(userFirstName, userLastName);
                                this.Trainers.Add(newTr);
                                Console.WriteLine("You are added as a new trainer in the academy!");
                                break;
                            }
                        }
                        Console.WriteLine($"Welcome trainer, {userFirstName} {userLastName}!");
                        Console.WriteLine("-----------------------------------------");

                        ChooseTrainerOptions();
                        Console.WriteLine("-----------------------------------------");
                        break;

                    // STUDENT CASE OPTIONS-----------------------------------
                    case 3:
                        for (int i = 0; i < this.Students.Count; i++)
                        {
                            Student userSt = new Student(userFirstName, userLastName);
                            Student st;
                            st = this.Students[i];

                            if ((st.FirstName == userSt.FirstName) && (st.LastName == userSt.LastName))
                            {
                                Console.WriteLine("You are one of the students in the academy!");
                                this.currentStudent = st;
                                break;
                            }
                            else if ((st.FirstName != userSt.FirstName) && (st.LastName != userSt.LastName))
                            {
                                Student newSt = new Student(userFirstName, userLastName);
                                this.Students.Add(newSt);
                                this.currentStudent = newSt;
                                Console.WriteLine("You are added as a new student in the academy! No subjects added yet!");
                                break;
                            }
                        }
                        Console.WriteLine($"Welcome student, {userFirstName} {userLastName}!");
                        Console.WriteLine("-----------------------------------------");

                        ChooseStudentOptions(this.currentStudent);
                        Console.WriteLine("-----------------------------------------");
                        break;

                    //DEFAULT OPTION - NO SUCH ROLE ----------------------------
                    default:
                        Console.WriteLine("No such role in the academy!");
                        break;
                }
            }
            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        #region Functions

        public void ChooseAdminOptions(string usFN, string usLN)
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("Press 1 to add an admin");
            Console.WriteLine("Press 2 to remove an admin");
            Console.WriteLine("Press 3 to add a trainer");
            Console.WriteLine("Press 4 to remove a trainer");
            Console.WriteLine("Press 5 to add a student");
            Console.WriteLine("Press 6 to remove a student");

            try
            {
                int adminResponse = int.Parse(Console.ReadLine());
                if ((adminResponse > 0) || (adminResponse < 7))
                {
                    Console.WriteLine("\n");
                }
                else
                {
                    throw new FormatException("You did not enter a number from 1 to 6!");
                }

                switch (adminResponse)
                {
                    case 1:
                        Console.WriteLine("You have chosen to add admin!");
                        Console.WriteLine("Enter admin's first name");
                        string adInpFirst01 = Console.ReadLine().Trim();
                        Console.WriteLine("Enter admin's last name");
                        string adInpLast01 = Console.ReadLine().Trim();
                        Admin userAdm01 = new Admin(adInpFirst01, adInpLast01);
                        userAdm01.AddAdmin(this.Admins, adInpFirst01, adInpLast01);
                        break;
                    case 2:
                        Console.WriteLine("You have chosen to remove an admin!");
                        Console.WriteLine("Enter admin's first name");
                        string adInpFirst02 = Console.ReadLine().Trim();
                        Console.WriteLine("Enter admin's last name");
                        string adInpLast02 = Console.ReadLine().Trim();
                        Admin userAdm02 = new Admin(adInpFirst02, adInpLast02);
                        if ((adInpFirst02 == usFN) && (adInpLast02 == usLN))
                        {
                            Console.WriteLine("You cannot remove yourself from admin list!");
                        }
                        else
                        {
                            userAdm02.RemoveAdmin(this.Admins, userAdm02);
                            Console.WriteLine("Admin removed!");
                        }
                        break;
                    case 3:
                        Console.WriteLine("You have chosen to add a trainer!");
                        Console.WriteLine("Enter trainer's first name");
                        string trInpFirst01 = Console.ReadLine().Trim();
                        Console.WriteLine("Enter trainer's last name");
                        string trInpLast01 = Console.ReadLine().Trim();
                        Trainer userTr01 = new Trainer(trInpFirst01, trInpLast01);
                        this.currentAdmin.AddTrainer(this.Trainers, trInpFirst01, trInpLast01);
                        break;
                    case 4:
                        Console.WriteLine("You have chosen to remove a trainer!");
                        Console.WriteLine("Enter trainer's first name");
                        string trInpFirst02 = Console.ReadLine().Trim();
                        Console.WriteLine("Enter trainer's last name");
                        string trInpLast02 = Console.ReadLine().Trim();
                        Trainer userTr02 = new Trainer(trInpFirst02, trInpLast02);
                        this.currentAdmin.RemoveTrainer(this.Trainers, userTr02);
                        foreach (var item in this.Trainers)
                        {
                            Console.WriteLine($"{item.GetFullName()}");
                        }
                        break;
                    case 5:
                        Console.WriteLine("You have chosen to add a student!");
                        Console.WriteLine("Enter student's first name");
                        string stInpFirst01 = Console.ReadLine().Trim();
                        Console.WriteLine("Enter student's last name");
                        string stInpLast01 = Console.ReadLine().Trim();
                        Student userSt01 = new Student(stInpFirst01, stInpLast01);
                        this.currentAdmin.AddStudent(this.Students, stInpFirst01, stInpLast01);
                        break;
                    case 6:
                        Console.WriteLine("You have chosen to remove a trainer!");
                        Console.WriteLine("Enter student's first name");
                        string stInpFirst02 = Console.ReadLine().Trim();
                        Console.WriteLine("Enter student's last name");
                        string stInpLast02 = Console.ReadLine().Trim();
                        Student userSt02 = new Student(stInpFirst02, stInpLast02);
                        this.currentAdmin.RemoveStudent(this.Students, userSt02);
                        break;
                    default:
                        Console.WriteLine("No such choice offered!");
                        break;
                }
            }
            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }

        public void ChooseTrainerOptions()
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("Press 1 to see students");
            Console.WriteLine("Press 2 to see subjects");
            Console.WriteLine("\n");
            try
            {
                int adminResponse = int.Parse(Console.ReadLine());
                if ((adminResponse != 1) || (adminResponse != 2))
                {
                    Console.WriteLine();
                }
                else
                {
                    throw new FormatException("Number is not 1 or 2!");
                }
                switch (adminResponse)
                {
                    case 1:
                        foreach (Student item in this.Students)
                        {
                            Console.WriteLine($"{item.FirstName}");
                        }
                        Console.WriteLine("---------------------------");
                        Console.WriteLine("Choose a name to see student's subjects");
                        string userInpName = Console.ReadLine().Trim();
                        Console.WriteLine("---------------------------------");
                        foreach (var student in this.Students)
                        {
                            if (student.FirstName == userInpName)
                            {
                                foreach (var subject in student.ListOfSubjects)
                                {
                                    Console.WriteLine($"{subject.Name}");
                                }
                                break;
                            }
                            else if (student.FirstName != userInpName)
                            {
                                Console.WriteLine("No such student in academy!");
                                break;
                            }
                        }
                        break;

                    case 2:
                        int htmlCount = 0;
                        int jsbCount = 0;
                        int jsaCount = 0;
                        int csbCount = 0;
                        int csaCount = 0;
                        int sqlCount = 0;
                        foreach (Student st in this.Students)
                        {
                            foreach (Subject sub in st.ListOfSubjects)
                            {
                                if (sub.Name == "HTML/CSS")
                                {
                                    htmlCount++;
                                    continue;
                                }
                                else if (sub.Name == "JavaScript Basic")
                                {
                                    jsbCount++;
                                    continue;
                                }
                                else if (sub.Name == "JavaScript Advanced")
                                {
                                    jsaCount++;
                                    continue;
                                }
                                else if (sub.Name == "C# Basic")
                                {
                                    csbCount++;
                                    continue;
                                }
                                else if (sub.Name == "C# Advanced")
                                {
                                    csaCount++;
                                    continue;
                                }
                                else if (sub.Name == "SQL")
                                {
                                    sqlCount++;
                                    continue;
                                }
                            }
                        }
                        Console.WriteLine($"HTML/CSS - are listening {htmlCount} students.");
                        Console.WriteLine($"JavaScript - Basic are listening {jsbCount} students.");
                        Console.WriteLine($"JavaScript - Advanced are listening {jsaCount} students.");
                        Console.WriteLine($"C# Basic - are listening {csbCount} students.");
                        Console.WriteLine($"C# Advanced - are listening {csaCount} students.");
                        Console.WriteLine($"SQL - are listening {sqlCount} students.");
                        Console.WriteLine("---------------------------------------");
                        break;
                }
            }
            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            

        }

        public void ChooseStudentOptions(Student st)
        {
            for (int i = 0; i < st.ListOfSubjects.Count; i++)
            {
                string eachSubject = st.ListOfSubjects[i].Name;
                int eachGrade = st.ListOfGrades[i];
                Console.WriteLine($"Subject: {eachSubject} - Grade: {eachGrade}");
            }
        }

        #endregion
    }
}
        
     

