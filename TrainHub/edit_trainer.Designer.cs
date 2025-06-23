namespace TrainHub
{
    partial class edit_trainer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(edit_trainer));
            cuiPanel2 = new CuoreUI.Controls.cuiPanel();
            lastNameTxt = new CuoreUI.Controls.cuiTextBox();
            birthDate = new CuoreUI.Controls.cuiCalendarDatePicker();
            doneButton = new CuoreUI.Controls.cuiButton();
            cancelButton = new CuoreUI.Controls.cuiButton();
            addressTxt = new CuoreUI.Controls.cuiTextBox();
            emailTxt = new CuoreUI.Controls.cuiTextBox();
            mobNumTxt = new CuoreUI.Controls.cuiTextBox();
            firstNameTxt = new CuoreUI.Controls.cuiTextBox();
            label1 = new Label();
            cuiPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // cuiPanel2
            // 
            cuiPanel2.BackColor = Color.Transparent;
            cuiPanel2.BackgroundImageLayout = ImageLayout.None;
            cuiPanel2.Controls.Add(lastNameTxt);
            cuiPanel2.Controls.Add(birthDate);
            cuiPanel2.Controls.Add(doneButton);
            cuiPanel2.Controls.Add(cancelButton);
            cuiPanel2.Controls.Add(addressTxt);
            cuiPanel2.Controls.Add(emailTxt);
            cuiPanel2.Controls.Add(mobNumTxt);
            cuiPanel2.Controls.Add(firstNameTxt);
            cuiPanel2.Location = new Point(27, 98);
            cuiPanel2.Name = "cuiPanel2";
            cuiPanel2.OutlineThickness = 1F;
            cuiPanel2.PanelColor = Color.White;
            cuiPanel2.PanelOutlineColor = Color.Black;
            cuiPanel2.Rounding = new Padding(10);
            cuiPanel2.Size = new Size(779, 305);
            cuiPanel2.TabIndex = 6;
            // 
            // lastNameTxt
            // 
            lastNameTxt.BackColor = Color.Transparent;
            lastNameTxt.BackgroundColor = Color.White;
            lastNameTxt.BorderColor = Color.FromArgb(50, 81, 88);
            lastNameTxt.Content = "";
            lastNameTxt.FocusBackgroundColor = Color.White;
            lastNameTxt.FocusBorderColor = Color.FromArgb(50, 81, 88);
            lastNameTxt.FocusImageTint = Color.White;
            lastNameTxt.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lastNameTxt.ForeColor = Color.Black;
            lastNameTxt.Image = null;
            lastNameTxt.ImageExpand = new Point(0, 0);
            lastNameTxt.ImageOffset = new Point(0, 0);
            lastNameTxt.Location = new Point(400, 70);
            lastNameTxt.Margin = new Padding(4);
            lastNameTxt.Multiline = false;
            lastNameTxt.Name = "lastNameTxt";
            lastNameTxt.NormalImageTint = Color.White;
            lastNameTxt.Padding = new Padding(13, 13, 13, 0);
            lastNameTxt.PasswordChar = false;
            lastNameTxt.PlaceholderColor = SystemColors.ScrollBar;
            lastNameTxt.PlaceholderText = "Last Name";
            lastNameTxt.Rounding = new Padding(10);
            lastNameTxt.Size = new Size(343, 38);
            lastNameTxt.TabIndex = 19;
            lastNameTxt.TextOffset = new Size(0, 0);
            lastNameTxt.UnderlinedStyle = false;
            // 
            // birthDate
            // 
            birthDate.EnableThemeChangeButton = true;
            birthDate.Font = new Font("Segoe UI", 9.75F);
            birthDate.ForeColor = Color.Gray;
            birthDate.HoverBackground = Color.FromArgb(50, 128, 128, 128);
            birthDate.HoverOutline = Color.FromArgb(180, 128, 128, 128);
            birthDate.Icon = (Image)resources.GetObject("birthDate.Icon");
            birthDate.IconTint = Color.Gray;
            birthDate.Location = new Point(400, 162);
            birthDate.Margin = new Padding(4, 3, 4, 3);
            birthDate.Name = "birthDate";
            birthDate.NormalBackground = Color.FromArgb(32, 128, 128, 128);
            birthDate.NormalOutline = Color.FromArgb(150, 128, 128, 128);
            birthDate.OutlineThickness = 1.5F;
            birthDate.PressedBackground = Color.FromArgb(80, 128, 128, 128);
            birthDate.PressedOutline = Color.FromArgb(210, 128, 128, 128);
            birthDate.Rounding = 8;
            birthDate.ShowIcon = true;
            birthDate.Size = new Size(343, 38);
            birthDate.TabIndex = 7;
            birthDate.Theme = CuoreUI.Controls.Forms.DatePicker.Themes.Light;
            birthDate.Value = new DateTime(2025, 6, 6, 0, 0, 0, 0);
            // 
            // doneButton
            // 
            doneButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            doneButton.CheckButton = false;
            doneButton.Checked = true;
            doneButton.CheckedBackground = Color.FromArgb(50, 81, 88);
            doneButton.CheckedForeColor = SystemColors.Window;
            doneButton.CheckedImageTint = Color.White;
            doneButton.CheckedOutline = Color.FromArgb(50, 81, 88);
            doneButton.Content = "OK";
            doneButton.DialogResult = DialogResult.None;
            doneButton.Font = new Font("Microsoft Sans Serif", 9.75F);
            doneButton.ForeColor = Color.White;
            doneButton.HoverBackground = Color.FromArgb(22, 36, 39);
            doneButton.HoveredImageTint = Color.White;
            doneButton.HoverForeColor = Color.Black;
            doneButton.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            doneButton.Image = null;
            doneButton.ImageAutoCenter = true;
            doneButton.ImageExpand = new Point(0, 0);
            doneButton.ImageOffset = new Point(0, 0);
            doneButton.Location = new Point(672, 216);
            doneButton.Name = "doneButton";
            doneButton.NormalBackground = Color.FromArgb(50, 81, 88);
            doneButton.NormalForeColor = Color.White;
            doneButton.NormalImageTint = Color.White;
            doneButton.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            doneButton.OutlineThickness = 1F;
            doneButton.PressedBackground = Color.WhiteSmoke;
            doneButton.PressedForeColor = Color.FromArgb(32, 32, 32);
            doneButton.PressedImageTint = Color.White;
            doneButton.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            doneButton.Rounding = new Padding(10);
            doneButton.Size = new Size(71, 32);
            doneButton.TabIndex = 18;
            doneButton.TextAlignment = StringAlignment.Center;
            doneButton.TextOffset = new Point(0, 0);
            doneButton.Click += doneButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cancelButton.CheckButton = false;
            cancelButton.Checked = false;
            cancelButton.CheckedBackground = Color.FromArgb(255, 106, 0);
            cancelButton.CheckedForeColor = Color.White;
            cancelButton.CheckedImageTint = Color.White;
            cancelButton.CheckedOutline = Color.FromArgb(255, 106, 0);
            cancelButton.Content = "Cancel";
            cancelButton.DialogResult = DialogResult.None;
            cancelButton.Font = new Font("Microsoft Sans Serif", 9.75F);
            cancelButton.ForeColor = Color.Black;
            cancelButton.HoverBackground = Color.White;
            cancelButton.HoveredImageTint = Color.White;
            cancelButton.HoverForeColor = Color.Black;
            cancelButton.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            cancelButton.Image = null;
            cancelButton.ImageAutoCenter = true;
            cancelButton.ImageExpand = new Point(0, 0);
            cancelButton.ImageOffset = new Point(0, 0);
            cancelButton.Location = new Point(602, 216);
            cancelButton.Name = "cancelButton";
            cancelButton.NormalBackground = Color.White;
            cancelButton.NormalForeColor = Color.Black;
            cancelButton.NormalImageTint = Color.White;
            cancelButton.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            cancelButton.OutlineThickness = 1F;
            cancelButton.PressedBackground = Color.WhiteSmoke;
            cancelButton.PressedForeColor = Color.FromArgb(32, 32, 32);
            cancelButton.PressedImageTint = Color.White;
            cancelButton.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            cancelButton.Rounding = new Padding(10);
            cancelButton.Size = new Size(64, 32);
            cancelButton.TabIndex = 17;
            cancelButton.TextAlignment = StringAlignment.Center;
            cancelButton.TextOffset = new Point(0, 0);
            cancelButton.Click += cancelButton_Click;
            // 
            // addressTxt
            // 
            addressTxt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            addressTxt.BackColor = Color.Transparent;
            addressTxt.BackgroundColor = Color.White;
            addressTxt.BorderColor = Color.FromArgb(50, 81, 88);
            addressTxt.Content = "";
            addressTxt.FocusBackgroundColor = Color.White;
            addressTxt.FocusBorderColor = Color.FromArgb(50, 81, 88);
            addressTxt.FocusImageTint = Color.White;
            addressTxt.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addressTxt.ForeColor = Color.Black;
            addressTxt.Image = null;
            addressTxt.ImageExpand = new Point(0, 0);
            addressTxt.ImageOffset = new Point(0, 0);
            addressTxt.Location = new Point(400, 116);
            addressTxt.Margin = new Padding(4);
            addressTxt.Multiline = false;
            addressTxt.Name = "addressTxt";
            addressTxt.NormalImageTint = Color.White;
            addressTxt.Padding = new Padding(13, 13, 13, 0);
            addressTxt.PasswordChar = false;
            addressTxt.PlaceholderColor = SystemColors.ScrollBar;
            addressTxt.PlaceholderText = "Address";
            addressTxt.Rounding = new Padding(10);
            addressTxt.Size = new Size(343, 38);
            addressTxt.TabIndex = 16;
            addressTxt.TextOffset = new Size(0, 0);
            addressTxt.UnderlinedStyle = false;
            // 
            // emailTxt
            // 
            emailTxt.BackColor = Color.Transparent;
            emailTxt.BackgroundColor = Color.White;
            emailTxt.BorderColor = Color.FromArgb(50, 81, 88);
            emailTxt.Content = "";
            emailTxt.FocusBackgroundColor = Color.White;
            emailTxt.FocusBorderColor = Color.FromArgb(50, 81, 88);
            emailTxt.FocusImageTint = Color.White;
            emailTxt.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailTxt.ForeColor = Color.Black;
            emailTxt.Image = null;
            emailTxt.ImageExpand = new Point(0, 0);
            emailTxt.ImageOffset = new Point(0, 0);
            emailTxt.Location = new Point(34, 162);
            emailTxt.Margin = new Padding(4);
            emailTxt.Multiline = false;
            emailTxt.Name = "emailTxt";
            emailTxt.NormalImageTint = Color.White;
            emailTxt.Padding = new Padding(13, 13, 13, 0);
            emailTxt.PasswordChar = false;
            emailTxt.PlaceholderColor = SystemColors.ScrollBar;
            emailTxt.PlaceholderText = "Email Address ";
            emailTxt.Rounding = new Padding(10);
            emailTxt.Size = new Size(343, 38);
            emailTxt.TabIndex = 15;
            emailTxt.TextOffset = new Size(0, 0);
            emailTxt.UnderlinedStyle = false;
            // 
            // mobNumTxt
            // 
            mobNumTxt.BackColor = Color.Transparent;
            mobNumTxt.BackgroundColor = Color.White;
            mobNumTxt.BorderColor = Color.FromArgb(50, 81, 88);
            mobNumTxt.Content = "";
            mobNumTxt.FocusBackgroundColor = Color.White;
            mobNumTxt.FocusBorderColor = Color.FromArgb(50, 81, 88);
            mobNumTxt.FocusImageTint = Color.White;
            mobNumTxt.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mobNumTxt.ForeColor = Color.Black;
            mobNumTxt.Image = null;
            mobNumTxt.ImageExpand = new Point(0, 0);
            mobNumTxt.ImageOffset = new Point(0, 0);
            mobNumTxt.Location = new Point(34, 116);
            mobNumTxt.Margin = new Padding(4);
            mobNumTxt.Multiline = false;
            mobNumTxt.Name = "mobNumTxt";
            mobNumTxt.NormalImageTint = Color.White;
            mobNumTxt.Padding = new Padding(13, 13, 13, 0);
            mobNumTxt.PasswordChar = false;
            mobNumTxt.PlaceholderColor = SystemColors.ScrollBar;
            mobNumTxt.PlaceholderText = "Mobile Number";
            mobNumTxt.Rounding = new Padding(10);
            mobNumTxt.Size = new Size(343, 38);
            mobNumTxt.TabIndex = 12;
            mobNumTxt.TextOffset = new Size(0, 0);
            mobNumTxt.UnderlinedStyle = false;
            mobNumTxt.KeyPress += mobNumTxt_KeyPress;
            // 
            // firstNameTxt
            // 
            firstNameTxt.BackColor = Color.Transparent;
            firstNameTxt.BackgroundColor = Color.White;
            firstNameTxt.BorderColor = Color.FromArgb(50, 81, 88);
            firstNameTxt.Content = "";
            firstNameTxt.FocusBackgroundColor = Color.White;
            firstNameTxt.FocusBorderColor = Color.FromArgb(50, 81, 88);
            firstNameTxt.FocusImageTint = Color.White;
            firstNameTxt.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            firstNameTxt.ForeColor = Color.Black;
            firstNameTxt.Image = null;
            firstNameTxt.ImageExpand = new Point(0, 0);
            firstNameTxt.ImageOffset = new Point(0, 0);
            firstNameTxt.Location = new Point(34, 70);
            firstNameTxt.Margin = new Padding(4);
            firstNameTxt.Multiline = false;
            firstNameTxt.Name = "firstNameTxt";
            firstNameTxt.NormalImageTint = Color.White;
            firstNameTxt.Padding = new Padding(13, 13, 13, 0);
            firstNameTxt.PasswordChar = false;
            firstNameTxt.PlaceholderColor = SystemColors.ScrollBar;
            firstNameTxt.PlaceholderText = "First Name";
            firstNameTxt.Rounding = new Padding(10);
            firstNameTxt.Size = new Size(343, 38);
            firstNameTxt.TabIndex = 11;
            firstNameTxt.TextOffset = new Size(0, 0);
            firstNameTxt.UnderlinedStyle = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(50, 81, 88);
            label1.Location = new Point(27, 45);
            label1.Name = "label1";
            label1.Size = new Size(142, 30);
            label1.TabIndex = 5;
            label1.Text = "Edit Trainers";
            // 
            // edit_trainer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(829, 467);
            Controls.Add(cuiPanel2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "edit_trainer";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "edit_trainer";
            TopMost = true;
            cuiPanel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CuoreUI.Controls.cuiPanel cuiPanel2;
        private CuoreUI.Controls.cuiButton doneButton;
        private CuoreUI.Controls.cuiButton cancelButton;
        private CuoreUI.Controls.cuiTextBox addressTxt;
        private CuoreUI.Controls.cuiTextBox emailTxt;
        private CuoreUI.Controls.cuiTextBox mobNumTxt;
        private CuoreUI.Controls.cuiTextBox firstNameTxt;
        private Label label1;
        private CuoreUI.Controls.cuiCalendarDatePicker birthDate;
        private CuoreUI.Controls.cuiTextBox lastNameTxt;
    }
}