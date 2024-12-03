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

namespace report_2
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
            DataTable dt = db.ExecuteQuery("select sv.MASV, HOSV + ' ' + TENSV as Hoten, PHAI, LANTHI, DIEM, m.MAMH, TENMH from DMSV sv, KETQUA k, DMMH m where sv.MASV = k.MASV and k.MAMH = m.MAMH");

            CrystalReport1 cr = new CrystalReport1();
            cr.SetDataSource(dt);
            crystalReportViewer1.ReportSource = cr;
        }
    }
}
