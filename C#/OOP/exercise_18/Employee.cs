using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercise_18
{
    public class Employee
    {
        public string Name{
            get; set;
        }

        public int Salary{
            get; set;
        }

        public Employee(){}

        public Employee(string name, int salary){
            Name = name;
            Salary = salary;
        }

        public void display()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Salary: " + Salary);
        }
    }
}