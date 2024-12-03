namespace test
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
            this.listFood = new System.Windows.Forms.ListView();
            this.kindOfMeals = new System.Windows.Forms.ComboBox();
            this.listOrder = new System.Windows.Forms.ListBox();
            this.btnChoose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.displayChosenTotal = new System.Windows.Forms.Label();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listFood
            // 
            this.listFood.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listFood.FullRowSelect = true;
            this.listFood.GridLines = true;
            this.listFood.HideSelection = false;
            this.listFood.Location = new System.Drawing.Point(12, 154);
            this.listFood.Name = "listFood";
            this.listFood.Size = new System.Drawing.Size(356, 216);
            this.listFood.TabIndex = 0;
            this.listFood.UseCompatibleStateImageBehavior = false;
            this.listFood.View = System.Windows.Forms.View.Details;
            this.listFood.SelectedIndexChanged += new System.EventHandler(this.listFood_SelectedIndexChanged);
            this.listFood.Click += new System.EventHandler(this.listFood_Click);
            // 
            // kindOfMeals
            // 
            this.kindOfMeals.FormattingEnabled = true;
            this.kindOfMeals.Location = new System.Drawing.Point(12, 55);
            this.kindOfMeals.Name = "kindOfMeals";
            this.kindOfMeals.Size = new System.Drawing.Size(356, 24);
            this.kindOfMeals.TabIndex = 1;
            this.kindOfMeals.SelectedIndexChanged += new System.EventHandler(this.kindOfMeals_SelectedIndexChanged);
            // 
            // listOrder
            // 
            this.listOrder.FormattingEnabled = true;
            this.listOrder.ItemHeight = 16;
            this.listOrder.Location = new System.Drawing.Point(526, 158);
            this.listOrder.Name = "listOrder";
            this.listOrder.Size = new System.Drawing.Size(280, 212);
            this.listOrder.TabIndex = 2;
            // 
            // btnChoose
            // 
            this.btnChoose.Location = new System.Drawing.Point(409, 195);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(75, 23);
            this.btnChoose.TabIndex = 3;
            this.btnChoose.Text = "Choose";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(409, 253);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // displayChosenTotal
            // 
            this.displayChosenTotal.AutoSize = true;
            this.displayChosenTotal.Location = new System.Drawing.Point(606, 390);
            this.displayChosenTotal.Name = "displayChosenTotal";
            this.displayChosenTotal.Size = new System.Drawing.Size(44, 16);
            this.displayChosenTotal.TabIndex = 4;
            this.displayChosenTotal.Text = "label1";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "STT";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Food Name";
            this.columnHeader2.Width = 152;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Price";
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(450, 390);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sum Of Foods  Chosen: ";
            // 
            // label2
            // 
            this.label2.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kind Of Food: ";
            // 
            // label3
            // 
            this.label3.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Food List:";
            // 
            // label4
            // 
            this.label4.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(523, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "List Food Chosen:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.displayChosenTotal);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.listOrder);
            this.Controls.Add(this.kindOfMeals);
            this.Controls.Add(this.listFood);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listFood;
        private System.Windows.Forms.ComboBox kindOfMeals;
        private System.Windows.Forms.ListBox listOrder;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label displayChosenTotal;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

