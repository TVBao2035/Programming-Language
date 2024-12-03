using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LuyenCoNao_1
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
            listFood.Items.Add("Ban Plan");
            listFood.Items.Add("Bun Thit Nuong");
            listFood.Items.Add("Ga Hap Chao");
            comboTable.Items.Add("Ban 1");
            comboTable.Items.Add("Ban 2");
            comboTable.Items.Add("Ban 3");
            comboTable.Items.Add("Ban 4");
            comboTable.Items.Add("Ban 5");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int length = listFood.CheckedItems.Count;
            int index = listOrder.Items.Count;
            for(int i=0; i<length; i++)
            {
                decimal amount = numericAmount.Value;
                int price = (listFood.CheckedIndices[i] + 1) * 10000;
                listOrder.Items.Add((index + 1).ToString());
                listOrder.Items[index].SubItems.Add(listFood.CheckedItems[i].ToString());
                listOrder.Items[index].SubItems.Add(comboTable.SelectedItem.ToString());
                listOrder.Items[index].SubItems.Add(amount.ToString());
                listOrder.Items[index].SubItems.Add(price.ToString());
                listOrder.Items[index].SubItems.Add((amount*price).ToString());
                index++;
            }
        }

        private void btnCalculator_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for(int i=0; i<listOrder.Items.Count; i++)
            {
                sum += int.Parse(listOrder.Items[i].SubItems[5].Text);
            }
            displaySumOfMoney.Text = sum.ToString("#,000");
        }
    }
}
