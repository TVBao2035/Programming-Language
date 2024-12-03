using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercise_18
{
    public class Manager:Employee
    {
        public int Bonus{
            get; set;
        }

        public Manager(string name, int salary, int bonus):base(name, salary){
            Bonus = bonus;
            Salary += Bonus;
        }

      
    }
}