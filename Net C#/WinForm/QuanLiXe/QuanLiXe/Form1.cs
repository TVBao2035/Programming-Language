using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiXe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void displayIdCar()
        {
            DataTable data = new DataTable();
            data = Xe.LayBienSoXe();
            listCar.DataSource = data;
            listCar.DisplayMember = "Bienso";
            listCar.ValueMember = "Bienso";
        }

        public void displayInforCustomer()
        {
            listCustomer.Items.Clear();
            DataTable data = new DataTable();
            data = Xe.LayThongTinKhachHang(listCar.SelectedValue.ToString());
            int length = data.Rows.Count;
            for(int i=0; i<length; i++)
            {
                listCustomer.Items.Add(data.Rows[i][0].ToString());
                listCustomer.Items[i].SubItems.Add(data.Rows[i][1].ToString());
                listCustomer.Items[i].SubItems.Add(data.Rows[i][2].ToString());
                listCustomer.Items[i].SubItems.Add(data.Rows[i][3].ToString());
            }
        }
        public void XoaDuLieuNhap()
        {
            textIdCar.Text = "";
            dateEndCar.Text = "";
            comboCustomers.Text = "";
        }

        private void listCar_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable data = new DataTable();
            data = Xe.LayMotBienSoXe(listCar.SelectedValue.ToString());
            textIdCar.Text = data.Rows[0]["Bienso"].ToString();
            dateEndCar.Text = data.Rows[0]["Ngayhethan"].ToString();
            comboCustomers.Text = data.Rows[0]["HoTen"].ToString();

            displayInforCustomer();
        }

        public void HienThiKhachHang()
        {
            DataTable data = new DataTable();
            data = Xe.LayTatCaKhachHang();
            comboCustomers.DataSource = data;
            comboCustomers.DisplayMember = "HoTen";
            comboCustomers.ValueMember = "MaKH";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            displayIdCar();
            HienThiKhachHang();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Xe.ThemThongTinXe(textIdCar.Text, dateEndCar.Value.ToString("MM/dd/yyyy"), comboCustomers.SelectedValue.ToString());
            displayIdCar();
            XoaDuLieuNhap();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Xe.XoaXe(textIdCar.Text);
            displayIdCar();
            XoaDuLieuNhap();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Xe.CapNhatXe(textIdCar.Text, dateEndCar.Value.ToString("MM/dd/yyyy"), comboCustomers.SelectedValue.ToString());
            displayIdCar();
        }
    }
}
