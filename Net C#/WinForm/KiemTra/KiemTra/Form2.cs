using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KiemTra
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public void displayAllAddressRoom()
        {
            listAddressRoom.Items.Clear();   
            DataTable data = new DataTable();
            data = ControllRooms.getAddressAllRoom();
            int length = data.Rows.Count;
            for(int i=0; i< length; i++)
            {
                listAddressRoom.Items.Add(data.Rows[i]["Diachi"].ToString());
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            displayAllAddressRoom();
            displayAreaName();
        }
        public void displayInforCustomer(string idRoom)
        {
            listCustomer.Items.Clear();
            DataTable data = new DataTable();
            data = ControllRooms.getAllInforTicket(idRoom);
            int length = data.Rows.Count;
            for(int i=0; i<length; i++)
            {
                listCustomer.Items.Add(data.Rows[i]["IdMaKH"].ToString());
                listCustomer.Items[i].SubItems.Add(data.Rows[i]["Hoten"].ToString());
                listCustomer.Items[i].SubItems.Add(data.Rows[i]["Sodt"].ToString());
                listCustomer.Items[i].SubItems.Add(data.Rows[i]["ngaylap"].ToString());
                listCustomer.Items[i].SubItems.Add(data.Rows[i]["Sotien"].ToString());
            }
            
        }
        private void listAddressRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable selectedData = new DataTable();
            selectedData = ControllRooms.getAddressAllRoom();
            if(listAddressRoom.CheckedIndices.Count != 0)
            {
                string idRoom = selectedData.Rows[listAddressRoom.CheckedIndices[0]]["IdMaPT"].ToString();
                DataTable data = new DataTable();
                data = ControllRooms.getAllInforRoom(idRoom);
                textId.Text = data.Rows[0]["IdMaPT"].ToString();
                textAddress.Text = data.Rows[0]["Diachi"].ToString();
                comboArea.Text = data.Rows[0]["TenKV"].ToString();
                displayInforCustomer(idRoom);
                int index = listAddressRoom.CheckedIndices[0] % 10;
               
                pictureRoom.Load("PT00"+index.ToString()+".jpg");
            }
           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataTable data = new DataTable();
            data = ControllRooms.getMaxIdRoom();
            string idMaxRoom = data.Rows[0][0].ToString();
            idMaxRoom = "PT" + (int.Parse(idMaxRoom.Substring(2,idMaxRoom.Length-2)) + 1).ToString("000");
            textId.Text = idMaxRoom;
        }
        public void displayAreaName()
        {
            DataTable data = new DataTable();
            data = ControllRooms.getAreaName();
            comboArea.DataSource = data;
            comboArea.DisplayMember = "TenKV";
            comboArea.ValueMember = "IdMaKV";
        }
        public void clearAllInputs()
        {
            textId.Text = "";
            textAddress.Text = "";
            comboArea.Text = "";
        }
        private void btnWrite_Click(object sender, EventArgs e)
        {
            ControllRooms.InsertRoom(textId.Text, textAddress.Text, comboArea.SelectedValue.ToString());
            clearAllInputs();
            displayAllAddressRoom();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ControllRooms.DeleteRoom(textId.Text);
            clearAllInputs();
            displayAllAddressRoom();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ControllRooms.UpdateRoom(textId.Text, textAddress.Text, comboArea.SelectedValue.ToString());
            clearAllInputs();
            displayAllAddressRoom();
        }
    }
}
