namespace ATMauto
{
    partial class deposite
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
            label4 = new Label();
            button2 = new Button();
            label3 = new Label();
            DepoAmtTb = new TextBox();
            button1 = new Button();
            label12 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(button2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(532, 89);
            panel1.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(496, 0);
            label4.Name = "label4";
            label4.Size = new Size(36, 41);
            label4.TabIndex = 1;
            label4.Text = "X";
            label4.Click += label1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkSlateGray;
            button2.FlatStyle = FlatStyle.Popup;
            button2.ForeColor = Color.White;
            button2.Location = new Point(275, 210);
            button2.Name = "button2";
            button2.Size = new Size(120, 40);
            button2.TabIndex = 27;
            button2.Text = "DEPOSIT";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.MidnightBlue;
            label3.Location = new Point(80, 157);
            label3.Name = "label3";
            label3.Size = new Size(123, 31);
            label3.TabIndex = 9;
            label3.Text = "AMOUNT :";
            // 
            // DepoAmtTb
            // 
            DepoAmtTb.Location = new Point(236, 161);
            DepoAmtTb.Name = "DepoAmtTb";
            DepoAmtTb.Size = new Size(237, 27);
            DepoAmtTb.TabIndex = 21;
            // 
            // button1
            // 
            button1.BackColor = Color.MidnightBlue;
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = Color.White;
            button1.Location = new Point(275, 210);
            button1.Name = "button1";
            button1.Size = new Size(120, 40);
            button1.TabIndex = 27;
            button1.Text = "DEPOSIT";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.MidnightBlue;
            label12.Location = new Point(292, 271);
            label12.Name = "label12";
            label12.Size = new Size(52, 28);
            label12.TabIndex = 29;
            label12.Text = "Back";
            label12.Click += label12_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(202, 92);
            label2.Name = "label2";
            label2.Size = new Size(107, 31);
            label2.TabIndex = 30;
            label2.Text = "DEPOSIT";
            // 
            // panel2
            // 
            panel2.BackColor = Color.MidnightBlue;
            panel2.Location = new Point(-289, 315);
            panel2.Name = "panel2";
            panel2.Size = new Size(1111, 17);
            panel2.TabIndex = 31;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(26, 24);
            label1.Name = "label1";
            label1.Size = new Size(464, 41);
            label1.TabIndex = 28;
            label1.Text = "FINVISTA MANAGEMENT SYSTEM";
            // 
            // deposite
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(532, 327);
            Controls.Add(panel2);
            Controls.Add(label2);
            Controls.Add(label12);
            Controls.Add(button1);
            Controls.Add(DepoAmtTb);
            Controls.Add(label3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "deposite";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "deposite";
            Load += deposite_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private TextBox DepoAmtTb;
        private Button button1;
        private Label label12;
        private Label label2;
        private Panel panel2;
        private Button button2;
        private Label label4;
        private Label label1;
    }
}