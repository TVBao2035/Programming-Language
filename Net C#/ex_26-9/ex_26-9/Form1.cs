using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex_26_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet();
        DataTable dg = new DataTable("DOCGIA");
        DataTable s = new DataTable("SACH");
        DataTable pm = new DataTable("PHIEUMUON");
        public void createDataSet()
        {
            dg.Columns.Add("MaDG", typeof(string));
            dg.Columns.Add("HoTen", typeof(string));
            dg.Columns.Add("NgaySinh", typeof(DateTime));
            dg.Columns.Add("SoDT", typeof(string));


            s.Columns.Add("MaSach", typeof(string));
            s.Columns.Add("TenSach", typeof(string));
            s.Columns.Add("NhaXB", typeof(string));
            s.Columns.Add("TacGia", typeof(string));

            pm.Columns.Add("SoPM", typeof(string));
            pm.Columns.Add("MaDG", typeof(string));
            pm.Columns.Add("MaSach", typeof(string));
            pm.Columns.Add("NgayMuon", typeof(DateTime));
            pm.Columns.Add("NgayTra", typeof(DateTime));


            ds.Tables.Add(dg);
            ds.Tables.Add(s);
            ds.Tables.Add(pm);
              
         }


        public void autoAddData(String[,] data, DataTable dt)
        {
            for(int i=0; i<data.GetLength(0); i++)
            {
                int index = 0;
                DataRow dr = dt.NewRow();
                foreach (DataColumn dc in dt.Columns) {
                    dr[dc.ColumnName] = data[i, index++];
                }
                dt.Rows.Add(dr);
            }
        }

        public void addData()
        {
            String[,] dgData =
            {
                {"DG001", "Nguyen Hai Thuy Van", "14/09/2005", "0234567212" },
                {"DG002", "Chau Minh Tran", "14/09/2005", "0234567212" },
                {"DG003", "Pham Phu Le", "14/09/2005", "0234567212" },
            };
            String[,] sData =
            {
                {"S0101", "Lam ban voi Bau Troi", "Tre", "" },
                {"S0201", "Mua He Khong ten", "Tre", "Nguyen Nhat Anh" },
                {"S0101", "Mot Doi Nhu Ke Tim Duong", "Lao Dong", "Phan Nhu Truong" },
                {"S0101", "Harry Porter-Ky nhu phu huy", "Lao Dong", "J.K.Rowling" },
                {"S0101", "Hat Giong Tam Hon", "Nhi Dong", "" },

            };
            String[,] pmData =
            {
                {"1", "DG001", "S0101", "14/5/2024", "14/5/2024" },
                {"2", "DG001", "S0201", "14/5/2024", "14/5/2024" },
                {"3", "DG002", "S0102", "14/5/2024", "14/5/2024" },
                {"4", "DG003", "S0103", "14/5/2024", "14/5/2024" },
                {"5", "DG001", "S0201", "14/5/2024", "14/5/2024" },
            };
            autoAddData(dgData, dg);
            autoAddData(sData, s);
            autoAddData(pmData, pm);
        }
        public void display()
        {
            listBox1.Items.Clear();
            foreach(DataTable dt in ds.Tables)
            {
                foreach(DataRow dr in dt.Rows)
                {
                    listBox1.Items.Add("++++++++++++++++++++=\r\n\n");
                    foreach (DataColumn dc in dt.Columns)
                    {
                        listBox1.Items.Add(dc.ColumnName + ":" + dr[dc]);
                    }
              
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            createDataSet();
            addData();
            display();
            foreach(DataTable dt in ds.Tables)
            {
                comboBox1.Items.Add(dt.TableName.ToString());
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int position = comboBox1.SelectedIndex;
            dataGridView1.DataSource = ds.Tables[position];
            label1.Text = $"Table {ds.Tables[position].TableName} Has {ds.Tables[position].Rows.Count} Rows";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int position = dataGridView1.CurrentCell.RowIndex;
            textBox1.Text = dataGridView1.Rows[position].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[position].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[position].Cells[3].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[position].Cells[2].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ds.Tables["DOCGIA"].Rows.Add(textBox1.Text, textBox2.Text, dateTimePicker1.Text, textBox3.Text);
            display();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ds.Tables["DOCGIA"].Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);
            display();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            dateTimePicker1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int position = dataGridView1.CurrentCell.RowIndex;
            ds.Tables["DOCGIA"].Rows[position][0] = textBox1.Text;
            ds.Tables["DOCGIA"].Rows[position][1] = textBox2.Text;
            ds.Tables["DOCGIA"].Rows[position][2] = dateTimePicker1.Value;
            ds.Tables["DOCGIA"].Rows[position][3] = textBox3.Text;
            display();
        }
    }
}
