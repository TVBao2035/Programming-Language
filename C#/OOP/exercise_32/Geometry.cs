using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercise_32
{
    public abstract class Geometry
    {
        // private int _a, _b, _c;



        // public Geometry(){}

        // public Geometry(int a, int b, int c){
        //     _a = a; 
        //     _b = b;
        //     _c = c;
        // }
        public abstract double Perimeter();
        public abstract double Area();

        public virtual void display(){
            Console.WriteLine("Area :" + Area());
            Console.WriteLine("Perimeter: " + Perimeter());
        }
    }
}