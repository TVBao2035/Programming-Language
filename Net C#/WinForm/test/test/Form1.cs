using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kindOfMeals.Items.Add("Mon Khai Vi");
            kindOfMeals.Items.Add("Cac Mon Lau");
        }

        private void kindOfMeals_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = kindOfMeals.SelectedIndex;
            listFood.Items.Clear();
            if(index == 0)
            {
                listFood.Items.Add("1");
                listFood.Items[0].SubItems.Add("Sup Ca Hoi");
                listFood.Items[0].SubItems.Add("200000");

                listFood.Items.Add("2");
                listFood.Items[1].SubItems.Add("Sup Cua");
                listFood.Items[1].SubItems.Add("250000");

                listFood.Items.Add("3");
                listFood.Items[2].SubItems.Add("Goi Ga Mang Cuc");
                listFood.Items[2].SubItems.Add("300000");

                listFood.Items.Add("4");
                listFood.Items[3].SubItems.Add("Goi Ga Mang Cau");
                listFood.Items[3].SubItems.Add("220000");
            }
            
            if(index == 1)
            {

                listFood.Items.Add("1");
                listFood.Items[0].SubItems.Add("Lau Ca e");
                listFood.Items[0].SubItems.Add("300000");

                listFood.Items.Add("2");
                listFood.Items[1].SubItems.Add("Lau Ca Tam");
                listFood.Items[1].SubItems.Add("500000");

                listFood.Items.Add("3");
                listFood.Items[2].SubItems.Add("Lau Ca Hoi");
                listFood.Items[2].SubItems.Add("400000");

                listFood.Items.Add("4");
                listFood.Items[3].SubItems.Add("Lau Hai San");
                listFood.Items[3].SubItems.Add("450000");
            }
        }

        private void listFood_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listFood_Click(object sender, EventArgs e)
        {

        }

        int search(string name, ListBox list)
        {
            for(int i=0; i<list.Items.Count; i++)
            {
                if (list.Items[i].ToString() == name) return i;
            }
            return -1;
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            string foodName = listFood.SelectedItems[0].SubItems[1].Text;
            int index = search(foodName, listOrder);
   
            if(index != -1)
            {
                MessageBox.Show("This fodd existed! Please another food", "Notification", MessageBoxButtons.OK);
            }
            else
            {

                listOrder.Items.Add(foodName);
            }

            displayChosenTotal.Text = listOrder.Items.Count.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            listOrder.Items.RemoveAt(listOrder.SelectedIndex);
            displayChosenTotal.Text = listOrder.Items.Count.ToString();
        }
    }
}
