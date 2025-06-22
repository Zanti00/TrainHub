using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrainHub.Data;
using TrainHub.Models;
using TrainHub.Static_Classes;

namespace TrainHub
{
    public partial class ViewTrainer : Form
    {
        private int trainerID;
        TrainHubContext dataContext = new TrainHubContext();
        private ReadQRForm _readQRForm;

        public ViewTrainer(int trainerID, ReadQRForm? _readQRForm)
        {
            this.trainerID = trainerID;
            this._readQRForm = _readQRForm;
            InitializeComponent();

            LoadTrainerData();
        }

        private void LoadTrainerData()
        {
            try
            {
                var selectedTrainer = dataContext.Trainer.Find(trainerID);

                if (selectedTrainer == null)
                {
                    MessageBox.Show("Trainer not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }
                else
                {
                    firstName.Text = selectedTrainer.FirstName;
                    lastName.Text = selectedTrainer.LastName;
                    emailAdd.Text = selectedTrainer.Email;
                    phoneNum.Text = selectedTrainer.PhoneNumber;
                    status.Text = selectedTrainer.Status;
                    availability.Text = selectedTrainer.Availability;
                    birthDate.Value = selectedTrainer.DateOfBirth;
                    hireDate.Value = (DateTime)selectedTrainer.CreatedDate;

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
                Bitmap loadedImage = ImageFileManager.LoadTrainerImage(fullPath);

                if (loadedImage != null)
                {
                    // Dispose previous image to free memory
                    if (pictureBox1.Image != null)
                    {
                        pictureBox1.Image.Dispose();
                    }

                    pictureBox1.Image = loadedImage;
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

        private void ShowImagePopup(string imagePath)
        {
            Form imageForm = new Form();
            imageForm.Size = new Size(400, 400);
            imageForm.StartPosition = FormStartPosition.CenterParent;
            imageForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            imageForm.MinimizeBox = false;

            PictureBox pictureBox = new PictureBox();
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.Image = Image.FromFile(imagePath);

            imageForm.Controls.Add(pictureBox);

            // Clean up image when form closes
            imageForm.FormClosed += (s, e) => pictureBox.Image?.Dispose();

            imageForm.ShowDialog(this);
        }
        private void doneBtn_Click(object sender, EventArgs e)
        {
            _readQRForm?.RecordTrainerAttendance(trainerID);
            this.Close();
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            var selectedTrainer = dataContext.Trainer.Find(trainerID);

            string fullPath = ImageFileManager.GetFullPath(selectedTrainer.ProfileImagePath);
            ShowImagePopup(fullPath);
        }
    }
}
