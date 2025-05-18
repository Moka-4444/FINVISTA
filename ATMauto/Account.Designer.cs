namespace ATMauto
{
    partial class Account
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
            label3 = new Label();
            label5 = new Label();
            label2 = new Label();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            PhoneTb = new TextBox();
            Addresstb = new TextBox();
            Pintb = new TextBox();
            AccNametb = new TextBox();
            AccNumTb = new TextBox();
            FaNameTb = new TextBox();
            dobdate = new DateTimePicker();
            educationtb = new ComboBox();
            panel2 = new Panel();
            button1 = new Button();
            label12 = new Label();
            occupationtb = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = SystemColors.HotTrack;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1111, 89);
            panel1.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(1065, 0);
            label3.Name = "label3";
            label3.Size = new Size(44, 50);
            label3.TabIndex = 1;
            label3.Text = "X";
            label3.Click += label3_Click_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.MidnightBlue;
            label5.Location = new Point(590, 322);
            label5.Name = "label5";
            label5.Size = new Size(150, 31);
            label5.TabIndex = 2;
            label5.Text = "OCCUPATION";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(70, 209);
            label2.Name = "label2";
            label2.Size = new Size(79, 31);
            label2.TabIndex = 3;
            label2.Text = "NAME";
            label2.Click += label2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.MidnightBlue;
            label4.Location = new Point(70, 356);
            label4.Name = "label4";
            label4.Size = new Size(111, 31);
            label4.TabIndex = 5;
            label4.Text = "ADDRESS";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.MidnightBlue;
            label6.Location = new Point(70, 280);
            label6.Name = "label6";
            label6.Size = new Size(90, 31);
            label6.TabIndex = 6;
            label6.Text = "FNAME";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.MidnightBlue;
            label7.Location = new Point(616, 145);
            label7.Name = "label7";
            label7.Size = new Size(50, 31);
            label7.TabIndex = 7;
            label7.Text = "PIN";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.MidnightBlue;
            label8.Location = new Point(55, 145);
            label8.Name = "label8";
            label8.Size = new Size(116, 31);
            label8.TabIndex = 8;
            label8.Text = "ACC NUM";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.MidnightBlue;
            label9.Location = new Point(616, 398);
            label9.Name = "label9";
            label9.Size = new Size(89, 31);
            label9.TabIndex = 9;
            label9.Text = "PHONE";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.MidnightBlue;
            label10.Location = new Point(590, 227);
            label10.Name = "label10";
            label10.Size = new Size(137, 31);
            label10.TabIndex = 10;
            label10.Text = "EDUCATION";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.MidnightBlue;
            label11.Location = new Point(626, 475);
            label11.Name = "label11";
            label11.Size = new Size(60, 31);
            label11.TabIndex = 11;
            label11.Text = "DOB";
            // 
            // PhoneTb
            // 
            PhoneTb.Location = new Point(760, 404);
            PhoneTb.Name = "PhoneTb";
            PhoneTb.Size = new Size(237, 27);
            PhoneTb.TabIndex = 12;
            // 
            // Addresstb
            // 
            Addresstb.Location = new Point(211, 362);
            Addresstb.Multiline = true;
            Addresstb.Name = "Addresstb";
            Addresstb.Size = new Size(237, 144);
            Addresstb.TabIndex = 13;
            // 
            // Pintb
            // 
            Pintb.Location = new Point(760, 145);
            Pintb.Name = "Pintb";
            Pintb.Size = new Size(237, 27);
            Pintb.TabIndex = 18;
            // 
            // AccNametb
            // 
            AccNametb.Location = new Point(211, 209);
            AccNametb.Name = "AccNametb";
            AccNametb.Size = new Size(237, 27);
            AccNametb.TabIndex = 19;
            AccNametb.TextChanged += AccNametb_TextChanged;
            // 
            // AccNumTb
            // 
            AccNumTb.Location = new Point(211, 145);
            AccNumTb.Name = "AccNumTb";
            AccNumTb.Size = new Size(237, 27);
            AccNumTb.TabIndex = 20;
            AccNumTb.TextChanged += AccNumTb_TextChanged;
            // 
            // FaNameTb
            // 
            FaNameTb.Location = new Point(211, 280);
            FaNameTb.Name = "FaNameTb";
            FaNameTb.Size = new Size(237, 27);
            FaNameTb.TabIndex = 21;
            // 
            // dobdate
            // 
            dobdate.Location = new Point(760, 479);
            dobdate.Name = "dobdate";
            dobdate.Size = new Size(250, 27);
            dobdate.TabIndex = 22;
            // 
            // educationtb
            // 
            educationtb.FormattingEnabled = true;
            educationtb.Items.AddRange(new object[] { "Non Graduate", "Under Graduate", "Post Graduate" });
            educationtb.Location = new Point(760, 233);
            educationtb.Name = "educationtb";
            educationtb.Size = new Size(237, 28);
            educationtb.TabIndex = 23;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MidnightBlue;
            panel2.Location = new Point(0, 696);
            panel2.Name = "panel2";
            panel2.Size = new Size(1111, 20);
            panel2.TabIndex = 24;
            // 
            // button1
            // 
            button1.BackColor = Color.MidnightBlue;
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = Color.White;
            button1.Location = new Point(466, 598);
            button1.Name = "button1";
            button1.Size = new Size(120, 40);
            button1.TabIndex = 25;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.MidnightBlue;
            label12.Location = new Point(498, 655);
            label12.Name = "label12";
            label12.Size = new Size(52, 28);
            label12.TabIndex = 26;
            label12.Text = "Back";
            label12.Click += label12_Click;
            // 
            // occupationtb
            // 
            occupationtb.Location = new Point(760, 328);
            occupationtb.Name = "occupationtb";
            occupationtb.Size = new Size(237, 27);
            occupationtb.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(267, 17);
            label1.Name = "label1";
            label1.Size = new Size(573, 50);
            label1.TabIndex = 2;
            label1.Text = "FINVISTA MANAGEMENT SYSTEM";
            // 
            // Account
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1111, 707);
            Controls.Add(label12);
            Controls.Add(button1);
            Controls.Add(panel2);
            Controls.Add(educationtb);
            Controls.Add(dobdate);
            Controls.Add(FaNameTb);
            Controls.Add(AccNumTb);
            Controls.Add(AccNametb);
            Controls.Add(Pintb);
            Controls.Add(occupationtb);
            Controls.Add(Addresstb);
            Controls.Add(PhoneTb);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Account";
            StartPosition = FormStartPosition.Manual;
            Text = "Account";
            Load += Account_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label5;
        private Label label2;
        private Label label4;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox PhoneTb;
        private TextBox Addresstb;
        private TextBox Pintb;
        private TextBox AccNametb;
        private TextBox AccNumTb;
        private TextBox FaNameTb;
        private DateTimePicker dobdate;
        private ComboBox educationtb;
        private Panel panel2;
        private Button button1;
        private Label label12;
        private TextBox occupationtb;
        private Label label3;
        private Label label1;
    }
}