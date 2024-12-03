namespace test
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.listSubjectMain = new System.Windows.Forms.ComboBox();
            this.mainSubjectScore = new System.Windows.Forms.NumericUpDown();
            this.Math = new System.Windows.Forms.Label();
            this.MathScore = new System.Windows.Forms.NumericUpDown();
            this.literatureScore = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.englishScore = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnStatistical = new System.Windows.Forms.Button();
            this.listStudents = new System.Windows.Forms.ListView();
            this.mainSubjectStatistical = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.displayStudentsToltal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mainSubjectScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MathScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.literatureScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.englishScore)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(62, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(121, 22);
            this.txtName.TabIndex = 0;
            // 
            // listSubjectMain
            // 
            this.listSubjectMain.FormattingEnabled = true;
            this.listSubjectMain.Location = new System.Drawing.Point(62, 61);
            this.listSubjectMain.Name = "listSubjectMain";
            this.listSubjectMain.Size = new System.Drawing.Size(121, 24);
            this.listSubjectMain.TabIndex = 1;
            // 
            // mainSubjectScore
            // 
            this.mainSubjectScore.DecimalPlaces = 2;
            this.mainSubjectScore.Location = new System.Drawing.Point(189, 63);
            this.mainSubjectScore.Name = "mainSubjectScore";
            this.mainSubjectScore.Size = new System.Drawing.Size(120, 22);
            this.mainSubjectScore.TabIndex = 2;
            // 
            // Math
            // 
            this.Math.AutoSize = true;
            this.Math.Location = new System.Drawing.Point(443, 22);
            this.Math.Name = "Math";
            this.Math.Size = new System.Drawing.Size(36, 16);
            this.Math.TabIndex = 3;
            this.Math.Text = "Math";
            // 
            // MathScore
            // 
            this.MathScore.DecimalPlaces = 2;
            this.MathScore.Location = new System.Drawing.Point(493, 22);
            this.MathScore.Name = "MathScore";
            this.MathScore.Size = new System.Drawing.Size(92, 22);
            this.MathScore.TabIndex = 2;
            // 
            // literatureScore
            // 
            this.literatureScore.DecimalPlaces = 2;
            this.literatureScore.Location = new System.Drawing.Point(493, 74);
            this.literatureScore.Name = "literatureScore";
            this.literatureScore.Size = new System.Drawing.Size(92, 22);
            this.literatureScore.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(425, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Literature";
            // 
            // englishScore
            // 
            this.englishScore.DecimalPlaces = 2;
            this.englishScore.Location = new System.Drawing.Point(493, 117);
            this.englishScore.Name = "englishScore";
            this.englishScore.Size = new System.Drawing.Size(92, 22);
            this.englishScore.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(443, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "English";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(73, 117);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Choose";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnStatistical
            // 
            this.btnStatistical.Location = new System.Drawing.Point(189, 112);
            this.btnStatistical.Name = "btnStatistical";
            this.btnStatistical.Size = new System.Drawing.Size(75, 23);
            this.btnStatistical.TabIndex = 4;
            this.btnStatistical.Text = "Statistical";
            this.btnStatistical.UseVisualStyleBackColor = true;
            this.btnStatistical.Click += new System.EventHandler(this.btnStatistical_Click);
            // 
            // listStudents
            // 
            this.listStudents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listStudents.FullRowSelect = true;
            this.listStudents.GridLines = true;
            this.listStudents.HideSelection = false;
            this.listStudents.Location = new System.Drawing.Point(12, 184);
            this.listStudents.Name = "listStudents";
            this.listStudents.Size = new System.Drawing.Size(564, 242);
            this.listStudents.TabIndex = 5;
            this.listStudents.UseCompatibleStateImageBehavior = false;
            this.listStudents.View = System.Windows.Forms.View.Details;
            // 
            // mainSubjectStatistical
            // 
            this.mainSubjectStatistical.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8});
            this.mainSubjectStatistical.FullRowSelect = true;
            this.mainSubjectStatistical.GridLines = true;
            this.mainSubjectStatistical.HideSelection = false;
            this.mainSubjectStatistical.Location = new System.Drawing.Point(582, 184);
            this.mainSubjectStatistical.Name = "mainSubjectStatistical";
            this.mainSubjectStatistical.Size = new System.Drawing.Size(244, 242);
            this.mainSubjectStatistical.TabIndex = 5;
            this.mainSubjectStatistical.UseCompatibleStateImageBehavior = false;
            this.mainSubjectStatistical.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Van";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Math";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "English";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Mon Chuyen";
            this.columnHeader5.Width = 105;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Score";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Main Subject";
            this.columnHeader7.Width = 110;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Sum Of Students";
            this.columnHeader8.Width = 124;
            // 
            // displayStudentsToltal
            // 
            this.displayStudentsToltal.AutoSize = true;
            this.displayStudentsToltal.Location = new System.Drawing.Point(21, 151);
            this.displayStudentsToltal.Name = "displayStudentsToltal";
            this.displayStudentsToltal.Size = new System.Drawing.Size(44, 16);
            this.displayStudentsToltal.TabIndex = 6;
            this.displayStudentsToltal.Text = "label1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 450);
            this.Controls.Add(this.displayStudentsToltal);
            this.Controls.Add(this.mainSubjectStatistical);
            this.Controls.Add(this.listStudents);
            this.Controls.Add(this.btnStatistical);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Math);
            this.Controls.Add(this.englishScore);
            this.Controls.Add(this.literatureScore);
            this.Controls.Add(this.MathScore);
            this.Controls.Add(this.mainSubjectScore);
            this.Controls.Add(this.listSubjectMain);
            this.Controls.Add(this.txtName);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainSubjectScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MathScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.literatureScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.englishScore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox listSubjectMain;
        private System.Windows.Forms.NumericUpDown mainSubjectScore;
        private System.Windows.Forms.Label Math;
        private System.Windows.Forms.NumericUpDown MathScore;
        private System.Windows.Forms.NumericUpDown literatureScore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown englishScore;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnStatistical;
        private System.Windows.Forms.ListView listStudents;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ListView mainSubjectStatistical;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Label displayStudentsToltal;
    }
}