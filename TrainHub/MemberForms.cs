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

namespace TrainHub.User_Controls
{
    //public enum FormMode
    //{
    //    Add,
    //    Edit,
    //    View
    //}
    public partial class MemberForm : Form
    {
        private FormMode _mode;
        private Member _currentMember;
        private int memberID;
        private VideoCaptureDevice videoSource;
        private Bitmap currentFrame;
        private Bitmap capturedImage;
        private bool isImageCaptured = false;
        private readonly TrainHubContext _dataContext;
        string pattern = @"^[a-zA-Z0-9._%+-]+@gmail\.com$";
        private readonly ShowMembersTablePageForm1 _parentForm;

        public MemberForm(ShowMembersTablePageForm1 parentForm, FormMode mode, Member? member = null, int? memberID = null)
        {
            InitializeComponent();
            InitializeWebcam();
            _mode = mode;
            _currentMember = member ?? new Member();
            _parentForm = parentForm;
            this.memberID = memberID ?? 0;
            _dataContext = new TrainHubContext();

            ConfigureFormForMode();
            if (!(mode == FormMode.Add))
            {
                LoadMemberData();
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
            statusCombo.Enabled = enabled;
            membershipTypeCombo.Enabled = enabled;
            trainerCombo.Enabled = enabled;
            birthDate.Enabled = enabled;
            startDate.Enabled = enabled;
            endDate.Enabled = enabled;
            captureBtn.Enabled = enabled;
            openCameraBtn.Enabled = enabled;
            genderCombo.Enabled = enabled;
        }

        private void LoadMemberData()
        {
            if (_currentMember != null)
            {
                try
                {
                    var selectedMember = _dataContext.Member.Find(memberID);

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
                        genderCombo.SelectedItem = selectedMember.Gender;

                        LoadMemberImage(selectedMember.ProfileImagePath);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading member data: {ex.Message}", 
                        "Error",
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Error);
                    this.Close();
                }
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
                        var newMember = CreateMemberFromFields();
                        if (SaveMember(newMember))
                        {
                            DialogResult = DialogResult.OK;
                            Close();
                        }
                    }
                    break;

                case FormMode.Edit:
                    if (await ValidateInput())
                    {
                        UpdateMemberFromFields();
                        if (UpdateMember(_currentMember))
                        {
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
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private async Task<bool> ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(firstNameTxt.Content) ||
                    string.IsNullOrWhiteSpace(lastNameTxt.Content) ||
                    string.IsNullOrWhiteSpace(emailAddTxt.Content) ||
                    string.IsNullOrWhiteSpace(phoneNumTxt.Content) ||
                    statusCombo.SelectedIndex == -1 ||
                    membershipTypeCombo.SelectedIndex == -1 ||
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
            if (await CheckEmailExistence.IsMemberEmailExistsAsync(emailAddTxt.Content, memberID))
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

        private Member CreateMemberFromFields()
        {
            return new Member()
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
                Gender = genderCombo.SelectedItem.ToString(),
            };
        }

        private void UpdateMemberFromFields()
        {
            var selectedMember = _dataContext.Member.Find(memberID);

            if (selectedMember != null)
            {
                selectedMember.FirstName = firstNameTxt.Content.Trim();
                selectedMember.LastName = lastNameTxt.Content.Trim();
                selectedMember.Email = emailAddTxt.Content.Trim();
                selectedMember.PhoneNumber = phoneNumTxt.Content.Trim();

                selectedMember.Status = statusCombo.SelectedItem?.ToString() ?? selectedMember.Status;
                selectedMember.MembershipType = membershipTypeCombo.SelectedItem?.ToString() ?? selectedMember.MembershipType;
                selectedMember.Gender = genderCombo.SelectedItem?.ToString() ?? selectedMember.Gender;

                selectedMember.DateOfBirth = birthDate.Value;
                selectedMember.StartDate = startDate.Value;
                selectedMember.EndDate = endDate.Value;
            }
        }

        private bool SaveMember(Member member)
        {
            try
            {
                _dataContext.Add(member);
                _dataContext.SaveChanges();
                SaveMemberPhoto(member);

                QrCode qrCodeGenerator = new QrCode();
                Bitmap picQRCode = QrCode.GetCode(member.Id.ToString());
                qrCodeGenerator.GenerateQrCodeForMember(member.Id, picQRCode);

                MessageBox.Show("Member registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _parentForm?.RefreshMemberData();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error registering member: {ex.Message}",
                    "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
        }

        private bool UpdateMember(Member member)
        {
            try
            {
                _dataContext.SaveChanges();
                SaveMemberPhoto(member);

                MessageBox.Show("Member updated successfully!",
                                "Success",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Member registered successfully, but failed to save image: {ex.Message}",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }
        }
        private void SaveMemberPhoto(Member member)
        {
            if (isImageCaptured && capturedImage != null)
            {
                try
                {
                    string imagePath = ImageFileManager.SaveMemberImage(capturedImage, member.Id, member.Email);

                    string relativePath = ImageFileManager.GetRelativePath(imagePath);

                    member.ProfileImagePath = relativePath;
                    member.ImageFileName = System.IO.Path.GetFileName(imagePath);
                    member.ImageCapturedDate = DateTime.Now;

                    _dataContext.SaveChanges(); // Save image path
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Member registered successfully, but failed to save image: {ex.Message}",
                        "Warning",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
        }

        private void MemberForm_FormClosing(object sender, FormClosingEventArgs e)
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
