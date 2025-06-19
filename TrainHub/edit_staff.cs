using System;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrainHub.Data;
using TrainHub.Models;
using TrainHub.Static_Classes;

namespace TrainHub
{
    public partial class edit_staff : Form
    {
        private readonly TrainHubContext dataContext = new TrainHubContext();
        private readonly int userID;
        private readonly StaffTable? staffTableRef;
        private static readonly Regex EmailPattern = new Regex(@"^[a-zA-Z0-9._%+-]+@gmail\.com$", RegexOptions.Compiled);

        public edit_staff(int userID, StaffTable? staffTable = null)
        {
            InitializeComponent();
            this.userID = userID;
            this.staffTableRef = staffTable;

            ConfigureForm();
            LoadUserData();
        }

        private void ConfigureForm()
        {
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void LoadUserData()
        {
            try
            {
                var user = dataContext.User.Find(userID);
                if (user == null)
                {
                    ShowErrorAndClose("User not found.");
                    return;
                }

                PopulateFields(user);
            }
            catch (Exception ex)
            {
                ShowErrorAndClose($"Error loading data: {ex.Message}");
            }
        }

        private void PopulateFields(User user)
        {
            firstNameTxt.Text = user.FirstName ?? string.Empty;
            lastNameTxt.Text = user.LastName ?? string.Empty;
            emailTxt.Text = user.Email ?? string.Empty;
            phoneNumTxt.Text = user.PhoneNumber ?? string.Empty;
            addressTxt.Text = user.Address ?? string.Empty;

            if (DateTime.TryParse(user.DateOfBirth, out DateTime dob))
            {
                birthDate.Value = dob;
            }
            else
            {
                ShowErrorAndClose("Invalid Date of Birth format.");
            }
        }

        private async void okBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInput())
                    return;

                if (await IsEmailDuplicate())
                    return;

                await UpdateUser();
                ShowSuccessAndClose();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Update failed: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInput()
        {
            // Check for empty fields
            if (IsAnyFieldEmpty())
            {
                ShowValidationError("Please fill in all fields.");
                return false;
            }

            // Validate phone number
            var phoneNumber = phoneNumTxt.Text.Trim();
            if (phoneNumber.Length != 11 || !IsAllDigits(phoneNumber))
            {
                ShowValidationError("Mobile number should be exactly 11 digits.");
                return false;
            }

            // Validate email
            if (!EmailPattern.IsMatch(emailTxt.Text.Trim()))
            {
                ShowValidationError("Please enter a valid Gmail address.");
                return false;
            }

            // Validate birth date
            if (birthDate.Value.Date >= DateTime.Now.Date)
            {
                ShowValidationError("Date of Birth must be a past date.");
                return false;
            }

            return true;
        }

        private bool IsAnyFieldEmpty()
        {
            return string.IsNullOrWhiteSpace(firstNameTxt.Text) ||
                   string.IsNullOrWhiteSpace(lastNameTxt.Text) ||
                   string.IsNullOrWhiteSpace(emailTxt.Text) ||
                   string.IsNullOrWhiteSpace(phoneNumTxt.Text) ||
                   string.IsNullOrWhiteSpace(addressTxt.Text);
        }

        private static bool IsAllDigits(string input)
        {
            foreach (char c in input)
            {
                if (!char.IsDigit(c))
                    return false;
            }
            return true;
        }

        private async Task<bool> IsEmailDuplicate()
        {
            if (await CheckEmailExistence.IsUserEmailExistsAsync(emailTxt.Text.Trim(), userID))
            {
                ShowValidationError("Email already exists. Please use another.");
                return true;
            }
            return false;
        }

        private async Task UpdateUser()
        {
            var user = dataContext.User.Find(userID);
            if (user == null)
            {
                throw new InvalidOperationException("User not found during update.");
            }

            // Update user properties
            user.FirstName = firstNameTxt.Text.Trim();
            user.LastName = lastNameTxt.Text.Trim();
            user.Email = emailTxt.Text.Trim();
            user.PhoneNumber = phoneNumTxt.Text.Trim();
            user.Address = addressTxt.Text.Trim();
            user.DateOfBirth = birthDate.Value.ToString("MM-dd-yyyy");

            // Save changes (make async if possible)
            dataContext.SaveChanges();

            // Refresh parent table if available
            //staffTableRef?.RefreshUserData();
        }

        private void phoneNumTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow control characters (backspace, delete, etc.)
            if (char.IsControl(e.KeyChar))
                return;

            // Block if already 11 digits
            if (phoneNumTxt.Text.Length >= 11)
            {
                e.Handled = true;
                return;
            }

            // Allow only digits
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            dataContext?.Dispose();
            base.OnFormClosed(e);
        }

        #region Helper Methods

        private void ShowErrorAndClose(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Close();
        }

        private void ShowValidationError(string message)
        {
            MessageBox.Show(message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void ShowSuccessAndClose()
        {
            MessageBox.Show("Staff updated successfully!", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        #endregion
    }
}