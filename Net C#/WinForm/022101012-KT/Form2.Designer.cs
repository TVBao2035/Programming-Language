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
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.numAmount = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnHandle = new System.Windows.Forms.Button();
            this.listSubjects = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.radioFree = new System.Windows.Forms.RadioButton();
            this.radioPossible = new System.Windows.Forms.RadioButton();
            this.sumFree = new System.Windows.Forms.Label();
            this.sumPossible = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(121, 90);
            this.txtId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(199, 22);
            this.txtId.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(121, 149);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(199, 22);
            this.txtName.TabIndex = 0;
            // 
            // numAmount
            // 
            this.numAmount.Location = new System.Drawing.Point(121, 208);
            this.numAmount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numAmount.Name = "numAmount";
            this.numAmount.Size = new System.Drawing.Size(200, 22);
            this.numAmount.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(365, 86);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 28);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = ">";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(365, 142);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 28);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "<";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnHandle
            // 
            this.btnHandle.Location = new System.Drawing.Point(365, 208);
            this.btnHandle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHandle.Name = "btnHandle";
            this.btnHandle.Size = new System.Drawing.Size(100, 28);
            this.btnHandle.TabIndex = 2;
            this.btnHandle.Text = "Tính";
            this.btnHandle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHandle.UseVisualStyleBackColor = true;
            this.btnHandle.Click += new System.EventHandler(this.btnHandle_Click);
            // 
            // listSubjects
            // 
            this.listSubjects.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listSubjects.FullRowSelect = true;
            this.listSubjects.GridLines = true;
            this.listSubjects.HideSelection = false;
            this.listSubjects.Location = new System.Drawing.Point(528, 86);
            this.listSubjects.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listSubjects.MultiSelect = false;
            this.listSubjects.Name = "listSubjects";
            this.listSubjects.Size = new System.Drawing.Size(521, 158);
            this.listSubjects.TabIndex = 3;
            this.listSubjects.UseCompatibleStateImageBehavior = false;
            this.listSubjects.View = System.Windows.Forms.View.Details;
            this.listSubjects.SelectedIndexChanged += new System.EventHandler(this.listSubjects_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã học phần";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên học phần";
            this.columnHeader2.Width = 151;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Số tín chỉ";
            this.columnHeader3.Width = 68;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Loại học phần";
            this.columnHeader4.Width = 109;
            // 
            // radioFree
            // 
            this.radioFree.AutoSize = true;
            this.radioFree.Checked = true;
            this.radioFree.Location = new System.Drawing.Point(161, 282);
            this.radioFree.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioFree.Name = "radioFree";
            this.radioFree.Size = new System.Drawing.Size(76, 20);
            this.radioFree.TabIndex = 4;
            this.radioFree.TabStop = true;
            this.radioFree.Text = "Tự chọn";
            this.radioFree.UseVisualStyleBackColor = true;
            // 
            // radioPossible
            // 
            this.radioPossible.AutoSize = true;
            this.radioPossible.Location = new System.Drawing.Point(305, 282);
            this.radioPossible.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioPossible.Name = "radioPossible";
            this.radioPossible.Size = new System.Drawing.Size(81, 20);
            this.radioPossible.TabIndex = 4;
            this.radioPossible.Text = "Bắt buộc";
            this.radioPossible.UseVisualStyleBackColor = true;
            // 
            // sumFree
            // 
            this.sumFree.AutoSize = true;
            this.sumFree.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sumFree.Location = new System.Drawing.Point(524, 324);
            this.sumFree.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sumFree.Name = "sumFree";
            this.sumFree.Size = new System.Drawing.Size(0, 17);
            this.sumFree.TabIndex = 5;
            // 
            // sumPossible
            // 
            this.sumPossible.AutoSize = true;
            this.sumPossible.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sumPossible.Location = new System.Drawing.Point(788, 324);
            this.sumPossible.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sumPossible.Name = "sumPossible";
            this.sumPossible.Size = new System.Drawing.Size(0, 17);
            this.sumPossible.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 287);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Loại học phần:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 210);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Số tín chỉ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 153);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tên học phần:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 94);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Mã học phần:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(361, 23);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(248, 29);
            this.label7.TabIndex = 5;
            this.label7.Text = "QUẢN LÝ HỌC PHẦN";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 396);
            this.Controls.Add(this.sumPossible);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sumFree);
            this.Controls.Add(this.radioPossible);
            this.Controls.Add(this.radioFree);
            this.Controls.Add(this.listSubjects);
            this.Controls.Add(this.btnHandle);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.numAmount);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtId);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.NumericUpDown numAmount;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnHandle;
        private System.Windows.Forms.ListView listSubjects;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.RadioButton radioFree;
        private System.Windows.Forms.RadioButton radioPossible;
        private System.Windows.Forms.Label sumFree;
        private System.Windows.Forms.Label sumPossible;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}