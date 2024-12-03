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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            listSubjects.Items.Add("30073");
            listSubjects.Items[0].SubItems.Add("Công nghệ .NET");
            listSubjects.Items[0].SubItems.Add("3");
            listSubjects.Items[0].SubItems.Add("Bắt buộc");
            listSubjects.Items.Add("32304");
            listSubjects.Items[1].SubItems.Add("Cơ sở dữ liệu");
            listSubjects.Items[1].SubItems.Add("4");
            listSubjects.Items[1].SubItems.Add("Bắt buộc");
            listSubjects.Items.Add("30043");
            listSubjects.Items[2].SubItems.Add("Tin học VP");
            listSubjects.Items[2].SubItems.Add("3");
            listSubjects.Items[2].SubItems.Add("Tự chọn");
            listSubjects.Items.Add("30102");
            listSubjects.Items[3].SubItems.Add("Lắp đặt và MTMT");
            listSubjects.Items[3].SubItems.Add("3");
            listSubjects.Items[3].SubItems.Add("Tự chọn");
            listSubjects.Items.Add("32304");
            listSubjects.Items[4].SubItems.Add("Toán rời rạc");
            listSubjects.Items[4].SubItems.Add("3");
            listSubjects.Items[4].SubItems.Add("Bắt buộc");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            listSubjects.Items.Add(txtId.Text);
            listSubjects.Items[listSubjects.Items.Count - 1].SubItems.Add(txtName.Text);
            listSubjects.Items[listSubjects.Items.Count - 1].SubItems.Add(numAmount.Value.ToString());
            if (radioPossible.Checked) 
            {
                listSubjects.Items[listSubjects.Items.Count - 1].SubItems.Add("Bắt buộc");
            }
            else
            {
                listSubjects.Items[listSubjects.Items.Count - 1].SubItems.Add("Tự chọn");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(listSubjects.SelectedIndices.Count != 0)
            {
                DialogResult kq = MessageBox.Show("Bạn có muốn xóa Học Phần này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (kq == DialogResult.Yes) listSubjects.Items.RemoveAt(listSubjects.SelectedIndices[0]);
            }
       
        }

        private void btnHandle_Click(object sender, EventArgs e)
        {
            int free = 0, possible =0;
          
            for (int i=0; i<listSubjects.Items.Count; i++)
            {
                if(listSubjects.Items[i].SubItems[3].Text == "Bắt buộc")
                {
                    possible += int.Parse(listSubjects.Items[i].SubItems[2].Text) ;
                }
                else
                {
                    free += int.Parse(listSubjects.Items[i].SubItems[2].Text);
                }
            }

            sumFree.Text = "Tổng số tín chỉ tự chọn là: " + free.ToString();
            sumPossible.Text = "Tổng số tín chỉ bắt buộc là: " + possible.ToString();
        }

        private void listSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
