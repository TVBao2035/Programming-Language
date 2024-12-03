using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercise_33
{
    public class EmployeePT:Person
    {
        public int Hour{
            get; set;
        }
        public long Money{
            get; set;
        }

        public EmployeePT(){}
        public EmployeePT(string name, int age, string add, string tel, string sex, int hour, long money):base(name,age,add, tel, sex){
            Hour = hour;
            Money = money;
        }

        public override long salary(){
            return Money*Hour;
        }

        public override void display(){
            base.display();
            Console.WriteLine("Hour: " + Hour);
            Console.WriteLine("Money: " + Money);
            Console.WriteLine("Salary: " + salary());
        }

        public static List<EmployeePT> getMaxSalary(List<EmployeePT> pt){
            List<EmployeePT> result = new List<EmployeePT>();
            long maxSalary = pt[0].salary();
            foreach(EmployeePT e in pt) if(e.salary() > maxSalary) maxSalary = e.salary();

            foreach(EmployeePT e in pt) if(e.salary() == maxSalary) result.Add(e);

            return result;
         }
    }
}