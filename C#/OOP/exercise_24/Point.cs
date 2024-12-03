using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercise_24
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
        public Point(int x, int y){
            X = x;
            Y = y;
        }
    }
}