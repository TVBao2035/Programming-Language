using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercise_33
{
    public class EmployeeFT:Person
    {
        public int Day{
            get; set;
        }

        public long Money{
            get; set;
        }

        public EmployeeFT(){}
        public EmployeeFT(string name, int age, string add, string tel, string sex, int day, long money):base(name,age,add, tel, sex){
            Day = day;
            Money = money;
        }

        public override long salary(){
            return Money*Day;
        }
        public override void display(){
            base.display();
            Console.WriteLine("Day: " + Day);
            Console.WriteLine("Money: " + Money);
            Console.WriteLine("Salary: " + salary());
        }

        public static List<EmployeeFT> getMaxSalary(List<EmployeeFT> ft){
            List<EmployeeFT> result = new List<EmployeeFT>();
            long maxSalary = ft[0].salary();
            foreach(EmployeeFT e in ft) if(e.salary() > maxSalary) maxSalary = e.salary();

            foreach(EmployeeFT e in ft) if(e.salary() == maxSalary) result.Add(e);

            return result;
        }
    }
}