using CrystalDecisions.CrystalReports.Engine;
using report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace report_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataBase db = new DataBase();
        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = db.ExecuteQuery($"select dh.MaDonHang, Ngaydat, HoTenKH, sp.MaSP, TenSP, ctdh.SoLuong, ctdh.Gia, (ctdh.SoLuong * ctdh.Gia) as ThanhTien from DonHang dh, ChiTietDonHang ctdh, SanPham sp, KhachHang kh where kh.MaKH = dh.MaKH and ctdh.MaSP = sp.MaSP and ctdh.MaDonHang = dh.MaDonHang");
            CrystalReport1 rp = new CrystalReport1();
            rp.SetDataSource(dt);
            crystalReportViewer1.ReportSource = rp;
        }
    }
}
