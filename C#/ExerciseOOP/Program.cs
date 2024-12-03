namespace ExerciseOOP{

    class Program{
        static public void Main(){
            Rectangle r = new Rectangle();
            r.enterPoint();
            Console.WriteLine("Perimeter: " + r.perimeter());
           
            Straight s = new Straight();
            s.enterPoint();
            Console.WriteLine("Distance: " + s.distance());
                      
            Cycle c = new Cycle();
            c.enterCycleData();
            Console.Write("Perimeter: " + c.cyclePerimeter());
        }
    }
}