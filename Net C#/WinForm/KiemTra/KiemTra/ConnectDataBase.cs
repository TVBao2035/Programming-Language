using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace KiemTra
{
    internal class ConnectDataBase
    {
        private static SqlConnection connect = new SqlConnection();

        public static void OpenDataBase()
        {
            string sqlString = @"Data Source=MSI\MSSQLSERVER01;Initial Catalog=QLPHONGTRO;Integrated Security=True";
            connect.ConnectionString = sqlString;
            if (connect.State == ConnectionState.Closed)
                connect.Open();
        }

        public static void CloseDataBase()
        {
           
            if (connect.State != ConnectionState.Closed)
                connect.Close();
        }

        public static DataTable ExecuteQuery(string sql)
        {
            OpenDataBase();
            SqlCommand cd = new SqlCommand(sql, connect);
            SqlDataReader dr = cd.ExecuteReader();
            DataTable data = new DataTable();
            data.Load(dr);
            CloseDataBase();
            return data;
        }

        public static void ExecuteNonQuery(string sql)
        {
            OpenDataBase();
            SqlCommand cd = new SqlCommand(sql, connect);
            cd.ExecuteNonQuery();
            CloseDataBase();
        }
    }
}
