using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercise_8
{
    public class Person
    {
        private int id, age;
        private string name;

        public int Id{
            set{
                id = value;
            }

            get{
                return id;
            }
        }

        public int Age{
            get; set;
        }
        public string Name{
            get; set;
        }

        public string Address{
            get; set;
        }
        public void display(){
            Console.WriteLine("Id: " + Id);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Address: " + Address);
        }
    }
}