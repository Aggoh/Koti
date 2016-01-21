using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT6
{
    class Movies : Book
    {
        public string Genre { get; set; }
        public string Lenght { get; set; }
        
        public Movies()
        {

        }
        public Movies(string firstName, string lastName, string genre, string lenght) : base(firstName, lastName)
        {
            Genre = genre;
            Lenght = lenght;
        }
        public void MoviesMethod()
        {
            Console.WriteLine(" - Movie - ");
        }
        public override string ToString()
        {
            return base.ToString() + "\nDuration : " + Lenght + "\nGenre : " + Genre;
        }
    }
}
