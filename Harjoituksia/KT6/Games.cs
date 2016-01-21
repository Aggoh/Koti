using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT6
{
    class Games : Book
    {
       public string Platform { get; set; }


        public Games()
        {
            
        }
        public Games(string firstName, string lastName, string platform) : base(firstName, lastName)
        {
            Platform = platform;
        }
        public void GamesMethod()
        {
            Console.WriteLine(" - Game - ");
        }
        public override string ToString()
        {
            return base.ToString() + "\nPlatform: " +Platform;
        }
    }
}