using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercise_31
{
    public class Car:Transport
    {
        public string EngineType{
            get; set;
        }

        public int NumberSeat{
            get; set;
        }
        
        public Car(){}
        public Car(string manufacturer, string name, int year, int speed, int numberSeat, string engineType):base(manufacturer, name, year, speed){
            NumberSeat = numberSeat;
            EngineType = engineType;
        }

        public double getSpeedBasic(){
            return Speed / NumberSeat;
        }

        public void display(){
            base.display();
            Console.WriteLine("Engine Type: " + EngineType);
            Console.WriteLine("Number Seat: " + NumberSeat);
            Console.WriteLine("Speed Basic: " + getSpeedBasic());
        }

        public static List<Car> getCarHaveMaxSpeedBasic(List<Car> array){
            double maxSpeedBasicValue = array[0].getSpeedBasic();
            List<Car> listCarsHaveMaxSpeedBasic = new List<Car>();

            foreach(Car element in array) if(element.getSpeedBasic() > maxSpeedBasicValue) maxSpeedBasicValue = element.getSpeedBasic();

            foreach(Car element in array) if(element.getSpeedBasic() == maxSpeedBasicValue) listCarsHaveMaxSpeedBasic.Add(element);

            return listCarsHaveMaxSpeedBasic;
        }

        public static List<Car> getCarHaveMaxSeat(List<Car> array){
            int maxSeatValue = array[0].NumberSeat;
            List<Car> listCarsHaveMaxSeat = new List<Car>();

            foreach(Car element in array) if(element.NumberSeat > maxSeatValue) maxSeatValue = element.NumberSeat;

            foreach(Car element in array) if(element.NumberSeat == maxSeatValue) listCarsHaveMaxSeat.Add(element);

            return listCarsHaveMaxSeat;
        }
    }
}