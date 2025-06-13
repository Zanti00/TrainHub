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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace TrainHub
{
    public partial class RegisterNewMember : Form
    {
        private readonly TrainHubContext _context;
        private readonly ShowMembersTablePageForm1 _showMembersTablePageForm1;
        string pattern = @"^[a-zA-Z0-9._%+-]+@gmail\.com$";
        public RegisterNewMember(ShowMembersTablePageForm1 showMembersTablePageForm1)
        {
            InitializeComponent();

            _showMembersTablePageForm1 = showMembersTablePageForm1;

            // Initialize the context
            _context = new TrainHubContext();

            // Prevent resizing, but allow moving
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ControlBox = true;
            this.StartPosition = FormStartPosition.CenterScreen;

            startDate.Value = DateTime.Today;
            endDate.Value = DateTime.Today;
        }

        private async void addBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(firstNameTxt.Content) ||
                string.IsNullOrWhiteSpace(phoneNumTxt.Content) ||
                string.IsNullOrWhiteSpace(emailAddTxt.Content) ||
                string.IsNullOrWhiteSpace(lastNameTxt.Content) ||
                birthDate.Value == null ||
                startDate.Value == null ||
                endDate.Value == null ||
                statusCombo.SelectedIndex == -1 ||
                membershipTypeCombo.SelectedIndex == -1 ||
                trainerCombo.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (await CheckEmailExistence.IsMemberEmailExistsAsync(emailAddTxt.Content))
            {
                MessageBox.Show("Email already exists. Please use a different email.",
                    "Duplicate Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                emailAddTxt.Focus();
                return;
            }

            AddMember();

            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void AddMember()
        {
            Member member = new Member()
            {
                FirstName = firstNameTxt.Content,
                LastName = lastNameTxt.Content,
                Email = emailAddTxt.Content,
                PhoneNumber = phoneNumTxt.Content,
                DateOfBirth = birthDate.Value.Date,
                StartDate = startDate.Value.Date,
                EndDate = endDate.Value.Date,
                Status = statusCombo.SelectedItem.ToString(),
                MembershipType = membershipTypeCombo.SelectedItem.ToString(),
                //TrainerID = 1 // Assuming a default trainer ID for now
            };
            _context.Add(member);
            _context.SaveChanges(); // Ensure changes are saved to the database

            MessageBox.Show("Member registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            _showMembersTablePageForm1?.RefreshMemberData();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            _context?.Dispose();
            base.OnFormClosed(e);
        }
    }
}
