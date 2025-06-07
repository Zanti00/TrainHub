namespace TrainHub
{
    partial class EditMemberForm1
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
            ComboBox comboBox1;
            ComboBox comboBox3;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditMemberForm1));
            label1 = new Label();
            cuiPanel1 = new CuoreUI.Controls.cuiPanel();
            cuiPanel3 = new CuoreUI.Controls.cuiPanel();
            cuiPanel2 = new CuoreUI.Controls.cuiPanel();
            cuiCalendarDatePicker2 = new CuoreUI.Controls.cuiCalendarDatePicker();
            cuiCalendarDatePicker1 = new CuoreUI.Controls.cuiCalendarDatePicker();
            cuiButtonGroup1 = new CuoreUI.Controls.cuiButtonGroup();
            cuiButton2 = new CuoreUI.Controls.cuiButtonGroup();
            cuiTextBox6 = new CuoreUI.Controls.cuiTextBox();
            cuiTextBox4 = new CuoreUI.Controls.cuiTextBox();
            cuiTextBox3 = new CuoreUI.Controls.cuiTextBox();
            cuiTextBox2 = new CuoreUI.Controls.cuiTextBox();
            cuiTextBox1 = new CuoreUI.Controls.cuiTextBox();
            emailTxt = new CuoreUI.Controls.cuiTextBox();
            comboBox1 = new ComboBox();
            comboBox3 = new ComboBox();
            cuiPanel1.SuspendLayout();
            cuiPanel3.SuspendLayout();
            cuiPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.White;
            comboBox1.DropDownHeight = 150;
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.ForeColor = Color.Black;
            comboBox1.FormattingEnabled = true;
            comboBox1.IntegralHeight = false;
            comboBox1.Items.AddRange(new object[] { "Inactive", "Active" });
            comboBox1.Location = new Point(13, 7);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(320, 24);
            comboBox1.TabIndex = 5;
            comboBox1.Text = "Status";
            // 
            // comboBox3
            // 
            comboBox3.BackColor = Color.White;
            comboBox3.DropDownHeight = 150;
            comboBox3.FlatStyle = FlatStyle.Flat;
            comboBox3.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox3.ForeColor = Color.Black;
            comboBox3.FormattingEnabled = true;
            comboBox3.IntegralHeight = false;
            comboBox3.Items.AddRange(new object[] { "Daily", "Monthly", "Quarterly", "Yearly" });
            comboBox3.Location = new Point(13, 7);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(320, 24);
            comboBox3.TabIndex = 5;
            comboBox3.Text = "Membership Type";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(51, 81, 88);
            label1.Location = new Point(33, 40);
            label1.Name = "label1";
            label1.Size = new Size(162, 29);
            label1.TabIndex = 3;
            label1.Text = "Edit Member";
            // 
            // cuiPanel1
            // 
            cuiPanel1.Controls.Add(cuiPanel3);
            cuiPanel1.Controls.Add(cuiPanel2);
            cuiPanel1.Controls.Add(cuiCalendarDatePicker2);
            cuiPanel1.Controls.Add(cuiCalendarDatePicker1);
            cuiPanel1.Controls.Add(cuiButtonGroup1);
            cuiPanel1.Controls.Add(cuiButton2);
            cuiPanel1.Controls.Add(cuiTextBox6);
            cuiPanel1.Controls.Add(cuiTextBox4);
            cuiPanel1.Controls.Add(cuiTextBox3);
            cuiPanel1.Controls.Add(cuiTextBox2);
            cuiPanel1.Controls.Add(cuiTextBox1);
            cuiPanel1.Controls.Add(emailTxt);
            cuiPanel1.Location = new Point(33, 90);
            cuiPanel1.Name = "cuiPanel1";
            cuiPanel1.OutlineThickness = 1F;
            cuiPanel1.PanelColor = Color.White;
            cuiPanel1.PanelOutlineColor = Color.Black;
            cuiPanel1.Rounding = new Padding(8);
            cuiPanel1.Size = new Size(774, 347);
            cuiPanel1.TabIndex = 4;
            // 
            // cuiPanel3
            // 
            cuiPanel3.BackColor = Color.Transparent;
            cuiPanel3.Controls.Add(comboBox3);
            cuiPanel3.Location = new Point(400, 192);
            cuiPanel3.Name = "cuiPanel3";
            cuiPanel3.OutlineThickness = 1F;
            cuiPanel3.PanelColor = Color.White;
            cuiPanel3.PanelOutlineColor = Color.Black;
            cuiPanel3.Rounding = new Padding(10);
            cuiPanel3.Size = new Size(343, 38);
            cuiPanel3.TabIndex = 30;
            // 
            // cuiPanel2
            // 
            cuiPanel2.BackColor = Color.Transparent;
            cuiPanel2.Controls.Add(comboBox1);
            cuiPanel2.Location = new Point(400, 144);
            cuiPanel2.Name = "cuiPanel2";
            cuiPanel2.OutlineThickness = 1F;
            cuiPanel2.PanelColor = Color.White;
            cuiPanel2.PanelOutlineColor = Color.Black;
            cuiPanel2.Rounding = new Padding(10);
            cuiPanel2.Size = new Size(343, 38);
            cuiPanel2.TabIndex = 29;
            // 
            // cuiCalendarDatePicker2
            // 
            cuiCalendarDatePicker2.EnableThemeChangeButton = true;
            cuiCalendarDatePicker2.Font = new Font("Segoe UI", 9.75F);
            cuiCalendarDatePicker2.ForeColor = Color.DarkGray;
            cuiCalendarDatePicker2.HoverBackground = Color.FromArgb(50, 128, 128, 128);
            cuiCalendarDatePicker2.HoverOutline = Color.FromArgb(180, 128, 128, 128);
            cuiCalendarDatePicker2.Icon = (Image)resources.GetObject("cuiCalendarDatePicker2.Icon");
            cuiCalendarDatePicker2.IconTint = Color.Gray;
            cuiCalendarDatePicker2.Location = new Point(578, 96);
            cuiCalendarDatePicker2.Margin = new Padding(4, 5, 4, 5);
            cuiCalendarDatePicker2.Name = "cuiCalendarDatePicker2";
            cuiCalendarDatePicker2.NormalBackground = Color.White;
            cuiCalendarDatePicker2.NormalOutline = Color.FromArgb(51, 81, 88);
            cuiCalendarDatePicker2.OutlineThickness = 1.5F;
            cuiCalendarDatePicker2.PressedBackground = Color.FromArgb(80, 128, 128, 128);
            cuiCalendarDatePicker2.PressedOutline = Color.FromArgb(210, 128, 128, 128);
            cuiCalendarDatePicker2.Rounding = 10;
            cuiCalendarDatePicker2.ShowIcon = true;
            cuiCalendarDatePicker2.Size = new Size(165, 38);
            cuiCalendarDatePicker2.TabIndex = 27;
            cuiCalendarDatePicker2.Theme = CuoreUI.Controls.Forms.DatePicker.Themes.Light;
            cuiCalendarDatePicker2.Value = new DateTime(2025, 6, 4, 0, 0, 0, 0);
            // 
            // cuiCalendarDatePicker1
            // 
            cuiCalendarDatePicker1.EnableThemeChangeButton = true;
            cuiCalendarDatePicker1.Font = new Font("Segoe UI", 9.75F);
            cuiCalendarDatePicker1.ForeColor = Color.DarkGray;
            cuiCalendarDatePicker1.HoverBackground = Color.FromArgb(50, 128, 128, 128);
            cuiCalendarDatePicker1.HoverOutline = Color.FromArgb(180, 128, 128, 128);
            cuiCalendarDatePicker1.Icon = (Image)resources.GetObject("cuiCalendarDatePicker1.Icon");
            cuiCalendarDatePicker1.IconTint = Color.Gray;
            cuiCalendarDatePicker1.Location = new Point(400, 96);
            cuiCalendarDatePicker1.Margin = new Padding(4, 5, 4, 5);
            cuiCalendarDatePicker1.Name = "cuiCalendarDatePicker1";
            cuiCalendarDatePicker1.NormalBackground = Color.White;
            cuiCalendarDatePicker1.NormalOutline = Color.FromArgb(51, 81, 88);
            cuiCalendarDatePicker1.OutlineThickness = 1.5F;
            cuiCalendarDatePicker1.PressedBackground = Color.FromArgb(80, 128, 128, 128);
            cuiCalendarDatePicker1.PressedOutline = Color.FromArgb(210, 128, 128, 128);
            cuiCalendarDatePicker1.Rounding = 10;
            cuiCalendarDatePicker1.ShowIcon = true;
            cuiCalendarDatePicker1.Size = new Size(165, 38);
            cuiCalendarDatePicker1.TabIndex = 26;
            cuiCalendarDatePicker1.Theme = CuoreUI.Controls.Forms.DatePicker.Themes.Light;
            cuiCalendarDatePicker1.Value = new DateTime(2025, 6, 4, 0, 0, 0, 0);
            // 
            // cuiButtonGroup1
            // 
            cuiButtonGroup1.BackColor = Color.Transparent;
            cuiButtonGroup1.Checked = false;
            cuiButtonGroup1.CheckedBackground = Color.FromArgb(50, 81, 88);
            cuiButtonGroup1.CheckedForeColor = Color.White;
            cuiButtonGroup1.CheckedImageTint = Color.White;
            cuiButtonGroup1.CheckedOutline = Color.FromArgb(50, 81, 88);
            cuiButtonGroup1.Content = "Cancel";
            cuiButtonGroup1.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiButtonGroup1.ForeColor = Color.Black;
            cuiButtonGroup1.Group = 0;
            cuiButtonGroup1.HoverBackground = Color.FromArgb(22, 36, 39);
            cuiButtonGroup1.HoveredImageTint = Color.White;
            cuiButtonGroup1.HoverForeColor = Color.White;
            cuiButtonGroup1.HoverOutline = Color.FromArgb(22, 36, 39);
            cuiButtonGroup1.Image = null;
            cuiButtonGroup1.ImageAutoCenter = true;
            cuiButtonGroup1.ImageExpand = new Point(0, 0);
            cuiButtonGroup1.ImageOffset = new Point(0, 0);
            cuiButtonGroup1.Location = new Point(565, 279);
            cuiButtonGroup1.Margin = new Padding(3, 4, 3, 4);
            cuiButtonGroup1.Name = "cuiButtonGroup1";
            cuiButtonGroup1.NormalBackground = Color.White;
            cuiButtonGroup1.NormalForeColor = Color.Black;
            cuiButtonGroup1.NormalImageTint = Color.White;
            cuiButtonGroup1.NormalOutline = Color.FromArgb(50, 81, 88);
            cuiButtonGroup1.OutlineThickness = 1F;
            cuiButtonGroup1.PressedBackground = Color.FromArgb(22, 36, 39);
            cuiButtonGroup1.PressedForeColor = Color.White;
            cuiButtonGroup1.PressedImageTint = Color.White;
            cuiButtonGroup1.PressedOutline = Color.FromArgb(22, 36, 39);
            cuiButtonGroup1.Rounding = new Padding(10);
            cuiButtonGroup1.Size = new Size(86, 35);
            cuiButtonGroup1.TabIndex = 21;
            cuiButtonGroup1.TextAlignment = StringAlignment.Center;
            cuiButtonGroup1.TextOffset = new Point(0, 0);
            cuiButtonGroup1.Click += cuiButtonGroup1_Click;
            // 
            // cuiButton2
            // 
            cuiButton2.BackColor = Color.Transparent;
            cuiButton2.Checked = false;
            cuiButton2.CheckedBackground = Color.FromArgb(50, 81, 88);
            cuiButton2.CheckedForeColor = Color.White;
            cuiButton2.CheckedImageTint = Color.White;
            cuiButton2.CheckedOutline = Color.FromArgb(50, 81, 88);
            cuiButton2.Content = "OK";
            cuiButton2.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiButton2.ForeColor = Color.White;
            cuiButton2.Group = 0;
            cuiButton2.HoverBackground = Color.White;
            cuiButton2.HoveredImageTint = Color.White;
            cuiButton2.HoverForeColor = Color.Black;
            cuiButton2.HoverOutline = Color.FromArgb(22, 36, 39);
            cuiButton2.Image = null;
            cuiButton2.ImageAutoCenter = true;
            cuiButton2.ImageExpand = new Point(0, 0);
            cuiButton2.ImageOffset = new Point(0, 0);
            cuiButton2.Location = new Point(657, 279);
            cuiButton2.Margin = new Padding(3, 4, 3, 4);
            cuiButton2.Name = "cuiButton2";
            cuiButton2.NormalBackground = Color.FromArgb(50, 81, 88);
            cuiButton2.NormalForeColor = Color.White;
            cuiButton2.NormalImageTint = Color.White;
            cuiButton2.NormalOutline = Color.FromArgb(50, 81, 88);
            cuiButton2.OutlineThickness = 1F;
            cuiButton2.PressedBackground = Color.FromArgb(22, 36, 39);
            cuiButton2.PressedForeColor = Color.White;
            cuiButton2.PressedImageTint = Color.White;
            cuiButton2.PressedOutline = Color.FromArgb(22, 36, 39);
            cuiButton2.Rounding = new Padding(10);
            cuiButton2.Size = new Size(86, 35);
            cuiButton2.TabIndex = 20;
            cuiButton2.TextAlignment = StringAlignment.Center;
            cuiButton2.TextOffset = new Point(0, 0);
            cuiButton2.Click += cuiButton2_Click;
            // 
            // cuiTextBox6
            // 
            cuiTextBox6.BackColor = Color.Transparent;
            cuiTextBox6.BackgroundColor = Color.White;
            cuiTextBox6.BorderColor = Color.FromArgb(50, 81, 88);
            cuiTextBox6.Content = "";
            cuiTextBox6.FocusBackgroundColor = Color.White;
            cuiTextBox6.FocusBorderColor = Color.FromArgb(50, 81, 88);
            cuiTextBox6.FocusImageTint = Color.White;
            cuiTextBox6.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiTextBox6.ForeColor = Color.Black;
            cuiTextBox6.Image = null;
            cuiTextBox6.ImageExpand = new Point(0, 0);
            cuiTextBox6.ImageOffset = new Point(0, 0);
            cuiTextBox6.Location = new Point(29, 240);
            cuiTextBox6.Margin = new Padding(5);
            cuiTextBox6.Multiline = false;
            cuiTextBox6.Name = "cuiTextBox6";
            cuiTextBox6.NormalImageTint = Color.White;
            cuiTextBox6.Padding = new Padding(16, 11, 16, 0);
            cuiTextBox6.PasswordChar = false;
            cuiTextBox6.PlaceholderColor = SystemColors.ScrollBar;
            cuiTextBox6.PlaceholderText = "Trainer ID ";
            cuiTextBox6.Rounding = new Padding(10);
            cuiTextBox6.Size = new Size(343, 38);
            cuiTextBox6.TabIndex = 17;
            cuiTextBox6.TextOffset = new Size(0, 0);
            cuiTextBox6.UnderlinedStyle = false;
            // 
            // cuiTextBox4
            // 
            cuiTextBox4.BackColor = Color.Transparent;
            cuiTextBox4.BackgroundColor = Color.White;
            cuiTextBox4.BorderColor = Color.FromArgb(50, 81, 88);
            cuiTextBox4.Content = "";
            cuiTextBox4.FocusBackgroundColor = Color.White;
            cuiTextBox4.FocusBorderColor = Color.FromArgb(50, 81, 88);
            cuiTextBox4.FocusImageTint = Color.White;
            cuiTextBox4.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiTextBox4.ForeColor = Color.Black;
            cuiTextBox4.Image = null;
            cuiTextBox4.ImageExpand = new Point(0, 0);
            cuiTextBox4.ImageOffset = new Point(0, 0);
            cuiTextBox4.Location = new Point(400, 48);
            cuiTextBox4.Margin = new Padding(5);
            cuiTextBox4.Multiline = false;
            cuiTextBox4.Name = "cuiTextBox4";
            cuiTextBox4.NormalImageTint = Color.White;
            cuiTextBox4.Padding = new Padding(16, 11, 16, 0);
            cuiTextBox4.PasswordChar = false;
            cuiTextBox4.PlaceholderColor = SystemColors.ScrollBar;
            cuiTextBox4.PlaceholderText = "Last Name";
            cuiTextBox4.Rounding = new Padding(10);
            cuiTextBox4.Size = new Size(343, 38);
            cuiTextBox4.TabIndex = 15;
            cuiTextBox4.TextOffset = new Size(0, 0);
            cuiTextBox4.UnderlinedStyle = false;
            // 
            // cuiTextBox3
            // 
            cuiTextBox3.BackColor = Color.Transparent;
            cuiTextBox3.BackgroundColor = Color.White;
            cuiTextBox3.BorderColor = Color.FromArgb(50, 81, 88);
            cuiTextBox3.Content = "";
            cuiTextBox3.FocusBackgroundColor = Color.White;
            cuiTextBox3.FocusBorderColor = Color.FromArgb(50, 81, 88);
            cuiTextBox3.FocusImageTint = Color.White;
            cuiTextBox3.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiTextBox3.ForeColor = Color.Black;
            cuiTextBox3.Image = null;
            cuiTextBox3.ImageExpand = new Point(0, 0);
            cuiTextBox3.ImageOffset = new Point(0, 0);
            cuiTextBox3.Location = new Point(29, 144);
            cuiTextBox3.Margin = new Padding(5);
            cuiTextBox3.Multiline = false;
            cuiTextBox3.Name = "cuiTextBox3";
            cuiTextBox3.NormalImageTint = Color.White;
            cuiTextBox3.Padding = new Padding(16, 11, 16, 0);
            cuiTextBox3.PasswordChar = false;
            cuiTextBox3.PlaceholderColor = SystemColors.ScrollBar;
            cuiTextBox3.PlaceholderText = "Email Address";
            cuiTextBox3.Rounding = new Padding(10);
            cuiTextBox3.Size = new Size(343, 38);
            cuiTextBox3.TabIndex = 14;
            cuiTextBox3.TextOffset = new Size(0, 0);
            cuiTextBox3.UnderlinedStyle = false;
            // 
            // cuiTextBox2
            // 
            cuiTextBox2.BackColor = Color.Transparent;
            cuiTextBox2.BackgroundColor = Color.White;
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
            cuiTextBox2.Location = new Point(29, 96);
            cuiTextBox2.Margin = new Padding(5);
            cuiTextBox2.Multiline = false;
            cuiTextBox2.Name = "cuiTextBox2";
            cuiTextBox2.NormalImageTint = Color.White;
            cuiTextBox2.Padding = new Padding(16, 11, 16, 0);
            cuiTextBox2.PasswordChar = false;
            cuiTextBox2.PlaceholderColor = SystemColors.ScrollBar;
            cuiTextBox2.PlaceholderText = "Mobile Number";
            cuiTextBox2.Rounding = new Padding(10);
            cuiTextBox2.Size = new Size(343, 38);
            cuiTextBox2.TabIndex = 13;
            cuiTextBox2.TextOffset = new Size(0, 0);
            cuiTextBox2.UnderlinedStyle = false;
            // 
            // cuiTextBox1
            // 
            cuiTextBox1.BackColor = Color.Transparent;
            cuiTextBox1.BackgroundColor = Color.White;
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
            cuiTextBox1.Location = new Point(29, 192);
            cuiTextBox1.Margin = new Padding(5);
            cuiTextBox1.Multiline = false;
            cuiTextBox1.Name = "cuiTextBox1";
            cuiTextBox1.NormalImageTint = Color.White;
            cuiTextBox1.Padding = new Padding(16, 11, 16, 0);
            cuiTextBox1.PasswordChar = false;
            cuiTextBox1.PlaceholderColor = SystemColors.ScrollBar;
            cuiTextBox1.PlaceholderText = "Program ID";
            cuiTextBox1.Rounding = new Padding(10);
            cuiTextBox1.Size = new Size(343, 38);
            cuiTextBox1.TabIndex = 12;
            cuiTextBox1.TextOffset = new Size(0, 0);
            cuiTextBox1.UnderlinedStyle = false;
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
            emailTxt.Location = new Point(29, 48);
            emailTxt.Margin = new Padding(5);
            emailTxt.Multiline = false;
            emailTxt.Name = "emailTxt";
            emailTxt.NormalImageTint = Color.White;
            emailTxt.Padding = new Padding(16, 11, 16, 0);
            emailTxt.PasswordChar = false;
            emailTxt.PlaceholderColor = SystemColors.ScrollBar;
            emailTxt.PlaceholderText = "First Name";
            emailTxt.Rounding = new Padding(10);
            emailTxt.Size = new Size(343, 38);
            emailTxt.TabIndex = 11;
            emailTxt.TextOffset = new Size(0, 0);
            emailTxt.UnderlinedStyle = false;
            // 
            // EditMemberForm1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(845, 476);
            Controls.Add(cuiPanel1);
            Controls.Add(label1);
            ForeColor = Color.White;
            Name = "EditMemberForm1";
            Text = "EditMemberForm1";
            cuiPanel1.ResumeLayout(false);
            cuiPanel3.ResumeLayout(false);
            cuiPanel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private CuoreUI.Controls.cuiPanel cuiPanel1;
        private CuoreUI.Controls.cuiCalendarDatePicker cuiCalendarDatePicker2;
        private CuoreUI.Controls.cuiCalendarDatePicker cuiCalendarDatePicker1;
        private CuoreUI.Controls.cuiButtonGroup cuiButtonGroup1;
        private CuoreUI.Controls.cuiButtonGroup cuiButton2;
        private CuoreUI.Controls.cuiTextBox cuiTextBox6;
        private CuoreUI.Controls.cuiTextBox cuiTextBox4;
        private CuoreUI.Controls.cuiTextBox cuiTextBox3;
        private CuoreUI.Controls.cuiTextBox cuiTextBox2;
        private CuoreUI.Controls.cuiTextBox cuiTextBox1;
        private CuoreUI.Controls.cuiTextBox emailTxt;
        private ComboBox comboBox1;
        private CuoreUI.Controls.cuiPanel cuiPanel2;
        private CuoreUI.Controls.cuiPanel cuiPanel3;
    }
}