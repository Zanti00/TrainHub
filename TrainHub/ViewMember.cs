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

    public partial class ViewMember : Form
    {
        private int memberID;
        TrainHubContext dataContext = new TrainHubContext();
        public ViewMember(int memberID)
        {
            InitializeComponent();

            this.memberID = memberID;

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
                    firstName.Text = selectedMember.FirstName;
                    lastName.Text = selectedMember.LastName;
                    emailAdd.Text = selectedMember.Email;
                    phoneNum.Text = selectedMember.PhoneNumber;
                    status.Text = selectedMember.Status;
                    membershipType.Text = selectedMember.MembershipType;
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
            this.Close();
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            var selectedMember = dataContext.Member.Find(memberID);

            string fullPath = ImageFileManager.GetFullPath(selectedMember.ProfileImagePath);
            ShowImagePopup(fullPath);
        }
    }
}
