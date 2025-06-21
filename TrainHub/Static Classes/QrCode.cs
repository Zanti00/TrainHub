using QRCoder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using TrainHub.Data;
using TrainHub.Models;
using TrainHub.Properties;

namespace TrainHub
{
    public class QrCode
    {
        private TrainHubContext dataContext = new TrainHubContext();
        public static Bitmap GetCode(string targetID)
        {
            using QRCodeGenerator qrGenerator = new QRCodeGenerator();
            using QRCodeData qrData = qrGenerator.CreateQrCode(targetID, QRCodeGenerator.ECCLevel.Q);
            using QRCode qrCode = new QRCode(qrData);

            return qrCode.GetGraphic(
                20, 
                Color.Black, 
                Color.White,
                true
                );
        }

        public void GenerateQrCode(int targetID, Bitmap picQRCode)
        {
            try
            {
                if (picQRCode != null)
                {
                    SendQRCode(picQRCode, targetID);
                }
                else
                {
                    MessageBox.Show("Failed to generate QR code.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating QR code: " +
                    $"{ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void SendQRCode(Bitmap picQRCode, int targetID)
        {
            var selectedMember = dataContext.Member.Find(targetID);

            string from = "zantialdama1@gmail.com";
            string pass = "ecql vlsa psql jbxu";

            string messageBody = "Here's your new QR Code pass attached to this email.";

            MailMessage message = new MailMessage();
            message.To.Add(selectedMember.Email);
            message.From = new MailAddress(from);
            message.Subject = "New QR Code for TrainHub Membership";
            message.Body = messageBody;

            using (MemoryStream ms = new MemoryStream())
            {
                picQRCode.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                ms.Position = 0;

                Attachment attachment = new Attachment(ms, "QRCode.png", "image/png");
                message.Attachments.Add(attachment);

                SmtpClient smtp = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    EnableSsl = true,
                    Credentials = new NetworkCredential(from, pass),
                    DeliveryMethod = SmtpDeliveryMethod.Network
                };

                try
                {
                    smtp.Send(message);
                    MessageBox.Show("QR Code sent to " + selectedMember.Email, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error sending email: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    smtp.Dispose();
                    message.Dispose();
                }
            }
        }
    }
}
