using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercise_23
{
    public class Line:Point
    {
        public Point Begin{
            get; set;
        }

        public Point End{
            get; set;
        }
        public Line(Point begin, Point end){
            Begin = begin;
            End = end;
        }

        public Line( int x1, int y1, int x2, int y2){
            Begin.X = x1;
            Begin.Y = y1;
            End.X = x2;
            End.Y = y2;
        }
        public double getLength(){
            return Math.Sqrt(Math.Pow((End.X - Begin.X), 2) + Math.Pow((End.Y - Begin.Y) , 2));
        }
    }
}