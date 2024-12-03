namespace exercise_23;
class Program {
    static void Main()
    {
        Point a = new Point(6, 6);
        Point b = new Point(5, 5);

        Line l = new Line(a, b);
        Console.Write(l.getLength());
    }
}