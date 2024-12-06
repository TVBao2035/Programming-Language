using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
namespace report
{
    internal class DataBase
    {
        SqlConnection connect = new SqlConnection(@"Data Source=MSI\MSSQLSERVER01;Initial Catalog=QuanLyThoiTrang;Integrated Security=True");

        public DataTable ExecuteQuery(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, connect);
            DataTable data = new DataTable();
            da.Fill(data);
            return data;
        }

       
    }
}
