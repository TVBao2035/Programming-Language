using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace sample_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            displayInformationTeacher();
            comboGender.Items.Add("Nu");
            comboGender.Items.Add("Nam");
    
        }
        public void clearAllValueInput()
        {
            txtId.Text = "";
            txtName.Text = "";
            txtAddress.Text = "";
            txtPhone.Text = "";
            comboGender.Text = "";
        }
       
        public void displayInformationTeacher()
        {
            listTeachers.Items.Clear();
            DataTable data = new DataTable();
            data = Teacher.getInformation();
            int lengthOfData = data.Rows.Count;
            for(int i=0; i<lengthOfData; i++)
            {
                string temp = "Nu";
                if (data.Rows[i][2].ToString() == "True")
                {
                    temp = "Nam";
                }
                listTeachers.Items.Add(data.Rows[i][0].ToString());
                listTeachers.Items[i].SubItems.Add(data.Rows[i][1].ToString());
                listTeachers.Items[i].SubItems.Add(temp);
                listTeachers.Items[i].SubItems.Add(data.Rows[i][3].ToString());
                listTeachers.Items[i].SubItems.Add(data.Rows[i][4].ToString());
                listTeachers.Items[i].SubItems.Add(data.Rows[i][5].ToString());
            }
        }

        private void listTeachers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listTeachers.SelectedItems.Count != 0)
            {
                txtId.Text = listTeachers.SelectedItems[0].SubItems[0].Text;
                txtName.Text = listTeachers.SelectedItems[0].SubItems[1].Text;
                comboGender.Text = listTeachers.SelectedItems[0].SubItems[2].Text;
                bornDate.Text = listTeachers.SelectedItems[0].SubItems[3].Text;
                txtAddress.Text = listTeachers.SelectedItems[0].SubItems[4].Text;
                txtPhone.Text = listTeachers.SelectedItems[0].SubItems[5].Text;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            clearAllValueInput();
            string id = Teacher.getIdMax().Rows[0][0].ToString();
            id = "GV" + (int.Parse(id.Substring(2, id.Length - 2)) + 1).ToString("000");
            txtId.Text = id;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string id = txtId.Text;
            string address = txtAddress.Text;
            string phone = txtPhone.Text;
            string gender = comboGender.SelectedIndex.ToString();
            string date = bornDate.Value.ToString("MM/dd/yyyy");
            if (id.Length != 0)
            {
                Teacher.InsertData(id, name, gender, date, address, phone);
                displayInformationTeacher();
                clearAllValueInput();

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string id = txtId.Text;
            string address = txtAddress.Text;
            string phone = txtPhone.Text;
            string gender = comboGender.SelectedIndex.ToString();
            string date = bornDate.Value.ToString("MM/dd/yyyy");
            if (id.Length != 0)
            {
                Teacher.UpdateData(id, name, gender, date, address, phone);
                displayInformationTeacher();
                clearAllValueInput();

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;

            if (id.Length != 0)
            {
                Teacher.DeleteData(id);
                displayInformationTeacher();
                clearAllValueInput();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
