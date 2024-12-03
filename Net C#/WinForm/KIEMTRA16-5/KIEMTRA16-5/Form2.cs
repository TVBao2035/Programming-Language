using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KIEMTRA16_5
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public void HienThiDiaChiPhong()
        {
            DanhSachDiaChi.Items.Clear();
            DataTable data = new DataTable();
            data = Room.LayDiaChiPhongTro();
            int length = data.Rows.Count;
            for(int i=0; i<length; i++)
            {
                DanhSachDiaChi.Items.Add(data.Rows[i]["Diachi"]);
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            HienThiDiaChiPhong();
            HienThiKhuVuc();
        }
        public void HienThiThongTinThietBi(string RoomId)
        {
            DanhSachThietBi.Items.Clear();
            DataTable data = new DataTable();
            data = Room.LayThongTinChiTietThietBi(RoomId);
            int length = data.Rows.Count;
            for(int i=0; i<length; i++)
            {
                DanhSachThietBi.Items.Add(data.Rows[i]["IdMaTB"].ToString());
                DanhSachThietBi.Items[i].SubItems.Add(data.Rows[i]["TenTB"].ToString());
                DanhSachThietBi.Items[i].SubItems.Add(data.Rows[i]["Soluong"].ToString());
                DanhSachThietBi.Items[i].SubItems.Add(data.Rows[i]["Trigia"].ToString());
            }
        }

        public void HienThiKhuVuc()
        {
            DataTable data = new DataTable();
            data = Room.LayTatCaKhuVuc();
            listArea.DataSource = data;
            listArea.DisplayMember = "TenKV";
            listArea.ValueMember = "IdMaKV";
        }
        private void DanhSachDiaChi_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable data = new DataTable();
            data = Room.LayThongTinChiTietPhongTro(DanhSachDiaChi.SelectedItem.ToString());
            txtRoomId.Text = data.Rows[0]["IdMaPT"].ToString();
            txtRoomAddress.Text = data.Rows[0]["Diachi"].ToString();
            listArea.Text = data.Rows[0]["TenKV"].ToString();
            HienThiThongTinThietBi(data.Rows[0]["IdMaPT"].ToString());
            string indexString = data.Rows[0]["IdMaPT"].ToString();
            int indexOfPhoto = int.Parse(indexString.Substring(2, indexString.Length - 2))%10;
            pictureRoom.Load("PT00" + indexOfPhoto.ToString() + ".jpg");

        }
        public void XoaDuLieuNhap()
        {
            txtRoomId.Text = "";
            txtRoomAddress.Text = "";
            listArea.Text = "";
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            XoaDuLieuNhap();
            string MaPhong = Room.LayMaPhongCaoNhat().Rows[0][0].ToString();
            MaPhong = "PT" + (int.Parse(MaPhong.Substring(2, MaPhong.Length - 2))+1).ToString("000");
            txtRoomId.Text = MaPhong;
        }

        private void btnPush_Click(object sender, EventArgs e)
        {
            Room.ThemPhong(txtRoomId.Text, txtRoomAddress.Text, listArea.SelectedValue.ToString());
            HienThiDiaChiPhong();
            XoaDuLieuNhap();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Room.XoaPhong(txtRoomId.Text);
            HienThiDiaChiPhong();
            XoaDuLieuNhap();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Room.CapNhatPhong(txtRoomId.Text, txtRoomAddress.Text, listArea.SelectedValue.ToString());
            HienThiDiaChiPhong();
            XoaDuLieuNhap();
        }
    }
}
