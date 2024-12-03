using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercise_10
{
    public class Student
    {
        public string Name{
            get; set;
        }
        public int Id{
            get; set;
        }

        public int Age{
            get; set;
        }


        public string Address{
            get; set;
        }

        public int Score{
            get; set;
        }

        public Student(){}

        public Student(int id, string name, int age, string address, int score){
            Id = id;
            Name = name;
            Age = age;
            Address = address;
            Score = score;
        }

        public void display(){
            Console.WriteLine("Id: " + Id);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Address: " + Address);
            Console.WriteLine("Score: " + Score);
        }
    }
}