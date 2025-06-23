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
using Zuby.ADGV;

namespace TrainHub
{
    public partial class Dashboar : Form
    {
        private TrainHubContext dataContext;
        private BindingSource attendanceBindingSource;
        public Dashboar()
        {
            InitializeComponent();
            dataContext = new TrainHubContext();
            attendanceBindingSource = new BindingSource();

            memberAttendanceLabel.Text = DateTime.Today.ToString("MMMM dd, yyyy");
            trainerAttendanceLabel.Text = DateTime.Today.ToString("MMMM dd, yyyy");
        }

        private void cuiButtonGroup2_Click(object sender, EventArgs e)
        {
            //ReadQRForm readQRForm = new ReadQRForm(this);
            //readQRForm.ShowDialog();
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

        private void Dashboar_Load(object sender, EventArgs e)
        {
            RefreshMemberAttendanceGrid();
            RefreshTrainerAttendanceGrid();
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
