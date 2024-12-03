using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex_20_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
         DataSet ds = new DataSet();
         DataTable nv = new DataTable("NHANVIEN");
         DataTable pb = new DataTable("PHONGBAN");

        public  void createDataSet()
        {
            nv.Columns.Add("MaNV", Type.GetType("System.String"));
            nv.Columns.Add("HoTen", Type.GetType("System.String"));
            nv.Columns.Add("DiaChi", Type.GetType("System.String"));
            nv.Columns.Add("MaPhong", Type.GetType("System.String"));
            nv.Columns.Add("NgaySinh", Type.GetType("System.DateTime"));

            pb.Columns.Add("MaPB", Type.GetType("System.String"));
            pb.Columns.Add("TenPB", Type.GetType("System.String"));

            ds.Tables.Add(pb);
            ds.Tables.Add(nv);
        }

        public void addDataNV(String[,] data)
        {
            for(int i=0; i < data.GetLength(0); i++)
            {
                DataRow r = ds.Tables["NHANVIEN"].NewRow();
                int index = 0;
                foreach(DataColumn dc in ds.Tables["NHANVIEN"].Columns)
                {
                    r[dc.ColumnName] = data[i, index++];
                } 
                nv.Rows.Add(r); 
            }
        }

        public void addDatePB(String[,] data)
        {
            for (int i = 0; i < data.GetLength(0); i++)
            {
                DataRow r = ds.Tables["PHONGBAN"].NewRow();
                int index = 0;
                foreach (DataColumn dc in ds.Tables["PHONGBAN"].Columns)
                {
                    r[dc.ColumnName] = data[i, index++];
                }
                pb.Rows.Add(r);
            }
        }

        public void addData(String[,] nv, String[,] pb)
        {
            addDataNV(nv);
            addDatePB(pb);
        }
        public void display()
        {

            foreach(DataTable dt in ds.Tables)
            {
                foreach(DataRow dr in dt.Rows)
                {
                    foreach(DataColumn dc in dt.Columns)
                    {
                        listView.Items.Add(dc.ColumnName +":"+ dr[dc].ToString()) ;
                    }
                }
            }
        }
   
        private void button1_Click(object sender, EventArgs e)
        {
            String[,] nv =  {
                 { "NV-001", "Nguyen Van A", "TGS", "PB-001", "20/12/2022" },
                 {  "NV-002", "Nguyen Van B", "TGS", "PB-002", "25/12/2022"}
            };
            String[,] pb =  {
                 { "PB-001", "Phong A" },
                 {  "PB-002", "Phong B"}
            };
            createDataSet();
            addData(nv, pb);
              foreach(DataTable i in ds.Tables)
            {
                comboBox1.Items.Add(i.TableName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            display();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.Tables[comboBox1.SelectedIndex];


        }

        private void Form1_Load(object sender, EventArgs e)
        {
          

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
