using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercise_14
{
    public class Point
    {
        public double X{
            get; set;
        }

        public double Y{
            get; set;
        }

        public Point(){}

        public Point(double x, double y){
            X = x;
            Y = y;
        }

        public double distance(double x, double y){
            return Math.Sqrt((X * x) + (Y * y));
        }

        public double distance(Point another){
            return distance(another.X, another.Y);
        }
    }
}