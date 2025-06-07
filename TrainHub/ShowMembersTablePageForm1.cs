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
    public partial class ShowMembersTablePageForm1 : Form
    {
        public ShowMembersTablePageForm1()
        {
            InitializeComponent();

            // Lock window size and controls
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ControlBox = true;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        // Prevent the form from being dragged
        protected override void WndProc(ref Message m)
        {
            const int WM_NCLBUTTONDOWN = 0xA1;
            const int HTCAPTION = 0x2;

            if (m.Msg == WM_NCLBUTTONDOWN && m.WParam.ToInt32() == HTCAPTION)
                return;

            base.WndProc(ref m);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cuiButtonGroup4_Click(object sender, EventArgs e)
        {

        }

        private void cuiButtonGroup2_Click(object sender, EventArgs e)
        {
            RegisterNewMember f1 = new RegisterNewMember();
            f1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EditMemberForm1 f2 = new EditMemberForm1();
            f2.ShowDialog();
        }
    }
}
