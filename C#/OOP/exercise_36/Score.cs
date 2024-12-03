using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercise_36
{
    public class Score
    {
        public double Math{
            get; set;
        }

        public double Literature{
            get; set;
        }

        public double English{
            get; set;
        }

        public Score(){}
        public Score(double math, double literature, double english){
            Math = math;
            Literature = literature;
            English = english;
        }

        public virtual double PointA(){
            return Math;
        }

        public virtual double PointB(){
            return Math;
        }

        public virtual double PointC(){
            return Literature;
        }

        public virtual double PointD(){
            return Math + Literature + English;
        }

        public virtual double avgPoint(){
            return 0;
        }

        public static double getMaxAvg(List<Score> list){
            double maxAvg = list[0].avgPoint();

            foreach(var e in list) maxAvg = e.avgPoint() > maxAvg ? e.avgPoint() : maxAvg;

            return maxAvg;
        }


        public static double getMinAvg(List<Score> list){
            double minAvg = list[0].avgPoint();

            foreach(var e in list) minAvg = e.avgPoint() > minAvg ? minAvg : e.avgPoint();

            return minAvg;
        }

        public bool isPass(){
            return avgPoint() > 5;
        }

        public static double getMaxPointA(List<Score> list){
            double maxPoint = list[0].PointA();

            foreach(var e in list) maxPoint = maxPoint > e.PointA() ? maxPoint : e.PointA();

            return maxPoint;
        }
        public static double getMaxPointB(List<Score> list){
            double maxPoint = list[0].PointB();

            foreach(var e in list) maxPoint = maxPoint > e.PointB() ? maxPoint : e.PointB();

            return maxPoint;
        }

        public static double getMaxPointC(List<Score> list){
            double maxPoint = list[0].PointC();

            foreach(var e in list) maxPoint = maxPoint > e.PointC() ? maxPoint : e.PointC();

            return maxPoint;
        }

        public static double getMaxPointD(List<Score> list){
            double maxPoint = list[0].PointD();

            foreach(var e in list) maxPoint = maxPoint > e.PointD() ? maxPoint : e.PointD();

            return maxPoint;
        }
    }
}