using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace ATMauto
{
    public partial class ministatement : Form
    {
        private ListView MinistatementLV;

        // ✅ إضافات BST
        private TransactionBST bst = new TransactionBST();
        private TextBox searchBox;
        private Button searchButton;

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\DATABASE\ATMDB.MDF;Integrated Security=True;Connect Timeout=30");
        string Acc = Login.AccNumber;

        public ministatement()
        {
            InitializeComponent();
            InitializeCustomListView();
            InitializeSearchControls(); // ✅
        }

        private void InitializeCustomListView()
        {
            MinistatementLV = new ListView();
            MinistatementLV.View = View.Details;
            MinistatementLV.FullRowSelect = true;
            MinistatementLV.GridLines = true;
            MinistatementLV.Size = new Size(740, 250);
            MinistatementLV.Location = new Point(30, 140);
            MinistatementLV.BackColor = Color.White;
            MinistatementLV.ForeColor = Color.Black;

            MinistatementLV.Columns.Add("Tid", 50);
            MinistatementLV.Columns.Add("AccNum", 100);
            MinistatementLV.Columns.Add("Type", 150);
            MinistatementLV.Columns.Add("Amount", 100);
            MinistatementLV.Columns.Add("TDate", 150);

            this.Controls.Add(MinistatementLV);
        }

        // ✅ controls للبحث
        private void InitializeSearchControls()
        {
            searchBox = new TextBox();
            searchBox.Size = new Size(100, 25);
            searchBox.Location = new Point(30, 100);
            this.Controls.Add(searchBox);

            searchButton = new Button();
            searchButton.Text = "Search by Tid";
            searchButton.Size = new Size(120, 25);
            searchButton.Location = new Point(140, 100);
            searchButton.Click += SearchButton_Click;
            this.Controls.Add(searchButton);
        }

        // ✅ بحث باستخدام BST
        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(searchBox.Text, out int tid))
            {
                var result = bst.Search(tid);
                if (result != null)
                {
                    MessageBox.Show($"Transaction Found:\n\nTid: {result.Tid}\nAccNum: {result.AccNum}\nType: {result.Type}\nAmount: {result.Amount}\nDate: {result.TDate}", "Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Transaction not found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid Tid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void populate()
        {
            try
            {
                con.Open();
                string query = "SELECT * FROM TransactionTbl WHERE AccNum = @AccNum";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@AccNum", Acc);
                SqlDataReader reader = cmd.ExecuteReader();

                MinistatementLV.Items.Clear();
                bst = new TransactionBST(); // ✅ إعادة ضبط الشجرة

                while (reader.Read())
                {
                    string tidStr = reader["Tid"].ToString();
                    string accNum = reader["AccNum"].ToString();
                    string type = reader["Type"].ToString();
                    string amount = reader["Amount"].ToString();
                    string tDate = reader["TDate"].ToString();

                    ListViewItem item = new ListViewItem(tidStr);
                    item.SubItems.Add(accNum);
                    item.SubItems.Add(type);
                    item.SubItems.Add(amount);
                    item.SubItems.Add(tDate);

                    MinistatementLV.Items.Add(item);

                    // ✅ إدخال المعاملة في الشجرة
                    int tid = int.Parse(tidStr);
                    TransactionNode node = new TransactionNode(tid, accNum, type, amount, tDate);
                    bst.Insert(node);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading transactions: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void ministatement_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            HOME home = new HOME();
            home.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

    // ✅ تعريف Node و BST
    class TransactionNode
    {
        public int Tid;
        public string AccNum, Type, Amount, TDate;
        public TransactionNode Left, Right;

        public TransactionNode(int tid, string accNum, string type, string amount, string tDate)
        {
            Tid = tid;
            AccNum = accNum;
            Type = type;
            Amount = amount;
            TDate = tDate;
        }
    }

    class TransactionBST
    {
        public TransactionNode Root;

        public void Insert(TransactionNode node)
        {
            Root = InsertRec(Root, node);
        }

        private TransactionNode InsertRec(TransactionNode root, TransactionNode node)
        {
            if (root == null) return node;

            if (node.Tid < root.Tid)
                root.Left = InsertRec(root.Left, node);
            else
                root.Right = InsertRec(root.Right, node);

            return root;
        }

        public TransactionNode Search(int tid)
        {
            return SearchRec(Root, tid);
        }

        private TransactionNode SearchRec(TransactionNode root, int tid)
        {
            if (root == null || root.Tid == tid) return root;

            if (tid < root.Tid)
                return SearchRec(root.Left, tid);
            else
                return SearchRec(root.Right, tid);
        }
    }
}
