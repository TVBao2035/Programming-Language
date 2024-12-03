using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _022101012
{
    internal class Teachers
    {
        public static DataTable getInformation()
        {
            string sql = "select * from giangvien";
            DataTable data = new DataTable();
            data = ConnectDataBase.ExcuteQuery(sql);
            return data;
        }

        public static DataTable getIdTeacherMax()
        {
            string sql = "select top 1 magv from giangvien order by magv desc";
            DataTable data = new DataTable();
            data = ConnectDataBase.ExcuteQuery(sql);
            return data;
        }

        public static void AddTeacher(string id, string name, string gender, string bornDate, string address, string phoneNumber)
        {
            string sql = "insert into GIANGVIEN(MaGV, TenGV, GioiTinh, NgaySinh,DiaChi,SDT) Values('" + id + "', N'" + name + "','" + gender + "','" + bornDate + "',N'" + address + "', '" + phoneNumber + "');";
            ConnectDataBase.ExecuteNonQuery(sql);

        }

        public static void DeleteTeacher(string id)
        {
            string sql = "delete from GIANGVIEN where MaGV = '" + id + "';";
            ConnectDataBase.ExecuteNonQuery(sql);
        }

        public static void UpdateTeacher(string id, string name, string gender, string born, string address, string phoneNumber)
        {
            string sql = "update GIANGVIEN set TenGV='" + name + "', GioiTinh='" + gender + "', NgaySinh='"+born+"', SDT='"+phoneNumber+"', diachi='"+address+"' where magv='"+id+"';";
            ConnectDataBase.ExecuteNonQuery(sql);
        }
    }
}
