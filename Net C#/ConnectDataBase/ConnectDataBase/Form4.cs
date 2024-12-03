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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        SqlConnection connect = new SqlConnection(@"Data Source=MSI\MSSQLSERVER01;Initial Catalog=QuanLyChamCong;Integrated Security=True");
        private void Form4_Load(object sender, EventArgs e)
        {
            displayDataOnListView();
        }

        public void displayDataOnListView()
        {
            try
            {
                string sql = $"select * from NHANVIEN";
                SqlDataAdapter da = new SqlDataAdapter(sql, connect);
                DataTable dt = new DataTable();
                da.Fill(dt);
                listView1.Items.Clear();
               for(int i = 0; i < dt.Rows.Count; i++)
                {
                    string gender = "Nam";
                    if (dt.Rows[i]["Phai"].ToString() == "False") gender = "Nu";
                    listView1.Items.Add(dt.Rows[i]["MaNV"].ToString());
                    listView1.Items[i].SubItems.Add(dt.Rows[i]["HoTen"].ToString());
                    listView1.Items[i].SubItems.Add(gender);
                    listView1.Items[i].SubItems.Add(dt.Rows[i]["HSLuong"].ToString());
                    listView1.Items[i].SubItems.Add(dt.Rows[i]["NgaySinh"].ToString());
                    listView1.Items[i].SubItems.Add(dt.Rows[i]["NoiSinh"].ToString());
                }

            }catch(Exception ex)
            {
                MessageBox.Show("Error DataBase");
            }
            return;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            textId.Text = listView1.SelectedItems[0].SubItems[0].Text;
            textName.Text = listView1.SelectedItems[0].SubItems[1].Text;
            textAddress.Text = listView1.SelectedItems[0].SubItems[5].Text;
            numericSalary.Value = decimal.Parse(listView1.SelectedItems[0].SubItems[3].Text);
            dateBorn.Text = listView1.SelectedItems[0].SubItems[4].Text;
            if(listView1.SelectedItems[0].SubItems[2].Text == "Nam")
            {
                radioButton1.Checked = true;
            }
            else
            {
                radioButton2.Checked = true;
            }
        }
        public void resetFields()
        {
            textId.Text = "";
            textName.Text = "";
            textAddress.Text = "";
            numericSalary.Value = 0;
            dateBorn.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string id = textId.Text, name = textName.Text, born = dateBorn.Value.ToString("MM/dd/yyyy"), address = textAddress.Text;
            int gender = radioButton1.Checked ? 1 : 0;
            string salary = numericSalary.Value.ToString("#,##");
            try
            {
                string sql = $"insert into NHANVIEN(MaNV, HoTen, Phai, HSLuong, NgaySinh, NoiSinh) Values('{id}', N'{name}', {gender}, {salary}, {born}, N'{address}');";
                SqlCommand cd = new SqlCommand(sql, connect);
                connect.Open();
                cd.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show("Tao Nhan Vien Thanh Cong");
                resetFields();
                displayDataOnListView();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Loi DataBase" + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string id = textId.Text, name = textName.Text, born = dateBorn.Value.ToString("MM/dd/yyyy"), address = textAddress.Text;
            int gender = radioButton1.Checked ? 1 : 0;
            string salary = numericSalary.Value.ToString("#,##");
            try
            {
                string sql = $"update NHANVIEN set HoTen=N'{name}', Phai={gender}, HSLuong={salary}, NoiSinh=N'{address}', NgaySinh={born} where MaNV='{id}';";
                SqlCommand cd = new SqlCommand(sql, connect);
                connect.Open();
                cd.ExecuteNonQuery();
                connect.Close();
                displayDataOnListView();
                resetFields();
                MessageBox.Show("Cap Nhat Nhan Vien Thanh Cong");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Loi DataBase" + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = $"delete NHANVIEN where MaNV='{textId.Text}';";
                SqlCommand cd = new SqlCommand(sql, connect);
                connect.Open();
                cd.ExecuteNonQuery();
                connect.Close();
                displayDataOnListView();
                resetFields();
                MessageBox.Show("Xoa Nhan Vien Thanh Cong");

            }
            catch(Exception ex)
            {
                MessageBox.Show("Loi DataBase" + ex.Message);
            }
        }
    }
}
