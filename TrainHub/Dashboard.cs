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
using TrainHub.Static_Classes;

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
            LoadLabels();
        }

        public void LoadLabels()
        {
            welcomeLabel.Text = $"Welcome back, {CurrentUser.Username ?? "User"}!";
            nearlyExpiredMembersLbl.Text = LoadTotalLabels.LoadTotalNearlyExpiredMembers().ToString();
            totalMemberTodayLbl.Text = LoadTotalLabels.LoadMemberAttendanceToday().ToString();
            totalTrainerTodayLbl.Text = LoadTotalLabels.LoadTrainerAttendanceToday().ToString();
        }
        public void LoadSubscriptionChartFromDatabase()
        {
            try
            {
                int monthlyCount = dataContext.Member.Count(m =>
                    !m.IsDeleted && m.MembershipType == "Monthly");

                int quarterlyCount = dataContext.Member.Count(m =>
                    !m.IsDeleted && m.MembershipType == "Quarterly");

                int yearlyCount = dataContext.Member.Count(m =>
                    !m.IsDeleted && m.MembershipType == "Yearly");

                subscriptionChartLine.DataPoints = new float[]
                {
                    monthlyCount,
                    quarterlyCount,
                    yearlyCount
                };

                subscriptionChartLine.Invalidate();
                subscriptionChartLine.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading subscription chart: {ex.Message}", "Chart Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DataTable CreateNearlyExpiredMembersDataTable()
        {
            var dataTable = new DataTable();
            dataTable.Columns.Add("Id", typeof(int));
            dataTable.Columns.Add("FirstName", typeof(string));
            dataTable.Columns.Add("LastName", typeof(string));
            dataTable.Columns.Add("Gender", typeof(string));
            dataTable.Columns.Add("Email", typeof(string));
            dataTable.Columns.Add("PhoneNumber", typeof(string));
            dataTable.Columns.Add("DateOfBirth", typeof(DateTime));
            dataTable.Columns.Add("StartDate", typeof(DateTime));
            dataTable.Columns.Add("EndDate", typeof(DateTime));
            dataTable.Columns.Add("CreatedDate", typeof(DateTime));
            dataTable.Columns.Add("Status", typeof(string));
            dataTable.Columns.Add("MembershipType", typeof(string));

            return dataTable;
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

                var dataTable = CreateNearlyExpiredMembersDataTable();

                foreach (var member in members)
                {
                    dataTable.Rows.Add(
                         member.Id,
                         member.FirstName,
                         member.LastName,
                         member.Gender,
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
                nearlyExpiredMembersLbl.Text = dataTable.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading nearly expired member data: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void advancedDataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
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

                    var dataTable = CreateNearlyExpiredMembersDataTable();

                    foreach (var member in members)
                    {
                        dataTable.Rows.Add(
                             member.Id,
                             member.FirstName,
                             member.LastName,
                             member.Gender,
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


                    nearlyExpiredMembersLbl.Text = dataTable.Rows.Count.ToString();
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
            LoadLabels();
            RefreshNearlyExpiredMembers();
            LoadSubscriptionChartFromDatabase();
        }
    }
}
