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
            verificationBtn = new CuoreUI.Controls.cuiButton();
            label2 = new Label();
            label1 = new Label();
            backBtn = new CuoreUI.Controls.cuiButton();
            tableLayoutPanel1 = new TableLayoutPanel();
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
            verificationCodeTxtBox.Location = new Point(125, 227);
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
            panel1.Controls.Add(verificationBtn);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(verificationCodeTxtBox);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(73, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(680, 515);
            panel1.TabIndex = 3;
            // 
            // verificationBtn
            // 
            verificationBtn.Anchor = AnchorStyles.None;
            verificationBtn.BackColor = Color.Transparent;
            verificationBtn.CheckButton = false;
            verificationBtn.Checked = false;
            verificationBtn.CheckedBackground = Color.FromArgb(50, 81, 88);
            verificationBtn.CheckedForeColor = Color.White;
            verificationBtn.CheckedImageTint = Color.White;
            verificationBtn.CheckedOutline = Color.FromArgb(50, 81, 88);
            verificationBtn.Content = "CONTINUE";
            verificationBtn.DialogResult = DialogResult.None;
            verificationBtn.Font = new Font("Microsoft Sans Serif", 8F);
            verificationBtn.ForeColor = Color.White;
            verificationBtn.HoverBackground = Color.FromArgb(22, 36, 39);
            verificationBtn.HoveredImageTint = Color.White;
            verificationBtn.HoverForeColor = Color.White;
            verificationBtn.HoverOutline = Color.FromArgb(22, 36, 39);
            verificationBtn.Image = null;
            verificationBtn.ImageAutoCenter = true;
            verificationBtn.ImageExpand = new Point(0, 0);
            verificationBtn.ImageOffset = new Point(0, 0);
            verificationBtn.Location = new Point(125, 298);
            verificationBtn.Name = "verificationBtn";
            verificationBtn.NormalBackground = Color.FromArgb(50, 81, 88);
            verificationBtn.NormalForeColor = Color.White;
            verificationBtn.NormalImageTint = Color.White;
            verificationBtn.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            verificationBtn.OutlineThickness = 1F;
            verificationBtn.PressedBackground = Color.FromArgb(22, 36, 39);
            verificationBtn.PressedForeColor = Color.White;
            verificationBtn.PressedImageTint = Color.White;
            verificationBtn.PressedOutline = Color.FromArgb(22, 36, 39);
            verificationBtn.Rounding = new Padding(3);
            verificationBtn.Size = new Size(315, 35);
            verificationBtn.TabIndex = 5;
            verificationBtn.TextAlignment = StringAlignment.Center;
            verificationBtn.TextOffset = new Point(0, 0);
            verificationBtn.Click += verificationBtn_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(130, 130, 130);
            label2.Location = new Point(125, 195);
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
            label1.Location = new Point(119, 142);
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
            tableLayoutPanel1.Size = new Size(756, 521);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // VerifyCode
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(756, 521);
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
    }
}