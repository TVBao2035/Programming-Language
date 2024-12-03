using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercise_4;

class Circle
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public double getArea()
    {
        return 3.14 * this.radius * this.radius;
    }

    public double getPerimeter()
    {
        return 3.14 * 2 * this.radius;
    }

    public void display()
    {
        Console.WriteLine("Area: " + getArea());
        Console.WriteLine("Perimeter: " + getPerimeter());
    }
}