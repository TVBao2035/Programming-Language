public class triangular {
    public point a,b,c;
    public triangular(point a, point b, point c){
        this.a = a;
        this.b = b;
        this.c = c;
    }

    public triangular(){
        try {
            System.out.print("Point A:");
            a = new point();
            System.out.print("Point B:");
            b = new point();
            System.out.print("Point C:");
            c = new point();
        } catch (Exception e) {
            // TODO: handle exception
        }
    }

    public point truc_tam(){
        
    }

    public void display(){
        System.out.println("Point A :");
        this.a.display();
        System.out.println("Point B :");
        this.b.display();
        System.out.println("Point C :");
        this.c.display();
    }
}
