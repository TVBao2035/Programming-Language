using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercise_30
{
    public class Subject
    {
        public string NameSubject{
            get; set;
        }

        public double Point{
            get; set;
        }

        public int NumberCredit{
            get; set;
        }

        public long Money{
            get; set;
        }

        public Subject(){}
        public Subject(string nameSubject, double point, int numberCredit, long money){
            NameSubject = nameSubject;
            Point = point;
            NumberCredit = numberCredit;
            Money = money;
        }

        public void display()
        {
            Console.WriteLine("Name Subject: " + NameSubject);
            Console.WriteLine("Point: " + Point);
            Console.WriteLine("Number Credit: " + NumberCredit);
            Console.WriteLine("Money Of One Credit: " + Money);
        }
    }
}