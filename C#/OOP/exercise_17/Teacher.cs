using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercise_17
{
    public class Teacher:Person
    {
        public int Salary{
            get; set;
        }

        public Teacher(string name, int age, string address, int salary):base(name, age, address){
            Salary = salary;
        }

        public void display(){
            base.display();
            Console.WriteLine("Salary: " + Salary);
        }
    }
}