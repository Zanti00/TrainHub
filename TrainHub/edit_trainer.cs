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
using TrainHub.Static_Classes;

namespace TrainHub
{
    public partial class edit_trainer : Form
    {
        private TrainHubContext dataContext = new TrainHubContext();
        private int trainerID;
        private table_trainer showTrainerTable;
        string pattern = @"^[a-zA-Z0-9._%+-]+@gmail\.com$";
        public edit_trainer(int trainerID, table_trainer showTrainerTable = null)
        {

            {
                InitializeComponent();

                this.FormBorderStyle = FormBorderStyle.FixedDialog;
                this.MaximizeBox = false;
                this.MinimizeBox = false;
                this.ControlBox = true;
                this.StartPosition = FormStartPosition.CenterScreen;
                this.trainerID = trainerID;
                this.showTrainerTable = showTrainerTable;

                LoadTrainerData();

            }
        }

        private void LoadTrainerData()
        {
            try
            {
                var selectedTrainer = dataContext.Trainer.Find(trainerID);

                if (selectedTrainer == null)
                {
                    MessageBox.Show("Trainer not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }
                else
                {
                    firstNameTxt.Content = selectedTrainer.FirstName;
                    lastNameTxt.Content = selectedTrainer.LastName;
                    emailTxt.Content = selectedTrainer.Email;
                    mobNumTxt.Content = selectedTrainer.MobileNumber;
                    addressTxt.Content = selectedTrainer.Address;
                    birthDate.Value = (DateTime)selectedTrainer.DateOfBirth;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading trainer data: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void mobNumTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (mobNumTxt.Content.Length >= 11 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Prevent further input if length exceeds 11 characters
            }
            else if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Prevent non-numeric input
            }
        }


        


        private void cancelButton_Click(object sender, EventArgs e)
        {
            // Close this form and return to the previous form
            this.Close();
        }

        private async void doneButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate input fields
                if (string.IsNullOrWhiteSpace(firstNameTxt.Content) ||
                    string.IsNullOrWhiteSpace(lastNameTxt.Content) ||
                    string.IsNullOrWhiteSpace(emailTxt.Content) ||
                    string.IsNullOrWhiteSpace(mobNumTxt.Content))
                {
                    MessageBox.Show("Please fill in all required fields.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (mobNumTxt.Content.Length != 11)
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
                if (await CheckEmailExistence.IsMemberEmailExistsAsync(emailTxt.Content, trainerID))
                {
                    MessageBox.Show("Email already exists. Please use a different email.",
                        "Duplicate Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    emailTxt.Focus();
                    return;
                }

                var selectedMember = dataContext.Trainer.Find(trainerID);

                if (selectedMember != null)
                {
                    // Update member properties with form values
                    selectedMember.FirstName = firstNameTxt.Content.Trim();
                    selectedMember.LastName = lastNameTxt.Content.Trim();
                    selectedMember.Email = emailTxt.Content.Trim();
                    selectedMember.MobileNumber = mobNumTxt.Content.Trim();

                  
                    // Update date values
                    selectedMember.DateOfBirth = birthDate.Value.Date;
                   
                    // IMPORTANT: Save changes to database
                    dataContext.SaveChanges();

                    MessageBox.Show("Member updated successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Refresh the parent form's data grid
                    showTrainerTable?.RefreshTrainerData();

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
