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
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Lap Trinh Giao Dien");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Mang May Tinh");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Co So Du Lieu");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Tin Hoc", new System.Windows.Forms.TreeNode[] {
            treeNode15,
            treeNode16,
            treeNode17});
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Tam Cam");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Thanh Giong");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Thieu Nhi", new System.Windows.Forms.TreeNode[] {
            treeNode19,
            treeNode20});
            this.treeSubject = new System.Windows.Forms.TreeView();
            this.listSubjectDisplay = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeSubject
            // 
            this.treeSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.treeSubject.Location = new System.Drawing.Point(21, 31);
            this.treeSubject.Name = "treeSubject";
            treeNode15.Name = "Node2";
            treeNode15.Text = "Lap Trinh Giao Dien";
            treeNode16.Name = "Node3";
            treeNode16.Text = "Mang May Tinh";
            treeNode17.Name = "Node4";
            treeNode17.Text = "Co So Du Lieu";
            treeNode18.Name = "Node0";
            treeNode18.Text = "Tin Hoc";
            treeNode19.Name = "Node4";
            treeNode19.Text = "Tam Cam";
            treeNode20.Name = "Node5";
            treeNode20.Text = "Thanh Giong";
            treeNode21.Name = "Node1";
            treeNode21.Text = "Thieu Nhi";
            this.treeSubject.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode18,
            treeNode21});
            this.treeSubject.Size = new System.Drawing.Size(233, 238);
            this.treeSubject.TabIndex = 0;
            this.treeSubject.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeSubject_AfterSelect);
            // 
            // listSubjectDisplay
            // 
            this.listSubjectDisplay.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listSubjectDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.listSubjectDisplay.FullRowSelect = true;
            this.listSubjectDisplay.GridLines = true;
            this.listSubjectDisplay.HideSelection = false;
            this.listSubjectDisplay.Location = new System.Drawing.Point(291, 31);
            this.listSubjectDisplay.Name = "listSubjectDisplay";
            this.listSubjectDisplay.Size = new System.Drawing.Size(410, 238);
            this.listSubjectDisplay.TabIndex = 1;
            this.listSubjectDisplay.UseCompatibleStateImageBehavior = false;
            this.listSubjectDisplay.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Subject";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Author";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Price";
            this.columnHeader3.Width = 100;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.treeSubject);
            this.groupBox1.Controls.Add(this.listSubjectDisplay);
            this.groupBox1.Location = new System.Drawing.Point(12, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(719, 315);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "List Type Of Book";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeSubject;
        private System.Windows.Forms.ListView listSubjectDisplay;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}