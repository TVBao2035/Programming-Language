using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercise_17
{
    public class Person
    {
        public string Name{
            get; set;
        }

        public int Age{
            get; set;
        }

        public string Address{
            get; set;
        }

        public Person(){}

         public Person(string name, int age, string address){
            Name = name;
            Age = age;
            Address = address;
        }
        
        public void display(){
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Address: " + Address);
        }
    }
}