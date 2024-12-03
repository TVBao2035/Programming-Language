import java.io.*;
public class Rectangle extends Shape {
    public int length, width;
    private BufferedReader in = new BufferedReader(new InputStreamReader(System.in));
    public Rectangle() throws Exception{
        System.out.println("Enter Length:");
        this.length = Integer.parseInt(in.readLine());
        System.out.println("Enter Width: ");
        this.width = Integer.parseInt(in.readLine());
    }
    public void ShapeName(){
        System.out.println(">>> RECTANGLE");
    };
    public void Display(){
        System.out.println("Length: " + this.length);
        System.out.println("Width: " + this.width);
    };
    public double LengthOfLine(){
        return 0.0;
    };
    public double Area(){
        return this.length * this.width;
    };
}
