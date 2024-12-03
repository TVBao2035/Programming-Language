using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercise_33
{
    public class Person
    {
        public string Name{
            get; set;
        }

        public int Age{
            get; set;
        }

        public string Add{
            get; set;
        }

        public string Tel{
            get; set;
        }

        public string Sex{
            get; set;
        }

        public Person(){}
        public Person(string name, int age, string add, string tel, string sex){
            Name = name;
            Age = age;
            Add = add;
            Tel = tel;
            Sex = sex;
        }

        public virtual void display(){
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Address: " + Add);
            Console.WriteLine("Telephone: " + Tel);
            Console.WriteLine("Sex: "  + Sex);
        }
        public virtual long salary(){
            long result = 99;
            return result;
        }

        public static List<Person> findPerson( List<Person> p){
            List<Person> result = new List<Person>();
            foreach(Person e in p) if(e.Add == "HN")
                    result.Add(e);           
            return result;
        }
    }
}