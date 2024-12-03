using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciseOOP
{
    public class Rectangle : Straight
    {
        public Point thirdPoint{
            get; set;
        }

        public Point fourthPoint{
            get; set;
        }

        public Straight Length{
            get; set;
        }
       
        public Straight Width{
            get; set;
        }

        public void enterPoint(){
            base.enterPoint();
            thirdPoint = new Point();
            thirdPoint.X = firstPoint.X;
            thirdPoint.Y = secondPoint.Y;
            fourthPoint = new Point();
            fourthPoint.X = secondPoint.X;
            fourthPoint.Y = firstPoint.Y;
            Length = new Straight(firstPoint, thirdPoint);
            Width = new Straight(firstPoint, fourthPoint);
        }

        public double perimeter(){
            return Length.distance() * Width.distance();
        }
    }
}