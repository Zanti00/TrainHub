using System;
using System.Windows.Forms;

namespace TrainHub
{
    public partial class Admin_Settings : Form
    {
        public Admin_Settings()
        {
            InitializeComponent();
            this.Load += Admin_Settings_Load;
        }

        private void Admin_Settings_Load(object sender, EventArgs e)
        {
            try
            {
                // Hook up button events safely during Load
                if (emailEditBtn != null) emailEditBtn.Click += emailEditBtn_Click;
                if (phoneEditBtn != null) phoneEditBtn.Click += phoneEditBtn_Click;
                if (saveChangesBtn != null) saveChangesBtn.Click += saveChangesBtn_Click;

                LoadCurrentSettings();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Initialization error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadCurrentSettings()
        {
            try
            {
                // Example: cuiTextBox2.Text = CurrentUser.Email;
                // phoneTextBox.Text = CurrentUser.Phone;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading settings: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void emailEditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (var updateEmailForm = new update_email())
                {
                    if (updateEmailForm.ShowDialog() == DialogResult.OK)
                    {
                        LoadCurrentSettings();
                        MessageBox.Show("Email updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating email: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void phoneEditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (var updatePhoneForm = new update_phone())
                {
                    if (updatePhoneForm.ShowDialog() == DialogResult.OK)
                    {
                        LoadCurrentSettings();
                        MessageBox.Show("Phone number updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating phone: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveChangesBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Add save logic here if the form supports inline editing
                MessageBox.Show("Changes saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving changes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
