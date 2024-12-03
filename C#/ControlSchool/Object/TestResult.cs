using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlSchool.Object
{
    public class TestResult
    {
        private string id_subject;

        private string id_student;

        private double score;
        public string Id_student{
            get{
                return id_student;
            }
            set{
                id_student = value;
            }
        }

         public string Id_subject{
            get{
                return id_subject;
            } 
            set{
                id_subject = value;
            }
        }

        public double Score{
            get{
                return score;
            }
            set{
                score = value;
            }
        }

        public TestResult(string id_stud, string id_sub, double sco){
            id_student = id_stud;
            id_subject = id_sub;
            score = sco;
        }

    }
}