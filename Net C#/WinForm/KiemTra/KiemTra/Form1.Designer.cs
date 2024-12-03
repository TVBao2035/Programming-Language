namespace KiemTra
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
            this.comboTable = new System.Windows.Forms.ComboBox();
            this.amountFood = new System.Windows.Forms.NumericUpDown();
            this.listOrder = new System.Windows.Forms.ListView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCalculator = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.displaySumOfAllMoney = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.amountFood)).BeginInit();
            this.SuspendLayout();
            // 
            // listFood
            // 
            this.listFood.FormattingEnabled = true;
            this.listFood.Location = new System.Drawing.Point(12, 11);
            this.listFood.Name = "listFood";
            this.listFood.Size = new System.Drawing.Size(206, 191);
            this.listFood.TabIndex = 0;
            // 
            // comboTable
            // 
            this.comboTable.FormattingEnabled = true;
            this.comboTable.Location = new System.Drawing.Point(224, 47);
            this.comboTable.Name = "comboTable";
            this.comboTable.Size = new System.Drawing.Size(204, 24);
            this.comboTable.TabIndex = 1;
            // 
            // amountFood
            // 
            this.amountFood.Location = new System.Drawing.Point(224, 125);
            this.amountFood.Name = "amountFood";
            this.amountFood.Size = new System.Drawing.Size(204, 22);
            this.amountFood.TabIndex = 2;
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
            this.listOrder.Location = new System.Drawing.Point(12, 208);
            this.listOrder.Name = "listOrder";
            this.listOrder.Size = new System.Drawing.Size(766, 185);
            this.listOrder.TabIndex = 3;
            this.listOrder.UseCompatibleStateImageBehavior = false;
            this.listOrder.View = System.Windows.Forms.View.Details;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(261, 162);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 30);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCalculator
            // 
            this.btnCalculator.Location = new System.Drawing.Point(261, 399);
            this.btnCalculator.Name = "btnCalculator";
            this.btnCalculator.Size = new System.Drawing.Size(75, 39);
            this.btnCalculator.TabIndex = 4;
            this.btnCalculator.Text = "Calculator";
            this.btnCalculator.UseVisualStyleBackColor = true;
            this.btnCalculator.Click += new System.EventHandler(this.btnCalculator_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "STT";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 113;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Number Table";
            this.columnHeader3.Width = 135;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Amount";
            this.columnHeader4.Width = 134;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Price";
            this.columnHeader5.Width = 129;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Sum Of Money";
            this.columnHeader6.Width = 176;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(352, 410);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sum of all money: ";
            // 
            // displaySumOfAllMoney
            // 
            this.displaySumOfAllMoney.AutoSize = true;
            this.displaySumOfAllMoney.Location = new System.Drawing.Point(484, 410);
            this.displaySumOfAllMoney.Name = "displaySumOfAllMoney";
            this.displaySumOfAllMoney.Size = new System.Drawing.Size(0, 16);
            this.displaySumOfAllMoney.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.displaySumOfAllMoney);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalculator);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.listOrder);
            this.Controls.Add(this.amountFood);
            this.Controls.Add(this.comboTable);
            this.Controls.Add(this.listFood);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.amountFood)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox listFood;
        private System.Windows.Forms.ComboBox comboTable;
        private System.Windows.Forms.NumericUpDown amountFood;
        private System.Windows.Forms.ListView listOrder;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCalculator;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label displaySumOfAllMoney;
    }
}

