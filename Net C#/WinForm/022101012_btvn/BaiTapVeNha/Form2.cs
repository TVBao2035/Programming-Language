using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapVeNha
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            listSubejcts.Items.Add("30073_Công nghệ .NET");
            listSubejcts.Items.Add("30043_Tin học văn phòng");
            listSubejcts.Items.Add("32153_Lập trình cơ sở dữ liệu");
            listSubejcts.Items.Add("32304_Cơ sở dữ liệu");
            listSubejcts.Items.Add("31303_Toán rời rạc");
            listSubejcts.Items.Add("31323_Nhập môn lập trình");
            listSubejcts.Items.Add("31333_Kỹ thuật lập trình");
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            for(int i=0; i<listSubejcts.CheckedItems.Count; i++)
            {
                listRegister.Items.Add(listSubejcts.CheckedItems[i]);
            }

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int creditCount = 0;
            for(int i=0; i < listRegister.Items.Count; i++)
            {
                creditCount +=  int.Parse("0" + listRegister.Items[i].ToString()[4]);
            }

            creditSum.Text = "Sum Of Credits Registered: " + creditCount.ToString();
            moneySum.Text = "Sum Of Money: " + (creditCount * 350000).ToString("#,### VND") ;
        }
    }
}
