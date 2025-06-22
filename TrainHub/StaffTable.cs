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

        private void advancedDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Edit button column index = 9
            if (e.ColumnIndex == 9 && e.RowIndex >= 0)
            {
                int userID = Convert.ToInt32(advancedDataGridView1.Rows[e.RowIndex].Cells[0].Value);
                edit_staff editForm = new edit_staff(userID, this);
                editForm.ShowDialog();
            }

            // Delete button column index = 10
            if (e.ColumnIndex == 10 && e.RowIndex >= 0)
            {
                // Make sure you're not deleting the new row
                if (!advancedDataGridView1.Rows[e.RowIndex].IsNewRow)
                {
                    DialogResult deleteConfirmationResult = MessageBox.Show(
                        "Are you sure you want to delete this staff member?",
                        "Confirm Delete",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (deleteConfirmationResult == DialogResult.Yes)
                    {
                        try
                        {
                            // Get the ID from the first column (index 0) which should be the Id column
                            int staffId = Convert.ToInt32(advancedDataGridView1.Rows[e.RowIndex].Cells[0].Value);

                            // Find the staff in the database and mark as deleted
                            var staffToDelete = dataContext.User.FirstOrDefault(s => s.Id == staffId);
                            if (staffToDelete != null)
                            {
                                staffToDelete.isDeleted = true;
                                staffToDelete.softDeleteDate = DateTime.Now; // Set the soft delete date
                                dataContext.SaveChanges();

                                // Refresh the DataGridView to remove the deleted item
                                RefreshUserData();

                                MessageBox.Show("Staff member deleted successfully.", "Success",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Staff member not found in database.", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error deleting staff member: {ex.Message}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Cannot delete the new row entry.", "Invalid Operation",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void addStaffBtn_Click(object sender, EventArgs e)
        {
            add_newstaff f1 = new add_newstaff(this);
            f1.ShowDialog();
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            string searchText = searchTextBox.Content.Trim();

            try
            {
                IQueryable<User> users;

                if (!string.IsNullOrEmpty(searchText))
                {
                    // Search in FirstName, LastName, Username, and Email
                    users = from user in dataContext.User
                            where !user.isDeleted && // Only include non-deleted users
                                  (user.FirstName.ToLower().Contains(searchText.ToLower()) ||
                                   user.LastName.ToLower().Contains(searchText.ToLower()) ||
                                   user.Username.ToLower().Contains(searchText.ToLower()) ||
                                   user.Email.ToLower().Contains(searchText.ToLower()))
                            select user;
                }
                else
                {
                    // If search is empty, show all non-deleted users
                    users = from user in dataContext.User
                            where !user.isDeleted
                            select user;
                }

                // Convert to DataTable with consistent column order
                var dataTable = CreateUserDataTable();

                foreach (var user in users)
                {
                    dataTable.Rows.Add(
                        user.Id,
                        user.FirstName,
                        user.LastName,
                        user.Username,           // Fixed: Username in correct position
                        user.MobileNumber,
                        user.DateOfBirth,
                        user.Email,              // Fixed: Email in correct position
                        user.Password,
                        user.Address,            // Fixed: Address in correct position
                        user.CreatedDate,
                        user.softDeleteDate,
                        user.isDeleted
                    );
                }

                userBindingSource.DataSource = dataTable;
                advancedDataGridView1.DataSource = userBindingSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching user data: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Creates a consistent DataTable structure for user data
        /// </summary>
        private DataTable CreateUserDataTable()
        {
            var dataTable = new DataTable();
            dataTable.Columns.Add("Id", typeof(int));
            dataTable.Columns.Add("FirstName", typeof(string));
            dataTable.Columns.Add("LastName", typeof(string));
            dataTable.Columns.Add("Username", typeof(string));
            dataTable.Columns.Add("MobileNumber", typeof(string));
            dataTable.Columns.Add("DateOfBirth", typeof(DateTime));
            dataTable.Columns.Add("Email", typeof(string));
            dataTable.Columns.Add("Password", typeof(string));
            dataTable.Columns.Add("Address", typeof(string));
            dataTable.Columns.Add("CreatedDate", typeof(DateTime));
            dataTable.Columns.Add("softDeleteDate", typeof(DateTime));
            dataTable.Columns.Add("isDeleted", typeof(bool));

            return dataTable;
        }

        /// <summary>
        /// Refreshes the user data displayed in the StaffTable with consistent column order.
        /// </summary>
        public void RefreshUserData()
        {
            try
            {
                dataContext.ChangeTracker.Clear();
                var users = from user in dataContext.User
                            where !user.isDeleted // Only select non-deleted members
                            select user;

                // Use the same DataTable creation method for consistency
                var dataTable = CreateUserDataTable();

                foreach (var user in users)
                {
                    dataTable.Rows.Add(
                        user.Id,
                        user.FirstName,
                        user.LastName,
                        user.Username,           // Fixed: Consistent column order
                        user.MobileNumber,
                        user.DateOfBirth,
                        user.Email,              // Fixed: Consistent column order
                        user.Password,
                        user.Address,            // Fixed: Consistent column order
                        user.CreatedDate,
                        user.softDeleteDate,
                        user.isDeleted
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
    }
}
