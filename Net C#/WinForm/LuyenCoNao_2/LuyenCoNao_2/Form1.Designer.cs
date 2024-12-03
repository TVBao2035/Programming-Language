namespace LuyenCoNao_2
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
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.dateBorn = new System.Windows.Forms.DateTimePicker();
            this.txtName = new System.Windows.Forms.TextBox();
            this.comboDepaterment = new System.Windows.Forms.ComboBox();
            this.listStaff = new System.Windows.Forms.ListView();
            this.radioASC = new System.Windows.Forms.RadioButton();
            this.radioDESC = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.displayAmountOfStaff = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(31, 24);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(150, 22);
            this.txtId.TabIndex = 0;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(31, 112);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(150, 22);
            this.txtAddress.TabIndex = 0;
            // 
            // dateBorn
            // 
            this.dateBorn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateBorn.Location = new System.Drawing.Point(31, 84);
            this.dateBorn.Name = "dateBorn";
            this.dateBorn.Size = new System.Drawing.Size(150, 22);
            this.dateBorn.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(31, 52);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(150, 22);
            this.txtName.TabIndex = 0;
            // 
            // comboDepaterment
            // 
            this.comboDepaterment.FormattingEnabled = true;
            this.comboDepaterment.Location = new System.Drawing.Point(31, 140);
            this.comboDepaterment.Name = "comboDepaterment";
            this.comboDepaterment.Size = new System.Drawing.Size(150, 24);
            this.comboDepaterment.TabIndex = 2;
            // 
            // listStaff
            // 
            this.listStaff.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listStaff.FullRowSelect = true;
            this.listStaff.GridLines = true;
            this.listStaff.HideSelection = false;
            this.listStaff.Location = new System.Drawing.Point(3, 244);
            this.listStaff.Name = "listStaff";
            this.listStaff.Size = new System.Drawing.Size(967, 194);
            this.listStaff.TabIndex = 3;
            this.listStaff.UseCompatibleStateImageBehavior = false;
            this.listStaff.View = System.Windows.Forms.View.Details;
            this.listStaff.SelectedIndexChanged += new System.EventHandler(this.listStaff_SelectedIndexChanged);
            // 
            // radioASC
            // 
            this.radioASC.AutoSize = true;
            this.radioASC.Location = new System.Drawing.Point(764, 22);
            this.radioASC.Name = "radioASC";
            this.radioASC.Size = new System.Drawing.Size(103, 20);
            this.radioASC.TabIndex = 4;
            this.radioASC.TabStop = true;
            this.radioASC.Text = "radioButton1";
            this.radioASC.UseVisualStyleBackColor = true;
            // 
            // radioDESC
            // 
            this.radioDESC.AutoSize = true;
            this.radioDESC.Location = new System.Drawing.Point(764, 73);
            this.radioDESC.Name = "radioDESC";
            this.radioDESC.Size = new System.Drawing.Size(103, 20);
            this.radioDESC.TabIndex = 4;
            this.radioDESC.TabStop = true;
            this.radioDESC.Text = "radioButton1";
            this.radioDESC.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(764, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(246, 195);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "button1";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(349, 195);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "button1";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(465, 195);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "button1";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(591, 195);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "button1";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ma NV";
            this.columnHeader1.Width = 138;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ho Ten";
            this.columnHeader2.Width = 127;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ngay Sinh";
            this.columnHeader3.Width = 125;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Dia Chi";
            this.columnHeader4.Width = 154;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Ma Phong";
            this.columnHeader5.Width = 137;
            // 
            // displayAmountOfStaff
            // 
            this.displayAmountOfStaff.AutoSize = true;
            this.displayAmountOfStaff.Location = new System.Drawing.Point(317, 52);
            this.displayAmountOfStaff.Name = "displayAmountOfStaff";
            this.displayAmountOfStaff.Size = new System.Drawing.Size(44, 16);
            this.displayAmountOfStaff.TabIndex = 6;
            this.displayAmountOfStaff.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 450);
            this.Controls.Add(this.displayAmountOfStaff);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioDESC);
            this.Controls.Add(this.radioASC);
            this.Controls.Add(this.listStaff);
            this.Controls.Add(this.comboDepaterment);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.dateBorn);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtId);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.DateTimePicker dateBorn;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox comboDepaterment;
        private System.Windows.Forms.ListView listStaff;
        private System.Windows.Forms.RadioButton radioASC;
        private System.Windows.Forms.RadioButton radioDESC;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label displayAmountOfStaff;
    }
}

