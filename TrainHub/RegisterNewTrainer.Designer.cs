namespace TrainHub
{
    partial class RegisterNewTrainer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterNewTrainer));
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label1 = new Label();
            cuiPanel2 = new CuoreUI.Controls.cuiPanel();
            yearsOfExperienceTxt = new CuoreUI.Controls.cuiTextBox();
            birthDate = new CuoreUI.Controls.cuiCalendarDatePicker();
            addButton = new CuoreUI.Controls.cuiButton();
            cancelButton = new CuoreUI.Controls.cuiButton();
            cancelBtn = new CuoreUI.Controls.cuiButton();
            addressTxt = new CuoreUI.Controls.cuiTextBox();
            emailTxt = new CuoreUI.Controls.cuiTextBox();
            lastNameTxt = new CuoreUI.Controls.cuiTextBox();
            mobNumTxt = new CuoreUI.Controls.cuiTextBox();
            firstNameTxt = new CuoreUI.Controls.cuiTextBox();
            cuiPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(50, 81, 88);
            label1.Location = new Point(27, 45);
            label1.Name = "label1";
            label1.Size = new Size(197, 30);
            label1.TabIndex = 6;
            label1.Text = "Add New Trainers";
            // 
            // cuiPanel2
            // 
            cuiPanel2.BackColor = Color.Transparent;
            cuiPanel2.BackgroundImageLayout = ImageLayout.None;
            cuiPanel2.Controls.Add(yearsOfExperienceTxt);
            cuiPanel2.Controls.Add(birthDate);
            cuiPanel2.Controls.Add(addButton);
            cuiPanel2.Controls.Add(cancelButton);
            cuiPanel2.Controls.Add(cancelBtn);
            cuiPanel2.Controls.Add(addressTxt);
            cuiPanel2.Controls.Add(emailTxt);
            cuiPanel2.Controls.Add(lastNameTxt);
            cuiPanel2.Controls.Add(mobNumTxt);
            cuiPanel2.Controls.Add(firstNameTxt);
            cuiPanel2.Location = new Point(27, 94);
            cuiPanel2.Name = "cuiPanel2";
            cuiPanel2.OutlineThickness = 1F;
            cuiPanel2.PanelColor = Color.White;
            cuiPanel2.PanelOutlineColor = Color.Black;
            cuiPanel2.Rounding = new Padding(10);
            cuiPanel2.Size = new Size(779, 289);
            cuiPanel2.TabIndex = 7;
            // 
            // yearsOfExperienceTxt
            // 
            yearsOfExperienceTxt.BackColor = Color.Transparent;
            yearsOfExperienceTxt.BackgroundColor = Color.White;
            yearsOfExperienceTxt.BorderColor = Color.FromArgb(50, 81, 88);
            yearsOfExperienceTxt.Content = "";
            yearsOfExperienceTxt.FocusBackgroundColor = Color.White;
            yearsOfExperienceTxt.FocusBorderColor = Color.FromArgb(50, 81, 88);
            yearsOfExperienceTxt.FocusImageTint = Color.White;
            yearsOfExperienceTxt.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            yearsOfExperienceTxt.ForeColor = Color.Black;
            yearsOfExperienceTxt.Image = null;
            yearsOfExperienceTxt.ImageExpand = new Point(0, 0);
            yearsOfExperienceTxt.ImageOffset = new Point(0, 0);
            yearsOfExperienceTxt.Location = new Point(35, 208);
            yearsOfExperienceTxt.Margin = new Padding(4);
            yearsOfExperienceTxt.Multiline = false;
            yearsOfExperienceTxt.Name = "yearsOfExperienceTxt";
            yearsOfExperienceTxt.NormalImageTint = Color.White;
            yearsOfExperienceTxt.Padding = new Padding(13, 13, 13, 0);
            yearsOfExperienceTxt.PasswordChar = false;
            yearsOfExperienceTxt.PlaceholderColor = SystemColors.ScrollBar;
            yearsOfExperienceTxt.PlaceholderText = "Years of Experience";
            yearsOfExperienceTxt.Rounding = new Padding(10);
            yearsOfExperienceTxt.Size = new Size(343, 38);
            yearsOfExperienceTxt.TabIndex = 25;
            yearsOfExperienceTxt.TextOffset = new Size(0, 0);
            yearsOfExperienceTxt.UnderlinedStyle = false;
            // 
            // birthDate
            // 
            birthDate.Anchor = AnchorStyles.None;
            birthDate.EnableThemeChangeButton = true;
            birthDate.Font = new Font("Segoe UI", 9.75F);
            birthDate.ForeColor = Color.Gray;
            birthDate.HoverBackground = Color.FromArgb(50, 128, 128, 128);
            birthDate.HoverOutline = Color.FromArgb(180, 128, 128, 128);
            birthDate.Icon = (Image)resources.GetObject("birthDate.Icon");
            birthDate.IconTint = Color.Gray;
            birthDate.Location = new Point(410, 162);
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
            birthDate.TabIndex = 24;
            birthDate.Theme = CuoreUI.Controls.Forms.DatePicker.Themes.Light;
            birthDate.Value = new DateTime(2025, 6, 6, 0, 0, 0, 0);
            // 
            // addButton
            // 
            addButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            addButton.CheckButton = false;
            addButton.Checked = true;
            addButton.CheckedBackground = Color.FromArgb(50, 81, 88);
            addButton.CheckedForeColor = SystemColors.Window;
            addButton.CheckedImageTint = Color.White;
            addButton.CheckedOutline = Color.FromArgb(50, 81, 88);
            addButton.Content = "OK";
            addButton.DialogResult = DialogResult.None;
            addButton.Font = new Font("Microsoft Sans Serif", 9.75F);
            addButton.ForeColor = Color.White;
            addButton.HoverBackground = Color.FromArgb(22, 36, 39);
            addButton.HoveredImageTint = Color.White;
            addButton.HoverForeColor = Color.Black;
            addButton.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            addButton.Image = null;
            addButton.ImageAutoCenter = true;
            addButton.ImageExpand = new Point(0, 0);
            addButton.ImageOffset = new Point(0, 0);
            addButton.Location = new Point(682, 214);
            addButton.Name = "addButton";
            addButton.NormalBackground = Color.FromArgb(50, 81, 88);
            addButton.NormalForeColor = Color.White;
            addButton.NormalImageTint = Color.White;
            addButton.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            addButton.OutlineThickness = 1F;
            addButton.PressedBackground = Color.WhiteSmoke;
            addButton.PressedForeColor = Color.FromArgb(32, 32, 32);
            addButton.PressedImageTint = Color.White;
            addButton.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            addButton.Rounding = new Padding(10);
            addButton.Size = new Size(71, 32);
            addButton.TabIndex = 23;
            addButton.TextAlignment = StringAlignment.Center;
            addButton.TextOffset = new Point(0, 0);
            addButton.Click += addButton_Click;
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
            cancelButton.Location = new Point(612, 213);
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
            cancelButton.TabIndex = 22;
            cancelButton.TextAlignment = StringAlignment.Center;
            cancelButton.TextOffset = new Point(0, 0);
            cancelButton.Click += cancelBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cancelBtn.CheckButton = false;
            cancelBtn.Checked = false;
            cancelBtn.CheckedBackground = Color.FromArgb(255, 106, 0);
            cancelBtn.CheckedForeColor = Color.White;
            cancelBtn.CheckedImageTint = Color.White;
            cancelBtn.CheckedOutline = Color.FromArgb(255, 106, 0);
            cancelBtn.Content = "Cancel";
            cancelBtn.DialogResult = DialogResult.None;
            cancelBtn.Font = new Font("Microsoft Sans Serif", 9.75F);
            cancelBtn.ForeColor = Color.Black;
            cancelBtn.HoverBackground = Color.White;
            cancelBtn.HoveredImageTint = Color.White;
            cancelBtn.HoverForeColor = Color.Black;
            cancelBtn.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            cancelBtn.Image = null;
            cancelBtn.ImageAutoCenter = true;
            cancelBtn.ImageExpand = new Point(0, 0);
            cancelBtn.ImageOffset = new Point(0, 0);
            cancelBtn.Location = new Point(1051, 321);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.NormalBackground = Color.White;
            cancelBtn.NormalForeColor = Color.Black;
            cancelBtn.NormalImageTint = Color.White;
            cancelBtn.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            cancelBtn.OutlineThickness = 1F;
            cancelBtn.PressedBackground = Color.WhiteSmoke;
            cancelBtn.PressedForeColor = Color.FromArgb(32, 32, 32);
            cancelBtn.PressedImageTint = Color.White;
            cancelBtn.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            cancelBtn.Rounding = new Padding(8);
            cancelBtn.Size = new Size(64, 32);
            cancelBtn.TabIndex = 17;
            cancelBtn.TextAlignment = StringAlignment.Center;
            cancelBtn.TextOffset = new Point(0, 0);
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
            addressTxt.Location = new Point(410, 117);
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
            emailTxt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
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
            // lastNameTxt
            // 
            lastNameTxt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
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
            lastNameTxt.Location = new Point(410, 70);
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
            lastNameTxt.TabIndex = 11;
            lastNameTxt.TextOffset = new Size(0, 0);
            lastNameTxt.UnderlinedStyle = false;
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
            // RegisterNewTrainer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(829, 467);
            Controls.Add(cuiPanel2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RegisterNewTrainer";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "trainer";
            TopMost = true;
            cuiPanel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label1;
        private CuoreUI.Controls.cuiPanel cuiPanel2;
        private CuoreUI.Controls.cuiButton cancelBtn;
        private CuoreUI.Controls.cuiTextBox addressTxt;
        private CuoreUI.Controls.cuiTextBox emailTxt;
        private CuoreUI.Controls.cuiTextBox lastNameTxt;
        private CuoreUI.Controls.cuiTextBox mobNumTxt;
        private CuoreUI.Controls.cuiTextBox firstNameTxt;
        private CuoreUI.Controls.cuiButton cancelButton;
        private CuoreUI.Controls.cuiButton addButton;
        private CuoreUI.Controls.cuiCalendarDatePicker birthDate;
        private CuoreUI.Controls.cuiTextBox yearsOfExperienceTxt;
    }
}