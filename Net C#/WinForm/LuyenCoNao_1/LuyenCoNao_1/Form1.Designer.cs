namespace LuyenCoNao_1
{
    partial class Form1
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
            this.listFood = new System.Windows.Forms.CheckedListBox();
            this.listOrder = new System.Windows.Forms.ListView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCalculator = new System.Windows.Forms.Button();
            this.comboTable = new System.Windows.Forms.ComboBox();
            this.numericAmount = new System.Windows.Forms.NumericUpDown();
            this.displaySumOfMoney = new System.Windows.Forms.Label();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.numericAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // listFood
            // 
            this.listFood.FormattingEnabled = true;
            this.listFood.Location = new System.Drawing.Point(12, 36);
            this.listFood.Name = "listFood";
            this.listFood.Size = new System.Drawing.Size(173, 174);
            this.listFood.TabIndex = 0;
            // 
            // listOrder
            // 
            this.listOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listOrder.FullRowSelect = true;
            this.listOrder.GridLines = true;
            this.listOrder.HideSelection = false;
            this.listOrder.Location = new System.Drawing.Point(68, 255);
            this.listOrder.Name = "listOrder";
            this.listOrder.Size = new System.Drawing.Size(778, 129);
            this.listOrder.TabIndex = 1;
            this.listOrder.UseCompatibleStateImageBehavior = false;
            this.listOrder.View = System.Windows.Forms.View.Details;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(290, 155);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "button1";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCalculator
            // 
            this.btnCalculator.Location = new System.Drawing.Point(225, 399);
            this.btnCalculator.Name = "btnCalculator";
            this.btnCalculator.Size = new System.Drawing.Size(75, 23);
            this.btnCalculator.TabIndex = 2;
            this.btnCalculator.Text = "button1";
            this.btnCalculator.UseVisualStyleBackColor = true;
            this.btnCalculator.Click += new System.EventHandler(this.btnCalculator_Click);
            // 
            // comboTable
            // 
            this.comboTable.FormattingEnabled = true;
            this.comboTable.Location = new System.Drawing.Point(302, 36);
            this.comboTable.Name = "comboTable";
            this.comboTable.Size = new System.Drawing.Size(121, 24);
            this.comboTable.TabIndex = 3;
            // 
            // numericAmount
            // 
            this.numericAmount.Location = new System.Drawing.Point(303, 93);
            this.numericAmount.Name = "numericAmount";
            this.numericAmount.Size = new System.Drawing.Size(120, 22);
            this.numericAmount.TabIndex = 4;
            // 
            // displaySumOfMoney
            // 
            this.displaySumOfMoney.AutoSize = true;
            this.displaySumOfMoney.Location = new System.Drawing.Point(366, 405);
            this.displaySumOfMoney.Name = "displaySumOfMoney";
            this.displaySumOfMoney.Size = new System.Drawing.Size(44, 16);
            this.displaySumOfMoney.TabIndex = 5;
            this.displaySumOfMoney.Text = "label1";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "STT";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ten Mon An";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ban";
            this.columnHeader3.Width = 82;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "So Luong";
            this.columnHeader4.Width = 83;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Don Gia";
            this.columnHeader5.Width = 164;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Thanh Tien";
            this.columnHeader6.Width = 143;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 450);
            this.Controls.Add(this.displaySumOfMoney);
            this.Controls.Add(this.numericAmount);
            this.Controls.Add(this.comboTable);
            this.Controls.Add(this.btnCalculator);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.listOrder);
            this.Controls.Add(this.listFood);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox listFood;
        private System.Windows.Forms.ListView listOrder;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCalculator;
        private System.Windows.Forms.ComboBox comboTable;
        private System.Windows.Forms.NumericUpDown numericAmount;
        private System.Windows.Forms.Label displaySumOfMoney;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}

