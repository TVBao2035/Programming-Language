using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercise_32
{
    public class Circle : Geometry
    {
        private int _r;

        public Circle(){}

        public Circle(int r){
            _r = r;
        }

        public override double Perimeter(){
            return 3.14 * 2 *_r;
        }

        public override double Area(){
            return 3.14 * _r * _r;
        }
    }
}