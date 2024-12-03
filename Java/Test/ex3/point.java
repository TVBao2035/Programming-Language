import java.io.*;
public class point {
    public int x, y;
    private BufferedReader in = new BufferedReader(new InputStreamReader(System.in));

    public point(int x, int y){
        this.x = x;
        this.y = y;
    }

    public point(){
        try {
            System.out.println("X : ");
            x = Integer.parseInt(in.readLine());
            System.out.println("Y : ");
            y = Integer.parseInt(in.readLine());
        } catch (Exception e) {
            // TODO: handle exception
        }
    }

    public point vector(point other){
        return new point((other.x - this.x), (other.y - this.y));
    }

    public void display(){
        System.out.println("x = " + this.x);
        System.out.println("y = " + this.y);
    }

}
 