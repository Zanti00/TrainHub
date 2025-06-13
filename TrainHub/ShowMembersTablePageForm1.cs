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

namespace TrainHub
{
    public partial class ShowMembersTablePageForm1 : Form
    {
        private TrainHubContext dataContext;
        public ShowMembersTablePageForm1()
        {
            InitializeComponent();
            // make the form full screen
            this.WindowState = FormWindowState.Maximized;
            dataContext = new TrainHubContext();

            advancedDataGridView1.CellFormatting += advancedDataGridView1_CellFormatting;
        }

        private void cuiButtonGroup2_Click(object sender, EventArgs e)
        {
            RegisterNewMember registerNewMember = new RegisterNewMember(this);
            registerNewMember.ShowDialog();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 13 && e.RowIndex >= 0)
            {
                int memberID = Convert.ToInt32(advancedDataGridView1.Rows[e.RowIndex].Cells[0].Value);
                EditMemberForm1 editForm = new EditMemberForm1(memberID, this);
                editForm.ShowDialog();
            }

            if (e.ColumnIndex == 14 && e.RowIndex >= 0)
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
            // Check if this is column 11 (Status column) and has a value
            if (e.ColumnIndex == 11 && e.Value != null)
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

        private void ShowMembersTablePageForm1_Load(object sender, EventArgs e)
        {
            RefreshMemberData();
        }
        public void RefreshMemberData()
        {
            try
            {
                dataContext.ChangeTracker.Clear();
                var members = from member in dataContext.Member
                              where !member.IsDeleted // Only select non-deleted members
                              select member;

                // Convert to DataTable for sorting/filtering support
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
                        member.MembershipType
                    );
                }

                this.memberBindingSource.DataSource = dataTable;
                advancedDataGridView1.DataSource = memberBindingSource;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading member data: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Clean up resources
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            dataContext?.Dispose();
            base.OnFormClosed(e);
        }

        private void searchBar_ContentChanged(object sender, EventArgs e)
        {
            string memberName = searchBar.Content.Trim();

            try
            {
                if (!string.IsNullOrEmpty(memberName))
                {
                    // Select complete member objects, not just names
                    var members = from member in dataContext.Member
                                  where member.FirstName.ToLower().Contains(memberName.ToLower()) ||
                                        member.LastName.ToLower().Contains(memberName.ToLower())
                                  select member;
                    // Convert to DataTable for sorting/filtering support
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
                            member.MembershipType
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
    }
}
