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
    public partial class Account : Form
    {
        public Account()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\DATABASE\ATMDB.MDF;Integrated Security=True;Connect Timeout=30");
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (AccNametb.Text == "" || AccNumTb.Text == "" || FaNameTb.Text == "" || PhoneTb.Text == "" || Addresstb.Text == "" || occupationtb.Text == "" || Pintb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "INSERT INTO AccountTbl (AccNum, Name, FaName, Dob, Phone, Address, Education, Occupation, PIN, Balance) " +
                                  "VALUES (@AccNum, @Name, @FaName, @Dob, @Phone, @Address, @Education, @Occupation, @PIN, @Balance)";

                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@AccNum", AccNumTb.Text);
                    cmd.Parameters.AddWithValue("@Name", AccNametb.Text);
                    cmd.Parameters.AddWithValue("@FaName", FaNameTb.Text);
                    cmd.Parameters.AddWithValue("@Dob", "01/01/2000"); // يمكن استبدالها بقيمة من عنصر واجهة المستخدم
                    cmd.Parameters.AddWithValue("@Phone", PhoneTb.Text);
                    cmd.Parameters.AddWithValue("@Address", Addresstb.Text);
                    cmd.Parameters.AddWithValue("@Education", "Bachelor"); // يمكن استبدالها بقيمة من عنصر واجهة المستخدم
                    cmd.Parameters.AddWithValue("@Occupation", occupationtb.Text);
                    cmd.Parameters.AddWithValue("@PIN", Pintb.Text);
                    cmd.Parameters.AddWithValue("@Balance", 0); // رصيد ابتدائي صفر

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account Created Successfully");
                    con.Close();
                    Login log = new Login();
                    log.Show();
                    this.Hide();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
                finally
                {
                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }
                }
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AccNametb_TextChanged(object sender, EventArgs e)
        {

        }

        private void AccNumTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void Account_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}