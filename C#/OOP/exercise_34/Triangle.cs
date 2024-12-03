using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercise_34
{
    public class Triangle:Point
    {
        public Point A{
            get; set;
        }

        public Point B{
            get; set;
        }

        public Point C{
            get; set;
        }

        public Triangle(){}
        public Triangle(Point ai, Point bi, Point ci){
            A = ai;
            B = bi;
            C = ci;
        }

        public double perimeter(){
            return A.distance(B) + B.distance(C) + C.distance(A);
        }

        public double area(){
            return Math.Abs((A.X - B.X) * (A.Y - B.Y) * (A.X - C.X) * (A.Y - C.Y))*0.5;
        }

        public Point center(){
            Point re = new Point(((A.X + B.X + C.X)/3), ((A.Y + B.Y + C.Y)/3));
            return re;
        }

        public bool isTriangle(){
            double distance_1 = A.distance(B);
            double distance_2 = A.distance(C);
            double distance_3 = B.distance(C);

            if(distance_1 + distance_2 > distance_3 && distance_1 + distance_3 > distance_2 && distance_2 + distance_3 > distance_1 && distance_1 > 0 && distance_2 > 0 && distance_3 > 0){
                return true;
            }
            return false;
        }
    }
}