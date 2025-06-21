using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrainHub.Data;
using TrainHub.Models;
using TrainHub.Static_Classes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace TrainHub
{
    public partial class RegisterNewMember : Form
    {
        private readonly TrainHubContext _context;
        private readonly ShowMembersTablePageForm1 _showMembersTablePageForm1;
        private VideoCaptureDevice videoSource;
        private Bitmap currentFrame;
        private Bitmap capturedImage;
        private bool isImageCaptured = false;

        string pattern = @"^[a-zA-Z0-9._%+-]+@gmail\.com$";
        public RegisterNewMember(ShowMembersTablePageForm1 showMembersTablePageForm1)
        {
            InitializeComponent();

            _showMembersTablePageForm1 = showMembersTablePageForm1;

            // Initialize the context
            _context = new TrainHubContext();
            InitializeWebcam();

            startDate.Value = DateTime.Today;
            endDate.Value = DateTime.Today;
        }

        private void InitializeWebcam()
        {
            // Get list of video devices
            FilterInfoCollection videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            if (videoDevices.Count > 0)
            {
                // Use first available camera
                videoSource = new VideoCaptureDevice(videoDevices[0].MonikerString);
                videoSource.NewFrame += VideoSource_NewFrame;
            }
            else
            {
                MessageBox.Show("No video devices found!");
            }
        }

        private void VideoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            // Get the current frame
            currentFrame = (Bitmap)eventArgs.Frame.Clone();

            // Display in PictureBox (invoke required for cross-thread operation)
            if (pictureBox1.InvokeRequired)
            {
                pictureBox1.Invoke(new Action(() =>
                {
                    pictureBox1.Image?.Dispose();
                    pictureBox1.Image = (Bitmap)currentFrame.Clone();
                }));
            }
            else
            {
                pictureBox1.Image?.Dispose();
                pictureBox1.Image = (Bitmap)currentFrame.Clone();
            }
        }
        private async void addBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(firstNameTxt.Content) ||
                string.IsNullOrWhiteSpace(phoneNumTxt.Content) ||
                string.IsNullOrWhiteSpace(emailAddTxt.Content) ||
                string.IsNullOrWhiteSpace(lastNameTxt.Content) ||
                birthDate.Value == null ||
                startDate.Value == null ||
                endDate.Value == null ||
                statusCombo.SelectedIndex == -1 ||
                membershipTypeCombo.SelectedIndex == -1 ||
                trainerCombo.SelectedIndex == -1 ||
                isImageCaptured == null ||
                capturedImage == null)
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (birthDate.Value.Date >= DateTime.Now.Date)
            {
                MessageBox.Show("Date of Birth cannot be today or in the future.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (await CheckEmailExistence.IsMemberEmailExistsAsync(emailAddTxt.Content))
            {
                MessageBox.Show("Email already exists. Please use a different email.",
                    "Duplicate Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                emailAddTxt.Focus();
                return;
            }

            AddMember();

            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void phoneNumTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (phoneNumTxt.Content.Length >= 11 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Prevent further input if length exceeds 11 characters
            }
            else if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Prevent non-numeric input
            }
        }

        private void AddMember()
        {
            try
            {
                Member member = new Member()
                {
                    FirstName = firstNameTxt.Content.Trim(),
                    LastName = lastNameTxt.Content.Trim(),
                    Email = emailAddTxt.Content.Trim(),
                    PhoneNumber = phoneNumTxt.Content.Trim(),
                    DateOfBirth = birthDate.Value.Date,
                    StartDate = startDate.Value.Date,
                    EndDate = endDate.Value.Date,
                    Status = statusCombo.SelectedItem.ToString(),
                    MembershipType = membershipTypeCombo.SelectedItem.ToString(),
                    //TrainerID = 1 // Assuming a default trainer ID for now
                };

                _context.Add(member);
                _context.SaveChanges(); // Ensure changes are saved to the database
                if (isImageCaptured && capturedImage != null)
                {
                    try
                    {
                        string imagePath = ImageFileManager.SaveMemberImage(capturedImage, member.Id, member.Email);

                        string relativePath = ImageFileManager.GetRelativePath(imagePath);

                        member.ProfileImagePath = relativePath;
                        member.ImageFileName = System.IO.Path.GetFileName(imagePath);
                        member.ImageCapturedDate = DateTime.Now;

                        _context.SaveChanges(); // Save image path
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Member registered successfully, but failed to save image: {ex.Message}",
                            "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                QrCode qrCodeGenerator = new QrCode();
                Bitmap picQRCode = QrCode.GetCode(member.Id.ToString());
                qrCodeGenerator.GenerateQrCode(member.Id, picQRCode);

                MessageBox.Show("Member registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _showMembersTablePageForm1?.RefreshMemberData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error registering member: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void captureBtn_Click(object sender, EventArgs e)
        {
            if (currentFrame != null)
            {
                // Capture the current frame
                capturedImage?.Dispose(); // Dispose previous captured image
                capturedImage = (Bitmap)currentFrame.Clone();
                isImageCaptured = true;

                // Stop the camera after capture
                if (videoSource != null && videoSource.IsRunning)
                {
                    videoSource.SignalToStop();
                    videoSource.WaitForStop();
                }

                // Optional: Show the captured image in the same PictureBox or another one
                pictureBox1.Image?.Dispose();
                pictureBox1.Image = (Bitmap)capturedImage.Clone();

                MessageBox.Show("Image captured successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No frame to capture!");
            }
        }

        private void openCameraBtn_Click(object sender, EventArgs e)
        {
            if (videoSource != null && !videoSource.IsRunning)
            {
                videoSource.Start();
                isImageCaptured = false;
            }
            else
            {
                videoSource.SignalToStop();
                videoSource.WaitForStop();
            }
        }

        private void RegisterNewMember_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource.WaitForStop();
            }

            // Clean up resources
            currentFrame?.Dispose();
            capturedImage?.Dispose();
        }
    }
}
