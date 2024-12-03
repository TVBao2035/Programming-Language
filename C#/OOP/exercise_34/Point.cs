using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercise_34
{
    public class Point
    {
        public int X{
            get; set;
        }

        public int Y{
            get; set;
        }

        public Point(){}
        public Point(int ix, int iy){
            X = ix;
            Y = iy;
        }
         
        public static Point operator - (Point A, Point B)
        {
            Point re = new Point((A.X - B.X), (A.Y - B.Y));
            return re;
        }
        public double distance(Point A){
            return Math.Sqrt(Math.Pow(X - A.X, 2) + Math.Pow(Y - A.Y, 2));
        }
    }
}