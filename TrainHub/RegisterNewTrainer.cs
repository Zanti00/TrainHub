using Microsoft.EntityFrameworkCore;
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
    public partial class RegisterNewTrainer : Form
    {
        private readonly TrainHubContext _context;
        private readonly table_trainer _showTrainerTable;
        string pattern = @"^[a-zA-Z0-9._%+-]+@gmail\.com$";
        public RegisterNewTrainer(table_trainer showTrainerTable)
        {
            InitializeComponent();

            _showTrainerTable = showTrainerTable;


            // Initialize the context
            _context = new TrainHubContext();

        }

        private async void addButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(firstNameTxt.Content) ||
                string.IsNullOrWhiteSpace(mobNumTxt.Content) ||
                string.IsNullOrWhiteSpace(emailTxt.Content) ||
                string.IsNullOrWhiteSpace(lastNameTxt.Content) ||
                string.IsNullOrWhiteSpace(addressTxt.Content) ||
                string.IsNullOrWhiteSpace(yearsOfExperienceTxt.Content) ||
                birthDate.Value == null)

            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (await CheckEmailExistence.IsTrainerEmailExistsAsync(emailTxt.Content))
            {
                MessageBox.Show("Email already exists. Please use a different email.",
                    "Duplicate Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                emailTxt.Focus();
                return;
            }

            AddTrainer();

            this.Close();

        }
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
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
        private void AddTrainer()
        {

            Trainer trainer = new Trainer()
            {
                FirstName = firstNameTxt.Content,
                LastName = lastNameTxt.Content,
                Email = emailTxt.Content,
                Address = addressTxt.Content,
                MobileNumber = mobNumTxt.Content,
                DateOfBirth = birthDate.Value.Date,
                YearsOfExperience = yearsOfExperienceTxt.Content,
            };
            _context.Add(trainer);
            _context.SaveChanges(); // Ensure changes are saved to the database

            MessageBox.Show("Trainer registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            _showTrainerTable?.RefreshTrainerData();
        }



        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            _context?.Dispose();
            base.OnFormClosed(e);
        }

        private void mobNumTxt_KeyPress_1(object sender, KeyPressEventArgs e)
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
    }
}