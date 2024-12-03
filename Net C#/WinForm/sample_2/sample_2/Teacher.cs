using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample_2
{
    internal class Teacher
    {
        public static DataTable displayInformation()
        {
            return ConnectDataBase.ExcuteQuery("select * from GIANGVIEN");
        }

        public static DataTable getMaxID()
        {
            return ConnectDataBase.ExcuteQuery("select top 1 MaGV from GiangVien order by MaGv desc");
        }

        public static void Insert(string id, string name, string gender, string date, string address, string phone)
        {
            ConnectDataBase.ExcuteNonQuery("insert into GIANGVIEN values ('" + id + "', N'" + name + "', '" + gender + "', '" + date + "', '" + address + "', '" + phone + "')");
        }

        public static void Update(string id, string name, string gender, string date, string address, string phone)
        {
            ConnectDataBase.ExcuteNonQuery("update Giangvien set TenGV='" + name + "', GioiTinh='" + gender + "', NgaySinh='" + date + "', DiaChi='" + address + "', SDT='" + phone + "' where MaGV='"+id+"'");
        }

        public static void Delete(string id)
        {
            ConnectDataBase.ExcuteNonQuery("delete from GiangVien where magv='" + id + "'");
        }
    }
}
