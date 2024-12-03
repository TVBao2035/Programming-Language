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
using System.Data;
using System.Xml.Linq;
namespace ConnectDataBase
{
    public partial class Form6 : Form
    {
        private SqlConnection connect = new SqlConnection(@"Data Source=MSI\MSSQLSERVER01;Initial Catalog=QuanLyBanHang;Integrated Security=True");
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            displayTV();
        }
        public DataTable ExcueQuery(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, connect);
            DataTable data = new DataTable();
            da.Fill(data);
            return data;

        }

        public void ExcueNoneQuery(string sql)
        {
            connect.Open();
            SqlCommand cm = new SqlCommand(sql, connect);
            cm.ExecuteNonQuery();
            connect.Close();
        }
        public void displayTV()
        {
            string sql = $"select * from DanhMuc";
            DataTable data = ExcueQuery(sql);
            for(int i=0; i<data.Rows.Count; i++)
            {
                treeView1.Nodes.Add(data.Rows[i][1].ToString());
            }
        }
        public void displayLV(string name)
        {
            string sql = $"select * from DanhMuc dm, SanPham sp where sp.MaDanhMuc = dm.MaDanhMuc and TenDanhMuc=N'{name}'";
            DataTable data = ExcueQuery(sql);
            listView1.Items.Clear();
            for(int i=0; i<data.Rows.Count; i++)
            {
                listView1.Items.Add(data.Rows[i]["MaSP"].ToString());
                listView1.Items[i].SubItems.Add(data.Rows[i]["TenSP"].ToString());
                listView1.Items[i].SubItems.Add(data.Rows[i]["Gia"].ToString());
                listView1.Items[i].SubItems.Add(data.Rows[i]["SoLuong"].ToString());
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string name = treeView1.SelectedNode.Text;
            displayLV(name);
            string sql = $"select * from DanhMuc dm, SanPham sp where dm.MaDanhMuc = sp.MaDanhMuc and TenDanhMuc=N'{name}'";
            DataTable data = ExcueQuery(sql);
            for(int i=0; i<data.Rows.Count; i++)
            {
                treeView1.SelectedNode.Nodes.Add(data.Rows[i]["TenSP"].ToString());
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void listView1_Click(object sender, EventArgs e)
        {
           
            string masp = listView1.SelectedItems[0].SubItems[0].Text;
            DataTable data = ExcueQuery($"select * from SanPham where MaSP = {masp}");
            txtMSP.Text = data.Rows[0][0].ToString();
            txtTSP.Text = data.Rows[0][1].ToString();
            txtPrice.Value = decimal.Parse(data.Rows[0]["Gia"].ToString());
            txtAmount.Value = decimal.Parse(data.Rows[0]["Soluong"].ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable data = ExcueQuery("select TOP 1 MaSP from SanPham order by MaSP desc");
            txtMSP.Text = (int.Parse(data.Rows[0][0].ToString()) + 1).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = treeView1.SelectedNode.Text;
            string MaDM = ExcueQuery($"select * from DanhMuc where TenDanhMuc = N'{name}'").Rows[0][0].ToString();
            string sql = $"insert into SanPham (TenSP, Gia, SoLuong, MaDanhMuc) values(N'{txtTSP.Text}', {txtPrice.Value.ToString()}, {txtAmount.Value.ToString()}, {MaDM})";
            ExcueNoneQuery(sql);
            displayLV(name);
        }
        public void resetFileds()
        {
            txtMSP.Text = "";
            txtTSP.Text = "";
            txtPrice.Text = "";
            txtAmount.Text = "";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            resetFileds();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ExcueNoneQuery($"\r\ndelete SanPham where MaSP = {txtMSP.Text}");
            resetFileds();
        }

        private void button5_Click(object sender, EventArgs e)
        {
         //MessageBox.Show(txtMSP.Text + "--" + txtTSP.Text + "--" + txtAmount.Value.ToString()+ "--" + txtPrice.Value.ToString("#"));
         ExcueNoneQuery($"update SanPham set TenSP=N'{txtTSP.Text}', SoLuong= {txtAmount.Value.ToString()}, Gia={txtPrice.Value.ToString("#")} where MaSP= {txtMSP.Text}");
            string name = treeView1.SelectedNode.Text;
            displayLV(name);
        }
    }
}
