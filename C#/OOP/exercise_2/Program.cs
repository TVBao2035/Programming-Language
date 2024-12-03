namespace OOP;


class Rectangle
{
    public double width, height;
    public void getInformation()
    {
        Console.Write("Enter Width: ");
        width = double.Parse(Console.ReadLine());
        Console.Write("Enter height: ");
        height = double.Parse(Console.ReadLine());
    }

    public double getArea()
    {
        return height*width;
    }

    public double getPerimeter()
    {
        return (height + width) * 2;
    }

    public void display()
    {
        Console.WriteLine("Area: " + getArea());
        Console.WriteLine("Perimeter: " + getPerimeter());
    }
}
class Program{
    static void Main()
    {
        Rectangle r = new Rectangle();
        r.getInformation();
        r.display();
    }
}