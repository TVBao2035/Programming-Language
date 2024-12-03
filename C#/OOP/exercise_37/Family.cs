using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercise_37
{
    public class Family
    {
        public string NameF{
            get; set;
        }

        public string Status{
            get; set;
        }

        public string Add{
            get; set;
        }

        public List<People> p{
            get; set;
        }

        public Family(){}

        public Family(string nameF, string status, string add, List<People> pf){
            NameF = nameF;
            Status = status;
            Add = add;
            p = pf;
        }
    
        public void display(){
            Console.WriteLine("Name of Family: " + NameF);
            Console.WriteLine("Status: " + Status);
            Console.WriteLine("Address: " + Add);
            Console.WriteLine("List Of People in Family: ");
            foreach(var e in p){
                e.display();
                Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++");
            }
        }

        public static List<Family> getPoorHousehold(List<Family> listF){
            List<Family> list = new List<Family>();

            foreach(var e in listF) if(e.Status == "poor") list.Add(e);

            return list;
        }

        public static List<Family> findFamilySurname(List<Family> listF, string surName){
            List<Family> list = new List<Family>();

            foreach(var e in listF) if(e.NameF == surName) list.Add(e);

            return list;
        }
    }

}