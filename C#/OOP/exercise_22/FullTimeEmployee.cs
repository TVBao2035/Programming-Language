using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercise_22
{
    public class FullTimeEmployee:Employee
    {
        public FullTimeEmployee(string name, int paymentPerHour):base(name, paymentPerHour){

        }

        public override int calculateSalary(){
            return 8 * PaymentPerHour;
        }
    }
}