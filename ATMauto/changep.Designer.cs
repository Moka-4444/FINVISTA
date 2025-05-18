namespace ATMauto
{
    partial class changep
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
            label2 = new Label();
            label3 = new Label();
            Pin2Tb = new TextBox();
            Pin1Tb = new TextBox();
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
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(654, 89);
            panel1.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(610, 0);
            label4.Name = "label4";
            label4.Size = new Size(44, 50);
            label4.TabIndex = 1;
            label4.Text = "X";
            label4.Click += label4_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(63, 253);
            label2.Name = "label2";
            label2.Size = new Size(166, 31);
            label2.TabIndex = 7;
            label2.Text = "CONFIRM PIN :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.MidnightBlue;
            label3.Location = new Point(92, 151);
            label3.Name = "label3";
            label3.Size = new Size(117, 31);
            label3.TabIndex = 8;
            label3.Text = "NEW PIN :";
            // 
            // Pin2Tb
            // 
            Pin2Tb.Location = new Point(298, 257);
            Pin2Tb.Name = "Pin2Tb";
            Pin2Tb.Size = new Size(237, 27);
            Pin2Tb.TabIndex = 19;
            // 
            // Pin1Tb
            // 
            Pin1Tb.Location = new Point(298, 151);
            Pin1Tb.Name = "Pin1Tb";
            Pin1Tb.Size = new Size(237, 27);
            Pin1Tb.TabIndex = 20;
            // 
            // button1
            // 
            button1.BackColor = Color.MidnightBlue;
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = Color.White;
            button1.Location = new Point(355, 334);
            button1.Name = "button1";
            button1.Size = new Size(120, 40);
            button1.TabIndex = 26;
            button1.Text = "Change";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.MidnightBlue;
            label12.Location = new Point(388, 395);
            label12.Name = "label12";
            label12.Size = new Size(52, 28);
            label12.TabIndex = 28;
            label12.Text = "Back";
            label12.Click += label12_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MidnightBlue;
            panel2.Location = new Point(-228, 444);
            panel2.Name = "panel2";
            panel2.Size = new Size(1111, 21);
            panel2.TabIndex = 29;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(31, 19);
            label1.Name = "label1";
            label1.Size = new Size(573, 50);
            label1.TabIndex = 2;
            label1.Text = "FINVISTA MANAGEMENT SYSTEM";
            // 
            // changep
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(654, 461);
            Controls.Add(panel2);
            Controls.Add(label12);
            Controls.Add(button1);
            Controls.Add(Pin1Tb);
            Controls.Add(Pin2Tb);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "changep";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "changep";
            Load += changep_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label3;
        private TextBox Pin2Tb;
        private TextBox Pin1Tb;
        private Button button1;
        private Label label12;
        private Panel panel2;
        private Label label4;
        private Label label1;
    }
}