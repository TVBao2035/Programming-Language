namespace BaiTapVeNha
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
            this.listSubejcts = new System.Windows.Forms.CheckedListBox();
            this.listRegister = new System.Windows.Forms.ListBox();
            this.btnChoose = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.creditSum = new System.Windows.Forms.Label();
            this.moneySum = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listSubejcts
            // 
            this.listSubejcts.FormattingEnabled = true;
            this.listSubejcts.Location = new System.Drawing.Point(12, 150);
            this.listSubejcts.Name = "listSubejcts";
            this.listSubejcts.Size = new System.Drawing.Size(273, 157);
            this.listSubejcts.TabIndex = 0;
            // 
            // listRegister
            // 
            this.listRegister.FormattingEnabled = true;
            this.listRegister.ItemHeight = 16;
            this.listRegister.Location = new System.Drawing.Point(482, 150);
            this.listRegister.Name = "listRegister";
            this.listRegister.Size = new System.Drawing.Size(292, 164);
            this.listRegister.TabIndex = 1;
            // 
            // btnChoose
            // 
            this.btnChoose.Location = new System.Drawing.Point(328, 191);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(111, 23);
            this.btnChoose.TabIndex = 2;
            this.btnChoose.Text = "Choose";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(328, 256);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(111, 23);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // creditSum
            // 
            this.creditSum.AutoSize = true;
            this.creditSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.creditSum.Location = new System.Drawing.Point(379, 341);
            this.creditSum.Name = "creditSum";
            this.creditSum.Size = new System.Drawing.Size(0, 16);
            this.creditSum.TabIndex = 3;
            // 
            // moneySum
            // 
            this.moneySum.AutoSize = true;
            this.moneySum.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.moneySum.Location = new System.Drawing.Point(379, 396);
            this.moneySum.Name = "moneySum";
            this.moneySum.Size = new System.Drawing.Size(0, 16);
            this.moneySum.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(211, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "CREDIT REGISTER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "The price of one credit: 350000VND";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "List Subejcts:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(479, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "List Register:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.moneySum);
            this.Controls.Add(this.creditSum);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.listRegister);
            this.Controls.Add(this.listSubejcts);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox listSubejcts;
        private System.Windows.Forms.ListBox listRegister;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label moneySum;
        private System.Windows.Forms.Label creditSum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}