namespace TrainHub
{
    partial class ConfirmPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfirmPassword));
            cuiPanel1 = new CuoreUI.Controls.cuiPanel();
            showPassBtn = new PictureBox();
            label5 = new Label();
            passwordTxt = new CuoreUI.Controls.cuiTextBox();
            doneBtn = new CuoreUI.Controls.cuiButtonGroup();
            cuiPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)showPassBtn).BeginInit();
            SuspendLayout();
            // 
            // cuiPanel1
            // 
            cuiPanel1.BackColor = SystemColors.ButtonHighlight;
            cuiPanel1.Controls.Add(showPassBtn);
            cuiPanel1.Controls.Add(label5);
            cuiPanel1.Controls.Add(passwordTxt);
            cuiPanel1.Controls.Add(doneBtn);
            cuiPanel1.Dock = DockStyle.Fill;
            cuiPanel1.Location = new Point(0, 0);
            cuiPanel1.Margin = new Padding(3, 2, 3, 2);
            cuiPanel1.Name = "cuiPanel1";
            cuiPanel1.OutlineThickness = 1F;
            cuiPanel1.PanelColor = Color.White;
            cuiPanel1.PanelOutlineColor = Color.Transparent;
            cuiPanel1.Rounding = new Padding(8);
            cuiPanel1.Size = new Size(475, 161);
            cuiPanel1.TabIndex = 10;
            // 
            // showPassBtn
            // 
            showPassBtn.BackColor = Color.White;
            showPassBtn.BackgroundImage = (Image)resources.GetObject("showPassBtn.BackgroundImage");
            showPassBtn.BackgroundImageLayout = ImageLayout.Zoom;
            showPassBtn.Location = new Point(324, 48);
            showPassBtn.Name = "showPassBtn";
            showPassBtn.Size = new Size(21, 23);
            showPassBtn.TabIndex = 30;
            showPassBtn.TabStop = false;
            showPassBtn.Click += showPassBtn_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(0, 0, 64);
            label5.ImageAlign = ContentAlignment.MiddleLeft;
            label5.Location = new Point(96, 18);
            label5.Margin = new Padding(5, 0, 3, 0);
            label5.Name = "label5";
            label5.Size = new Size(149, 20);
            label5.TabIndex = 29;
            label5.Text = "Enter your password";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // passwordTxt
            // 
            passwordTxt.Anchor = AnchorStyles.None;
            passwordTxt.BackColor = Color.Transparent;
            passwordTxt.BackgroundColor = Color.White;
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
            passwordTxt.Location = new Point(96, 41);
            passwordTxt.Margin = new Padding(4);
            passwordTxt.Multiline = false;
            passwordTxt.Name = "passwordTxt";
            passwordTxt.NormalImageTint = Color.White;
            passwordTxt.Padding = new Padding(13, 12, 13, 0);
            passwordTxt.PasswordChar = true;
            passwordTxt.PlaceholderColor = SystemColors.ScrollBar;
            passwordTxt.PlaceholderText = "Enter password";
            passwordTxt.Rounding = new Padding(10);
            passwordTxt.Size = new Size(261, 36);
            passwordTxt.TabIndex = 25;
            passwordTxt.TextOffset = new Size(0, 0);
            passwordTxt.UnderlinedStyle = false;
            // 
            // doneBtn
            // 
            doneBtn.Anchor = AnchorStyles.None;
            doneBtn.BackColor = Color.Transparent;
            doneBtn.Checked = false;
            doneBtn.CheckedBackground = Color.FromArgb(50, 81, 88);
            doneBtn.CheckedForeColor = Color.White;
            doneBtn.CheckedImageTint = Color.White;
            doneBtn.CheckedOutline = Color.FromArgb(50, 81, 88);
            doneBtn.Content = "DONE";
            doneBtn.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            doneBtn.ForeColor = Color.White;
            doneBtn.Group = 0;
            doneBtn.HoverBackground = Color.White;
            doneBtn.HoveredImageTint = Color.White;
            doneBtn.HoverForeColor = Color.Black;
            doneBtn.HoverOutline = Color.FromArgb(22, 36, 39);
            doneBtn.Image = null;
            doneBtn.ImageAutoCenter = true;
            doneBtn.ImageExpand = new Point(0, 0);
            doneBtn.ImageOffset = new Point(0, 0);
            doneBtn.Location = new Point(245, 97);
            doneBtn.Name = "doneBtn";
            doneBtn.NormalBackground = Color.FromArgb(50, 81, 88);
            doneBtn.NormalForeColor = Color.White;
            doneBtn.NormalImageTint = Color.White;
            doneBtn.NormalOutline = Color.FromArgb(50, 81, 88);
            doneBtn.OutlineThickness = 1F;
            doneBtn.PressedBackground = Color.FromArgb(22, 36, 39);
            doneBtn.PressedForeColor = Color.White;
            doneBtn.PressedImageTint = Color.White;
            doneBtn.PressedOutline = Color.FromArgb(22, 36, 39);
            doneBtn.Rounding = new Padding(6);
            doneBtn.Size = new Size(112, 34);
            doneBtn.TabIndex = 21;
            doneBtn.TextAlignment = StringAlignment.Center;
            doneBtn.TextOffset = new Point(0, 0);
            doneBtn.Click += doneBtn_Click;
            // 
            // ConfirmPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(475, 161);
            Controls.Add(cuiPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ConfirmPassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ConfirmPassword";
            cuiPanel1.ResumeLayout(false);
            cuiPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)showPassBtn).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private CuoreUI.Controls.cuiPanel cuiPanel1;
        private Label label5;
        private CuoreUI.Controls.cuiTextBox passwordTxt;
        private CuoreUI.Controls.cuiButtonGroup doneBtn;
        private PictureBox showPassBtn;
    }
}