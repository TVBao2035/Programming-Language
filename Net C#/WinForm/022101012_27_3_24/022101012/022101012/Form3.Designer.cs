namespace _022101012
{
    partial class Form3
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
            this.listCar = new System.Windows.Forms.TreeView();
            this.listCarDisplay = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.numAmount = new System.Windows.Forms.NumericUpDown();
            this.displayPriceTotal = new System.Windows.Forms.Label();
            this.payMethod = new System.Windows.Forms.ComboBox();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // listCar
            // 
            this.listCar.Location = new System.Drawing.Point(29, 41);
            this.listCar.Name = "listCar";
            this.listCar.Size = new System.Drawing.Size(242, 266);
            this.listCar.TabIndex = 0;
            this.listCar.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.listCar_AfterSelect);
            // 
            // listCarDisplay
            // 
            this.listCarDisplay.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listCarDisplay.FullRowSelect = true;
            this.listCarDisplay.GridLines = true;
            this.listCarDisplay.HideSelection = false;
            this.listCarDisplay.Location = new System.Drawing.Point(327, 83);
            this.listCarDisplay.Name = "listCarDisplay";
            this.listCarDisplay.Size = new System.Drawing.Size(471, 180);
            this.listCarDisplay.TabIndex = 1;
            this.listCarDisplay.UseCompatibleStateImageBehavior = false;
            this.listCarDisplay.View = System.Windows.Forms.View.Details;
            this.listCarDisplay.SelectedIndexChanged += new System.EventHandler(this.listCarDisplay_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Hang";
            this.columnHeader1.Width = 149;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nam SX";
            this.columnHeader2.Width = 113;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Dong Co";
            this.columnHeader3.Width = 107;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Gia";
            // 
            // numAmount
            // 
            this.numAmount.Location = new System.Drawing.Point(107, 338);
            this.numAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numAmount.Name = "numAmount";
            this.numAmount.Size = new System.Drawing.Size(176, 22);
            this.numAmount.TabIndex = 2;
            this.numAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numAmount.ValueChanged += new System.EventHandler(this.numAmount_ValueChanged);
            // 
            // displayPriceTotal
            // 
            this.displayPriceTotal.AutoSize = true;
            this.displayPriceTotal.Location = new System.Drawing.Point(104, 390);
            this.displayPriceTotal.Name = "displayPriceTotal";
            this.displayPriceTotal.Size = new System.Drawing.Size(0, 16);
            this.displayPriceTotal.TabIndex = 3;
            // 
            // payMethod
            // 
            this.payMethod.AllowDrop = true;
            this.payMethod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.payMethod.DisplayMember = "Tra Gop";
            this.payMethod.FormattingEnabled = true;
            this.payMethod.Location = new System.Drawing.Point(394, 332);
            this.payMethod.Name = "payMethod";
            this.payMethod.Size = new System.Drawing.Size(209, 24);
            this.payMethod.TabIndex = 4;
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(394, 374);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(75, 48);
            this.btnOrder.TabIndex = 5;
            this.btnOrder.Text = "Dat Hang";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(528, 374);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 48);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 390);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tong Tien:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "So luong: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Danh Sach Xe:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(324, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Thong Tin Chi TIet Ve Xe:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(391, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Phuong Thuc Thanh Toan:";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.payMethod);
            this.Controls.Add(this.displayPriceTotal);
            this.Controls.Add(this.numAmount);
            this.Controls.Add(this.listCarDisplay);
            this.Controls.Add(this.listCar);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView listCar;
        private System.Windows.Forms.ListView listCarDisplay;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.NumericUpDown numAmount;
        private System.Windows.Forms.Label displayPriceTotal;
        private System.Windows.Forms.ComboBox payMethod;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}