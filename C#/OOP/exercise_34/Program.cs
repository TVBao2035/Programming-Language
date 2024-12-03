namespace exercise_34;

class Program{
    static void Main()
    {
        Point A = new Point(4, 6);
        Point B = new Point (5, 7);
        Point C = new Point (2, 5);
        Point subtraction = A - B;
        Triangle triangle = new Triangle(A, B, C);
        Console.WriteLine(subtraction.X + " " + subtraction.Y);
        Console.WriteLine(triangle.area());
        Console.WriteLine(triangle.perimeter());
        Console.WriteLine(triangle.center().X + " " + triangle.center().Y);
        Console.WriteLine(triangle.isTriangle());
    }
}