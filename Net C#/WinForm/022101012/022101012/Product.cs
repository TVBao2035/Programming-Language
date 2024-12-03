using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _022101012
{
    internal class Product
    {

        public static DataTable getInformationProduct()
        {
            string sql = "select * from sanpham";
            DataTable data = new DataTable();
            data = ConnectDataBase.ExcuteQuery(sql);
            return data;
        }
    }
}
