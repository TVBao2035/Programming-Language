namespace KIEMTRA16_5
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
            this.comboTable = new System.Windows.Forms.ComboBox();
            this.numericAmount = new System.Windows.Forms.NumericUpDown();
            this.listFood = new System.Windows.Forms.ListBox();
            this.listOrderFood = new System.Windows.Forms.ListView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCalculator = new System.Windows.Forms.Button();
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
            // comboTable
            // 
            this.comboTable.FormattingEnabled = true;
            this.comboTable.Location = new System.Drawing.Point(286, 33);
            this.comboTable.Name = "comboTable";
            this.comboTable.Size = new System.Drawing.Size(121, 24);
            this.comboTable.TabIndex = 0;
            // 
            // numericAmount
            // 
            this.numericAmount.Location = new System.Drawing.Point(286, 81);
            this.numericAmount.Name = "numericAmount";
            this.numericAmount.Size = new System.Drawing.Size(120, 22);
            this.numericAmount.TabIndex = 1;
            // 
            // listFood
            // 
            this.listFood.FormattingEnabled = true;
            this.listFood.ItemHeight = 16;
            this.listFood.Location = new System.Drawing.Point(12, 9);
            this.listFood.Name = "listFood";
            this.listFood.Size = new System.Drawing.Size(199, 180);
            this.listFood.TabIndex = 2;
            // 
            // listOrderFood
            // 
            this.listOrderFood.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listOrderFood.FullRowSelect = true;
            this.listOrderFood.GridLines = true;
            this.listOrderFood.HideSelection = false;
            this.listOrderFood.Location = new System.Drawing.Point(48, 231);
            this.listOrderFood.Name = "listOrderFood";
            this.listOrderFood.Size = new System.Drawing.Size(701, 144);
            this.listOrderFood.TabIndex = 3;
            this.listOrderFood.UseCompatibleStateImageBehavior = false;
            this.listOrderFood.View = System.Windows.Forms.View.Details;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(286, 125);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "THEM";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCalculator
            // 
            this.btnCalculator.Location = new System.Drawing.Point(245, 401);
            this.btnCalculator.Name = "btnCalculator";
            this.btnCalculator.Size = new System.Drawing.Size(75, 23);
            this.btnCalculator.TabIndex = 4;
            this.btnCalculator.Text = "TINH";
            this.btnCalculator.UseVisualStyleBackColor = true;
            this.btnCalculator.Click += new System.EventHandler(this.btnCalculator_Click);
            // 
            // displaySumOfMoney
            // 
            this.displaySumOfMoney.AutoSize = true;
            this.displaySumOfMoney.Location = new System.Drawing.Point(347, 404);
            this.displaySumOfMoney.Name = "displaySumOfMoney";
            this.displaySumOfMoney.Size = new System.Drawing.Size(0, 16);
            this.displaySumOfMoney.TabIndex = 5;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "STT";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ten Mon An";
            this.columnHeader2.Width = 135;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "So Ban";
            this.columnHeader3.Width = 110;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "So luong";
            this.columnHeader4.Width = 133;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Don Gia";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Thanh Tien";
            this.columnHeader6.Width = 110;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.displaySumOfMoney);
            this.Controls.Add(this.btnCalculator);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.listOrderFood);
            this.Controls.Add(this.listFood);
            this.Controls.Add(this.numericAmount);
            this.Controls.Add(this.comboTable);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboTable;
        private System.Windows.Forms.NumericUpDown numericAmount;
        private System.Windows.Forms.ListBox listFood;
        private System.Windows.Forms.ListView listOrderFood;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCalculator;
        private System.Windows.Forms.Label displaySumOfMoney;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}

