using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrainHub.Data;

namespace TrainHub
{
    public partial class ForgotPassword : Form
    {
        public static string to;
        public ForgotPassword()
        {
            InitializeComponent();
            sendEmailBtn.ButtonContent = "SEND EMAIL";
            sendEmailBtn.ButtonClicked += sendEmailBtn_Click;
            emailTxt.PlaceHolderText = "Enter your email";
            emailTxt.TextContent = emailTxt.TextContent;
            backBtn.BackButtonClicked += backBtn_Click;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void sendEmailBtn_Click(object sender, EventArgs e)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@gmail\.com$";
            if (emailTxt.TextContent.Contains("@gmail.com") == false || (Regex.IsMatch(emailTxt.TextContent, pattern) == false))
            {
                MessageBox.Show("Please enter a valid email address.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (string.IsNullOrWhiteSpace(emailTxt.TextContent))
            {
                MessageBox.Show("Please enter your email address.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                using (TrainHubContext dataContext = new TrainHubContext())
                {
                    var user = dataContext.User.FirstOrDefault(u => u.Email == emailTxt.TextContent);

                    if (user != null)
                    {
                        try
                        {
                            string verificationCode = EmailHelper.SendOTP(emailTxt.TextContent, out MailMessage sentMsg);

                            VerifyCode verifyCode = new VerifyCode(verificationCode, emailTxt.TextContent);
                            this.Hide();
                            verifyCode.Show();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        string verificationCode = "000000";
                        VerifyCode verifyCode = new VerifyCode(verificationCode, emailTxt.TextContent);
                        this.Hide();
                        verifyCode.Show();
                    }
                }
            }
        }
    }
}
