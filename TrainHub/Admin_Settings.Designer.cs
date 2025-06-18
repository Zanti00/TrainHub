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
            passwordEditBtn = new CuoreUI.Controls.cuiButton();
            phoneEditBtn = new CuoreUI.Controls.cuiButton();
            emailEditBtn = new CuoreUI.Controls.cuiButton();
            label4 = new Label();
            label2 = new Label();
            cuiTextBox2 = new CuoreUI.Controls.cuiTextBox();
            label6 = new Label();
            loginBtn = new CuoreUI.Controls.cuiButtonGroup();
            cuiTextBox1 = new CuoreUI.Controls.cuiTextBox();
            passwordTxt = new CuoreUI.Controls.cuiTextBox();
            label3 = new Label();
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
            label1.Location = new Point(77, 48);
            label1.Name = "label1";
            label1.Size = new Size(409, 45);
            label1.TabIndex = 13;
            label1.Text = "Administrator Settings";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cuiPanel1
            // 
            cuiPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            cuiPanel1.BackColor = SystemColors.ButtonHighlight;
            cuiPanel1.Controls.Add(passwordEditBtn);
            cuiPanel1.Controls.Add(phoneEditBtn);
            cuiPanel1.Controls.Add(emailEditBtn);
            cuiPanel1.Controls.Add(label4);
            cuiPanel1.Controls.Add(label2);
            cuiPanel1.Controls.Add(cuiTextBox2);
            cuiPanel1.Controls.Add(label6);
            cuiPanel1.Controls.Add(loginBtn);
            cuiPanel1.Controls.Add(cuiTextBox1);
            cuiPanel1.Controls.Add(passwordTxt);
            cuiPanel1.Controls.Add(label3);
            cuiPanel1.Controls.Add(label1);
            cuiPanel1.Location = new Point(42, 27);
            cuiPanel1.Name = "cuiPanel1";
            cuiPanel1.OutlineThickness = 1F;
            cuiPanel1.PanelColor = Color.White;
            cuiPanel1.PanelOutlineColor = Color.Black;
            cuiPanel1.Rounding = new Padding(8);
            cuiPanel1.Size = new Size(653, 660);
            cuiPanel1.TabIndex = 10;
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
            passwordEditBtn.Location = new Point(442, 453);
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
            passwordEditBtn.Size = new Size(112, 40);
            passwordEditBtn.TabIndex = 28;
            passwordEditBtn.TextAlignment = StringAlignment.Center;
            passwordEditBtn.TextOffset = new Point(0, 0);
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
            phoneEditBtn.Location = new Point(442, 330);
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
            phoneEditBtn.Size = new Size(112, 40);
            phoneEditBtn.TabIndex = 27;
            phoneEditBtn.TextAlignment = StringAlignment.Center;
            phoneEditBtn.TextOffset = new Point(0, 0);
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
            emailEditBtn.Location = new Point(442, 208);
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
            emailEditBtn.Size = new Size(112, 40);
            emailEditBtn.TabIndex = 26;
            emailEditBtn.TextAlignment = StringAlignment.Center;
            emailEditBtn.TextOffset = new Point(0, 0);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(0, 0, 64);
            label4.ImageAlign = ContentAlignment.MiddleLeft;
            label4.Location = new Point(77, 428);
            label4.Margin = new Padding(6, 0, 3, 0);
            label4.Name = "label4";
            label4.Size = new Size(124, 20);
            label4.TabIndex = 25;
            label4.Text = "Change Password";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 0, 64);
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(77, 305);
            label2.Margin = new Padding(6, 0, 3, 0);
            label2.Name = "label2";
            label2.Size = new Size(146, 20);
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
            cuiTextBox2.Location = new Point(77, 208);
            cuiTextBox2.Margin = new Padding(5);
            cuiTextBox2.Multiline = false;
            cuiTextBox2.Name = "cuiTextBox2";
            cuiTextBox2.NormalImageTint = Color.White;
            cuiTextBox2.Padding = new Padding(16, 12, 16, 0);
            cuiTextBox2.PasswordChar = true;
            cuiTextBox2.PlaceholderColor = SystemColors.ScrollBar;
            cuiTextBox2.PlaceholderText = "Please enter your email...";
            cuiTextBox2.Rounding = new Padding(6);
            cuiTextBox2.Size = new Size(336, 40);
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
            label6.Location = new Point(77, 183);
            label6.Margin = new Padding(6, 0, 3, 0);
            label6.Name = "label6";
            label6.Size = new Size(141, 20);
            label6.TabIndex = 22;
            label6.Text = "Enter Email Address";
            label6.TextAlign = ContentAlignment.MiddleLeft;
          //label6.Click += label6_Click;
            // 
            // loginBtn
            // 
            loginBtn.BackColor = Color.Transparent;
            loginBtn.Checked = false;
            loginBtn.CheckedBackground = Color.FromArgb(50, 81, 88);
            loginBtn.CheckedForeColor = Color.White;
            loginBtn.CheckedImageTint = Color.White;
            loginBtn.CheckedOutline = Color.FromArgb(50, 81, 88);
            loginBtn.Content = "SAVE CHANGES";
            loginBtn.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginBtn.ForeColor = Color.White;
            loginBtn.Group = 0;
            loginBtn.HoverBackground = Color.White;
            loginBtn.HoveredImageTint = Color.White;
            loginBtn.HoverForeColor = Color.Black;
            loginBtn.HoverOutline = Color.FromArgb(22, 36, 39);
            loginBtn.Image = null;
            loginBtn.ImageAutoCenter = true;
            loginBtn.ImageExpand = new Point(0, 0);
            loginBtn.ImageOffset = new Point(0, 0);
            loginBtn.Location = new Point(150, 564);
            loginBtn.Margin = new Padding(3, 4, 3, 4);
            loginBtn.Name = "loginBtn";
            loginBtn.NormalBackground = Color.FromArgb(50, 81, 88);
            loginBtn.NormalForeColor = Color.White;
            loginBtn.NormalImageTint = Color.White;
            loginBtn.NormalOutline = Color.FromArgb(50, 81, 88);
            loginBtn.OutlineThickness = 1F;
            loginBtn.PressedBackground = Color.FromArgb(22, 36, 39);
            loginBtn.PressedForeColor = Color.White;
            loginBtn.PressedImageTint = Color.White;
            loginBtn.PressedOutline = Color.FromArgb(22, 36, 39);
            loginBtn.Rounding = new Padding(6);
            loginBtn.Size = new Size(336, 46);
            loginBtn.TabIndex = 21;
            loginBtn.TextAlignment = StringAlignment.Center;
            loginBtn.TextOffset = new Point(0, 0);
          //loginBtn.Click += loginBtn_Click;
            // 
            // cuiTextBox1
            // 
            cuiTextBox1.BackColor = Color.Transparent;
            cuiTextBox1.BackgroundColor = Color.WhiteSmoke;
            cuiTextBox1.BorderColor = Color.FromArgb(50, 81, 88);
            cuiTextBox1.Content = "";
            cuiTextBox1.FocusBackgroundColor = Color.White;
            cuiTextBox1.FocusBorderColor = Color.FromArgb(50, 81, 88);
            cuiTextBox1.FocusImageTint = Color.White;
            cuiTextBox1.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiTextBox1.ForeColor = Color.Black;
            cuiTextBox1.Image = null;
            cuiTextBox1.ImageExpand = new Point(0, 0);
            cuiTextBox1.ImageOffset = new Point(0, 0);
            cuiTextBox1.Location = new Point(77, 453);
            cuiTextBox1.Margin = new Padding(5);
            cuiTextBox1.Multiline = false;
            cuiTextBox1.Name = "cuiTextBox1";
            cuiTextBox1.NormalImageTint = Color.White;
            cuiTextBox1.Padding = new Padding(16, 12, 16, 0);
            cuiTextBox1.PasswordChar = true;
            cuiTextBox1.PlaceholderColor = SystemColors.ScrollBar;
            cuiTextBox1.PlaceholderText = "Please enter your password...";
            cuiTextBox1.Rounding = new Padding(6);
            cuiTextBox1.Size = new Size(336, 40);
            cuiTextBox1.TabIndex = 19;
            cuiTextBox1.TextOffset = new Size(0, 0);
            cuiTextBox1.UnderlinedStyle = false;
            // 
            // passwordTxt
            // 
            passwordTxt.BackColor = Color.Transparent;
            passwordTxt.BackgroundColor = Color.WhiteSmoke;
            passwordTxt.BorderColor = Color.FromArgb(50, 81, 88);
            passwordTxt.Content = "";
            passwordTxt.FocusBackgroundColor = Color.White;
            passwordTxt.FocusBorderColor = Color.FromArgb(50, 81, 88);
            passwordTxt.FocusImageTint = Color.White;
            passwordTxt.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordTxt.ForeColor = Color.Black;
            passwordTxt.Image = null;
            passwordTxt.ImageExpand = new Point(0, 0);
            passwordTxt.ImageOffset = new Point(0, 0);
            passwordTxt.Location = new Point(77, 330);
            passwordTxt.Margin = new Padding(5);
            passwordTxt.Multiline = false;
            passwordTxt.Name = "passwordTxt";
            passwordTxt.NormalImageTint = Color.White;
            passwordTxt.Padding = new Padding(16, 12, 16, 0);
            passwordTxt.PasswordChar = true;
            passwordTxt.PlaceholderColor = SystemColors.ScrollBar;
            passwordTxt.PlaceholderText = "Please enter your phone number...";
            passwordTxt.Rounding = new Padding(6);
            passwordTxt.Size = new Size(336, 40);
            passwordTxt.TabIndex = 17;
            passwordTxt.TextOffset = new Size(0, 0);
            passwordTxt.UnderlinedStyle = false;
          //passwordTxt.ContentChanged += passwordTxt_ContentChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(130, 130, 130);
            label3.Location = new Point(77, 113);
            label3.Margin = new Padding(11, 20, 3, 0);
            label3.Name = "label3";
            label3.Size = new Size(337, 20);
            label3.TabIndex = 15;
            label3.Text = "\"Welcome admin. Make changes to your account\"";
            // 
            // Admin_Settings
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(736, 699);
            Controls.Add(cuiPanel1);
            Name = "Admin_Settings";
            Text = "Admin_Settings";
            cuiPanel1.ResumeLayout(false);
            cuiPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private CuoreUI.Controls.cuiPanel cuiPanel1;
        private CuoreUI.Controls.cuiButtonGroup loginBtn;
        private CuoreUI.Controls.cuiTextBox cuiTextBox1;
        private CuoreUI.Controls.cuiTextBox passwordTxt;
        private Label label3;
        private Label label6;
        private CuoreUI.Controls.cuiTextBox cuiTextBox2;
        private Label label4;
        private Label label2;
        private CuoreUI.Controls.cuiButton emailEditBtn;
        private CuoreUI.Controls.cuiButton passwordEditBtn;
        private CuoreUI.Controls.cuiButton phoneEditBtn;
    }
}