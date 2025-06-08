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

            // Prevent resizing, but allow moving
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ControlBox = true;
            this.StartPosition = FormStartPosition.CenterScreen;
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
            this.Close(); // closes form
        }

        private void cuiButton2_Click(object sender, EventArgs e)
        {
            this.Close(); // closes form
        }
    }
}
