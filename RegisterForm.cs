using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamWPFcoffee
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            // Populate role ComboBox (if not already done in the designer)
            Role.Items.Clear();
            Role.Items.AddRange(new string[] { "Admin", "Cashier", "Staff" });
            Role.SelectedIndex = 0; // Set default selection
                                    // Populate Gender ComboBox
            Genderbox.Items.Add("Male");
            Genderbox.Items.Add("Female");
            Genderbox.SelectedIndex = 0; // Default to Male
        }

        private void txtUsernameRegis_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPasswordRegis_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtConfirmPW_TextChanged(object sender, EventArgs e)
        {

        }

        private void tctPhoneNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void DateOfBirth_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void Role_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRegisterForm_Click(object sender, EventArgs e)
        {
            // Retrieve user inputs
            string username = txtUsernameRegis.Text.Trim();
            string password = txtPasswordRegis.Text.Trim();
            string phoneNumber = txtPhoneNumber.Text.Trim();
            string gender = Genderbox.SelectedItem?.ToString();
            string role = Role.SelectedItem?.ToString();
            DateTime dob = DateOfBirth.SelectionStart;

            // Validate input
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(phoneNumber) ||
                string.IsNullOrEmpty(gender) || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!long.TryParse(phoneNumber, out _))
            {
                MessageBox.Show("Invalid phone number format.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Simulate saving to database
            bool isRegistered = AddUserToDatabase(username, password, phoneNumber, dob, gender, role);

            if (isRegistered)
            {
                MessageBox.Show("User registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Registration failed. Username already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool AddUserToDatabase(string username, string password, string phoneNumber, DateTime dob, string gender, string role)
        {
            // Mock database logic (for demonstration)
            if (username == "existingUser") // Simulate an existing username check
                return false;

            // Simulate adding user logic (e.g., save to a database)
            Console.WriteLine($"User registered: {username}, Role: {role}, DOB: {dob.ToShortDateString()}, Gender: {gender}, Phone: {phoneNumber}");
            return true;

        }

        private void Genderbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
