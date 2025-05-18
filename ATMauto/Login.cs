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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public static string AccNumber;

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\DATABASE\ATMDB.MDF;Integrated Security=True;Connect Timeout=30");

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Account acc = new Account();
            acc.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "SELECT COUNT(*) FROM AccountTbl WHERE AccNum = @accnum AND Pin = @pin";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@accnum", AccNumtb.Text);
                cmd.Parameters.AddWithValue("@pin", Pintb.Text);

                int result = (int)cmd.ExecuteScalar();

                if (result == 1)
                {
                    AccNumber = AccNumtb.Text;
                    HOME hOME = new HOME();
                    hOME.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong account number or pin code");
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

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label8_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}