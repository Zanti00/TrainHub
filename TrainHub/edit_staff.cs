using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using TrainHub.Data;
using TrainHub.Models;
using TrainHub.Static_Classes;

namespace TrainHub
{
    public partial class edit_staff : Form
    {
        private readonly TrainHubContext dataContext = new TrainHubContext();
        private readonly string pattern = @"^[a-zA-Z0-9._%+-]+@gmail\.com$";
        private readonly StaffTable? parentForm;
        private readonly int userID;
        private User? currentUser;

        public edit_staff(int userID, StaffTable? parentForm = null)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            this.userID = userID;

            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;

            // Load existing user data
            LoadUserData();
        }

        public edit_staff()
        {
            InitializeComponent();
        }

        private void LoadUserData()
        {
            try
            {
                currentUser = dataContext.User.FirstOrDefault(u => u.Id == userID);
                if (currentUser != null)
                {
                    // Populate form fields with existing data
                    firstNameTxt.Content = currentUser.FirstName;
                    lastNameTxt.Content = currentUser.LastName;
                    emailTxt.Content = currentUser.Email;
                    passwordTxt.Content = currentUser.Password;
                    usernameTxt.Content = currentUser.Username;
                    phoneNumTxt.Content = currentUser.PhoneNumber;
                    addressTxt.Content = currentUser.Address;
                    birthDate.Value = currentUser.DateOfBirth;
                }
                else
                {
                    MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading user data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private async void okBtn_Click(object sender, EventArgs e)
        {
            if (currentUser == null)
            {
                MessageBox.Show("No user data to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(firstNameTxt.Content) ||
                string.IsNullOrWhiteSpace(lastNameTxt.Content) ||
                string.IsNullOrWhiteSpace(emailTxt.Content) ||
                string.IsNullOrWhiteSpace(addressTxt.Content) ||
                string.IsNullOrWhiteSpace(phoneNumTxt.Content))
            {
                MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Fixed: Address validation should check if it's TOO SHORT (less than 5), not if length > 5
            if (addressTxt.Content.Length < 5)
            {
                MessageBox.Show("Address is too short. Please enter a complete address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (phoneNumTxt.Content.Length != 11)
            {
                MessageBox.Show("Mobile number should be exactly 11 digits.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Regex.IsMatch(emailTxt.Content, pattern))
            {
                MessageBox.Show("Please enter a valid Gmail address.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (birthDate.Value.Date >= DateTime.Now.Date)
            {
                MessageBox.Show("Date of Birth cannot be today or in the future.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if email exists for OTHER users (exclude current user)
            if (emailTxt.Content.Trim() != currentUser.Email &&
                await CheckEmailExistence.IsUserEmailExistsAsync(emailTxt.Content))
            {
                MessageBox.Show("Email already exists. Please use a different email.", "Duplicate Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                emailTxt.Focus();
                return;
            }

            try
            {
                // Update existing user instead of creating new one
                currentUser.FirstName = firstNameTxt.Content.Trim();
                currentUser.LastName = lastNameTxt.Content.Trim();
                currentUser.Email = emailTxt.Content.Trim();
                currentUser.Password = passwordTxt.Content.Trim();
                currentUser.Username = usernameTxt.Content.Trim();
                currentUser.PhoneNumber = phoneNumTxt.Content.Trim();
                currentUser.Address = addressTxt.Content.Trim();
                currentUser.DateOfBirth = birthDate.Value.Date;

                // Save changes to existing user
                dataContext.SaveChanges();

                MessageBox.Show("Staff updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
                parentForm?.RefreshUserData(); // Refresh the parent form's data
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating staff: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void phoneNumTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (phoneNumTxt.Content.Length >= 11 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cuiButtonGroup1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            dataContext?.Dispose();
            base.OnFormClosed(e);
        }
    }
}