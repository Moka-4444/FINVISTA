namespace ATMauto
{
    partial class HOME
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
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            panel2 = new Panel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            AccNumlbl = new Label();
            button7 = new Button();
            button6 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 89);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(756, 0);
            label2.Name = "label2";
            label2.Size = new Size(44, 50);
            label2.TabIndex = 1;
            label2.Text = "X";
            label2.Click += label1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(152, 19);
            label1.Name = "label1";
            label1.Size = new Size(494, 50);
            label1.TabIndex = 1;
            label1.Text = "Select Your Transiction Phase";
            label1.Click += label1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.MidnightBlue;
            label4.Location = new Point(357, 402);
            label4.Name = "label4";
            label4.Size = new Size(75, 28);
            label4.TabIndex = 2;
            label4.Text = "Logout";
            label4.Click += label4_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MidnightBlue;
            panel2.Location = new Point(0, 433);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 30);
            panel2.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.MidnightBlue;
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = Color.White;
            button1.Location = new Point(504, 329);
            button1.Name = "button1";
            button1.Size = new Size(120, 64);
            button1.TabIndex = 5;
            button1.Text = "BALANCE";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.MidnightBlue;
            button2.FlatStyle = FlatStyle.Popup;
            button2.ForeColor = Color.White;
            button2.Location = new Point(504, 236);
            button2.Name = "button2";
            button2.Size = new Size(120, 62);
            button2.TabIndex = 6;
            button2.Text = "Last Transctions";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.MidnightBlue;
            button3.FlatStyle = FlatStyle.Popup;
            button3.ForeColor = Color.White;
            button3.Location = new Point(504, 140);
            button3.Name = "button3";
            button3.Size = new Size(120, 57);
            button3.TabIndex = 7;
            button3.Text = "WITHDRAW";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.MidnightBlue;
            button4.FlatStyle = FlatStyle.Popup;
            button4.ForeColor = Color.White;
            button4.Location = new Point(128, 329);
            button4.Name = "button4";
            button4.Size = new Size(120, 57);
            button4.TabIndex = 8;
            button4.Text = "CHANGE PIN";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.MidnightBlue;
            button5.FlatStyle = FlatStyle.Popup;
            button5.ForeColor = Color.White;
            button5.Location = new Point(128, 243);
            button5.Name = "button5";
            button5.Size = new Size(120, 55);
            button5.TabIndex = 9;
            button5.Text = "FAST CASH";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // AccNumlbl
            // 
            AccNumlbl.AutoSize = true;
            AccNumlbl.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AccNumlbl.ForeColor = Color.MidnightBlue;
            AccNumlbl.Location = new Point(234, 92);
            AccNumlbl.Name = "AccNumlbl";
            AccNumlbl.Size = new Size(282, 41);
            AccNumlbl.TabIndex = 11;
            AccNumlbl.Text = "ACCOUNT NUMBER";
            // 
            // button7
            // 
            button7.BackColor = Color.MidnightBlue;
            button7.FlatStyle = FlatStyle.Popup;
            button7.ForeColor = Color.White;
            button7.Location = new Point(128, 136);
            button7.Name = "button7";
            button7.Size = new Size(120, 57);
            button7.TabIndex = 10;
            button7.Text = "DEPOSIT";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button6_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.MidnightBlue;
            button6.ForeColor = Color.White;
            button6.Location = new Point(322, 233);
            button6.Name = "button6";
            button6.Size = new Size(110, 69);
            button6.TabIndex = 12;
            button6.Text = "ATMS";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click_1;
            // 
            // HOME
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button6);
            Controls.Add(AccNumlbl);
            Controls.Add(button7);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel2);
            Controls.Add(label4);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HOME";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HOME";
            Load += HOME_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label4;
        private Panel panel2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label AccNumlbl;
        private Label label2;
        private Button button7;
        private Button button6;
    }
}