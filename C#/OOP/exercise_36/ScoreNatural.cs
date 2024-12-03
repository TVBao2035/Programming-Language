using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercise_36
{
    public class ScoreNatural:Score
    {
        public double Physic{
            get; set;
        }

        public double Chemistry{
            get; set;
        }
        public double Biology{
            get; set;
        }

        public ScoreNatural(){}
        public ScoreNatural(double math, double literature, double english, double physic, double chemistry, double biology):base(math, literature, english){
            Physic = physic;
            Chemistry = chemistry;
            Biology = biology;
        }

        public override double PointA(){
            return Math + Physic + Chemistry;
        }

        public override double PointB(){
            return Math + Chemistry + Biology;
        }

        public double pointNatural(){
            return Physic + Chemistry + Biology;
        }

        public override double avgPoint(){
            return (Math + Literature + English + Physic + Chemistry + Biology) / 6;
        }

        
    }
}