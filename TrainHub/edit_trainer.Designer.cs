namespace TrainHub
{
    partial class edit_trainer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(edit_trainer));
            cuiPanel2 = new CuoreUI.Controls.cuiPanel();
            cuiCalendarDatePicker1 = new CuoreUI.Controls.cuiCalendarDatePicker();
            okBtn = new CuoreUI.Controls.cuiButton();
            cancelBtn = new CuoreUI.Controls.cuiButton();
            addressTxt = new CuoreUI.Controls.cuiTextBox();
            emailTxt = new CuoreUI.Controls.cuiTextBox();
            LastNametxt = new CuoreUI.Controls.cuiTextBox();
            mobNumTxt = new CuoreUI.Controls.cuiTextBox();
            firstNametxt = new CuoreUI.Controls.cuiTextBox();
            label1 = new Label();
            cuiPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // cuiPanel2
            // 
            cuiPanel2.BackColor = Color.Transparent;
            cuiPanel2.BackgroundImageLayout = ImageLayout.None;
            cuiPanel2.Controls.Add(cuiCalendarDatePicker1);
            cuiPanel2.Controls.Add(okBtn);
            cuiPanel2.Controls.Add(cancelBtn);
            cuiPanel2.Controls.Add(addressTxt);
            cuiPanel2.Controls.Add(emailTxt);
            cuiPanel2.Controls.Add(LastNametxt);
            cuiPanel2.Controls.Add(mobNumTxt);
            cuiPanel2.Controls.Add(firstNametxt);
            cuiPanel2.Location = new Point(27, 98);
            cuiPanel2.Name = "cuiPanel2";
            cuiPanel2.OutlineThickness = 1F;
            cuiPanel2.PanelColor = Color.White;
            cuiPanel2.PanelOutlineColor = Color.Black;
            cuiPanel2.Rounding = new Padding(10);
            cuiPanel2.Size = new Size(779, 305);
            cuiPanel2.TabIndex = 6;
            cuiPanel2.Paint += cuiPanel2_Paint_1;
            // 
            // cuiCalendarDatePicker1
            // 
            cuiCalendarDatePicker1.EnableThemeChangeButton = true;
            cuiCalendarDatePicker1.Font = new Font("Segoe UI", 9.75F);
            cuiCalendarDatePicker1.ForeColor = Color.Gray;
            cuiCalendarDatePicker1.HoverBackground = Color.FromArgb(50, 128, 128, 128);
            cuiCalendarDatePicker1.HoverOutline = Color.FromArgb(180, 128, 128, 128);
            cuiCalendarDatePicker1.Icon = (Image)resources.GetObject("cuiCalendarDatePicker1.Icon");
            cuiCalendarDatePicker1.IconTint = Color.Gray;
            cuiCalendarDatePicker1.Location = new Point(400, 162);
            cuiCalendarDatePicker1.Margin = new Padding(4, 3, 4, 3);
            cuiCalendarDatePicker1.Name = "cuiCalendarDatePicker1";
            cuiCalendarDatePicker1.NormalBackground = Color.FromArgb(32, 128, 128, 128);
            cuiCalendarDatePicker1.NormalOutline = Color.FromArgb(150, 128, 128, 128);
            cuiCalendarDatePicker1.OutlineThickness = 1.5F;
            cuiCalendarDatePicker1.PressedBackground = Color.FromArgb(80, 128, 128, 128);
            cuiCalendarDatePicker1.PressedOutline = Color.FromArgb(210, 128, 128, 128);
            cuiCalendarDatePicker1.Rounding = 8;
            cuiCalendarDatePicker1.ShowIcon = true;
            cuiCalendarDatePicker1.Size = new Size(343, 38);
            cuiCalendarDatePicker1.TabIndex = 7;
            cuiCalendarDatePicker1.Theme = CuoreUI.Controls.Forms.DatePicker.Themes.Light;
            cuiCalendarDatePicker1.Value = new DateTime(2025, 6, 6, 0, 0, 0, 0);
            // 
            // okBtn
            // 
            okBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            okBtn.CheckButton = false;
            okBtn.Checked = true;
            okBtn.CheckedBackground = Color.FromArgb(50, 81, 88);
            okBtn.CheckedForeColor = SystemColors.Window;
            okBtn.CheckedImageTint = Color.White;
            okBtn.CheckedOutline = Color.FromArgb(50, 81, 88);
            okBtn.Content = "OK";
            okBtn.DialogResult = DialogResult.None;
            okBtn.Font = new Font("Microsoft Sans Serif", 9.75F);
            okBtn.ForeColor = Color.White;
            okBtn.HoverBackground = Color.FromArgb(22, 36, 39);
            okBtn.HoveredImageTint = Color.White;
            okBtn.HoverForeColor = Color.Black;
            okBtn.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            okBtn.Image = null;
            okBtn.ImageAutoCenter = true;
            okBtn.ImageExpand = new Point(0, 0);
            okBtn.ImageOffset = new Point(0, 0);
            okBtn.Location = new Point(672, 216);
            okBtn.Name = "okBtn";
            okBtn.NormalBackground = Color.FromArgb(50, 81, 88);
            okBtn.NormalForeColor = Color.White;
            okBtn.NormalImageTint = Color.White;
            okBtn.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            okBtn.OutlineThickness = 1F;
            okBtn.PressedBackground = Color.WhiteSmoke;
            okBtn.PressedForeColor = Color.FromArgb(32, 32, 32);
            okBtn.PressedImageTint = Color.White;
            okBtn.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            okBtn.Rounding = new Padding(10);
            okBtn.Size = new Size(71, 32);
            okBtn.TabIndex = 18;
            okBtn.TextAlignment = StringAlignment.Center;
            okBtn.TextOffset = new Point(0, 0);
            okBtn.Click += okBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cancelBtn.CheckButton = false;
            cancelBtn.Checked = false;
            cancelBtn.CheckedBackground = Color.FromArgb(255, 106, 0);
            cancelBtn.CheckedForeColor = Color.White;
            cancelBtn.CheckedImageTint = Color.White;
            cancelBtn.CheckedOutline = Color.FromArgb(255, 106, 0);
            cancelBtn.Content = "Cancel";
            cancelBtn.DialogResult = DialogResult.None;
            cancelBtn.Font = new Font("Microsoft Sans Serif", 9.75F);
            cancelBtn.ForeColor = Color.Black;
            cancelBtn.HoverBackground = Color.White;
            cancelBtn.HoveredImageTint = Color.White;
            cancelBtn.HoverForeColor = Color.Black;
            cancelBtn.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            cancelBtn.Image = null;
            cancelBtn.ImageAutoCenter = true;
            cancelBtn.ImageExpand = new Point(0, 0);
            cancelBtn.ImageOffset = new Point(0, 0);
            cancelBtn.Location = new Point(602, 216);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.NormalBackground = Color.White;
            cancelBtn.NormalForeColor = Color.Black;
            cancelBtn.NormalImageTint = Color.White;
            cancelBtn.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            cancelBtn.OutlineThickness = 1F;
            cancelBtn.PressedBackground = Color.WhiteSmoke;
            cancelBtn.PressedForeColor = Color.FromArgb(32, 32, 32);
            cancelBtn.PressedImageTint = Color.White;
            cancelBtn.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            cancelBtn.Rounding = new Padding(10);
            cancelBtn.Size = new Size(64, 32);
            cancelBtn.TabIndex = 17;
            cancelBtn.TextAlignment = StringAlignment.Center;
            cancelBtn.TextOffset = new Point(0, 0);
            // 
            // addressTxt
            // 
            addressTxt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            addressTxt.BackColor = Color.Transparent;
            addressTxt.BackgroundColor = Color.White;
            addressTxt.BorderColor = Color.FromArgb(50, 81, 88);
            addressTxt.Content = "";
            addressTxt.FocusBackgroundColor = Color.White;
            addressTxt.FocusBorderColor = Color.FromArgb(50, 81, 88);
            addressTxt.FocusImageTint = Color.White;
            addressTxt.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addressTxt.ForeColor = Color.Black;
            addressTxt.Image = null;
            addressTxt.ImageExpand = new Point(0, 0);
            addressTxt.ImageOffset = new Point(0, 0);
            addressTxt.Location = new Point(400, 116);
            addressTxt.Margin = new Padding(4);
            addressTxt.Multiline = false;
            addressTxt.Name = "addressTxt";
            addressTxt.NormalImageTint = Color.White;
            addressTxt.Padding = new Padding(13, 13, 13, 0);
            addressTxt.PasswordChar = false;
            addressTxt.PlaceholderColor = SystemColors.ScrollBar;
            addressTxt.PlaceholderText = "Address";
            addressTxt.Rounding = new Padding(10);
            addressTxt.Size = new Size(343, 38);
            addressTxt.TabIndex = 16;
            addressTxt.TextOffset = new Size(0, 0);
            addressTxt.UnderlinedStyle = false;
            addressTxt.ContentChanged += addressTxt_ContentChanged;
            // 
            // emailTxt
            // 
            emailTxt.BackColor = Color.Transparent;
            emailTxt.BackgroundColor = Color.White;
            emailTxt.BorderColor = Color.FromArgb(50, 81, 88);
            emailTxt.Content = "";
            emailTxt.FocusBackgroundColor = Color.White;
            emailTxt.FocusBorderColor = Color.FromArgb(50, 81, 88);
            emailTxt.FocusImageTint = Color.White;
            emailTxt.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailTxt.ForeColor = Color.Black;
            emailTxt.Image = null;
            emailTxt.ImageExpand = new Point(0, 0);
            emailTxt.ImageOffset = new Point(0, 0);
            emailTxt.Location = new Point(34, 162);
            emailTxt.Margin = new Padding(4);
            emailTxt.Multiline = false;
            emailTxt.Name = "emailTxt";
            emailTxt.NormalImageTint = Color.White;
            emailTxt.Padding = new Padding(13, 13, 13, 0);
            emailTxt.PasswordChar = false;
            emailTxt.PlaceholderColor = SystemColors.ScrollBar;
            emailTxt.PlaceholderText = "Email Address ";
            emailTxt.Rounding = new Padding(10);
            emailTxt.Size = new Size(343, 38);
            emailTxt.TabIndex = 15;
            emailTxt.TextOffset = new Size(0, 0);
            emailTxt.UnderlinedStyle = false;
            emailTxt.ContentChanged += emailTxt_ContentChanged;
            // 
            // LastNametxt
            // 
            LastNametxt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LastNametxt.BackColor = Color.Transparent;
            LastNametxt.BackgroundColor = Color.White;
            LastNametxt.BorderColor = Color.FromArgb(50, 81, 88);
            LastNametxt.Content = "";
            LastNametxt.FocusBackgroundColor = Color.White;
            LastNametxt.FocusBorderColor = Color.FromArgb(50, 81, 88);
            LastNametxt.FocusImageTint = Color.White;
            LastNametxt.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LastNametxt.ForeColor = Color.Black;
            LastNametxt.Image = null;
            LastNametxt.ImageExpand = new Point(0, 0);
            LastNametxt.ImageOffset = new Point(0, 0);
            LastNametxt.Location = new Point(400, 70);
            LastNametxt.Margin = new Padding(4);
            LastNametxt.Multiline = false;
            LastNametxt.Name = "LastNametxt";
            LastNametxt.NormalImageTint = Color.White;
            LastNametxt.Padding = new Padding(13, 13, 13, 0);
            LastNametxt.PasswordChar = false;
            LastNametxt.PlaceholderColor = SystemColors.ScrollBar;
            LastNametxt.PlaceholderText = "Last Name";
            LastNametxt.Rounding = new Padding(10);
            LastNametxt.Size = new Size(343, 38);
            LastNametxt.TabIndex = 11;
            LastNametxt.TextOffset = new Size(0, 0);
            LastNametxt.UnderlinedStyle = false;
            // 
            // mobNumTxt
            // 
            mobNumTxt.BackColor = Color.Transparent;
            mobNumTxt.BackgroundColor = Color.White;
            mobNumTxt.BorderColor = Color.FromArgb(50, 81, 88);
            mobNumTxt.Content = "";
            mobNumTxt.FocusBackgroundColor = Color.White;
            mobNumTxt.FocusBorderColor = Color.FromArgb(50, 81, 88);
            mobNumTxt.FocusImageTint = Color.White;
            mobNumTxt.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mobNumTxt.ForeColor = Color.Black;
            mobNumTxt.Image = null;
            mobNumTxt.ImageExpand = new Point(0, 0);
            mobNumTxt.ImageOffset = new Point(0, 0);
            mobNumTxt.Location = new Point(34, 116);
            mobNumTxt.Margin = new Padding(4);
            mobNumTxt.Multiline = false;
            mobNumTxt.Name = "mobNumTxt";
            mobNumTxt.NormalImageTint = Color.White;
            mobNumTxt.Padding = new Padding(13, 13, 13, 0);
            mobNumTxt.PasswordChar = false;
            mobNumTxt.PlaceholderColor = SystemColors.ScrollBar;
            mobNumTxt.PlaceholderText = "Mobile Number";
            mobNumTxt.Rounding = new Padding(10);
            mobNumTxt.Size = new Size(343, 38);
            mobNumTxt.TabIndex = 12;
            mobNumTxt.TextOffset = new Size(0, 0);
            mobNumTxt.UnderlinedStyle = false;
            mobNumTxt.ContentChanged += mobNumTxt_ContentChanged;
            // 
            // firstNametxt
            // 
            firstNametxt.BackColor = Color.Transparent;
            firstNametxt.BackgroundColor = Color.White;
            firstNametxt.BorderColor = Color.FromArgb(50, 81, 88);
            firstNametxt.Content = "";
            firstNametxt.FocusBackgroundColor = Color.White;
            firstNametxt.FocusBorderColor = Color.FromArgb(50, 81, 88);
            firstNametxt.FocusImageTint = Color.White;
            firstNametxt.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            firstNametxt.ForeColor = Color.Black;
            firstNametxt.Image = null;
            firstNametxt.ImageExpand = new Point(0, 0);
            firstNametxt.ImageOffset = new Point(0, 0);
            firstNametxt.Location = new Point(34, 70);
            firstNametxt.Margin = new Padding(4);
            firstNametxt.Multiline = false;
            firstNametxt.Name = "firstNametxt";
            firstNametxt.NormalImageTint = Color.White;
            firstNametxt.Padding = new Padding(13, 13, 13, 0);
            firstNametxt.PasswordChar = false;
            firstNametxt.PlaceholderColor = SystemColors.ScrollBar;
            firstNametxt.PlaceholderText = "First Name";
            firstNametxt.Rounding = new Padding(10);
            firstNametxt.Size = new Size(343, 38);
            firstNametxt.TabIndex = 11;
            firstNametxt.TextOffset = new Size(0, 0);
            firstNametxt.UnderlinedStyle = false;
            firstNametxt.ContentChanged += firstNametxt_ContentChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(50, 81, 88);
            label1.Location = new Point(27, 45);
            label1.Name = "label1";
            label1.Size = new Size(142, 30);
            label1.TabIndex = 5;
            label1.Text = "Edit Trainers";
            label1.Click += label1_Click_1;
            // 
            // edit_trainer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(829, 467);
            Controls.Add(cuiPanel2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "edit_trainer";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "edit_trainer";
            TopMost = true;
            cuiPanel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CuoreUI.Controls.cuiPanel cuiPanel2;
        private CuoreUI.Controls.cuiButton okBtn;
        private CuoreUI.Controls.cuiButton cancelBtn;
        private CuoreUI.Controls.cuiTextBox addressTxt;
        private CuoreUI.Controls.cuiTextBox emailTxt;
        private CuoreUI.Controls.cuiTextBox LastNametxt;
        private CuoreUI.Controls.cuiTextBox mobNumTxt;
        private CuoreUI.Controls.cuiTextBox firstNametxt;
        private Label label1;
        private CuoreUI.Controls.cuiCalendarDatePicker cuiCalendarDatePicker1;
    }
}