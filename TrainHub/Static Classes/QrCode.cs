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
    public enum EntityType
    {
        Member,
        Trainer,
        Staff
    }

    public class QrCode
    {
        private TrainHubContext dataContext = new TrainHubContext();

        public static Bitmap GetCode(string qrContent)
        {
            using QRCodeGenerator qrGenerator = new QRCodeGenerator();
            using QRCodeData qrData = qrGenerator.CreateQrCode(qrContent, QRCodeGenerator.ECCLevel.Q);
            using QRCode qrCode = new QRCode(qrData);

            return qrCode.GetGraphic(
                20,
                Color.Black,
                Color.White,
                true
                );
        }

        public void GenerateQrCode(int targetID, Bitmap picQRCode, EntityType entityType)
        {
            try
            {
                if (picQRCode != null)
                {
                    SendQRCode(picQRCode, targetID, entityType);
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

        private void SendQRCode(Bitmap picQRCode, int targetID, EntityType entityType)
        {
            string recipientEmail = "";
            string recipientName = "";
            string subjectPrefix = "";

            try
            {

                switch (entityType)
                {
                    case EntityType.Member:
                        var selectedMember = dataContext.Member.Find(targetID);
                        if (selectedMember == null)
                        {
                            MessageBox.Show("Member not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        recipientEmail = selectedMember.Email;
                        recipientName = $"{selectedMember.FirstName} {selectedMember.LastName}";
                        subjectPrefix = "TrainHub Membership";
                        break;

                    case EntityType.Trainer:
                        var selectedTrainer = dataContext.Trainer.Find(targetID);
                        if (selectedTrainer == null)
                        {
                            MessageBox.Show("Trainer not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        recipientEmail = selectedTrainer.Email;
                        recipientName = $"{selectedTrainer.FirstName} {selectedTrainer.LastName}";
                        subjectPrefix = "TrainHub Trainer Access";
                        break;

                    case EntityType.Staff:
                        var selectedStaff = dataContext.User.Find(targetID);
                        if (selectedStaff == null)
                        {
                            MessageBox.Show("Staff not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        recipientEmail = selectedStaff.Email;
                        recipientName = $"{selectedStaff.FirstName} {selectedStaff.LastName}";
                        subjectPrefix = "TrainHub Staff Access";
                        break;

                    default:
                        MessageBox.Show("Invalid entity type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                }

                string from = "zantialdama1@gmail.com";
                string pass = "ecql vlsa psql jbxu";

                string messageBody = $"Dear {recipientName},\n\n" +
                                   "Here's your new QR Code pass attached to this email.\n\n" +
                                   "Please keep this QR code safe as it will be used for accessing TrainHub facilities.\n\n" +
                                   "Best regards,\n" +
                                   "TrainHub Team";

                MailMessage message = new MailMessage();
                message.To.Add(recipientEmail);
                message.From = new MailAddress(from);
                message.Subject = $"New QR Code for {subjectPrefix}";
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
                        MessageBox.Show($"QR Code sent to {recipientEmail}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving entity data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void GenerateQrCodeForMember(int memberID, Bitmap picQRCode)
        {
            GenerateQrCode(memberID, picQRCode, EntityType.Member);
        }

        public void GenerateQrCodeForTrainer(int trainerID, Bitmap picQRCode)
        {
            GenerateQrCode(trainerID, picQRCode, EntityType.Trainer);
        }

        public void GenerateQrCodeForStaff(int staffID, Bitmap picQRCode)
        {
            GenerateQrCode(staffID, picQRCode, EntityType.Staff);
        }

        public static void GenerateMemberQrCode(int memberID, Bitmap picQRCode)
        {
            var qrCodeGenerator = new QrCode();
            qrCodeGenerator.GenerateQrCodeForMember(memberID, picQRCode);
        }

        public static void GenerateTrainerQrCode(int trainerID, Bitmap picQRCode)
        {
            var qrCodeGenerator = new QrCode();
            qrCodeGenerator.GenerateQrCodeForTrainer(trainerID, picQRCode);
        }

        public static void GenerateStaffQrCode(int staffID, Bitmap picQRCode)
        {
            var qrCodeGenerator = new QrCode();
            qrCodeGenerator.GenerateQrCodeForStaff(staffID, picQRCode);
        }

        public void Dispose()
        {
            dataContext?.Dispose();
        }
    }
}