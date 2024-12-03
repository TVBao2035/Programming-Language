using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace KiemTra
{
    internal class ControllRooms
    {

        public static DataTable getAddressAllRoom()
        {
            return ConnectDataBase.ExecuteQuery("select * from PHONGTRO");
        }

        public static DataTable getAllInforRoom(string idRoom)
        {
            return ConnectDataBase.ExecuteQuery("select * from PHONGTRO pt, KHUVUC kv where pt.IDMaKV =kv.IdMaKV and IdMaPT='"+idRoom+"'");
        }
        public static DataTable getAllInforTicket(string idRoom)
        {
            return ConnectDataBase.ExecuteQuery("select * from PHONGTRO pt, PHIEUTHUE pthue, KHACHHANG kh where pt.IdMaPT = pthue.IdMaPT and pthue.IdMaKH = kh.IdMaKH and pt.IdMaPT = '"+idRoom+"'; ");
        }
        public static DataTable getMaxIdRoom()
        {
            return ConnectDataBase.ExecuteQuery("select top 1 idMaPT from PHONGTRO order by IdMaPT desc");
        }
        public static DataTable getAreaName()
        {
            return ConnectDataBase.ExecuteQuery("select * from KHUVUC");
        }
        public static void InsertRoom(string idRoom, string address, string idArea)
        {
            ConnectDataBase.ExecuteNonQuery("INSERT [dbo].[PHONGTRO] ([IdMaPT], [Diachi], [Ghichu], [IDMaKV]) VALUES (N'"+idRoom+"', N'"+address+"', NULL, N'"+idArea+"')");
        }

        public static void DeleteRoom(string idRoom)
        {
            ConnectDataBase.ExecuteNonQuery("delete PHONGTRO where IdMaPT = '"+idRoom+"'");
        }

        public static void UpdateRoom(string idRoom, string address, string idArea)
        {
            ConnectDataBase.ExecuteNonQuery("update PHONGTRO set Diachi='"+address+"', IDMaKV='"+idArea+"' where IdMaPT='"+idRoom+"'");
        }
    }
}
