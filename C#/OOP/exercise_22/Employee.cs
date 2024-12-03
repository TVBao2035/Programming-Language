using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercise_22
{
    public abstract class Employee
    {
        public string Name{
            get; set;
        }
        public int PaymentPerHour{
            get; set;
        }

        public Employee(string name, int paymentPerHour){
            Name = name;
            PaymentPerHour = paymentPerHour;
        }

        public abstract int calculateSalary();
    }
}