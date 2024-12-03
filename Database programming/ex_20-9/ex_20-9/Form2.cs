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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet();
        DataTable dg = new DataTable("DOCGIA");
        DataTable s = new DataTable("SACH");
        DataTable pm = new DataTable("PHIEUMUON");
        
        void createDataSet()
        {
            dg.Columns.Add("MaDG", Type.GetType("System.String"));
            dg.Columns.Add("HoTen", Type.GetType("System.String"));
            dg.Columns.Add("SDT", Type.GetType("System.String"));
            dg.Columns.Add("Email", Type.GetType("System.String"));

            s.Columns.Add("MaSach", Type.GetType("System.String"));
            s.Columns.Add("TenSach", Type.GetType("System.String"));
            s.Columns.Add("NXB", Type.GetType("System.String"));
            s.Columns.Add("TacGia", Type.GetType("System.String"));

            pm.Columns.Add("SoPM", typeof(String));
            pm.Columns.Add("MaDG", typeof(String));
            pm.Columns.Add("MaSach", typeof(String));
            pm.Columns.Add("NgM", typeof(DateTime));
            pm.Columns.Add("NgT", typeof(DateTime));

            ds.Tables.Add(s);
            ds.Tables.Add(dg);
            ds.Tables.Add(pm);
        }

        void IAddData(String[,] data, String TableName, DataTable dt)
        {
            for(int i=0; i<data.GetLength(0); i++)
            {
                int index = 0;
                DataRow r = ds.Tables[TableName].NewRow();
                foreach(DataColumn dc in ds.Tables[TableName].Columns)
                {
                    r[dc.ColumnName] = data[i,index++];
                }
                dt.Rows.Add(r);   
            }
        }

        void addData(String[,] dataDG, String[,] dataS, String[,] dataPM)
        {
            IAddData(dataDG, "DOCGIA", dg);
            IAddData(dataS, "SACH", s);
            IAddData(dataPM, "PHIEUMUON", pm);
        }
        void display()
        {
            foreach (DataTable dt in ds.Tables)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    foreach (DataColumn dc in dt.Columns)
                    {
                        listBox1.Items.Add(dc.ColumnName + ":" + dr[dc]);
                    }
                }
            }
        }
            private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String[,] dataDG =  {
                 { "DG-001", "Nguyen Van A", "0123451", "a@gmail.com" },
                 {  "DG-002", "Nguyen Van B", "0123452", "b@gmail.com"},
                 {  "DG-003", "Nguyen Van C", "0123453", "c@gmail.com"},
            };
            String[,] dataS =  {
                 { "S-001", "Sach 1", "6/6/1999", "ABC" },
                 {  "S-002", "Sach 2", "7/6/1999", "ABD"},
                 {  "S-003", "Sach 3", "8/6/1999", "ABE"},
                 {  "S-004", "Sach 4", "9/6/1999", "ABF"},
                 {  "S-005", "Sach 5", "10/6/1999", "ABG"},
            };
            String[,] dataPM =  {
                 { "SP-001", "DG-001", "S-001", "1/1/2024", "6/1/2024"},
                 {  "SP-002", "DG-001","S-002", "1/1/2024", "6/1/2024"},
                {  "SP-003", "DG-001","S-002", "1/1/2024", "6/1/2024"},
                {  "SP-004", "DG-002","S-002", "1/1/2024", "6/1/2024"},
                {  "SP-005", "DG-003","S-002", "1/1/2024", "7/1/2024"}
            };
            createDataSet();
            addData(dataDG, dataS, dataPM);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            display();
        }
    }
}
