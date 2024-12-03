import java.io.*;
import java.math.*;
public class Line extends Shape {
    public Point p1, p2;
    private BufferedReader in = new BufferedReader(new InputStreamReader(System.in));

    public Line() throws Exception{
        System.out.println("Enter Two Points Of The Line:");
        this.p1 = new Point();
        this.p2 = new Point();
    }
    public void ShapeName(){
        System.out.println(">>> LINE");
    }
    public double LengthOfLine(){
        return Math.sqrt(Math.pow(Math.abs(p2.x - p1.x), 2) + Math.pow(Math.abs(p2.y - p1.y), 2));
    }
    public void Display(){
        this.p1.Display();
        this.p2.Display();
    }
    public double Area(){
        return 0.0;
    }
}
