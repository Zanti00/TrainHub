using AForge.Video;
using AForge.Video.DirectShow;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrainHub.Data;
using TrainHub.Models;
using TrainHub.Static_Classes;

namespace TrainHub
{
    public partial class StaffForm : Form
    {
        private FormMode _mode;
        private User _currentStaff;
        private int staffID;
        private VideoCaptureDevice videoSource;
        private Bitmap currentFrame;
        private Bitmap capturedImage;
        private bool isImageCaptured = false;
        private readonly TrainHubContext _dataContext;
        string pattern = @"^[a-zA-Z0-9._%+-]+@gmail\.com$";
        private readonly StaffTable _parentForm;
        public StaffForm(StaffTable parentForm, FormMode mode, User? user = null, int? staffID = null)
        {
            InitializeComponent();
            InitializeWebcam();
            _mode = mode;
            _parentForm = parentForm;
            this.staffID = staffID ?? 0;
            _dataContext = new TrainHubContext();

            ConfigureFormForMode();

            if (!(mode == FormMode.Edit))
            {
                generateQrBtn.Enabled = false;
            }
            if (!(_mode == FormMode.Add))
            {
                LoadStaffData();
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

        private void ConfigureFormForMode()
        {
            switch (_mode)
            {
                case FormMode.Add:
                    formLabel.Text = "Add New Staff";
                    EnableFields(true);
                    break;
                case FormMode.Edit:
                    formLabel.Text = "Edit Staff Details";
                    EnableFields(true);
                    break;
                case FormMode.View:
                    formLabel.Text = "View Staff Details";
                    EnableFields(false);
                    break;
            }
        }

        private void EnableFields(bool enabled)
        {
            firstNameTxt.Enabled = enabled;
            lastNameTxt.Enabled = enabled;
            emailAddTxt.Enabled = enabled;
            addressTxt.Enabled = enabled;
            phoneNumTxt.Enabled = enabled;
            statusCombo.Enabled = enabled;
            genderCombo.Enabled = enabled;
            usernameTxt.Enabled = enabled;
            passwordTxt.Enabled = enabled;
            birthDate.Enabled = enabled;
            captureBtn.Enabled = enabled;
            openCameraBtn.Enabled = enabled;
        }

        private void LoadStaffData()
        {
            try
            {
                var selectedStaff = _dataContext.User
                    .FirstOrDefault(m => m.Id == staffID);

                if (selectedStaff == null)
                {
                    MessageBox.Show("Staff not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }

                // Update the _currentMember reference
                _currentStaff = selectedStaff;

                firstNameTxt.Content = selectedStaff.FirstName;
                lastNameTxt.Content = selectedStaff.LastName;
                emailAddTxt.Content = selectedStaff.Email;
                addressTxt.Content = selectedStaff.Address;
                phoneNumTxt.Content = selectedStaff.PhoneNumber;
                statusCombo.SelectedItem = selectedStaff.Status;
                genderCombo.SelectedItem = selectedStaff.Gender;
                usernameTxt.Content = selectedStaff.Username;
                passwordTxt.Content = selectedStaff.Password;

                birthDate.Value = selectedStaff.DateOfBirth;

                // Load member image if available
                if (!string.IsNullOrWhiteSpace(selectedStaff.ProfileImagePath))
                {
                    LoadStaffImage(selectedStaff.ProfileImagePath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading member data: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void LoadStaffImage(string imagePath)
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
                Bitmap loadedImage = ImageFileManager.LoadStaffImage(fullPath);

                if (loadedImage != null)
                {
                    // Dispose previous image to free memory
                    if (pictureBox1.Image != null)
                    {
                        pictureBox1.Image.Dispose();
                    }

                    pictureBox1.Image = loadedImage;
                    capturedImage = (Bitmap)loadedImage.Clone();
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

        private async void doneBtn_Click(object sender, EventArgs e)
        {
            switch (_mode)
            {
                case FormMode.Add:
                    if (await ValidateInput())
                    {
                        var newStaff = CreateStaffFromFields();
                        if (SaveStaff(newStaff))
                        {
                            DialogResult = DialogResult.OK;
                            Close();
                        }
                    }
                    break;

                case FormMode.Edit:
                    if (await ValidateInput())
                    {
                        UpdateStaffFromFields();
                        if (UpdateStaff(_currentStaff))
                        {
                            _parentForm?.RefreshUserData();
                            DialogResult = DialogResult.OK;
                            Close();
                        }
                    }
                    break;

                case FormMode.View:
                    DialogResult = DialogResult.Cancel;
                    Close();
                    break;
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(firstNameTxt.Content) ||
                    !string.IsNullOrWhiteSpace(lastNameTxt.Content) ||
                    !string.IsNullOrWhiteSpace(emailAddTxt.Content) ||
                    !string.IsNullOrWhiteSpace(phoneNumTxt.Content) ||
                    !string.IsNullOrWhiteSpace(addressTxt.Content) ||
                    !string.IsNullOrWhiteSpace(usernameTxt.Content) ||
                    !string.IsNullOrWhiteSpace(passwordTxt.Content) ||
                    statusCombo.SelectedIndex >= 0 ||
                    genderCombo.SelectedIndex >= 0 ||
                    pictureBox1.Image != null)
            {
                var result = MessageBox.Show("You have unsaved changes. Are you sure you want to cancel?", "Confirm Cancel",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                {
                    return; // User chose not to cancel
                }
            }
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private async Task<bool> ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(firstNameTxt.Content) ||
                    string.IsNullOrWhiteSpace(lastNameTxt.Content) ||
                    string.IsNullOrWhiteSpace(emailAddTxt.Content) ||
                    string.IsNullOrWhiteSpace(phoneNumTxt.Content) ||
                    string.IsNullOrWhiteSpace(addressTxt.Content) ||
                    string.IsNullOrWhiteSpace(usernameTxt.Content) ||
                    string.IsNullOrWhiteSpace(passwordTxt.Content) ||
                    statusCombo.SelectedIndex == -1 ||
                    genderCombo.SelectedIndex == -1 ||
                    pictureBox1.Image == null)
            {
                MessageBox.Show("Please fill in all required fields.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (phoneNumTxt.Content.Length != 11)
            {
                MessageBox.Show("Mobile number should be exactly 11 characters length.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (emailAddTxt.Content.Contains("@gmail.com") == false || (Regex.IsMatch(emailAddTxt.Content, pattern) == false))
            {
                MessageBox.Show("Please enter a valid email address.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (birthDate.Value.Date >= DateTime.Now.Date)
            {
                MessageBox.Show("Date of Birth cannot be today or in the future.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (await CheckEmailExistence.IsUserEmailExistsAsync(emailAddTxt.Content, staffID))
            {
                MessageBox.Show("Email already exists. Please use a different email.",
                    "Duplicate Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                emailAddTxt.Focus();
                return false;
            }

            if (videoSource.IsRunning == true)
            {
                MessageBox.Show("Please stop the camera before saving changes.", "Camera Running",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
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

        private void generateQrBtn_Click(object sender, EventArgs e)
        {
            QrCode qrCodeGenerator = new QrCode(); // Create an instance of QrCode
            string qrContent = $"STAFF:{staffID}";
            Bitmap picQRCode = QrCode.GetCode(qrContent);
            qrCodeGenerator.GenerateQrCodeForMember(staffID, picQRCode); // Use the instance to call the non-static method
        }

        private User CreateStaffFromFields()
        {
            return new User()
            {
                FirstName = firstNameTxt.Content.Trim(),
                LastName = lastNameTxt.Content.Trim(),
                Email = emailAddTxt.Content.Trim(),
                PhoneNumber = phoneNumTxt.Content.Trim(),
                Address = addressTxt.Content.Trim(),
                DateOfBirth = birthDate.Value.Date,
                Status = statusCombo.SelectedItem.ToString(),
                Gender = genderCombo.SelectedItem.ToString(),
                Username = usernameTxt.Content.Trim(),
                Password = passwordTxt.Content.Trim(),
            };
        }

        private void UpdateStaffFromFields()
        {
            var selectedStaff = _dataContext.User.Find(staffID);

            if (selectedStaff != null)
            {
                selectedStaff.FirstName = firstNameTxt.Content.Trim();
                selectedStaff.LastName = lastNameTxt.Content.Trim();
                selectedStaff.Email = emailAddTxt.Content.Trim();
                selectedStaff.PhoneNumber = phoneNumTxt.Content.Trim();
                selectedStaff.Address = addressTxt.Content.Trim();

                selectedStaff.Status = statusCombo.SelectedItem?.ToString() ?? selectedStaff.Status;
                selectedStaff.Gender = genderCombo.SelectedItem?.ToString() ?? selectedStaff.Gender;

                selectedStaff.DateOfBirth = birthDate.Value;

                selectedStaff.Username = usernameTxt.Content.Trim();

                // Hash this password before saving
                selectedStaff.Password = passwordTxt.Content.Trim();

                _currentStaff = selectedStaff;
            }
            else
            {
                throw new InvalidOperationException($"Staff with ID {staffID} not found.");
            }
        }

        private bool SaveStaff(User staff)
        {
            try
            {
                _dataContext.Add(staff);
                _dataContext.SaveChanges();
                SaveStaffPhoto(staff);

                QrCode qrCodeGenerator = new QrCode();
                Bitmap picQRCode = QrCode.GetCode(staff.Id.ToString());
                qrCodeGenerator.GenerateQrCodeForStaff(staff.Id, picQRCode);

                MessageBox.Show("Staff registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _parentForm?.RefreshUserData();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error registering staff: {ex.Message}",
                    "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
        }

        private bool UpdateStaff(User staff)
        {
            try
            {
                _dataContext.SaveChanges();
                SaveStaffPhoto(staff);

                MessageBox.Show("Staff updated successfully!",
                                "Success",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Staff registered successfully, but failed to save image: {ex.Message}",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }
        }

        private void SaveStaffPhoto(User staff)
        {
            if (isImageCaptured && capturedImage != null)
            {
                try
                {
                    string imagePath = ImageFileManager.SaveStaffImage(capturedImage, staff.Id, staff.Email);

                    string relativePath = ImageFileManager.GetRelativePath(imagePath);

                    staff.ProfileImagePath = relativePath;
                    staff.ImageFileName = System.IO.Path.GetFileName(imagePath);
                    staff.ImageCapturedDate = DateTime.Now;

                    _dataContext.SaveChanges(); // Save image path
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Staff registered successfully, but failed to save image: {ex.Message}",
                        "Warning",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
        }

        private void StaffForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource.WaitForStop();
            }
            _dataContext?.Dispose();
            currentFrame?.Dispose();
            capturedImage?.Dispose();
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
