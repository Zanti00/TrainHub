namespace TrainHub
{
    partial class Settings
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
            label1 = new Label();
            cuiPanel1 = new CuoreUI.Controls.cuiPanel();
            phoneNumberLabel = new Label();
            cuiPanel3 = new CuoreUI.Controls.cuiPanel();
            label5 = new Label();
            emailLabel = new Label();
            cuiPanel2 = new CuoreUI.Controls.cuiPanel();
            label6 = new Label();
            editBtn = new CuoreUI.Controls.cuiButtonGroup();
            label3 = new Label();
            usernameLabel = new Label();
            cuiPanel4 = new CuoreUI.Controls.cuiPanel();
            label4 = new Label();
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
            label1.Location = new Point(150, 118);
            label1.Name = "label1";
            label1.Size = new Size(126, 36);
            label1.TabIndex = 13;
            label1.Text = "Settings";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cuiPanel1
            // 
            cuiPanel1.BackColor = SystemColors.ButtonHighlight;
            cuiPanel1.Controls.Add(usernameLabel);
            cuiPanel1.Controls.Add(cuiPanel4);
            cuiPanel1.Controls.Add(label4);
            cuiPanel1.Controls.Add(phoneNumberLabel);
            cuiPanel1.Controls.Add(cuiPanel3);
            cuiPanel1.Controls.Add(label5);
            cuiPanel1.Controls.Add(emailLabel);
            cuiPanel1.Controls.Add(cuiPanel2);
            cuiPanel1.Controls.Add(label6);
            cuiPanel1.Controls.Add(editBtn);
            cuiPanel1.Controls.Add(label3);
            cuiPanel1.Controls.Add(label1);
            cuiPanel1.Dock = DockStyle.Fill;
            cuiPanel1.Location = new Point(0, 0);
            cuiPanel1.Margin = new Padding(3, 2, 3, 2);
            cuiPanel1.Name = "cuiPanel1";
            cuiPanel1.OutlineThickness = 1F;
            cuiPanel1.PanelColor = Color.White;
            cuiPanel1.PanelOutlineColor = Color.Black;
            cuiPanel1.Rounding = new Padding(8);
            cuiPanel1.Size = new Size(646, 514);
            cuiPanel1.TabIndex = 10;
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.Anchor = AnchorStyles.None;
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.ForeColor = Color.FromArgb(130, 130, 130);
            phoneNumberLabel.Location = new Point(154, 298);
            phoneNumberLabel.Margin = new Padding(10, 15, 3, 0);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new Size(73, 15);
            phoneNumberLabel.TabIndex = 32;
            phoneNumberLabel.Text = "09123456789";
            // 
            // cuiPanel3
            // 
            cuiPanel3.Anchor = AnchorStyles.None;
            cuiPanel3.Location = new Point(157, 319);
            cuiPanel3.Name = "cuiPanel3";
            cuiPanel3.OutlineThickness = 1F;
            cuiPanel3.PanelColor = Color.FromArgb(50, 81, 88);
            cuiPanel3.PanelOutlineColor = Color.Transparent;
            cuiPanel3.Rounding = new Padding(8);
            cuiPanel3.Size = new Size(314, 2);
            cuiPanel3.TabIndex = 31;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(0, 0, 64);
            label5.ImageAlign = ContentAlignment.MiddleLeft;
            label5.Location = new Point(154, 275);
            label5.Margin = new Padding(5, 0, 3, 0);
            label5.Name = "label5";
            label5.Size = new Size(82, 15);
            label5.TabIndex = 30;
            label5.Text = "Phon Number";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // emailLabel
            // 
            emailLabel.Anchor = AnchorStyles.None;
            emailLabel.AutoSize = true;
            emailLabel.ForeColor = Color.FromArgb(130, 130, 130);
            emailLabel.Location = new Point(154, 234);
            emailLabel.Margin = new Padding(10, 15, 3, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(108, 15);
            emailLabel.TabIndex = 29;
            emailLabel.Text = "example@test.com";
            // 
            // cuiPanel2
            // 
            cuiPanel2.Anchor = AnchorStyles.None;
            cuiPanel2.Location = new Point(157, 255);
            cuiPanel2.Name = "cuiPanel2";
            cuiPanel2.OutlineThickness = 1F;
            cuiPanel2.PanelColor = Color.FromArgb(50, 81, 88);
            cuiPanel2.PanelOutlineColor = Color.Transparent;
            cuiPanel2.Rounding = new Padding(8);
            cuiPanel2.Size = new Size(314, 2);
            cuiPanel2.TabIndex = 28;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(0, 0, 64);
            label6.ImageAlign = ContentAlignment.MiddleLeft;
            label6.Location = new Point(154, 211);
            label6.Margin = new Padding(5, 0, 3, 0);
            label6.Name = "label6";
            label6.Size = new Size(81, 15);
            label6.TabIndex = 22;
            label6.Text = "Email Address";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // editBtn
            // 
            editBtn.Anchor = AnchorStyles.None;
            editBtn.BackColor = Color.Transparent;
            editBtn.Checked = false;
            editBtn.CheckedBackground = Color.FromArgb(50, 81, 88);
            editBtn.CheckedForeColor = Color.White;
            editBtn.CheckedImageTint = Color.White;
            editBtn.CheckedOutline = Color.FromArgb(50, 81, 88);
            editBtn.Content = "EDIT INFO";
            editBtn.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            editBtn.ForeColor = Color.White;
            editBtn.Group = 0;
            editBtn.HoverBackground = Color.White;
            editBtn.HoveredImageTint = Color.White;
            editBtn.HoverForeColor = Color.Black;
            editBtn.HoverOutline = Color.FromArgb(22, 36, 39);
            editBtn.Image = null;
            editBtn.ImageAutoCenter = true;
            editBtn.ImageExpand = new Point(0, 0);
            editBtn.ImageOffset = new Point(0, 0);
            editBtn.Location = new Point(372, 407);
            editBtn.Name = "editBtn";
            editBtn.NormalBackground = Color.FromArgb(50, 81, 88);
            editBtn.NormalForeColor = Color.White;
            editBtn.NormalImageTint = Color.White;
            editBtn.NormalOutline = Color.FromArgb(50, 81, 88);
            editBtn.OutlineThickness = 1F;
            editBtn.PressedBackground = Color.FromArgb(22, 36, 39);
            editBtn.PressedForeColor = Color.White;
            editBtn.PressedImageTint = Color.White;
            editBtn.PressedOutline = Color.FromArgb(22, 36, 39);
            editBtn.Rounding = new Padding(6);
            editBtn.Size = new Size(99, 34);
            editBtn.TabIndex = 21;
            editBtn.TextAlignment = StringAlignment.Center;
            editBtn.TextOffset = new Point(0, 0);
            editBtn.Click += editBtn_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(130, 130, 130);
            label3.Location = new Point(154, 159);
            label3.Margin = new Padding(10, 15, 3, 0);
            label3.Name = "label3";
            label3.Size = new Size(170, 15);
            label3.TabIndex = 15;
            label3.Text = "Make changes to your account";
            // 
            // usernameLabel
            // 
            usernameLabel.Anchor = AnchorStyles.None;
            usernameLabel.AutoSize = true;
            usernameLabel.ForeColor = Color.FromArgb(130, 130, 130);
            usernameLabel.Location = new Point(154, 363);
            usernameLabel.Margin = new Padding(10, 15, 3, 0);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(59, 15);
            usernameLabel.TabIndex = 35;
            usernameLabel.Text = "username";
            // 
            // cuiPanel4
            // 
            cuiPanel4.Anchor = AnchorStyles.None;
            cuiPanel4.Location = new Point(157, 384);
            cuiPanel4.Name = "cuiPanel4";
            cuiPanel4.OutlineThickness = 1F;
            cuiPanel4.PanelColor = Color.FromArgb(50, 81, 88);
            cuiPanel4.PanelOutlineColor = Color.Transparent;
            cuiPanel4.Rounding = new Padding(8);
            cuiPanel4.Size = new Size(314, 2);
            cuiPanel4.TabIndex = 34;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(0, 0, 64);
            label4.ImageAlign = ContentAlignment.MiddleLeft;
            label4.Location = new Point(154, 340);
            label4.Margin = new Padding(5, 0, 3, 0);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 33;
            label4.Text = "Username";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(646, 514);
            Controls.Add(cuiPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Settings";
            Text = "Admin_Settings";
            cuiPanel1.ResumeLayout(false);
            cuiPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private CuoreUI.Controls.cuiPanel cuiPanel1;
        private CuoreUI.Controls.cuiButtonGroup editBtn;
        private Label label3;
        private Label label6;
        private CuoreUI.Controls.cuiPanel cuiPanel2;
        private Label phoneNumberLabel;
        private CuoreUI.Controls.cuiPanel cuiPanel3;
        private Label label5;
        private Label emailLabel;
        private Label usernameLabel;
        private CuoreUI.Controls.cuiPanel cuiPanel4;
        private Label label4;
    }
}