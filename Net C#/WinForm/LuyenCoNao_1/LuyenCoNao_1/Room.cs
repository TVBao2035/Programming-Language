using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LuyenCoNao_1
{
    internal class Room
    {
        public static DataTable getAllRoomAddress()
        {
            return ConectDataBase.ExecuteQuery("select Diachi from PHONGTRO ");
        }
        public static DataTable getInformationByAddress(string address)
        {
            return ConectDataBase.ExecuteQuery("select * from PHONGTRO, KHUVUC where DiaChi= N'" + address+ "' and PHONGTRO.IDMaKV = KHUVUC.IdMaKV");
        }
        public static DataTable getInformationRoomAndCustomer(string id)
        {
            return ConectDataBase.ExecuteQuery("select * from PHONGTRO pt, PHIEUTHUE th, KHACHHANG kh where pt.IdMaPT=th.IdMaPT and th.IdMaKH=kh.IdMaKH and pt.IdMaPT =N'"+id+"'");
        }
        public static DataTable getAllAreaName()
        {
            return ConectDataBase.ExecuteQuery("select * from KHUVUC");
        }

        public static DataTable getMaxRoomId() 
        {
            return ConectDataBase.ExecuteQuery("select top 1 IdMaPT from PHONGTRO order by IdMaPT desc");
        }
        public static void insertRoom(string roomId, string name, string areaId)
        {
            ConectDataBase.ExecuteNonQuery("insert PHONGTRO values(N'"+roomId+"', N'"+name+"', NULL, N'"+areaId+"')");
        }

        public static void updateRoom(string roomId, string name, string areaId)
        {
            ConectDataBase.ExecuteNonQuery("update PHONGTRO set Diachi='" + name + "', IDMaKV='" + areaId + "' where IdMaPT='" + roomId + "'");
        }
        public static void deleteRoom(string roomId)
        {
            ConectDataBase.ExecuteNonQuery("delete PHONGTRO where IdMaPT='"+roomId+"'");
        }
    }
}
