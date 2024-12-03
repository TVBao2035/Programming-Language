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
            comboBoxSchools.Items.Add("Nguyễn Đình Chiểu");
            comboBoxSchools.Items.Add("Chuyên Tiền Giang");
            comboBoxSchools.Items.Add("Lưu Tấn Phát");
            comboBoxSchools.Items.Add("Phước Thạnh");
            comboBoxSchools.Items.Add("Trần Hưng Đạo");

            comboBoxSubject.Items.Add("Toán");
            comboBoxSubject.Items.Add("Sinh Học");
            comboBoxSubject.Items.Add("Anh Văn");
            comboBoxSubject.Items.Add("Vật Lý");
            comboBoxSubject.Items.Add("Hóa Học");
            comboBoxSubject.Items.Add("Tin Học");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int length = listStudentInformation.Items.Count;
            string name = txtName.Text;
            double score = Convert.ToDouble(numScore.Value);
            string subject = comboBoxSubject.SelectedItem.ToString();
            string school = comboBoxSchools.SelectedItem.ToString();
            listStudentInformation.Items.Add((length+1).ToString());
            listStudentInformation.Items[length].SubItems.Add(name);
            listStudentInformation.Items[length].SubItems.Add(score.ToString("#.#0"));
            listStudentInformation.Items[length].SubItems.Add(subject);
            listStudentInformation.Items[length].SubItems.Add(school);
        }

        bool search(string name, ListView list)
        {
            for (int i = 0; i < list.Items.Count; i++)
            {
                if (list.Items[i].SubItems[0].Text == name) return true;
            }
            return false;
        }
        

        private void btnStatistical_Click(object sender, EventArgs e)
        {
            int totalPrize = 0;
            listStatistical.Items.Clear();
            displayTotalStudent.Text = "";
            for (int i=0; i<listStudentInformation.Items.Count; i++)
            {
                string school = listStudentInformation.Items[i].SubItems[4].Text;
                if(!search(school, listStatistical))
                {
                    int count = 0;
                    for(int j=0; j<listStudentInformation.Items.Count; j++)
                    {
                        double score = Convert.ToDouble(listStudentInformation.Items[j].SubItems[2].Text);
                        if (school == listStudentInformation.Items[j].SubItems[4].Text && score >= 6)
                        {
                            count++;
                        }
                    }
                    totalPrize += count;
                    listStatistical.Items.Add(school);
                    listStatistical.Items[listStatistical.Items.Count - 1].SubItems.Add(count.ToString());
                }
            }


            displayTotalStudent.Text = totalPrize.ToString();
        }

        private void numScore_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
