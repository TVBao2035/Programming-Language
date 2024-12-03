import java.io.*;
public class Circle extends Shape {
    public int radius;
    public Point center;
    private BufferedReader in = new BufferedReader(new InputStreamReader(System.in));
    public Circle() throws Exception{
        System.out.println("Enter Legnth Of Radius:");
        this.radius = Integer.parseInt(in.readLine());
        System.out.println("Enter Center Point:");
        this.center = new Point();
    }

    public void ShapeName(){
        System.out.println(">>> CIRCLE");
    };
    public void Display(){
        System.out.println("Radius: " + this.radius);
        System.out.print("Center Point: ");
        this.center.Display();
    };
    public double LengthOfLine(){
        return 0.0;
    };
    public double Area(){
        return Math.PI * this.radius * this.radius;
    };
}
