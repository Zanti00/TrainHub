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
            loginBtn = new CuoreUI.Controls.cuiButtonGroup();
            cuiTextBox1 = new CuoreUI.Controls.cuiTextBox();
            passwordTxt = new CuoreUI.Controls.cuiTextBox();
            label3 = new Label();
            label6 = new Label();
            cuiTextBox2 = new CuoreUI.Controls.cuiTextBox();
            label2 = new Label();
            label4 = new Label();
            cuiButton1 = new CuoreUI.Controls.cuiButton();
            cuiButton2 = new CuoreUI.Controls.cuiButton();
            cuiButton3 = new CuoreUI.Controls.cuiButton();
            cuiPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
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
            cuiPanel1.BackColor = SystemColors.ButtonHighlight;
            cuiPanel1.Controls.Add(cuiButton3);
            cuiPanel1.Controls.Add(cuiButton2);
            cuiPanel1.Controls.Add(cuiButton1);
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
            loginBtn.Click += loginBtn_Click;
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
            passwordTxt.ContentChanged += passwordTxt_ContentChanged;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(130, 130, 130);
            label3.Location = new Point(77, 113);
            label3.Margin = new Padding(11, 20, 3, 0);
            label3.Name = "label3";
            label3.Size = new Size(337, 20);
            label3.TabIndex = 15;
            label3.Text = "\"Welcome admin. Make changes to your account\"";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
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
            label6.Click += label6_Click;
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
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
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
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
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
            // cuiButton1
            // 
            cuiButton1.BackColor = Color.Transparent;
            cuiButton1.BackgroundImage = (Image)resources.GetObject("cuiButton1.BackgroundImage");
            cuiButton1.BackgroundImageLayout = ImageLayout.Zoom;
            cuiButton1.CheckButton = false;
            cuiButton1.Checked = false;
            cuiButton1.CheckedBackground = Color.FromArgb(255, 106, 0);
            cuiButton1.CheckedForeColor = SystemColors.ButtonHighlight;
            cuiButton1.CheckedImageTint = SystemColors.ButtonHighlight;
            cuiButton1.CheckedOutline = Color.FromArgb(255, 106, 0);
            cuiButton1.Content = "Edit";
            cuiButton1.DialogResult = DialogResult.None;
            cuiButton1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            cuiButton1.ForeColor = Color.FromArgb(50, 81, 88);
            cuiButton1.HoverBackground = Color.Transparent;
            cuiButton1.HoveredImageTint = Color.Transparent;
            cuiButton1.HoverForeColor = Color.Black;
            cuiButton1.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            cuiButton1.Image = null;
            cuiButton1.ImageAutoCenter = true;
            cuiButton1.ImageExpand = new Point(0, 0);
            cuiButton1.ImageOffset = new Point(0, 0);
            cuiButton1.Location = new Point(442, 208);
            cuiButton1.Name = "cuiButton1";
            cuiButton1.NormalBackground = Color.White;
            cuiButton1.NormalForeColor = Color.FromArgb(50, 81, 88);
            cuiButton1.NormalImageTint = Color.White;
            cuiButton1.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            cuiButton1.OutlineThickness = 1F;
            cuiButton1.PressedBackground = Color.WhiteSmoke;
            cuiButton1.PressedForeColor = Color.FromArgb(32, 32, 32);
            cuiButton1.PressedImageTint = Color.White;
            cuiButton1.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            cuiButton1.Rounding = new Padding(8);
            cuiButton1.Size = new Size(112, 40);
            cuiButton1.TabIndex = 26;
            cuiButton1.TextAlignment = StringAlignment.Center;
            cuiButton1.TextOffset = new Point(0, 0);
            // 
            // cuiButton2
            // 
            cuiButton2.BackColor = Color.Transparent;
            cuiButton2.BackgroundImage = (Image)resources.GetObject("cuiButton2.BackgroundImage");
            cuiButton2.BackgroundImageLayout = ImageLayout.Zoom;
            cuiButton2.CheckButton = false;
            cuiButton2.Checked = false;
            cuiButton2.CheckedBackground = Color.FromArgb(255, 106, 0);
            cuiButton2.CheckedForeColor = SystemColors.ButtonHighlight;
            cuiButton2.CheckedImageTint = SystemColors.ButtonHighlight;
            cuiButton2.CheckedOutline = Color.FromArgb(255, 106, 0);
            cuiButton2.Content = "Edit";
            cuiButton2.DialogResult = DialogResult.None;
            cuiButton2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            cuiButton2.ForeColor = Color.FromArgb(50, 81, 88);
            cuiButton2.HoverBackground = Color.Transparent;
            cuiButton2.HoveredImageTint = Color.Transparent;
            cuiButton2.HoverForeColor = Color.Black;
            cuiButton2.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            cuiButton2.Image = null;
            cuiButton2.ImageAutoCenter = true;
            cuiButton2.ImageExpand = new Point(0, 0);
            cuiButton2.ImageOffset = new Point(0, 0);
            cuiButton2.Location = new Point(442, 330);
            cuiButton2.Name = "cuiButton2";
            cuiButton2.NormalBackground = Color.White;
            cuiButton2.NormalForeColor = Color.FromArgb(50, 81, 88);
            cuiButton2.NormalImageTint = Color.White;
            cuiButton2.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            cuiButton2.OutlineThickness = 1F;
            cuiButton2.PressedBackground = Color.WhiteSmoke;
            cuiButton2.PressedForeColor = Color.FromArgb(32, 32, 32);
            cuiButton2.PressedImageTint = Color.White;
            cuiButton2.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            cuiButton2.Rounding = new Padding(8);
            cuiButton2.Size = new Size(112, 40);
            cuiButton2.TabIndex = 27;
            cuiButton2.TextAlignment = StringAlignment.Center;
            cuiButton2.TextOffset = new Point(0, 0);
            // 
            // cuiButton3
            // 
            cuiButton3.BackColor = Color.Transparent;
            cuiButton3.BackgroundImage = (Image)resources.GetObject("cuiButton3.BackgroundImage");
            cuiButton3.BackgroundImageLayout = ImageLayout.Zoom;
            cuiButton3.CheckButton = false;
            cuiButton3.Checked = false;
            cuiButton3.CheckedBackground = Color.FromArgb(255, 106, 0);
            cuiButton3.CheckedForeColor = SystemColors.ButtonHighlight;
            cuiButton3.CheckedImageTint = SystemColors.ButtonHighlight;
            cuiButton3.CheckedOutline = Color.FromArgb(255, 106, 0);
            cuiButton3.Content = "Edit";
            cuiButton3.DialogResult = DialogResult.None;
            cuiButton3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            cuiButton3.ForeColor = Color.FromArgb(50, 81, 88);
            cuiButton3.HoverBackground = Color.Transparent;
            cuiButton3.HoveredImageTint = Color.Transparent;
            cuiButton3.HoverForeColor = Color.Black;
            cuiButton3.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            cuiButton3.Image = null;
            cuiButton3.ImageAutoCenter = true;
            cuiButton3.ImageExpand = new Point(0, 0);
            cuiButton3.ImageOffset = new Point(0, 0);
            cuiButton3.Location = new Point(442, 453);
            cuiButton3.Name = "cuiButton3";
            cuiButton3.NormalBackground = Color.White;
            cuiButton3.NormalForeColor = Color.FromArgb(50, 81, 88);
            cuiButton3.NormalImageTint = Color.White;
            cuiButton3.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            cuiButton3.OutlineThickness = 1F;
            cuiButton3.PressedBackground = Color.WhiteSmoke;
            cuiButton3.PressedForeColor = Color.FromArgb(32, 32, 32);
            cuiButton3.PressedImageTint = Color.White;
            cuiButton3.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            cuiButton3.Rounding = new Padding(8);
            cuiButton3.Size = new Size(112, 40);
            cuiButton3.TabIndex = 28;
            cuiButton3.TextAlignment = StringAlignment.Center;
            cuiButton3.TextOffset = new Point(0, 0);
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
        private CuoreUI.Controls.cuiButton cuiButton1;
        private CuoreUI.Controls.cuiButton cuiButton3;
        private CuoreUI.Controls.cuiButton cuiButton2;
    }
}