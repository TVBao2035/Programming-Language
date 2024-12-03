namespace KIEMTRA16_5
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DanhSachDiaChi = new System.Windows.Forms.CheckedListBox();
            this.txtRoomId = new System.Windows.Forms.TextBox();
            this.txtRoomAddress = new System.Windows.Forms.TextBox();
            this.listArea = new System.Windows.Forms.ComboBox();
            this.DanhSachThietBi = new System.Windows.Forms.ListView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnPush = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.pictureRoom = new System.Windows.Forms.PictureBox();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.pictureRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // DanhSachDiaChi
            // 
            this.DanhSachDiaChi.FormattingEnabled = true;
            this.DanhSachDiaChi.Location = new System.Drawing.Point(12, 13);
            this.DanhSachDiaChi.Name = "DanhSachDiaChi";
            this.DanhSachDiaChi.Size = new System.Drawing.Size(227, 174);
            this.DanhSachDiaChi.TabIndex = 0;
            this.DanhSachDiaChi.SelectedIndexChanged += new System.EventHandler(this.DanhSachDiaChi_SelectedIndexChanged);
            // 
            // txtRoomId
            // 
            this.txtRoomId.Location = new System.Drawing.Point(324, 32);
            this.txtRoomId.Name = "txtRoomId";
            this.txtRoomId.Size = new System.Drawing.Size(157, 22);
            this.txtRoomId.TabIndex = 1;
            // 
            // txtRoomAddress
            // 
            this.txtRoomAddress.Location = new System.Drawing.Point(324, 80);
            this.txtRoomAddress.Name = "txtRoomAddress";
            this.txtRoomAddress.Size = new System.Drawing.Size(157, 22);
            this.txtRoomAddress.TabIndex = 1;
            // 
            // listArea
            // 
            this.listArea.FormattingEnabled = true;
            this.listArea.Location = new System.Drawing.Point(324, 140);
            this.listArea.Name = "listArea";
            this.listArea.Size = new System.Drawing.Size(157, 24);
            this.listArea.TabIndex = 2;
            // 
            // DanhSachThietBi
            // 
            this.DanhSachThietBi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.DanhSachThietBi.FullRowSelect = true;
            this.DanhSachThietBi.GridLines = true;
            this.DanhSachThietBi.HideSelection = false;
            this.DanhSachThietBi.Location = new System.Drawing.Point(12, 260);
            this.DanhSachThietBi.Name = "DanhSachThietBi";
            this.DanhSachThietBi.Size = new System.Drawing.Size(776, 178);
            this.DanhSachThietBi.TabIndex = 3;
            this.DanhSachThietBi.UseCompatibleStateImageBehavior = false;
            this.DanhSachThietBi.View = System.Windows.Forms.View.Details;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(206, 204);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "THEM";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnPush
            // 
            this.btnPush.Location = new System.Drawing.Point(324, 204);
            this.btnPush.Name = "btnPush";
            this.btnPush.Size = new System.Drawing.Size(75, 23);
            this.btnPush.TabIndex = 4;
            this.btnPush.Text = "GHI";
            this.btnPush.UseVisualStyleBackColor = true;
            this.btnPush.Click += new System.EventHandler(this.btnPush_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(435, 204);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "HUY";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(562, 204);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "CAPNHAT";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pictureRoom
            // 
            this.pictureRoom.Location = new System.Drawing.Point(550, 3);
            this.pictureRoom.Name = "pictureRoom";
            this.pictureRoom.Size = new System.Drawing.Size(238, 173);
            this.pictureRoom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureRoom.TabIndex = 5;
            this.pictureRoom.TabStop = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "MaTB";
            this.columnHeader1.Width = 106;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "TenTB";
            this.columnHeader2.Width = 128;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "SoLuong";
            this.columnHeader3.Width = 145;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "TriGia";
            this.columnHeader4.Width = 157;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureRoom);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnPush);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.DanhSachThietBi);
            this.Controls.Add(this.listArea);
            this.Controls.Add(this.txtRoomAddress);
            this.Controls.Add(this.txtRoomId);
            this.Controls.Add(this.DanhSachDiaChi);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureRoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox DanhSachDiaChi;
        private System.Windows.Forms.TextBox txtRoomId;
        private System.Windows.Forms.TextBox txtRoomAddress;
        private System.Windows.Forms.ComboBox listArea;
        private System.Windows.Forms.ListView DanhSachThietBi;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnPush;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.PictureBox pictureRoom;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}