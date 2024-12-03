using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex_20_9
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet();
        DataTable cv = new DataTable("CONGVIEC");
        DataTable nv = new DataTable("NHANVIEN");
        DataTable pc = new DataTable("PHANCONG");
        private void Form3_Load(object sender, EventArgs e)
        {
            createDataSet();
            AddData();
            DisplayNVData(nv);
        }
        

        public void createDataSet()
        {
            nv.Columns.Add("MaNV", Type.GetType("System.String"));
            nv.Columns.Add("HoTen", Type.GetType("System.String"));
            nv.Columns.Add("Phai", Type.GetType("System.Boolean"));
            nv.Columns.Add("HSLuong", Type.GetType("System.String"));
            nv.Columns.Add("NgaySinh", Type.GetType("System.String"));
            nv.Columns.Add("NoiSinh", Type.GetType("System.String"));

            cv.Columns.Add("MaCV", Type.GetType("System.String"));
            cv.Columns.Add("TenCV", Type.GetType("System.String"));
            cv.Columns.Add("DonGia", Type.GetType("System.String"));

            pc.Columns.Add("MaNV", Type.GetType("System.String"));
            pc.Columns.Add("MaCV", Type.GetType("System.String"));
            pc.Columns.Add("KLCV", Type.GetType("System.String"));


            ds.Tables.Add(nv);
            ds.Tables.Add(cv);
            ds.Tables.Add(pc);
        }
        public void AutoAddData(String[,] data, String TableName, DataTable dt)
        {
            for(int i=0; i< data.GetLength(0); i++)
            {
                int index = 0;
                DataRow dr = ds.Tables[TableName].NewRow();
                foreach(DataColumn dc in ds.Tables[TableName].Columns)
                {
                    dr[dc.ColumnName] = data[i, index++];
                }
                dt.Rows.Add(dr);
            }

        }
        public void AddData()
        {
            String[,] nvData =
            {
                {"A001", "Tran Thi Nhung", "False", "2000", "12/12/1982", "TienGiang"},
                {"A002", "Ho Thi Lan", "False", "1000", "12/12/1980", "Ben Tre"},
                {"A003", "Nguyen Lan Chi", "False", "1300", "12/2/1981", "Vinh Long"},
                {"A004", "Tran Thanh Sang", "True", "1500", "5/6/1982", "TienGiang"},
                {"A005", "Tran Xuan Thu", "True", "1200", "12/12/1982", "Tra Vinh"},

            };
            String[,] cvData =
            {
                {"BV", "Bao Ve", "5000"},
                {"CM", "Cao mu", "3000"},
                {"HC", "Hanh Chinh", "7000"},
                {"QL", "Quan ly", "10000"},
                {"TC", "Cham soc cay", "3000"},
            };
            String[,] pcData =
            {
                {"A001", "BV", "10"},
                {"A001", "CM", "20"},
                {"A002", "CM", "15"},
                {"A002", "QL", "2"},
                {"A004", "BV", "10"},
                {"A004", "QL", "3"},
                {"A005", "HC", "10"},
            };

            AutoAddData(nvData, "NHANVIEN", nv);
            AutoAddData(cvData, "CONGVIEC", cv);
            AutoAddData(pcData, "PHANCONG", pc);
        }
        public void DisplayNVData(DataTable dt) 
        {

            for(int i=0; i<dt.Rows.Count; i++)
            {
                listView1.Items.Add(dt.Rows[i]["MaNV"].ToString());
                listView1.Items[i].SubItems.Add(dt.Rows[i]["HoTen"].ToString());
                String gender = "Nam";
                if(dt.Rows[i]["Phai"].ToString() == "False")
                {
                    gender = "Nu";
                }
                listView1.Items[i].SubItems.Add(gender);
                listView1.Items[i].SubItems.Add(dt.Rows[i]["HSLuong"].ToString());
                listView1.Items[i].SubItems.Add(dt.Rows[i]["NgaySinh"].ToString());
                listView1.Items[i].SubItems.Add(dt.Rows[i]["NoiSinh"].ToString());

            }
           
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            textBox1.Text = listView1.SelectedItems[0].SubItems[0].Text;
            textBox2.Text = listView1.SelectedItems[0].SubItems[1].Text;
            if(listView1.SelectedItems[0].SubItems[2].Text == "Nam")
            {
                radioButton2.Checked = true;
                radioButton1.Checked = false;
            }
            else
            {
                radioButton1.Checked = true;
                radioButton2.Checked = false;

            }
            numericUpDown1.Value = decimal.Parse(listView1.SelectedItems[0].SubItems[3].Text)/1000;
            dateTimePicker1.Text = listView1.SelectedItems[0].SubItems[4].Text;
            textBox3.Text = listView1.SelectedItems[0].SubItems[5].Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }
    }
}
