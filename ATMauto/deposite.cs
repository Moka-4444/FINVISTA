using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMauto
{
    public partial class deposite : Form
    {
        public deposite()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\DATABASE\ATMDB.MDF;Integrated Security=True;Connect Timeout=30");
        int oldbalance, newbalance;

        private void addtransaction()
        {
            string TrType = "Deposit";
            try
            {
                string query = "INSERT INTO TransactionTbl (AccNum, Type, Amount, TDate) VALUES (@AccNum, @Type, @Amount, @TDate)";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@AccNum", Login.AccNumber);
                cmd.Parameters.AddWithValue("@Type", TrType);
                cmd.Parameters.AddWithValue("@Amount", Convert.ToInt32(DepoAmtTb.Text));
                cmd.Parameters.AddWithValue("@TDate", DateTime.Today.Date.ToString("yyyy-MM-dd"));

                cmd.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Transaction Error: " + Ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DepoAmtTb.Text == "" || Convert.ToInt32(DepoAmtTb.Text) <= 0)
            {
                MessageBox.Show("Enter The Amount To Deposit");
            }
            else
            {
                string Acc = Login.AccNumber;
                newbalance = oldbalance + Convert.ToInt32(DepoAmtTb.Text);
                try
                {
                    con.Open();

                    SqlCommand selectCmd = new SqlCommand("SELECT Balance FROM AccountTbl WHERE AccNum = @accnum", con);
                    selectCmd.Parameters.AddWithValue("@accnum", Acc);
                    object result = selectCmd.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        int currentBalance = Convert.ToInt32(result);
                        int depositAmount = Convert.ToInt32(DepoAmtTb.Text);
                        newbalance = currentBalance + depositAmount;

                        SqlCommand updateCmd = new SqlCommand("UPDATE AccountTbl SET Balance = @balance WHERE AccNum = @accnum", con);
                        updateCmd.Parameters.AddWithValue("@balance", newbalance);
                        updateCmd.Parameters.AddWithValue("@accnum", Acc);

                        updateCmd.ExecuteNonQuery();

                        // نداء دالة تسجيل العملية بعد نجاح الإيداع
                        addtransaction();

                        MessageBox.Show("Amount Deposited Successfully");
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

        private void getbalance()
        {
            try
            {
                con.Open();
                string query = "SELECT Balance FROM AccountTbl WHERE AccNum = @accnum";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@accnum", Login.AccNumber);

                object result = cmd.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    oldbalance = Convert.ToInt32(result);
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

        private void deposite_Load(object sender, EventArgs e)
        {
            getbalance();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            HOME home = new HOME();
            home.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
