using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _022101012
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listFood.Items.Add("Trà sữa");
            listFood.Items.Add("Matcha đá xay");
            listFood.Items.Add("Trà đào chanh sả");
            listFood.Items.Add("Cafe latte");
            listFood.Items.Add("Soda việt quốc");
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            listOrder.Items.Add(listFood.SelectedItem);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtSumOrder.Text = "Tông số nước uống đã chọn là: " + listOrder.Items.Count.ToString();
            txtDisplay.Text = "Họ tên: " + txtName.Text + "\r\nNgày đặt: " + txtDate.Text + "\r\nNước uống đã chọn: ";
            for(int i=0; i<listOrder.Items.Count; i++)
            {
                txtDisplay.Text += listOrder.Items[i].ToString();
                if(i != listOrder.Items.Count - 1)
                {
                    txtDisplay.Text += ", ";
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn chắc chắn muốn bỏ các lựa chọn này?", "Thông Báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(kq == DialogResult.Yes)
            {
                txtName.Text = "";
                txtDate.Text = "01/01/1753";
                txtSumOrder.Text = "";
                txtDisplay.Text = "";
                listOrder.Items.Clear();
            }
          
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listFood_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
