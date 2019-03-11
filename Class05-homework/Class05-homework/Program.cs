using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class05_homework
{
    class Program
    {
        class Creature
        {
            public string Name;
            public int PowerLevel;
            public byte Age;
            public bool IsTamed;

            public Creature(string name, int powerLevel, byte age, bool isTamed)
            {
                this.Name = name;
                this.PowerLevel = powerLevel;
                this.Age = age;
                this.IsTamed = isTamed;
            }

        }

        class Wizard
        {
            public string Name;
            public int PowerLevel;
            public byte Age;
            public DateTime DateOfAdmission;
            public bool IsGraduated;

            public Wizard(string name, int powerLevel, byte age, DateTime dateOfAdmission, bool isGraduated)
            {
                this.Name = name;
                this.PowerLevel = powerLevel;
                this.Age = age;
                this.DateOfAdmission = dateOfAdmission;
                this.IsGraduated = isGraduated;
            }
            
        }

        
        static void Main(string[] args)
        {
            Wizard[] theWizards = new Wizard[]
            {
                new Wizard("Gandalf", 90, 200, new DateTime(1001, 1, 1), true),
                new Wizard("Warlock", 75, 33, new DateTime(1881, 1, 1), true),
                new Wizard("Eowin", 80, 102, new DateTime(101, 1, 1), false),
                new Wizard("Satyricon", 50, 50, new DateTime(161, 1, 1), true),
                new Wizard("Mardyk", 65, 133, new DateTime(651, 1, 1), false),
            };
            Creature[] theCreatures = new Creature[]
            {
                new Creature("Cerberus", 100, 105, false),
                new Creature("Hydra", 10, 15, false),
                new Creature("Sodoma", 70, 50, false),
                new Creature("Balrog", 30, 99, false),
                new Creature("Phlegeton", 42, 33, false),
            };

            Console.WriteLine("Meanwhile in Hogwarts there is an epic battle between the Wizards and the fearsome mythical Creatures..." +
                "The game lasts for many years and there has come a time to stop..." +
                "But can Wizards tame this wildebeasts?!? Or not...");
            Console.WriteLine("\n");
            Console.WriteLine("Let's see who wins the battle!");
            Console.WriteLine("\n");


            for (int i = 0; i < theWizards.Length; i++)
            {
                for (int j = 0; j < theCreatures.Length; j++)
                {
                    if (theWizards[i].PowerLevel > theCreatures[j].PowerLevel)
                    {
                        Console.WriteLine("The Wizard {0} has tamed the beast {1}", theWizards[i].Name, theCreatures[j].Name);
                        theCreatures[j].IsTamed = true;
                    }
                    else
                    {
                        Console.WriteLine("The Wizard {0} did not tame the beast {1}", theWizards[i].Name, theCreatures[j].Name);

                    }
                }
            }
            Console.WriteLine("\n");

            //check if there is a winner beast
            for (int i = 0; i < theCreatures.Length; i++)
            {
                if(theCreatures[i].IsTamed == false)
                {
                    Console.WriteLine("The beast {0} CANNOT be tamed by any wizard!", theCreatures[i].Name);
                }

            }
            Console.ReadLine();
        }
    }
}
