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
using TrainHub.Data;
using TrainHub.Models;
using TrainHub.Static_Classes;

namespace TrainHub
{
    public partial class edit_staff : Form
    {
        private TrainHubContext dataContext = new TrainHubContext();
        private int userID;
        private ShowUsersTablePageForm1? ShowUsersTablePageForm1;
        private ShowUsersTablePageForm1? showUserTablePageForm1;
        string pattern = @"^[a-zA-Z0-9._%+-]+@gmail\.com$";
        private object? selectedUser;

        public edit_staff(int userID, ShowUsersTablePageForm1? showUserTablePageForm1 = null)
        {
            InitializeComponent();

            // to prevent resizing
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ControlBox = true;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.userID = userID;
            this.ShowUsersTablePageForm1 = showUserTablePageForm1;

            LoadUserData();
        }

        public edit_staff()
        {
        }
        private void LoadUserData()
        {
            try
            {
                var selectedUser = dataContext.User.Find(userID);

                if (selectedUser == null)
                {
                    MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }
                else
                {
                    firstNameTxt.Content = selectedUser.FirstName;
                    lastNameTxt.Content = selectedUser.LastName;
                    emailTxt.Content = selectedUser.Email;
                    phoneNumTxt.Content = selectedUser.PhoneNumber;
                    addressTxt.Content = selectedUser.Address;

                    // Convert the string DateOfBirth to DateTime before assigning it to birthDate.Value
                    if (DateTime.TryParse(selectedUser.DateOfBirth, out DateTime parsedDate))
                    {
                        birthDate.Value = parsedDate;
                    }
                    else
                    {
                        MessageBox.Show("Invalid date format for Date of Birth.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading user data: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void phoneNumTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (phoneNumTxt.Content.Length >= 11 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Prevent further input if length exceeds 11 characters
            }
            else if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Prevent non-numeric input
            }
        }
        private void cuiButtonGroup1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void editBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate input fields
                if (string.IsNullOrWhiteSpace(firstNameTxt.Content) ||
                    string.IsNullOrWhiteSpace(lastNameTxt.Content) ||
                    string.IsNullOrWhiteSpace(emailTxt.Content) ||
                    string.IsNullOrWhiteSpace(addressTxt.Content) ||
                    string.IsNullOrWhiteSpace(phoneNumTxt.Content))
                {
                    MessageBox.Show("Please fill in all required fields.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (addressTxt.Text.Length < 5)
                {
                    MessageBox.Show("Address is too short. Please enter a complete address.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (phoneNumTxt.Content.Length != 11)
                {
                    MessageBox.Show("Mobile number should be exactly 11 characters length.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (emailTxt.Content.Contains("@gmail.com") == false || (Regex.IsMatch(emailTxt.Content, pattern) == false))
                {
                    MessageBox.Show("Please enter a valid email address.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (birthDate.Value.Date >= DateTime.Now.Date)
                {
                    MessageBox.Show("Date of Birth cannot be today or in the future.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (await CheckEmailExistence.IsUserEmailExistsAsync(emailTxt.Content, userID))
                {
                    MessageBox.Show("Email already exists. Please use a different email.",
                        "Duplicate Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    emailTxt.Focus();
                    return;
                }

                // Cast selectedUser to the appropriate type
                var selectedUser = dataContext.User.Find(userID) as User;

                if (selectedUser != null)
                {
                    // Update user properties with form values
                    selectedUser.FirstName = firstNameTxt.Content.Trim();
                    selectedUser.LastName = lastNameTxt.Content.Trim();
                    selectedUser.Email = emailTxt.Content.Trim();
                    selectedUser.Address = addressTxt.Content.Trim();
                    selectedUser.PhoneNumber = phoneNumTxt.Content.Trim();
                    selectedUser.DateOfBirth = birthDate.Value.Date.ToString("MM-dd-yyyy");

                    // IMPORTANT: Save changes to database
                    dataContext.SaveChanges();

                    MessageBox.Show("User updated successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Refresh the parent form's data grid
                    ShowUsersTablePageForm1?.RefreshUserData();

                    this.Close();
                }
                else
                {
                    MessageBox.Show("User not found.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating user: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Clean up resources
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            dataContext?.Dispose();
            base.OnFormClosed(e);
        }

        private void birthDate_Load(object sender, EventArgs e)
        {

        }
    }
}

public class ShowUsersTablePageForm1
{
    internal void RefreshUserData()
    {
    }
}