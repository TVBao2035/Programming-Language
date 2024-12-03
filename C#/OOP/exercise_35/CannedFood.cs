using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercise_35
{
    public class CannedFood:Food
    {
        public int NumberBox{
            get; set;
        }

        public CannedFood(){}

        public CannedFood(string name, double price, int numberBox):base(name, price){
            NumberBox = numberBox;
        }

        public override void display(){
            base.display();
            Console.WriteLine("Number box: " + NumberBox);
        }

        public static void sortNumberBox(List<CannedFood> list){
            for(int i = 0; i < list.Count - 1; i++){
                for(int j = i + 1; j < list.Count; j++){
                    if(list[i].NumberBox > list[j].NumberBox){
                        CannedFood temp = list[i];
                        list[i] = list[j];
                        list[j] = temp;
                    }
                }
            }
        }
    }
}