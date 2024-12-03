namespace bai_thi;


class CanBo
{
    private int maCB;
    private string ho_ten;
    private string gioi_tinh;
    private int tuoi;

    public virtual void Nhap()
    {
        Console.Write("- Nhap ma can bo: ");
        maCB = int.Parse(Console.ReadLine());
        Console.Write("- Nhap ho ten can bo: ");
        ho_ten = Console.ReadLine();
        Console.Write("- Nhap gioi tinh: ");
        gioi_tinh = Console.ReadLine();
        Console.Write("- Nhap tuoi: ");
        tuoi = int.Parse(Console.ReadLine());
    }


    public virtual void Xuat()
    {
        Console.Write(maCB + "  " + ho_ten + "  " + gioi_tinh + "  " + tuoi + "  ");
    }


    public int LayMCB()
    {
        return maCB;
    }

    public string LayHoTen(){
        return ho_ten;
    }

    public int LayTuoi(){
        return tuoi;
    }
}


class KySu : CanBo
{
    private string nghanh;

    public override void Nhap()
    {
        base.Nhap();
        Console.Write("- Nhap nghanh: ");
        nghanh = Console.ReadLine();
    }

    public override void Xuat()
    {
        base.Xuat();
        Console.Write(nghanh + "  ");
    }


}


class CongNhan : CanBo{
    private int bac;

    public override void Nhap()
    {
        base.Nhap();
        Console.Write("- Nhap bac: ");
        bac = int.Parse(Console.ReadLine());
    }

    public override void Xuat()
    {
        base.Xuat();
        Console.Write(bac + "  ");
    }
}


class QL
{
    List<CanBo> danhSachCanBo = new List<CanBo>();


    public void NhapNhieuCanBo()
    {
        CanBo temp ;
        do{
            Console.WriteLine("1.Ky Su\n2.Cong Nhan");
            int n = int.Parse(Console.ReadLine());

            if(n == 1) temp = new KySu();
            else if (n == 2) temp = new CongNhan();

            temp.Nhap();
            
            if(temp.LayMCB() != 0) danhSachCanBo.Add(temp); 
        }while(temp.LayMCB() != 0);
    }


    public void XuatDanhSach()
    {
        foreach(CanBo cb in danhSachCanBo)
        {
            cb.Xuat();
        }
    }
}
class Program
{
    static void Main()
    {
        QL quanli = new QL();

    }
}