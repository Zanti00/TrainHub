using CuoreUI.Controls.Charts;
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
    public partial class Dashboard : Form
    {
        private TrainHubContext dataContext;
        public Dashboard()
        {
            InitializeComponent();
            dataContext = new TrainHubContext();

            advancedDataGridView1.CellFormatting += advancedDataGridView1_CellFormatting;
        }

       
        private void LoadSubscriptionChartFromDatabase()
        {
            try
            {
                // Query counts per membership type
                int monthlyCount = dataContext.Member.Count(m =>
                    !m.IsDeleted && m.MembershipType == "Monthly");

                int quarterlyCount = dataContext.Member.Count(m =>
                    !m.IsDeleted && m.MembershipType == "Quarterly");

                int yearlyCount = dataContext.Member.Count(m =>
                    !m.IsDeleted && m.MembershipType == "Yearly");

                // Assign to the chart
                cuiChartLine2.CustomXAxis = new string[] { "Monthly", "Quarterly", "Yearly" };
                cuiChartLine2.DataPoints = new float[]
                {
            monthlyCount,
            quarterlyCount,
            yearlyCount
                };

                // Refresh the chart (optional)
                cuiChartLine2.Invalidate();
                cuiChartLine2.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading subscription chart: {ex.Message}", "Chart Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void RefreshNearlyExpiredMembers()
        {
            try
            {
                dataContext.ChangeTracker.Clear();



                DateTime today = DateTime.Today;
                DateTime sevenDaysFromNow = today.AddDays(7);


                var nearlyExpiredMembers = from member in dataContext.Member
                                           where !member.IsDeleted &&
                                                member.ExpiryDate.HasValue &&
                                                member.ExpiryDate.Value >= today &&
                                                member.ExpiryDate.Value <= sevenDaysFromNow &&
                                                 member.Status == "Active"
                                           orderby member.ExpiryDate ascending
                                           select member;

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
                dataTable.Columns.Add("ExpiryDate", typeof(DateTime));
                dataTable.Columns.Add("DaysToExpiry", typeof(int));


                foreach (var member in nearlyExpiredMembers)
                {
                    int daysToExpiry = (member.ExpiryDate.Value - DateTime.Today).Days;

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
                         member.ExpiryDate.Value,
                         daysToExpiry
                     );


                }

                this.memberBindingSource.DataSource = dataTable;
                advancedDataGridView1.DataSource = memberBindingSource;

                this.Text = $"Nearly Expired Members ({dataTable.Rows.Count})";
                label6.Text = dataTable.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading nearly expired member data: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





        private void advancedDataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Color-code the "DaysToExpiry" column based on urgency
            if (e.ColumnIndex == 12 && e.Value != null)
            {
                int daysToExpiry = Convert.ToInt32(e.Value);

                if (daysToExpiry <= 7)
                {
                    // Very urgent - expires in 3 days or less
                    e.CellStyle.BackColor = Color.LightCoral;
                    e.CellStyle.ForeColor = Color.DarkRed;

                }

                else if (daysToExpiry < 0)
                {
                    // Already expired (shouldn't appear in this view, but just in case)
                    e.CellStyle.BackColor = Color.Red;
                    e.CellStyle.ForeColor = Color.White;

                }
            }
            if (e.ColumnIndex == 14 && e.Value != null)
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
            }
        }



        private void cuiPanel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void searchBar_ContentChanged(object sender, EventArgs e)
        {
            string memberName = searchBar.Content.Trim();

            try
            {
                if (!string.IsNullOrEmpty(memberName))
                {
                    // Calculate the date range for "nearly expired" members
                    dataContext.ChangeTracker.Clear();

                    DateTime today = DateTime.Today;
                    DateTime sevenDaysFromToday = today.AddDays(7);

                    var nearlyExpiredMembers = from member in dataContext.Member
                                               where !member.IsDeleted &&
                                                     member.ExpiryDate.HasValue &&
                                                     member.ExpiryDate.Value >= today &&
                                                     member.ExpiryDate.Value <= sevenDaysFromToday &&
                                                     member.Status == "Active" &&
                                                     (member.FirstName.ToLower().Contains(memberName.ToLower()) ||
                                                      member.LastName.ToLower().Contains(memberName.ToLower()))
                                               orderby member.ExpiryDate ascending
                                               select member;

                    // Create DataTable with the same structure
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
                    dataTable.Columns.Add("ExpiryDate", typeof(DateTime));
                    dataTable.Columns.Add("DaysToExpiry", typeof(int));


                    // Add filtered members to the DataTable
                    foreach (var member in nearlyExpiredMembers)
                    {
                        int daysToExpiry = (member.ExpiryDate.Value - today).Days;

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
                         member.ExpiryDate.Value,
                         daysToExpiry
                     );
                    }

                    // Update the grid with filtered data
                    this.memberBindingSource.DataSource = dataTable;
                    advancedDataGridView1.DataSource = memberBindingSource;


                    label6.Text = dataTable.Rows.Count.ToString();
                }
                else
                {
                    // If search is empty, show all nearly expired members
                    RefreshNearlyExpiredMembers();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching member data: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Dashboard_Load_1(object sender, EventArgs e)
        {
            RefreshNearlyExpiredMembers();
            LoadSubscriptionChartFromDatabase();
        }

        private void cuiChartLine1_Load(object sender, EventArgs e)
        {

        }

        private void cuiChartLine2_Load(object sender, EventArgs e)
        {

        }

        private void customBackButton1_Load(object sender, EventArgs e)
        {

        }

        private void cuiChartLine2_Load_1(object sender, EventArgs e)
        {
            
        }
    }
}
