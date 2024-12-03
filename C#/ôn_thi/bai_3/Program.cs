namespace bai_3;


class GiangVien
{
    int ma_giang_vien;
    string ten, ngay_sinh, so_dien_thoai;

    public GiangVien(int ms, string t, string ns, string sdt)
    {
        ma_giang_vien = ms;
        ten = t;
        ngay_sinh = ns;
        so_dien_thoai = sdt;
    }
    public static bool operator == (GiangVien a, GiangVien b)
    {
        if(a.ma_giang_vien == b.ma_giang_vien) return true;
        return false;
    } 
    public static bool operator != (GiangVien a, GiangVien b)
    {
        if(a.ma_giang_vien != b.ma_giang_vien) return true;
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
        for(int i = 0; i < list.Length; i++)
        {
            if(list[i] == a && !kiemtra)
            {
                list[i].Xuat();
                kiemtra = true;
                break;
            }
        }
        if(!kiemtra) 
            Console.WriteLine("Khong tim thay giang vien!");

    }
}
 class GiangVienCoHuu:GiangVien
{
    int ma_chuc_danh, he_so;
    public GiangVienCoHuu(int ms, string t, string ns, string sdt, int mch, int hs):base(ms,t,ns, sdt)
    {
        ma_chuc_danh = mch;
        he_so = hs;
    }
    public override void Nhap()
    {
        base.Nhap();
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
    public GiangVienThinhGiang(int ms, string t, string ns, string sdt, string dv, string ng_tg):base(ms, t, ns, sdt)
    {
        don_vi_cong_tac = dv;
        ngay_tham_gia = ng_tg;
    }
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
        GiangVien[] danh_sach_giang_vien = new GiangVien[5]; 
        danh_sach_giang_vien[0] = new GiangVienCoHuu(388253, "Le minh hien", "20/12/2003", "08399322",77992, 9);
        danh_sach_giang_vien[1] = new GiangVienCoHuu(224553, "Truong van Bao", "22/1/2004", "08399322", 43333, 6);
        danh_sach_giang_vien[2] = new GiangVienCoHuu(666453, "Nguyen van tien dat", "27/7/2006", "08399322",73232, 9);
        danh_sach_giang_vien[3] = new GiangVienCoHuu(837222, "Nguyen tri nhan", "12/3/2007", "083333322", 54734, 6);
        danh_sach_giang_vien[4] = new GiangVienCoHuu(664444, "nguyen minh quang", "8/2/2003", "08333322", 496433, 6);

        GiangVienThinhGiang a = new GiangVienThinhGiang(22153, "Truong van Bao", "22/1/2004", "08399322", "DH Tien Gian", "23/6/2023");
        GiangVienCoHuu b = new GiangVienCoHuu(224553, "Truong van Bao", "22/1/2004", "08399322", 43333, 6);
        GiangVien.Tim_kiem_GV(danh_sach_giang_vien, b);
    }
}