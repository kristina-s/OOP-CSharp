using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Class08_class_exercises
{
    class Program
    {
        static void PrintCollection(List<Song> collection, string name)
        {
            Console.WriteLine($"Elements from collection: {name}");
            foreach (var o in collection)
            {
                Console.Write($"{o.Title}, ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            //exercise 02 - create new person and add and print songs
            Person person1 = new Person(01, "Kristina", "Spasevska", 31, Genre.Rock);
            person1.FavoriteSongs.Add(new Song("The Hip_Hop Song", 8, Genre.Hip_hop));
            person1.FavoriteSongs.Add(new Song("The Rock Song", 3, Genre.Rock));
            person1.FavoriteSongs.Add(new Song("The Techno Song", 12, Genre.Techno));
            person1.FavoriteSongs.Add(new Song("The Classical Song", 32, Genre.Classical));
            person1.GetFavSongs();
            Console.WriteLine("--------------------------");
            //exercise 03 - lynq exercises with more persons and songs
            Person jerry = new Person(02, "Jerry", "Berry", 22, Genre.Rock);
            jerry.FavoriteSongs.Add(new Song("Beginning", 8, Genre.Hip_hop));
            jerry.FavoriteSongs.Add(new Song("Behind blue eyes", 3, Genre.Rock));
            jerry.FavoriteSongs.Add(new Song("Where are we?", 3, Genre.Techno));
            jerry.GetFavSongs();
            List<Song> startWithB = jerry.FavoriteSongs
                .Where(x => x.Title.StartsWith("B"))
                .ToList();
            PrintCollection(startWithB, "Songs that start with B:");
            Console.WriteLine("--------------------------");

            Person maria = new Person(03, "Maria", "Gomez", 40, Genre.Classical);
            maria.FavoriteSongs.Add(new Song("Shubert's symphony", 13, Genre.Classical));
            maria.FavoriteSongs.Add(new Song("Up the beat", 3, Genre.Hip_hop));
            maria.FavoriteSongs.Add(new Song("Listz's piano overtures", 24, Genre.Classical));
            maria.GetFavSongs();
            List<Song> longerThan6 = maria.FavoriteSongs
                .Where(x => x.Length > 6)
                .ToList();
            PrintCollection(longerThan6, "Songs longer than 6 minutes:");
            Console.WriteLine("--------------------------");

            Person jane = new Person(04, "Jane", "Dawson", 28, Genre.Rock);
            jane.FavoriteSongs.Add(new Song("All is all", 7, Genre.Rock));
            jane.FavoriteSongs.Add(new Song("Long lost", 20, Genre.Classical));
            jane.FavoriteSongs.Add(new Song("Behind blue eyes", 3, Genre.Rock));
            jane.FavoriteSongs.Add(new Song("Listz's piano overtures", 24, Genre.Classical));
            jane.FavoriteSongs.Add(new Song("Time is future", 5, Genre.Rock));
            jane.FavoriteSongs.Add(new Song("Love's the answer", 9, Genre.Rock));
            jane.GetFavSongs();
            List<Song> rockSongs = jane.FavoriteSongs
                .Where(x => x.Type == Genre.Rock)
                .ToList();
            PrintCollection(rockSongs, "Rock songs:");
            Console.WriteLine("--------------------------");

            Person stefan = new Person(05, "Stefan", "Petrov", 34, Genre.Rock);
            stefan.FavoriteSongs.Add(new Song("Up the beat", 2, Genre.Hip_hop));
            stefan.FavoriteSongs.Add(new Song("All is all", 7, Genre.Rock));
            stefan.FavoriteSongs.Add(new Song("Beginning", 5, Genre.Hip_hop));
            stefan.FavoriteSongs.Add(new Song("Where are we?", 2, Genre.Hip_hop));
            stefan.GetFavSongs();
            List<Song> shorterThan3Hiphop = stefan.FavoriteSongs
                .Where(x => x.Length < 3)
                .Where(x => x.Type == Genre.Hip_hop)
                .ToList();
            PrintCollection(shorterThan3Hiphop, "Song shorter than 3 and hip hop genre: ");
            Console.WriteLine("--------------------------");

            Person[] persons = new Person[4] { jerry, maria, jane, stefan };
            List<Person> persons02 = persons
                .Where(x => x.FavoriteSongs.Count >= 4)
                .ToList();
            Console.WriteLine("The following people have 4 or more songs: ");
            foreach (var person in persons02)
            {
                Console.Write($"{person.FirstName}, ");
            }
            Console.WriteLine();
                                 

            Console.ReadLine();
        }
    }
}
