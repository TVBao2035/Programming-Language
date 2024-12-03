using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercise_27
{
    public class PolyLine
    {
        public List<Point>Points = new List<Point>();

        public PolyLine(List<Point> points){
            Points = points;
        }

        public PolyLine(){}

        public void appendPoint(Point p){
            Points.Add(p);
        }

        public double getLength(){
            double result = 0;
            for(int i=0; i < Points.Count - 1; i++){
                Point p1 = new Point(Points[i].X, Points[i].Y);
                Point p2 = new Point(Points[i + 1].X, Points[i +1].Y);

                result += Math.Sqrt(Math.Pow((p2.X - p1.X), 2) + Math.Pow((p2.Y - p1.Y), 2));
            }

            return result;
        }

    }
}