using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrainHub;
using TrainHub.Data;
using TrainHub.Models;
using TrainHub.Static_Classes;
using TrainHub.User_Controls;
using Zuby.ADGV;

namespace TrainHub
{
    public partial class ShowMembersTablePageForm1 : Form
    {
        private TrainHubContext dataContext;
        public ShowMembersTablePageForm1()
        {
            InitializeComponent();
            dataContext = new TrainHubContext();

            advancedDataGridView1.CellFormatting += advancedDataGridView1_CellFormatting;
        }
        private void cuiButtonGroup2_Click(object sender, EventArgs e)
        {
            MemberForm addMemberForm = new MemberForm(this, FormMode.Add);
            addMemberForm.ShowDialog();
        }
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 14 && e.RowIndex >= 0)
            {
                int memberID = Convert.ToInt32(advancedDataGridView1.Rows[e.RowIndex].Cells[0].Value);
                MemberForm viewMemberForm = new MemberForm(this, FormMode.View, memberID);
                viewMemberForm.ShowDialog();
            }

            if (e.ColumnIndex == 15 && e.RowIndex >= 0)
            {
                int memberID = Convert.ToInt32(advancedDataGridView1.Rows[e.RowIndex].Cells[0].Value);
                MemberForm editMemberForm = new MemberForm(this, FormMode.Edit, memberID);
                editMemberForm.ShowDialog();
            }

            if (e.ColumnIndex == 16 && e.RowIndex >= 0)
            {
                // Confirm deletion
                var result = MessageBox.Show($"Are you sure you want to delete member {advancedDataGridView1.Rows[e.RowIndex].Cells[1].Value} {advancedDataGridView1.Rows[e.RowIndex].Cells[2].Value}?", "Confirm Deletion",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        // Get the selected member's ID
                        int memberId = Convert.ToInt32(advancedDataGridView1.Rows[e.RowIndex].Cells[0].Value);
                        var memberToDelete = dataContext.Member.Find(memberId);
                        if (memberToDelete != null)
                        {
                            memberToDelete.IsDeleted = true; // Soft delete
                            memberToDelete.SoftDeleteDate = DateTime.Today;
                            dataContext.SaveChanges();
                            RefreshMemberData(); // Refresh the DataGridView after deletion
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error deleting member: {ex.Message}", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void advancedDataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 11 && e.Value != null)
            {
                if (e.Value is Trainer trainer)
                {
                    e.Value = $"{trainer.FirstName} {trainer.LastName}";
                    e.FormattingApplied = true;
                }
            }

            if (e.ColumnIndex == 10 && e.Value != null)
            {
                string status = e.Value.ToString();

                if (status.Equals("Active", StringComparison.OrdinalIgnoreCase))
                {
                    e.CellStyle.ForeColor = Color.Green;
                }
                else if (status.Equals("Inactive", StringComparison.OrdinalIgnoreCase))
                {
                    e.CellStyle.ForeColor = Color.Red;
                }
                else
                {
                    e.CellStyle.ForeColor = Color.Black; // Default color
                }
            }
        }
        private void advancedDataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if clicked on image column (ProfileImage column)
            if (e.ColumnIndex == 1 && e.RowIndex >= 0) // Adjust column index based on your layout
            {
                try
                {
                    int memberId = Convert.ToInt32(advancedDataGridView1.Rows[e.RowIndex].Cells[0].Value);
                    var member = dataContext.Member.Find(memberId);

                    if (member != null && !string.IsNullOrEmpty(member.ProfileImagePath))
                    {
                        string fullPath = ImageFileManager.GetFullPath(member.ProfileImagePath);

                        if (File.Exists(fullPath))
                        {
                            // Show image in a popup form
                            ShowImagePopup(fullPath, $"{member.FirstName} {member.LastName}");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error displaying image: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void ShowImagePopup(string imagePath, string memberName)
        {
            Form imageForm = new Form();
            imageForm.Text = $"Photo - {memberName}";
            imageForm.Size = new Size(400, 400);
            imageForm.StartPosition = FormStartPosition.CenterParent;
            imageForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            imageForm.MaximizeBox = false;
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
        private void ShowMembersTablePageForm1_Load(object sender, EventArgs e)
        {
            RefreshMemberData();
        }
        
        private DataTable CreateMemberDataTable()
        {
            var dataTable = new DataTable();
            dataTable.Columns.Add("Id", typeof(int));
            dataTable.Columns.Add("FirstName", typeof(string));
            dataTable.Columns.Add("LastName", typeof(string));
            dataTable.Columns.Add("Email", typeof(string));
            dataTable.Columns.Add("PhoneNumber", typeof(string));
            dataTable.Columns.Add("DateOfBirth", typeof(DateTime));
            dataTable.Columns.Add("StartDate", typeof(DateTime));
            dataTable.Columns.Add("EndDate", typeof(DateTime));
            dataTable.Columns.Add("CreatedDate", typeof(DateTime));
            dataTable.Columns.Add("SoftDeleteDate", typeof(DateTime));
            dataTable.Columns.Add("IsDeleted", typeof(bool));
            dataTable.Columns.Add("Status", typeof(string));
            dataTable.Columns.Add("MembershipType", typeof(string));
            dataTable.Columns.Add("Gender", typeof(string));
            dataTable.Columns.Add("TrainerFullName", typeof(string));

            return dataTable;
        }
        
        public void RefreshMemberData()
        {

            try
            {
                dataContext.ChangeTracker.Clear();
                IQueryable<Member> members;
                if (deletedMemberCheck.Checked)
                {
                    members = from member in dataContext.Member
                              .Include(m => m.Trainer)
                              select member;
                }
                else
                {
                    members = from member in dataContext.Member
                              .Include(m => m.Trainer)
                              where !member.IsDeleted // Only select non-deleted members
                              select member;
                }

                // Convert to DataTable for sorting/filtering support
                var dataTable = CreateMemberDataTable();

                foreach (var member in members)
                {
                    dataTable.Rows.Add(
                        member.Id,
                        member.FirstName,
                        member.LastName,
                        member.Email,
                        member.PhoneNumber,
                        member.DateOfBirth,
                        member.StartDate,
                        member.EndDate,
                        member.CreatedDate,
                        member.SoftDeleteDate,
                        member.IsDeleted,
                        member.Status,
                        member.MembershipType,
                        member.Gender,
                        member.TrainerFullName
                    );
                }

                this.memberBindingSource.DataSource = dataTable;
                advancedDataGridView1.DataSource = memberBindingSource;

                // to disable sort and filter for unbounded columns
                foreach (DataGridViewColumn col in advancedDataGridView1.Columns)
                {
                    if (string.IsNullOrEmpty(col.DataPropertyName))
                    {
                        advancedDataGridView1.SetFilterAndSortEnabled(col, false);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading member data: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private Image LoadMemberImage(string imagePath)
        {
            try
            {
                if (!string.IsNullOrEmpty(imagePath))
                {
                    // Construct full path from relative path
                    string fullPath = ImageFileManager.GetFullPath(imagePath);

                    if (File.Exists(fullPath))
                    {
                        // Load and resize image for DataGridView display
                        using (var originalImage = Image.FromFile(fullPath))
                        {
                            return ResizeImage(originalImage, 60, 60); // Resize to 60x60 for display
                        }
                    }
                }

                // Return default/placeholder image if no image found
                return CreateDefaultImage();
            }
            catch (Exception ex)
            {
                // Return default image on error
                return CreateDefaultImage();
            }
        }
        private Image ResizeImage(Image originalImage, int width, int height)
        {
            Bitmap resized = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(resized))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(originalImage, 0, 0, width, height);
            }
            return resized;
        }
        private Image CreateDefaultImage()
        {
            // Create a simple default image (gray rectangle with text)
            Bitmap defaultImage = new Bitmap(60, 60);
            using (Graphics g = Graphics.FromImage(defaultImage))
            {
                g.FillRectangle(Brushes.LightGray, 0, 0, 60, 60);
                g.DrawRectangle(Pens.Gray, 0, 0, 59, 59);

                using (Font font = new Font("Arial", 8))
                {
                    g.DrawString("No\nPhoto", font, Brushes.DarkGray, 10, 20);
                }
            }
            return defaultImage;
        }
        private void searchBar_ContentChanged(object sender, EventArgs e)
        {
            string memberName = searchBar.Content.Trim();

            try
            {
                if (!string.IsNullOrEmpty(memberName))
                {
                    IQueryable<Member> members;
                    if (deletedMemberCheck.Checked)
                    {
                        members = from member in dataContext.Member
                                    .Include(m => m.Trainer)
                                    where member.FirstName.ToLower().Contains(memberName.ToLower()) ||
                                        member.LastName.ToLower().Contains(memberName.ToLower())
                                    select member;
                    }
                    else
                    {
                        members = from member in dataContext.Member
                                    .Include(m => m.Trainer)
                                    where !member.IsDeleted &&
                                        (member.FirstName.ToLower().Contains(memberName.ToLower()) ||
                                         member.LastName.ToLower().Contains(memberName.ToLower()))
                                    select member;
                    }

                    // Convert to DataTable for sorting/filtering support
                    var dataTable = CreateMemberDataTable();

                    foreach (var member in members)
                    {

                        dataTable.Rows.Add(
                            member.Id,
                            member.FirstName,
                            member.LastName,
                            member.Email,
                            member.PhoneNumber,
                            member.DateOfBirth,
                            member.StartDate,
                            member.EndDate,
                            member.CreatedDate,
                            member.SoftDeleteDate,
                            member.IsDeleted,
                            member.Status,
                            member.MembershipType,
                            member.Gender,
                            member.TrainerFullName
                        );
                    }

                    this.memberBindingSource.DataSource = dataTable;
                }
                else
                {
                    // If search is empty, show all members
                    RefreshMemberData();
                }
                advancedDataGridView1.DataSource = memberBindingSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching member data: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deletedMemberCheck_Click(object sender, EventArgs e)
        {
            RefreshMemberData();
        }
    }
}
