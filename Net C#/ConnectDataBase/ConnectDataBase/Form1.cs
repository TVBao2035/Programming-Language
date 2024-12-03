using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectDataBase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection connect = new SqlConnection(@"Data Source=MSI\MSSQLSERVER01;Initial Catalog=QUANLYNHANVIEN;Integrated Security=True");
        DataSet ds = new DataSet();

        public DataTable ExuceQuery(string sql)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, connect);
            da.Fill(dt);
            return dt;
        }
        public void ExuceNonQuery(string sql)
        {
            try
            {
                connect.Open();
                SqlCommand cm = new SqlCommand(sql, connect);
                cm.ExecuteNonQuery();
                connect.Close();
              
                dataGridView1.DataSource = ExuceQuery($"Select * From {comboBox1.SelectedItem.ToString()}");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox6.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
        public void AddTable(String TableName)
        {
            DataTable dt = new DataTable(TableName);
            SqlDataAdapter da = new SqlDataAdapter($"Select * From {TableName}", connect);
            da.Fill(dt);
            ds.Tables.Add(dt);
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void CreateDataSet()
        {
            String[] listTableName = new String[] { "NHANVIEN", "PHANCONG", "PHONGBAN", "VITRIVL" };
            foreach (String name in listTableName)
            {
                AddTable(name);
            }
            foreach (DataTable dt in ds.Tables)
            {
                comboBox1.Items.Add(dt.TableName);
            }
            MessageBox.Show("CONNECT DATABASE SUCCESS");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            foreach (DataTable dt in ds.Tables)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    foreach (DataColumn dc in dt.Columns)
                    {
                        listBox1.Items.Add(dr[dc]);
                    }
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = $"Select * From {comboBox1.SelectedItem.ToString()}";
            dataGridView1.DataSource = ExuceQuery(sql);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CreateDataSet();
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            textBox1.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
            textBox6.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.Rows[index].Cells[4].Value.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = $"insert NHANVIEN values(N'{textBox1.Text}', N'{textBox2.Text}', CAST(N'1997-12-07 00:00:00.000' AS DateTime), N'{textBox4.Text}', N'{textBox5.Text}')";
            ExuceNonQuery(sql);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql = $"update NHANVIEN set Hoten=N'{textBox2.Text}', Diachi=N'{textBox4.Text}', MaPhong=N'{textBox5.Text}' where MaNV=N'{textBox1.Text}'";
            ExuceNonQuery(sql);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sql = $"Delete NHANVIEN where MaNV=N'{textBox1.Text}'";
            ExuceNonQuery(sql);
        }
    }
}
