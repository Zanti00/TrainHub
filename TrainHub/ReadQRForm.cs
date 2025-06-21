using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ZXing;
using ZXing.Aztec;
using ZXing.QrCode;
using TrainHub.Data;
using TrainHub.Models;
using Microsoft.EntityFrameworkCore;

namespace TrainHub
{
    public partial class ReadQRForm : Form
    {
        private FilterInfoCollection captureDevice;
        private VideoCaptureDevice videoSource;
        private Dashboar _dashboardForm;
        TrainHubContext dataContext = new TrainHubContext();
        public ReadQRForm(Dashboar dashboardForm)
        {
            InitializeComponent();
            _dashboardForm = dashboardForm;
        }

        private void ReadQRForm_Load(object sender, EventArgs e)
        {
            GetVideoDevice();
            OpenCamera();
        }

        private void GetVideoDevice()
        {
            captureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            videoSource = new VideoCaptureDevice();
        }

        private void OpenCamera()
        {
            videoSource = new VideoCaptureDevice(captureDevice[0].MonikerString);
            videoSource.NewFrame += new NewFrameEventHandler(finalFrame_NewFrame);
            videoSource.Start();
        }

        private void StopCamera()
        {
            if (videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource.WaitForStop();
            }
        }

        private void finalFrame_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void ReadQRForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopCamera();
            _dashboardForm.RefreshAttendanceGrid();
        }

        private void readBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (pictureBox1.Image == null)
                {
                    MessageBox.Show("No image to scan.", "QR Code Reader", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var reader = new ZXing.Windows.Compatibility.BarcodeReader();
                Result result = reader.Decode((Bitmap)pictureBox1.Image);

                if (result != null && !string.IsNullOrEmpty(result.Text))
                {
                    // Parse the member ID from QR code
                    if (int.TryParse(result.Text.Trim(), out int memberId))
                    {
                        // Find the member first
                        var member = dataContext.Member
                            .FirstOrDefault(m => m.Id == memberId && !m.IsDeleted);

                        if (member != null)
                        {
                            // Check if member has valid membership
                            if (DateTime.Today >= member.StartDate && DateTime.Today <= member.EndDate)
                            {
                                ViewMember viewMember = new ViewMember(member.Id, this);
                                viewMember.ShowDialog();
                            }
                            else
                            {
                                MessageBox.Show($"Member {member.FirstName} {member.LastName}'s membership has expired or not yet active.\nMembership period: {member.StartDate:MM/dd/yyyy} - {member.EndDate:MM/dd/yyyy}",
                                    "Membership Invalid",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Member not found or has been deleted.",
                                "Member Not Found",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid QR Code format. Expected a member ID.",
                            "Invalid QR Code",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("No QR Code detected.", 
                        "QR Code Reader", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading QR Code: " 
                    + ex.Message, "QR Code Reader", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
        }
        public void AddMemberAttendnace(int memberID)
        {
            var member = dataContext.Member
                            .FirstOrDefault(m => m.Id == memberID && !m.IsDeleted);
            // Create new attendance record
            var attendance = new MemberAttendances
            {
                MemberId = member.Id,
                CheckInTime = DateTime.Now.TimeOfDay,
            };

            // Check if already checked in today
            var existingAttendance = dataContext.MemberAttendances
                .FirstOrDefault(a => a.MemberId == memberID &&
                              a.AttendanceDate.Date == DateTime.Today.Date &&
                              !a.IsDeleted);

            if (existingAttendance == null)
            {

                // Add new attendance
                dataContext.MemberAttendances.Add(attendance);
                dataContext.SaveChanges();

                MessageBox.Show($"Welcome {member.FirstName} {member.LastName}!\nCheck-in successful.",
                    "Attendance Recorded",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                // Refresh the dashboard if needed
                _dashboardForm.RefreshAttendanceGrid();
            }
            else
            {
                MessageBox.Show($"{member.FirstName} {member.LastName} has already checked in today.",
                    "Already Checked In",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }
    }
}