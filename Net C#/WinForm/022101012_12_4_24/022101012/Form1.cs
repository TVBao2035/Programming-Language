using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            comboKindOfMedicine.Items.Add("Thuốc bổ");
            comboKindOfMedicine.Items.Add("Thuốc hạ sốt, kháng viêm");
            comboKindOfMedicine.Items.Add("Thuốc giảm đau");
        }

        private void comboKindOfMedicine_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboKindOfMedicine.SelectedIndex;
            listMedicine.Items.Clear();
            if(index == 0)
            {
                listMedicine.Items.Add("Magnes B6 5mg");
                listMedicine.Items.Add("Montelukast 5 mg");
                listMedicine.Items.Add("Opensikat 5mg");
                listMedicine.Items.Add("Opensikat 10mg");
                listMedicine.Items.Add("Herrbes 30mg");
            }

            if (index == 1)
            {
                listMedicine.Items.Add(" Paracetamol  5mg");
                listMedicine.Items.Add("Tylenol 5 mg");
                listMedicine.Items.Add("Hapacol 5mg");
                listMedicine.Items.Add("Efferalgant 10mg");
                listMedicine.Items.Add(" Ibuprofen 30mg");
            }

            if (index == 2)
            {
                listMedicine.Items.Add("Alexan 5mg");
                listMedicine.Items.Add("Salonpas 5 mg");
                listMedicine.Items.Add("Motilum 5mg");
                listMedicine.Items.Add("Becberin 10mg");
                listMedicine.Items.Add("Smecta 30mg");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(listMedicine.SelectedItems.Count != 0) 
                listOrder.Items.Add(listMedicine.SelectedItem);
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string gender = "Nữ";
            if (checkGender.Checked)
            {
                gender = "Nam";
            }

            string age = (DateTime.Now.Year - int.Parse(txtBorn.Text)).ToString();

            string list = "";
            int length = listOrder.Items.Count;
            for(int i=0; i<length; i++)
            {
                list += listOrder.Items[i].ToString() + "\r\n";
            }

            string notification = "Họ và Tên: " + name + ". Giới tính: " + gender + ". Tuổi: " + age + "\r\nThuốc được kê toa: \r\n" + list + "Hẹn tái khám sau 28 ngày";
            MessageBox.Show(notification, "Notification", MessageBoxButtons.OK);
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string gender = "Nữ";
            if (checkGender.Checked)
            {
                gender = "Nam";
            }

            string age = (DateTime.Now.Year - int.Parse(txtBorn.Text)).ToString();

            string list = "";
            int length = listOrder.Items.Count;
            for (int i = 0; i < length; i++)
            {
                list += listOrder.Items[i].ToString() + "\r\n";
            }

            string notification = "\r\n\nHọ và Tên: " + name + ". Giới tính: " + gender + ". Tuổi: " + age + "\r\nThuốc được kê toa: \r\n" + list + "Hẹn tái khám sau 28 ngày";
            FileStream fs = new FileStream("TTBN.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
            StreamWriter wf = new StreamWriter(fs);
            fs.Seek(0, SeekOrigin.End);
            wf.Write(notification);   
            wf.Flush();

            txtName.Text = "";
            txtBorn.Text = "";
            listOrder.Items.Clear();
            checkGender.Checked = false;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
