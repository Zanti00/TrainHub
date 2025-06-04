namespace TrainHub
{
    partial class VerifyCode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerifyCode));
            verificationCodeTxtBox = new CuoreUI.Controls.cuiOTPasswordBox();
            panel1 = new Panel();
            resendLink = new Label();
            label3 = new Label();
            verificationBtn = new CustomButton();
            label2 = new Label();
            label1 = new Label();
            backBtn = new CuoreUI.Controls.cuiButton();
            tableLayoutPanel1 = new TableLayoutPanel();
            backBtn = new TrainHub.User_Controls.CustomBackButton();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // verificationCodeTxtBox
            // 
            verificationCodeTxtBox.Anchor = AnchorStyles.None;
            verificationCodeTxtBox.BoxAmount = 6;
            verificationCodeTxtBox.Content = "";
            verificationCodeTxtBox.FocusedBorderColor = Color.FromArgb(50, 81, 88);
            verificationCodeTxtBox.FocusedColor = Color.FromArgb(32, 128, 128, 128);
            verificationCodeTxtBox.FocusedTextColor = Color.Black;
            verificationCodeTxtBox.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Bold);
            verificationCodeTxtBox.Location = new Point(104, 218);
            verificationCodeTxtBox.Name = "verificationCodeTxtBox";
            verificationCodeTxtBox.OnlyDigit = false;
            verificationCodeTxtBox.Rounding = 8;
            verificationCodeTxtBox.Size = new Size(315, 45);
            verificationCodeTxtBox.TabIndex = 1;
            verificationCodeTxtBox.UnderlinedStyle = false;
            verificationCodeTxtBox.UnfocusedBorderColor = Color.FromArgb(64, 128, 128, 128);
            verificationCodeTxtBox.UnfocusedColor = Color.FromArgb(32, 128, 128, 128);
            verificationCodeTxtBox.UnfocusedTextColor = Color.Gray;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(resendLink);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(verificationBtn);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(verificationCodeTxtBox);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(73, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(639, 496);
            panel1.TabIndex = 3;
            // 
            // resendLink
            // 
            resendLink.Anchor = AnchorStyles.None;
            resendLink.AutoSize = true;
            resendLink.BackColor = Color.Transparent;
            resendLink.Cursor = Cursors.Hand;
            resendLink.ForeColor = Color.Red;
            resendLink.Location = new Point(311, 339);
            resendLink.Name = "resendLink";
            resendLink.Size = new Size(45, 15);
            resendLink.TabIndex = 6;
            resendLink.Text = "Resend";
            resendLink.Click += resendLink_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(130, 130, 130);
            label3.Location = new Point(161, 339);
            label3.Name = "label3";
            label3.Size = new Size(152, 15);
            label3.TabIndex = 5;
            label3.Text = "If you didn’t receive a code!";
            // 
            // verificationBtn
            // 
            verificationBtn.Anchor = AnchorStyles.None;
            verificationBtn.BackColor = Color.Transparent;
            verificationBtn.ButtonContent = "BUTTON";
            verificationBtn.Location = new Point(101, 283);
            verificationBtn.Name = "verificationBtn";
            verificationBtn.Size = new Size(321, 43);
            verificationBtn.TabIndex = 4;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(130, 130, 130);
            label2.Location = new Point(104, 186);
            label2.Name = "label2";
            label2.Size = new Size(236, 15);
            label2.TabIndex = 3;
            label2.Text = "Enter the 6 digits code sent to you via email";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.ForeColor = Color.FromArgb(0, 0, 64);
            label1.Location = new Point(98, 133);
            label1.Name = "label1";
            label1.Size = new Size(150, 37);
            label1.TabIndex = 2;
            label1.Text = "Verification";
            // 
            // backBtn
            // 
            backBtn.CheckButton = false;
            backBtn.Checked = false;
            backBtn.CheckedBackground = Color.Transparent;
            backBtn.CheckedForeColor = Color.Black;
            backBtn.CheckedImageTint = Color.Black;
            backBtn.CheckedOutline = Color.Transparent;
            backBtn.Content = "back";
            backBtn.DialogResult = DialogResult.None;
            backBtn.Font = new Font("Microsoft Sans Serif", 9.75F);
            backBtn.ForeColor = Color.Black;
            backBtn.HoverBackground = Color.Transparent;
            backBtn.HoveredImageTint = Color.Black;
            backBtn.HoverForeColor = Color.Black;
            backBtn.HoverOutline = Color.Transparent;
            backBtn.Image = (Image)resources.GetObject("backBtn.Image");
            backBtn.ImageAutoCenter = true;
            backBtn.ImageExpand = new Point(3, 3);
            backBtn.ImageOffset = new Point(-3, 0);
            backBtn.Location = new Point(3, 3);
            backBtn.Name = "backBtn";
            backBtn.NormalBackground = Color.Transparent;
            backBtn.NormalForeColor = Color.Black;
            backBtn.NormalImageTint = Color.Black;
            backBtn.NormalOutline = Color.Transparent;
            backBtn.OutlineThickness = 1F;
            backBtn.PressedBackground = Color.Transparent;
            backBtn.PressedForeColor = Color.Black;
            backBtn.PressedImageTint = Color.Black;
            backBtn.PressedOutline = Color.Transparent;
            backBtn.Rounding = new Padding(8);
            backBtn.Size = new Size(64, 45);
            backBtn.TabIndex = 6;
            backBtn.TextAlignment = StringAlignment.Center;
            backBtn.TextOffset = new Point(0, 0);
            backBtn.Click += backBtn_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 70F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel1, 1, 0);
            tableLayoutPanel1.Controls.Add(backBtn, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(715, 502);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // backBtn
            // 
            backBtn.BackColor = Color.Transparent;
            backBtn.Location = new Point(3, 3);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(64, 52);
            backBtn.TabIndex = 4;
            // 
            // VerifyCode
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(715, 502);
            Controls.Add(tableLayoutPanel1);
            Name = "VerifyCode";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Verify code";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private CuoreUI.Controls.cuiOTPasswordBox verificationCodeTxtBox;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private CuoreUI.Controls.cuiButton verificationBtn;
        private CuoreUI.Controls.cuiButton backBtn;
        private TableLayoutPanel tableLayoutPanel1;
        private CustomButton verificationBtn;
        private Label label3;
        private Label resendLink;
        private User_Controls.CustomBackButton backBtn;
    }
}