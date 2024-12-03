using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercise_38
{
    public class Adult:Person
    {
        public Adult(){}

        public Adult(string name, int age, string address, List<Book> listBook):base(name, age, address, listBook){

        }

        public override long moneyPay(){
            return ListBook.Count * 10000;
        }

        public void display(){
            Console.WriteLine("Adult!");
            base.display();
        }
    }
}