namespace TrainHub
{
    partial class update_email
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
            cuiPanel1 = new CuoreUI.Controls.cuiPanel();
            loginBtn = new CuoreUI.Controls.cuiButtonGroup();
            cuiTextBox1 = new CuoreUI.Controls.cuiTextBox();
            label5 = new Label();
            passwordTxt = new CuoreUI.Controls.cuiTextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cuiPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // cuiPanel1
            // 
            cuiPanel1.BackColor = SystemColors.ButtonHighlight;
            cuiPanel1.Controls.Add(loginBtn);
            cuiPanel1.Controls.Add(cuiTextBox1);
            cuiPanel1.Controls.Add(label5);
            cuiPanel1.Controls.Add(passwordTxt);
            cuiPanel1.Controls.Add(label4);
            cuiPanel1.Controls.Add(label3);
            cuiPanel1.Controls.Add(label2);
            cuiPanel1.Controls.Add(label1);
            cuiPanel1.Location = new Point(41, 33);
            cuiPanel1.Name = "cuiPanel1";
            cuiPanel1.OutlineThickness = 1F;
            cuiPanel1.PanelColor = Color.White;
            cuiPanel1.PanelOutlineColor = Color.Black;
            cuiPanel1.Rounding = new Padding(8);
            cuiPanel1.Size = new Size(653, 576);
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
            loginBtn.Location = new Point(133, 457);
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
            cuiTextBox1.Location = new Point(133, 371);
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
            cuiTextBox1.ContentChanged += cuiTextBox1_ContentChanged;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(0, 0, 64);
            label5.ImageAlign = ContentAlignment.MiddleLeft;
            label5.Location = new Point(133, 346);
            label5.Margin = new Padding(6, 0, 3, 0);
            label5.Name = "label5";
            label5.Size = new Size(127, 20);
            label5.TabIndex = 18;
            label5.Text = "Confirm Password";
            label5.TextAlign = ContentAlignment.MiddleLeft;
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
            passwordTxt.Location = new Point(133, 266);
            passwordTxt.Margin = new Padding(5);
            passwordTxt.Multiline = false;
            passwordTxt.Name = "passwordTxt";
            passwordTxt.NormalImageTint = Color.White;
            passwordTxt.Padding = new Padding(16, 12, 16, 0);
            passwordTxt.PasswordChar = true;
            passwordTxt.PlaceholderColor = SystemColors.ScrollBar;
            passwordTxt.PlaceholderText = "Please enter your new email...";
            passwordTxt.Rounding = new Padding(6);
            passwordTxt.Size = new Size(336, 40);
            passwordTxt.TabIndex = 17;
            passwordTxt.TextOffset = new Size(0, 0);
            passwordTxt.UnderlinedStyle = false;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(0, 0, 64);
            label4.ImageAlign = ContentAlignment.MiddleLeft;
            label4.Location = new Point(133, 241);
            label4.Margin = new Padding(6, 0, 3, 0);
            label4.Name = "label4";
            label4.Size = new Size(118, 20);
            label4.TabIndex = 16;
            label4.Text = "Enter New Email";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(130, 130, 130);
            label3.Location = new Point(133, 181);
            label3.Margin = new Padding(11, 20, 3, 0);
            label3.Name = "label3";
            label3.Size = new Size(135, 20);
            label3.TabIndex = 15;
            label3.Text = "Update your Email.";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 0, 64);
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(133, 121);
            label2.Margin = new Padding(6, 0, 3, 0);
            label2.Name = "label2";
            label2.Size = new Size(188, 40);
            label2.TabIndex = 14;
            label2.Text = "Update Email";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(50, 81, 88);
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(133, 58);
            label1.Name = "label1";
            label1.Size = new Size(177, 46);
            label1.TabIndex = 13;
            label1.Text = "TrainHub";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            label1.Click += label1_Click;
            // 
            // update_email
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(736, 671);
            Controls.Add(cuiPanel1);
            Name = "update_email";
            Text = "Form1";
            cuiPanel1.ResumeLayout(false);
            cuiPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private CuoreUI.Controls.cuiPanel cuiPanel1;
        private CuoreUI.Controls.cuiButtonGroup loginBtn;
        private CuoreUI.Controls.cuiTextBox cuiTextBox1;
        private Label label5;
        private CuoreUI.Controls.cuiTextBox passwordTxt;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}