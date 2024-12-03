namespace exercise_32;

class Program{
    static void Main(){
        Geometry geometry = new Rectangle(3, 7);
        geometry.display();

        geometry = new Circle(4);
        geometry.display();

        geometry = new Triangle(4, 3, 2);
        geometry.display();

    }
}