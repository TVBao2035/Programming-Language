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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public void displayAllRoomAddress()
        {
            listRoomAddress.Items.Clear();
            DataTable data = new DataTable();
            data = Room.getAllRoomAddress();
            for(int i=0; i<data.Rows.Count; i++)
            {
                listRoomAddress.Items.Add(data.Rows[i][0].ToString());
            }
        }
        public void displayAllAreaName()
        {
            DataTable data = new DataTable();
            data = Room.getAllAreaName();
            listArea.DataSource = data;
            listArea.DisplayMember = "TenKV";
            listArea.ValueMember = "IdMaKV";
            
        }
        public void displayAllInformationCustomer(string roomID)
        {
            listCustomer.Items.Clear();
            DataTable data = new DataTable();
            data = Room.getInformationRoomAndCustomer(roomID);
            for (int i = 0; i < data.Rows.Count; i++)
            {
                listCustomer.Items.Add(data.Rows[i]["IdMaKH"].ToString());
                listCustomer.Items[i].SubItems.Add(data.Rows[i]["Hoten"].ToString());
                listCustomer.Items[i].SubItems.Add(data.Rows[i]["Sodt"].ToString());
                listCustomer.Items[i].SubItems.Add(data.Rows[i]["ngaylap"].ToString());
                listCustomer.Items[i].SubItems.Add(data.Rows[i]["Sotien"].ToString());

            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            displayAllRoomAddress();
            displayAllAreaName();
        }
        public void clearAllInputs()
        {
            txtRoomId.Text = "";
            txtAddress.Text = "";
            listArea.Text = "";
        }
        private void listRoomAddress_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listRoomAddress.CheckedItems.Count != 0)
            {
                DataTable data = new DataTable();
                data = Room.getInformationByAddress(listRoomAddress.CheckedItems[0].ToString());
                txtRoomId.Text = data.Rows[0]["IdMaPT"].ToString();
                txtAddress.Text = data.Rows[0]["DiaChi"].ToString();
                listArea.Text = data.Rows[0]["TenKV"].ToString();
                displayAllInformationCustomer(data.Rows[0]["IdMaPT"].ToString());
                string idString = data.Rows[0]["IdMaPT"].ToString();
                int idPicture = int.Parse(idString.Substring(2, idString.Length-2));
                pictureRoom.Load("PT00" + idPicture.ToString() + ".jpg");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            clearAllInputs();
            DataTable data = new DataTable();
            data = Room.getMaxRoomId();
            string maxRoomId = data.Rows[0][0].ToString();
            maxRoomId ="PT" + (int.Parse(maxRoomId.Substring(2, maxRoomId.Length - 2))+1).ToString("000");
            txtRoomId.Text = maxRoomId;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Room.insertRoom(txtRoomId.Text, txtAddress.Text, listArea.SelectedValue.ToString());
            displayAllRoomAddress();
            clearAllInputs();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Room.deleteRoom(txtRoomId.Text);
            displayAllRoomAddress();
            clearAllInputs();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Room.updateRoom(txtRoomId.Text, txtAddress.Text, listArea.SelectedValue.ToString());
            displayAllRoomAddress();
            clearAllInputs();
        }
    }
}
