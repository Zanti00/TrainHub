using AForge.Video;
using AForge.Video.DirectShow;
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
    public partial class TrainerForm : Form
    {
        private FormMode _mode;
        private Trainer _currentTrainer;
        private int trainerID;
        private VideoCaptureDevice videoSource;
        private Bitmap currentFrame;
        private Bitmap capturedImage;
        private bool isImageCaptured = false;
        private readonly TrainHubContext _dataContext;
        string pattern = @"^[a-zA-Z0-9._%+-]+@gmail\.com$";
        private readonly table_trainer _parentForm;
        public TrainerForm(table_trainer parentForm, FormMode mode, Trainer? trainer = null, int? trainerID = null)
        {
            InitializeComponent();
            InitializeWebcam();
            _mode = mode;
            _currentTrainer = trainer ?? new Trainer();
            _parentForm = parentForm;
            this.trainerID = trainerID ?? 0;
            _dataContext = new TrainHubContext();

            ConfigureFormForMode();
            if (!(mode == FormMode.Add))
            {
                LoadTrainerData();
            }
            if (!(mode == FormMode.Edit))
            {
                generateQrBtn.Enabled = false;
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
                    formLabel.Text = "Add New Member";
                    EnableFields(true);
                    break;
                case FormMode.Edit:
                    formLabel.Text = "Edit Member Details";
                    EnableFields(true);
                    break;
                case FormMode.View:
                    formLabel.Text = "View Member Details";
                    EnableFields(false);
                    break;
            }
        }

        private void EnableFields(bool enabled)
        {
            firstNameTxt.Enabled = enabled;
            lastNameTxt.Enabled = enabled;
            emailAddTxt.Enabled = enabled;
            phoneNumTxt.Enabled = enabled;
            birthDate.Enabled = enabled;
            addressTxt.Enabled = enabled;
            genderCombo.Enabled = enabled;
            specializationTxt.Enabled = enabled;
            yearsOfExperienceTxt.Enabled = enabled;
            availabilityTxt.Enabled = enabled;
            hourlyRateTxt.Enabled = enabled;
            statusCombo.Enabled = enabled;
            captureBtn.Enabled = enabled;
            openCameraBtn.Enabled = enabled;
        }

        private void LoadTrainerData()
        {
            if (_currentTrainer != null)
            {
                try
                {
                    var selectedTrainer = _dataContext.Trainer.Find(trainerID);

                    if (selectedTrainer == null)
                    {
                        MessageBox.Show("Trainer not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                        return;
                    }
                    else
                    {
                        firstNameTxt.Content = selectedTrainer.FirstName;
                        lastNameTxt.Content = selectedTrainer.LastName;
                        genderCombo.SelectedItem = selectedTrainer.Gender;
                        emailAddTxt.Content = selectedTrainer.Email;
                        phoneNumTxt.Content = selectedTrainer.PhoneNumber;
                        addressTxt.Content = selectedTrainer.Address;
                        yearsOfExperienceTxt.Content = selectedTrainer.YearsOfExperience.ToString();
                        specializationTxt.Content = selectedTrainer.Specialization;
                        availabilityTxt.Content = selectedTrainer.Availability;
                        hourlyRateTxt.Content = selectedTrainer.HourlyRate.ToString("F2");
                        birthDate.Value = selectedTrainer.DateOfBirth;
                        statusCombo.SelectedItem = selectedTrainer.Status;

                        LoadTrainerImage(selectedTrainer.ProfileImagePath);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading member data: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
        }

        private void LoadTrainerImage(string imagePath)
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
                        var newTrainer = CreateTrainerFromFields();
                        if (SaveTrainer(newTrainer))
                        {
                            DialogResult = DialogResult.OK;
                            Close();
                        }
                    }
                    break;

                case FormMode.Edit:
                    if (await ValidateInput())
                    {
                        UpdateTrainerFromFields();
                        if (UpdateTrainer(_currentTrainer))
                        {
                            DialogResult = DialogResult.OK;
                            _parentForm?.RefreshTrainerData();
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
                    !string.IsNullOrWhiteSpace(specializationTxt.Content) ||
                    !string.IsNullOrWhiteSpace(yearsOfExperienceTxt.Content) ||
                    !string.IsNullOrWhiteSpace(availabilityTxt.Content) ||
                    !string.IsNullOrWhiteSpace(hourlyRateTxt.Content) ||
                    genderCombo.SelectedIndex >= 0 ||
                    statusCombo.SelectedIndex >= 0 ||
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
                    string.IsNullOrWhiteSpace(specializationTxt.Content) ||
                    string.IsNullOrWhiteSpace(yearsOfExperienceTxt.Content) ||
                    string.IsNullOrWhiteSpace(availabilityTxt.Content) ||
                    string.IsNullOrWhiteSpace(hourlyRateTxt.Content) ||
                    genderCombo.SelectedIndex == -1 ||
                    statusCombo.SelectedIndex == -1 ||
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
            if (await CheckEmailExistence.IsTrainerEmailExistsAsync(emailAddTxt.Content, trainerID))
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

        private void yearsOfExperienceTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Prevent non-numeric input
            }
        }

        private void hourlyRateTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar) || e.KeyChar == '.')
            {
                // Allow control characters, digits, and decimal point
                if (e.KeyChar == '.' && hourlyRateTxt.Content.Contains("."))
                {
                    e.Handled = true; // Prevent multiple decimal points
                }
            }
            else
            {
                e.Handled = true; // Prevent any other character input
            }
        }

        private void generateQrBtn_Click(object sender, EventArgs e)
        {
            QrCode qrCodeGenerator = new QrCode(); // Create an instance of QrCode
            string qrContent = $"TRAINER:{trainerID}";
            Bitmap picQRCode = QrCode.GetCode(qrContent);
            qrCodeGenerator.GenerateQrCodeForTrainer(trainerID, picQRCode); // Use the instance to call the non-static method
        }

        private Trainer CreateTrainerFromFields()
        {
            return new Trainer()
            {
                FirstName = firstNameTxt.Content.Trim(),
                LastName = lastNameTxt.Content.Trim(),
                Email = emailAddTxt.Content.Trim(),
                PhoneNumber = phoneNumTxt.Content.Trim(),
                Address = addressTxt.Content.Trim(),
                Specialization = specializationTxt.Content.Trim(),
                YearsOfExperience = yearsOfExperienceTxt.Content.Trim(),
                Availability = availabilityTxt.Content.Trim(),
                HourlyRate = decimal.TryParse(hourlyRateTxt.Content.Trim(), out decimal hourlyRate) ? hourlyRate : 0m,
                DateOfBirth = birthDate.Value.Date,
                Status = statusCombo.SelectedItem.ToString(),
                Gender = genderCombo.SelectedItem.ToString(),
                //TrainerID = 1 // Assuming a default trainer ID for now
            };
        }

        private void UpdateTrainerFromFields()
        {
            var selectedTrainer = _dataContext.Trainer.Find(trainerID);

            if (selectedTrainer != null)
            {
                selectedTrainer.FirstName = firstNameTxt.Content.Trim();
                selectedTrainer.LastName = lastNameTxt.Content.Trim();
                selectedTrainer.Email = emailAddTxt.Content.Trim();
                selectedTrainer.PhoneNumber = phoneNumTxt.Content.Trim();
                selectedTrainer.Address = addressTxt.Content.Trim();
                selectedTrainer.Specialization = specializationTxt.Content.Trim();
                selectedTrainer.YearsOfExperience = yearsOfExperienceTxt.Content.Trim();
                selectedTrainer.Availability = availabilityTxt.Content.Trim();
                selectedTrainer.HourlyRate = decimal.TryParse(hourlyRateTxt.Content.Trim(), out decimal hourlyRate) ? hourlyRate : 0m;

                selectedTrainer.Status = statusCombo.SelectedItem?.ToString() ?? selectedTrainer.Status;
                selectedTrainer.Gender = genderCombo.SelectedItem?.ToString() ?? selectedTrainer.Gender;

                selectedTrainer.DateOfBirth = birthDate.Value;
            }
        }

        private bool SaveTrainer(Trainer trainer)
        {
            try
            {
                _dataContext.Add(trainer);
                _dataContext.SaveChanges();
                SaveTrainerPhoto(trainer);

                QrCode qrCodeGenerator = new QrCode();
                Bitmap picQRCode = QrCode.GetCode(trainer.Id.ToString());
                qrCodeGenerator.GenerateQrCodeForTrainer(trainer.Id, picQRCode);

                MessageBox.Show("Trainer registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _parentForm?.RefreshTrainerData();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error registering trainer: {ex.Message}",
                    "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
        }

        private bool UpdateTrainer(Trainer trainer)
        {
            try
            {
                _dataContext.SaveChanges();
                SaveTrainerPhoto(trainer);

                MessageBox.Show("Trainer updated successfully!",
                                "Success",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Trainer registered successfully, but failed to save image: {ex.Message}",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }
        }
        private void SaveTrainerPhoto(Trainer trainer)
        {
            if (isImageCaptured && capturedImage != null)
            {
                try
                {
                    string imagePath = ImageFileManager.SaveTrainerImage(capturedImage, trainer.Id, trainer.Email);

                    string relativePath = ImageFileManager.GetRelativePath(imagePath);

                    trainer.ProfileImagePath = relativePath;
                    trainer.ImageFileName = System.IO.Path.GetFileName(imagePath);
                    trainer.ImageCapturedDate = DateTime.Now;

                    _dataContext.SaveChanges(); // Save image path
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Trainer registered successfully, but failed to save image: {ex.Message}",
                        "Warning",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
        }
        private void TrainerForm_FormClosing(object sender, FormClosingEventArgs e)
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

    }
}
