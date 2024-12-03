using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercise_17
{
    public class Student:Person
    {
        public double Gpa{
            get; set;
        }

        public Student(string name, int age, string address, double gpa):base(name, age, address){
            Gpa = gpa;
        }

        public void display(){
            base.display();
            Console.WriteLine("GPA: " + Gpa);
        }
    }
}