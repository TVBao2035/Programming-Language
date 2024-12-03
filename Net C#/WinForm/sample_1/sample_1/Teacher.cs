using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample_1
{
    internal class Teacher
    {
        public static DataTable getInformation()
        {
            string sql = "select * from giangvien";
            return ConnectDataBase.ExecuteQuery(sql);
            
        }

        public static DataTable getIdMax()
        {
            string sql = "select top 1 magv from giangvien order by magv desc";
            return ConnectDataBase.ExecuteQuery(sql);
        }

        public static void InsertData(string id, string name, string gender, string bornDate, string address, string phoneNumber)
        {
            string sql = "insert into giangvien(MaGV, TenGV, GioiTinh, NgaySinh,DiaChi,SDT) values('" + id + "','" + name + "', '" + gender + "', '" + bornDate + "', '" + address + "','" + phoneNumber + "')";
            ConnectDataBase.ExecuteNonQuery(sql);
        }

        public static void UpdateData(string id, string name, string gender, string bornDate, string address, string phoneNumber)
        {
            string sql = "update giangvien set TenGV='" + name + "', GioiTinh='" + gender + "', NgaySinh='" + bornDate + "', diachi='" + address + "', SDT='" + phoneNumber + "' where MaGV='" + id + "'";
            ConnectDataBase.ExecuteNonQuery(sql);
        }

        public static void DeleteData(string id)
        {
            string sql = "delete from giangvien where MaGV='" + id + "'";
            ConnectDataBase.ExecuteNonQuery(sql);
        }
    }
}
