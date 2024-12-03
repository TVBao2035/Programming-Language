namespace ex_20_9
{
    partial class baitap2
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
            this.lstdata = new System.Windows.Forms.ListBox();
            this.cbtable = new System.Windows.Forms.ComboBox();
            this.databang = new System.Windows.Forms.DataGridView();
            this.txtmadg = new System.Windows.Forms.TextBox();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.time = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lbbangdocgia = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btthem = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            this.btapnhat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.databang)).BeginInit();
            this.SuspendLayout();
            // 
            // lstdata
            // 
            this.lstdata.FormattingEnabled = true;
            this.lstdata.ItemHeight = 25;
            this.lstdata.Location = new System.Drawing.Point(12, 21);
            this.lstdata.Name = "lstdata";
            this.lstdata.Size = new System.Drawing.Size(273, 429);
            this.lstdata.TabIndex = 0;
            // 
            // cbtable
            // 
            this.cbtable.FormattingEnabled = true;
            this.cbtable.Location = new System.Drawing.Point(472, 10);
            this.cbtable.Name = "cbtable";
            this.cbtable.Size = new System.Drawing.Size(283, 33);
            this.cbtable.TabIndex = 1;
            this.cbtable.SelectedIndexChanged += new System.EventHandler(this.cbtable_SelectedIndexChanged);
            // 
            // databang
            // 
            this.databang.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.databang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.databang.Location = new System.Drawing.Point(310, 38);
            this.databang.Name = "databang";
            this.databang.Size = new System.Drawing.Size(685, 239);
            this.databang.TabIndex = 2;
            this.databang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.databang_CellContentClick);
            // 
            // txtmadg
            // 
            this.txtmadg.Location = new System.Drawing.Point(395, 336);
            this.txtmadg.Name = "txtmadg";
            this.txtmadg.Size = new System.Drawing.Size(163, 30);
            this.txtmadg.TabIndex = 3;
            // 
            // txtsdt
            // 
            this.txtsdt.Location = new System.Drawing.Point(673, 336);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(163, 30);
            this.txtsdt.TabIndex = 3;
            // 
            // txthoten
            // 
            this.txthoten.Location = new System.Drawing.Point(395, 392);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(281, 30);
            this.txthoten.TabIndex = 3;
            // 
            // time
            // 
            this.time.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.time.Location = new System.Drawing.Point(415, 428);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(261, 30);
            this.time.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(341, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Bảng Độc Giả ";
            // 
            // lbbangdocgia
            // 
            this.lbbangdocgia.AutoSize = true;
            this.lbbangdocgia.Location = new System.Drawing.Point(591, 294);
            this.lbbangdocgia.Name = "lbbangdocgia";
            this.lbbangdocgia.Size = new System.Drawing.Size(64, 25);
            this.lbbangdocgia.TabIndex = 5;
            this.lbbangdocgia.Text = "label1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(305, 341);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mã ĐG";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(305, 392);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Họ Tên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(292, 428);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ngày Sinh ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(594, 339);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Số Dt";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(341, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 25);
            this.label7.TabIndex = 5;
            this.label7.Text = "Các table";
            // 
            // btthem
            // 
            this.btthem.Location = new System.Drawing.Point(887, 294);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(108, 35);
            this.btthem.TabIndex = 6;
            this.btthem.Text = "Thêm";
            this.btthem.UseVisualStyleBackColor = true;
            this.btthem.Click += new System.EventHandler(this.btthem_Click);
            // 
            // btxoa
            // 
            this.btxoa.Location = new System.Drawing.Point(887, 336);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(108, 35);
            this.btxoa.TabIndex = 6;
            this.btxoa.Text = "Xóa";
            this.btxoa.UseVisualStyleBackColor = true;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // btapnhat
            // 
            this.btapnhat.Location = new System.Drawing.Point(887, 401);
            this.btapnhat.Name = "btapnhat";
            this.btapnhat.Size = new System.Drawing.Size(108, 35);
            this.btapnhat.TabIndex = 6;
            this.btapnhat.Text = "Cập nhật";
            this.btapnhat.UseVisualStyleBackColor = true;
            this.btapnhat.Click += new System.EventHandler(this.btapnhat_Click);
            // 
            // baitap2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 470);
            this.Controls.Add(this.btapnhat);
            this.Controls.Add(this.btxoa);
            this.Controls.Add(this.btthem);
            this.Controls.Add(this.lbbangdocgia);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.time);
            this.Controls.Add(this.txthoten);
            this.Controls.Add(this.txtsdt);
            this.Controls.Add(this.txtmadg);
            this.Controls.Add(this.databang);
            this.Controls.Add(this.cbtable);
            this.Controls.Add(this.lstdata);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "baitap2";
            this.Text = "baitap2";
            this.Load += new System.EventHandler(this.baitap2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstdata;
        private System.Windows.Forms.ComboBox cbtable;
        private System.Windows.Forms.DataGridView databang;
        private System.Windows.Forms.TextBox txtmadg;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.DateTimePicker time;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbbangdocgia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button btapnhat;
    }
}