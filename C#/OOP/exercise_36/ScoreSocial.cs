using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercise_36
{
    public class ScoreSocial:Score
    {
        public double CE{
            get; set;
        }

        public double Geography{
            get; set;
        }

        public double History{
            get; set;
        }

        public ScoreSocial(){}

        public ScoreSocial(double math, double literature, double english, double ce, double geography, double history):base(math, literature, english) {
            CE = ce;
            Geography = geography;
            History = history;
        }

        public override double PointC(){
            return Literature + Geography + History;
        }

        public double pointSocial(){
            return CE + Geography + History;
        }

        public override double avgPoint(){
            return (Math + Literature + English + CE + Geography + History) / 6;
        }
    }
}