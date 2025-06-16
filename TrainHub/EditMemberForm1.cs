using AForge.Video;
using AForge.Video.DirectShow;
using Microsoft.EntityFrameworkCore;
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
using TrainHub.Models;
using TrainHub.Static_Classes;

namespace TrainHub
{
    public partial class EditMemberForm1 : Form
    {
        private TrainHubContext dataContext = new TrainHubContext();
        private int memberID;
        private ShowMembersTablePageForm1 showMembersTablePageForm1;
        private VideoCaptureDevice videoSource;
        private Bitmap currentFrame;
        private Bitmap capturedImage;
        private bool isImageCaptured = false;
        string pattern = @"^[a-zA-Z0-9._%+-]+@gmail\.com$";
        public EditMemberForm1(int memberID, ShowMembersTablePageForm1 showMembersTablePageForm1 = null)
        {
            InitializeComponent();
            InitializeWebcam();

            this.memberID = memberID;
            this.showMembersTablePageForm1 = showMembersTablePageForm1;

            LoadMemberData();

        }

        private void LoadMemberData()
        {
            try
            {
                var selectedMember = dataContext.Member.Find(memberID);

                if (selectedMember == null)
                {
                    MessageBox.Show("Member not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }
                else
                {
                    firstNameTxt.Content = selectedMember.FirstName;
                    lastNameTxt.Content = selectedMember.LastName;
                    emailAddTxt.Content = selectedMember.Email;
                    phoneNumTxt.Content = selectedMember.PhoneNumber;
                    statusCombo.SelectedItem = selectedMember.Status;
                    membershipTypeCombo.SelectedItem = selectedMember.MembershipType;
                    birthDate.Value = selectedMember.DateOfBirth;
                    startDate.Value = selectedMember.StartDate;
                    endDate.Value = selectedMember.EndDate;

                    LoadMemberImage(selectedMember.ProfileImagePath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading member data: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void LoadMemberImage(string imagePath)
        {
            try
            {
                // Check if image path exists and is not null/empty
                if (string.IsNullOrWhiteSpace(imagePath))
                {
                    return;
                }

                // Use ImageFileManager to get the full path and load the image
                string fullPath;

                // If it's already a full path, use it as is
                if (System.IO.Path.IsPathRooted(imagePath))
                {
                    fullPath = imagePath;
                }
                else
                {
                    // Convert relative path to full path using ImageFileManager
                    fullPath = ImageFileManager.GetFullPath(imagePath);
                }

                // Load the image using ImageFileManager
                Bitmap loadedImage = ImageFileManager.LoadMemberImage(fullPath);

                if (loadedImage != null)
                {
                    // Dispose previous image to free memory
                    if (pictureBox1.Image != null)
                    {
                        pictureBox1.Image.Dispose();
                    }

                    pictureBox1.Image = loadedImage;
                    isImageCaptured = true;
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine($"Image file not found: {fullPath}");
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error loading image: {ex.Message}");
                // MessageBox.Show($"Could not load member image: {ex.Message}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void doneBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate input fields
                if (string.IsNullOrWhiteSpace(firstNameTxt.Content) ||
                    string.IsNullOrWhiteSpace(lastNameTxt.Content) ||
                    string.IsNullOrWhiteSpace(emailAddTxt.Content) ||
                    string.IsNullOrWhiteSpace(phoneNumTxt.Content) ||
                    pictureBox1.Image == null)
                {
                    MessageBox.Show("Please fill in all required fields.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                if (await CheckEmailExistence.IsMemberEmailExistsAsync(emailAddTxt.Content, memberID))
                {
                    MessageBox.Show("Email already exists. Please use a different email.",
                        "Duplicate Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    emailAddTxt.Focus();
                    return;
                }

                if (videoSource.IsRunning == true)
                {
                    MessageBox.Show("Please stop the camera before saving changes.", "Camera Running",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var selectedMember = dataContext.Member.Find(memberID);

                if (selectedMember != null)
                {
                    // Update member properties with form values
                    selectedMember.FirstName = firstNameTxt.Content.Trim();
                    selectedMember.LastName = lastNameTxt.Content.Trim();
                    selectedMember.Email = emailAddTxt.Content.Trim();
                    selectedMember.PhoneNumber = phoneNumTxt.Content.Trim();

                    // Handle ComboBox selections safely
                    selectedMember.Status = statusCombo.SelectedItem?.ToString() ?? selectedMember.Status;
                    selectedMember.MembershipType = membershipTypeCombo.SelectedItem?.ToString() ?? selectedMember.MembershipType;

                    // Update date values
                    selectedMember.DateOfBirth = birthDate.Value.Date;
                    selectedMember.StartDate = startDate.Value.Date;
                    selectedMember.EndDate = endDate.Value.Date;

                    if (isImageCaptured && capturedImage != null)
                    {
                        try
                        {
                            string imagePath = ImageFileManager.SaveMemberImage(capturedImage, selectedMember.Id, selectedMember.Email);

                            string relativePath = ImageFileManager.GetRelativePath(imagePath);

                            selectedMember.ProfileImagePath = relativePath;
                            selectedMember.ImageFileName = System.IO.Path.GetFileName(imagePath);
                            selectedMember.ImageCapturedDate = DateTime.Now;

                            dataContext.SaveChanges(); // Save image path
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Member registered successfully, but failed to save image: {ex.Message}",
                                "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }

                    MessageBox.Show("Member updated successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Refresh the parent form's data grid
                    showMembersTablePageForm1?.RefreshMemberData();

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Member not found.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating member: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void generateQrBtn_Click(object sender, EventArgs e)
        {
            QrCode qrCodeGenerator = new QrCode(); // Create an instance of QrCode
            Bitmap picQRCode = QrCode.GetCode(memberID.ToString());
            qrCodeGenerator.GenerateQrCode(memberID, picQRCode); // Use the instance to call the non-static method
        }

        private void EditMemberForm1_FormClosing(object sender, FormClosingEventArgs e)
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