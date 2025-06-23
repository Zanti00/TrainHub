namespace TrainHub
{
    partial class RegisterNewTrainer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterNewTrainer));
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            formLabel = new Label();
            cuiPanel2 = new CuoreUI.Controls.cuiPanel();
            cuiComboBox1 = new CuoreUI.Controls.cuiComboBox();
            birthDate = new CuoreUI.Controls.cuiCalendarDatePicker();
            cancelButton = new CuoreUI.Controls.cuiButton();
            cancelBtn = new CuoreUI.Controls.cuiButton();
            addressTxt = new CuoreUI.Controls.cuiTextBox();
            emailTxt = new CuoreUI.Controls.cuiTextBox();
            lastNameTxt = new CuoreUI.Controls.cuiTextBox();
            mobNumTxt = new CuoreUI.Controls.cuiTextBox();
            firstNameTxt = new CuoreUI.Controls.cuiTextBox();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            cuiTabControl1 = new CuoreUI.Controls.cuiTabControl();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            cuiPanel1 = new CuoreUI.Controls.cuiPanel();
            doneBtn = new CuoreUI.Controls.cuiButton();
            pictureBox1 = new PictureBox();
            openCameraBtn = new CuoreUI.Controls.cuiButtonGroup();
            captureBtn = new CuoreUI.Controls.cuiButtonGroup();
            statusCombo = new CuoreUI.Controls.cuiComboBox();
            hourlyRateTxt = new CuoreUI.Controls.cuiTextBox();
            availabilityTxt = new CuoreUI.Controls.cuiTextBox();
            yearsOfExperienceTxt = new CuoreUI.Controls.cuiTextBox();
            specializationTxt = new CuoreUI.Controls.cuiTextBox();
            cuiPanel2.SuspendLayout();
            cuiTabControl1.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            cuiPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // formLabel
            // 
            formLabel.AutoSize = true;
            formLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            formLabel.ForeColor = Color.FromArgb(50, 81, 88);
            formLabel.Location = new Point(27, 26);
            formLabel.Name = "formLabel";
            formLabel.Size = new Size(239, 30);
            formLabel.TabIndex = 6;
            formLabel.Text = "Register New Trainers";
            // 
            // cuiPanel2
            // 
            cuiPanel2.BackColor = Color.Transparent;
            cuiPanel2.BackgroundImageLayout = ImageLayout.None;
            cuiPanel2.Controls.Add(cuiComboBox1);
            cuiPanel2.Controls.Add(birthDate);
            cuiPanel2.Controls.Add(cancelButton);
            cuiPanel2.Controls.Add(cancelBtn);
            cuiPanel2.Controls.Add(addressTxt);
            cuiPanel2.Controls.Add(emailTxt);
            cuiPanel2.Controls.Add(lastNameTxt);
            cuiPanel2.Controls.Add(mobNumTxt);
            cuiPanel2.Controls.Add(firstNameTxt);
            cuiPanel2.Dock = DockStyle.Fill;
            cuiPanel2.Location = new Point(3, 3);
            cuiPanel2.Name = "cuiPanel2";
            cuiPanel2.OutlineThickness = 1F;
            cuiPanel2.PanelColor = Color.White;
            cuiPanel2.PanelOutlineColor = Color.Black;
            cuiPanel2.Rounding = new Padding(10);
            cuiPanel2.Size = new Size(660, 296);
            cuiPanel2.TabIndex = 7;
            // 
            // cuiComboBox1
            // 
            cuiComboBox1.BackgroundColor = Color.FromArgb(255, 255, 255);
            cuiComboBox1.ButtonCursor = Cursors.Arrow;
            cuiComboBox1.ButtonHoverBackground = Color.FromArgb(192, 255, 106, 0);
            cuiComboBox1.ButtonHoverOutline = Color.Empty;
            cuiComboBox1.ButtonNormalBackground = Color.FromArgb(255, 106, 0);
            cuiComboBox1.ButtonNormalOutline = Color.Empty;
            cuiComboBox1.ButtonPressedBackground = Color.FromArgb(255, 106, 0);
            cuiComboBox1.ButtonPressedOutline = Color.Empty;
            cuiComboBox1.DropDownBackgroundColor = Color.White;
            cuiComboBox1.DropDownOutlineColor = Color.FromArgb(30, 255, 255, 255);
            cuiComboBox1.ExpandArrowColor = Color.Gray;
            cuiComboBox1.ForeColor = Color.Gray;
            cuiComboBox1.Location = new Point(483, 92);
            cuiComboBox1.Margin = new Padding(4, 3, 4, 3);
            cuiComboBox1.Name = "cuiComboBox1";
            cuiComboBox1.NoSelectionDropdownText = "Empty";
            cuiComboBox1.NoSelectionText = "None";
            cuiComboBox1.OutlineColor = Color.FromArgb(64, 128, 128, 128);
            cuiComboBox1.OutlineThickness = 1F;
            cuiComboBox1.Rounding = 8;
            cuiComboBox1.Size = new Size(140, 38);
            cuiComboBox1.TabIndex = 26;
            // 
            // birthDate
            // 
            birthDate.Anchor = AnchorStyles.None;
            birthDate.EnableThemeChangeButton = true;
            birthDate.Font = new Font("Segoe UI", 9.75F);
            birthDate.ForeColor = Color.Gray;
            birthDate.HoverBackground = Color.FromArgb(50, 128, 128, 128);
            birthDate.HoverOutline = Color.FromArgb(180, 128, 128, 128);
            birthDate.Icon = (Image)resources.GetObject("birthDate.Icon");
            birthDate.IconTint = Color.Gray;
            birthDate.Location = new Point(338, 91);
            birthDate.Margin = new Padding(4, 3, 4, 3);
            birthDate.Name = "birthDate";
            birthDate.NormalBackground = Color.FromArgb(32, 128, 128, 128);
            birthDate.NormalOutline = Color.FromArgb(150, 128, 128, 128);
            birthDate.OutlineThickness = 1.5F;
            birthDate.PressedBackground = Color.FromArgb(80, 128, 128, 128);
            birthDate.PressedOutline = Color.FromArgb(210, 128, 128, 128);
            birthDate.Rounding = 8;
            birthDate.ShowIcon = true;
            birthDate.Size = new Size(140, 38);
            birthDate.TabIndex = 24;
            birthDate.Theme = CuoreUI.Controls.Forms.DatePicker.Themes.Light;
            birthDate.Value = new DateTime(2025, 6, 6, 0, 0, 0, 0);
            // 
            // cancelButton
            // 
            cancelButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cancelButton.CheckButton = false;
            cancelButton.Checked = false;
            cancelButton.CheckedBackground = Color.FromArgb(255, 106, 0);
            cancelButton.CheckedForeColor = Color.White;
            cancelButton.CheckedImageTint = Color.White;
            cancelButton.CheckedOutline = Color.FromArgb(255, 106, 0);
            cancelButton.Content = "Cancel";
            cancelButton.DialogResult = DialogResult.None;
            cancelButton.Font = new Font("Microsoft Sans Serif", 9.75F);
            cancelButton.ForeColor = Color.Black;
            cancelButton.HoverBackground = Color.White;
            cancelButton.HoveredImageTint = Color.White;
            cancelButton.HoverForeColor = Color.Black;
            cancelButton.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            cancelButton.Image = null;
            cancelButton.ImageAutoCenter = true;
            cancelButton.ImageExpand = new Point(0, 0);
            cancelButton.ImageOffset = new Point(0, 0);
            cancelButton.Location = new Point(552, 232);
            cancelButton.Name = "cancelButton";
            cancelButton.NormalBackground = Color.White;
            cancelButton.NormalForeColor = Color.Black;
            cancelButton.NormalImageTint = Color.White;
            cancelButton.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            cancelButton.OutlineThickness = 1F;
            cancelButton.PressedBackground = Color.WhiteSmoke;
            cancelButton.PressedForeColor = Color.FromArgb(32, 32, 32);
            cancelButton.PressedImageTint = Color.White;
            cancelButton.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            cancelButton.Rounding = new Padding(10);
            cancelButton.Size = new Size(71, 32);
            cancelButton.TabIndex = 22;
            cancelButton.TextAlignment = StringAlignment.Center;
            cancelButton.TextOffset = new Point(0, 0);
            cancelButton.Click += cancelBtn_Click;
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
            cancelBtn.Location = new Point(932, 328);
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
            cancelBtn.Rounding = new Padding(8);
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
            addressTxt.Location = new Point(338, 46);
            addressTxt.Margin = new Padding(4);
            addressTxt.Multiline = false;
            addressTxt.Name = "addressTxt";
            addressTxt.NormalImageTint = Color.White;
            addressTxt.Padding = new Padding(13, 13, 13, 0);
            addressTxt.PasswordChar = false;
            addressTxt.PlaceholderColor = SystemColors.ScrollBar;
            addressTxt.PlaceholderText = "Address";
            addressTxt.Rounding = new Padding(10);
            addressTxt.Size = new Size(285, 38);
            addressTxt.TabIndex = 16;
            addressTxt.TextOffset = new Size(0, 0);
            addressTxt.UnderlinedStyle = false;
            // 
            // emailTxt
            // 
            emailTxt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
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
            emailTxt.Location = new Point(34, 138);
            emailTxt.Margin = new Padding(4);
            emailTxt.Multiline = false;
            emailTxt.Name = "emailTxt";
            emailTxt.NormalImageTint = Color.White;
            emailTxt.Padding = new Padding(13, 13, 13, 0);
            emailTxt.PasswordChar = false;
            emailTxt.PlaceholderColor = SystemColors.ScrollBar;
            emailTxt.PlaceholderText = "Email Address ";
            emailTxt.Rounding = new Padding(10);
            emailTxt.Size = new Size(285, 38);
            emailTxt.TabIndex = 15;
            emailTxt.TextOffset = new Size(0, 0);
            emailTxt.UnderlinedStyle = false;
            // 
            // lastNameTxt
            // 
            lastNameTxt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
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
            lastNameTxt.Location = new Point(34, 92);
            lastNameTxt.Margin = new Padding(4);
            lastNameTxt.Multiline = false;
            lastNameTxt.Name = "lastNameTxt";
            lastNameTxt.NormalImageTint = Color.White;
            lastNameTxt.Padding = new Padding(13, 13, 13, 0);
            lastNameTxt.PasswordChar = false;
            lastNameTxt.PlaceholderColor = SystemColors.ScrollBar;
            lastNameTxt.PlaceholderText = "Last Name";
            lastNameTxt.Rounding = new Padding(10);
            lastNameTxt.Size = new Size(285, 38);
            lastNameTxt.TabIndex = 11;
            lastNameTxt.TextOffset = new Size(0, 0);
            lastNameTxt.UnderlinedStyle = false;
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
            mobNumTxt.Location = new Point(34, 184);
            mobNumTxt.Margin = new Padding(4);
            mobNumTxt.Multiline = false;
            mobNumTxt.Name = "mobNumTxt";
            mobNumTxt.NormalImageTint = Color.White;
            mobNumTxt.Padding = new Padding(13, 13, 13, 0);
            mobNumTxt.PasswordChar = false;
            mobNumTxt.PlaceholderColor = SystemColors.ScrollBar;
            mobNumTxt.PlaceholderText = "Mobile Number";
            mobNumTxt.Rounding = new Padding(10);
            mobNumTxt.Size = new Size(285, 38);
            mobNumTxt.TabIndex = 12;
            mobNumTxt.TextOffset = new Size(0, 0);
            mobNumTxt.UnderlinedStyle = false;
            mobNumTxt.KeyPress += mobNumTxt_KeyPress_1;
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
            firstNameTxt.Location = new Point(34, 46);
            firstNameTxt.Margin = new Padding(4);
            firstNameTxt.Multiline = false;
            firstNameTxt.Name = "firstNameTxt";
            firstNameTxt.NormalImageTint = Color.White;
            firstNameTxt.Padding = new Padding(13, 13, 13, 0);
            firstNameTxt.PasswordChar = false;
            firstNameTxt.PlaceholderColor = SystemColors.ScrollBar;
            firstNameTxt.PlaceholderText = "First Name";
            firstNameTxt.Rounding = new Padding(10);
            firstNameTxt.Size = new Size(285, 38);
            firstNameTxt.TabIndex = 11;
            firstNameTxt.TextOffset = new Size(0, 0);
            firstNameTxt.UnderlinedStyle = false;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 46);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(283, 149);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 46);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(192, 50);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // cuiTabControl1
            // 
            cuiTabControl1.AddButtonBackgroundColor = Color.FromArgb(128, 0, 0, 0);
            cuiTabControl1.AddButtonColor = Color.White;
            cuiTabControl1.AllowNoTabs = false;
            cuiTabControl1.Appearance = TabAppearance.Buttons;
            cuiTabControl1.BackgroundColor = Color.Transparent;
            cuiTabControl1.Controls.Add(tabPage3);
            cuiTabControl1.Controls.Add(tabPage4);
            cuiTabControl1.DeletionColor = Color.White;
            cuiTabControl1.DeletionTabBackgroundColor = Color.Crimson;
            cuiTabControl1.DrawMode = TabDrawMode.OwnerDrawFixed;
            cuiTabControl1.HoverCursor = Cursors.Hand;
            cuiTabControl1.HoveredTabBackColor = Color.FromArgb(64, 128, 128, 128);
            cuiTabControl1.HoveredTabTextBackColor = Color.FromArgb(64, 64, 64);
            cuiTabControl1.ItemSize = new Size(126, 42);
            cuiTabControl1.Location = new Point(27, 72);
            cuiTabControl1.Name = "cuiTabControl1";
            cuiTabControl1.Rounding = 8;
            cuiTabControl1.SelectedIndex = 0;
            cuiTabControl1.SelectedTabBackColor = Color.FromArgb(50, 81, 88);
            cuiTabControl1.SelectedTabTextBackColor = Color.White;
            cuiTabControl1.ShowAddTabButton = false;
            cuiTabControl1.Size = new Size(674, 352);
            cuiTabControl1.SizeMode = TabSizeMode.Fixed;
            cuiTabControl1.TabIndex = 28;
            cuiTabControl1.tabNamingConvention = "tabPage";
            cuiTabControl1.UnselectedTabBackColor = Color.FromArgb(32, 128, 128, 128);
            cuiTabControl1.UnselectedTabTextBackColor = Color.Gray;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.Transparent;
            tabPage3.Controls.Add(cuiPanel2);
            tabPage3.Location = new Point(4, 46);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(666, 302);
            tabPage3.TabIndex = 0;
            tabPage3.Text = "Basic Information";
            // 
            // tabPage4
            // 
            tabPage4.BackColor = Color.Transparent;
            tabPage4.Controls.Add(cuiPanel1);
            tabPage4.Location = new Point(4, 46);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(666, 302);
            tabPage4.TabIndex = 1;
            tabPage4.Text = "Professional Information";
            // 
            // cuiPanel1
            // 
            cuiPanel1.Controls.Add(doneBtn);
            cuiPanel1.Controls.Add(pictureBox1);
            cuiPanel1.Controls.Add(openCameraBtn);
            cuiPanel1.Controls.Add(captureBtn);
            cuiPanel1.Controls.Add(statusCombo);
            cuiPanel1.Controls.Add(hourlyRateTxt);
            cuiPanel1.Controls.Add(availabilityTxt);
            cuiPanel1.Controls.Add(yearsOfExperienceTxt);
            cuiPanel1.Controls.Add(specializationTxt);
            cuiPanel1.Dock = DockStyle.Fill;
            cuiPanel1.Location = new Point(3, 3);
            cuiPanel1.Name = "cuiPanel1";
            cuiPanel1.OutlineThickness = 1F;
            cuiPanel1.PanelColor = Color.White;
            cuiPanel1.PanelOutlineColor = Color.Black;
            cuiPanel1.Rounding = new Padding(8);
            cuiPanel1.Size = new Size(660, 296);
            cuiPanel1.TabIndex = 0;
            // 
            // doneBtn
            // 
            doneBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            doneBtn.CheckButton = false;
            doneBtn.Checked = true;
            doneBtn.CheckedBackground = Color.FromArgb(50, 81, 88);
            doneBtn.CheckedForeColor = SystemColors.Window;
            doneBtn.CheckedImageTint = Color.White;
            doneBtn.CheckedOutline = Color.FromArgb(50, 81, 88);
            doneBtn.Content = "DONE";
            doneBtn.DialogResult = DialogResult.None;
            doneBtn.Font = new Font("Microsoft Sans Serif", 9.75F);
            doneBtn.ForeColor = Color.White;
            doneBtn.HoverBackground = Color.FromArgb(22, 36, 39);
            doneBtn.HoveredImageTint = Color.White;
            doneBtn.HoverForeColor = Color.Black;
            doneBtn.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            doneBtn.Image = null;
            doneBtn.ImageAutoCenter = true;
            doneBtn.ImageExpand = new Point(0, 0);
            doneBtn.ImageOffset = new Point(0, 0);
            doneBtn.Location = new Point(568, 235);
            doneBtn.Name = "doneBtn";
            doneBtn.NormalBackground = Color.FromArgb(50, 81, 88);
            doneBtn.NormalForeColor = Color.White;
            doneBtn.NormalImageTint = Color.White;
            doneBtn.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            doneBtn.OutlineThickness = 1F;
            doneBtn.PressedBackground = Color.WhiteSmoke;
            doneBtn.PressedForeColor = Color.FromArgb(32, 32, 32);
            doneBtn.PressedImageTint = Color.White;
            doneBtn.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            doneBtn.Rounding = new Padding(10);
            doneBtn.Size = new Size(71, 32);
            doneBtn.TabIndex = 48;
            doneBtn.TextAlignment = StringAlignment.Center;
            doneBtn.TextOffset = new Point(0, 0);
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(22, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(220, 125);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 46;
            pictureBox1.TabStop = false;
            // 
            // openCameraBtn
            // 
            openCameraBtn.Checked = false;
            openCameraBtn.CheckedBackground = Color.FromArgb(50, 81, 88);
            openCameraBtn.CheckedForeColor = Color.White;
            openCameraBtn.CheckedImageTint = Color.White;
            openCameraBtn.CheckedOutline = Color.FromArgb(50, 81, 88);
            openCameraBtn.Content = "Open camera";
            openCameraBtn.Font = new Font("Microsoft Sans Serif", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            openCameraBtn.ForeColor = Color.Black;
            openCameraBtn.Group = 0;
            openCameraBtn.HoverBackground = Color.FromArgb(50, 81, 88);
            openCameraBtn.HoveredImageTint = Color.White;
            openCameraBtn.HoverForeColor = Color.White;
            openCameraBtn.HoverOutline = Color.FromArgb(50, 81, 88);
            openCameraBtn.Image = null;
            openCameraBtn.ImageAutoCenter = true;
            openCameraBtn.ImageExpand = new Point(0, 0);
            openCameraBtn.ImageOffset = new Point(0, 0);
            openCameraBtn.Location = new Point(257, 61);
            openCameraBtn.Name = "openCameraBtn";
            openCameraBtn.NormalBackground = Color.White;
            openCameraBtn.NormalForeColor = Color.Black;
            openCameraBtn.NormalImageTint = Color.White;
            openCameraBtn.NormalOutline = Color.FromArgb(50, 81, 88);
            openCameraBtn.OutlineThickness = 1F;
            openCameraBtn.PressedBackground = Color.FromArgb(22, 36, 39);
            openCameraBtn.PressedForeColor = Color.White;
            openCameraBtn.PressedImageTint = Color.White;
            openCameraBtn.PressedOutline = Color.FromArgb(22, 36, 39);
            openCameraBtn.Rounding = new Padding(8);
            openCameraBtn.Size = new Size(80, 28);
            openCameraBtn.TabIndex = 45;
            openCameraBtn.TextAlignment = StringAlignment.Center;
            openCameraBtn.TextOffset = new Point(0, 0);
            // 
            // captureBtn
            // 
            captureBtn.Checked = false;
            captureBtn.CheckedBackground = Color.FromArgb(50, 81, 88);
            captureBtn.CheckedForeColor = Color.White;
            captureBtn.CheckedImageTint = Color.White;
            captureBtn.CheckedOutline = Color.FromArgb(50, 81, 88);
            captureBtn.Content = "Capture";
            captureBtn.Font = new Font("Microsoft Sans Serif", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            captureBtn.ForeColor = Color.Black;
            captureBtn.Group = 0;
            captureBtn.HoverBackground = Color.FromArgb(50, 81, 88);
            captureBtn.HoveredImageTint = Color.White;
            captureBtn.HoverForeColor = Color.White;
            captureBtn.HoverOutline = Color.FromArgb(50, 81, 88);
            captureBtn.Image = null;
            captureBtn.ImageAutoCenter = true;
            captureBtn.ImageExpand = new Point(0, 0);
            captureBtn.ImageOffset = new Point(0, 0);
            captureBtn.Location = new Point(257, 27);
            captureBtn.Name = "captureBtn";
            captureBtn.NormalBackground = Color.White;
            captureBtn.NormalForeColor = Color.Black;
            captureBtn.NormalImageTint = Color.White;
            captureBtn.NormalOutline = Color.FromArgb(50, 81, 88);
            captureBtn.OutlineThickness = 1F;
            captureBtn.PressedBackground = Color.FromArgb(22, 36, 39);
            captureBtn.PressedForeColor = Color.White;
            captureBtn.PressedImageTint = Color.White;
            captureBtn.PressedOutline = Color.FromArgb(22, 36, 39);
            captureBtn.Rounding = new Padding(8);
            captureBtn.Size = new Size(80, 28);
            captureBtn.TabIndex = 44;
            captureBtn.TextAlignment = StringAlignment.Center;
            captureBtn.TextOffset = new Point(0, 0);
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
    "Inactive",
    "Terminated"
    };
            statusCombo.Location = new Point(504, 162);
            statusCombo.Margin = new Padding(4, 3, 4, 3);
            statusCombo.Name = "statusCombo";
            statusCombo.NoSelectionDropdownText = "Empty";
            statusCombo.NoSelectionText = "Select status";
            statusCombo.OutlineColor = Color.FromArgb(50, 81, 88);
            statusCombo.OutlineThickness = 1F;
            statusCombo.Rounding = 8;
            statusCombo.Size = new Size(137, 38);
            statusCombo.TabIndex = 35;
            // 
            // hourlyRateTxt
            // 
            hourlyRateTxt.BackColor = Color.Transparent;
            hourlyRateTxt.BackgroundColor = Color.White;
            hourlyRateTxt.BorderColor = Color.FromArgb(50, 81, 88);
            hourlyRateTxt.Content = "";
            hourlyRateTxt.FocusBackgroundColor = Color.White;
            hourlyRateTxt.FocusBorderColor = Color.FromArgb(50, 81, 88);
            hourlyRateTxt.FocusImageTint = Color.White;
            hourlyRateTxt.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            hourlyRateTxt.ForeColor = Color.Black;
            hourlyRateTxt.Image = null;
            hourlyRateTxt.ImageExpand = new Point(0, 0);
            hourlyRateTxt.ImageOffset = new Point(0, 0);
            hourlyRateTxt.Location = new Point(359, 162);
            hourlyRateTxt.Margin = new Padding(4);
            hourlyRateTxt.Multiline = false;
            hourlyRateTxt.Name = "hourlyRateTxt";
            hourlyRateTxt.NormalImageTint = Color.White;
            hourlyRateTxt.Padding = new Padding(13, 13, 13, 0);
            hourlyRateTxt.PasswordChar = false;
            hourlyRateTxt.PlaceholderColor = SystemColors.ScrollBar;
            hourlyRateTxt.PlaceholderText = "Hourly rate";
            hourlyRateTxt.Rounding = new Padding(10);
            hourlyRateTxt.Size = new Size(137, 38);
            hourlyRateTxt.TabIndex = 15;
            hourlyRateTxt.TextOffset = new Size(0, 0);
            hourlyRateTxt.UnderlinedStyle = false;
            // 
            // availabilityTxt
            // 
            availabilityTxt.BackColor = Color.Transparent;
            availabilityTxt.BackgroundColor = Color.White;
            availabilityTxt.BorderColor = Color.FromArgb(50, 81, 88);
            availabilityTxt.Content = "";
            availabilityTxt.FocusBackgroundColor = Color.White;
            availabilityTxt.FocusBorderColor = Color.FromArgb(50, 81, 88);
            availabilityTxt.FocusImageTint = Color.White;
            availabilityTxt.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            availabilityTxt.ForeColor = Color.Black;
            availabilityTxt.Image = null;
            availabilityTxt.ImageExpand = new Point(0, 0);
            availabilityTxt.ImageOffset = new Point(0, 0);
            availabilityTxt.Location = new Point(359, 116);
            availabilityTxt.Margin = new Padding(4);
            availabilityTxt.Multiline = false;
            availabilityTxt.Name = "availabilityTxt";
            availabilityTxt.NormalImageTint = Color.White;
            availabilityTxt.Padding = new Padding(13, 13, 13, 0);
            availabilityTxt.PasswordChar = false;
            availabilityTxt.PlaceholderColor = SystemColors.ScrollBar;
            availabilityTxt.PlaceholderText = "Availability";
            availabilityTxt.Rounding = new Padding(10);
            availabilityTxt.Size = new Size(280, 38);
            availabilityTxt.TabIndex = 14;
            availabilityTxt.TextOffset = new Size(0, 0);
            availabilityTxt.UnderlinedStyle = false;
            // 
            // yearsOfExperienceTxt
            // 
            yearsOfExperienceTxt.BackColor = Color.Transparent;
            yearsOfExperienceTxt.BackgroundColor = Color.White;
            yearsOfExperienceTxt.BorderColor = Color.FromArgb(50, 81, 88);
            yearsOfExperienceTxt.Content = "";
            yearsOfExperienceTxt.FocusBackgroundColor = Color.White;
            yearsOfExperienceTxt.FocusBorderColor = Color.FromArgb(50, 81, 88);
            yearsOfExperienceTxt.FocusImageTint = Color.White;
            yearsOfExperienceTxt.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            yearsOfExperienceTxt.ForeColor = Color.Black;
            yearsOfExperienceTxt.Image = null;
            yearsOfExperienceTxt.ImageExpand = new Point(0, 0);
            yearsOfExperienceTxt.ImageOffset = new Point(0, 0);
            yearsOfExperienceTxt.Location = new Point(359, 70);
            yearsOfExperienceTxt.Margin = new Padding(4);
            yearsOfExperienceTxt.Multiline = false;
            yearsOfExperienceTxt.Name = "yearsOfExperienceTxt";
            yearsOfExperienceTxt.NormalImageTint = Color.White;
            yearsOfExperienceTxt.Padding = new Padding(13, 13, 13, 0);
            yearsOfExperienceTxt.PasswordChar = false;
            yearsOfExperienceTxt.PlaceholderColor = SystemColors.ScrollBar;
            yearsOfExperienceTxt.PlaceholderText = "Years of experience";
            yearsOfExperienceTxt.Rounding = new Padding(10);
            yearsOfExperienceTxt.Size = new Size(280, 38);
            yearsOfExperienceTxt.TabIndex = 13;
            yearsOfExperienceTxt.TextOffset = new Size(0, 0);
            yearsOfExperienceTxt.UnderlinedStyle = false;
            // 
            // specializationTxt
            // 
            specializationTxt.BackColor = Color.Transparent;
            specializationTxt.BackgroundColor = Color.White;
            specializationTxt.BorderColor = Color.FromArgb(50, 81, 88);
            specializationTxt.Content = "";
            specializationTxt.FocusBackgroundColor = Color.White;
            specializationTxt.FocusBorderColor = Color.FromArgb(50, 81, 88);
            specializationTxt.FocusImageTint = Color.White;
            specializationTxt.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            specializationTxt.ForeColor = Color.Black;
            specializationTxt.Image = null;
            specializationTxt.ImageExpand = new Point(0, 0);
            specializationTxt.ImageOffset = new Point(0, 0);
            specializationTxt.Location = new Point(359, 24);
            specializationTxt.Margin = new Padding(4);
            specializationTxt.Multiline = false;
            specializationTxt.Name = "specializationTxt";
            specializationTxt.NormalImageTint = Color.White;
            specializationTxt.Padding = new Padding(13, 13, 13, 0);
            specializationTxt.PasswordChar = false;
            specializationTxt.PlaceholderColor = SystemColors.ScrollBar;
            specializationTxt.PlaceholderText = "Specialization";
            specializationTxt.Rounding = new Padding(10);
            specializationTxt.Size = new Size(280, 38);
            specializationTxt.TabIndex = 12;
            specializationTxt.TextOffset = new Size(0, 0);
            specializationTxt.UnderlinedStyle = false;
            // 
            // RegisterNewTrainer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(728, 446);
            Controls.Add(cuiTabControl1);
            Controls.Add(formLabel);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RegisterNewTrainer";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "trainer";
            TopMost = true;
            cuiPanel2.ResumeLayout(false);
            cuiTabControl1.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            cuiPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label formLabel;
        private CuoreUI.Controls.cuiPanel cuiPanel2;
        private CuoreUI.Controls.cuiButton cancelBtn;
        private CuoreUI.Controls.cuiTextBox addressTxt;
        private CuoreUI.Controls.cuiTextBox emailTxt;
        private CuoreUI.Controls.cuiTextBox lastNameTxt;
        private CuoreUI.Controls.cuiTextBox mobNumTxt;
        private CuoreUI.Controls.cuiTextBox firstNameTxt;
        private CuoreUI.Controls.cuiButton cancelButton;
        private CuoreUI.Controls.cuiButton nextBtn;
        private CuoreUI.Controls.cuiCalendarDatePicker birthDate;
        private CuoreUI.Controls.cuiComboBox cuiComboBox1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private CuoreUI.Controls.cuiTabControl cuiTabControl1;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private CuoreUI.Controls.cuiPanel cuiPanel1;
        private CuoreUI.Controls.cuiTextBox specializationTxt;
        private CuoreUI.Controls.cuiTextBox yearsOfExperienceTxt;
        private CuoreUI.Controls.cuiTextBox availabilityTxt;
        private CuoreUI.Controls.cuiTextBox hourlyRateTxt;
        private CuoreUI.Controls.cuiComboBox statusCombo;
        private CuoreUI.Controls.cuiButton doneBtn;
        private PictureBox pictureBox1;
        private CuoreUI.Controls.cuiButtonGroup openCameraBtn;
        private CuoreUI.Controls.cuiButtonGroup captureBtn;
    }
}