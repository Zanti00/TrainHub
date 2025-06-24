using Microsoft.VisualBasic.ApplicationServices;
using System.Data;
using TrainHub.Data;
using TrainHub.Models;

namespace TrainHub
{
    public partial class StaffTable : Form
    {
        private TrainHubContext dataContext;

        public StaffTable()
        {
            InitializeComponent();

            dataContext = new TrainHubContext();
        }

        private void advancedDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 11 && e.RowIndex >= 0)
            {
                int staffID = Convert.ToInt32(advancedDataGridView1.Rows[e.RowIndex].Cells[0].Value);
                StaffForm viewStaffForm = new StaffForm(this, FormMode.Edit, null, staffID);
                viewStaffForm.ShowDialog();
            }

            if (e.ColumnIndex == 12 && e.RowIndex >= 0)
            {
                int staffID = Convert.ToInt32(advancedDataGridView1.Rows[e.RowIndex].Cells[0].Value);
                StaffForm editStaffForm = new StaffForm(this, FormMode.Edit, null, staffID);
                editStaffForm.ShowDialog();
            }

            // Delete button column index = 10
            if (e.ColumnIndex == 13 && e.RowIndex >= 0)
            {
                // Confirm deletion
                var result = MessageBox.Show($"Are you sure you want to delete staff {advancedDataGridView1.Rows[e.RowIndex].Cells[1].Value} {advancedDataGridView1.Rows[e.RowIndex].Cells[2].Value}?", "Confirm Deletion",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        int staffId = Convert.ToInt32(advancedDataGridView1.Rows[e.RowIndex].Cells[0].Value);
                        var staffToDelete = dataContext.User.Find(staffId);
                        if (staffToDelete != null)
                        {
                            staffToDelete.isDeleted = true;
                            staffToDelete.softDeleteDate = DateTime.Today;
                            dataContext.SaveChanges();
                            RefreshUserData(); // Refresh the DataGridView after deletion
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

        private void addStaffBtn_Click(object sender, EventArgs e)
        {
            StaffForm addStaffForm = new StaffForm(this, FormMode.Add);
            addStaffForm.ShowDialog();
        }
        private DataTable CreateUserDataTable()
        {
            var dataTable = new DataTable();
            dataTable.Columns.Add("Id", typeof(int));
            dataTable.Columns.Add("FirstName", typeof(string));
            dataTable.Columns.Add("LastName", typeof(string));
            dataTable.Columns.Add("Username", typeof(string));
            dataTable.Columns.Add("Gender", typeof(string));
            dataTable.Columns.Add("PhoneNumber", typeof(string));
            dataTable.Columns.Add("Email", typeof(string));
            dataTable.Columns.Add("DateOfBirth", typeof(DateTime));
            dataTable.Columns.Add("Address", typeof(string));
            dataTable.Columns.Add("CreatedDate", typeof(DateTime));
            dataTable.Columns.Add("Status", typeof(string));

            return dataTable;
        }

        public void RefreshUserData()
        {
            try
            {
                dataContext.ChangeTracker.Clear();
                var staffs = from user in dataContext.User
                             where !user.isDeleted // Only select non-deleted members
                             select user;

                var dataTable = CreateUserDataTable();

                foreach (var staff in staffs)
                {
                    dataTable.Rows.Add(
                        staff.Id,
                        staff.FirstName,
                        staff.LastName,
                        staff.Username,
                        staff.Gender,
                        staff.PhoneNumber,
                        staff.Email,
                        staff.DateOfBirth,
                        staff.Address,
                        staff.CreatedDate,
                        staff.Status
                    );
                }

                this.userBindingSource.DataSource = dataTable;
                advancedDataGridView1.DataSource = userBindingSource;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading user data: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StaffTable_Load(object sender, EventArgs e)
        {
            RefreshUserData();
        }

        private void searchBar_ContentChanged(object sender, EventArgs e)
        {
            string searchStaff = searchBar.Content.Trim();

            try
            {

                if (!string.IsNullOrEmpty(searchStaff))
                {
                    var staffs = from user in dataContext.User
                                 where !user.isDeleted &&
                                       user.FirstName.ToLower().Contains(searchStaff.ToLower()) ||
                                       user.LastName.ToLower().Contains(searchStaff.ToLower())
                                 select user;


                    // Convert to DataTable with consistent column order
                    var dataTable = CreateUserDataTable();

                    foreach (var staff in staffs)
                    {
                        dataTable.Rows.Add(
                            staff.Id,
                            staff.FirstName,
                            staff.LastName,
                            staff.Username,
                            staff.Gender,
                            staff.PhoneNumber,
                            staff.Email,
                            staff.DateOfBirth,
                            staff.Address,
                            staff.CreatedDate,
                            staff.Status
                        );
                    }

                    this.userBindingSource.DataSource = dataTable;
                }
                else
                {
                    // If search is empty, show all members
                    RefreshUserData();
                }
                advancedDataGridView1.DataSource = userBindingSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching user data: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
