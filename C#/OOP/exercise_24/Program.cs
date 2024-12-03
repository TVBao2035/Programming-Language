namespace exercise_24;
class Program {
    static void Main(){
        Point p1 = new Point(4, 6);
        Point p2 = new Point(8, 5);
        Point p3 = new Point(6, 8);

        Triangle t = new Triangle(p1, p2, p3);
        Triangle r = new Triangle(3, 5 ,5 ,6 ,4, 9);

        Console.WriteLine(t.getPerimeter());
        Console.WriteLine(r.getPerimeter());
    }
}