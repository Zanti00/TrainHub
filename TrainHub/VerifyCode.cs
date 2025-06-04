using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainHub
{
    public partial class VerifyCode : Form
    {
        private string verificationCodeReceived;
        private string emailTxtRecieved;

        public VerifyCode(string verificationCode, string emailTxt)
        {
            InitializeComponent();
            verificationBtn.ButtonContent = "CONTINUE";
            verificationBtn.ButtonClicked += verificationBtn_Click;
            verificationCodeReceived = verificationCode;
            emailTxtRecieved = emailTxt;
            backBtn.BackButtonClicked += backBtn_Click;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            ForgotPassword forgotPassword = new ForgotPassword();
            this.Hide();
            forgotPassword.Show();
        }

        private void verificationBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(verificationCodeTxtBox.Content))
            {
                MessageBox.Show("Please enter the verification code.");
                return;
            }
            else if ((verificationCodeTxtBox.Content).ToString() == verificationCodeReceived)
            {
                UpdatePassword updatePassword = new UpdatePassword(emailTxtRecieved);
                this.Hide();
                updatePassword.Show();
            }
            else
            {
                MessageBox.Show("Invalid Code!");
            }
        }

        private void resendLink_Click(object sender, EventArgs e)
        {
            verificationCodeReceived = EmailHelper.SendOTP(emailTxtRecieved, out MailMessage sentMsg);
        }
    }
}
