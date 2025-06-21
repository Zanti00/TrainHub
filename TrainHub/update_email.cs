using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Security.Cryptography;
using System.Linq;
using System.Collections.Generic;

namespace TrainHub
{
    public partial class update_email : Form
    {
        private static Dictionary<int, UserData> users = new Dictionary<int, UserData>();
        private int Id; // Current user's ID

        public class UserData
        {
            public int Id { get; set; }
            public string Email { get; set; }
            public string Password { get; set; }
        }

        public update_email()
        {
            InitializeComponent();
            this.Id = 1; // Default user for demo
            InitializeTestData(); // Add test data
        }

        public update_email(int currentUserId)
        {
            InitializeComponent();
            this.Id = currentUserId;
            InitializeTestData(); // Add test data
        }

        // Initialize some test data for demonstration
        private void InitializeTestData()
        {
            if (!users.ContainsKey(1))
            {
                AddUser(1, "user@example.com", "password123");
            }
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                string newEmail = GetControlText("txtNewEmail");
                string password = GetControlText("txtPassword");

                // Validate inputs
                if (!ValidateInputs(newEmail, password))
                    return;

                // Verify password and update email
                if (VerifyPasswordAndUpdateEmail(newEmail, password))
                {
                    MessageBox.Show("Email updated successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetControlText(string controlName)
        {
            Control control = this.Controls.Find(controlName, true).FirstOrDefault();
            return control?.Text?.Trim() ?? "";
        }

        private bool ValidateInputs(string email, string password)
        {
            // Check if fields are empty
            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please enter your new email.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                FocusControl("txtNewEmail");
                return false;
            }

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter your password.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                FocusControl("txtPassword");
                return false;
            }

            // Validate email format
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Please enter a valid email address.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                FocusControl("txtNewEmail");
                return false;
            }

            return true;
        }

        private void FocusControl(string controlName)
        {
            Control control = this.Controls.Find(controlName, true).FirstOrDefault();
            control?.Focus();
        }

        private bool IsValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }

        private bool VerifyPasswordAndUpdateEmail(string newEmail, string password)
        {
            try
            {
                // Check if user exists
                if (!users.ContainsKey(Id))
                {
                    MessageBox.Show("User not found.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                UserData currentUser = users[Id];

                // Verify the current password
                if (!VerifyPassword(password, currentUser.Password))
                {
                    MessageBox.Show("Incorrect password. Please try again.", "Authentication Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    FocusControl("txtPassword");
                    return false;
                }

                // Check if email already exists for other users
                if (users.Values.Any(u => u.Id != Id && u.Email.Equals(newEmail, StringComparison.OrdinalIgnoreCase)))
                {
                    MessageBox.Show("This email is already in use. Please choose a different email.",
                        "Email Already Exists", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    FocusControl("txtNewEmail");
                    return false;
                }

                // Update the email
                currentUser.Email = newEmail;

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool VerifyPassword(string inputPassword, string storedPassword)
        {
            // If stored password looks like a hash (contains special characters)
            if (storedPassword.Length > 20 && storedPassword.Contains("$"))
            {
                // Use BCrypt or similar for hashed passwords
                // return BCrypt.Net.BCrypt.Verify(inputPassword, storedPassword);
                return inputPassword == storedPassword; // Fallback for demo
            }

            // Simple comparison for plain text passwords (not recommended for production)
            return inputPassword == storedPassword;
        }

        private string HashPassword(string password)
        {
            // Simple hash for demo - use BCrypt in production
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void txtNewEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only valid email characters
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) &&
                e.KeyChar != '@' && e.KeyChar != '.' && e.KeyChar != '_' &&
                e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSaveChanges_Click(sender, e);
            }
        }

        private void update_email_Load(object sender, EventArgs e)
        {
            // Load current email for reference
            LoadCurrentEmail();
        }

        private void LoadCurrentEmail()
        {
            try
            {
                if (users.ContainsKey(Id))
                {
                    string currentEmail = users[Id].Email;
                    // You can display current email in a label if needed
                    // lblCurrentEmail.Text = $"Current Email: {currentEmail}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading current email: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Helper method to get current user's email (for external access)
        public string GetCurrentUserEmail()
        {
            return users.ContainsKey(Id) ? users[Id].Email : string.Empty;
        }

        // Helper method to add new users (for testing purposes)
        public static void AddUser(int userId, string email, string password)
        {
            users[userId] = new UserData
            {
                Id = userId,
                Email = email,
                Password = password,
            };
        }
        private void passwordEyeButton_Click(object sender, EventArgs e)
        {
            // Fixed: Correctly check the PasswordChar property of cuiTextBox
            if (txtPassword.PasswordChar)
            {
                txtPassword.PasswordChar = false; // Show password
                if (sender is Button btn)
                    btn.Text = "Hide";
            }
            else
            {
                txtPassword.PasswordChar = true; // Hide password
                if (sender is Button btn)
                    btn.Text = "Show";
            }
        }
    }
}