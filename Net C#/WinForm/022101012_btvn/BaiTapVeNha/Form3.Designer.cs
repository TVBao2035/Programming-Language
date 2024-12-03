namespace BaiTapVeNha
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
            this.txtSubejctId = new System.Windows.Forms.TextBox();
            this.txtSubejctName = new System.Windows.Forms.TextBox();
            this.numCredit = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.listSubject = new System.Windows.Forms.ListView();
            this.radioElective = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.sumCreditsElective = new System.Windows.Forms.Label();
            this.sumCreditsForced = new System.Windows.Forms.Label();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numCredit)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSubejctId
            // 
            this.txtSubejctId.Location = new System.Drawing.Point(137, 80);
            this.txtSubejctId.Name = "txtSubejctId";
            this.txtSubejctId.Size = new System.Drawing.Size(170, 22);
            this.txtSubejctId.TabIndex = 0;
            // 
            // txtSubejctName
            // 
            this.txtSubejctName.Location = new System.Drawing.Point(137, 135);
            this.txtSubejctName.Name = "txtSubejctName";
            this.txtSubejctName.Size = new System.Drawing.Size(170, 22);
            this.txtSubejctName.TabIndex = 0;
            // 
            // numCredit
            // 
            this.numCredit.Location = new System.Drawing.Point(137, 193);
            this.numCredit.Name = "numCredit";
            this.numCredit.Size = new System.Drawing.Size(170, 22);
            this.numCredit.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(326, 83);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = ">";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(326, 138);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "<";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(326, 192);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // listSubject
            // 
            this.listSubject.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listSubject.FullRowSelect = true;
            this.listSubject.GridLines = true;
            this.listSubject.HideSelection = false;
            this.listSubject.Location = new System.Drawing.Point(424, 83);
            this.listSubject.MultiSelect = false;
            this.listSubject.Name = "listSubject";
            this.listSubject.Size = new System.Drawing.Size(644, 210);
            this.listSubject.TabIndex = 4;
            this.listSubject.UseCompatibleStateImageBehavior = false;
            this.listSubject.View = System.Windows.Forms.View.Details;
            // 
            // radioElective
            // 
            this.radioElective.AutoSize = true;
            this.radioElective.Location = new System.Drawing.Point(113, 251);
            this.radioElective.Name = "radioElective";
            this.radioElective.Size = new System.Drawing.Size(76, 20);
            this.radioElective.TabIndex = 5;
            this.radioElective.TabStop = true;
            this.radioElective.Text = "Elective";
            this.radioElective.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(234, 251);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(71, 20);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Forced";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // sumCreditsElective
            // 
            this.sumCreditsElective.AutoSize = true;
            this.sumCreditsElective.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.sumCreditsElective.Location = new System.Drawing.Point(421, 338);
            this.sumCreditsElective.Name = "sumCreditsElective";
            this.sumCreditsElective.Size = new System.Drawing.Size(0, 16);
            this.sumCreditsElective.TabIndex = 6;
            this.sumCreditsElective.Click += new System.EventHandler(this.label1_Click);
            // 
            // sumCreditsForced
            // 
            this.sumCreditsForced.AutoSize = true;
            this.sumCreditsForced.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.sumCreditsForced.Location = new System.Drawing.Point(721, 338);
            this.sumCreditsForced.Name = "sumCreditsForced";
            this.sumCreditsForced.Size = new System.Drawing.Size(0, 16);
            this.sumCreditsForced.TabIndex = 6;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Subejct ID";
            this.columnHeader1.Width = 90;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Subejct Name";
            this.columnHeader2.Width = 333;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Credit Number";
            this.columnHeader3.Width = 106;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Subject Type";
            this.columnHeader4.Width = 105;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Subject Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Subject Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Number Of Credits:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(358, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(224, 32);
            this.label4.TabIndex = 7;
            this.label4.Text = "Subject Control";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sumCreditsForced);
            this.Controls.Add(this.sumCreditsElective);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioElective);
            this.Controls.Add(this.listSubject);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.numCredit);
            this.Controls.Add(this.txtSubejctName);
            this.Controls.Add(this.txtSubejctId);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numCredit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSubejctId;
        private System.Windows.Forms.TextBox txtSubejctName;
        private System.Windows.Forms.NumericUpDown numCredit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.ListView listSubject;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.RadioButton radioElective;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label sumCreditsElective;
        private System.Windows.Forms.Label sumCreditsForced;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}