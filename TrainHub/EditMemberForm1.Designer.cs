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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditMemberForm1));
            label1 = new Label();
            cuiPanel1 = new CuoreUI.Controls.cuiPanel();
            birthDate = new CuoreUI.Controls.cuiCalendarDatePicker();
            label2 = new Label();
            label4 = new Label();
            trainerCombo = new CuoreUI.Controls.cuiComboBox();
            endDate = new CuoreUI.Controls.cuiCalendarDatePicker();
            label3 = new Label();
            statusCombo = new CuoreUI.Controls.cuiComboBox();
            startDate = new CuoreUI.Controls.cuiCalendarDatePicker();
            membershipTypeCombo = new CuoreUI.Controls.cuiComboBox();
            cancelBtn = new CuoreUI.Controls.cuiButtonGroup();
            doneBtn = new CuoreUI.Controls.cuiButtonGroup();
            phoneNumTxt = new CuoreUI.Controls.cuiTextBox();
            emailAddTxt = new CuoreUI.Controls.cuiTextBox();
            lastNameTxt = new CuoreUI.Controls.cuiTextBox();
            firstNameTxt = new CuoreUI.Controls.cuiTextBox();
            cuiPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(51, 81, 88);
            label1.Location = new Point(29, 30);
            label1.Name = "label1";
            label1.Size = new Size(129, 24);
            label1.TabIndex = 3;
            label1.Text = "Edit Member";
            // 
            // cuiPanel1
            // 
            cuiPanel1.Controls.Add(birthDate);
            cuiPanel1.Controls.Add(label2);
            cuiPanel1.Controls.Add(label4);
            cuiPanel1.Controls.Add(trainerCombo);
            cuiPanel1.Controls.Add(endDate);
            cuiPanel1.Controls.Add(label3);
            cuiPanel1.Controls.Add(statusCombo);
            cuiPanel1.Controls.Add(startDate);
            cuiPanel1.Controls.Add(membershipTypeCombo);
            cuiPanel1.Controls.Add(cancelBtn);
            cuiPanel1.Controls.Add(doneBtn);
            cuiPanel1.Controls.Add(phoneNumTxt);
            cuiPanel1.Controls.Add(emailAddTxt);
            cuiPanel1.Controls.Add(lastNameTxt);
            cuiPanel1.Controls.Add(firstNameTxt);
            cuiPanel1.Location = new Point(29, 72);
            cuiPanel1.Margin = new Padding(3, 2, 3, 2);
            cuiPanel1.Name = "cuiPanel1";
            cuiPanel1.OutlineThickness = 1F;
            cuiPanel1.PanelColor = Color.White;
            cuiPanel1.PanelOutlineColor = Color.Black;
            cuiPanel1.Rounding = new Padding(10);
            cuiPanel1.Size = new Size(677, 260);
            cuiPanel1.TabIndex = 8;
            // 
            // birthDate
            // 
            birthDate.EnableThemeChangeButton = true;
            birthDate.Font = new Font("Segoe UI", 9.75F);
            birthDate.ForeColor = Color.Gray;
            birthDate.HoverBackground = Color.FromArgb(50, 128, 128, 128);
            birthDate.HoverOutline = Color.FromArgb(180, 128, 128, 128);
            birthDate.Icon = (Image)resources.GetObject("birthDate.Icon");
            birthDate.IconTint = Color.Gray;
            birthDate.Location = new Point(439, 72);
            birthDate.Margin = new Padding(4);
            birthDate.Name = "birthDate";
            birthDate.NormalBackground = Color.White;
            birthDate.NormalOutline = Color.FromArgb(51, 81, 88);
            birthDate.OutlineThickness = 1.5F;
            birthDate.PressedBackground = Color.FromArgb(80, 128, 128, 128);
            birthDate.PressedOutline = Color.FromArgb(210, 128, 128, 128);
            birthDate.Rounding = 10;
            birthDate.ShowIcon = true;
            birthDate.Size = new Size(211, 28);
            birthDate.TabIndex = 32;
            birthDate.Theme = CuoreUI.Controls.Forms.DatePicker.Themes.Light;
            birthDate.Value = new DateTime(2025, 6, 4, 0, 0, 0, 0);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Inter", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Silver;
            label2.Location = new Point(353, 75);
            label2.Name = "label2";
            label2.Size = new Size(75, 22);
            label2.TabIndex = 36;
            label2.Text = "Birthdate";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Inter", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Silver;
            label4.Location = new Point(353, 146);
            label4.Name = "label4";
            label4.Size = new Size(72, 22);
            label4.TabIndex = 38;
            label4.Text = "End date";
            // 
            // trainerCombo
            // 
            trainerCombo.BackColor = Color.Transparent;
            trainerCombo.BackgroundColor = Color.White;
            trainerCombo.ButtonCursor = Cursors.Arrow;
            trainerCombo.ButtonHoverBackground = Color.FromArgb(22, 36, 39);
            trainerCombo.ButtonHoverOutline = Color.FromArgb(22, 36, 39);
            trainerCombo.ButtonNormalBackground = Color.FromArgb(50, 81, 88);
            trainerCombo.ButtonNormalOutline = Color.FromArgb(50, 81, 88);
            trainerCombo.ButtonPressedBackground = Color.FromArgb(22, 36, 39);
            trainerCombo.ButtonPressedOutline = Color.FromArgb(22, 36, 39);
            trainerCombo.DropDownBackgroundColor = Color.FromArgb(50, 81, 88);
            trainerCombo.DropDownOutlineColor = Color.FromArgb(50, 81, 88);
            trainerCombo.ExpandArrowColor = Color.FromArgb(50, 81, 88);
            trainerCombo.ForeColor = Color.Gray;
            trainerCombo.Items = new string[]
    {
    "None",
    "Trainer 1",
    "Trainer 2",
    "Trainer 3"
    };
            trainerCombo.Location = new Point(350, 37);
            trainerCombo.Margin = new Padding(4, 3, 4, 3);
            trainerCombo.Name = "trainerCombo";
            trainerCombo.NoSelectionDropdownText = "Empty";
            trainerCombo.NoSelectionText = "Select a trainer";
            trainerCombo.OutlineColor = Color.FromArgb(50, 81, 88);
            trainerCombo.OutlineThickness = 1F;
            trainerCombo.Rounding = 8;
            trainerCombo.Size = new Size(300, 27);
            trainerCombo.TabIndex = 35;
            // 
            // endDate
            // 
            endDate.EnableThemeChangeButton = true;
            endDate.Font = new Font("Segoe UI", 9.75F);
            endDate.ForeColor = Color.Gray;
            endDate.HoverBackground = Color.FromArgb(50, 128, 128, 128);
            endDate.HoverOutline = Color.FromArgb(180, 128, 128, 128);
            endDate.Icon = (Image)resources.GetObject("endDate.Icon");
            endDate.IconTint = Color.Gray;
            endDate.Location = new Point(439, 143);
            endDate.Margin = new Padding(4);
            endDate.Name = "endDate";
            endDate.NormalBackground = Color.White;
            endDate.NormalOutline = Color.FromArgb(51, 81, 88);
            endDate.OutlineThickness = 1.5F;
            endDate.PressedBackground = Color.FromArgb(80, 128, 128, 128);
            endDate.PressedOutline = Color.FromArgb(210, 128, 128, 128);
            endDate.Rounding = 10;
            endDate.ShowIcon = true;
            endDate.Size = new Size(211, 28);
            endDate.TabIndex = 27;
            endDate.Theme = CuoreUI.Controls.Forms.DatePicker.Themes.Light;
            endDate.Value = new DateTime(2025, 6, 4, 0, 0, 0, 0);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Inter", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Silver;
            label3.Location = new Point(353, 108);
            label3.Name = "label3";
            label3.Size = new Size(79, 22);
            label3.TabIndex = 37;
            label3.Text = "Start date";
            // 
            // statusCombo
            // 
            statusCombo.BackColor = Color.Transparent;
            statusCombo.BackgroundColor = Color.White;
            statusCombo.ButtonCursor = Cursors.Arrow;
            statusCombo.ButtonHoverBackground = Color.FromArgb(22, 36, 39);
            statusCombo.ButtonHoverOutline = Color.FromArgb(22, 36, 39);
            statusCombo.ButtonNormalBackground = Color.FromArgb(50, 81, 88);
            statusCombo.ButtonNormalOutline = Color.FromArgb(50, 81, 88);
            statusCombo.ButtonPressedBackground = Color.FromArgb(22, 36, 39);
            statusCombo.ButtonPressedOutline = Color.FromArgb(22, 36, 39);
            statusCombo.DropDownBackgroundColor = Color.FromArgb(50, 81, 88);
            statusCombo.DropDownOutlineColor = Color.FromArgb(50, 81, 88);
            statusCombo.ExpandArrowColor = Color.FromArgb(50, 81, 88);
            statusCombo.ForeColor = Color.Gray;
            statusCombo.Items = new string[]
    {
    "Active",
    "Inactive"
    };
            statusCombo.Location = new Point(25, 179);
            statusCombo.Margin = new Padding(4, 3, 4, 3);
            statusCombo.Name = "statusCombo";
            statusCombo.NoSelectionDropdownText = "Empty";
            statusCombo.NoSelectionText = "Select status";
            statusCombo.OutlineColor = Color.FromArgb(50, 81, 88);
            statusCombo.OutlineThickness = 1F;
            statusCombo.Rounding = 8;
            statusCombo.Size = new Size(148, 27);
            statusCombo.TabIndex = 34;
            // 
            // startDate
            // 
            startDate.EnableThemeChangeButton = true;
            startDate.Font = new Font("Segoe UI", 9.75F);
            startDate.ForeColor = Color.Gray;
            startDate.HoverBackground = Color.FromArgb(50, 128, 128, 128);
            startDate.HoverOutline = Color.FromArgb(180, 128, 128, 128);
            startDate.Icon = (Image)resources.GetObject("startDate.Icon");
            startDate.IconTint = Color.Gray;
            startDate.Location = new Point(439, 107);
            startDate.Margin = new Padding(4);
            startDate.Name = "startDate";
            startDate.NormalBackground = Color.White;
            startDate.NormalOutline = Color.FromArgb(51, 81, 88);
            startDate.OutlineThickness = 1.5F;
            startDate.PressedBackground = Color.FromArgb(80, 128, 128, 128);
            startDate.PressedOutline = Color.FromArgb(210, 128, 128, 128);
            startDate.Rounding = 10;
            startDate.ShowIcon = true;
            startDate.Size = new Size(211, 28);
            startDate.TabIndex = 26;
            startDate.Theme = CuoreUI.Controls.Forms.DatePicker.Themes.Light;
            startDate.Value = new DateTime(2025, 6, 4, 0, 0, 0, 0);
            // 
            // membershipTypeCombo
            // 
            membershipTypeCombo.BackColor = Color.Transparent;
            membershipTypeCombo.BackgroundColor = Color.White;
            membershipTypeCombo.ButtonCursor = Cursors.Arrow;
            membershipTypeCombo.ButtonHoverBackground = Color.FromArgb(22, 36, 39);
            membershipTypeCombo.ButtonHoverOutline = Color.FromArgb(22, 36, 39);
            membershipTypeCombo.ButtonNormalBackground = Color.FromArgb(50, 81, 88);
            membershipTypeCombo.ButtonNormalOutline = Color.FromArgb(50, 81, 88);
            membershipTypeCombo.ButtonPressedBackground = Color.FromArgb(22, 36, 39);
            membershipTypeCombo.ButtonPressedOutline = Color.FromArgb(22, 36, 39);
            membershipTypeCombo.DropDownBackgroundColor = Color.FromArgb(50, 81, 88);
            membershipTypeCombo.DropDownOutlineColor = Color.FromArgb(50, 81, 88);
            membershipTypeCombo.ExpandArrowColor = Color.FromArgb(50, 81, 88);
            membershipTypeCombo.ForeColor = Color.Gray;
            membershipTypeCombo.Items = new string[]
    {
    "Monthly",
    "Quarterly",
    "Yearly"
    };
            membershipTypeCombo.Location = new Point(177, 179);
            membershipTypeCombo.Margin = new Padding(4, 3, 4, 3);
            membershipTypeCombo.Name = "membershipTypeCombo";
            membershipTypeCombo.NoSelectionDropdownText = "Empty";
            membershipTypeCombo.NoSelectionText = "Membership type";
            membershipTypeCombo.OutlineColor = Color.FromArgb(50, 81, 88);
            membershipTypeCombo.OutlineThickness = 1F;
            membershipTypeCombo.Rounding = 8;
            membershipTypeCombo.Size = new Size(148, 27);
            membershipTypeCombo.TabIndex = 33;
            // 
            // cancelBtn
            // 
            cancelBtn.BackColor = Color.Transparent;
            cancelBtn.Checked = false;
            cancelBtn.CheckedBackground = Color.FromArgb(50, 81, 88);
            cancelBtn.CheckedForeColor = Color.White;
            cancelBtn.CheckedImageTint = Color.White;
            cancelBtn.CheckedOutline = Color.FromArgb(50, 81, 88);
            cancelBtn.Content = "Cancel";
            cancelBtn.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cancelBtn.ForeColor = Color.Black;
            cancelBtn.Group = 0;
            cancelBtn.HoverBackground = Color.FromArgb(22, 36, 39);
            cancelBtn.HoveredImageTint = Color.White;
            cancelBtn.HoverForeColor = Color.White;
            cancelBtn.HoverOutline = Color.FromArgb(22, 36, 39);
            cancelBtn.Image = null;
            cancelBtn.ImageAutoCenter = true;
            cancelBtn.ImageExpand = new Point(0, 0);
            cancelBtn.ImageOffset = new Point(0, 0);
            cancelBtn.Location = new Point(494, 211);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.NormalBackground = Color.White;
            cancelBtn.NormalForeColor = Color.Black;
            cancelBtn.NormalImageTint = Color.White;
            cancelBtn.NormalOutline = Color.FromArgb(50, 81, 88);
            cancelBtn.OutlineThickness = 1F;
            cancelBtn.PressedBackground = Color.FromArgb(22, 36, 39);
            cancelBtn.PressedForeColor = Color.White;
            cancelBtn.PressedImageTint = Color.White;
            cancelBtn.PressedOutline = Color.FromArgb(22, 36, 39);
            cancelBtn.Rounding = new Padding(10);
            cancelBtn.Size = new Size(75, 26);
            cancelBtn.TabIndex = 21;
            cancelBtn.TextAlignment = StringAlignment.Center;
            cancelBtn.TextOffset = new Point(0, 0);
            cancelBtn.Click += cancelBtn_Click;
            // 
            // doneBtn
            // 
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
            doneBtn.HoverBackground = Color.FromArgb(22, 36, 39);
            doneBtn.HoveredImageTint = Color.White;
            doneBtn.HoverForeColor = Color.White;
            doneBtn.HoverOutline = Color.FromArgb(22, 36, 39);
            doneBtn.Image = null;
            doneBtn.ImageAutoCenter = true;
            doneBtn.ImageExpand = new Point(0, 0);
            doneBtn.ImageOffset = new Point(0, 0);
            doneBtn.Location = new Point(575, 211);
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
            doneBtn.Rounding = new Padding(10);
            doneBtn.Size = new Size(75, 26);
            doneBtn.TabIndex = 20;
            doneBtn.TextAlignment = StringAlignment.Center;
            doneBtn.TextOffset = new Point(0, 0);
            doneBtn.Click += doneBtn_Click;
            // 
            // phoneNumTxt
            // 
            phoneNumTxt.BackColor = Color.Transparent;
            phoneNumTxt.BackgroundColor = Color.White;
            phoneNumTxt.BorderColor = Color.FromArgb(50, 81, 88);
            phoneNumTxt.Content = "";
            phoneNumTxt.FocusBackgroundColor = Color.White;
            phoneNumTxt.FocusBorderColor = Color.FromArgb(50, 81, 88);
            phoneNumTxt.FocusImageTint = Color.White;
            phoneNumTxt.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            phoneNumTxt.ForeColor = Color.Black;
            phoneNumTxt.Image = null;
            phoneNumTxt.ImageExpand = new Point(0, 0);
            phoneNumTxt.ImageOffset = new Point(0, 0);
            phoneNumTxt.Location = new Point(25, 144);
            phoneNumTxt.Margin = new Padding(4);
            phoneNumTxt.Multiline = false;
            phoneNumTxt.Name = "phoneNumTxt";
            phoneNumTxt.NormalImageTint = Color.White;
            phoneNumTxt.Padding = new Padding(13, 8, 13, 0);
            phoneNumTxt.PasswordChar = false;
            phoneNumTxt.PlaceholderColor = SystemColors.ScrollBar;
            phoneNumTxt.PlaceholderText = "Phone number";
            phoneNumTxt.Rounding = new Padding(10);
            phoneNumTxt.Size = new Size(300, 28);
            phoneNumTxt.TabIndex = 15;
            phoneNumTxt.TextOffset = new Size(0, 0);
            phoneNumTxt.UnderlinedStyle = false;
            phoneNumTxt.KeyPress += phoneNumTxt_KeyPress;
            // 
            // emailAddTxt
            // 
            emailAddTxt.BackColor = Color.Transparent;
            emailAddTxt.BackgroundColor = Color.White;
            emailAddTxt.BorderColor = Color.FromArgb(50, 81, 88);
            emailAddTxt.Content = "";
            emailAddTxt.FocusBackgroundColor = Color.White;
            emailAddTxt.FocusBorderColor = Color.FromArgb(50, 81, 88);
            emailAddTxt.FocusImageTint = Color.White;
            emailAddTxt.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailAddTxt.ForeColor = Color.Black;
            emailAddTxt.Image = null;
            emailAddTxt.ImageExpand = new Point(0, 0);
            emailAddTxt.ImageOffset = new Point(0, 0);
            emailAddTxt.Location = new Point(25, 108);
            emailAddTxt.Margin = new Padding(4);
            emailAddTxt.Multiline = false;
            emailAddTxt.Name = "emailAddTxt";
            emailAddTxt.NormalImageTint = Color.White;
            emailAddTxt.Padding = new Padding(13, 8, 13, 0);
            emailAddTxt.PasswordChar = false;
            emailAddTxt.PlaceholderColor = SystemColors.ScrollBar;
            emailAddTxt.PlaceholderText = "Email address";
            emailAddTxt.Rounding = new Padding(10);
            emailAddTxt.Size = new Size(300, 28);
            emailAddTxt.TabIndex = 14;
            emailAddTxt.TextOffset = new Size(0, 0);
            emailAddTxt.UnderlinedStyle = false;
            // 
            // lastNameTxt
            // 
            lastNameTxt.BackColor = Color.Transparent;
            lastNameTxt.BackgroundColor = Color.White;
            lastNameTxt.BorderColor = Color.FromArgb(50, 81, 88);
            lastNameTxt.Content = "";
            lastNameTxt.FocusBackgroundColor = Color.White;
            lastNameTxt.FocusBorderColor = Color.FromArgb(50, 81, 88);
            lastNameTxt.FocusImageTint = Color.White;
            lastNameTxt.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lastNameTxt.ForeColor = Color.Black;
            lastNameTxt.Image = null;
            lastNameTxt.ImageExpand = new Point(0, 0);
            lastNameTxt.ImageOffset = new Point(0, 0);
            lastNameTxt.Location = new Point(25, 72);
            lastNameTxt.Margin = new Padding(4);
            lastNameTxt.Multiline = false;
            lastNameTxt.Name = "lastNameTxt";
            lastNameTxt.NormalImageTint = Color.White;
            lastNameTxt.Padding = new Padding(13, 8, 13, 0);
            lastNameTxt.PasswordChar = false;
            lastNameTxt.PlaceholderColor = SystemColors.ScrollBar;
            lastNameTxt.PlaceholderText = "Last name";
            lastNameTxt.Rounding = new Padding(10);
            lastNameTxt.Size = new Size(300, 28);
            lastNameTxt.TabIndex = 13;
            lastNameTxt.TextOffset = new Size(0, 0);
            lastNameTxt.UnderlinedStyle = false;
            // 
            // firstNameTxt
            // 
            firstNameTxt.BackColor = Color.Transparent;
            firstNameTxt.BackgroundColor = Color.White;
            firstNameTxt.BorderColor = Color.FromArgb(50, 81, 88);
            firstNameTxt.Content = "";
            firstNameTxt.FocusBackgroundColor = Color.White;
            firstNameTxt.FocusBorderColor = Color.FromArgb(50, 81, 88);
            firstNameTxt.FocusImageTint = Color.White;
            firstNameTxt.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            firstNameTxt.ForeColor = Color.Black;
            firstNameTxt.Image = null;
            firstNameTxt.ImageExpand = new Point(0, 0);
            firstNameTxt.ImageOffset = new Point(0, 0);
            firstNameTxt.Location = new Point(25, 36);
            firstNameTxt.Margin = new Padding(4);
            firstNameTxt.Multiline = false;
            firstNameTxt.Name = "firstNameTxt";
            firstNameTxt.NormalImageTint = Color.White;
            firstNameTxt.Padding = new Padding(13, 8, 13, 0);
            firstNameTxt.PasswordChar = false;
            firstNameTxt.PlaceholderColor = SystemColors.ScrollBar;
            firstNameTxt.PlaceholderText = "First name";
            firstNameTxt.Rounding = new Padding(10);
            firstNameTxt.Size = new Size(300, 28);
            firstNameTxt.TabIndex = 11;
            firstNameTxt.TextOffset = new Size(0, 0);
            firstNameTxt.UnderlinedStyle = false;
            // 
            // EditMemberForm1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(739, 357);
            Controls.Add(cuiPanel1);
            Controls.Add(label1);
            ForeColor = Color.White;
            Margin = new Padding(3, 2, 3, 2);
            Name = "EditMemberForm1";
            Text = "EditMemberForm1";
            cuiPanel1.ResumeLayout(false);
            cuiPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private CuoreUI.Controls.cuiPanel cuiPanel1;
        private CuoreUI.Controls.cuiCalendarDatePicker birthDate;
        private Label label2;
        private Label label4;
        private CuoreUI.Controls.cuiComboBox trainerCombo;
        private CuoreUI.Controls.cuiCalendarDatePicker endDate;
        private Label label3;
        private CuoreUI.Controls.cuiComboBox statusCombo;
        private CuoreUI.Controls.cuiCalendarDatePicker startDate;
        private CuoreUI.Controls.cuiComboBox membershipTypeCombo;
        private CuoreUI.Controls.cuiButtonGroup cancelBtn;
        private CuoreUI.Controls.cuiButtonGroup doneBtn;
        private CuoreUI.Controls.cuiTextBox phoneNumTxt;
        private CuoreUI.Controls.cuiTextBox emailAddTxt;
        private CuoreUI.Controls.cuiTextBox lastNameTxt;
        private CuoreUI.Controls.cuiTextBox firstNameTxt;
    }
}