using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercise_30
{
    public class Student:Subject
    {
        public string Name{
            get; set;
        }

        public string Id{
            get; set;
        }

        public List<Subject> ArraySubjects{
            get; set;
        }

        public Student(string id, string name, List<Subject> array){
            Id = id;
            Name = name;
            ArraySubjects = array;
        }

        public double AveragePoint(){
            double result = 0;

            foreach(Subject e in ArraySubjects) result += e.Point;
            
            return result / ArraySubjects.Count;
        }

        public long getSumMoney(){
            long sum = 0;
            
            foreach(Subject e in ArraySubjects) sum += e.Money * e.NumberCredit;

            return sum;
        }

        public void display(){
            Console.WriteLine("Id: " + Id);
            Console.WriteLine("Name Student: " + Name);
            foreach(Subject e in ArraySubjects) e.display();

            Console.WriteLine("Sum Money Have to Pay: " + getSumMoney());
            Console.WriteLine("Average: " + AveragePoint());
        }

    }
}