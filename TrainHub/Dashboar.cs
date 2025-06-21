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
        }

        private void cuiButtonGroup2_Click(object sender, EventArgs e)
        {
            ReadQRForm readQRForm = new ReadQRForm(this);
            readQRForm.ShowDialog();
        }

        public void RefreshAttendanceGrid()
        {
            using (var dataContext = new TrainHubContext())
            {
                var attendanceData = dataContext.MemberAttendances
                    .Include(a => a.Member)
                    .Where(a => !a.IsDeleted && a.AttendanceDate == DateTime.Today)
                    .OrderByDescending(a => a.AttendanceDate)
                    .ThenByDescending(a => a.CheckInTime)
                    .ToList();

                attendanceBindingSource.DataSource = ConvertToDataTable(attendanceData);
                attendanceDataGridView.DataSource = attendanceBindingSource;
            }
        }

        private DataTable ConvertToDataTable(IEnumerable<MemberAttendances> attendanceData)
        {
            var dataTable = CreateAttendanceDataTable();

            foreach (var attendance in attendanceData)
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

        private DataTable CreateAttendanceDataTable()
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

        private void Dashboar_Load(object sender, EventArgs e)
        {
            RefreshAttendanceGrid();
        }

        private void searchBarAttendance_ContentChanged(object sender, EventArgs e)
        {
            string memberName = searchBarAttendance.Content.Trim();

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

                        attendanceBindingSource.DataSource = ConvertToDataTable(attendanceData); ;
                        attendanceDataGridView.DataSource = attendanceBindingSource;

                    }
                }
                else
                {
                    // If search is empty, show all members
                    RefreshAttendanceGrid();
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
