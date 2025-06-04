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

namespace TrainHub
{
    public partial class UpdatePassword : Form
    {
        string email = ForgotPassword.to;

        public UpdatePassword()
        {
            InitializeComponent();
        }

        private void updatePasswordBtn_Click(object sender, EventArgs e)
        {
            // Check if passwords match
            if (newPasswordTxt1.Content == newPasswordTxt2.Content)
            {
                // Check if passwords are not empty
                if (string.IsNullOrWhiteSpace(newPasswordTxt1.Content))
                {
                    MessageBox.Show("Password cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                            cmd.Parameters.AddWithValue("@password", newPasswordTxt1.Content);
                            cmd.Parameters.AddWithValue("@email", email);

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
    }
}