using System;
using System.Windows.Forms;

namespace ATMauto
{
    public partial class ATMS : Form
    {
        private bool isReserved = false;
        private string reservedATM = "";

        public ATMS()
        {
            InitializeComponent();
        }

        private void ATMS_Load(object sender, EventArgs e)
        {
            EnableAllReserveButtons();

            // Generate random values for labels
            label1.Text = GetRandomLabelText(); // Random label for ATM Finder
            Capacity1.Text = GetRandomLabelText(); // Random label for Choose your ATM
            label3.Text = GetRandomLabelText(); // Random label for Reserve your spot
            label5.Text = GetRandomLabelText(); // Random label for Welcome message
        }

        // Method to generate a random label text
        private string GetRandomLabelText()
        {
            Random random = new Random();
            string[] randomTexts = new string[]
            {
                "ATM Finder", "Choose your ATM", "Reserve your spot", "Welcome, User",
                "Please select an ATM", "ATM Booking System", "Reserve Now", "Select your machine",
                "ATM Reservation in progress", "Enjoy your banking experience"
            };

            // Return a random text from the list
            int index = random.Next(randomTexts.Length);
            return randomTexts[index];
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            HOME home = new HOME();
            home.Show();
            this.Hide();
        }

        // ====== RESERVATION METHODS ======
        private void ReserveATM(string atmName)
        {
            if (isReserved)
            {
                MessageBox.Show("An ATM is already reserved!", "Reservation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            isReserved = true;
            reservedATM = atmName;

            FreezeAllButtonsExcept(atmName); // Freeze all buttons except the cancel button of the reserved ATM

            MessageBox.Show($"ATM reserved successfully!\nReserved: {reservedATM}", "Reservation Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CancelReservation(string atmName)
        {
            if (!isReserved)
            {
                MessageBox.Show("No ATM is currently reserved.", "No Reservation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (reservedATM != atmName)
            {
                MessageBox.Show($"You didn't reserve {atmName}.", "Cancel Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            isReserved = false;
            reservedATM = "";

            EnableAllReserveButtons(); // Enable all buttons again when reservation is cancelled

            MessageBox.Show($"{atmName} reservation cancelled successfully.", "Cancellation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FreezeAllButtonsExcept(string atmName)
        {
            // Disable all reserve buttons except for the cancel button of the reserved ATM
            button1.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button2.Enabled = false;

            // Enable only the cancel button for the reserved ATM
            if (atmName == "QNB ATM")
                button5.Enabled = true;
            else
                button5.Enabled = false; // Disable other cancel buttons
        }

        private void EnableAllReserveButtons()
        {
            // Enable all buttons
            button1.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button2.Enabled = true;
            button5.Enabled = true;
        }

        // ====== RESERVE BUTTON EVENTS ======
        private void button1_Click(object sender, EventArgs e)
        {
            ReserveATM("ALAHLY ATM");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ReserveATM("CIB ATM");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ReserveATM("AGRICULTURE ATM");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReserveATM("QNB ATM");
        }

        private void button5_Click(object sender, EventArgs e) // Cancel QNB
        {
            CancelReservation("QNB ATM");
        }

        // ====== CANCEL BUTTON EVENTS ======
        private void button6_Click(object sender, EventArgs e) // Cancel ALAHLY
        {
            CancelReservation("ALAHLY ATM");
        }

        private void button7_Click(object sender, EventArgs e) // Cancel CIB
        {
            CancelReservation("CIB ATM");
        }

        private void button8_Click(object sender, EventArgs e) // Cancel AGRI
        {
            CancelReservation("AGRICULTURE ATM");
        }

        private void button9_Click(object sender, EventArgs e) // Cancel MASR
        {
            CancelReservation("MASR ATM");
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {
            // Optional logic
        }

        private void ATMS_Load_1(object sender, EventArgs e)
        {
            // Optional logic
        }

        private void groupBox5_Enter_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            HOME hOME = new HOME();
            hOME.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
