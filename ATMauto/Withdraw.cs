using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMauto
{
    public partial class withdraw : Form
    {
        public withdraw()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\DATABASE\ATMDB.MDF;Integrated Security=True;Connect Timeout=30");
        string Acc = Login.AccNumber;
        int bal;

        private void getbalance()
        {
            try
            {
                con.Open();
                string query = "SELECT Balance FROM AccountTbl WHERE AccNum = @accnum";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@accnum", Acc);

                object result = cmd.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    bal = Convert.ToInt32(result);
                    balancelbl.Text = result.ToString();
                }
                else
                {
                    balancelbl.Text = "N/A";
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

        private void withdraw_Load(object sender, EventArgs e)
        {
            getbalance();
        }

        int newbalance;

        private void button1_Click(object sender, EventArgs e)
        {
            if (wdamtTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else if (Convert.ToInt32(wdamtTb.Text) <= 0)
            {
                MessageBox.Show("Enter a Valid Amount");
            }
            else if (Convert.ToInt32(wdamtTb.Text) > bal)
            {
                MessageBox.Show("Balance Can not be negative");
            }
            else
            {
                try
                {
                    newbalance = bal - Convert.ToInt32(wdamtTb.Text);
                    try
                    {
                        con.Open();

                        SqlCommand selectCmd = new SqlCommand("SELECT Balance FROM AccountTbl WHERE AccNum = @accnum", con);
                        selectCmd.Parameters.AddWithValue("@accnum", Acc);
                        object result = selectCmd.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            int currentBalance = Convert.ToInt32(result);
                            int withdrawAmount = Convert.ToInt32(wdamtTb.Text);
                            newbalance = currentBalance - withdrawAmount;

                            SqlCommand updateCmd = new SqlCommand("UPDATE AccountTbl SET Balance = @balance WHERE AccNum = @accnum", con);
                            updateCmd.Parameters.AddWithValue("@balance", newbalance);
                            updateCmd.Parameters.AddWithValue("@accnum", Acc);

                            updateCmd.ExecuteNonQuery();

                            // نداء دالة تسجيل السحب بعد نجاح العملية
                            addtransaction();

                            MessageBox.Show("Success Withdraw");

                            // الانتقال إلى صفحة الـ Home بعد السحب
                            HOME home = new HOME();
                            home.Show();
                            this.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        con.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void addtransaction()
        {
            string TrType = "WithDraw";
            try
            {
                string query = "INSERT INTO TransactionTbl (AccNum, Type, Amount, TDate) VALUES (@AccNum, @Type, @Amount, @TDate)";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@AccNum", Login.AccNumber);
                cmd.Parameters.AddWithValue("@Type", TrType);
                cmd.Parameters.AddWithValue("@Amount", Convert.ToInt32(wdamtTb.Text));
                cmd.Parameters.AddWithValue("@TDate", DateTime.Today.Date.ToString("yyyy-MM-dd"));

                cmd.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Transaction Error: " + Ex.Message);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label12_Click(object sender, EventArgs e)
        {
            this.Hide();
            HOME home = new HOME();
            home.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
