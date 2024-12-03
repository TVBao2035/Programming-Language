using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercise_3;

    public class Student
    {
        private string name, gender;
        private int age;
        private double gpa;

        public Student(string name, int age, string gender, double gpa){
            this.name = name;
            this.age = age;
            this.gender = gender;
            this.gpa = gpa;
        }

        public void display()
        {
            Console.WriteLine("Name: " + this.name);
            Console.WriteLine("Age: " + this.age);
            Console.WriteLine("Gender: " + this.gender);
            Console.WriteLine("GPA: " + this.gpa);
        }
    }
