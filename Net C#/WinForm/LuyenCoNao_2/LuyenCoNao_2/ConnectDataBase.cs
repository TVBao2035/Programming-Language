using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace LuyenCoNao_2
{
    internal class ConnectDataBase
    {
        private static SqlConnection connect = new SqlConnection();
        public static void OpenDB()
        {
            string sqlServer = @"Data Source=MSI\MSSQLSERVER01;Initial Catalog=QLNV;Integrated Security=True";
            connect.ConnectionString = sqlServer;
            if (connect.State == ConnectionState.Closed) connect.Open();
        }
        public static void CloseDB()
        {
          
            if (connect.State != ConnectionState.Closed) connect.Close();
        }

        public static DataTable ExecuteQuery(string sql)
        {
            OpenDB();
            SqlCommand cd = new SqlCommand(sql, connect);
            SqlDataReader dr = cd.ExecuteReader();
            DataTable data = new DataTable();
            data.Load(dr);
            CloseDB();
            return data;
        }
        public static void ExecuteNoneQuery(string sql)
        {
            OpenDB();
            SqlCommand cd = new SqlCommand(sql, connect);
            cd.ExecuteNonQuery();
            CloseDB();
          
        }
    }
}
