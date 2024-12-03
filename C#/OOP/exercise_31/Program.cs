namespace exercise_31;

class Program{

    static void Main(){
        List<Car> listCars = new List<Car>();

        listCars.Add(new Car("VietNam", "VinFast_1", 2019, 400, 4, "EngineVN"));
        listCars.Add(new Car("Chine", "CarCN", 2019, 100, 4, "EngineSP"));
        listCars.Add(new Car("VietNam", "VinFast_2", 2020, 400, 2, "EngineVN_S"));
        listCars.Add(new Car("VietNam", "VinFast_3", 2022, 500, 6, "EngineVN_S"));
        listCars.Add(new Car("VietNam", "VinFast_3S", 2023, 600, 6, "EngineVN_SS"));

        void print(Car element){
            element.display();
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++");
        }

        List<Car> listCarsHaveMaxSpeedBasic = Car.getCarHaveMaxSpeedBasic(listCars);
        List<Car> listCarsHaveMaxSeat = Car.getCarHaveMaxSeat(listCars);

 
        Console.WriteLine("List Cars Have Max Speed Basic: ");
        listCarsHaveMaxSpeedBasic.ForEach(print);
        Console.WriteLine("List Cars Have Max Seat: ");
        listCarsHaveMaxSeat.ForEach(print);
    }
}