using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercise_26
{
    public class Customer
    {
        public int Id{
            get; set;
        }
        public string Name{
            get; set;
        }
        public int Discount{
            get; set;
        }

        public Customer(){}

        public Customer(int id, string name, int discount){
            Id = id;
            Name = name; 
            Discount = discount;
        }
    }
}