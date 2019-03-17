using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class08_class_exercises
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public byte Age { get; set; }
        public Genre FavoriteMusicType { get; set; }
        public List<Song> FavoriteSongs { get; set; }

        public Person(int id, string firstName, string lastName, byte age, Genre FavoriteMusicType)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.FavoriteMusicType = FavoriteMusicType;
            FavoriteSongs = new List<Song>();
        }

        public void GetFavSongs()
        {
            if (FavoriteSongs.Count == 0)
            {
                Console.WriteLine("This person doesn't like music!");
            }
            else
            {
                foreach (var song in FavoriteSongs)
                {
                    song.GetSongInfo();
                }
            }
        }

    }
}
