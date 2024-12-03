using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercise_21
{
    public class Rectangle:Shape
    {
        public double Length{
            get; set;
        }
        public double Width{
            get; set;
        }

        public Rectangle(double length, double width){
            Length = length;
            Width = width;
        }

        public override double getArea(){
            return Length * Width;
        }

        public override double getPerimeter(){
            return (Length + Width)*2;
        }
    }
}