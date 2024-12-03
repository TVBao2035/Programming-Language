using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LuyenCoNao_2
{
    internal class Staff
    {
        public static DataTable getAllStaff()
        {
            return ConnectDataBase.ExecuteQuery("select * from NhanVien nv, PhongBan pb where nv.MaPhong = pb.MaPhong");
        }
        public static DataTable getAllDeparter()
        {
            return ConnectDataBase.ExecuteQuery("select * from PhongBan");
        }
        public static DataTable getOneStaff(string id)
        {
            return ConnectDataBase.ExecuteQuery("select * from NhanVien nv, PhongBan pb where nv.MaPhong = pb.MaPhong and nv.MaNV = '"+id+"'");
        }

        public static DataTable sortStaff(string typeSort)
        {
            return ConnectDataBase.ExecuteQuery("select * from NhanVien nv, PhongBan pb where nv.MaPhong = pb.MaPhong order by HoTen "+ typeSort + "");
        }
        public static DataTable getMaxId()
        {
            return ConnectDataBase.ExecuteQuery("select top 1 MaNV from NhanVien order by MaNV desc");
        }
        public static void insertStaff(string id, string name, string born, string address, string departer)
        {
            ConnectDataBase.ExecuteNoneQuery("insert into NhanVien values('"+id+"', '"+name+"', '"+born+"', '"+address+"', '"+departer+"'); ");
        }
        public static void updateStaff(string id, string name, string born, string address, string departer)
        {
            ConnectDataBase.ExecuteNoneQuery("update NhanVien set Hoten='" + name + "', NgaySinh='"+born+"', DiaChi ='" + address +"', MaPhong='"+departer+"' where MaNV ='" + id + "'");
        }
        public static void deleteStaff(string id)
        {
            ConnectDataBase.ExecuteNoneQuery("delete NhanVien where MaNV = '" + id + "'");
        }

    }
}
