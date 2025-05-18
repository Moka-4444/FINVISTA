namespace ATMauto
{
    partial class withdraw
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
            panel1 = new Panel();
            label7 = new Label();
            label5 = new Label();
            label2 = new Label();
            balancelbl = new Label();
            label3 = new Label();
            label4 = new Label();
            wdamtTb = new TextBox();
            button1 = new Button();
            label12 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(532, 89);
            panel1.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(496, 0);
            label7.Name = "label7";
            label7.Size = new Size(36, 41);
            label7.TabIndex = 1;
            label7.Text = "X";
            label7.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DarkSlateGray;
            label5.Location = new Point(282, 274);
            label5.Name = "label5";
            label5.Size = new Size(75, 28);
            label5.TabIndex = 36;
            label5.Text = "Logout";
            label5.Click += label12_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkSlateGray;
            label2.Location = new Point(282, 265);
            label2.Name = "label2";
            label2.Size = new Size(75, 28);
            label2.TabIndex = 36;
            label2.Text = "Logout";
            label2.Click += label12_Click;
            // 
            // balancelbl
            // 
            balancelbl.AutoSize = true;
            balancelbl.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            balancelbl.ForeColor = Color.MidnightBlue;
            balancelbl.Location = new Point(235, 135);
            balancelbl.Name = "balancelbl";
            balancelbl.Size = new Size(244, 31);
            balancelbl.TabIndex = 31;
            balancelbl.Text = "AVAILABLE BALANCE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.MidnightBlue;
            label3.Location = new Point(177, 92);
            label3.Name = "label3";
            label3.Size = new Size(145, 31);
            label3.TabIndex = 32;
            label3.Text = "WITHDRAW";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.MidnightBlue;
            label4.Location = new Point(100, 179);
            label4.Name = "label4";
            label4.Size = new Size(129, 31);
            label4.TabIndex = 33;
            label4.Text = "AMOUNT :";
            // 
            // wdamtTb
            // 
            wdamtTb.Location = new Point(235, 179);
            wdamtTb.Name = "wdamtTb";
            wdamtTb.Size = new Size(237, 27);
            wdamtTb.TabIndex = 34;
            // 
            // button1
            // 
            button1.BackColor = Color.MidnightBlue;
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = Color.White;
            button1.Location = new Point(265, 222);
            button1.Name = "button1";
            button1.Size = new Size(120, 40);
            button1.TabIndex = 35;
            button1.Text = "WITHDRAW";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.MidnightBlue;
            label12.Location = new Point(282, 265);
            label12.Name = "label12";
            label12.Size = new Size(52, 28);
            label12.TabIndex = 36;
            label12.Text = "Back";
            label12.Click += label12_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MidnightBlue;
            panel2.Location = new Point(-289, 319);
            panel2.Name = "panel2";
            panel2.Size = new Size(1111, 16);
            panel2.TabIndex = 37;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(26, 24);
            label1.Name = "label1";
            label1.Size = new Size(464, 41);
            label1.TabIndex = 37;
            label1.Text = "FINVISTA MANAGEMENT SYSTEM";
            // 
            // withdraw
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(532, 327);
            Controls.Add(panel2);
            Controls.Add(label12);
            Controls.Add(button1);
            Controls.Add(wdamtTb);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(balancelbl);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "withdraw";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "withdraw";
            Load += withdraw_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label balancelbl;
        private Label label3;
        private Label label4;
        private TextBox wdamtTb;
        private Button button1;
        private Label label12;
        private Panel panel2;
        private Label label5;
        private Label label2;
        private Label label7;
        private Label label1;
    }
}