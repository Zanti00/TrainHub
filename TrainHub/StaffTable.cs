using System.Data;
using TrainHub.Data;

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
                DialogResult deleteConfirmationResult = MessageBox.Show("Are you sure you want to delete this staff?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (deleteConfirmationResult == DialogResult.Yes)
                {
                    // Make sure you're not deleting the new row
                    if (!advancedDataGridView1.Rows[e.RowIndex].IsNewRow)
                    {
                        // Get the ID from the hidden ID column
                        int staffId = Convert.ToInt32(advancedDataGridView1.Rows[e.RowIndex].Cells["Id"].Value);

                        // Find the staff in the database and mark as deleted
                        var staffToDelete = dataContext.User.FirstOrDefault(s => s.Id == staffId);
                        if (staffToDelete != null)
                        {
                            staffToDelete.isDeleted = true;
                            dataContext.SaveChanges();

                            // Refresh the DataGridView
                            RefreshUserData();
                        }
                    }
                }
                else if (deleteConfirmationResult == DialogResult.No)
                {
                    // Do nothing, just close the dialog
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
            string userName = searchTextBox.Content.Trim();

            try
            {
                if (!string.IsNullOrEmpty(userName))
                {
                    var users = from user in dataContext.User
                                where user.FirstName.ToLower().Contains(userName.ToLower()) ||
                                      user.LastName.ToLower().Contains(userName.ToLower())
                                select user;

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

                    foreach (var user in users)
                    {
                        dataTable.Rows.Add(
                            user.Id,
                            user.FirstName,
                            user.LastName,
                            user.Email,
                            user.MobileNumber,
                            user.DateOfBirth,
                            user.Address,
                            user.Username,
                            user.Password,
                            user.CreatedDate,
                            user.softDeleteDate,
                            user.isDeleted
                        );
                    }

                    userBindingSource.DataSource = dataTable;
                }
                else
                {
                    // If search is empty, show all users
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

        /// <summary>
        /// Refreshes the user data displayed in the StaffTable.
        /// </summary>
        public void RefreshUserData()
        {
            try
            {
                dataContext.ChangeTracker.Clear();
                var users = from user in dataContext.User
                            where !user.isDeleted // Only select non-deleted members
                            select user;

                // Convert to DataTable for sorting/filtering support
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

                foreach (var user in users)
                {
                    dataTable.Rows.Add(
                        user.Id,
                        user.FirstName,
                        user.LastName,
                        user.Email,
                        user.MobileNumber,
                        user.DateOfBirth,
                        user.Address,
                        user.Username,
                        user.Password,
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
