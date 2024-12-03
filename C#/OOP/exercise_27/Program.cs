namespace exercise_27;
class Program {
    static void Main(){
        Point p1 = new Point(1, 1);
        Point p2 = new Point(2, 3);
        Point p3 = new Point(3, 0);
        Point p4 = new Point(4, 2);

        PolyLine p = new PolyLine();
        p.appendPoint(p1);
        p.appendPoint(p2);
        p.appendPoint(p3);
        p.appendPoint(p4);

        Console.Write(p.getLength());
    }
}