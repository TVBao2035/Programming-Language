using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercise_35
{
    public class NonCFood:Food
    {
        public double Weight{
            get; set;
        }

        public NonCFood(){}
        public NonCFood(string name, double price, double weight):base(name, price){
            Weight = weight;
        }

        public override void display(){
            base.display();
            Console.WriteLine("Weight: " + Weight);
        }

        public static void sortWeight(List<NonCFood> list){
            for(int i = 0; i < list.Count - 1; i++){
                for(int j = i + 1; j < list.Count; j++){
                    if(list[i].Weight > list[j].Weight){
                        NonCFood temp = list[i];
                        list[i] = list[j];
                        list[j] = temp;
                    }
                }
            }
        }
    }
}