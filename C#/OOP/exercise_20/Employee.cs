using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercise_20
{
    public class Employee:Person
    {
        public int Salary{
            get; set;
        }
        public Employee(string name, string address, int salary):base(name, address){
            Salary = salary;
        }
        public override void display(){
            Console.WriteLine("Employee name: " + Name);
            Console.WriteLine("Employee address: " + Address);
            Console.WriteLine("Employee salary: " + Salary);
        }
    }
}