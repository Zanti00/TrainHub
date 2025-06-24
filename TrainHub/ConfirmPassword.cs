using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrainHub.Data;
using TrainHub.Properties;

namespace TrainHub
{
    public partial class ConfirmPassword : Form
    {
        private readonly Settings _settings; // for accessing load labels method
        public ConfirmPassword(Settings settings)
        {
            InitializeComponent();

            _settings = settings;
        }

        private async void doneBtn_Click(object sender, EventArgs e)
        {
            using (TrainHubContext dataContext = new TrainHubContext())
            {
                string password = passwordTxt.Content.Trim();
                // Validate password
                if (string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Please enter your password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var user = dataContext.User.FirstOrDefault(u => u.Email == CurrentUser.Email);

                // Then verify the password in memory (not in the database query)
                if (user == null || !PasswordHelper.VerifyPassword(password, user.Password))
                {
                    MessageBox.Show("Incorrect password. Please try again.", "Authentication Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                EditUserDetails editUserDetails = new EditUserDetails(CurrentUser.UserId, _settings);
                this.Close();

                await Task.Delay(500);

                editUserDetails.ShowDialog();
            }
        }

        private void showPassBtn_Click(object sender, EventArgs e)
        {
            if (passwordTxt.PasswordChar)
            {
                passwordTxt.PasswordChar = false;
            }
            else
            {
                passwordTxt.PasswordChar = true;
            }
        }
    }
}
