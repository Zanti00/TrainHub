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
                int memberID = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells[0].Value);
                EditMemberForm1 editForm = new EditMemberForm1(memberID, this);
                editForm.ShowDialog();
            }

            if (e.ColumnIndex == 14 && e.RowIndex >= 0)
            {
                // Confirm deletion
                var result = MessageBox.Show($"Are you sure you want to delete member {dataGridView2.Rows[e.RowIndex].Cells[1].Value} {dataGridView2.Rows[e.RowIndex].Cells[2].Value}?", "Confirm Deletion",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        // Get the selected member's ID
                        int memberId = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells[0].Value);
                        var memberToDelete = dataContext.Member.Find(memberId);
                        if (memberToDelete != null)
                        {
                            dataContext.Member.Remove(memberToDelete);
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

        private void ShowMembersTablePageForm1_Load(object sender, EventArgs e)
        {
            RefreshMemberData();
        }

        // Public method to refresh the DataGridView
        public void RefreshMemberData()
        {
            try
            {
                dataContext.ChangeTracker.Clear(); // Clear the change tracker to avoid stale data
                var members = from member in dataContext.Member
                              select member;
                dataGridView2.DataSource = members.ToList();
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
                    dataGridView2.DataSource = members.ToList();
                }
                else
                {
                    // If search is empty, show all members
                    RefreshMemberData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching member data: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
