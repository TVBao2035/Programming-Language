package objects.triangular;
import objects.point.Point;
import objects.line.Line;
public class Triangular {
    public Point A, B, C;

    public Triangular(Point a, Point b, Point c){
        A = a;
        B = b;
        C = c;
    }

    public Point trucTam(){
        Line dtAB = A.phuongTrinhDuongThangQuaHaiDiem(B);
        Line dtAC = A.phuongTrinhDuongThangQuaHaiDiem(C);

        Line duongCaoThuNhat = dtAB.phuongTrinhQuaMotDiemVuongGocDuongThang(C);
        Line duongCaoThuHai = dtAC.phuongTrinhQuaMotDiemVuongGocDuongThang(B);

        return duongCaoThuNhat.giaoDiem(duongCaoThuHai);
    }

    public Point trongTam(){
        Point tdAC = A.trungDiem(C);
        Point tdAB = A.trungDiem(B);
        Line ptdt_1 = C.phuongTrinhDuongThangQuaHaiDiem(tdAB);
        Line ptdt_2 = B.phuongTrinhDuongThangQuaHaiDiem(tdAC);
        return ptdt_1.giaoDiem(ptdt_2);
    }
    public void print(){
        System.out.println("Diem A:");
        A.print();
        System.out.println("Diem B:");
        B.print();
        System.out.println("Diem C:");
        C.print();
    }
}
