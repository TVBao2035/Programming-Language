using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Diagnostics;
namespace sample_2
{
    internal class ConnectDataBase
    {
        private static SqlConnection sqlConnect = new SqlConnection();

        public static void OpenDataBase()
        {
            string sqlServer = @"Data Source=MSI\MSSQLSERVER01;Initial Catalog=QLGV1;Integrated Security=True";
            sqlConnect.ConnectionString = sqlServer;

            if (sqlConnect.State == ConnectionState.Closed)
                sqlConnect.Open();
        }

        public static void CloseDataBase()
        {
            if (sqlConnect.State == ConnectionState.Open)
                sqlConnect.Close();
        }

        public static DataTable ExcuteQuery(string sql)
        {
            OpenDataBase();
            SqlCommand cd = new SqlCommand(sql, sqlConnect);
            SqlDataReader dr = cd.ExecuteReader();
            DataTable data = new DataTable();
            data.Load(dr);
            CloseDataBase();
            return data;
        }

        public static void ExcuteNonQuery(string sql)
        {
            OpenDataBase();
            SqlCommand cd = new SqlCommand(sql, sqlConnect);
            cd.ExecuteNonQuery();
            CloseDataBase();
        }
    }
}
