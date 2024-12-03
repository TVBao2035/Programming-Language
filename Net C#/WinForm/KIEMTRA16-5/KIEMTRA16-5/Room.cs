using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KIEMTRA16_5
{
    internal class Room
    {
        public static DataTable LayDiaChiPhongTro()
        {
            return ConnectDataBase.executeQuery("select Diachi from PHONGTRO");
        }
        public static DataTable LayThongTinChiTietPhongTro(string address)
        {
            return ConnectDataBase.executeQuery("select * from PHONGTRO pt, KHUVUC kv where pt.IDMaKV = kv.IdMaKV and Diachi=N'" + address + "'");
        }
        public static DataTable LayThongTinChiTietThietBi(string RoomId)
        {
            return ConnectDataBase.executeQuery("select * from PHONGTRO pt, THIETBI tbi, TRANGBI tb where pt.IdMaPT=tb.IdMaPT and tb.IdMaTB = tbi.IdMaTB and pt.IdMaPT='" + RoomId + "'");
        }
        public static DataTable LayMaPhongCaoNhat()
        {
            return ConnectDataBase.executeQuery("select top 1 IdMaPT from PHONGTRO order by IdMaPT desc");
        }
        public static DataTable LayTatCaKhuVuc()
        {
            return ConnectDataBase.executeQuery("select * from KHUVUC");
        }
        public static void ThemPhong(string RoomId, string address, string AreaId)
        {
            ConnectDataBase.executeNonQuery("insert into PHONGTRO Values('" + RoomId + "', N'" + address + "', NULL, '" + AreaId + "')");
        }
        public static void XoaPhong(string RoomId)
        {
            ConnectDataBase.executeNonQuery("delete PHONGTRO where IdMaPT='"+RoomId+"'");
        }
        public static void CapNhatPhong(string RoomId, string address, string AreaId)
        {
            ConnectDataBase.executeNonQuery("update PHONGTRO set Diachi=N'"+address+"', IDMaKV='"+AreaId+"' where IdMaPT='"+RoomId+"'");
        }

    }
}
