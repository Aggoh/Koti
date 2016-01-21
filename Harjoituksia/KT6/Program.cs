using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT6
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            book.BookMethod();
            book.Name = "Turms Kuolematon";
            book.Editor = "Mika Waltari";
            book.Author = "Werner Söderström";
            book.Age = 1955;
            Console.WriteLine(book.ToString());

            Games games = new Games();
            games.GamesMethod();
            games.Name = "Metal Gear Solid V, Phantom Pain";
            games.Editor = "Konami";
            games.Author = "Hideo Kojima";
            games.Age = 2015;
            games.Platform = "Playstation 4";
            Console.WriteLine(games.ToString());

            Movies movies = new Movies();
            movies.MoviesMethod();
            movies.Name = "Aristovcats";
            movies.Editor = "Walt Disney";
            movies.Lenght = "76 minutes";
            movies.Age = 1970;
            movies.Genre = "Animation";
            Console.WriteLine(movies.ToString());
        }
    }
}
