using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace TrainHub
{
    public partial class update_phone : Form
    {
        private const int PHONE_LENGTH = 11;
        private bool isPasswordVisible = false;

        public update_phone()
        {
            InitializeComponent();
            SetupForm();
        }

        private void SetupForm()
        {
            this.Text = "TrainHub - Update Phone Number";

            // Setup password field
            //txtPassword.PasswordChar = '*';

            // Setup event handlers
            txtPhoneNumber.KeyPress += OnlyAllowDigits;
            txtPhoneNumber.KeyDown += (s, e) => { if (e.KeyCode == Keys.Enter) txtPassword.Focus(); };
            txtPassword.KeyDown += (s, e) => { if (e.KeyCode == Keys.Enter) btnSave_Click(s, e); };
        }

        private void OnlyAllowDigits(object sender, KeyPressEventArgs e)
        {
            // Only allow digits and control characters (backspace, delete)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            // Disable button during processing
            btnSave.Enabled = false;
            btnSave.Text = "Updating...";

            try
            {
                string phone = txtPhoneNumber.Text.Trim();
                string password = txtPassword.Text.Trim();

                // Validate inputs
                if (!IsValidInput(phone, password))
                    return;

                // Verify password
                if (!await VerifyPasswordAsync(password))
                {
                    ShowError("Incorrect password.");
                    txtPassword.Content = string.Empty; // Clear the password field
                    txtPassword.Focus();
                    return;
                }

                // Update phone number
                string formattedPhone = FormatPhoneNumber(phone);
                bool success = await UpdatePhoneInDatabaseAsync(formattedPhone);

                if (success)
                {
                    MessageBox.Show($"Phone number updated to: {formattedPhone}",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    ShowError("Failed to update phone number. Please try again.");
                }
            }
            catch (Exception ex)
            {
                ShowError($"An error occurred: {ex.Message}");
            }
            finally
            {
                btnSave.Enabled = true;
                btnSave.Text = "SAVE CHANGES";
            }
        }

        private bool IsValidInput(string phone, string password)
        {
            if (string.IsNullOrWhiteSpace(phone))
            {
                ShowError("Please enter a phone number.");
                txtPhoneNumber.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                ShowError("Please enter your password.");
                txtPassword.Focus();
                return false;
            }

            // Remove non-digits and check length
            string digitsOnly = Regex.Replace(phone, @"\D", "");
            if (digitsOnly.Length != PHONE_LENGTH)
            {
                ShowError($"Please enter exactly {PHONE_LENGTH} digits.");
                txtPhoneNumber.Focus();
                return false;
            }

            return true;
        }

        private string FormatPhoneNumber(string phone)
        {
            string digits = Regex.Replace(phone, @"\D", "");
            // Format: +1 (XXX) XXX-XXXX
            return $"+{digits.Substring(0, 1)} ({digits.Substring(1, 3)}) {digits.Substring(4, 3)}-{digits.Substring(7)}";
        }

        private async Task<bool> VerifyPasswordAsync(string password)
        {
            // Simulate password verification delay
            await Task.Delay(500);

            // TODO: Replace with actual password verification logic
            // This should hash the input password and compare with stored hash
            return password == "demo123"; // Temporary for demonstration
        }

        private async Task<bool> UpdatePhoneInDatabaseAsync(string phoneNumber)
        {
            try
            {
                // Simulate database update delay
                await Task.Delay(1000);

                // TODO: Implement actual database update
                // Example: return await database.UpdateUserPhone(userId, phoneNumber);
                return true; // Temporary success response
            }
            catch
            {
                return false;
            }
        }

        private void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        private void showPassBtn_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar)
            {
                txtPassword.PasswordChar = false;
            }
            else
            {
                txtPassword.PasswordChar = true;
            }
        }
    }
}