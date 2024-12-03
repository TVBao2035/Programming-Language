namespace _022101012
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
            this.listStudentInformation = new System.Windows.Forms.ListView();
            this.listStatistical = new System.Windows.Forms.ListView();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numScore = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboBoxSubject = new System.Windows.Forms.ComboBox();
            this.comboBoxSchools = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnStatistical = new System.Windows.Forms.Button();
            this.displayTotalStudent = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numScore)).BeginInit();
            this.SuspendLayout();
            // 
            // listStudentInformation
            // 
            this.listStudentInformation.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listStudentInformation.FullRowSelect = true;
            this.listStudentInformation.GridLines = true;
            this.listStudentInformation.HideSelection = false;
            this.listStudentInformation.Location = new System.Drawing.Point(16, 158);
            this.listStudentInformation.Name = "listStudentInformation";
            this.listStudentInformation.Size = new System.Drawing.Size(475, 216);
            this.listStudentInformation.TabIndex = 0;
            this.listStudentInformation.UseCompatibleStateImageBehavior = false;
            this.listStudentInformation.View = System.Windows.Forms.View.Details;
            // 
            // listStatistical
            // 
            this.listStatistical.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7});
            this.listStatistical.FullRowSelect = true;
            this.listStatistical.GridLines = true;
            this.listStatistical.HideSelection = false;
            this.listStatistical.Location = new System.Drawing.Point(493, 154);
            this.listStatistical.Name = "listStatistical";
            this.listStatistical.Size = new System.Drawing.Size(339, 216);
            this.listStatistical.TabIndex = 0;
            this.listStatistical.UseCompatibleStateImageBehavior = false;
            this.listStatistical.View = System.Windows.Forms.View.Details;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(74, 75);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(176, 22);
            this.txtName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(268, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Điểm:";
            // 
            // numScore
            // 
            this.numScore.DecimalPlaces = 2;
            this.numScore.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.numScore.Location = new System.Drawing.Point(315, 74);
            this.numScore.Name = "numScore";
            this.numScore.Size = new System.Drawing.Size(72, 22);
            this.numScore.TabIndex = 3;
            this.numScore.ValueChanged += new System.EventHandler(this.numScore_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(393, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Môn:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(573, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Trường:";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "STT";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Họ Tên";
            this.columnHeader2.Width = 118;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Điểm";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Môn";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Trường";
            this.columnHeader5.Width = 155;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Trường";
            this.columnHeader6.Width = 184;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Tổng TS";
            this.columnHeader7.Width = 91;
            // 
            // comboBoxSubject
            // 
            this.comboBoxSubject.FormattingEnabled = true;
            this.comboBoxSubject.Location = new System.Drawing.Point(435, 71);
            this.comboBoxSubject.Name = "comboBoxSubject";
            this.comboBoxSubject.Size = new System.Drawing.Size(121, 24);
            this.comboBoxSubject.TabIndex = 4;
            // 
            // comboBoxSchools
            // 
            this.comboBoxSchools.FormattingEnabled = true;
            this.comboBoxSchools.Location = new System.Drawing.Point(632, 72);
            this.comboBoxSchools.Name = "comboBoxSchools";
            this.comboBoxSchools.Size = new System.Drawing.Size(200, 24);
            this.comboBoxSchools.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAdd.Location = new System.Drawing.Point(214, 103);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(95, 45);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnStatistical
            // 
            this.btnStatistical.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnStatistical.Location = new System.Drawing.Point(348, 380);
            this.btnStatistical.Name = "btnStatistical";
            this.btnStatistical.Size = new System.Drawing.Size(110, 44);
            this.btnStatistical.TabIndex = 5;
            this.btnStatistical.Text = "Xét KQ";
            this.btnStatistical.UseVisualStyleBackColor = true;
            this.btnStatistical.Click += new System.EventHandler(this.btnStatistical_Click);
            // 
            // displayTotalStudent
            // 
            this.displayTotalStudent.AutoSize = true;
            this.displayTotalStudent.Location = new System.Drawing.Point(671, 394);
            this.displayTotalStudent.Name = "displayTotalStudent";
            this.displayTotalStudent.Size = new System.Drawing.Size(14, 16);
            this.displayTotalStudent.TabIndex = 6;
            this.displayTotalStudent.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Họ Tên:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(490, 394);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tổng số học sinh đạt giải:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(747, 713);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Tổng số học sinh đạt giải:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Danh sách thí sinh:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(490, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "Thống kê:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(154, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(531, 29);
            this.label9.TabIndex = 2;
            this.label9.Text = "KẾT QUẢ HỌC SINH GIỎI CẤP THÀNH PHỐ";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.displayTotalStudent);
            this.Controls.Add(this.btnStatistical);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.comboBoxSchools);
            this.Controls.Add(this.comboBoxSubject);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numScore);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.listStatistical);
            this.Controls.Add(this.listStudentInformation);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numScore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listStudentInformation;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ListView listStatistical;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numScore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxSubject;
        private System.Windows.Forms.ComboBox comboBoxSchools;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnStatistical;
        private System.Windows.Forms.Label displayTotalStudent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}