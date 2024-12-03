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
        public void displayInformationTeacher()
        {
            listProduct.Items.Clear();
            DataTable data = new DataTable();
            data = Teachers.getInformation();
            int length = data.Rows.Count;
            for(int i=0; i<length; i++)
            {
                listProduct.Items.Add(data.Rows[i][0].ToString());
                listProduct.Items[i].SubItems.Add(data.Rows[i][1].ToString());
                if(data.Rows[i][2].ToString()=="True")
                listProduct.Items[i].SubItems.Add("Nam");
                else listProduct.Items[i].SubItems.Add("Nu");

                listProduct.Items[i].SubItems.Add(data.Rows[i][3].ToString());
                listProduct.Items[i].SubItems.Add(data.Rows[i][4].ToString());
                listProduct.Items[i].SubItems.Add(data.Rows[i][5].ToString());

            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            displayInformationTeacher();
            comboGender.Items.Add("Nam");
            comboGender.Items.Add("Nu");
        }

        private void listProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listProduct.SelectedItems.Count != 0)
            {
                txtID.Text = listProduct.SelectedItems[0].SubItems[0].Text;
                txtName.Text = listProduct.SelectedItems[0].SubItems[1].Text;
                bornDate.Text = listProduct.SelectedItems[0].SubItems[3].Text;
                comboGender.Text = listProduct.SelectedItems[0].SubItems[2].Text;
                txtAddress.Text = listProduct.SelectedItems[0].SubItems[4].Text;
                txtPhoneNumber.Text = listProduct.SelectedItems[0].SubItems[5].Text;

            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtName.Text = "";
            bornDate.Text = "";
            comboGender.Text = "";
            txtAddress.Text = "";
            txtPhoneNumber.Text = "";

            string id = Teachers.getIdTeacherMax().Rows[0][0].ToString();
            id = "GV" + (int.Parse(id.Substring(2, id.Length - 2))+1).ToString("000");
            txtID.Text = id;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            string name = txtName.Text;
            string gender = "0";
            if (comboGender.SelectedItem.ToString() == "Nam")
            {
                gender = "1";
            }

            string bornDay = bornDate.Value.ToString("MM/dd/yyyy");
            string address = txtAddress.Text;
            string phoneNumber = txtPhoneNumber.Text;

            Teachers.AddTeacher(id, name, gender, bornDay, address, phoneNumber);



            displayInformationTeacher();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Teachers.DeleteTeacher(txtID.Text);
            txtID.Text = "";
            txtName.Text = "";
            bornDate.Text = "";
            comboGender.Text = "";
            txtAddress.Text = "";
            txtPhoneNumber.Text = "";
            displayInformationTeacher();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            string name = txtName.Text;
            string gender = "0";
            if (comboGender.SelectedItem.ToString() == "Nam")
            {
                gender = "1";
            }

            string bornDay = bornDate.Value.ToString("MM/dd/yyyy");
            string address = txtAddress.Text;
            string phoneNumber = txtPhoneNumber.Text;

            Teachers.UpdateTeacher(id, name, gender, bornDay, address, phoneNumber);



            displayInformationTeacher();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
