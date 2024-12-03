import java.io.*;
public class main  {
    public static void main(String[] args) throws Exception {
        Shape[] listShapes = new Shape[4];
        System.out.println("**** Point ***");
        listShapes[0] = new Point();
        System.out.println("*** Line ***");
        listShapes[1] = new Line();
        System.out.println("*** Circle ****");
        listShapes[2] = new Circle();
        System.out.println("*** Rectangle ***");
        listShapes[3] = new Rectangle();

        for(int i=0; i<listShapes.length; i++){
            listShapes[i].ShapeName();
            listShapes[i].Display();
            System.out.println("Length Of Line: " + listShapes[i].LengthOfLine());
            System.out.println("Area: " +  listShapes[i].Area());
        }
    }
}
