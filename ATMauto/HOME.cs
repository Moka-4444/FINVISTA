using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMauto
{
    public partial class HOME : Form
    {
        public HOME()
        {
            InitializeComponent();
        }

        public static string AccNumber;
        private bool atmAccessGranted = false; // متغير للتحكم في الدخول

        private void HOME_Load(object sender, EventArgs e)
        {
            AccNumlbl.Text = "Account Number:" + Login.AccNumber;
            AccNumber = Login.AccNumber;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // زر الدخول إلى ATM
        private void button6_Click_1(object sender, EventArgs e)
        {
            ATMS atm = new ATMS();
            this.Hide();                     // نخفي الفورم الحالية
            atm.ShowDialog();               // نفتح فورم ATMS كمودال
            this.Show();                    // نرجع نظهر HOME
            atmAccessGranted = true;        // السماح بالدخول للعمليات بعد الرجوع
        }

        // زر Deposit - محمي
        private void button6_Click(object sender, EventArgs e)
        {
            if (atmAccessGranted)
            {
                deposite depo = new deposite();
                depo.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please access ATM first before using this operation.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // زر Balance - غير محمي
        private void button1_Click(object sender, EventArgs e)
        {
            Balance bal = new Balance();
            bal.Show();
            this.Hide();
        }

        // زر Last Transaction - غير محمي
        private void button2_Click(object sender, EventArgs e)
        {
            ministatement mini = new ministatement();
            mini.Show();
            this.Hide();
        }

        // زر Withdraw - محمي
        private void button3_Click(object sender, EventArgs e)
        {
            if (atmAccessGranted)
            {
                withdraw wd = new withdraw();
                wd.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please access ATM first before using this operation.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // زر Change PIN - غير محمي
        private void button4_Click(object sender, EventArgs e)
        {
            changep Pin = new changep();
            Pin.Show();
            this.Hide();
        }

        // زر Fast Cash - محمي
        private void button5_Click(object sender, EventArgs e)
        {
            if (atmAccessGranted)
            {
                FastCash Fcash = new FastCash();
                Fcash.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please access ATM first before using this operation.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
