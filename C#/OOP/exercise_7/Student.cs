using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercise_7
{
    public class Student
    {
        private string name;
        private char gender;

        public Student(){
            this.name = "Unknown";
            this.gender = 'u';
        }

        public Student(string name){
            this.name = name;
        }

        public Student(char gender){
            this.gender = gender;
        }

        public Student(string name, char gender){
            this.name = name;
            this.gender = gender;
        }

        public void display(){
            Console.WriteLine("Name: " + this.name);
            Console.Write("Gender: ");
            if(this.gender == 'f'){
                Console.WriteLine("Female");
            }else if(this.gender == 'm'){
                Console.WriteLine("Male");
            }else{
                Console.WriteLine("Unknown");
            }
        }
    }
}