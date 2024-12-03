using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercise_35
{
    public class Food
    {
        public string Name{
            get; set;
        }
        public double Price{
            get; set;
        }

        public Food(){}
        public Food(string name, double price){
            Name = name;
            Price = price;
        }

        public virtual void display(){
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Price: " + Price);
        }
    }
}