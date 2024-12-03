using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercise_16
{
    public class Person
    {
        public string Name{
            get; set;
        }

        public int Dob{
            get; set;
        }

        public Person(){}
        public Person(string name, int dob){
            Name = name;
            Dob = dob;
        }

        public void display(){
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Dob: " + Dob);
        }
    }
}