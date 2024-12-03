using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;
namespace ConnectDataBase
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        SqlConnection connect = new SqlConnection(@"Data Source=MSI\MSSQLSERVER01;Initial Catalog=QuanLySinhVien;Integrated Security=True");
        BindingManagerBase bmb;
        DataTable listStudents = new DataTable();
        private void Form5_Load(object sender, EventArgs e)
        {
            displayOnComboBox();
        }

        public void displayOnComboBox()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter($"select * from Lop", connect);
                DataTable dt = new DataTable();
                da.Fill(dt);

                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "TenLop";
                comboBox1.ValueMember = "MaLop";
            }
            catch(Exception ex)
            {
                MessageBox.Show("Dau Vao Khong Hop Le " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue.ToString() == "System.Data.DataRowView" ) return;
            string sql = $"select * from Lop l, SINHVIEN sv where sv.MaLop = l.MaLop and l.MaLop = '{comboBox1.SelectedValue}' ";
            SqlDataAdapter da = new SqlDataAdapter(sql, connect);
            listStudents = new DataTable();
            da.Fill(listStudents);
            bmb = this.BindingContext[listStudents];
            displayCurrentStudent();
            
         
        }

        public void displayCurrentStudent()
        {
            int postion = bmb.Position;
            if(postion == 0)
            {
                button2.Enabled = false;
                button3.Enabled = true;
            }
             
            if(postion > 0 && postion < listStudents.Rows.Count-1)
            {
                button2.Enabled = true;
                button3.Enabled = true;
            }
            if(postion == listStudents.Rows.Count-1 )
            {
                button2.Enabled = true;
                button3.Enabled = false;
            }

            if(listStudents.Rows.Count == 1)
            {
                button2.Enabled = false;
                button3.Enabled = false;
            }
         // MessageBox.Show((listStudents.Rows.Count-1).ToString() + "+++" + postion.ToString());
            txtId.Text = listStudents.Rows[postion]["MaSV"].ToString();
            txtName.Text = listStudents.Rows[postion]["TenSV"].ToString();
            txtBorn.Text = listStudents.Rows[postion]["NgaySinh"].ToString();
            txtPhai.Text = listStudents.Rows[postion]["Phai"].ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (bmb.Position > 0)
            {
                bmb.Position--;
                displayCurrentStudent();
            }
            

          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bmb.Position = listStudents.Rows.Count-1;
            displayCurrentStudent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(bmb.Position < listStudents.Rows.Count - 1)
            {
                bmb.Position++; 
                
                displayCurrentStudent();
            }
           

         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bmb.Position = 0;
            displayCurrentStudent();
        }
    }
}
