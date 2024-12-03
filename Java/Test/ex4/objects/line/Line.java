package objects.line;
import objects.point.Point;
public class Line {
    public double a, b, c;

    public Line(double a, double b, double c){
        this.a = a;
        this.b = b;
        this.c = c;
    }

    public Line phuongTrinhQuaMotDiemVuongGocDuongThang(Point pointPass){
        Point vCP = new Point(-this.b, this.a);
        double otherC = -(vCP.x * pointPass.x) - (vCP.y * pointPass.y);
        return new Line(vCP.x, vCP.y, otherC);
    }

    public Point giaoDiem(Line otherLine){
        double tu = (this.a * otherLine.c - this.c * otherLine.a);
        double mau = this.b * otherLine.a - this.a * otherLine.b;
        double y = tu / mau;
        double x = -(this.b * y + this.c) / this.a;
        return new Point(x, y);
    }

    
    public void print(){
        System.out.println("{ "+ this.a+"x + "+this.b+"y + "+this.c+" = 0 }");
    }
}
