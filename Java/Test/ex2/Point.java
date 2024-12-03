import java.io.*;
public class Point extends Shape {
    public int x, y;
    private BufferedReader in = new BufferedReader(new InputStreamReader(System.in));
    public Point() throws Exception{
        System.out.println("Enter [X, Y]:");
        this.x = Integer.parseInt(in.readLine());
        this.y = Integer.parseInt(in.readLine());
    }
    public void ShapeName(){
        System.out.println(">>> POINT");
    }
    public void Display(){
        System.out.println("[ " + this.x + ", " + this.y + " ]");
    }
    public double LengthOfLine(){
        return 0.0;
    }
    public double Area(){
        return 0.0;
    }
}
