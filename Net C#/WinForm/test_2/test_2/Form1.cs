namespace test_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listFood.Items.Add("Thit kho trung");
            listFood.Items.Add("Tom rang thit");
            listFood.Items.Add("Ca sot ca");
            listFood.Items.Add("Muc sao");
            listFood.Items.Add("Canh chua");
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            listOrder.Items.Add(listFood.SelectedItem);
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            amountFood.Text = "Tong so mon an da chon: " + listOrder.Items.Count.ToString();
            txtResult.Text += "Ho ten: " + txtName.Text + "\r\n" + "Ngay dat: " + txtDateTime.Text + "\r\n" + "Mon an da chon: ";
            for (int i = 0; i < listOrder.Items.Count; i++)
            {
                txtResult.Text += listOrder.Items[i].ToString();
                if (i != listOrder.Items.Count - 1)
                {
                    txtResult.Text += ", ";
                }
            }

        }

        private void btnDistroy_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
            txtName.Text = "";
            txtDateTime.Text = "";
            listOrder.Items.Clear();
            amountFood.Text = "";
        }
    }
}
