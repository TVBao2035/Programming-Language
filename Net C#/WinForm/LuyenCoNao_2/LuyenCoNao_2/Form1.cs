using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LuyenCoNao_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public  void displayStaffOnListView(DataTable list)
        {
            int length = list.Rows.Count;
            listStaff.Items.Clear();
            for(int i=0; i<length; i++)
            {
                listStaff.Items.Add(list.Rows[i]["MaNV"].ToString());
                listStaff.Items[i].SubItems.Add(list.Rows[i]["HoTen"].ToString());
                listStaff.Items[i].SubItems.Add(list.Rows[i]["NgaySinh"].ToString());
                listStaff.Items[i].SubItems.Add(list.Rows[i]["DiaChi"].ToString());
                listStaff.Items[i].SubItems.Add(list.Rows[i]["MaPhong"].ToString());

            }
        }
        public void displayDeparter()
        {
            DataTable data = Staff.getAllDeparter();
            comboDepaterment.DataSource = data;
            comboDepaterment.DisplayMember = "TenPhong";
            comboDepaterment.ValueMember = "MaPhong";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            displayStaffOnListView(Staff.getAllStaff());
            displayDeparter();
        }

        private void listStaff_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listStaff.SelectedItems.Count != 0)
            {
                DataTable data = Staff.getOneStaff(listStaff.SelectedItems[0].SubItems[0].Text);
                txtId.Text = data.Rows[0]["MaNV"].ToString();
                txtName.Text = data.Rows[0]["HoTen"].ToString();
                dateBorn.Text = data.Rows[0]["NgaySinh"].ToString();
                txtAddress.Text = data.Rows[0]["DiaChi"].ToString();
                comboDepaterment.Text = data.Rows[0]["TenPhong"].ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string typeSort="";
            if (radioASC.Checked) typeSort = "ASC";
            else if (radioDESC.Checked) typeSort = "DESC";
            displayStaffOnListView(Staff.sortStaff(typeSort));
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            clear();
            string maxId = Staff.getMaxId().Rows[0][0].ToString();
            maxId = "NV" + (int.Parse(maxId.Substring(2, maxId.Length - 2)) + 1).ToString("000");
            txtId.Text = maxId;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Staff.insertStaff(txtId.Text, txtName.Text, dateBorn.Value.ToString("MM/dd/yyyy"), txtAddress.Text, comboDepaterment.SelectedValue.ToString());
            displayStaffOnListView(Staff.getAllStaff());
            clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Staff.deleteStaff(txtId.Text);
            displayStaffOnListView(Staff.getAllStaff());
            clear();

        }
        public void clear()
        {
            txtId.Text = "";
            txtAddress.Text = "";
            txtName.Text = "";
            comboDepaterment.Text = "";
            dateBorn.Text = "";
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Staff.updateStaff(txtId.Text, txtName.Text, dateBorn.Value.ToString("MM/dd/yyyy"), txtAddress.Text, comboDepaterment.SelectedValue.ToString());
            displayStaffOnListView(Staff.getAllStaff());
            clear();
        }
    }
}
