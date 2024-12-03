using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sample_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void displayInformationTeacher()
        {
            teacherList.Items.Clear();
            DataTable data = new DataTable();
            data = Teacher.displayInformation();
            int length = data.Rows.Count;
            for(int i=0; i<length; i++)
            {
                teacherList.Items.Add(data.Rows[i][0].ToString());
                teacherList.Items[i].SubItems.Add(data.Rows[i][1].ToString());
                if (data.Rows[i][2].ToString() == "True")
                    teacherList.Items[i].SubItems.Add("Nam");
                else teacherList.Items[i].SubItems.Add("Nu");
                teacherList.Items[i].SubItems.Add(data.Rows[i][3].ToString());
                teacherList.Items[i].SubItems.Add(data.Rows[i][4].ToString());
                teacherList.Items[i].SubItems.Add(data.Rows[i][5].ToString());
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            displayInformationTeacher();
            comboGender.Items.Add("Nu");
            comboGender.Items.Add("Nam");
        }

        private void teacherList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (teacherList.SelectedItems.Count != 0)
            {
                txtId.Text = teacherList.SelectedItems[0].SubItems[0].Text;
                txtName.Text = teacherList.SelectedItems[0].SubItems[1].Text;
                comboGender.Text = teacherList.SelectedItems[0].SubItems[2].Text;
                dateBorn.Text = teacherList.SelectedItems[0].SubItems[3].Text;
                txtAddress.Text = teacherList.SelectedItems[0].SubItems[4].Text;
                txtPhone.Text = teacherList.SelectedItems[0].SubItems[5].Text;

            }
        }
        public void clearValueInputs()
        {
            txtId.Text = "";
            txtName.Text = "";
            txtAddress.Text = "";
            txtPhone.Text = "";
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string id = Teacher.getMaxID().Rows[0][0].ToString();
            id = "GV" + (int.Parse(id.Substring(2, id.Length - 2)) + 1).ToString("000");
            clearValueInputs();
            txtId.Text = id;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Teacher.Insert(txtId.Text, txtName.Text, comboGender.SelectedIndex.ToString(), dateBorn.Value.ToString("MM/dd/yyyy"), txtAddress.Text, txtPhone.Text);
            clearValueInputs();
            displayInformationTeacher();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(teacherList.SelectedIndices.Count != 0)
            {
                Teacher.Update(txtId.Text, txtName.Text, comboGender.SelectedIndex.ToString(), dateBorn.Value.ToString("MM/dd/yyyy"), txtAddress.Text, txtPhone.Text);
                clearValueInputs();
                displayInformationTeacher();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(teacherList.SelectedItems.Count != 0)
            {
                Teacher.Delete(txtId.Text);
                clearValueInputs();
                displayInformationTeacher();
            }
        }
    }
}
