import objects.point.Point;
import objects.line.Line;
import objects.triangular.Triangular;
public class main {
    public static void main(String[] args) {
        System.out.println("Hello world");
        Point p1 = new Point(-1, 1);
        Point p2 = new Point (3, 1);
        Point p3 = new Point (2, 4);
        Triangular triangular = new Triangular(p1, p2, p3);
        triangular.print();
        System.out.println("Truc Tam: ");
        triangular.trucTam().print();
        System.out.println("Trong Tam: ");
        triangular.trongTam().print();

    }
}
