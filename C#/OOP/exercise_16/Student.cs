using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercise_16
{
    public class Student : Person
    {
        public double GPA{
            get; set;
        }

        public Student(string name, int dob, double gpa): base(name, dob){
            GPA = gpa;
        }

        public void display(){
            base.display();
            Console.WriteLine("GPA: " + GPA);
        }
    }
}