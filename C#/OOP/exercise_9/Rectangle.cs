using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercise_9
{
    public class Rectangle
    {
        private double width, height;

        public double Width{
            get; set;
        }
        public double Height{
            get; set;
        }

       public Rectangle(){
        
       }

        public Rectangle(double width, double height){
            Width = width;
            Height = height;
        }

        public double getArea(){
            return Width * Height;
        }

        public double getPerimeter(){
            return (Width + Height) * 2;
        }
    }

}