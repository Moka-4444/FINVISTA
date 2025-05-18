using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ATMauto
{
    public partial class changep : Form
    {
        public changep()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\DATABASE\ATMDB.MDF;Integrated Security=True;Connect Timeout=30");

        private void button1_Click(object sender, EventArgs e)
        {
            if (Pin1Tb.Text == "" || Pin2Tb.Text == "")
            {
                MessageBox.Show("Enter And Confirm The New Pin");
            }
            else if (Pin1Tb.Text != Pin2Tb.Text)
            {
                MessageBox.Show("Pin1 And Pin2 are Different");
            }
            else
            {
                string Acc = Login.AccNumber;
                int newbalance = 0;
                try
                {
                    con.Open();

                    SqlCommand selectCmd = new SqlCommand("SELECT Balance FROM AccountTbl WHERE AccNum = @accnum", con);
                    selectCmd.Parameters.AddWithValue("@accnum", Acc);
                    object result = selectCmd.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        int currentBalance = Convert.ToInt32(result);
                        int depositAmount = Convert.ToInt32(Pin1Tb.Text);  // Assuming DepoAmtTb is a TextBox
                        newbalance = currentBalance + depositAmount;

                        SqlCommand updateCmd = new SqlCommand("UPDATE AccountTbl SET Balance = @balance WHERE AccNum = @accnum", con);
                        updateCmd.Parameters.AddWithValue("@balance", newbalance);
                        updateCmd.Parameters.AddWithValue("@accnum", Acc);

                        updateCmd.ExecuteNonQuery();
                        MessageBox.Show("Amount Deposited Successfully");

                        Login home = new Login();
                        home.Show();
                        this.Hide(); // ← السطر المطلوب
                    }
                    else
                    {
                        MessageBox.Show("Account not found.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void changep_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            HOME home = new HOME();
            home.Show();
            this.Hide();
        }

        private void label4_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
