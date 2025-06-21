namespace TrainHub
{
    partial class Admin_Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Settings));
            label1 = new Label();
            cuiPanel1 = new CuoreUI.Controls.cuiPanel();
            label4 = new Label();
            passwordTextBox = new CuoreUI.Controls.cuiTextBox();
            phoneEditBtn = new CuoreUI.Controls.cuiButton();
            emailEditBtn = new CuoreUI.Controls.cuiButton();
            label2 = new Label();
            cuiTextBox2 = new CuoreUI.Controls.cuiTextBox();
            label6 = new Label();
            saveChangesBtn = new CuoreUI.Controls.cuiButtonGroup();
            phoneTextBox = new CuoreUI.Controls.cuiTextBox();
            label3 = new Label();
            passwordEditBtn = new CuoreUI.Controls.cuiButton();
            cuiPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Microsoft YaHei", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(50, 81, 88);
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(67, 36);
            label1.Name = "label1";
            label1.Size = new Size(324, 36);
            label1.TabIndex = 13;
            label1.Text = "Administrator Settings";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cuiPanel1
            // 
            cuiPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            cuiPanel1.BackColor = SystemColors.ButtonHighlight;
            cuiPanel1.Controls.Add(passwordEditBtn);
            cuiPanel1.Controls.Add(label4);
            cuiPanel1.Controls.Add(passwordTextBox);
            cuiPanel1.Controls.Add(phoneEditBtn);
            cuiPanel1.Controls.Add(emailEditBtn);
            cuiPanel1.Controls.Add(label2);
            cuiPanel1.Controls.Add(cuiTextBox2);
            cuiPanel1.Controls.Add(label6);
            cuiPanel1.Controls.Add(saveChangesBtn);
            cuiPanel1.Controls.Add(phoneTextBox);
            cuiPanel1.Controls.Add(label3);
            cuiPanel1.Controls.Add(label1);
            cuiPanel1.Location = new Point(37, 20);
            cuiPanel1.Margin = new Padding(3, 2, 3, 2);
            cuiPanel1.Name = "cuiPanel1";
            cuiPanel1.OutlineThickness = 1F;
            cuiPanel1.PanelColor = Color.White;
            cuiPanel1.PanelOutlineColor = Color.Black;
            cuiPanel1.Rounding = new Padding(8);
            cuiPanel1.Size = new Size(571, 495);
            cuiPanel1.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(0, 0, 64);
            label4.ImageAlign = ContentAlignment.MiddleLeft;
            label4.Location = new Point(67, 320);
            label4.Margin = new Padding(5, 0, 3, 0);
            label4.Name = "label4";
            label4.Size = new Size(87, 15);
            label4.TabIndex = 29;
            label4.Text = "Enter Password";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // passwordTextBox
            // 
            passwordTextBox.BackColor = Color.Transparent;
            passwordTextBox.BackgroundColor = Color.WhiteSmoke;
            passwordTextBox.BorderColor = Color.FromArgb(50, 81, 88);
            passwordTextBox.Content = "";
            passwordTextBox.FocusBackgroundColor = Color.White;
            passwordTextBox.FocusBorderColor = Color.FromArgb(50, 81, 88);
            passwordTextBox.FocusImageTint = Color.White;
            passwordTextBox.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordTextBox.ForeColor = Color.Black;
            passwordTextBox.Image = null;
            passwordTextBox.ImageExpand = new Point(0, 0);
            passwordTextBox.ImageOffset = new Point(0, 0);
            passwordTextBox.Location = new Point(67, 339);
            passwordTextBox.Margin = new Padding(4);
            passwordTextBox.Multiline = false;
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.NormalImageTint = Color.White;
            passwordTextBox.Padding = new Padding(13, 9, 13, 0);
            passwordTextBox.PasswordChar = false;
            passwordTextBox.PlaceholderColor = SystemColors.ScrollBar;
            passwordTextBox.PlaceholderText = "Please enter your password...";
            passwordTextBox.Rounding = new Padding(6);
            passwordTextBox.Size = new Size(294, 30);
            passwordTextBox.TabIndex = 28;
            passwordTextBox.TextOffset = new Size(0, 0);
            passwordTextBox.UnderlinedStyle = false;
            // 
            // phoneEditBtn
            // 
            phoneEditBtn.BackColor = Color.Transparent;
            phoneEditBtn.BackgroundImage = (Image)resources.GetObject("phoneEditBtn.BackgroundImage");
            phoneEditBtn.BackgroundImageLayout = ImageLayout.Zoom;
            phoneEditBtn.CheckButton = false;
            phoneEditBtn.Checked = false;
            phoneEditBtn.CheckedBackground = Color.FromArgb(255, 106, 0);
            phoneEditBtn.CheckedForeColor = SystemColors.ButtonHighlight;
            phoneEditBtn.CheckedImageTint = SystemColors.ButtonHighlight;
            phoneEditBtn.CheckedOutline = Color.FromArgb(255, 106, 0);
            phoneEditBtn.Content = "Edit";
            phoneEditBtn.DialogResult = DialogResult.None;
            phoneEditBtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            phoneEditBtn.ForeColor = Color.FromArgb(50, 81, 88);
            phoneEditBtn.HoverBackground = Color.Transparent;
            phoneEditBtn.HoveredImageTint = Color.Transparent;
            phoneEditBtn.HoverForeColor = Color.Black;
            phoneEditBtn.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            phoneEditBtn.Image = null;
            phoneEditBtn.ImageAutoCenter = true;
            phoneEditBtn.ImageExpand = new Point(0, 0);
            phoneEditBtn.ImageOffset = new Point(0, 0);
            phoneEditBtn.Location = new Point(387, 248);
            phoneEditBtn.Margin = new Padding(3, 2, 3, 2);
            phoneEditBtn.Name = "phoneEditBtn";
            phoneEditBtn.NormalBackground = Color.White;
            phoneEditBtn.NormalForeColor = Color.FromArgb(50, 81, 88);
            phoneEditBtn.NormalImageTint = Color.White;
            phoneEditBtn.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            phoneEditBtn.OutlineThickness = 1F;
            phoneEditBtn.PressedBackground = Color.WhiteSmoke;
            phoneEditBtn.PressedForeColor = Color.FromArgb(32, 32, 32);
            phoneEditBtn.PressedImageTint = Color.White;
            phoneEditBtn.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            phoneEditBtn.Rounding = new Padding(8);
            phoneEditBtn.Size = new Size(98, 30);
            phoneEditBtn.TabIndex = 27;
            phoneEditBtn.TextAlignment = StringAlignment.Center;
            phoneEditBtn.TextOffset = new Point(0, 0);
            phoneEditBtn.Click += phoneEditBtn_Click;
            // 
            // emailEditBtn
            // 
            emailEditBtn.BackColor = Color.Transparent;
            emailEditBtn.BackgroundImage = (Image)resources.GetObject("emailEditBtn.BackgroundImage");
            emailEditBtn.BackgroundImageLayout = ImageLayout.Zoom;
            emailEditBtn.CheckButton = false;
            emailEditBtn.Checked = false;
            emailEditBtn.CheckedBackground = Color.FromArgb(255, 106, 0);
            emailEditBtn.CheckedForeColor = SystemColors.ButtonHighlight;
            emailEditBtn.CheckedImageTint = SystemColors.ButtonHighlight;
            emailEditBtn.CheckedOutline = Color.FromArgb(255, 106, 0);
            emailEditBtn.Content = "Edit";
            emailEditBtn.DialogResult = DialogResult.None;
            emailEditBtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            emailEditBtn.ForeColor = Color.FromArgb(50, 81, 88);
            emailEditBtn.HoverBackground = Color.Transparent;
            emailEditBtn.HoveredImageTint = Color.Transparent;
            emailEditBtn.HoverForeColor = Color.Black;
            emailEditBtn.HoverOutline = Color.White;
            emailEditBtn.Image = null;
            emailEditBtn.ImageAutoCenter = true;
            emailEditBtn.ImageExpand = new Point(0, 0);
            emailEditBtn.ImageOffset = new Point(0, 0);
            emailEditBtn.Location = new Point(387, 156);
            emailEditBtn.Margin = new Padding(3, 2, 3, 2);
            emailEditBtn.Name = "emailEditBtn";
            emailEditBtn.NormalBackground = Color.White;
            emailEditBtn.NormalForeColor = Color.FromArgb(50, 81, 88);
            emailEditBtn.NormalImageTint = Color.White;
            emailEditBtn.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            emailEditBtn.OutlineThickness = 1F;
            emailEditBtn.PressedBackground = Color.WhiteSmoke;
            emailEditBtn.PressedForeColor = Color.FromArgb(32, 32, 32);
            emailEditBtn.PressedImageTint = Color.White;
            emailEditBtn.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            emailEditBtn.Rounding = new Padding(8);
            emailEditBtn.Size = new Size(98, 30);
            emailEditBtn.TabIndex = 26;
            emailEditBtn.TextAlignment = StringAlignment.Center;
            emailEditBtn.TextOffset = new Point(0, 0);
            emailEditBtn.Click += emailEditBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 0, 64);
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(67, 229);
            label2.Margin = new Padding(5, 0, 3, 0);
            label2.Name = "label2";
            label2.Size = new Size(118, 15);
            label2.TabIndex = 24;
            label2.Text = "Enter Phone Number";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cuiTextBox2
            // 
            cuiTextBox2.BackColor = Color.Transparent;
            cuiTextBox2.BackgroundColor = Color.WhiteSmoke;
            cuiTextBox2.BorderColor = Color.FromArgb(50, 81, 88);
            cuiTextBox2.Content = "";
            cuiTextBox2.FocusBackgroundColor = Color.White;
            cuiTextBox2.FocusBorderColor = Color.FromArgb(50, 81, 88);
            cuiTextBox2.FocusImageTint = Color.White;
            cuiTextBox2.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiTextBox2.ForeColor = Color.Black;
            cuiTextBox2.Image = null;
            cuiTextBox2.ImageExpand = new Point(0, 0);
            cuiTextBox2.ImageOffset = new Point(0, 0);
            cuiTextBox2.Location = new Point(67, 156);
            cuiTextBox2.Margin = new Padding(4);
            cuiTextBox2.Multiline = false;
            cuiTextBox2.Name = "cuiTextBox2";
            cuiTextBox2.NormalImageTint = Color.White;
            cuiTextBox2.Padding = new Padding(13, 9, 13, 0);
            cuiTextBox2.PasswordChar = false;
            cuiTextBox2.PlaceholderColor = SystemColors.ScrollBar;
            cuiTextBox2.PlaceholderText = "Please enter your email...";
            cuiTextBox2.Rounding = new Padding(6);
            cuiTextBox2.Size = new Size(294, 30);
            cuiTextBox2.TabIndex = 23;
            cuiTextBox2.TextOffset = new Size(0, 0);
            cuiTextBox2.UnderlinedStyle = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(0, 0, 64);
            label6.ImageAlign = ContentAlignment.MiddleLeft;
            label6.Location = new Point(67, 137);
            label6.Margin = new Padding(5, 0, 3, 0);
            label6.Name = "label6";
            label6.Size = new Size(111, 15);
            label6.TabIndex = 22;
            label6.Text = "Enter Email Address";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // saveChangesBtn
            // 
            saveChangesBtn.BackColor = Color.Transparent;
            saveChangesBtn.Checked = false;
            saveChangesBtn.CheckedBackground = Color.FromArgb(50, 81, 88);
            saveChangesBtn.CheckedForeColor = Color.White;
            saveChangesBtn.CheckedImageTint = Color.White;
            saveChangesBtn.CheckedOutline = Color.FromArgb(50, 81, 88);
            saveChangesBtn.Content = "SAVE CHANGES";
            saveChangesBtn.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            saveChangesBtn.ForeColor = Color.White;
            saveChangesBtn.Group = 0;
            saveChangesBtn.HoverBackground = Color.White;
            saveChangesBtn.HoveredImageTint = Color.White;
            saveChangesBtn.HoverForeColor = Color.Black;
            saveChangesBtn.HoverOutline = Color.FromArgb(22, 36, 39);
            saveChangesBtn.Image = null;
            saveChangesBtn.ImageAutoCenter = true;
            saveChangesBtn.ImageExpand = new Point(0, 0);
            saveChangesBtn.ImageOffset = new Point(0, 0);
            saveChangesBtn.Location = new Point(131, 423);
            saveChangesBtn.Name = "saveChangesBtn";
            saveChangesBtn.NormalBackground = Color.FromArgb(50, 81, 88);
            saveChangesBtn.NormalForeColor = Color.White;
            saveChangesBtn.NormalImageTint = Color.White;
            saveChangesBtn.NormalOutline = Color.FromArgb(50, 81, 88);
            saveChangesBtn.OutlineThickness = 1F;
            saveChangesBtn.PressedBackground = Color.FromArgb(22, 36, 39);
            saveChangesBtn.PressedForeColor = Color.White;
            saveChangesBtn.PressedImageTint = Color.White;
            saveChangesBtn.PressedOutline = Color.FromArgb(22, 36, 39);
            saveChangesBtn.Rounding = new Padding(6);
            saveChangesBtn.Size = new Size(294, 34);
            saveChangesBtn.TabIndex = 21;
            saveChangesBtn.TextAlignment = StringAlignment.Center;
            saveChangesBtn.TextOffset = new Point(0, 0);
            saveChangesBtn.Click += saveChangesBtn_Click;
            // 
            // phoneTextBox
            // 
            phoneTextBox.BackColor = Color.Transparent;
            phoneTextBox.BackgroundColor = Color.WhiteSmoke;
            phoneTextBox.BorderColor = Color.FromArgb(50, 81, 88);
            phoneTextBox.Content = "";
            phoneTextBox.FocusBackgroundColor = Color.White;
            phoneTextBox.FocusBorderColor = Color.FromArgb(50, 81, 88);
            phoneTextBox.FocusImageTint = Color.White;
            phoneTextBox.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            phoneTextBox.ForeColor = Color.Black;
            phoneTextBox.Image = null;
            phoneTextBox.ImageExpand = new Point(0, 0);
            phoneTextBox.ImageOffset = new Point(0, 0);
            phoneTextBox.Location = new Point(67, 248);
            phoneTextBox.Margin = new Padding(4);
            phoneTextBox.Multiline = false;
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.NormalImageTint = Color.White;
            phoneTextBox.Padding = new Padding(13, 9, 13, 0);
            phoneTextBox.PasswordChar = false;
            phoneTextBox.PlaceholderColor = SystemColors.ScrollBar;
            phoneTextBox.PlaceholderText = "Please enter your phone number...";
            phoneTextBox.Rounding = new Padding(6);
            phoneTextBox.Size = new Size(294, 30);
            phoneTextBox.TabIndex = 17;
            phoneTextBox.TextOffset = new Size(0, 0);
            phoneTextBox.UnderlinedStyle = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(130, 130, 130);
            label3.Location = new Point(67, 85);
            label3.Margin = new Padding(10, 15, 3, 0);
            label3.Name = "label3";
            label3.Size = new Size(273, 15);
            label3.TabIndex = 15;
            label3.Text = "\"Welcome admin. Make changes to your account\"";
            // 
            // passwordEditBtn
            // 
            passwordEditBtn.BackColor = Color.Transparent;
            passwordEditBtn.BackgroundImage = (Image)resources.GetObject("passwordEditBtn.BackgroundImage");
            passwordEditBtn.BackgroundImageLayout = ImageLayout.Zoom;
            passwordEditBtn.CheckButton = false;
            passwordEditBtn.Checked = false;
            passwordEditBtn.CheckedBackground = Color.FromArgb(255, 106, 0);
            passwordEditBtn.CheckedForeColor = SystemColors.ButtonHighlight;
            passwordEditBtn.CheckedImageTint = SystemColors.ButtonHighlight;
            passwordEditBtn.CheckedOutline = Color.FromArgb(255, 106, 0);
            passwordEditBtn.Content = "Edit";
            passwordEditBtn.DialogResult = DialogResult.None;
            passwordEditBtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            passwordEditBtn.ForeColor = Color.FromArgb(50, 81, 88);
            passwordEditBtn.HoverBackground = Color.Transparent;
            passwordEditBtn.HoveredImageTint = Color.Transparent;
            passwordEditBtn.HoverForeColor = Color.Black;
            passwordEditBtn.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            passwordEditBtn.Image = null;
            passwordEditBtn.ImageAutoCenter = true;
            passwordEditBtn.ImageExpand = new Point(0, 0);
            passwordEditBtn.ImageOffset = new Point(0, 0);
            passwordEditBtn.Location = new Point(387, 339);
            passwordEditBtn.Margin = new Padding(3, 2, 3, 2);
            passwordEditBtn.Name = "passwordEditBtn";
            passwordEditBtn.NormalBackground = Color.White;
            passwordEditBtn.NormalForeColor = Color.FromArgb(50, 81, 88);
            passwordEditBtn.NormalImageTint = Color.White;
            passwordEditBtn.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            passwordEditBtn.OutlineThickness = 1F;
            passwordEditBtn.PressedBackground = Color.WhiteSmoke;
            passwordEditBtn.PressedForeColor = Color.FromArgb(32, 32, 32);
            passwordEditBtn.PressedImageTint = Color.White;
            passwordEditBtn.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            passwordEditBtn.Rounding = new Padding(8);
            passwordEditBtn.Size = new Size(98, 30);
            passwordEditBtn.TabIndex = 30;
            passwordEditBtn.TextAlignment = StringAlignment.Center;
            passwordEditBtn.TextOffset = new Point(0, 0);
            // 
            // Admin_Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(644, 524);
            Controls.Add(cuiPanel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Admin_Settings";
            Text = "Admin_Settings";
            cuiPanel1.ResumeLayout(false);
            cuiPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private CuoreUI.Controls.cuiPanel cuiPanel1;
        private CuoreUI.Controls.cuiButtonGroup saveChangesBtn;
        private CuoreUI.Controls.cuiTextBox phoneTextBox;
        private Label label3;
        private Label label6;
        private CuoreUI.Controls.cuiTextBox cuiTextBox2;
        private Label label2;
        private CuoreUI.Controls.cuiButton emailEditBtn;
        private CuoreUI.Controls.cuiButton phoneEditBtn;
        private Label label4;
        private CuoreUI.Controls.cuiTextBox passwordTextBox;
        private CuoreUI.Controls.cuiButton passwordEditBtn;
    }
}