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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection connect = new SqlConnection(@"Data Source=MSI\MSSQLSERVER01;Initial Catalog=QuanLySinhVien;Integrated Security=True");

        private void From2_Load(object sender, EventArgs e)
        {
            AddDataCombobox();


        }

        public void AddDataCombobox()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from Lop", connect);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "TenLop";
            comboBox1.ValueMember = "MaLop"; 
        }

        public DataTable QueryDataBase(string MaLop)
        {
            DataTable dt = new DataTable();
            string sql = $"select * from SINHVIEN where MaLop = '{MaLop}'";
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(sql, connect);
                da.Fill(dt);
            }catch(Exception ex)
            {
                MessageBox.Show("Loi He Thong!!");
            }
            return dt;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = QueryDataBase(comboBox1.SelectedValue.ToString());
            dataGridView1.DataSource = dt;
        }
    }
}
