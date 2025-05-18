namespace ATMauto
{
    partial class ATMS
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
        /// Required method for Designer support. Do not modify the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label4 = new Label();
            panel2 = new Panel();
            groupBox1 = new GroupBox();
            button6 = new Button();
            button1 = new Button();
            label5 = new Label();
            label3 = new Label();
            Capacity1 = new Label();
            groupBox3 = new GroupBox();
            button7 = new Button();
            button3 = new Button();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            button8 = new Button();
            groupBox4 = new GroupBox();
            button4 = new Button();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            groupBox5 = new GroupBox();
            button5 = new Button();
            button2 = new Button();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label6 = new Label();
            label7 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
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
            panel1.Size = new Size(836, 89);
            panel1.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 22.2F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(795, 0);
            label4.Name = "label4";
            label4.Size = new Size(44, 50);
            label4.TabIndex = 1;
            label4.Text = "X";
            label4.Click += label4_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MidnightBlue;
            panel2.Location = new Point(0, 729);
            panel2.Name = "panel2";
            panel2.Size = new Size(988, 21);
            panel2.TabIndex = 29;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button6);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(Capacity1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.MidnightBlue;
            groupBox1.Location = new Point(20, 122);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(307, 251);
            groupBox1.TabIndex = 30;
            groupBox1.TabStop = false;
            groupBox1.Text = "ALAHLY ATM";
            // 
            // button6
            // 
            button6.BackColor = Color.MidnightBlue;
            button6.ForeColor = Color.Transparent;
            button6.Location = new Point(174, 199);
            button6.Name = "button6";
            button6.Size = new Size(84, 46);
            button6.TabIndex = 5;
            button6.Text = "Cancel";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.MidnightBlue;
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(36, 199);
            button1.Name = "button1";
            button1.Size = new Size(84, 46);
            button1.TabIndex = 3;
            button1.Text = "Reserve";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 84);
            label5.Name = "label5";
            label5.Size = new Size(196, 28);
            label5.TabIndex = 2;
            label5.Text = "Currency : USD , EGP ";
            label5.Click += label5_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 127);
            label3.Name = "label3";
            label3.Size = new Size(230, 56);
            label3.TabIndex = 1;
            label3.Text = "Limits : withdrawal 5000 ,\r\n Deposite 10000";
            label3.Click += label3_Click;
            // 
            // Capacity1
            // 
            Capacity1.AutoSize = true;
            Capacity1.Location = new Point(15, 45);
            Capacity1.Name = "Capacity1";
            Capacity1.Size = new Size(143, 28);
            Capacity1.TabIndex = 0;
            Capacity1.Text = "Capacity : High";
            Capacity1.Click += label2_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button7);
            groupBox3.Controls.Add(button3);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label11);
            groupBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox3.ForeColor = Color.MidnightBlue;
            groupBox3.Location = new Point(504, 429);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(307, 251);
            groupBox3.TabIndex = 31;
            groupBox3.TabStop = false;
            groupBox3.Text = "CIB ATM";
            // 
            // button7
            // 
            button7.BackColor = Color.MidnightBlue;
            button7.ForeColor = Color.Transparent;
            button7.Location = new Point(193, 199);
            button7.Name = "button7";
            button7.Size = new Size(84, 46);
            button7.TabIndex = 6;
            button7.Text = "Cancel";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.MidnightBlue;
            button3.ForeColor = Color.Transparent;
            button3.Location = new Point(59, 199);
            button3.Name = "button3";
            button3.Size = new Size(84, 46);
            button3.TabIndex = 3;
            button3.Text = "Reserve";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(15, 84);
            label9.Name = "label9";
            label9.Size = new Size(196, 28);
            label9.TabIndex = 2;
            label9.Text = "Currency : USD , EGP ";
            label9.Click += label9_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(15, 127);
            label10.Name = "label10";
            label10.Size = new Size(241, 56);
            label10.TabIndex = 1;
            label10.Text = "Limits : withdrawal 15000 ,\r\n Deposite 10000";
            label10.Click += label10_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(15, 45);
            label11.Name = "label11";
            label11.Size = new Size(174, 28);
            label11.TabIndex = 0;
            label11.Text = "Capacity : Medium";
            label11.Click += label11_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.MidnightBlue;
            button8.ForeColor = Color.Transparent;
            button8.Location = new Point(174, 199);
            button8.Name = "button8";
            button8.Size = new Size(84, 46);
            button8.TabIndex = 4;
            button8.Text = "Cancel";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(button4);
            groupBox4.Controls.Add(button8);
            groupBox4.Controls.Add(label12);
            groupBox4.Controls.Add(label13);
            groupBox4.Controls.Add(label14);
            groupBox4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox4.ForeColor = Color.MidnightBlue;
            groupBox4.Location = new Point(20, 429);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(307, 251);
            groupBox4.TabIndex = 31;
            groupBox4.TabStop = false;
            groupBox4.Text = "AGRICULTURE ATM";
            // 
            // button4
            // 
            button4.BackColor = Color.MidnightBlue;
            button4.ForeColor = Color.Transparent;
            button4.Location = new Point(36, 199);
            button4.Name = "button4";
            button4.Size = new Size(84, 46);
            button4.TabIndex = 3;
            button4.Text = "Reserve";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(15, 84);
            label12.Name = "label12";
            label12.Size = new Size(196, 28);
            label12.TabIndex = 2;
            label12.Text = "Currency : USD , EGP ";
            label12.Click += label12_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(15, 127);
            label13.Name = "label13";
            label13.Size = new Size(241, 56);
            label13.TabIndex = 1;
            label13.Text = "Limits : withdrawal 20000 ,\r\n Deposite 5000";
            label13.Click += label13_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(15, 45);
            label14.Name = "label14";
            label14.Size = new Size(143, 28);
            label14.TabIndex = 0;
            label14.Text = "Capacity : High";
            label14.Click += label14_Click;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(button5);
            groupBox5.Controls.Add(button2);
            groupBox5.Controls.Add(label15);
            groupBox5.Controls.Add(label16);
            groupBox5.Controls.Add(label17);
            groupBox5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox5.ForeColor = Color.MidnightBlue;
            groupBox5.Location = new Point(504, 122);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(307, 251);
            groupBox5.TabIndex = 32;
            groupBox5.TabStop = false;
            groupBox5.Text = "QNB ATM";
            groupBox5.Enter += groupBox5_Enter_1;
            // 
            // button5
            // 
            button5.BackColor = Color.MidnightBlue;
            button5.ForeColor = Color.Transparent;
            button5.Location = new Point(184, 199);
            button5.Name = "button5";
            button5.Size = new Size(84, 46);
            button5.TabIndex = 3;
            button5.Text = "Cancel";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.MidnightBlue;
            button2.ForeColor = Color.Transparent;
            button2.Location = new Point(36, 199);
            button2.Name = "button2";
            button2.Size = new Size(84, 46);
            button2.TabIndex = 3;
            button2.Text = "Reserve";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(15, 84);
            label15.Name = "label15";
            label15.Size = new Size(196, 28);
            label15.TabIndex = 2;
            label15.Text = "Currency : USD , EGP ";
            label15.Click += label15_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(15, 127);
            label16.Name = "label16";
            label16.Size = new Size(241, 56);
            label16.TabIndex = 1;
            label16.Text = "Limits : withdrawal 10000 ,\r\n Deposite 20000";
            label16.Click += label16_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(15, 45);
            label17.Name = "label17";
            label17.Size = new Size(136, 28);
            label17.TabIndex = 0;
            label17.Text = "Capacity : Low";
            label17.Click += label17_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(858, 73);
            label6.Name = "label6";
            label6.Size = new Size(44, 20);
            label6.TabIndex = 34;
            label6.Text = "label6";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(384, 696);
            label7.Name = "label7";
            label7.Size = new Size(40, 20);
            label7.TabIndex = 33;
            label7.Text = "Back";
            label7.Click += label7_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(132, 19);
            label1.Name = "label1";
            label1.Size = new Size(573, 50);
            label1.TabIndex = 2;
            label1.Text = "FINVISTA MANAGEMENT SYSTEM";
            // 
            // ATMS
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(836, 750);
            Controls.Add(label7);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ATMS";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ATMS";
            Load += ATMS_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label4;
        private Panel panel2;
        private GroupBox groupBox1;
        private Button button6;
        private Button button1;
        private Label label5;
        private Label label3;
        private Label Capacity1;
        private GroupBox groupBox3;
        private Button button8;
        private Button button3;
        private Label label9;
        private Label label10;
        private Label label11;
        private GroupBox groupBox4;
        private Button button7;
        private Button button4;
        private Label label12;
        private Label label13;
        private Label label14;
        private GroupBox groupBox5;
        private Button button5;
        private Button button2;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label6;
        private Label label7;
        private Label label1;
    }
}
