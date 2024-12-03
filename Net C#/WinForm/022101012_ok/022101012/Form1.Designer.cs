namespace _022101012
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
            this.listClasses = new System.Windows.Forms.ComboBox();
            this.listSubjects = new System.Windows.Forms.ListView();
            this.listOrderSubejct = new System.Windows.Forms.ListView();
            this.btnChoose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.displayIndexTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listClasses
            // 
            this.listClasses.FormattingEnabled = true;
            this.listClasses.Location = new System.Drawing.Point(122, 70);
            this.listClasses.Name = "listClasses";
            this.listClasses.Size = new System.Drawing.Size(234, 24);
            this.listClasses.TabIndex = 0;
            this.listClasses.SelectedIndexChanged += new System.EventHandler(this.listClasses_SelectedIndexChanged);
            // 
            // listSubjects
            // 
            this.listSubjects.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listSubjects.FullRowSelect = true;
            this.listSubjects.GridLines = true;
            this.listSubjects.HideSelection = false;
            this.listSubjects.Location = new System.Drawing.Point(15, 141);
            this.listSubjects.Name = "listSubjects";
            this.listSubjects.Size = new System.Drawing.Size(370, 255);
            this.listSubjects.TabIndex = 1;
            this.listSubjects.UseCompatibleStateImageBehavior = false;
            this.listSubjects.View = System.Windows.Forms.View.Details;
            // 
            // listOrderSubejct
            // 
            this.listOrderSubejct.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5});
            this.listOrderSubejct.FullRowSelect = true;
            this.listOrderSubejct.GridLines = true;
            this.listOrderSubejct.HideSelection = false;
            this.listOrderSubejct.Location = new System.Drawing.Point(524, 141);
            this.listOrderSubejct.Name = "listOrderSubejct";
            this.listOrderSubejct.Size = new System.Drawing.Size(273, 247);
            this.listOrderSubejct.TabIndex = 1;
            this.listOrderSubejct.UseCompatibleStateImageBehavior = false;
            this.listOrderSubejct.View = System.Windows.Forms.View.Details;
            // 
            // btnChoose
            // 
            this.btnChoose.Location = new System.Drawing.Point(404, 174);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(103, 39);
            this.btnChoose.TabIndex = 2;
            this.btnChoose.Text = "Chọn";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(404, 257);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(103, 49);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Bỏ Chọn";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã Học Phần";
            this.columnHeader1.Width = 102;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên Học Phần";
            this.columnHeader2.Width = 111;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Số Tín Chỉ";
            this.columnHeader3.Width = 97;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tên Học Phần";
            this.columnHeader4.Width = 165;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Số Tín Chỉ";
            this.columnHeader5.Width = 105;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nhóm học phần:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Danh sách học phần:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(521, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = " Danh sách học phần đã chọn:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(282, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(256, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "ĐĂNG KÍ HỌC PHẦN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(369, 404);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tổng số tín chỉ đã chọn :";
            // 
            // displayIndexTotal
            // 
            this.displayIndexTotal.AutoSize = true;
            this.displayIndexTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.displayIndexTotal.Location = new System.Drawing.Point(565, 404);
            this.displayIndexTotal.Name = "displayIndexTotal";
            this.displayIndexTotal.Size = new System.Drawing.Size(15, 16);
            this.displayIndexTotal.TabIndex = 5;
            this.displayIndexTotal.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 450);
            this.Controls.Add(this.displayIndexTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.listOrderSubejct);
            this.Controls.Add(this.listSubjects);
            this.Controls.Add(this.listClasses);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox listClasses;
        private System.Windows.Forms.ListView listSubjects;
        private System.Windows.Forms.ListView listOrderSubejct;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label displayIndexTotal;
    }
}

