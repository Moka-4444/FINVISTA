namespace ATMauto
{
    partial class Balance
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panel1 = new Panel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            Balancelbl = new Label();
            AccNumberlbl = new Label();
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
            panel1.Size = new Size(800, 89);
            panel1.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 22.2F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(756, 0);
            label4.Name = "label4";
            label4.Size = new Size(44, 50);
            label4.TabIndex = 1;
            label4.Text = "X";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F);
            label3.ForeColor = Color.MidnightBlue;
            label3.Location = new Point(156, 268);
            label3.Name = "label3";
            label3.Size = new Size(188, 31);
            label3.TabIndex = 5;
            label3.Text = "YOUR BALANCE :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(136, 164);
            label2.Name = "label2";
            label2.Size = new Size(227, 31);
            label2.TabIndex = 6;
            label2.Text = "ACCOUNT NUMBER :";
            // 
            // Balancelbl
            // 
            Balancelbl.AutoSize = true;
            Balancelbl.Font = new Font("Segoe UI", 13.8F);
            Balancelbl.ForeColor = Color.MidnightBlue;
            Balancelbl.Location = new Point(383, 268);
            Balancelbl.Name = "Balancelbl";
            Balancelbl.Size = new Size(136, 31);
            Balancelbl.TabIndex = 7;
            Balancelbl.Text = "BalanceinRs";
            // 
            // AccNumberlbl
            // 
            AccNumberlbl.AutoSize = true;
            AccNumberlbl.Font = new Font("Segoe UI", 13.8F);
            AccNumberlbl.ForeColor = Color.MidnightBlue;
            AccNumberlbl.Location = new Point(398, 164);
            AccNumberlbl.Name = "AccNumberlbl";
            AccNumberlbl.Size = new Size(101, 31);
            AccNumberlbl.TabIndex = 8;
            AccNumberlbl.Text = "AccNum";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F);
            label12.ForeColor = Color.MidnightBlue;
            label12.Location = new Point(341, 387);
            label12.Name = "label12";
            label12.Size = new Size(52, 28);
            label12.TabIndex = 27;
            label12.Text = "Back";
            label12.Click += label12_Click_1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MidnightBlue;
            panel2.Location = new Point(-155, 436);
            panel2.Name = "panel2";
            panel2.Size = new Size(1111, 15);
            panel2.TabIndex = 28;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(114, 19);
            label1.Name = "label1";
            label1.Size = new Size(573, 50);
            label1.TabIndex = 2;
            label1.Text = "FINVISTA MANAGEMENT SYSTEM";
            // 
            // Balance
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(label12);
            Controls.Add(AccNumberlbl);
            Controls.Add(Balancelbl);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Balance";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Balance";
            Load += Balance_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Label label2;
        private Label Balancelbl;
        private Label AccNumberlbl;
        private Label label12;
        private Panel panel2;
        private Label label4;
        private Label label1;
    }
}
