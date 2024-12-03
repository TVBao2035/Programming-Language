using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data.SqlTypes;
namespace _022101012
{
    internal class ConnectDataBase
    {
        private static SqlConnection sqlCon = new SqlConnection();

        public static void OpenConnect()
        {
            string sql = @"Data Source=MSI\MSSQLSERVER01;Initial Catalog=QLGV1;Integrated Security=True";

            sqlCon.ConnectionString = sql;

            if(sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }
        }

        public static void CloseConnect()
        {
            if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
        }

        public static DataTable ExcuteQuery(string sql)
        {
            OpenConnect();
            SqlCommand cd = new SqlCommand(sql, sqlCon);
            SqlDataReader dr = cd.ExecuteReader();
            DataTable data = new DataTable();
            data.Load(dr);
            CloseConnect();
            return data;
        }

        public static void ExecuteNonQuery(string sql)
        {
            OpenConnect();
            SqlCommand cd = new SqlCommand(sql, sqlCon);
            cd.ExecuteNonQuery();
            CloseConnect( );
        }
   
    }
}
