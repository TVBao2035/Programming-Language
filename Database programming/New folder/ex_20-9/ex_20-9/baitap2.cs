using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex_20_9
{
    public partial class baitap2 : Form
    {
        public baitap2()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet();
        DataTable dg = new DataTable("DOCGIA");
        DataTable s = new DataTable("SACH");
        DataTable pm = new DataTable("PHIEUMUON");
        private void baitap2_Load(object sender, EventArgs e)
        {
            createDataSet();
            foreach (DataTable dt in ds.Tables) { cbtable.Items.Add(dt.TableName); };
            AddData();
          
            cbtable.Items.Clear();
            displaydataset();
            foreach (DataTable dt in ds.Tables)
            {
               cbtable.Items.Add(dt.TableName);
            }


        }
        public void createDataSet()
        {
            s = new DataTable("SACH");
            s.Columns.Add("MaSach", typeof(string));
            s.Columns.Add("Tensach", typeof(string));
            s.Columns.Add("NhaXB", typeof(string));
            s.Columns.Add("Tacgia", typeof(string));

            dg = new DataTable("DOCGIA");
            dg.Columns.Add("MaDG", typeof(string));
            dg.Columns.Add("Hoten", typeof(string));
            dg.Columns.Add("Ngaysinh", typeof(DateTime));
            dg.Columns.Add("Sodt", typeof(string));

            pm = new DataTable("PHIEUMUON");
            pm.Columns.Add("SoPM", typeof(string));
            pm.Columns.Add("MaDG", typeof(string));
            pm.Columns.Add("Ngaymuon", typeof(DateTime));
            pm.Columns.Add("ngaytra", typeof(DateTime));

            ds.Tables.Add(s);
            ds.Tables.Add(dg);
            ds.Tables.Add(pm);

            MessageBox.Show("đã tạo xong");
        }
        public void AutoAddData(String[,] data, DataTable dt)
        {
            for (int i = 0; i < data.GetLength(0); i++)
            {
                int index = 0;
                DataRow dr = dt.NewRow();
                foreach (DataColumn dc in dt.Columns)
                {
                    dr[dc.ColumnName] = data[i, index++];
                }
                dt.Rows.Add(dr);
            }

        }
        public void AddData()
        {
            String[,] sData =
           {
                {"s011", "làm bạn với bầu trời", "trẻ","Nguyễn Nhật Ánh"},
                {"s012", "mùa hè không tên", "trẻ","Nguyễn Nhật Ánh"},
                {"s013", "hạt giông tâm hồn", "trẻ","Nguyễn Nhật Ánh"},
                {"s014", "một đời như kẻ tìm đường", "trẻ","Nguyễn Nhật Ánh"},
                {"s015", "tấm cám", "trẻ","Nguyễn Nhật Ánh"},
            };
            String[,] dgData =
            {
                {"A001", "Tran Thi Nhung", "12/12/1982", "0977867575"},
                {"A002", "Ho Thi Lan", "12/12/1980", "0978676755"},
                {"A003", "Nguyen Lan Chi", "12/2/1981", "096575675"},
                {"A004", "Tran Thanh Sang", "5/6/1982", "0976766554"},
                {"A005", "Tran Xuan Thu",  "12/12/1982", "0595756464"},

            };
           
            String[,] pmData =
            {
                {"A001", "s011", "10/05/2024","20/06/2024"},
                {"A001", "s012", "15/05/2024","20/06/2024"},
                {"A002", "s013", "19/05/2024","20/06/2024"},
                {"A002", "s014", "18/05/2024","20/06/2024"},
                {"A004", "s015", "12/05/2024","20/06/2024"},
                {"A004", "s011", "16/05/2024","20/06/2024"},
                {"A005", "s012", "11/05/2024","20/06/2024"},
            };

           AutoAddData(sData, s);
            AutoAddData(dgData, dg);
            AutoAddData(pmData, pm);
        }
        public void display()
        {

            foreach (DataTable dt in ds.Tables)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    foreach (DataColumn dc in dt.Columns)
                    {
                        lstdata.Items.Add(dc.ColumnName + ":" + dr[dc].ToString());
                    }
                }
            }
        }
        public void displaydataset()
        {
            lstdata.Items.Add("databang");
            lstdata.Items.Add("==============");
            foreach (DataTable dt in ds.Tables)
            {
                lstdata.Items.Add("       ");
                lstdata.Items.Add("Table:" + dt.TableName);
                lstdata.Items.Add("--------------------------------------");
                foreach (DataRow dr in dt.Rows)
                {
                    foreach (DataColumn dc in dt.Columns)
                        lstdata.Items.Add(dc.ColumnName + ":" + dr[dc]);
                    lstdata.Items.Add("******************");
                }
            }
        }

        private void cbtable_SelectedIndexChanged(object sender, EventArgs e)
        {
           databang.DataSource = ds.Tables[cbtable.SelectedIndex];

            lbbangdocgia.Text = " Bảng: " + cbtable.SelectedItem.ToString() +
            " có:  " + ds.Tables[cbtable.SelectedIndex].Rows.Count.ToString() + "  dòng";
        }

        private void databang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int vt = databang.CurrentCell.RowIndex;
            string MaDG = databang.Rows[vt].Cells[0].Value.ToString();
            string Hoten = databang.Rows[vt].Cells[1].Value.ToString();
            DateTime Ngaysinh = DateTime.Parse(databang.Rows[vt].Cells[2].Value.ToString());
            string Sodt = databang.Rows[vt].Cells[3].Value.ToString();

            txtmadg.Text = MaDG;
            txthoten.Text = Hoten;
            time.Value = Ngaysinh;
            txtsdt.Text = Sodt;

        }

        private void btthem_Click(object sender, EventArgs e)
        {
            ds.Tables["DOCGIA"].Rows.Add(txtmadg.Text, txthoten.Text, time.Text, txtsdt.Text);
            display();
        

        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            int vt = databang.CurrentCell.RowIndex;
            dg.Rows.RemoveAt(vt);
            display();
            lbbangdocgia.Text = " Bảng: " + cbtable.SelectedItem.ToString() +
            " có:  " + ds.Tables[cbtable.SelectedIndex].Rows.Count.ToString() + "  dòng";

        }

        private void btapnhat_Click(object sender, EventArgs e)
        {
            int vt = databang.CurrentCell.RowIndex;
            ds.Tables[cbtable.SelectedItem.ToString()].Rows[vt][0] = txtmadg.Text;
            ds.Tables[cbtable.SelectedItem.ToString()].Rows[vt][1] = txthoten.Text;
            ds.Tables[cbtable.SelectedItem.ToString()].Rows[vt][2] = DateTime.Parse(time.Value.ToShortDateString());
            ds.Tables[cbtable.SelectedItem.ToString()].Rows[vt][3] = txtsdt.Text;
            ds.Tables[cbtable.SelectedItem.ToString()].AcceptChanges();
            display();

        }
    }

  
    }

