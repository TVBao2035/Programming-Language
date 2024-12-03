using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercise_25
{
    public class Book
    {
        public string Name{
            get; set;
        }
        public double Price{
            get; set;
        }

        public Author[] Authors;
        public Book(string name, Author[] authors, double price){
            Name = name;
            Authors = authors;
            Price = price;
        }

        public string getAuthorNames(){
            string allNames = "";
            for(int i=0; i < Authors.Length - 1; i++){
                allNames += Authors[i].Name + ", ";
            }
            allNames += Authors[Authors.Length - 1].Name;
            return allNames;
        }
        
    }
}