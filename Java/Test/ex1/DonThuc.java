import java.io.*;
class DonThuc{
    public int CoSo, SoMu;
    private BufferedReader in = new BufferedReader(new InputStreamReader(System.in));
    public DonThuc() throws Exception{
        System.out.println("Nhap Co So: ");
        this.CoSo = Integer.parseInt(in.readLine());
        System.out.println("Nhap So Mu: ");
        this.SoMu = Integer.parseInt(in.readLine());
    }

    public void DaoHam(){
        this.CoSo = this.CoSo * this.SoMu;
        this.SoMu = this.SoMu - 1;
    }
    public void NguyenHam(){
        this.SoMu = this.SoMu + 1;
        this.CoSo = this.CoSo / this.SoMu;
    }
    public void Display(){
        System.out.print(this.CoSo + "^" + this.SoMu);
    }
}