using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciseOOP
{
    public class Straight
    {
        public Point firstPoint{
            get; set;
        }

        public Point secondPoint{
            get; set;
        }
        
        public Straight(){

        }

        public Straight(Point first, Point second){
            firstPoint = first;
            secondPoint = second;
        }
        public void enterPoint(){
            firstPoint = new Point();
            secondPoint = new Point();
            Console.WriteLine("Enter the first Point: ");
            firstPoint.enterCoordinate();
            Console.WriteLine("Enter the second Point: ");
            secondPoint.enterCoordinate();
        }

        public double distance(){
            return Math.Sqrt(Math.Pow(secondPoint.X - firstPoint.X, 2) + Math.Pow(secondPoint.Y - firstPoint.Y, 2));
        }
    }
}