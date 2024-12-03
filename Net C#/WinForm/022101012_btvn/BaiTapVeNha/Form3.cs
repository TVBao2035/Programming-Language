using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapVeNha
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            listSubject.Items.Add(txtSubejctId.Text);
            listSubject.Items[listSubject.Items.Count - 1].SubItems.Add(txtSubejctName.Text);
            listSubject.Items[listSubject.Items.Count - 1].SubItems.Add(numCredit.Value.ToString());
            string temp = "";
            if (radioElective.Checked) temp = "Tu chon";
            else temp = "Bat buoc";
            listSubject.Items[listSubject.Items.Count - 1].SubItems.Add(temp);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult notification = MessageBox.Show("Do you want to delete this Subject?", "Notification!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(notification == DialogResult.Yes)
            listSubject.Items.Remove(listSubject.SelectedItems[0]);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int electiveCredits = 0, forcedCredits = 0;

            for(int i = 0; i < listSubject.Items.Count; i++)
            {
                if (listSubject.Items[i].SubItems[3].Text == "Tu chon") electiveCredits += int.Parse(listSubject.Items[i].SubItems[2].Text);
                else forcedCredits += int.Parse(listSubject.Items[i].SubItems[2].Text);
            }

            sumCreditsElective.Text = "Sum Of Elective Credits: " + electiveCredits.ToString();
            sumCreditsForced.Text = "Sum Of Forced Credits: " + forcedCredits.ToString();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            listSubject.Items.Add("03301");
            listSubject.Items[0].SubItems.Add("Toan Cao Cap A1");
            listSubject.Items[0].SubItems.Add("3");
            listSubject.Items[0].SubItems.Add("Bat buoc");

            listSubject.Items.Add("03302");
            listSubject.Items[1].SubItems.Add("Toan Cao Cap A2");
            listSubject.Items[1].SubItems.Add("3");
            listSubject.Items[1].SubItems.Add("Bat buoc");

            listSubject.Items.Add("03392");
            listSubject.Items[2].SubItems.Add("Mang May Tinh");
            listSubject.Items[2].SubItems.Add("2");
            listSubject.Items[2].SubItems.Add("Tu chon");

            listSubject.Items.Add("03393");
            listSubject.Items[3].SubItems.Add("Lap Trinh Huong Doi Tuong");
            listSubject.Items[3].SubItems.Add("3");
            listSubject.Items[3].SubItems.Add("Tu chon");

            listSubject.Items.Add("03028");
            listSubject.Items[4].SubItems.Add("Co So Du Lieu");
            listSubject.Items[4].SubItems.Add("3");
            listSubject.Items[4].SubItems.Add("Bat buoc");
        }
    }
}
