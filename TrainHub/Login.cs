using System.Data;
using Microsoft.Data.SqlClient;
using TrainHub.Data;

namespace TrainHub
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(emailTxt.Content) || string.IsNullOrWhiteSpace(passwordTxt.Content))
            {
                MessageBox.Show("Please enter your email and password.", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using(TrainHubContext dataContext = new TrainHubContext())
            {
                var user = dataContext.User.FirstOrDefault(u => u.Email == emailTxt.Content && u.Password == passwordTxt.Content);
                if (user != null)
                {
                    // Load current user info
                    CurrentUser.UserId = user.Id;
                    CurrentUser.Username = user.Username;
                    CurrentUser.FirstName = user.FirstName;
                    CurrentUser.LastName = user.LastName;
                    CurrentUser.Email = user.Email;

                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid email or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    emailTxt.ResetText();
                    passwordTxt.ResetText();
                    emailTxt.Focus();
                }
            }
        }

        private void forgotPasswordLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPassword forgotPassword = new ForgotPassword();
            this.Hide();
            forgotPassword.Show();
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
