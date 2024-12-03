namespace test_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listFood = new ListBox();
            listOrder = new ListBox();
            txtName = new TextBox();
            txtDateTime = new DateTimePicker();
            btnAddFood = new Button();
            btnChoose = new Button();
            btnDistroy = new Button();
            btnClose = new Button();
            txtResult = new TextBox();
            amountFood = new Label();
            SuspendLayout();
            // 
            // listFood
            // 
            listFood.FormattingEnabled = true;
            listFood.Location = new Point(12, 74);
            listFood.Name = "listFood";
            listFood.Size = new Size(128, 164);
            listFood.TabIndex = 0;
            // 
            // listOrder
            // 
            listOrder.FormattingEnabled = true;
            listOrder.Location = new Point(542, 74);
            listOrder.Name = "listOrder";
            listOrder.Size = new Size(128, 164);
            listOrder.TabIndex = 0;
            // 
            // txtName
            // 
            txtName.Location = new Point(163, 12);
            txtName.Name = "txtName";
            txtName.Size = new Size(379, 27);
            txtName.TabIndex = 1;
            // 
            // txtDateTime
            // 
            txtDateTime.CustomFormat = "dd/MM/yyyy";
            txtDateTime.Format = DateTimePickerFormat.Custom;
            txtDateTime.Location = new Point(163, 57);
            txtDateTime.Name = "txtDateTime";
            txtDateTime.Size = new Size(373, 27);
            txtDateTime.TabIndex = 2;
            txtDateTime.Value = new DateTime(2024, 3, 6, 21, 7, 45, 0);
            // 
            // btnAddFood
            // 
            btnAddFood.Location = new Point(264, 116);
            btnAddFood.Name = "btnAddFood";
            btnAddFood.Size = new Size(94, 29);
            btnAddFood.TabIndex = 3;
            btnAddFood.Text = ">";
            btnAddFood.UseVisualStyleBackColor = true;
            btnAddFood.Click += btnAddFood_Click;
            // 
            // btnChoose
            // 
            btnChoose.Location = new Point(34, 262);
            btnChoose.Name = "btnChoose";
            btnChoose.Size = new Size(94, 29);
            btnChoose.TabIndex = 3;
            btnChoose.Text = "Chon";
            btnChoose.UseVisualStyleBackColor = true;
            btnChoose.Click += btnChoose_Click;
            // 
            // btnDistroy
            // 
            btnDistroy.Location = new Point(199, 262);
            btnDistroy.Name = "btnDistroy";
            btnDistroy.Size = new Size(94, 29);
            btnDistroy.TabIndex = 3;
            btnDistroy.Text = "Bo Chon";
            btnDistroy.UseVisualStyleBackColor = true;
            btnDistroy.Click += btnDistroy_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(384, 262);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 3;
            btnClose.Text = "Thoat";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // txtResult
            // 
            txtResult.Location = new Point(12, 373);
            txtResult.Multiline = true;
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(658, 108);
            txtResult.TabIndex = 4;
            // 
            // amountFood
            // 
            amountFood.AutoSize = true;
            amountFood.Location = new Point(23, 328);
            amountFood.Name = "amountFood";
            amountFood.Size = new Size(0, 20);
            amountFood.TabIndex = 5;
            amountFood.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(696, 493);
            Controls.Add(amountFood);
            Controls.Add(txtResult);
            Controls.Add(btnClose);
            Controls.Add(btnDistroy);
            Controls.Add(btnChoose);
            Controls.Add(btnAddFood);
            Controls.Add(txtDateTime);
            Controls.Add(txtName);
            Controls.Add(listOrder);
            Controls.Add(listFood);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listFood;
        private ListBox listOrder;
        private TextBox txtName;
        private DateTimePicker txtDateTime;
        private Button btnAddFood;
        private Button btnChoose;
        private Button btnDistroy;
        private Button btnClose;
        private TextBox txtResult;
        private Label amountFood;
    }
}
