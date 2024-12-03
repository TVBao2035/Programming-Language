using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercise_32
{
    public class Rectangle :Geometry
    {
        private int _a, _b;

        public Rectangle(){}

        public Rectangle(int a, int b){
            _a = a; 
            _b = b;
        }

        public override double Perimeter(){
            return (_a + _b) *2;
        }

        public override double Area(){
            return _a * _b;
        }
    }
}