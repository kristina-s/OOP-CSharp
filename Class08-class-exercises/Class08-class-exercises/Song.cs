using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class08_class_exercises
{
    public class Song
    {
        public string Title { get; set; }
        public int Length { get; set; }
        public Genre Type { get; set; }

        public Song(string title, int length, Genre Type)
        {
            this.Title = title;
            this.Length = length;
            this.Type = Type;
        }
        public void GetSongInfo()
        {
            Console.WriteLine($"Song title: {this.Title}, Song Length: {this.Length}, Song Genre: {this.Type}");
        }
    }
}
