namespace KiemTra
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
            this.listAddressRoom = new System.Windows.Forms.CheckedListBox();
            this.textId = new System.Windows.Forms.TextBox();
            this.textAddress = new System.Windows.Forms.TextBox();
            this.comboArea = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnWrite = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.listCustomer = new System.Windows.Forms.ListView();
            this.pictureRoom = new System.Windows.Forms.PictureBox();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.pictureRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // listAddressRoom
            // 
            this.listAddressRoom.FormattingEnabled = true;
            this.listAddressRoom.Location = new System.Drawing.Point(13, 13);
            this.listAddressRoom.Name = "listAddressRoom";
            this.listAddressRoom.Size = new System.Drawing.Size(188, 208);
            this.listAddressRoom.TabIndex = 0;
            this.listAddressRoom.SelectedIndexChanged += new System.EventHandler(this.listAddressRoom_SelectedIndexChanged);
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(227, 13);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(219, 22);
            this.textId.TabIndex = 1;
            // 
            // textAddress
            // 
            this.textAddress.Location = new System.Drawing.Point(229, 70);
            this.textAddress.Name = "textAddress";
            this.textAddress.Size = new System.Drawing.Size(217, 22);
            this.textAddress.TabIndex = 1;
            // 
            // comboArea
            // 
            this.comboArea.FormattingEnabled = true;
            this.comboArea.Location = new System.Drawing.Point(229, 122);
            this.comboArea.Name = "comboArea";
            this.comboArea.Size = new System.Drawing.Size(217, 24);
            this.comboArea.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(254, 183);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 33);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(362, 183);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(75, 33);
            this.btnWrite.TabIndex = 3;
            this.btnWrite.Text = "write";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(477, 183);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 33);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(598, 183);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 33);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // listCustomer
            // 
            this.listCustomer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listCustomer.FullRowSelect = true;
            this.listCustomer.GridLines = true;
            this.listCustomer.HideSelection = false;
            this.listCustomer.Location = new System.Drawing.Point(13, 259);
            this.listCustomer.Name = "listCustomer";
            this.listCustomer.Size = new System.Drawing.Size(757, 179);
            this.listCustomer.TabIndex = 4;
            this.listCustomer.UseCompatibleStateImageBehavior = false;
            this.listCustomer.View = System.Windows.Forms.View.Details;
            // 
            // pictureRoom
            // 
            this.pictureRoom.Location = new System.Drawing.Point(534, 13);
            this.pictureRoom.Name = "pictureRoom";
            this.pictureRoom.Size = new System.Drawing.Size(236, 133);
            this.pictureRoom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureRoom.TabIndex = 5;
            this.pictureRoom.TabStop = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "MaKH";
            this.columnHeader1.Width = 117;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Hoten";
            this.columnHeader2.Width = 137;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "SDT";
            this.columnHeader3.Width = 121;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "NgayLap";
            this.columnHeader4.Width = 126;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "So Tien";
            this.columnHeader5.Width = 123;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureRoom);
            this.Controls.Add(this.listCustomer);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.comboArea);
            this.Controls.Add(this.textAddress);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.listAddressRoom);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureRoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox listAddressRoom;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.TextBox textAddress;
        private System.Windows.Forms.ComboBox comboArea;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ListView listCustomer;
        private System.Windows.Forms.PictureBox pictureRoom;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}