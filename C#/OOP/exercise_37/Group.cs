using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercise_37
{
    public class Group
    {
        public string NameG{
            get; set;
        }

        public List<Family> f{
            get; set;
        }

        public Group(){}

        public Group(string nameG, List<Family> fg){
            NameG = nameG;
            f = fg;
        }

        public int getNumberFamily(){
            return f.Count();
        }

        public static double avgAgeGroup(Group g){
            double sumAge = 0;
            double count = 0;
            foreach(var eF in g.f){
                foreach(var eP in eF.p){
                    sumAge += eP.Age;
                    count++;
                }
            }

            return (sumAge / count);
        }

        public static List<People> getPeopleHaveNotJob(Group g){
            List<People> list = new List<People>();

            foreach(var eF in g.f){
                foreach(var eP in eF.p){
                    if(eP.Job == ""){
                        list.Add(eP);
                    }
                }
            }

            return list;
        }

        public void display(){
            foreach(var e in f){
                e.display();
                Console.WriteLine("------------------------------------------------------------------------");
            }
        }
    }
}