namespace exercise_14;
class Program{
    static void Main(){
        Point p1 = new Point(3.4, 6.4);
        Console.WriteLine(p1.distance(4.4, 5.5));

        Point p2 = new Point(4.4, 5.5);
        Console.WriteLine(p1.distance(p2));


    }
}