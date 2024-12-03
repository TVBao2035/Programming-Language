using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercise_15
{
    public class Account
    {
        public int Id{
            get; set;
        }

        public int Balance{
            get; set;
        }

        public string Name{
            get; set;
        }

        public Account(int id, string name, int balance){
            Id = id;
            Name = name;
            Balance = balance;
        }

        public Account(int id, string name){
            Id = id;
            Name = name;
        }

        public void deposit(int amount){
            Balance += amount;
        }

        public void withdraw(int amount){
            if(Balance < amount){
                Console.WriteLine("That amount exceeds your current balance.");
            }else Balance -= amount;
        }

        public void display(){
            Console.WriteLine("Id: " +  Id);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Balance: " + Balance);
        }
    }
}