using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercise_24
{
    public class Triangle
    {
        public Point Vert_1{
            get; set;
        }

        public Point Vert_2{
            get; set;
        }

        public Point Vert_3{
            get; set;
        }

        public Triangle(Point vert_1, Point vert_2, Point vert_3){
            Vert_1 = vert_1;
            Vert_2 = vert_2;
            Vert_3 = vert_3;
        }

        public Triangle(int x1, int y1, int x2, int y2, int x3, int y3){
            Vert_1 = new Point(x1, y1);
            Vert_2 = new Point(x2, y2);
            Vert_3 = new Point(x3, y3);
        }
        public double getLength(Point p1, Point p2){
            return Math.Sqrt(Math.Pow((p2.X - p1.X), 2) + Math.Pow((p2.Y - p1.Y), 2));
        }
        public double getPerimeter(){
            double result = getLength(Vert_1, Vert_2) + getLength(Vert_1, Vert_3) + getLength(Vert_2, Vert_3);
            return result;
        }
    }
}