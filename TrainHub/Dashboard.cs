using CuoreUI.Controls.Charts;
using Microsoft.EntityFrameworkCore;
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

namespace TrainHub
{
    public partial class Dashboard : Form
    {
        private TrainHubContext dataContext;
        public Dashboard()
        {
            InitializeComponent();
            dataContext = new TrainHubContext();

            nearlyExpiredMembersAdvancedDataGridView1.CellFormatting += advancedDataGridView1_CellFormatting;
            memberAttendanceLabel.Text = DateTime.Today.ToString("MMMM dd, yyyy");
            trainerAttendanceLabel.Text = DateTime.Today.ToString("MMMM dd, yyyy");
            welcomeLabel.Text = $"Welcome back, {dataContext.User.FirstOrDefault()?.FirstName ?? "User"}!";
        }


        public void LoadSubscriptionChartFromDatabase()
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
                DateTime sevenDaysFromToday = today.AddDays(7);

                var members = from member in dataContext.Member
                              where !member.IsDeleted &&
                                   member.EndDate.Date >= today &&
                                   member.EndDate.Date <= sevenDaysFromToday &&
                                   member.Status == "Active"
                              orderby member.EndDate ascending
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
                         member.Status,
                         member.MembershipType
                     );

                }

                this.memberBindingSource.DataSource = dataTable;
                nearlyExpiredMembersAdvancedDataGridView1.DataSource = memberBindingSource;

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

                    var members = from member in dataContext.Member
                                  where !member.IsDeleted &&
                                       (member.FirstName.ToLower().Contains(memberName.ToLower()) ||
                                       member.LastName.ToLower().Contains(memberName.ToLower())) &&
                                       member.EndDate.Date >= today &&
                                       member.EndDate.Date <= sevenDaysFromToday &&
                                       member.Status == "Active"
                                  orderby member.EndDate ascending
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
                             member.Status,
                             member.MembershipType
                         );
                    }

                    // Update the grid with filtered data
                    this.memberBindingSource.DataSource = dataTable;
                    nearlyExpiredMembersAdvancedDataGridView1.DataSource = memberBindingSource;


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
            RefreshMemberAttendanceGrid();
            RefreshTrainerAttendanceGrid();
        }

        private void scanQrBtn_Click(object sender, EventArgs e)
        {
            ReadQRForm readQRForm = new ReadQRForm(this);
            readQRForm.ShowDialog();
        }

        public void RefreshMemberAttendanceGrid()
        {
            using (var dataContext = new TrainHubContext())
            {
                var memberAttendanceData = dataContext.MemberAttendances
                    .Include(a => a.Member)
                    .Where(a => !a.IsDeleted && a.AttendanceDate == DateTime.Today)
                    .OrderByDescending(a => a.AttendanceDate)
                    .ThenByDescending(a => a.CheckInTime)
                    .ToList();

                memberAttendanceBindingSource.DataSource = ConvertToDataMemberTable(memberAttendanceData);
                memberAttendanceDataGridView.DataSource = memberAttendanceBindingSource;
            }
        }

        public void RefreshTrainerAttendanceGrid()
        {
            using (var dataContext = new TrainHubContext())
            {
                var trainerAttendanceData = dataContext.TrainerAttendances
                    .Include(a => a.Trainer)
                    .Where(a => !a.IsDeleted && a.AttendanceDate == DateTime.Today)
                    .OrderByDescending(a => a.AttendanceDate)
                    .ThenByDescending(a => a.CheckInTime)
                    .ToList();

                trainerAttendanceBindingSource.DataSource = ConvertToDataTrainerTable(trainerAttendanceData);
                trainerAttendanceDataGridView.DataSource = trainerAttendanceBindingSource;
            }
        }

        private DataTable ConvertToDataMemberTable(IEnumerable<MemberAttendances> memberAttendanceData)
        {
            var dataTable = CreateMemberAttendanceDataTable();

            foreach (var attendance in memberAttendanceData)
            {
                dataTable.Rows.Add(
                    attendance.Id,
                    attendance.Member?.Id ?? 0,
                    attendance.Member?.FirstName ?? "",
                    attendance.Member?.LastName ?? "",
                    attendance.Member?.Email ?? "",
                    attendance.Member?.PhoneNumber ?? "",
                    attendance.Member?.Status ?? "",
                    attendance.Member?.MembershipType ?? "",
                    attendance.AttendanceDate,
                    attendance.Member?.StartDate ?? DateTime.MinValue,
                    attendance.Member?.EndDate ?? DateTime.MinValue,
                    attendance.CheckInTime?.ToString(@"hh\:mm") ?? "",
                    attendance.CheckOutTime?.ToString(@"hh\:mm") ?? ""
                );
            }

            return dataTable;
        }

        private DataTable ConvertToDataTrainerTable(IEnumerable<TrainerAttendances> trainerAttendanceData)
        {
            var dataTable = CreateTrainerAttendanceDataTable();

            foreach (var attendance in trainerAttendanceData)
            {
                dataTable.Rows.Add(
                    attendance.Id,
                    attendance.Trainer?.Id ?? 0,
                    attendance.Trainer?.FirstName ?? "",
                    attendance.Trainer?.LastName ?? "",
                    attendance.Trainer?.Gender ?? "",
                    attendance.Trainer?.Email ?? "",
                    attendance.Trainer?.PhoneNumber ?? "",
                    attendance.Trainer?.Address ?? "",
                    attendance.Trainer?.Status ?? "",
                    attendance.Trainer?.Availability ?? "",
                    attendance.AttendanceDate,
                    attendance.Trainer?.CreatedDate ?? DateTime.MinValue,
                    attendance.CheckInTime?.ToString(@"hh\:mm") ?? "",
                    attendance.CheckOutTime?.ToString(@"hh\:mm") ?? ""
                );
            }

            return dataTable;
        }

        private DataTable CreateMemberAttendanceDataTable()
        {
            var dataTable = new DataTable();
            dataTable.Columns.Add("Id", typeof(int));
            dataTable.Columns.Add("MemberId", typeof(int));
            dataTable.Columns.Add("FirstName", typeof(string));
            dataTable.Columns.Add("LastName", typeof(string));
            dataTable.Columns.Add("Email", typeof(string));
            dataTable.Columns.Add("PhoneNumber", typeof(string));
            dataTable.Columns.Add("Status", typeof(string));
            dataTable.Columns.Add("MembershipType", typeof(string));
            dataTable.Columns.Add("AttendanceDate", typeof(DateTime));
            dataTable.Columns.Add("StartDate", typeof(DateTime));
            dataTable.Columns.Add("EndDate", typeof(DateTime));
            dataTable.Columns.Add("CheckInTime", typeof(string));
            dataTable.Columns.Add("CheckOutTime", typeof(string));

            return dataTable;
        }

        private DataTable CreateTrainerAttendanceDataTable()
        {
            var dataTable = new DataTable();
            dataTable.Columns.Add("Id", typeof(int));
            dataTable.Columns.Add("TrainerId", typeof(int));
            dataTable.Columns.Add("FirstName", typeof(string));
            dataTable.Columns.Add("LastName", typeof(string));
            dataTable.Columns.Add("Gender", typeof(string));
            dataTable.Columns.Add("Email", typeof(string));
            dataTable.Columns.Add("PhoneNumber", typeof(string));
            dataTable.Columns.Add("Address", typeof(string));
            dataTable.Columns.Add("Status", typeof(string));
            dataTable.Columns.Add("Availability", typeof(string));
            dataTable.Columns.Add("AttendanceDate", typeof(DateTime));
            dataTable.Columns.Add("HireDate", typeof(DateTime));
            dataTable.Columns.Add("CheckInTime", typeof(string));
            dataTable.Columns.Add("CheckOutTime", typeof(string));

            return dataTable;
        }

        private void searchBarMemberAttendance_ContentChanged(object sender, EventArgs e)
        {
            string memberName = searchBarMemberAttendance.Content.Trim();

            try
            {
                if (!string.IsNullOrEmpty(memberName))
                {
                    using (var searchContext = new TrainHubContext())
                    {
                        // Include the Member navigation property and filter by today's attendance
                        var attendanceData = searchContext.MemberAttendances
                            .Include(a => a.Member)
                            .Where(a => !a.IsDeleted &&
                                       a.AttendanceDate == DateTime.Today &&
                                       (a.Member.FirstName.ToLower().Contains(memberName.ToLower()) ||
                                        a.Member.LastName.ToLower().Contains(memberName.ToLower())))
                            .OrderByDescending(a => a.AttendanceDate)
                            .ThenByDescending(a => a.CheckInTime)
                            .ToList();

                        // Convert to DataTable for sorting/filtering support

                        memberAttendanceBindingSource.DataSource = ConvertToDataMemberTable(attendanceData); ;
                        memberAttendanceDataGridView.DataSource = memberAttendanceBindingSource;

                    }
                }
                else
                {
                    // If search is empty, show all members
                    RefreshMemberAttendanceGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching member data: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void searchBarTrainerAttendance_ContentChanged(object sender, EventArgs e)
        {
            string trainerName = searchBarTrainerAttendance.Content.Trim();

            try
            {
                if (!string.IsNullOrEmpty(trainerName))
                {
                    using (var searchContext = new TrainHubContext())
                    {
                        // Include the Member navigation property and filter by today's attendance
                        var attendanceData = searchContext.TrainerAttendances
                            .Include(a => a.Trainer)
                            .Where(a => !a.IsDeleted &&
                                       a.AttendanceDate == DateTime.Today &&
                                       (a.Trainer.FirstName.ToLower().Contains(trainerName.ToLower()) ||
                                        a.Trainer.LastName.ToLower().Contains(trainerName.ToLower())))
                            .OrderByDescending(a => a.AttendanceDate)
                            .ThenByDescending(a => a.CheckInTime)
                            .ToList();

                        // Convert to DataTable for sorting/filtering support

                        trainerAttendanceBindingSource.DataSource = ConvertToDataTrainerTable(attendanceData); ;
                        trainerAttendanceDataGridView.DataSource = trainerAttendanceBindingSource;

                    }
                }
                else
                {
                    // If search is empty, show all members
                    RefreshTrainerAttendanceGrid();
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
