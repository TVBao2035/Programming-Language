import java.io.*;
public class DaThuc {
    public int SoLuongDonThuc;
    public DonThuc[] listDonThuc;
    private BufferedReader in = new BufferedReader(new InputStreamReader(System.in));
    public DaThuc() throws Exception{
        System.out.println("Nhap so luong don thuc:");
        this.SoLuongDonThuc = Integer.parseInt(in.readLine());
        this.listDonThuc = new DonThuc[this.SoLuongDonThuc];
        for(int i=0; i < this.SoLuongDonThuc; i++){
            this.listDonThuc[i] = new DonThuc();
        }
    }
    public void DaoHam(){
        for(int i=0; i<this.SoLuongDonThuc; i++) {
            this.listDonThuc[i].DaoHam();
        }
    }
     public void NguyenHam(){
        for(int i=0; i<this.SoLuongDonThuc; i++) {
            this.listDonThuc[i].NguyenHam();
        }
    }
    public void Display(){
        if(this.listDonThuc[0].SoMu != 0){
            this.listDonThuc[0].Display();
        }
        for(int i=1; i<this.SoLuongDonThuc; i++){
            if(this.listDonThuc[i].SoMu != 0){
                if(i != this.SoLuongDonThuc && this.listDonThuc[0].SoMu != 0 ){
                    System.out.print(" + ");
                }
                this.listDonThuc[i].Display();
            }
        }
        System.out.println(" = 0");
    }
}
