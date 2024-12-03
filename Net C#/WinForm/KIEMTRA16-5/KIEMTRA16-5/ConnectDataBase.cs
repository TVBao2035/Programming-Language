using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace KIEMTRA16_5
{
    internal class ConnectDataBase
    {
        private static SqlConnection connect = new SqlConnection();

        public static void open()
        {
            string sqlserver = @"";
            connect.ConnectionString = sqlserver;
            if (connect.State == ConnectionState.Closed)
                connect.Open();
        }
        public static void close()
        {
          
            if (connect.State != ConnectionState.Closed)
                connect.Close();
        }

        public static DataTable executeQuery(string sql)
        {
            open();
            SqlCommand cd = new SqlCommand(sql, connect);
            SqlDataReader dr = cd.ExecuteReader();
            DataTable data = new DataTable();
            data.Load(dr);
            close();
            return data;
        }
        public static void executeNonQuery(string sql)
        {
            open();
            SqlCommand cd = new SqlCommand(sql, connect);
            cd.ExecuteNonQuery();
            close();
        }
    }
}
