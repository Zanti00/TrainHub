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
            updatePasswordBtn = new CustomButton();
            showPassBtn1 = new PictureBox();
            showPassBtn2 = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            newPasswordTxt1 = new TrainHub.User_Controls.CustomTextFields();
            newPasswordTxt2 = new TrainHub.User_Controls.CustomTextFields();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)showPassBtn1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)showPassBtn2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.Controls.Add(updatePasswordBtn);
            panel1.Controls.Add(showPassBtn1);
            panel1.Controls.Add(showPassBtn2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(newPasswordTxt1);
            panel1.Controls.Add(newPasswordTxt2);
            panel1.Location = new Point(-43, -6);
            panel1.Name = "panel1";
            panel1.Size = new Size(770, 500);
            panel1.TabIndex = 0;
            // 
            // updatePasswordBtn
            // 
            updatePasswordBtn.Anchor = AnchorStyles.None;
            updatePasswordBtn.BackColor = Color.Transparent;
            updatePasswordBtn.ButtonContent = "BUTTON";
            updatePasswordBtn.Location = new Point(233, 332);
            updatePasswordBtn.Name = "updatePasswordBtn";
            updatePasswordBtn.Size = new Size(321, 43);
            updatePasswordBtn.TabIndex = 16;
            // 
            // showPassBtn1
            // 
            showPassBtn1.Anchor = AnchorStyles.None;
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
            showPassBtn2.Anchor = AnchorStyles.None;
            showPassBtn2.BackColor = Color.White;
            showPassBtn2.BackgroundImage = (Image)resources.GetObject("showPassBtn2.BackgroundImage");
            showPassBtn2.BackgroundImageLayout = ImageLayout.Zoom;
            showPassBtn2.Location = new Point(513, 291);
            showPassBtn2.Name = "showPassBtn2";
            showPassBtn2.Size = new Size(25, 20);
            showPassBtn2.TabIndex = 14;
            showPassBtn2.TabStop = false;
            showPassBtn2.Click += showPassBtn2_Click;
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
            // newPasswordTxt1
            // 
            newPasswordTxt1.Anchor = AnchorStyles.None;
            newPasswordTxt1.BackColor = Color.Transparent;
            newPasswordTxt1.Location = new Point(237, 230);
            newPasswordTxt1.Name = "newPasswordTxt1";
            newPasswordTxt1.PasswordChar = false;
            newPasswordTxt1.PlaceHolderText = "Enter your text";
            newPasswordTxt1.Size = new Size(317, 42);
            newPasswordTxt1.TabIndex = 17;
            newPasswordTxt1.TextContent = "";
            // 
            // newPasswordTxt2
            // 
            newPasswordTxt2.Anchor = AnchorStyles.None;
            newPasswordTxt2.BackColor = Color.Transparent;
            newPasswordTxt2.Location = new Point(237, 278);
            newPasswordTxt2.Name = "newPasswordTxt2";
            newPasswordTxt2.PasswordChar = false;
            newPasswordTxt2.PlaceHolderText = "Enter your text";
            newPasswordTxt2.Size = new Size(317, 42);
            newPasswordTxt2.TabIndex = 18;
            newPasswordTxt2.TextContent = "";
            // 
            // UpdatePassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(684, 488);
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
        private PictureBox showPassBtn2;
        private PictureBox showPassBtn1;
        private CustomButton updatePasswordBtn;
        private User_Controls.CustomTextFields newPasswordTxt1;
        private User_Controls.CustomTextFields newPasswordTxt2;
    }
}