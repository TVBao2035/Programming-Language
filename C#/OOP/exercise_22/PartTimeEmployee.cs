using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercise_22
{
    public class PartTimeEmployee:Employee
    {
        public int WorkingHours{
            get; set;
        }

        public PartTimeEmployee(string name, int paymentPerHour, int workingHours):base(name, paymentPerHour){
            WorkingHours = workingHours;
        }

        public override int calculateSalary(){
            return WorkingHours * PaymentPerHour;
        }
    }
}