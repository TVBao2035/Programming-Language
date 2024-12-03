namespace exercise_21;
class Program{
    static void Main(){
        Shape s1 = new Circle(4.5);
        Shape s2 = new Rectangle(4.7, 3.3);

        Console.WriteLine(s1.getArea() + "   " + s1.getPerimeter());
        Console.WriteLine(s2.getArea() + "   " + s2.getPerimeter());
    }
}