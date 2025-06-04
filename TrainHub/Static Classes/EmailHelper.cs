// File: EmailHelper.cs
using System;
using System.Net;
using System.Net.Mail;

namespace TrainHub
{
    public static class EmailHelper
    {
        public static string SendOTP(string recipientEmail, out MailMessage sentMessage)
        {
            string from = "zantialdama1@gmail.com";
            string pass = "ecql vlsa psql jbxu";
            string verificationCode = new Random().Next(100000, 999999).ToString();

            string messageBody = $"NEVER SHARE YOUR CODE to anyone.\nYour verification code is: {verificationCode}\n\n Disregard this message if you didn't request any OTP";

            MailMessage message = new MailMessage();
            message.To.Add(recipientEmail);
            message.From = new MailAddress(from);
            message.Subject = "Password Reset Verification Code for TrainHub";
            message.Body = messageBody;

            SmtpClient smtp = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                EnableSsl = true,
                Credentials = new NetworkCredential(from, pass),
                DeliveryMethod = SmtpDeliveryMethod.Network
            };

            smtp.Send(message); // Can throw exception if sending fails

            sentMessage = message; // return the MailMessage in case you need to display it
            MessageBox.Show("If this email is registered, you will receieve an OTP to " + recipientEmail, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return verificationCode;
        }
    }
}
