using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercise_37
{
    public class People
    {
        public string Id{
            get; set;
        }

        public string Name{
            get; set;
        }

        public string Job{
            get; set;
        }

        public int Age{
            get; set;
        }

        public People(){}

        public People(string name, int age, string job, string id){
            Id = id;
            Name = name;
            Job = job;
            Age = age;
        }

        public void display(){
            Console.WriteLine("Name: "  + Name);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Job: " + Job);
            Console.WriteLine("Id: " + Id);
        }
    }
}