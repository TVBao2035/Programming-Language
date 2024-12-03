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

        private void treeSubject_AfterSelect(object sender, TreeViewEventArgs e)
        {
            listSubjectDisplay.Items.Clear();
            if (treeSubject.SelectedNode.Text == "Tin Hoc")
            {
                listSubjectDisplay.Items.Add("Lap Trinh Giao Dien");
                listSubjectDisplay.Items[0].SubItems.Add("Phuong Linh");
                listSubjectDisplay.Items[0].SubItems.Add("35000");

                listSubjectDisplay.Items.Add("Mang May Tinh");
                listSubjectDisplay.Items[1].SubItems.Add("Minh Khanh");
                listSubjectDisplay.Items[1].SubItems.Add("45000");

                listSubjectDisplay.Items.Add("Co So Du Lieu");
                listSubjectDisplay.Items[2].SubItems.Add("Minh Khanh");
                listSubjectDisplay.Items[2].SubItems.Add("30000");
            }

            if (treeSubject.SelectedNode.Text == "Thieu Nhi")
            {
                listSubjectDisplay.Items.Add("Tam Cam");
                listSubjectDisplay.Items[0].SubItems.Add("Chuyen Co Tich");
                listSubjectDisplay.Items[0].SubItems.Add("25000");

                listSubjectDisplay.Items.Add("Thanh Giong");
                listSubjectDisplay.Items[1].SubItems.Add("Chuyen Co Tich");
                listSubjectDisplay.Items[1].SubItems.Add("40000");

            }
        }
    }
}
