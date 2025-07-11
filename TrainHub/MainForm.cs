using System.Windows.Forms;
using System.Data.SqlClient;

namespace TrainHub
{
    public partial class MainForm : Form
    {
        Dashboard dashboardPage;
        MemberTablePage memberPage;
        TrainerTablePage trainerPage;
        StaffTablePage staffPage;
        Settings settingsPage;
        Attendance attendancePage;

        public MainForm()
        {
            InitializeComponent();
            usernameTxt.Text = CurrentUser.Username;

            // will only show the staff button to admin
            if (CurrentUser.IsAdmin)
            {
                staffBtn.Visible = true;
            }
        }

        private void trainerBtn_Click(object sender, EventArgs e)
        {
            if (trainerPage == null)
            {
                trainerPage = new TrainerTablePage();
                trainerPage.FormClosed += trainer_FormClosed;
                trainerPage.MdiParent = this;
                trainerPage.Dock = DockStyle.Fill;
                trainerPage.Show();
            }
            else
            {
                trainerPage.Activate();
            }
            trainerPage.RefreshTrainerData();
            changeBtnNormalBackground("trainerBtn");
        }

        private void memberBtn_Click(object sender, EventArgs e)
        {


            if (memberPage == null)
            {
                memberPage = new MemberTablePage();
                memberPage.FormClosed += member_FormClosed;
                memberPage.MdiParent = this;
                memberPage.Dock = DockStyle.Fill;
                memberPage.Show();
            }
            else
            {
                memberPage.Activate();
            }
            memberPage.RefreshMemberData();
            changeBtnNormalBackground("memberBtn");

        }

        private void staffBtn_Click(object sender, EventArgs e)
        {
            if (staffPage == null)
            {
                staffPage = new StaffTablePage();
                staffPage.FormClosed += staff_FormClosed;
                staffPage.MdiParent = this;
                staffPage.Dock = DockStyle.Fill;
                staffPage.Show();
            }
            else
            {
                staffPage.Activate();
            }
            staffPage.RefreshUserData();
            changeBtnNormalBackground("staffBtn");
        }

        private void settingBtn_Click(object sender, EventArgs e)
        {
            if (settingsPage == null)
            {
                settingsPage = new Settings();
                settingsPage.FormClosed += settings_FormClosed;
                settingsPage.MdiParent = this;
                settingsPage.Dock = DockStyle.Fill;
                settingsPage.Show();
            }
            else
            {
                settingsPage.Activate();
            }
            changeBtnNormalBackground("settingBtn");
        }

        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            if (dashboardPage == null)
            {
                dashboardPage = new Dashboard();

                dashboardPage.FormClosed += Dashboard_FormClosed;
                dashboardPage.MdiParent = this;
                dashboardPage.Dock = DockStyle.Fill;
                dashboardPage.Show();
            }
            else
            {
                dashboardPage.Activate();
            }
            dashboardPage.LoadLabels();
            dashboardPage.RefreshNearlyExpiredMembers();
            dashboardPage.LoadSubscriptionChartFromDatabase();
            changeBtnNormalBackground("dashboardBtn");
        }

        private void attendanceBtn_Click(object sender, EventArgs e)
        {
            if (attendancePage == null)
            {
                attendancePage = new Attendance();

                attendancePage.FormClosed += Attendance_FormClosed;
                attendancePage.MdiParent = this;
                attendancePage.Dock = DockStyle.Fill;
                attendancePage.Show();
            }
            else
            {
                attendancePage.Activate();
            }
            changeBtnNormalBackground("attendanceBtn");
        }

        private void changeBtnNormalBackground(string btnName)
        {
            dashboardBtn.NormalBackground = Color.FromArgb(50, 81, 88);
            trainerBtn.NormalBackground = Color.FromArgb(50, 81, 88);
            memberBtn.NormalBackground = Color.FromArgb(50, 81, 88);
            staffBtn.NormalBackground = Color.FromArgb(50, 81, 88);
            settingBtn.NormalBackground = Color.FromArgb(50, 81, 88);
            attendanceBtn.NormalBackground = Color.FromArgb(50, 81, 88);

            if (btnName == "dashboardBtn")
                dashboardBtn.NormalBackground = Color.FromArgb(45, 47, 57);
            else if (btnName == "trainerBtn")
                trainerBtn.NormalBackground = Color.FromArgb(45, 47, 57);
            else if (btnName == "memberBtn")
                memberBtn.NormalBackground = Color.FromArgb(45, 47, 57);
            else if (btnName == "staffBtn")
                staffBtn.NormalBackground = Color.FromArgb(45, 47, 57);
            else if (btnName == "dashboardBtn")
                dashboardBtn.NormalBackground = Color.FromArgb(45, 47, 57);
            else if (btnName == "attendanceBtn")
                attendanceBtn.NormalBackground = Color.FromArgb(45, 47, 57);
            else
                settingBtn.NormalBackground = Color.FromArgb(45, 47, 57);

        }

        private void member_FormClosed(object? sender, FormClosedEventArgs e)
        {
            memberPage = null;
        }

        private void trainer_FormClosed(object? sender, FormClosedEventArgs e)
        {
            trainerPage = null;
        }

        private void staff_FormClosed(object? sender, FormClosedEventArgs e)
        {
            staffPage = null;
        }

        private void settings_FormClosed(object? sender, FormClosedEventArgs e)
        {
            settingsPage = null;
        }

        private void Dashboard_FormClosed(object? sender, FormClosedEventArgs e)
        {
            dashboardPage = null;
        }

        private void Attendance_FormClosed(object? sender, FormClosedEventArgs e)
        {
            attendancePage = null;
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            logoutConfirm logOutConfirm = new logoutConfirm();
            DialogResult result = logOutConfirm.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                Login login = new Login();
                this.Hide();
                login.Show();
            }
        }
    }
}
