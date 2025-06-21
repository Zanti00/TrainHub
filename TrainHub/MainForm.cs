using System.Windows.Forms;
using System.Data.SqlClient;

namespace TrainHub
{
    public partial class MainForm : Form
    {
        bool isTrainerContainerExpanded = false;
        bool isMemberContainerExpanded = false;
        bool isStaffContainerExpanded = false;
        Dashboar dashboar;
        ShowMembersTablePageForm1 memberPage;
        table_trainer trainerPage;
        Login login;
        public MainForm()
        {
            InitializeComponent();
            usernameTxt.Text = CurrentUser.Username;
        }

        private void trainerBtn_Click(object sender, EventArgs e)
        {
            if (trainerPage == null) 
            {
                trainerPage = new table_trainer();
                trainerPage.FormClosed += trainer_FormClosed;
                trainerPage.MdiParent = this;
                trainerPage.Dock = DockStyle.Fill;
                trainerPage.Show();
            }
            else
            {
                trainerPage.Activate();
            }
            changeBtnNormalBackground("trainerBtn");
        }

        private void memberBtn_Click(object sender, EventArgs e)
        {
            

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

        private void trainer_FormClosed(object? sender, FormClosedEventArgs e)
        {
            trainerPage = null;
        }

        private void staffBtn_Click(object sender, EventArgs e)
        {

            changeBtnNormalBackground("staffBtn");
        }

        private void settingBtn_Click(object sender, EventArgs e)
        {
            changeBtnNormalBackground("settingBtn");
        }

        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            if (dashboar == null)
            {
                dashboar = new Dashboar();

                dashboar.FormClosed += Dashboard_FormClosed;
                dashboar.MdiParent = this;
                dashboar.Dock = DockStyle.Fill;
                dashboar.Show();
            }
            else
            {
                dashboar.Activate();
            }

            changeBtnNormalBackground("dashboardBtn");
        }

        private void Dashboard_FormClosed(object? sender, FormClosedEventArgs e)
        {
            dashboar = null;
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
