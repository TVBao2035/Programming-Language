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
            listCountries.Items.Add("China");
            listCountries.Items.Add("Viet Nam");
            listCountries.Items.Add("Korea");
        }

        private void listCountries_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listCountries.SelectedIndex;
            listFood.Items.Clear();
            if(index == 0)
            {
                listFood.Items.Add("Mi Vit Tiem");
                listFood.Items.Add("Mi Xao Gion");
                listFood.Items.Add("Banh Canh Vit");
                listFood.Items.Add("Hot Vit Lon");
            }

            if(index == 1)
            {
                listFood.Items.Add("Goi Cuon");
                listFood.Items.Add("Banh Flan");
                listFood.Items.Add("Ga Hap Chao");
                listFood.Items.Add("Bun Thit Nuong");
            }

            if (index == 2)
            {
                listFood.Items.Add("Su Si");
                listFood.Items.Add("Canh Rong Bien");
                listFood.Items.Add("Kim Chi");
                listFood.Items.Add("Com Cuon");
            }
        }

        int search(string name, ListView list)
        {
            for(int i=0; i<list.Items.Count; i++)
            {
                if (name == list.Items[i].Text) return i;
            }
            return -1;
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            int amount = Convert.ToInt32(numAmount.Value);
            for(int i = 0; i < listFood.CheckedItems.Count; i++)
            {
                string foodName = listFood.CheckedItems[i].ToString();
                int lenghtOfListOrder = listOrder.Items.Count;
                int indexOfExistFood = search(foodName, listOrder);

                if(indexOfExistFood == -1)
                {
                    listOrder.Items.Add(foodName);
                    listOrder.Items[lenghtOfListOrder].SubItems.Add(amount.ToString());
                }
                else
                {
                    int amountOfExistFood = int.Parse(listOrder.Items[indexOfExistFood].SubItems[1].Text);
                    listOrder.Items[indexOfExistFood].SubItems[1].Text = (amountOfExistFood + amount).ToString();
                }
            }
        }

        private void btnDerease_Click(object sender, EventArgs e)
        {
            if(listOrder.SelectedItems.Count != 0)
            {
                int amountBefor = int.Parse(listOrder.SelectedItems[0].SubItems[1].Text);
                if(amountBefor == 1)
                {
                    listOrder.Items.RemoveAt(listOrder.SelectedIndices[0]);
                }
                else
                    listOrder.SelectedItems[0].SubItems[1].Text = (amountBefor - 1).ToString();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Would you like to reset?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
                listOrder.Items.Clear();
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
