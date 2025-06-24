using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using TrainHub.Data;
using TrainHub.Models;
using TrainHub.Static_Classes;

namespace TrainHub
{
    public partial class add_newstaff : Form
    {
        private readonly TrainHubContext dataContext = new TrainHubContext();
        private readonly string pattern = @"^[a-zA-Z0-9._%+-]+@gmail\.com$";
        private readonly StaffTable? parentForm;

        public add_newstaff(StaffTable? parentForm = null)
        {
            InitializeComponent();
            this.parentForm = parentForm;

            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private async void okBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(firstNameTxt.Content) ||
                string.IsNullOrWhiteSpace(lastNameTxt.Content) ||
                string.IsNullOrWhiteSpace(emailTxt.Content) ||
                string.IsNullOrWhiteSpace(addressTxt.Content) ||
                string.IsNullOrWhiteSpace(phoneNumTxt.Content) ||
                string.IsNullOrWhiteSpace(passwordTxt.Content) ||
                string.IsNullOrWhiteSpace(usernameTxt.Content))
            {
                MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (addressTxt.Content.Length < 6)
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

            if (await CheckEmailExistence.IsUserEmailExistsAsync(emailTxt.Content))
            {
                MessageBox.Show("Email already exists. Please use a different email.", "Duplicate Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                emailTxt.Focus();
                return;
            }

            try
            {
                var newUser = new User
                {
                    FirstName = firstNameTxt.Content.Trim(),
                    LastName = lastNameTxt.Content.Trim(),
                    Email = emailTxt.Content.Trim(),
                    Password = passwordTxt.Content.Trim(),
                    Username = usernameTxt.Content.Trim(),
                    PhoneNumber = phoneNumTxt.Content.Trim(),
                    Address = addressTxt.Content.Trim(),
                    DateOfBirth = birthDate.Value.Date,
                };

                dataContext.User.Add(newUser);
                dataContext.SaveChanges();

                MessageBox.Show("New staff added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                parentForm?.RefreshUserData();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding staff: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void phoneNumTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((phoneNumTxt.Content.Length >= 11 && !char.IsControl(e.KeyChar)) ||
                (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)))
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
