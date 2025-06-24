using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using TrainHub.Data;

namespace TrainHub
{
    public partial class EditUserDetails : Form
    {
        private int userID;
        private TrainHubContext _dataContext = new TrainHubContext();
        private readonly Settings _settings; // for accessing load labels method
        string pattern = @"^[a-zA-Z0-9._%+-]+@gmail\.com$";
        public EditUserDetails(int userID, Settings settings)
        {
            this.userID = userID;
            _settings = settings;

            InitializeComponent();
            LoadUserDetails();
        }

        private void LoadUserDetails()
        {
            var user = _dataContext.User.FirstOrDefault(u => u.Id == userID);
            if (user != null)
            {
                usernameTxt.Content = user.Username;
                phoneNumTxt.Content = user.PhoneNumber;
                emailAddTxt.Content = user.Email;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var user = _dataContext.User.FirstOrDefault(u => u.Id == userID);
            if (user == null)
            {
                MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(usernameTxt.Content) ||
                string.IsNullOrWhiteSpace(emailAddTxt.Content) ||
                string.IsNullOrWhiteSpace(phoneNumTxt.Content))
            {
                MessageBox.Show("Fill all the required input fields to continue.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            user.Username = usernameTxt.Content.Trim();
            user.Email = emailAddTxt.Content.Trim();
            user.PhoneNumber = phoneNumTxt.Content.Trim();

            if (!string.IsNullOrWhiteSpace(newPasswordTxt.Content))
            {
                if (newPasswordTxt.Content != confirmPasswordTxt.Content)
                {
                    MessageBox.Show("New password and confirm password do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!(Regex.IsMatch(newPasswordTxt.Content, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^a-zA-Z0-9]).+$") && (newPasswordTxt.Content).Length >= 8))
                {
                    MessageBox.Show("Password must be at least 8 characters long and contain at least one uppercase letter, one lowercase letter, one number, and one special character.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                user.Password = newPasswordTxt.Content;
            }
            UpdateCurrentUserInfo();
            _dataContext.SaveChanges();
            MessageBox.Show("User details updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _settings?.LoadLabels();
            this.Close();
        }

        private void UpdateCurrentUserInfo()
        {
            CurrentUser.Username = usernameTxt.Content.Trim();
            CurrentUser.Email = emailAddTxt.Content.Trim();
            CurrentUser.PhoneNumber = phoneNumTxt.Content.Trim();
            if (!(string.IsNullOrWhiteSpace(newPasswordTxt.Content) && string.IsNullOrWhiteSpace(confirmPasswordTxt.Content)))
                CurrentUser.Password = newPasswordTxt.Content ?? confirmPasswordTxt.Content;

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(usernameTxt.Content) ||
                !string.IsNullOrWhiteSpace(emailAddTxt.Content) ||
                !string.IsNullOrWhiteSpace(phoneNumTxt.Content) ||
                !string.IsNullOrWhiteSpace(newPasswordTxt.Content) ||
                !string.IsNullOrWhiteSpace(confirmPasswordTxt.Content))
                this.Close();
        }

        private void showPassBtn1_Click(object sender, EventArgs e)
        {
            if (newPasswordTxt.PasswordChar)
            {
                newPasswordTxt.PasswordChar = false;
            }
            else
            {
                newPasswordTxt.PasswordChar = true;
            }
        }

        private void showPassBtn2_Click(object sender, EventArgs e)
        {
            if (confirmPasswordTxt.PasswordChar)
            {
                confirmPasswordTxt.PasswordChar = false;
            }
            else
            {
                confirmPasswordTxt.PasswordChar = true;
            }
        }
    }
}

    