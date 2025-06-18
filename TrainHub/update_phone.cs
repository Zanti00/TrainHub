using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace TrainHub
{
    public partial class update_phone : Form
    {
        private const int PHONE_MIN_LENGTH = 10;
        private const int PHONE_MAX_LENGTH = 11;

        public update_phone()
        {
            InitializeComponent();
            InitializeForm();
        }

        private void InitializeForm()
        {
            txtPassword.PasswordChar = '*'; // Password masking  
            txtPhoneNumber.MaxLength = PHONE_MAX_LENGTH;  // Limit input length

            // Add input validation events
            txtPhoneNumber.KeyPress += TxtPhoneNumber_KeyPress;
            txtPassword.KeyDown += TxtPassword_KeyDown;
            txtPhoneNumber.KeyDown += TxtPhoneNumber_KeyDown;
        }

        // Only allow numeric input for phone number
        private void TxtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // Allow Enter key to trigger save action
        private void TxtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave_Click(sender, e);
            }
        }

        private void TxtPhoneNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPassword.Focus();
            }
        }

        private void btnTogglePasswordVisibility_Click(object sender, EventArgs e)
        {
            bool isVisible = txtPassword.PasswordChar == '\0';
            txtPassword.PasswordChar = isVisible ? '\0' : '*';

            // Update button text/icon to reflect current state
            btnTogglePasswordVisibility.Text = isVisible ? "Hide" : "Show";
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Disable button to prevent multiple clicks
                btnSave.Enabled = false;
                btnSave.Text = "Updating...";

                string newPhone = txtPhoneNumber.Text.Trim();
                string password = txtPassword.Text.Trim();

                // Comprehensive field validation
                if (!ValidateInput(newPhone, password))
                {
                    return;
                }

                // Verify password asynchronously
                if (!await VerifyPasswordAsync(password))
                {
                    MessageBox.Show("Incorrect password.", "Authentication Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Content = string.Empty; // Clear the content
                    txtPassword.Focus();
                    return;
                }

                // Format phone number for consistency
                string formattedPhone = FormatPhoneNumber(newPhone);

                // Update phone number in database
                bool updateSuccess = await UpdatePhoneNumberInDatabase(formattedPhone);

                if (updateSuccess)
                {
                    MessageBox.Show($"Phone number updated successfully to: {formattedPhone}",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Set dialog result for parent form
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to update phone number. Please try again.",
                        "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Re-enable button
                btnSave.Enabled = true;
                btnSave.Text = "Save";
            }
        }

        private bool ValidateInput(string phoneNumber, string password)
        {
            // Check for empty fields  
            if (string.IsNullOrWhiteSpace(phoneNumber))
            {
                MessageBox.Show("Please enter a phone number.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhoneNumber.Content = string.Empty; // Clear the content
                txtPhoneNumber.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter your password.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return false;
            }

            // Enhanced phone validation
            if (!IsValidPhoneNumber(phoneNumber))
            {
                MessageBox.Show($"Please enter a valid {PHONE_MIN_LENGTH} or {PHONE_MAX_LENGTH}-digit phone number.",
                    "Invalid Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhoneNumber.Content = string.Empty; // Clear the content
                txtPhoneNumber.Focus();
                return false;
            }

            return true;
        }

        private bool IsValidPhoneNumber(string phoneNumber)
        {
            // Remove any non-digit characters for validation
            string digitsOnly = Regex.Replace(phoneNumber, @"\D", "");

            // Check length and format
            if (digitsOnly.Length < PHONE_MIN_LENGTH || digitsOnly.Length > PHONE_MAX_LENGTH)
            {
                return false;
            }

            // Additional validation: ensure it doesn't start with 0 or 1 (US format)
            if (digitsOnly.StartsWith("0") || digitsOnly.StartsWith("1"))
            {
                return false;
            }

            return true;
        }

        private string FormatPhoneNumber(string phoneNumber)
        {
            // Remove any non-digit characters
            string digitsOnly = Regex.Replace(phoneNumber, @"\D", "");

            // Format based on length
            if (digitsOnly.Length == 10)
            {
                return $"({digitsOnly.Substring(0, 3)}) {digitsOnly.Substring(3, 3)}-{digitsOnly.Substring(6)}";
            }
            else if (digitsOnly.Length == 11)
            {
                return $"+{digitsOnly.Substring(0, 1)} ({digitsOnly.Substring(1, 3)}) {digitsOnly.Substring(4, 3)}-{digitsOnly.Substring(7)}";
            }

            return phoneNumber; // Return original if formatting fails
        }

        private async Task<bool> VerifyPasswordAsync(string password)
        {
            // TODO: Replace with actual database password verification
            // This should hash the input password and compare with stored hash

            // Simulate async database call
            await Task.Delay(500);

            // Placeholder - replace with actual authentication logic
            string storedPasswordHash = GetStoredPasswordHash(); // Get from database
            string inputPasswordHash = HashPassword(password);

            return storedPasswordHash == inputPasswordHash;
        }

        private string HashPassword(string password)
        {
            // TODO: Implement proper password hashing (e.g., bcrypt, Argon2, or PBKDF2)
            // This is a placeholder - DO NOT use in production
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password + "salt"));
                return Convert.ToBase64String(bytes);
            }
        }

        private string GetStoredPasswordHash()
        {
            // TODO: Retrieve password hash from database
            // Placeholder implementation
            return HashPassword("yourPassword");
        }

        private async Task<bool> UpdatePhoneNumberInDatabase(string phoneNumber)
        {
            try
            {

                // Simulate async database operation
                await Task.Delay(1000);
                return true; // Placeholder - always succeeds
            }
            catch (Exception ex)
            {
                // Log the exception
                System.Diagnostics.Debug.WriteLine($"Database update error: {ex.Message}");
                return false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}