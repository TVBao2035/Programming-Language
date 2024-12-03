using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercise_21
{
    public class Circle:Shape
    {
        public double Radius{
            get; set;
        }
        public Circle(double radius){
            Radius = radius;
        }
        public override double getArea(){
            return Radius * Radius * 3.14;
        }

        public override double getPerimeter(){
            return 2*Radius*3.14;
        }
    }
}