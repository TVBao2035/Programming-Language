using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LuyenCoNao_1
{
    internal class ConectDataBase
    {
        private static SqlConnection connect = new SqlConnection();
        public static void Open()
        {
            string sqlServer = @"Data Source=MSI\MSSQLSERVER01;Initial Catalog=QLPHONGTRO;Integrated Security=True";
            connect.ConnectionString = sqlServer;
            if (connect.State == ConnectionState.Closed) connect.Open();
        }

        public static void Close()
        {
            if (connect.State != ConnectionState.Closed) connect.Close();

        }

        public static DataTable ExecuteQuery(string sql)
        {
            Open();
            SqlCommand cd = new SqlCommand(sql, connect);
            SqlDataReader dr = cd.ExecuteReader();
            DataTable data = new DataTable();
            data.Load(dr);
            Close();
            return data;
        }

        public static void ExecuteNonQuery(string sql)
        {
            Open();
            SqlCommand cd = new SqlCommand(sql, connect);
            cd.ExecuteNonQuery();
            Close();
        }
    }
}
