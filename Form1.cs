using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace ExamWPFcoffee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Set initial button properties
            pictureBox1.BackColor = Color.Red;
            pictureBox1.ForeColor = Color.Black;

            // Attach hover events
            pictureBox1.MouseEnter += btnClose_MouseEnter;
            pictureBox1.MouseLeave += btnClose_MouseLeave;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to close?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
                Environment.Exit(0);
            }
        }

        // Event triggered when the mouse enters the button area
        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.DarkRed;  // Change background color on hover
            pictureBox1.ForeColor = Color.White;   // Change text color on hover
        }

        // Event triggered when the mouse leaves the button area
        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Red;     // Revert background color
            pictureBox1.ForeColor = Color.Black;  // Revert text color
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Authenticate the user by checking the role after password hashing
            string userRole = AuthenticateUser(username, password);

            if (userRole == "Admin")
            {
                this.Hide();
                using (var adminDashboard = new AdminDashboardForm())
                {
                    adminDashboard.ShowDialog(this);
                }
                this.Close();
            }
            else if (userRole == "Cashier")
            {
                this.Hide();
                using (var cashierDashboard = new CashierDashbordForm())
                {
                    cashierDashboard.ShowDialog(this);
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid credentials. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Mock authentication method with hashed password comparison
        private string AuthenticateUser(string username, string password)
        {
            // Mock users with hashed passwords (In a real app, this should come from a database)
            var users = new Dictionary<string, string>
            {
                { "admin", ComputeSha256Hash("123") }, // Hash for "123" password for admin
                { "cashier", ComputeSha256Hash("123") } // Hash for "123" password for cashier
            };

            if (users.ContainsKey(username))
            {
                string storedHash = users[username];
                string inputHash = ComputeSha256Hash(password);

                // Compare the hashes
                if (storedHash == inputHash)
                {
                    return username.Equals("admin") ? "Admin" : "Cashier";
                }
            }

            return null; // Invalid credentials
        }

        // Method to hash the input password using SHA-256
        private string ComputeSha256Hash(string rawData)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // Compute hash from the raw data
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convert byte array to a string
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            new RegisterForm().ShowDialog(this);
        }
    }
}
