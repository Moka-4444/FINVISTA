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
    public partial class FastCash : Form
    {
        public FastCash()
        {
            InitializeComponent();
        }

        string Acc = Login.AccNumber;
        int bal;

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\DATABASE\ATMDB.MDF;Integrated Security=True;Connect Timeout=30");

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

        private void addtransaction(int amount)
        {
            string TrType = "WithDraw";
            try
            {
                string query = "INSERT INTO TransactionTbl (AccNum, Type, Amount, TDate) VALUES (@AccNum, @Type, @Amount, @TDate)";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@AccNum", Login.AccNumber);
                cmd.Parameters.AddWithValue("@Type", TrType);
                cmd.Parameters.AddWithValue("@Amount", amount);
                cmd.Parameters.AddWithValue("@TDate", DateTime.Today.Date.ToString("yyyy-MM-dd"));

                cmd.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Transaction Error: " + Ex.Message);
            }
        }

        private void withdraw(int amount)
        {
            if (bal < amount)
            {
                MessageBox.Show("Balance Can Not Be Negative");
            }
            else
            {
                int newbalance = bal - amount;
                try
                {
                    con.Open();

                    SqlCommand selectCmd = new SqlCommand("SELECT Balance FROM AccountTbl WHERE AccNum = @accnum", con);
                    selectCmd.Parameters.AddWithValue("@accnum", Acc);
                    object result = selectCmd.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        SqlCommand updateCmd = new SqlCommand("UPDATE AccountTbl SET Balance = @balance WHERE AccNum = @accnum", con);
                        updateCmd.Parameters.AddWithValue("@balance", newbalance);
                        updateCmd.Parameters.AddWithValue("@accnum", Acc);

                        updateCmd.ExecuteNonQuery();
                        addtransaction(amount);
                        MessageBox.Show("Success Withdraw");

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
        }

        private void FastCash_Load(object sender, EventArgs e)
        {
            getbalance();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            withdraw(100);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            withdraw(500);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            withdraw(1000);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            withdraw(2000);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            withdraw(5000);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            withdraw(10000);
        }

        private void label2_Click(object sender, EventArgs e) { }

        private void label3_Click(object sender, EventArgs e) { Application.Exit(); }

        private void label12_Click(object sender, EventArgs e)
        {
            HOME home = new HOME();
            home.Show();
            this.Hide();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
