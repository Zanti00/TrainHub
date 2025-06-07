using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace TrainHub
{
    public partial class UpdatePassword : Form
    {
        private string emailRecieved;
        public UpdatePassword(string email)
        {
            InitializeComponent();
            updatePasswordBtn.ButtonContent = "UPDATE PASSWORD";
            updatePasswordBtn.ButtonClicked += updatePasswordBtn_Click;
            emailRecieved = email;
            newPasswordTxt1.PasswordChar = true;
            newPasswordTxt2.PasswordChar = true;
            newPasswordTxt1.PlaceHolderText = "Enter your new password";
            newPasswordTxt2.PlaceHolderText = "Re-enter your new passoword";
            newPasswordTxt1.PasswordChar = true;
            newPasswordTxt2.PasswordChar = true;
        }

        private void showPassBtn1_Click(object sender, EventArgs e)
        {
            if (newPasswordTxt1.PasswordChar)
            {
                newPasswordTxt1.PasswordChar = false;
            }
            else
            {
                newPasswordTxt1.PasswordChar = true;
            }
        }

        private void showPassBtn2_Click(object sender, EventArgs e)
        {
            if (newPasswordTxt2.PasswordChar)
            {
                newPasswordTxt2.PasswordChar = false;
            }
            else
            {
                newPasswordTxt2.PasswordChar = true;
            }
        }

        private void updatePasswordBtn_Click(object sender, EventArgs e)
        {
            // Check if passwords match
            if (newPasswordTxt1.TextContent == newPasswordTxt2.TextContent)
            {
                // Check if passwords are not empty
                if (string.IsNullOrWhiteSpace(newPasswordTxt1.TextContent))
                {
                    MessageBox.Show("Password cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!(Regex.IsMatch(newPasswordTxt1.TextContent, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^a-zA-Z0-9]).+$") && (newPasswordTxt1.TextContent).Length >= 8))
                {
                    MessageBox.Show("Password should contain at least 1 special character, uppercase, number and a lowercase character and it should be 8 character long.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                try
                {
                    using (SqlConnection conn = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=TrainHub;Integrated Security=True"))
                    {
                        // Use parameterized query to prevent SQL injection
                        using (SqlCommand cmd = new SqlCommand("UPDATE users SET [password] = @password WHERE email = @email", conn))
                        {
                            // Add parameters
                            cmd.Parameters.AddWithValue("@password", newPasswordTxt1.TextContent);
                            cmd.Parameters.AddWithValue("@email", emailRecieved);

                            conn.Open();
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                PasswordResetSuccessful passwordResetSuccessful = new PasswordResetSuccessful();
                                this.Hide();
                                passwordResetSuccessful.Show();
                            }
                            else
                            {
                                MessageBox.Show("User not found or password update failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Passwords do not match. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                newPasswordTxt1.ResetText();
                newPasswordTxt2.ResetText();
                newPasswordTxt1.Focus();
            }
        }
    }
}