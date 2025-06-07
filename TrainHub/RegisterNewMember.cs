using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainHub
{
    public partial class RegisterNewMember : Form
    {
        public RegisterNewMember()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cuiTextBox1_ContentChanged(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {

        }

        private void cuiComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cuiComboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void RegisterNewMember_Load(object sender, EventArgs e)
        {

        }

        private void cuiButtonGroup1_Click(object sender, EventArgs e)
        {
            this.Hide(); // to hide current form
            ShowMembersTablePageForm1 f2 = new ShowMembersTablePageForm1();
            f2.ShowDialog();
            this.Show();
        }

        private void cuiButton2_Click(object sender, EventArgs e)
        {
            this.Hide(); // to hide current form
            ShowMembersTablePageForm1 f3 = new ShowMembersTablePageForm1();
            f3.ShowDialog();
            this.Show();
        }
    }
}
