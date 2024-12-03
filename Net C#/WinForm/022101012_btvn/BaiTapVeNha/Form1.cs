using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapVeNha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listFoods.Items.Add("Thit Kho Trung");
            listFoods.Items.Add("Tom Rang Thit");
            listFoods.Items.Add("Ca Sot Ca");
            listFoods.Items.Add("Muc Xao");
            listFoods.Items.Add("Canh Chua");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            listOrder.Items.Add(listFoods.SelectedItem);
        }

        private void btnActive_Click(object sender, EventArgs e)
        {
            int orderCount = listOrder.Items.Count;
            amountOrder.Text = "Tong so mon an la: " + orderCount.ToString();
            string result = "Ho ten: " + txtName.Text + "\r\nNgay dat: " + txtDate.Text+"\r\nMon an duoc chon: ";
            for(int i=0; i < orderCount; i++)
            {
                result += listOrder.Items[i].ToString();
                if (i != orderCount - 1) result += ", ";
            }
            displayResult.Text = result;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult notification = MessageBox.Show("Do you want to clear all your information?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(notification == DialogResult.Yes)
            {
                listOrder.Items.Clear();
                displayResult.Text = "";
                txtName.Text = "";
                amountOrder.Text = "";
            }   
         
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
