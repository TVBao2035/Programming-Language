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

namespace ConnectDataBase
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection connect = new SqlConnection(@"Data Source=MSI\MSSQLSERVER01;Initial Catalog=QuanLySinhVien;Integrated Security=True");

        private void Form3_Load(object sender, EventArgs e)
        {
            AddDataComboBox();
            for(int i=1; i<32; i++)
            {
                comboDay.Items.Add(i.ToString("0#"));
            }
            for(int i=1; i<13; i++)
            {
                comboMonth.Items.Add(i.ToString("0#"));
            }
        }

        public void AddDataComboBox()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * from Lop", connect);
                da.Fill(dt);
                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "TenLop";
                comboBox1.ValueMember = "MaLop";
            }catch(Exception ex)
            {
                MessageBox.Show("Loi He Thong!!!");
            }
        }
        public DataTable QueryDataBase(string sql)
        {
            DataTable dt = new DataTable();
         
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(sql, connect);
                da.Fill(dt);
            }catch(Exception ex)
            {
                MessageBox.Show("Loi He Thong");
            }
            return dt;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = $"Select * From SinhVien where MaLop = '{comboBox1.SelectedValue.ToString()}'";
            DataTable dt = QueryDataBase(sql);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int position = dataGridView1.CurrentRow.Index;
            textId.Text = dataGridView1.Rows[position].Cells["MaSV"].Value.ToString();
            textName.Text = dataGridView1.Rows[position].Cells["TenSV"].Value.ToString();
            textPhone.Text = dataGridView1.Rows[position].Cells["DienThoai"].Value.ToString();
            textYear.Text = DateTime.Parse(dataGridView1.Rows[position].Cells["NgaySinh"].Value.ToString()).ToString("yyyy");
            textAddress.Text = dataGridView1.Rows[position].Cells["DiaChi"].Value.ToString();
            comboDay.Text = DateTime.Parse(dataGridView1.Rows[position].Cells["NgaySinh"].Value.ToString()).ToString("dd");
            comboMonth.Text = DateTime.Parse(dataGridView1.Rows[position].Cells["NgaySinh"].Value.ToString()).ToString("MM");
            checkGender.Checked = Boolean.Parse(dataGridView1.Rows[position].Cells["Phai"].Value.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = $"select * from SINHVIEN sv,  Lop l, KHOA k where sv.MaLop = l.MaLop and  l.MaKhoa = k.MaKhoa   and k.MaKhoa = \r\n(select k.MaKhoa from Khoa k, Lop l where l.MaKhoa = k.MaKhoa and l.MaLop = '{comboBox1.SelectedValue}') Order By MaSV desc";
            DataTable dt = QueryDataBase(sql);
           
            string maxStudentId = dt.Rows[0]["MaSV"].ToString();
            string nameId = maxStudentId.Substring(0, maxStudentId.Length - 2);
            int nextId = int.Parse(maxStudentId.Substring(nameId.Length, maxStudentId.Length - 2)) + 1;
            string newStudentId = nameId + nextId.ToString("0#");
            textId.Text = newStudentId;
            textName.Text = "";
            textPhone.Text = "";
            textYear.Text = "";
            textAddress.Text = "";
            comboDay.Text = "";
            comboMonth.Text = "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string id = textId.Text, name = textName.Text, address = textAddress.Text;
            string classId = comboBox1.SelectedValue.ToString(), phone = textPhone.Text;
            int gender = checkGender.Checked ? 1 : 0;
            string day = comboDay.SelectedItem.ToString(), month = comboMonth.SelectedItem.ToString(), year = textYear.Text;

            string date = $"{month}/{day}/{year}";
            
            try
            {
                string sql = $"INSERT INTO SINHVIEN(MaSV, TenSV, Phai, NgaySinh, DienThoai, DiaChi, MaLop)  values(N'{id}', N'{name}', {gender}, {date}, '{phone}',N'{address}', N'{classId}');";
                SqlCommand cd = new SqlCommand(sql, connect);
                connect.Open();
                cd.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show("Create Student Successfully");
                textId.Text = "";
                textName.Text = "";
                textPhone.Text = "";
                textYear.Text = "";
                textAddress.Text = "";
                comboDay.Text = "";
                comboMonth.Text = "";
                AddDataComboBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Du Lieu Dau Vao Sai {id} - {name} - {address} - {classId} - {phone} - {gender} - {date} - {ex.Message}");
            }

            return;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textId.Text.ToString().Length == 0) return;
            try
            {
                string sql = $"delete SINHVIEN where MaSV='{textId.Text}'";
                SqlCommand cd = new SqlCommand(sql, connect);
                connect.Open();
                cd.ExecuteNonQuery();
                connect.Close();

                MessageBox.Show("Delete Student Successfully");
                textId.Text = "";
                textName.Text = "";
                textPhone.Text = "";
                textYear.Text = "";
                textAddress.Text = "";
                comboDay.Text = "";
                comboMonth.Text = "";
                AddDataComboBox();

            }catch(Exception ex)
            {
                MessageBox.Show($"Delete Failure");
            }
        }
    }
}
