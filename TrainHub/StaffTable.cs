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
            SetupDataGridViewButtons();
        }

        /// <summary>
        /// Sets up the Edit and Delete button columns in the DataGridView
        /// </summary>
        private void SetupDataGridViewButtons()
        {
            // Clear existing button columns if they exist
            if (advancedDataGridView1.Columns["EditButton"] != null)
                advancedDataGridView1.Columns.Remove("EditButton");
            if (advancedDataGridView1.Columns["DeleteButton"] != null)
                advancedDataGridView1.Columns.Remove("DeleteButton");

            // Add Edit button column
            DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
            editButtonColumn.Name = "EditButton";
            editButtonColumn.HeaderText = "Edit";
            editButtonColumn.Text = "Edit";
            editButtonColumn.UseColumnTextForButtonValue = true;
            editButtonColumn.Width = 60;
            advancedDataGridView1.Columns.Add(editButtonColumn);

            // Add Delete button column
            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.Name = "DeleteButton";
            deleteButtonColumn.HeaderText = "Delete";
            deleteButtonColumn.Text = "Delete";
            deleteButtonColumn.UseColumnTextForButtonValue = true;
            deleteButtonColumn.Width = 70;
            advancedDataGridView1.Columns.Add(deleteButtonColumn);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Make sure we're clicking on a valid row
            if (e.RowIndex < 0) return;

            // Get the column name to identify which button was clicked
            string columnName = advancedDataGridView1.Columns[e.ColumnIndex].Name;

            switch (columnName)
            {
                case "EditButton":
                    // Edit button clicked
                    int userID = Convert.ToInt32(advancedDataGridView1.Rows[e.RowIndex].Cells["Id"].Value);
                    edit_staff editForm = new edit_staff(userID, this);
                    editForm.ShowDialog();
                    break;

                case "DeleteButton":
                    // Delete button clicked
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this staff member?",
                        "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        int deleteUserID = Convert.ToInt32(advancedDataGridView1.Rows[e.RowIndex].Cells["Id"].Value);
                        DeleteUser(deleteUserID, e.RowIndex);
                    }
                    break;
            }
        }

        /// <summary>
        /// Handles the actual deletion of a user (soft delete)
        /// </summary>
        private void DeleteUser(int userId, int rowIndex)
        {
            try
            {
                var user = dataContext.User.FirstOrDefault(u => u.Id == userId);
                if (user != null)
                {
                    // Perform soft delete
                    user.isDeleted = true;
                    user.softDeleteDate = DateTime.Now;
                    dataContext.SaveChanges();

                    // Remove from display
                    advancedDataGridView1.Rows[rowIndex].Visible = false;

                    MessageBox.Show("Staff member deleted successfully.", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting user: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    advancedDataGridView1.DataSource = userBindingSource;

                    // Re-setup buttons after data binding
                    SetupDataGridViewButtons();
                }
                else
                {
                    // If search is empty, show all users
                    RefreshUserData();
                }
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

                // Setup buttons after data binding
                SetupDataGridViewButtons();

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

        private void cuiPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}