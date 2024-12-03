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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            comboBoxList.Items.Add("Nuoc Uong");
            comboBoxList.Items.Add("Nuoc Ep");
            comboBoxList.Items.Add("Sinh To");
        }

        private void comboBoxList_SelectedIndexChanged(object sender, EventArgs e)
        {
            listDrinks.Items.Clear();
            if(comboBoxList.SelectedIndex == 0)
            {
                listDrinks.Items.Add("1");
                listDrinks.Items[0].SubItems.Add("cafe");
                listDrinks.Items[0].SubItems.Add("10000");

                listDrinks.Items.Add("2");
                listDrinks.Items[1].SubItems.Add("cafe-sua");
                listDrinks.Items[1].SubItems.Add("12000");

                listDrinks.Items.Add("3");
                listDrinks.Items[2].SubItems.Add("Pesi");
                listDrinks.Items[2].SubItems.Add("9000");

            }

            if (comboBoxList.SelectedIndex == 1)
            {
                listDrinks.Items.Add("1");
                listDrinks.Items[0].SubItems.Add("Ep Cam");
                listDrinks.Items[0].SubItems.Add("20000");

                listDrinks.Items.Add("2");
                listDrinks.Items[1].SubItems.Add("Ep Dua");
                listDrinks.Items[1].SubItems.Add("18000");

                listDrinks.Items.Add("3");
                listDrinks.Items[2].SubItems.Add("Ep Dau");
                listDrinks.Items[2].SubItems.Add("30000");

            }
            if (comboBoxList.SelectedIndex == 2)
            {
                listDrinks.Items.Add("1");
                listDrinks.Items[0].SubItems.Add("Sinh to bo");
                listDrinks.Items[0].SubItems.Add("20000");

                listDrinks.Items.Add("2");
                listDrinks.Items[1].SubItems.Add("Sinh to xoai");
                listDrinks.Items[1].SubItems.Add("15000");

                listDrinks.Items.Add("3");
                listDrinks.Items[2].SubItems.Add("Sinh to dau");
                listDrinks.Items[2].SubItems.Add("25000");

            }
        }

        int searchItem(string name, ListView list)
        {
            for(int i = 0; i < list.Items.Count; i++)
            {
                if(name == list.Items[i].SubItems[0].Text)
                {
                    return i;
                }
            }
            return -1;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {

            string name = listDrinks.Items[listDrinks.SelectedIndices[0]].SubItems[1].Text;
            int price = int.Parse(listDrinks.Items[listDrinks.SelectedIndices[0]].SubItems[2].Text);
            int index = searchItem(name, listOrder);
            if (index != -1)
            {
                int amount = int.Parse(listOrder.Items[index].SubItems[1].Text);
                amount++;
                listOrder.Items[index].SubItems[1].Text = (amount).ToString();
                listOrder.Items[index].SubItems[2].Text = (amount * price).ToString();
            }
            else
            {
                listOrder.Items.Add(name);
                listOrder.Items[listOrder.Items.Count - 1].SubItems.Add("1");
                listOrder.Items[listOrder.Items.Count - 1].SubItems.Add(price.ToString());
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(listOrder.SelectedItems.Count != 0)
            {
                int index = listOrder.SelectedIndices[0];
                int amount = int.Parse(listOrder.Items[index].SubItems[1].Text);
                int price = int.Parse(listOrder.Items[index].SubItems[2].Text);
                if (amount > 1)
                {
                    listOrder.Items[index].SubItems[1].Text = (amount-1).ToString();
                    listOrder.SelectedItems[0].SubItems[2].Text = (price - price/amount ).ToString();
                }
                else {
                    listOrder.Items.RemoveAt(index);
                }
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for(int i = 0; i < listOrder.Items.Count; i++)
            {
                sum += int.Parse(listOrder.Items[i].SubItems[2].Text);
            }
            displayResul.Text = sum.ToString("#,###VND");
        }
    }
}
