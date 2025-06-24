using System;
using System.Windows.Forms;

namespace TrainHub
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            LoadLabels();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            ConfirmPassword confirmPassword = new ConfirmPassword(this);
            confirmPassword.ShowDialog();
        }

        public void LoadLabels()
        {
            emailLabel.Text = CurrentUser.Email;
            phoneNumberLabel.Text = CurrentUser.PhoneNumber;
            usernameLabel.Text = CurrentUser.Username;
        }
    }
}
