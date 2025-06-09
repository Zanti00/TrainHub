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
        }

        private void staffBtn_Click(object sender, EventArgs e)
        {
            staffContainerExpand.Start();
        }

        private void settingBtn_Click(object sender, EventArgs e)
        {
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
