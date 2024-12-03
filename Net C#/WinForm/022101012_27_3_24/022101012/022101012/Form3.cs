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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void listCar_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string carName = listCar.SelectedNode.Text;
            listCarDisplay.Items.Clear();
            if(carName == "SH")
            {
                listCarDisplay.Items.Add("Ducati");
                listCarDisplay.Items[0].SubItems.Add("2012");
                listCarDisplay.Items[0].SubItems.Add("125");
                listCarDisplay.Items[0].SubItems.Add("40000000");
                listCarDisplay.Items.Add("Ducati");
                listCarDisplay.Items[1].SubItems.Add("2013");
                listCarDisplay.Items[1].SubItems.Add("125");
                listCarDisplay.Items[1].SubItems.Add("42000000");
            }

            if (carName == "Spacy")
            {
                listCarDisplay.Items.Add("Yamaha");
                listCarDisplay.Items[0].SubItems.Add("2014");
                listCarDisplay.Items[0].SubItems.Add("150");
                listCarDisplay.Items[0].SubItems.Add("52000000");
            }
            if (carName == "Innova")
            {
                listCarDisplay.Items.Add("Toyo");
                listCarDisplay.Items[0].SubItems.Add("2013");
                listCarDisplay.Items[0].SubItems.Add("100");
                listCarDisplay.Items[0].SubItems.Add("150000000");
            }

            if (carName == "Camry")
            {
                listCarDisplay.Items.Add("Huyndai");
                listCarDisplay.Items[0].SubItems.Add("2012");
                listCarDisplay.Items[0].SubItems.Add("300");
                listCarDisplay.Items[0].SubItems.Add("20000000");
                listCarDisplay.Items.Add("Huyndai");
                listCarDisplay.Items[1].SubItems.Add("2015");
                listCarDisplay.Items[1].SubItems.Add("400");
                listCarDisplay.Items[1].SubItems.Add("50000000");
            }

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            listCar.Nodes.Add("Xe");
            listCar.Nodes[0].Nodes.Add("Xe May");
            listCar.Nodes[0].Nodes.Add("O To");
            listCar.Nodes[0].Nodes[0].Nodes.Add("SH");
            listCar.Nodes[0].Nodes[0].Nodes.Add("Spacy");
            listCar.Nodes[0].Nodes[1].Nodes.Add("Innova");
            listCar.Nodes[0].Nodes[1].Nodes.Add("Camry");
            listCar.ExpandAll();

            payMethod.Items.Add("Tra Gop");
            payMethod.Items.Add("Khong Tra Gop");
           
        }

        private void listCarDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {
            int price = int.Parse(listCarDisplay.SelectedItems[0].SubItems[3].Text);
            string name = listCarDisplay.SelectedItems[0].SubItems[0].Text;
            string year = listCarDisplay.SelectedItems[0].SubItems[1].Text;
            string engine = listCarDisplay.SelectedItems[0].SubItems[2].Text;

            int amount = Convert.ToInt32(numAmount.Value);
            displayPriceTotal.Text = (amount * price).ToString("#,###VND");
        }

        private void numAmount_ValueChanged(object sender, EventArgs e)
        {
            int price = int.Parse(listCarDisplay.SelectedItems[0].SubItems[3].Text);
            int amount = Convert.ToInt32(numAmount.Value);
            displayPriceTotal.Text = (amount * price).ToString("#,###VND");
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (payMethod.SelectedIndex != -1 && displayPriceTotal.Text != "") 
            {
                string price = listCarDisplay.SelectedItems[0].SubItems[3].Text;
                string name = listCarDisplay.SelectedItems[0].SubItems[0].Text;
                string year = listCarDisplay.SelectedItems[0].SubItems[1].Text;
                string engine = listCarDisplay.SelectedItems[0].SubItems[2].Text;
                string information = "Thong tin gom:\r\nHang: " + name + "\r\nNam SX: " + year + "\r\nDong Co: " + engine + "\r\\nGia: " + price + "\r\nSo luong: " + numAmount.Value.ToString() + "\r\nPhuong Thuc Thanh Toan: " + payMethod.SelectedItem + "\r\nTong Tien: " + displayPriceTotal.Text + "\r\n";

            
               MessageBox.Show(information, "Notification!", MessageBoxButtons.OK, MessageBoxIcon.Question);


            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
