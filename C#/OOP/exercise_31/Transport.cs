using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercise_31
{
    public class Transport
    {
        public string Manufacturer{
            get; set;
        }

        public string Name{
            get; set;
        }

        public int Speed{
            get; set;
        }

        public int Year{
            get; set;
        }


        public Transport(){}

        public Transport(string manufacturer, string name, int year, int speed){
            Manufacturer = manufacturer;
            Name = name;
            Year = year;
            Speed = speed;
        }

        public void display(){
            Console.WriteLine("Manufacturer: " + Manufacturer);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Year: " + Year);
            Console.WriteLine("Speed: " + Speed);
        }
    }
}