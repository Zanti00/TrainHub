namespace TrainHub
{
    partial class UpdatePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdatePassword));
            panel1 = new Panel();
            showPassBtn1 = new PictureBox();
            showPassBtn2 = new PictureBox();
            updatePasswordBtn = new CuoreUI.Controls.cuiButton();
            newPasswordTxt2 = new CuoreUI.Controls.cuiTextBox();
            newPasswordTxt1 = new CuoreUI.Controls.cuiTextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)showPassBtn1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)showPassBtn2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.Controls.Add(showPassBtn1);
            panel1.Controls.Add(showPassBtn2);
            panel1.Controls.Add(updatePasswordBtn);
            panel1.Controls.Add(newPasswordTxt2);
            panel1.Controls.Add(newPasswordTxt1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-5, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(770, 500);
            panel1.TabIndex = 0;
            // 
            // showPassBtn1
            // 
            showPassBtn1.BackColor = Color.White;
            showPassBtn1.BackgroundImage = (Image)resources.GetObject("showPassBtn1.BackgroundImage");
            showPassBtn1.BackgroundImageLayout = ImageLayout.Zoom;
            showPassBtn1.Location = new Point(513, 243);
            showPassBtn1.Name = "showPassBtn1";
            showPassBtn1.Size = new Size(25, 20);
            showPassBtn1.TabIndex = 15;
            showPassBtn1.TabStop = false;
            showPassBtn1.Click += showPassBtn1_Click;
            // 
            // showPassBtn2
            // 
            showPassBtn2.BackColor = Color.White;
            showPassBtn2.BackgroundImage = (Image)resources.GetObject("showPassBtn2.BackgroundImage");
            showPassBtn2.BackgroundImageLayout = ImageLayout.Zoom;
            showPassBtn2.Location = new Point(513, 287);
            showPassBtn2.Name = "showPassBtn2";
            showPassBtn2.Size = new Size(25, 20);
            showPassBtn2.TabIndex = 14;
            showPassBtn2.TabStop = false;
            showPassBtn2.Click += showPassBtn2_Click;
            // 
            // updatePasswordBtn
            // 
            updatePasswordBtn.Anchor = AnchorStyles.None;
            updatePasswordBtn.BackColor = Color.Transparent;
            updatePasswordBtn.CheckButton = false;
            updatePasswordBtn.Checked = false;
            updatePasswordBtn.CheckedBackground = Color.FromArgb(50, 81, 88);
            updatePasswordBtn.CheckedForeColor = Color.White;
            updatePasswordBtn.CheckedImageTint = Color.White;
            updatePasswordBtn.CheckedOutline = Color.FromArgb(50, 81, 88);
            updatePasswordBtn.Content = "UPDATE PASSWORD";
            updatePasswordBtn.DialogResult = DialogResult.None;
            updatePasswordBtn.Font = new Font("Microsoft Sans Serif", 8F);
            updatePasswordBtn.ForeColor = Color.White;
            updatePasswordBtn.HoverBackground = Color.FromArgb(22, 36, 39);
            updatePasswordBtn.HoveredImageTint = Color.White;
            updatePasswordBtn.HoverForeColor = Color.White;
            updatePasswordBtn.HoverOutline = Color.FromArgb(22, 36, 39);
            updatePasswordBtn.Image = null;
            updatePasswordBtn.ImageAutoCenter = true;
            updatePasswordBtn.ImageExpand = new Point(0, 0);
            updatePasswordBtn.ImageOffset = new Point(0, 0);
            updatePasswordBtn.Location = new Point(236, 340);
            updatePasswordBtn.Name = "updatePasswordBtn";
            updatePasswordBtn.NormalBackground = Color.FromArgb(50, 81, 88);
            updatePasswordBtn.NormalForeColor = Color.White;
            updatePasswordBtn.NormalImageTint = Color.White;
            updatePasswordBtn.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            updatePasswordBtn.OutlineThickness = 1F;
            updatePasswordBtn.PressedBackground = Color.FromArgb(22, 36, 39);
            updatePasswordBtn.PressedForeColor = Color.White;
            updatePasswordBtn.PressedImageTint = Color.White;
            updatePasswordBtn.PressedOutline = Color.FromArgb(22, 36, 39);
            updatePasswordBtn.Rounding = new Padding(3);
            updatePasswordBtn.Size = new Size(313, 35);
            updatePasswordBtn.TabIndex = 6;
            updatePasswordBtn.TextAlignment = StringAlignment.Center;
            updatePasswordBtn.TextOffset = new Point(0, 0);
            updatePasswordBtn.Click += updatePasswordBtn_Click;
            // 
            // newPasswordTxt2
            // 
            newPasswordTxt2.Anchor = AnchorStyles.None;
            newPasswordTxt2.BackColor = Color.Transparent;
            newPasswordTxt2.BackgroundColor = Color.White;
            newPasswordTxt2.BorderColor = Color.FromArgb(128, 128, 128, 128);
            newPasswordTxt2.Content = "";
            newPasswordTxt2.FocusBackgroundColor = Color.White;
            newPasswordTxt2.FocusBorderColor = Color.FromArgb(50, 81, 88);
            newPasswordTxt2.FocusImageTint = Color.White;
            newPasswordTxt2.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            newPasswordTxt2.ForeColor = Color.Gray;
            newPasswordTxt2.Image = null;
            newPasswordTxt2.ImageExpand = new Point(0, 0);
            newPasswordTxt2.ImageOffset = new Point(0, 0);
            newPasswordTxt2.Location = new Point(236, 279);
            newPasswordTxt2.Margin = new Padding(4);
            newPasswordTxt2.Multiline = false;
            newPasswordTxt2.Name = "newPasswordTxt2";
            newPasswordTxt2.NormalImageTint = Color.White;
            newPasswordTxt2.Padding = new Padding(15, 10, 15, 0);
            newPasswordTxt2.PasswordChar = true;
            newPasswordTxt2.PlaceholderColor = SystemColors.InactiveCaption;
            newPasswordTxt2.PlaceholderText = "Re-enter your new password";
            newPasswordTxt2.Rounding = new Padding(8);
            newPasswordTxt2.Size = new Size(313, 35);
            newPasswordTxt2.TabIndex = 5;
            newPasswordTxt2.TextOffset = new Size(0, 0);
            newPasswordTxt2.UnderlinedStyle = false;
            // 
            // newPasswordTxt1
            // 
            newPasswordTxt1.Anchor = AnchorStyles.None;
            newPasswordTxt1.BackColor = Color.Transparent;
            newPasswordTxt1.BackgroundColor = Color.White;
            newPasswordTxt1.BorderColor = Color.FromArgb(128, 128, 128, 128);
            newPasswordTxt1.Content = "";
            newPasswordTxt1.FocusBackgroundColor = Color.White;
            newPasswordTxt1.FocusBorderColor = Color.FromArgb(50, 81, 88);
            newPasswordTxt1.FocusImageTint = Color.White;
            newPasswordTxt1.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            newPasswordTxt1.ForeColor = Color.Gray;
            newPasswordTxt1.Image = null;
            newPasswordTxt1.ImageExpand = new Point(0, 0);
            newPasswordTxt1.ImageOffset = new Point(0, 0);
            newPasswordTxt1.Location = new Point(236, 235);
            newPasswordTxt1.Margin = new Padding(4);
            newPasswordTxt1.Multiline = false;
            newPasswordTxt1.Name = "newPasswordTxt1";
            newPasswordTxt1.NormalImageTint = Color.White;
            newPasswordTxt1.Padding = new Padding(15, 10, 15, 0);
            newPasswordTxt1.PasswordChar = true;
            newPasswordTxt1.PlaceholderColor = SystemColors.InactiveCaption;
            newPasswordTxt1.PlaceholderText = "Enter your new password";
            newPasswordTxt1.Rounding = new Padding(8);
            newPasswordTxt1.Size = new Size(313, 35);
            newPasswordTxt1.TabIndex = 4;
            newPasswordTxt1.TextOffset = new Size(0, 0);
            newPasswordTxt1.UnderlinedStyle = false;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(130, 130, 130);
            label3.Location = new Point(236, 192);
            label3.Margin = new Padding(10, 15, 3, 0);
            label3.Name = "label3";
            label3.Size = new Size(110, 15);
            label3.TabIndex = 3;
            label3.Text = "Set a new password";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.ForeColor = Color.FromArgb(0, 0, 64);
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(233, 148);
            label2.Margin = new Padding(5, 0, 3, 0);
            label2.Name = "label2";
            label2.Size = new Size(137, 28);
            label2.TabIndex = 2;
            label2.Text = "New Password";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(50, 81, 88);
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(229, 103);
            label1.Name = "label1";
            label1.Size = new Size(142, 37);
            label1.TabIndex = 1;
            label1.Text = "TrainHub";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // UpdatePassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(760, 502);
            Controls.Add(panel1);
            Name = "UpdatePassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Update password";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)showPassBtn1).EndInit();
            ((System.ComponentModel.ISupportInitialize)showPassBtn2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private CuoreUI.Controls.cuiTextBox newPasswordTxt1;
        private CuoreUI.Controls.cuiTextBox newPasswordTxt2;
        private CuoreUI.Controls.cuiButton updatePasswordBtn;
        private PictureBox showPassBtn2;
        private PictureBox showPassBtn1;
    }
}