using System;
using System.Collections.Generic;
 
namespace Code_Coach_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> coffee = new Dictionary<string, int>();
            coffee.Add("Americano", 50);
            coffee.Add("Latte", 70);
            coffee.Add("Flat White", 60);
            coffee.Add("Espresso", 60);
            coffee.Add("Cappuccino", 80);
            coffee.Add("Mocha", 90);

            int discount = int.Parse(Console.ReadLine());
            foreach(string x in coffee.Keys){
                double temp = coffee[x]*(100 - discount)/100;
                coffee[x] = (int)temp;
                Console.WriteLine(coffee[x]);
            }
            Console.ReadKey();
        }
    }
}
