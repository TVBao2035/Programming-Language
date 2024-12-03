using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercise_32
{
    public class Triangle:Geometry
    {
        private int _a, _b, _c;

        public Triangle(int a, int b, int c){
            _a = a; 
            _b = b;
            _c = c;
        }

        public Triangle(){}

        public override double Perimeter(){
            return _a + _b + _c;
        }

        public override double Area(){
            double p = (_a + _b + _c)/2.0;
            return Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c));
        }

    }
}