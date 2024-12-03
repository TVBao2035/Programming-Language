using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciseOOP
{
    public class Point
    {
        public double X{
            get; set;
        }

        public double Y{
            get; set;
        }

        public void enterCoordinate(){
            Console.Write("- Enter X coordinate: ");
            X = double.Parse(Console.ReadLine());
            Console.Write("- Enter Y coordinate: ");
            Y = double.Parse(Console.ReadLine());
        }

        public void display(){
            Console.WriteLine(X + " : " + Y);
        }
    }
}