using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciseOOP
{
    public class Cycle
    {
        public Point centerPoint{
            get; set;
        }

        public double Radius{
            get; set;
        }

        public void enterCycleData(){
            Console.WriteLine("Enter Center Point: ");
            centerPoint = new Point();
            centerPoint.enterCoordinate();
            Console.Write("Enter Radius: ");
            Radius = double.Parse(Console.ReadLine());
        }

        public double cyclePerimeter(){
            return 3.14 * Math.Pow(Radius, 2);
        }

    }
}