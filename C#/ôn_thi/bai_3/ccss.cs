namespace bai_3;


class GiangVien
{
    int ma_giang_vien;
    string ten, ngay_sinh, so_dien_thoai;

   
    public static bool operator == (GiangVien a, GiangVien b)
    {
       
        return false;
    } 
    public static bool operator != (GiangVien a, GiangVien b)
    {
       
        return false;
    } 
    public virtual void Nhap()
    {
        Console.Write("- nhap ma giang vien: ");
        ma_giang_vien = int.Parse(Console.ReadLine());
        Console.Write(" - nhap ten giang vien: ");
        ten = Console.ReadLine();
        Console.Write(" - ngay sinh cua giang vien: ");
        ngay_sinh = Console.ReadLine();
        Console.Write(" - nhap so dien thoai: ");
        so_dien_thoai = Console.ReadLine();
    }
    public virtual void Xuat()
    {
        Console.Write(ma_giang_vien + " | " + ten + " | " + ngay_sinh + " | " + so_dien_thoai + " | ");
    }
    public static void Tim_kiem_GV(GiangVien[] list, GiangVien a){
        bool kiemtra = false;
        ;

    }
}
 class GiangVienCoHuu:GiangVien
{
    int ma_chuc_danh, he_so;
   
 
    public override void Nhap()
    {
       
        Console.WriteLine("- nhap ma chuc danh: ");
        ma_chuc_danh = int.Parse(Console.ReadLine());
        Console.WriteLine(" - nhap he so: ");
        he_so = int.Parse(Console.ReadLine());
    }

    public override void Xuat()
    {
        base.Xuat();
        Console.WriteLine(ma_chuc_danh + " | " + he_so + " | ");
    }

}

class GiangVienThinhGiang : GiangVien
{
    string don_vi_cong_tac, ngay_tham_gia;
   
    public override void Nhap()
    {
        base.Nhap();
        Console.WriteLine("- nhap don vi cong tac: ");
        don_vi_cong_tac = Console.ReadLine();
        Console.WriteLine(" - nhap ngay tham gia: ");
        ngay_tham_gia = Console.ReadLine();
    }
    public override void Xuat()
    {
        base.Xuat();
        Console.WriteLine(don_vi_cong_tac + " | " + ngay_tham_gia + " | ");
    }

}
class Program
{
    static void Main()
    {
    
    }
}