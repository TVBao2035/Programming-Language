namespace bai_1
{
    class CanBo
    {
        string cccd, hoten, gioitinh;
        DateTime ngaysinh;
        
        
        public void NhapTT()
        {
            Console.Write("- Nhap CCCD:");
            cccd = Console.ReadLine();
            Console.Write("- Nhap Ten: ");
            hoten = Console.ReadLine();
            Console.Write("- Nhap gioi tinh: ");
            gioitinh = Console.ReadLine();
            Console.Write("- Nhap ngay sinh: ");
            ngaysinh = DateTime.Parse(Console.ReadLine());
        }

        public void XuatTT()
        {
            Console.Write( " | " + cccd + " | " + hoten + " | " + gioitinh + " | " + ngaysinh + " | " );
        }

    }

    class GiangVien : CanBo
    {
        double he_so, luong_thang, tien_day_them, tien_phu_cap;
        double luong_co_ban = 1800000, don_gia = 95000;
        int so_gio_day_them, kinh_nghiem;

        public void NhapTT(){
            base.NhapTT();
            Console.Write("- Nhap he so: ");
            he_so = double.Parse(Console.ReadLine());
            Console.Write("- Nhap so gio day them: ");
            so_gio_day_them = int.Parse(Console.ReadLine());
            Console.Write("- Nhap kinh nghiem: ");
            kinh_nghiem = int.Parse(Console.ReadLine());

            luong_thang = he_so * luong_co_ban;
            tien_day_them = don_gia * so_gio_day_them;
            tien_phu_cap = kinh_nghiem * 0.01 * luong_thang;
        }
     

        public  double Tinh_tien_hang_thang()
        {
            return luong_thang + tien_day_them + tien_phu_cap;
        }
        public  double Tinh_tien_hang_nam()
        {
            return 12 * Tinh_tien_hang_thang();
        }

        public void XuatTT(){
            base.XuatTT();
            Console.WriteLine(he_so + " | " + kinh_nghiem + " | " + so_gio_day_them + " | " + Tinh_tien_hang_thang() + "đ | " + Tinh_tien_hang_nam() + "đ | ");
        }

        public static double Tong_luong_thang_tat_ca_giang_vien(GiangVien[] danhsach)
        {
            double tong_luong = 0;
            for(int i = 0; i < danhsach.Length; i++){
                tong_luong += danhsach[i].Tinh_tien_hang_thang();
            }
            return tong_luong;
        }

         public static double Tong_luong_nam_tat_ca_giang_vien(GiangVien[] danhsach)
        {
            double tong_luong = 0;
            for(int i = 0; i < danhsach.Length; i++){
                tong_luong += danhsach[i].Tinh_tien_hang_nam();
            }
            return tong_luong;
        }
    }


    class VienChuc : CanBo
    {
        double he_so, luong_thang, tien_lam_them;
        int so_gio_lam_them;
        double luong_co_ban = 1800000, don_gia = 30000, tien_phu_cap = 340000;
        public void NhapTT()
        {
            base.NhapTT();
            Console.Write("- Nhap He So: ");
            he_so = double.Parse(Console.ReadLine());
            Console.Write("- Nhap So Gio Lam Them: ");
            so_gio_lam_them = int.Parse(Console.ReadLine());
            luong_thang = he_so * luong_co_ban;
            tien_lam_them = don_gia * so_gio_lam_them;
        }

        public double Tinh_tien_hang_thang()
        {
            return luong_thang + tien_phu_cap + tien_lam_them;
        }

        public double Tinh_tien_hang_nam()
        {
            return 12 * Tinh_tien_hang_thang();
        }
        public void XuatTT()
        {
            base.XuatTT();
            Console.WriteLine(he_so + " | " + so_gio_lam_them + " | " + Tinh_tien_hang_thang() + "đ | " + Tinh_tien_hang_nam() + "đ | ");
        }
         public static double Tong_luong_thang_tat_ca_vien_chuc(VienChuc[] danhsach)
        {
            double tong_luong = 0;
            for(int i = 0; i < danhsach.Length; i++){
                tong_luong += danhsach[i].Tinh_tien_hang_thang();
            }
            return tong_luong;
        }

         public static double Tong_luong_nam_tat_ca_giang_vien(VienChuc[] danhsach)
        {
            double tong_luong = 0;
            for(int i = 0; i < danhsach.Length; i++){
                tong_luong += danhsach[i].Tinh_tien_hang_nam();
            }
            return tong_luong;
        }
        
    }
    class NguoiLaoDong : CanBo
    {
        double luong_hop_dong = 4500000, don_gia = 30000;
        int so_gio;
        double tien_lam_them;

        public void NhapTT()
        {
            base.NhapTT();
            Console.Write("- Nhap so gio lam them: ");
            so_gio = int.Parse(Console.ReadLine());
            tien_lam_them = so_gio * don_gia;
        }

        public double Tinh_tien_hang_thang()
        {
            return luong_hop_dong + tien_lam_them;
        }

        public double Tinh_tien_hang_nam()
        {
            return 12 * Tinh_tien_hang_thang();
        }
        public void XuatTT()
        {
            base.XuatTT();
            Console.WriteLine(so_gio + " | " + Tinh_tien_hang_thang() + "đ | " + Tinh_tien_hang_nam() + "đ |");
        }
         public static double Tong_luong_thang_tat_ca_lao_dong(NguoiLaoDong[] danhsach)
        {
            double tong_luong = 0;
            for(int i = 0; i < danhsach.Length; i++){
                tong_luong += danhsach[i].Tinh_tien_hang_thang();
            }
            return tong_luong;
        }

         public static double Tong_luong_nam_tat_ca_lao_dong(NguoiLaoDong[] danhsach)
        {
            double tong_luong = 0;
            for(int i = 0; i < danhsach.Length; i++){
                tong_luong += danhsach[i].Tinh_tien_hang_nam();
            }
            return tong_luong;
        }
    }
    class Program
    {
        static void Main()
        {
            
            GiangVien[] danh_sach_giang_vien = new GiangVien[1];
            VienChuc[] danh_sach_vien_chuc = new VienChuc[1];
            NguoiLaoDong[] danh_sach_nguoi_lao_dong = new NguoiLaoDong[1];

            danh_sach_giang_vien[0] = new GiangVien();
            danh_sach_vien_chuc[0] = new VienChuc();
            danh_sach_nguoi_lao_dong[0] = new NguoiLaoDong();

            Console.WriteLine("Nguoi 1:");
            danh_sach_giang_vien[0].NhapTT();
            Console.WriteLine("Nguoi 2:");
            danh_sach_vien_chuc[0].NhapTT();
            Console.WriteLine("Nguoi 3:");
            danh_sach_nguoi_lao_dong[0].NhapTT();
            danh_sach_giang_vien[0].XuatTT();
            danh_sach_vien_chuc[0].XuatTT();
            danh_sach_nguoi_lao_dong[0].XuatTT();


            double tong_luong_thang = GiangVien.Tong_luong_thang_tat_ca_giang_vien(danh_sach_giang_vien) 
                                    + VienChuc.Tong_luong_thang_tat_ca_vien_chuc(danh_sach_vien_chuc) 
                                    + NguoiLaoDong.Tong_luong_thang_tat_ca_lao_dong(danh_sach_nguoi_lao_dong);

            double tong_luong_nam = GiangVien.Tong_luong_nam_tat_ca_giang_vien(danh_sach_giang_vien)
                                    + VienChuc.Tong_luong_nam_tat_ca_giang_vien(danh_sach_vien_chuc)
                                    + NguoiLaoDong.Tong_luong_nam_tat_ca_lao_dong(danh_sach_nguoi_lao_dong);

            Console.WriteLine("Tong luong thang cua tat ca nguoi lam viec: " + tong_luong_thang);
            Console.WriteLine("Tong luong nam cua tat ca nguoi lam viec: " + tong_luong_nam );

            
        }
    }
}