package objects.point;
import objects.line.Line;
public class Point {
    public double x, y;

    public Point(double x, double y){
        this.x = x;
        this.y = y;
    }

    public Point trungDiem(Point ortherPoint){
        double x = (ortherPoint.x + this.x)/2;
        double y = (ortherPoint.y + this.y)/2;
        return new Point(x, y);
    }
    public Point vector(Point orther){
        return new Point((orther.x - this.x), (orther.y - this.y));
    }
    

    public Line phuongTrinhDuongThangQuaHaiDiem(Point other){
        Point vec = vector(other);
        double c = (vec.y * other.x - vec.x * other.y);
        return new Line(-vec.y, vec.x, c);
    }
    
    public void print(){
        System.out.println("[" + this.x + " ; " + this.y +"]");
    }
}
