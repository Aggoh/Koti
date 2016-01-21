using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT6
{
    class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public string Editor { get; set; }
        public int Age { get; set; }


        public Book()
        {
        }
        public Book (string firstName, string lastName)
        {
            Name = firstName;
            Editor = lastName;
        }
        public void BookMethod()
        {
            Console.WriteLine(" - Book - ");
        }
        public override string ToString()
        {
            return "Name: "  + Name + "\n" + "Producer: " + Author + "\n" +"Publisher: " + Editor + "\n" + "Date: "  + Age;
        }
    }
}

    
