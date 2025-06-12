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
    public partial class EditMemberForm1 : Form
    {
        private TrainHubContext dataContext = new TrainHubContext();
        private int memberID;
        private ShowMembersTablePageForm1 showMembersTablePageForm1;
        string pattern = @"^[a-zA-Z0-9._%+-]+@gmail\.com$";
        public EditMemberForm1(int memberID, ShowMembersTablePageForm1 showMembersTablePageForm1 = null)
        {
            InitializeComponent();

            // to prevent resizing
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ControlBox = true;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.memberID = memberID;
            this.showMembersTablePageForm1 = showMembersTablePageForm1;

            LoadMemberData();
            
        }

        private void LoadMemberData()
        {
            try
            {
                var selectedMember = dataContext.Member.Find(memberID);
                
                if (selectedMember == null)
                {
                    MessageBox.Show("Member not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }
                else
                {
                    firstNameTxt.Content = selectedMember.FirstName;
                    lastNameTxt.Content = selectedMember.LastName;
                    emailAddTxt.Content = selectedMember.Email;
                    phoneNumTxt.Content = selectedMember.PhoneNumber;
                    statusCombo.SelectedItem = selectedMember.Status;
                    membershipTypeCombo.SelectedItem = selectedMember.MembershipType;
                    birthDate.Value = selectedMember.DateOfBirth;
                    startDate.Value = selectedMember.StartDate;
                    endDate.Value = selectedMember.EndDate;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading member data: {ex.Message}", "Error",
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

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void doneBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate input fields
                if (string.IsNullOrWhiteSpace(firstNameTxt.Content) ||
                    string.IsNullOrWhiteSpace(lastNameTxt.Content) ||
                    string.IsNullOrWhiteSpace(emailAddTxt.Content) ||
                    string.IsNullOrWhiteSpace(phoneNumTxt.Content))
                {
                    MessageBox.Show("Please fill in all required fields.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (phoneNumTxt.Content.Length != 11)
                {
                    MessageBox.Show("Mobile number should be exactly 11 characters length.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (emailAddTxt.Content.Contains("@gmail.com") == false || (Regex.IsMatch(emailAddTxt.Content, pattern) == false))
                {
                    MessageBox.Show("Please enter a valid email address.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (birthDate.Value.Date >= DateTime.Now.Date)
                {
                    MessageBox.Show("Date of Birth cannot be today or in the future.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (await CheckEmailExistence.IsMemberEmailExistsAsync(emailAddTxt.Content, memberID))
                {
                    MessageBox.Show("Email already exists. Please use a different email.",
                        "Duplicate Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    emailAddTxt.Focus();
                    return;
                }

                var selectedMember = dataContext.Member.Find(memberID);

                if (selectedMember != null)
                {
                    // Update member properties with form values
                    selectedMember.FirstName = firstNameTxt.Content.Trim();
                    selectedMember.LastName = lastNameTxt.Content.Trim();
                    selectedMember.Email = emailAddTxt.Content.Trim();
                    selectedMember.PhoneNumber = phoneNumTxt.Content.Trim();

                    // Handle ComboBox selections safely
                    selectedMember.Status = statusCombo.SelectedItem?.ToString() ?? selectedMember.Status;
                    selectedMember.MembershipType = membershipTypeCombo.SelectedItem?.ToString() ?? selectedMember.MembershipType;

                    // Update date values
                    selectedMember.DateOfBirth = birthDate.Value.Date;
                    selectedMember.StartDate = startDate.Value.Date;
                    selectedMember.EndDate = endDate.Value.Date;

                    // IMPORTANT: Save changes to database
                    dataContext.SaveChanges();

                    MessageBox.Show("Member updated successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Refresh the parent form's data grid
                    showMembersTablePageForm1?.RefreshMemberData();

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Member not found.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating member: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Clean up resources
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            dataContext?.Dispose();
            base.OnFormClosed(e);
        }
    }
}