using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiXe
{
    internal class Xe
    {
        public static DataTable LayBienSoXe()
        {
            return ConnectDataBase.ExecuteQuery("select Bienso from XE");
        }
        public static DataTable LayMotBienSoXe(string idOfCar)
        {
            return ConnectDataBase.ExecuteQuery("select * from XE x, KHACHHANG k where k.MaKH = x.MaKH and Bienso='" + idOfCar+"'");
        }
        public static DataTable LayThongTinKhachHang(string idOfCar)
        {
            return ConnectDataBase.ExecuteQuery("select SoPhieu, kh.MaKH, Hoten, Ngaydk  from KHACHHANG kh, PHIEUDK p where kh.MaKH = p.MaKH and Bienso='"+idOfCar+"'");

        }
        public static void ThemThongTinXe(string id, string date, string idCustomer)
        {
            ConnectDataBase.ExecuteNonQuery("INSERT [dbo].[XE] ([Bienso], [Ngayhethan], [MaKH], [Hinh]) VALUES (N'"+id+"', CAST(N'"+date+"' AS Date), N'"+idCustomer+"', NULL)");
        }
        public static DataTable LayTatCaKhachHang()
        {
            return ConnectDataBase.ExecuteQuery("select MaKH, HoTen from KHACHHANG");
        }

        public static void XoaXe(string idOfCar)
        {
            ConnectDataBase.ExecuteNonQuery("delete from Xe where Bienso='" + idOfCar + "'");
        }
        public static void CapNhatXe(string idOfCar, string date, string makh)
        {
            ConnectDataBase.ExecuteNonQuery("update XE set Ngayhethan='" + date + "', MaKH='" + makh + "' where Bienso='" + idOfCar + "'");
        }
    }
}
