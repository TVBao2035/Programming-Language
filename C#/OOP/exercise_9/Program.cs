namespace exercise_9;
class Program{
    static void Main(){
        Rectangle r = new Rectangle(3.5, 6);
        Console.WriteLine("Area: " + r.getArea());
        Console.WriteLine("Perimeter: " + r.getPerimeter());
        r.Width = 4.5;
        r.Height = 10;
        Console.WriteLine("Area: " + r.getArea());
        Console.WriteLine("Perimeter: " + r.getPerimeter());
    }
}