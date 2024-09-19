namespace Lab2_3
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtA = new TextBox();
            txtB = new TextBox();
            txtKetQua = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 46);
            label1.Name = "label1";
            label1.Size = new Size(43, 23);
            label1.TabIndex = 0;
            label1.Text = "Số a";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 106);
            label2.Name = "label2";
            label2.Size = new Size(44, 23);
            label2.TabIndex = 1;
            label2.Text = "Số b";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 165);
            label3.Name = "label3";
            label3.Size = new Size(69, 23);
            label3.TabIndex = 2;
            label3.Text = "Kết quả";
            // 
            // txtA
            // 
            txtA.Location = new Point(154, 39);
            txtA.Name = "txtA";
            txtA.Size = new Size(232, 30);
            txtA.TabIndex = 3;
            // 
            // txtB
            // 
            txtB.Location = new Point(154, 103);
            txtB.Name = "txtB";
            txtB.Size = new Size(232, 30);
            txtB.TabIndex = 3;
            // 
            // txtKetQua
            // 
            txtKetQua.Location = new Point(154, 162);
            txtKetQua.Name = "txtKetQua";
            txtKetQua.Size = new Size(232, 30);
            txtKetQua.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(292, 229);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "Cộng";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 284);
            Controls.Add(button1);
            Controls.Add(txtKetQua);
            Controls.Add(txtB);
            Controls.Add(txtA);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Tính toán";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtA;
        private TextBox txtB;
        private TextBox txtKetQua;
        private Button button1;
    }
}