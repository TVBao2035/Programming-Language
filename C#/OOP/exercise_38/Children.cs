using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercise_38
{
    public class Children:Person
    {
        
        public Children(){}

        public Children(string name, int age, string address, List<Book> listBook):base(name, age, address, listBook){

        }


        public override long moneyPay(){
            return ListBook.Count * 5000;
        }


        public void display(){
            Console.WriteLine("Children!");
            base.display();
        }


    }
}