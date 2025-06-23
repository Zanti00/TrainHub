namespace TrainHub
{
    partial class TrainerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrainerForm));
            cuiTabControl1 = new CuoreUI.Controls.cuiTabControl();
            tabPage3 = new TabPage();
            cuiPanel2 = new CuoreUI.Controls.cuiPanel();
            genderCombo = new CuoreUI.Controls.cuiComboBox();
            birthDate = new CuoreUI.Controls.cuiCalendarDatePicker();
            addressTxt = new CuoreUI.Controls.cuiTextBox();
            emailAddTxt = new CuoreUI.Controls.cuiTextBox();
            lastNameTxt = new CuoreUI.Controls.cuiTextBox();
            phoneNumTxt = new CuoreUI.Controls.cuiTextBox();
            firstNameTxt = new CuoreUI.Controls.cuiTextBox();
            cancelBtn = new CuoreUI.Controls.cuiButton();
            tabPage4 = new TabPage();
            cuiPanel1 = new CuoreUI.Controls.cuiPanel();
            generateQrBtn = new CuoreUI.Controls.cuiButtonGroup();
            doneBtn = new CuoreUI.Controls.cuiButton();
            pictureBox1 = new PictureBox();
            openCameraBtn = new CuoreUI.Controls.cuiButtonGroup();
            captureBtn = new CuoreUI.Controls.cuiButtonGroup();
            statusCombo = new CuoreUI.Controls.cuiComboBox();
            hourlyRateTxt = new CuoreUI.Controls.cuiTextBox();
            availabilityTxt = new CuoreUI.Controls.cuiTextBox();
            yearsOfExperienceTxt = new CuoreUI.Controls.cuiTextBox();
            specializationTxt = new CuoreUI.Controls.cuiTextBox();
            formLabel = new Label();
            label2 = new Label();
            cuiTabControl1.SuspendLayout();
            tabPage3.SuspendLayout();
            cuiPanel2.SuspendLayout();
            tabPage4.SuspendLayout();
            cuiPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
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
            cuiTabControl1.Location = new Point(27, 70);
            cuiTabControl1.Name = "cuiTabControl1";
            cuiTabControl1.Rounding = 8;
            cuiTabControl1.SelectedIndex = 0;
            cuiTabControl1.SelectedTabBackColor = Color.FromArgb(50, 81, 88);
            cuiTabControl1.SelectedTabTextBackColor = Color.White;
            cuiTabControl1.ShowAddTabButton = false;
            cuiTabControl1.Size = new Size(674, 352);
            cuiTabControl1.SizeMode = TabSizeMode.Fixed;
            cuiTabControl1.TabIndex = 30;
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
            // cuiPanel2
            // 
            cuiPanel2.BackColor = Color.Transparent;
            cuiPanel2.BackgroundImageLayout = ImageLayout.None;
            cuiPanel2.Controls.Add(label2);
            cuiPanel2.Controls.Add(genderCombo);
            cuiPanel2.Controls.Add(birthDate);
            cuiPanel2.Controls.Add(addressTxt);
            cuiPanel2.Controls.Add(emailAddTxt);
            cuiPanel2.Controls.Add(lastNameTxt);
            cuiPanel2.Controls.Add(phoneNumTxt);
            cuiPanel2.Controls.Add(firstNameTxt);
            cuiPanel2.Controls.Add(cancelBtn);
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
            // genderCombo
            // 
            genderCombo.BackColor = Color.Transparent;
            genderCombo.BackgroundColor = Color.White;
            genderCombo.ButtonCursor = Cursors.Arrow;
            genderCombo.ButtonHoverBackground = Color.FromArgb(22, 36, 39);
            genderCombo.ButtonHoverOutline = Color.FromArgb(22, 36, 39);
            genderCombo.ButtonNormalBackground = Color.FromArgb(50, 81, 88);
            genderCombo.ButtonNormalOutline = Color.FromArgb(50, 81, 88);
            genderCombo.ButtonPressedBackground = Color.FromArgb(22, 36, 39);
            genderCombo.ButtonPressedOutline = Color.FromArgb(22, 36, 39);
            genderCombo.DropDownBackgroundColor = Color.FromArgb(50, 81, 88);
            genderCombo.DropDownOutlineColor = Color.FromArgb(50, 81, 88);
            genderCombo.ExpandArrowColor = Color.FromArgb(50, 81, 88);
            genderCombo.ForeColor = Color.Gray;
            genderCombo.Items = new string[]
    {
    "Male",
    "Female",
    "Others"
    };
            genderCombo.Location = new Point(420, 139);
            genderCombo.Margin = new Padding(4, 3, 4, 3);
            genderCombo.Name = "genderCombo";
            genderCombo.NoSelectionDropdownText = "Empty";
            genderCombo.NoSelectionText = "Select gender";
            genderCombo.OutlineColor = Color.FromArgb(50, 81, 88);
            genderCombo.OutlineThickness = 1F;
            genderCombo.Rounding = 8;
            genderCombo.Size = new Size(203, 38);
            genderCombo.TabIndex = 36;
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
            birthDate.Location = new Point(420, 93);
            birthDate.Margin = new Padding(4, 3, 4, 3);
            birthDate.Name = "birthDate";
            birthDate.NormalBackground = Color.FromArgb(32, 128, 128, 128);
            birthDate.NormalOutline = Color.FromArgb(150, 128, 128, 128);
            birthDate.OutlineThickness = 1.5F;
            birthDate.PressedBackground = Color.FromArgb(80, 128, 128, 128);
            birthDate.PressedOutline = Color.FromArgb(210, 128, 128, 128);
            birthDate.Rounding = 8;
            birthDate.ShowIcon = true;
            birthDate.Size = new Size(203, 38);
            birthDate.TabIndex = 33;
            birthDate.Theme = CuoreUI.Controls.Forms.DatePicker.Themes.Light;
            birthDate.Value = new DateTime(2025, 6, 6, 0, 0, 0, 0);
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
            addressTxt.Location = new Point(338, 47);
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
            addressTxt.TabIndex = 5;
            addressTxt.TextOffset = new Size(0, 0);
            addressTxt.UnderlinedStyle = false;
            // 
            // emailAddTxt
            // 
            emailAddTxt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
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
            emailAddTxt.Location = new Point(34, 139);
            emailAddTxt.Margin = new Padding(4);
            emailAddTxt.Multiline = false;
            emailAddTxt.Name = "emailAddTxt";
            emailAddTxt.NormalImageTint = Color.White;
            emailAddTxt.Padding = new Padding(13, 13, 13, 0);
            emailAddTxt.PasswordChar = false;
            emailAddTxt.PlaceholderColor = SystemColors.ScrollBar;
            emailAddTxt.PlaceholderText = "Email Address ";
            emailAddTxt.Rounding = new Padding(10);
            emailAddTxt.Size = new Size(285, 38);
            emailAddTxt.TabIndex = 3;
            emailAddTxt.TextOffset = new Size(0, 0);
            emailAddTxt.UnderlinedStyle = false;
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
            lastNameTxt.Location = new Point(34, 93);
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
            lastNameTxt.TabIndex = 2;
            lastNameTxt.TextOffset = new Size(0, 0);
            lastNameTxt.UnderlinedStyle = false;
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
            phoneNumTxt.Location = new Point(34, 185);
            phoneNumTxt.Margin = new Padding(4);
            phoneNumTxt.Multiline = false;
            phoneNumTxt.Name = "phoneNumTxt";
            phoneNumTxt.NormalImageTint = Color.White;
            phoneNumTxt.Padding = new Padding(13, 13, 13, 0);
            phoneNumTxt.PasswordChar = false;
            phoneNumTxt.PlaceholderColor = SystemColors.ScrollBar;
            phoneNumTxt.PlaceholderText = "Phone Number";
            phoneNumTxt.Rounding = new Padding(10);
            phoneNumTxt.Size = new Size(285, 38);
            phoneNumTxt.TabIndex = 4;
            phoneNumTxt.TextOffset = new Size(0, 0);
            phoneNumTxt.UnderlinedStyle = false;
            phoneNumTxt.KeyPress += phoneNumTxt_KeyPress;
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
            firstNameTxt.Location = new Point(34, 47);
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
            firstNameTxt.TabIndex = 1;
            firstNameTxt.TextOffset = new Size(0, 0);
            firstNameTxt.UnderlinedStyle = false;
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
            cancelBtn.Location = new Point(552, 233);
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
            cancelBtn.Click += cancelBtn_Click;
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
            cuiPanel1.Controls.Add(generateQrBtn);
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
            // generateQrBtn
            // 
            generateQrBtn.Checked = false;
            generateQrBtn.CheckedBackground = Color.FromArgb(50, 81, 88);
            generateQrBtn.CheckedForeColor = Color.White;
            generateQrBtn.CheckedImageTint = Color.White;
            generateQrBtn.CheckedOutline = Color.FromArgb(50, 81, 88);
            generateQrBtn.Content = "Generate QR";
            generateQrBtn.Font = new Font("Microsoft Sans Serif", 6F, FontStyle.Regular, GraphicsUnit.Point, 0);
            generateQrBtn.ForeColor = Color.Black;
            generateQrBtn.Group = 0;
            generateQrBtn.HoverBackground = Color.FromArgb(50, 81, 88);
            generateQrBtn.HoveredImageTint = Color.White;
            generateQrBtn.HoverForeColor = Color.White;
            generateQrBtn.HoverOutline = Color.FromArgb(50, 81, 88);
            generateQrBtn.Image = null;
            generateQrBtn.ImageAutoCenter = true;
            generateQrBtn.ImageExpand = new Point(0, 0);
            generateQrBtn.ImageOffset = new Point(0, 0);
            generateQrBtn.Location = new Point(257, 95);
            generateQrBtn.Name = "generateQrBtn";
            generateQrBtn.NormalBackground = Color.White;
            generateQrBtn.NormalForeColor = Color.Black;
            generateQrBtn.NormalImageTint = Color.White;
            generateQrBtn.NormalOutline = Color.FromArgb(50, 81, 88);
            generateQrBtn.OutlineThickness = 1F;
            generateQrBtn.PressedBackground = Color.FromArgb(22, 36, 39);
            generateQrBtn.PressedForeColor = Color.White;
            generateQrBtn.PressedImageTint = Color.White;
            generateQrBtn.PressedOutline = Color.FromArgb(22, 36, 39);
            generateQrBtn.Rounding = new Padding(8);
            generateQrBtn.Size = new Size(80, 28);
            generateQrBtn.TabIndex = 49;
            generateQrBtn.TextAlignment = StringAlignment.Center;
            generateQrBtn.TextOffset = new Point(0, 0);
            generateQrBtn.Click += generateQrBtn_Click;
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
            doneBtn.Location = new Point(552, 233);
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
            doneBtn.Click += doneBtn_Click;
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
            openCameraBtn.Click += openCameraBtn_Click;
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
            captureBtn.Click += captureBtn_Click;
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
            statusCombo.Location = new Point(502, 161);
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
            hourlyRateTxt.TabIndex = 9;
            hourlyRateTxt.TextOffset = new Size(0, 0);
            hourlyRateTxt.UnderlinedStyle = false;
            hourlyRateTxt.KeyPress += hourlyRateTxt_KeyPress;
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
            availabilityTxt.TabIndex = 8;
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
            yearsOfExperienceTxt.TabIndex = 7;
            yearsOfExperienceTxt.TextOffset = new Size(0, 0);
            yearsOfExperienceTxt.UnderlinedStyle = false;
            yearsOfExperienceTxt.KeyPress += yearsOfExperienceTxt_KeyPress;
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
            specializationTxt.TabIndex = 6;
            specializationTxt.TextOffset = new Size(0, 0);
            specializationTxt.UnderlinedStyle = false;
            // 
            // formLabel
            // 
            formLabel.AutoSize = true;
            formLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            formLabel.ForeColor = Color.FromArgb(50, 81, 88);
            formLabel.Location = new Point(27, 24);
            formLabel.Name = "formLabel";
            formLabel.Size = new Size(239, 30);
            formLabel.TabIndex = 29;
            formLabel.Text = "Register New Trainers";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Inter", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Silver;
            label2.Location = new Point(338, 102);
            label2.Name = "label2";
            label2.Size = new Size(75, 22);
            label2.TabIndex = 37;
            label2.Text = "Birthdate";
            // 
            // TrainerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(728, 446);
            Controls.Add(cuiTabControl1);
            Controls.Add(formLabel);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TrainerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TrainerForm";
            FormClosing += TrainerForm_FormClosing;
            cuiTabControl1.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            cuiPanel2.ResumeLayout(false);
            cuiPanel2.PerformLayout();
            tabPage4.ResumeLayout(false);
            cuiPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CuoreUI.Controls.cuiTabControl cuiTabControl1;
        private TabPage tabPage3;
        private CuoreUI.Controls.cuiPanel cuiPanel2;
        private CuoreUI.Controls.cuiButton cancelBtn;
        private TabPage tabPage4;
        private CuoreUI.Controls.cuiPanel cuiPanel1;
        private CuoreUI.Controls.cuiButton doneBtn;
        private PictureBox pictureBox1;
        private CuoreUI.Controls.cuiButtonGroup openCameraBtn;
        private CuoreUI.Controls.cuiButtonGroup captureBtn;
        private CuoreUI.Controls.cuiComboBox statusCombo;
        private CuoreUI.Controls.cuiTextBox hourlyRateTxt;
        private CuoreUI.Controls.cuiTextBox availabilityTxt;
        private CuoreUI.Controls.cuiTextBox yearsOfExperienceTxt;
        private CuoreUI.Controls.cuiTextBox specializationTxt;
        private Label formLabel;
        private CuoreUI.Controls.cuiCalendarDatePicker birthDate;
        private CuoreUI.Controls.cuiTextBox addressTxt;
        private CuoreUI.Controls.cuiTextBox emailAddTxt;
        private CuoreUI.Controls.cuiTextBox lastNameTxt;
        private CuoreUI.Controls.cuiTextBox phoneNumTxt;
        private CuoreUI.Controls.cuiTextBox firstNameTxt;
        private CuoreUI.Controls.cuiComboBox genderCombo;
        private CuoreUI.Controls.cuiButtonGroup generateQrBtn;
        private Label label2;
    }
}