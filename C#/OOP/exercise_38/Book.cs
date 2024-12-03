using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercise_38
{
    public class Book
    {
        public string NameBook{
            get; set;
        }

        public string NameAuthor{
            get; set;
        }

        public int NumberBook{
            get; set;
        }

        public Book(){}

        public Book(string nameBook, string nameAuthor, int numberBook)
        {
            NameBook = nameBook;
            NameAuthor = nameAuthor;
            NumberBook = numberBook;
        }

        public void display()
        {
            Console.WriteLine("Name Book: " + NameBook);
            Console.WriteLine("Name Author: " + NameAuthor);
            Console.WriteLine("Number Book: " + NumberBook);
        }

    }
}