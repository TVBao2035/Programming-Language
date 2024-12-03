using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercise_20
{
    public class Customer:Person
    {
        public int Balance{
            get; set;
        }

        public Customer(string name, string address, int balance):base(name, address){
            Balance = balance;
        }

        public override void display(){
            Console.WriteLine("Customer name: " + Name);
            Console.WriteLine("Customer address: " + Address);
            Console.WriteLine("Customer balance: " + Balance);
        }
    }
}