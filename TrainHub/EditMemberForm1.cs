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
    public partial class EditMemberForm1 : Form
    {
        public EditMemberForm1()
        {
            InitializeComponent();

            // Prevent resizing
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ControlBox = true;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void cuiButton2_Click(object sender, EventArgs e)
        {
            this.Hide(); // to hide current form
            ShowMembersTablePageForm1 f2 = new ShowMembersTablePageForm1();
            f2.ShowDialog();
            this.Show();
        }

        private void cuiButtonGroup1_Click(object sender, EventArgs e)
        {
            this.Hide(); // to hide current form
            ShowMembersTablePageForm1 f3 = new ShowMembersTablePageForm1();
            f3.ShowDialog();
            this.Show();
        }
    }
}