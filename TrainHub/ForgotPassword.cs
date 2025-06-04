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

namespace TrainHub
{
    public partial class ForgotPassword : Form
    {
        string verificationCode;
        public static string to;
        public ForgotPassword()
        {
            InitializeComponent();
        }
      
        private void sendEmailBtn_Click(object sender, EventArgs e)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@gmail\.com$";
            if (emailTxt.Content.Contains("@gmail.com") == false || (Regex.IsMatch(emailTxt.Content, pattern) == false))
            {
                MessageBox.Show("Please enter a valid email address.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (string.IsNullOrWhiteSpace(emailTxt.Content))
            {
                MessageBox.Show("Please enter your email address.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                // checks if the email address exists in the database
                SqlConnection conn = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=TrainHub;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
                String query = "SELECT * FROM users WHERE email = @Email";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Email", emailTxt.Content);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count <= 0)
                {
                    MessageBox.Show("If this email is registered, you will receieve an OTP to " + emailTxt.Content, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    VerifyCode verifyCode = new VerifyCode("000000", emailTxt.Content);
                    this.Hide();
                    verifyCode.Show();
                }
                else
                {
                    string from, pass, messageBody;
                    Random rand = new Random();
                    verificationCode = (rand.Next(100000, 999999)).ToString();
                    MailMessage message = new MailMessage();
                    to = (emailTxt.Content).ToString();
                    from = "zantialdama1@gmail.com";
                    pass = "ecql vlsa psql jbxu";
                    messageBody = "NEVER SHARE YOUR CODE to anyone especially on social media, SMS, or email links. Your verification code is: " + verificationCode + "\n\nDisregard this email if you didn't request an OTP";
                    message.To.Add(to);
                    message.From = new MailAddress(from);
                    message.Body = messageBody;
                    message.Subject = "Password Reset Verification Code for TrainHub";
                    SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                    smtp.EnableSsl = true;
                    smtp.Port = 587;
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.Credentials = new NetworkCredential(from, pass);
                    try
                    {
                        smtp.Send(message);
                        MessageBox.Show("If this email is registered, you will receieve an OTP to " + to, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        VerifyCode verifyCode = new VerifyCode(verificationCode, emailTxt.Content);
                        this.Hide();
                        verifyCode.Show();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }
    }
}
