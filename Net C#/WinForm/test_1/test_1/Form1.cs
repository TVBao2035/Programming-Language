namespace test_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listSubjects.Items.Add("30073_Cong nghe .NET");
            listSubjects.Items.Add("30043_Tin hoc van phong");
            listSubjects.Items.Add("32153_Lap trinh Data base");
            listSubjects.Items.Add("32304_Data base");
            listSubjects.Items.Add("31303_Toan roi rac");
            listSubjects.Items.Add("31323_Nhap mon lap trinh");
            listSubjects.Items.Add("31333_Ky thuat lap trinh");

        }

        private void listSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            display.Items.Clear();
            for (int i = 0; i < listSubjects.CheckedItems.Count; i++)
            {
                display.Items.Add(listSubjects.CheckedItems[i]);
            }
        }

        private void btnHandle_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for(int i = 0; i < display.Items.Count; i++)
            {
                int r = int.Parse("0" + display.Items[i].ToString()[4]);
                sum += r;
            }
            displayIndex.Text = sum.ToString();
            int money = sum * 350000;
            displayMoney.Text = string.Format("{0:#,###}", money) + "VND";
            /*
            string text = (sum * 350000).ToString();
            int count = 0;
            displayMoney.Text = "";
            for (int i = text.Length - 1; i>= 0; i--)
            {
                count++;
                displayMoney.Text = text[i] + displayMoney.Text ;
                if (count == 3)
                {
                    displayMoney.Text = '.' + displayMoney.Text;
                    count = 0;
                }

            }
            displayMoney.Text = displayMoney.Text + "VND";*/
        }
    }
}
