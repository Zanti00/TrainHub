using System;
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
        private readonly int userID;
        private readonly StaffTable? staffTableRef;
        private readonly string pattern = @"^[a-zA-Z0-9._%+-]+@gmail\.com$";

        public edit_staff(int userID, StaffTable? staffTable = null)
        {
            InitializeComponent();
            this.userID = userID;
            this.staffTableRef = staffTable;

            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;

            LoadUserData();
        }

        public edit_staff()
        {
        }

        private void LoadUserData()
        {
            try
            {

                var user = dataContext.User.Find(userID);
                if (user == null)
                {
                    MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }

                firstNameTxt.Content = user.FirstName;
                lastNameTxt.Content = user.LastName;
                emailTxt.Content = user.Email;
                phoneNumTxt.Content = user.PhoneNumber;
                addressTxt.Content = user.Address;

                if (DateTime.TryParse(user.DateOfBirth, out DateTime dob))
                {
                    birthDate.Value = dob;
                }
                else
                {
                    MessageBox.Show("Invalid Date of Birth format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private async void okBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(firstNameTxt.Content) ||
                    string.IsNullOrWhiteSpace(lastNameTxt.Content) ||
                    string.IsNullOrWhiteSpace(emailTxt.Content) ||
                    string.IsNullOrWhiteSpace(phoneNumTxt.Content) ||
                    string.IsNullOrWhiteSpace(addressTxt.Content))
                {
                    MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (phoneNumTxt.Content.Length != 11)
                {
                    MessageBox.Show("Mobile number should be exactly 11 digits.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!Regex.IsMatch(emailTxt.Content, pattern))
                {
                    MessageBox.Show("Please enter a valid Gmail address.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (birthDate.Value.Date >= DateTime.Now.Date)
                {
                    MessageBox.Show("Date of Birth must be a past date.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (await CheckEmailExistence.IsUserEmailExistsAsync(emailTxt.Content, userID))
                {
                    MessageBox.Show("Email already exists. Please use another.", "Duplicate Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var user = dataContext.User.Find(userID);
                if (user == null)
                {
                    MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                user.FirstName = firstNameTxt.Content.Trim();
                user.LastName = lastNameTxt.Content.Trim();
                user.Email = emailTxt.Content.Trim();
                user.PhoneNumber = phoneNumTxt.Content.Trim();
                user.Address = addressTxt.Content.Trim();
                user.DateOfBirth = birthDate.Value.ToString("MM-dd-yyyy");

                dataContext.SaveChanges();

                MessageBox.Show("Staff updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //staffTableRef?.RefreshUserData();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Update failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void cancelBtn_Click(object sender, EventArgs e)
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
