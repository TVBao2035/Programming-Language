using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KiemTra
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
            comboTable.Items.Add("Table 1");
            comboTable.Items.Add("Table 2");
            comboTable.Items.Add("Table 3");
            comboTable.Items.Add("Table 4");
            comboTable.Items.Add("Table 5");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            int foodOrderCount= listFood.CheckedItems.Count;
            string tableNum = comboTable.SelectedItem.ToString();
            decimal amount = amountFood.Value;
            int currentIndex = listOrder.Items.Count;
            for(int i=0; i<foodOrderCount; i++)
            {
                listOrder.Items.Add((currentIndex+1).ToString());
                listOrder.Items[currentIndex].SubItems.Add(listFood.CheckedItems[i].ToString());
                listOrder.Items[currentIndex].SubItems.Add(tableNum);
                listOrder.Items[currentIndex].SubItems.Add(amount.ToString());
                int price = listFood.CheckedIndices[i] * 10000;
                listOrder.Items[currentIndex].SubItems.Add(price.ToString());
                listOrder.Items[currentIndex].SubItems.Add((price * amount).ToString());
                currentIndex++;
                
            }

        }

        private void btnCalculator_Click(object sender, EventArgs e)
        {
            int countOrder = listOrder.Items.Count;
            int sum = 0;
            for(int i=0; i<countOrder; i++)
            {
                sum += int.Parse(listOrder.Items[i].SubItems[5].Text);   
            }
            displaySumOfAllMoney.Text = sum.ToString();
        }
    }
}
