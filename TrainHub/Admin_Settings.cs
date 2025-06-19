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
    public partial class Admin_Settings : Form
    {
        public Admin_Settings()
        {
            InitializeComponent();
            // Hook up the button click events
            emailEditBtn.Click += emailEditBtn_Click;
            phoneEditBtn.Click += phoneEditBtn_Click;
            passwordEditBtn.Click += passwordEditBtn_Click;
        }
        private void emailEditBtn_Click(object sender, EventArgs e)
        {
            update_email updateEmailForm = new update_email();
            updateEmailForm.ShowDialog();
        }
        private void phoneEditBtn_Click(object sender, EventArgs e)
        {
            update_phone updatePhoneForm = new update_phone();
            updatePhoneForm.ShowDialog();
        }
        private void passwordEditBtn_Click(object sender, EventArgs e)
        {
            change_password changePasswordForm = new change_password();
            changePasswordForm.ShowDialog();
        }
    }
}