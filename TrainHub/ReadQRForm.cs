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
        private Dashboard _dashboardForm;
        TrainHubContext dataContext = new TrainHubContext();

        public ReadQRForm(Dashboard dashboardForm)
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
            _dashboardForm.RefreshMemberAttendanceGrid();
            _dashboardForm.RefreshTrainerAttendanceGrid();
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
                    ProcessQRCode(result.Text.Trim());
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

        private void ProcessQRCode(string qrContent)
        {
            try
            {
                if (int.TryParse(qrContent, out int simpleId))
                {
                    var member = dataContext.Member
                        .FirstOrDefault(m => m.Id == simpleId && !m.IsDeleted);

                    if (member != null)
                    {
                        HandleMemberQRCode(member);
                        return;
                    }

                    var trainer = dataContext.Trainer
                        .FirstOrDefault(t => t.Id == simpleId && !t.IsDeleted);

                    if (trainer != null)
                    {
                        HandleTrainerQRCode(trainer);
                        return;
                    }

                    MessageBox.Show("No member or trainer found with this ID.",
                        "Not Found",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                string[] parts = qrContent.Split(':');
                if (parts.Length == 2)
                {
                    string type = parts[0].ToUpper();
                    if (int.TryParse(parts[1], out int id))
                    {
                        switch (type)
                        {
                            case "MEMBER":
                                var member = dataContext.Member
                                    .FirstOrDefault(m => m.Id == id && !m.IsDeleted);
                                if (member != null)
                                {
                                    HandleMemberQRCode(member);
                                }
                                else
                                {
                                    MessageBox.Show("Member not found or has been deleted.",
                                        "Member Not Found",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                                }
                                break;

                            case "TRAINER":
                                var trainer = dataContext.Trainer
                                    .FirstOrDefault(t => t.Id == id && !t.IsDeleted);
                                if (trainer != null)
                                {
                                    HandleTrainerQRCode(trainer);
                                }
                                else
                                {
                                    MessageBox.Show("Trainer not found or has been deleted.",
                                        "Trainer Not Found",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                                }
                                break;

                            default:
                                MessageBox.Show("Invalid QR Code format. Expected format: MEMBER:ID or TRAINER:ID",
                                    "Invalid QR Code",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                                break;
                        }
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error processing QR Code: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void HandleMemberQRCode(Member member)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show($"Error handling member QR code: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void HandleTrainerQRCode(Trainer trainer)
        {
            try
            {
                // Check trainer status
                if (trainer.Status.ToLower() == "active")
                {
                    ViewTrainer viewTrainer = new ViewTrainer(trainer.Id, this);
                    viewTrainer.ShowDialog();
                }
                else
                {
                    MessageBox.Show($"Trainer {trainer.FirstName} {trainer.LastName} is currently {trainer.Status}.",
                        "Trainer Status",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error handling trainer QR code: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        public void RecordTrainerAttendance(int trainerId)
        {
            try
            {
                // Check if trainer already checked in today
                var existingAttendance = dataContext.TrainerAttendances
                    .FirstOrDefault(a => a.TrainerId == trainerId &&
                                  a.AttendanceDate.Date == DateTime.Today.Date &&
                                  !a.IsDeleted);

                if (existingAttendance == null)
                {
                    // Create new trainer attendance record
                    var attendance = new TrainerAttendances
                    {
                        TrainerId = trainerId,
                        CheckInTime = DateTime.Now.TimeOfDay,
                        AttendanceDate = DateTime.Today,
                        IsDeleted = false,
                    };

                    dataContext.TrainerAttendances.Add(attendance);
                    dataContext.SaveChanges();

                    var trainer = dataContext.Trainer.Find(trainerId);
                    MessageBox.Show($"Welcome {trainer.FirstName} {trainer.LastName}!\nTrainer check-in successful.",
                        "Attendance Recorded",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    var trainer = dataContext.Trainer.Find(trainerId);
                    MessageBox.Show($"{trainer.FirstName} {trainer.LastName} has already checked in today.",
                        "Already Checked In",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error recording trainer attendance: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        public void AddMemberAttendnace(int memberID)
        {
            var member = dataContext.Member
                            .FirstOrDefault(m => m.Id == memberID && !m.IsDeleted);

            if (member == null)
            {
                MessageBox.Show("Member not found.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            // Create new attendance record
            var attendance = new MemberAttendances
            {
                MemberId = member.Id,
                CheckInTime = DateTime.Now.TimeOfDay,
                AttendanceDate = DateTime.Today,
                IsDeleted = false,
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
                _dashboardForm.RefreshMemberAttendanceGrid();
                _dashboardForm.RefreshTrainerAttendanceGrid();
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