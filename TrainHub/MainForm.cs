using System.Windows.Forms;
using System.Data.SqlClient;

namespace TrainHub
{
    public partial class MainForm : Form
    {
        bool isTrainerContainerExpanded = false;
        bool isMemberContainerExpanded = false;
        bool isStaffContainerExpanded = false;
        Dashboard dashboard;
        ShowMembersTablePageForm1 memberPage;
        Login login;
        public MainForm()
        {
            InitializeComponent();
            usernameTxt.Text = CurrentUser.Username;
        }

        private void trainerContainerExpand_Tick(object sender, EventArgs e)
        {
            if (isTrainerContainerExpanded == false)
            {
                trainerContainer.Height += 30;
                if (trainerContainer.Height >= 60)
                {
                    trainerContainerExpand.Stop();
                    isTrainerContainerExpanded = true;
                }
            }
            else
            {
                trainerContainer.Height -= 30;
                if (trainerContainer.Height <= 30)
                {
                    trainerContainerExpand.Stop();
                    isTrainerContainerExpanded = false;
                }
            }
        }

        private void memberContainerExpand_Tick(object sender, EventArgs e)
        {
            if (isMemberContainerExpanded == false)
            {
                memberContainer.Height += 30;
                if (memberContainer.Height >= 60)
                {
                    memberContainerExpand.Stop();
                    isMemberContainerExpanded = true;
                }
            }
            else
            {
                memberContainer.Height -= 30;
                if (memberContainer.Height <= 30)
                {
                    memberContainerExpand.Stop();
                    isMemberContainerExpanded = false;
                }
            }
        }

        private void staffContainerExpand_Tick(object sender, EventArgs e)
        {
            if (isStaffContainerExpanded == false)
            {
                staffContainer.Height += 30;
                if (staffContainer.Height >= 60)
                {
                    staffContainerExpand.Stop();
                    isStaffContainerExpanded = true;
                }
            }
            else
            {
                staffContainer.Height -= 30;
                if (staffContainer.Height <= 30)
                {
                    staffContainerExpand.Stop();
                    isStaffContainerExpanded = false;
                }
            }
        }

        private void trainerBtn_Click(object sender, EventArgs e)
        {
            trainerContainerExpand.Start();
        }

        private void memberBtn_Click(object sender, EventArgs e)
        {
            memberContainerExpand.Start();

            if (memberPage == null)
            {
                memberPage = new ShowMembersTablePageForm1();
                memberPage.FormClosed += member_FormClosed;
                memberPage.MdiParent = this;
                memberPage.Dock = DockStyle.Fill;
                memberPage.Show();
            }
            else
            {
                memberPage.Activate();
            }
            changeBtnNormalBackground("memberBtn");

        }

        private void changeBtnNormalBackground(string btnName)
        {
            dashboardBtn.NormalBackground = Color.FromArgb(50, 81, 88);
            trainerBtn.NormalBackground = Color.FromArgb(50, 81, 88);
            memberBtn.NormalBackground = Color.FromArgb(50, 81, 88);
            staffBtn.NormalBackground = Color.FromArgb(50, 81, 88);
            settingBtn.NormalBackground = Color.FromArgb(50, 81, 88);

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
            else
                settingBtn.NormalBackground = Color.FromArgb(45, 47, 57);

        }

        private void member_FormClosed(object? sender, FormClosedEventArgs e)
        {
            memberPage = null;
        }

        private void staffBtn_Click(object sender, EventArgs e)
        {
            staffContainerExpand.Start();

            changeBtnNormalBackground("staffBtn");
        }

        private void settingBtn_Click(object sender, EventArgs e)
        {
            changeBtnNormalBackground("settingBtn");
        }

        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            if (dashboard == null)
            {
                dashboard = new Dashboard();

                dashboard.FormClosed += Dashboard_FormClosed;
                dashboard.MdiParent = this;
                dashboard.Dock = DockStyle.Fill;
                dashboard.Show();
            }
            else
            {
                dashboard.Activate();
            }

            changeBtnNormalBackground("dashboardBtn");
        }

        private void Dashboard_FormClosed(object? sender, FormClosedEventArgs e)
        {
            dashboard = null;
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
