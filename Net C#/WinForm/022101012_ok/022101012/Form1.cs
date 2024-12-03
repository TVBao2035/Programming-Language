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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listClasses.Items.Add("Hệ thống thông tin");
            listClasses.Items.Add("Công nghệ phần mềm");
        }

        private void listClasses_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listClasses.SelectedIndex;
            listSubjects.Items.Clear();
            if(index == 0)
            {
                listSubjects.Items.Add("33913");
                listSubjects.Items[0].SubItems.Add("Phát triển ứng dụng Web");
                listSubjects.Items[0].SubItems.Add("3");

                listSubjects.Items.Add("32304");
                listSubjects.Items[1].SubItems.Add("Cơ sở dữ liệu");
                listSubjects.Items[1].SubItems.Add("4");

                listSubjects.Items.Add("30073");
                listSubjects.Items[2].SubItems.Add("Công nghệ .NET");
                listSubjects.Items[2].SubItems.Add("3");

                listSubjects.Items.Add("32363");
                listSubjects.Items[3].SubItems.Add("Phân tích thiết kế HTTT");
                listSubjects.Items[3].SubItems.Add("3");
            }

            if (index == 1)
            {
                listSubjects.Items.Add("32762");
                listSubjects.Items[0].SubItems.Add("Quản lý dự án phần mềm");
                listSubjects.Items[0].SubItems.Add("2");

                listSubjects.Items.Add("32723");
                listSubjects.Items[1].SubItems.Add("Nhập môn công nghệ phần mềm");
                listSubjects.Items[1].SubItems.Add("3");

                listSubjects.Items.Add("32632");
                listSubjects.Items[2].SubItems.Add("Phát triển phần mềm nguồn mở");
                listSubjects.Items[2].SubItems.Add("3");

                listSubjects.Items.Add("34741");
                listSubjects.Items[3].SubItems.Add("Đồ án ngành");
                listSubjects.Items[3].SubItems.Add("1");
            }
        }

        bool search(string name, ListView list)
        {
            for(int i=0; i<list.Items.Count; i++)
            {
                if (list.Items[i].SubItems[0].Text == name) return true;
            }
            return false;
        }

        int countIndex(ListView list)
        {
            int result = 0;
            for(int i=0; i<list.Items.Count; i++)
            {
                int index = int.Parse(list.Items[i].SubItems[1].Text);
                result += index;
            }

            return result;
        }
        private void btnChoose_Click(object sender, EventArgs e)
        {
            string subjectName = listSubjects.SelectedItems[0].SubItems[1].Text;
            int numberIndex = int.Parse(listSubjects.SelectedItems[0].SubItems[2].Text);
            int length = listOrderSubejct.Items.Count;
            if (!search(subjectName, listOrderSubejct))
            {
                listOrderSubejct.Items.Add(subjectName);
                listOrderSubejct.Items[length].SubItems.Add(numberIndex.ToString());
            }

            int indexTotal = countIndex(listOrderSubejct);

            if (indexTotal > 15)
            {
                MessageBox.Show("Tổng số tín chỉ >15, vui lòng chọn học phần khác", "Thông Báo", MessageBoxButtons.OK);
                listOrderSubejct.Items.RemoveAt(listOrderSubejct.Items.Count - 1);
            }
            else
            {
                displayIndexTotal.Text = indexTotal.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listOrderSubejct.SelectedItems.Count != 0)
            {
                DialogResult result = MessageBox.Show("Bạn Chắc Chắn Muốn Xóa Học Phần Này!", "Thông Báo!", MessageBoxButtons.YesNo);

                if(result == DialogResult.Yes)
                {
                    listOrderSubejct.Items.RemoveAt(listOrderSubejct.SelectedIndices[0]);
                }

                displayIndexTotal.Text = countIndex(listOrderSubejct).ToString();

            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
