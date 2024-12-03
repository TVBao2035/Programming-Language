using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercise_26
{
    public class Invoice
    {
        public int Id{
            get; set;
        }

        public Customer customer{
            get; set;
        }

        public double Amount{
            get; set;
        }

        public Invoice(int id, Customer cus, double amount){
            Id = id;
            customer = cus;
            Amount = amount;
        }

        public double getAmountAfterDiscount(){
            return Amount * (100 - customer.Discount);
        }

    }
}