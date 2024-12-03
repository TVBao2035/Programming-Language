using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercise_11
{
    public class Employee
    {
        public int Id{
            get; set;
        }

        public string FirstName{
            get; set;
        }

        public string LastName{
            get; set;
        }

        public int Salary{
            get; set;
        }

        public Employee(int id, string firstName, string lastName, int salary){
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
        }

        public string getFullName(){
            return LastName + " " + FirstName;
        }

        public void display(){
            Console.WriteLine("Id: " + Id);
            Console.WriteLine("Full Name: " + getFullName());
            Console.WriteLine("Salary: " + Salary);
        }
    }
}