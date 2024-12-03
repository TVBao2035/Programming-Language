using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace report
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
            DataTable dt = db.ExecuteQuery("select MASV, HOSV + ' ' + TENSV as Hoten, NGAYSINH, NOISINH, HOCBONG, MAKH from DMSV");
            CrystalReport1 cp = new CrystalReport1();
            cp.SetDataSource(dt);
            crystalReportViewer1.ReportSource = cp;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
