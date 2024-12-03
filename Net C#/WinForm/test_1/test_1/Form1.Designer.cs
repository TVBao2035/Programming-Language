namespace test_1
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
            listSubjects = new CheckedListBox();
            label1 = new Label();
            Toon = new Label();
            displayIndex = new Label();
            displayMoney = new Label();
            btnChoose = new Button();
            btnHandle = new Button();
            display = new ListBox();
            SuspendLayout();
            // 
            // listSubjects
            // 
            listSubjects.FormattingEnabled = true;
            listSubjects.Location = new Point(26, 55);
            listSubjects.Name = "listSubjects";
            listSubjects.Size = new Size(230, 312);
            listSubjects.TabIndex = 0;
            listSubjects.SelectedIndexChanged += listSubjects_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(461, 347);
            label1.Name = "label1";
            label1.Size = new Size(117, 20);
            label1.TabIndex = 2;
            label1.Text = "Tổng số tính chỉ:";
            // 
            // Toon
            // 
            Toon.AutoSize = true;
            Toon.Location = new Point(485, 395);
            Toon.Name = "Toon";
            Toon.Size = new Size(75, 20);
            Toon.TabIndex = 2;
            Toon.Text = "Tổng tiền:";
            // 
            // displayIndex
            // 
            displayIndex.AutoSize = true;
            displayIndex.Location = new Point(584, 347);
            displayIndex.Name = "displayIndex";
            displayIndex.Size = new Size(50, 20);
            displayIndex.TabIndex = 2;
            displayIndex.Text = "label1";
            // 
            // displayMoney
            // 
            displayMoney.AutoSize = true;
            displayMoney.Location = new Point(584, 395);
            displayMoney.Name = "displayMoney";
            displayMoney.Size = new Size(50, 20);
            displayMoney.TabIndex = 2;
            displayMoney.Text = "label1";
            // 
            // btnChoose
            // 
            btnChoose.Location = new Point(317, 126);
            btnChoose.Name = "btnChoose";
            btnChoose.Size = new Size(120, 45);
            btnChoose.TabIndex = 3;
            btnChoose.Text = "Chọn";
            btnChoose.UseVisualStyleBackColor = true;
            btnChoose.Click += btnChoose_Click;
            // 
            // btnHandle
            // 
            btnHandle.Location = new Point(317, 219);
            btnHandle.Name = "btnHandle";
            btnHandle.Size = new Size(120, 45);
            btnHandle.TabIndex = 3;
            btnHandle.Text = "Tính";
            btnHandle.UseVisualStyleBackColor = true;
            btnHandle.Click += btnHandle_Click;
            // 
            // display
            // 
            display.FormattingEnabled = true;
            display.Location = new Point(561, 72);
            display.Name = "display";
            display.Size = new Size(205, 244);
            display.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(display);
            Controls.Add(btnHandle);
            Controls.Add(btnChoose);
            Controls.Add(displayMoney);
            Controls.Add(Toon);
            Controls.Add(displayIndex);
            Controls.Add(label1);
            Controls.Add(listSubjects);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox listSubjects;
        private Label label1;
        private Label Toon;
        private Label displayIndex;
        private Label displayMoney;
        private Button btnChoose;
        private Button btnHandle;
        private ListBox display;
    }
}
