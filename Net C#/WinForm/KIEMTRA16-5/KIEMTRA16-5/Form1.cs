using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KIEMTRA16_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listFood.Items.Add("Goi Cuon");
            listFood.Items.Add("Banh Plan");
            listFood.Items.Add("Bun Thit Nuong");
            listFood.Items.Add("Ga Hap Chao");
            listFood.Items.Add("Bun Bo Hue");

            comboTable.Items.Add("Ban 1");
            comboTable.Items.Add("Ban 2");
            comboTable.Items.Add("Ban 3");
            comboTable.Items.Add("Ban 4");
            comboTable.Items.Add("Ban 5");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string food = listFood.SelectedItem.ToString();
            int price = (listFood.SelectedIndex+1)*10000;
            decimal amount = numericAmount.Value;
            int lengthOfListOrderFood = listOrderFood.Items.Count;
            listOrderFood.Items.Add((lengthOfListOrderFood + 1).ToString());
            listOrderFood.Items[lengthOfListOrderFood].SubItems.Add(food);
            listOrderFood.Items[lengthOfListOrderFood].SubItems.Add(comboTable.SelectedItem.ToString());
            listOrderFood.Items[lengthOfListOrderFood].SubItems.Add(amount.ToString());
            listOrderFood.Items[lengthOfListOrderFood].SubItems.Add(price.ToString());
            listOrderFood.Items[lengthOfListOrderFood].SubItems.Add((price * amount).ToString());
        }

        private void btnCalculator_Click(object sender, EventArgs e)
        {
            int sum = 0;
            int length = listOrderFood.Items.Count;
            for(int i=0; i<length; i++)
            {
                sum += int.Parse(listOrderFood.Items[i].SubItems[5].Text);
            }
            displaySumOfMoney.Text = "Tong Tien La:" + sum.ToString();
        }
    }
}
