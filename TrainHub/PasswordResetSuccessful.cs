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
    public partial class PasswordResetSuccessful : Form
    {
        public PasswordResetSuccessful()
        {
            InitializeComponent();
            continueBtn.ButtonContent = "CONTINUE";
            continueBtn.ButtonClicked += continueBtn_Click;
        }

        private void continueBtn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }
    }
}
