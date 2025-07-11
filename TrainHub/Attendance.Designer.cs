namespace TrainHub
{
    partial class Attendance
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Attendance));
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            trainerAttendanceBindingSource = new BindingSource(components);
            memberAttendanceBindingSource = new BindingSource(components);
            cuiTabControl1 = new CuoreUI.Controls.cuiTabControl();
            tabPage1 = new TabPage();
            tableLayoutPanel8 = new TableLayoutPanel();
            panel5 = new Panel();
            label8 = new Label();
            memberAttendanceLabel = new Label();
            cuiPanel11 = new CuoreUI.Controls.cuiPanel();
            memberAttendanceDataGridView = new Zuby.ADGV.AdvancedDataGridView();
            FirstName = new DataGridViewTextBoxColumn();
            LastName = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            PhoneNumber = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            MembershipType = new DataGridViewTextBoxColumn();
            AttendanceDate = new DataGridViewTextBoxColumn();
            StartDate = new DataGridViewTextBoxColumn();
            EndDate = new DataGridViewTextBoxColumn();
            cuiPanel12 = new CuoreUI.Controls.cuiPanel();
            cuiPanel13 = new CuoreUI.Controls.cuiPanel();
            scanQrBtn = new CuoreUI.Controls.cuiButtonGroup();
            cuiPictureBox3 = new CuoreUI.Controls.cuiPictureBox();
            searchBarMemberAttendance = new CuoreUI.Controls.cuiTextBox();
            tabPage2 = new TabPage();
            tableLayoutPanel7 = new TableLayoutPanel();
            panel3 = new Panel();
            label7 = new Label();
            trainerAttendanceLabel = new Label();
            cuiPanel14 = new CuoreUI.Controls.cuiPanel();
            trainerAttendanceDataGridView = new Zuby.ADGV.AdvancedDataGridView();
            TrainerId = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            Availability = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            cuiPanel8 = new CuoreUI.Controls.cuiPanel();
            cuiPanel10 = new CuoreUI.Controls.cuiPanel();
            cuiPictureBox2 = new CuoreUI.Controls.cuiPictureBox();
            searchBarTrainerAttendance = new CuoreUI.Controls.cuiTextBox();
            ((System.ComponentModel.ISupportInitialize)trainerAttendanceBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)memberAttendanceBindingSource).BeginInit();
            cuiTabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            panel5.SuspendLayout();
            cuiPanel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)memberAttendanceDataGridView).BeginInit();
            cuiPanel12.SuspendLayout();
            cuiPanel13.SuspendLayout();
            tabPage2.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            panel3.SuspendLayout();
            cuiPanel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trainerAttendanceDataGridView).BeginInit();
            cuiPanel8.SuspendLayout();
            cuiPanel10.SuspendLayout();
            SuspendLayout();
            // 
            // trainerAttendanceBindingSource
            // 
            trainerAttendanceBindingSource.DataSource = typeof(Models.TrainerAttendances);
            // 
            // memberAttendanceBindingSource
            // 
            memberAttendanceBindingSource.DataSource = typeof(Models.MemberAttendances);
            // 
            // cuiTabControl1
            // 
            cuiTabControl1.AddButtonBackgroundColor = Color.FromArgb(128, 0, 0, 0);
            cuiTabControl1.AddButtonColor = Color.White;
            cuiTabControl1.AllowNoTabs = false;
            cuiTabControl1.Appearance = TabAppearance.Buttons;
            cuiTabControl1.BackgroundColor = Color.Empty;
            cuiTabControl1.Controls.Add(tabPage1);
            cuiTabControl1.Controls.Add(tabPage2);
            cuiTabControl1.DeletionColor = Color.White;
            cuiTabControl1.DeletionTabBackgroundColor = Color.Crimson;
            cuiTabControl1.Dock = DockStyle.Fill;
            cuiTabControl1.DrawMode = TabDrawMode.OwnerDrawFixed;
            cuiTabControl1.HoverCursor = Cursors.Hand;
            cuiTabControl1.HoveredTabBackColor = Color.FromArgb(64, 128, 128, 128);
            cuiTabControl1.HoveredTabTextBackColor = Color.FromArgb(64, 64, 64);
            cuiTabControl1.ItemSize = new Size(126, 42);
            cuiTabControl1.Location = new Point(20, 20);
            cuiTabControl1.Name = "cuiTabControl1";
            cuiTabControl1.Rounding = 8;
            cuiTabControl1.SelectedIndex = 0;
            cuiTabControl1.SelectedTabBackColor = Color.FromArgb(50, 81, 88);
            cuiTabControl1.SelectedTabTextBackColor = Color.White;
            cuiTabControl1.ShowAddTabButton = false;
            cuiTabControl1.Size = new Size(745, 392);
            cuiTabControl1.SizeMode = TabSizeMode.Fixed;
            cuiTabControl1.TabIndex = 13;
            cuiTabControl1.tabNamingConvention = "tabPage";
            cuiTabControl1.UnselectedTabBackColor = Color.FromArgb(32, 128, 128, 128);
            cuiTabControl1.UnselectedTabTextBackColor = Color.Gray;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(tableLayoutPanel8);
            tabPage1.Location = new Point(4, 46);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(737, 342);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Member";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.BackColor = Color.White;
            tableLayoutPanel8.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel8.ColumnCount = 1;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel8.Controls.Add(panel5, 0, 0);
            tableLayoutPanel8.Controls.Add(cuiPanel11, 0, 1);
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(3, 3);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 2;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel8.Size = new Size(731, 336);
            tableLayoutPanel8.TabIndex = 10;
            // 
            // panel5
            // 
            panel5.Controls.Add(label8);
            panel5.Controls.Add(memberAttendanceLabel);
            panel5.Dock = DockStyle.Left;
            panel5.Location = new Point(4, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(217, 60);
            panel5.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold);
            label8.ForeColor = Color.FromArgb(51, 81, 88);
            label8.ImeMode = ImeMode.NoControl;
            label8.Location = new Point(13, 11);
            label8.Name = "label8";
            label8.Size = new Size(199, 24);
            label8.TabIndex = 24;
            label8.Text = "Member Attendance";
            // 
            // memberAttendanceLabel
            // 
            memberAttendanceLabel.AutoSize = true;
            memberAttendanceLabel.BackColor = Color.Transparent;
            memberAttendanceLabel.ForeColor = Color.Gray;
            memberAttendanceLabel.ImeMode = ImeMode.NoControl;
            memberAttendanceLabel.Location = new Point(14, 41);
            memberAttendanceLabel.Name = "memberAttendanceLabel";
            memberAttendanceLabel.Size = new Size(65, 15);
            memberAttendanceLabel.TabIndex = 25;
            memberAttendanceLabel.Text = "17/06/2025";
            // 
            // cuiPanel11
            // 
            cuiPanel11.BackColor = Color.Transparent;
            cuiPanel11.Controls.Add(memberAttendanceDataGridView);
            cuiPanel11.Controls.Add(cuiPanel12);
            cuiPanel11.Dock = DockStyle.Fill;
            cuiPanel11.Location = new Point(4, 71);
            cuiPanel11.Name = "cuiPanel11";
            cuiPanel11.OutlineThickness = 1F;
            cuiPanel11.PanelColor = Color.Transparent;
            cuiPanel11.PanelOutlineColor = Color.Transparent;
            cuiPanel11.Rounding = new Padding(8);
            cuiPanel11.Size = new Size(723, 261);
            cuiPanel11.TabIndex = 8;
            // 
            // memberAttendanceDataGridView
            // 
            memberAttendanceDataGridView.AllowUserToAddRows = false;
            memberAttendanceDataGridView.AllowUserToDeleteRows = false;
            memberAttendanceDataGridView.AllowUserToResizeRows = false;
            memberAttendanceDataGridView.BackgroundColor = Color.White;
            memberAttendanceDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(50, 81, 88);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            memberAttendanceDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            memberAttendanceDataGridView.ColumnHeadersHeight = 40;
            memberAttendanceDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            memberAttendanceDataGridView.Columns.AddRange(new DataGridViewColumn[] { FirstName, LastName, Email, PhoneNumber, Status, MembershipType, AttendanceDate, StartDate, EndDate });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(50, 81, 88);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            memberAttendanceDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            memberAttendanceDataGridView.Dock = DockStyle.Fill;
            memberAttendanceDataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            memberAttendanceDataGridView.FilterAndSortEnabled = true;
            memberAttendanceDataGridView.FilterStringChangedInvokeBeforeDatasourceUpdate = false;
            memberAttendanceDataGridView.GridColor = Color.DimGray;
            memberAttendanceDataGridView.Location = new Point(0, 47);
            memberAttendanceDataGridView.MaxFilterButtonImageHeight = 23;
            memberAttendanceDataGridView.Name = "memberAttendanceDataGridView";
            memberAttendanceDataGridView.ReadOnly = true;
            memberAttendanceDataGridView.RightToLeft = RightToLeft.No;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.ButtonFace;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(50, 81, 88);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            memberAttendanceDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            memberAttendanceDataGridView.RowHeadersVisible = false;
            memberAttendanceDataGridView.RowHeadersWidth = 120;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.Padding = new Padding(0, 5, 0, 5);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(50, 81, 88);
            memberAttendanceDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            memberAttendanceDataGridView.RowTemplate.Height = 40;
            memberAttendanceDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            memberAttendanceDataGridView.Size = new Size(723, 214);
            memberAttendanceDataGridView.SortStringChangedInvokeBeforeDatasourceUpdate = false;
            memberAttendanceDataGridView.TabIndex = 17;
            // 
            // FirstName
            // 
            FirstName.DataPropertyName = "FirstName";
            FirstName.HeaderText = "FirstName";
            FirstName.MinimumWidth = 24;
            FirstName.Name = "FirstName";
            FirstName.ReadOnly = true;
            FirstName.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // LastName
            // 
            LastName.DataPropertyName = "LastName";
            LastName.HeaderText = "LastName";
            LastName.MinimumWidth = 24;
            LastName.Name = "LastName";
            LastName.ReadOnly = true;
            LastName.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // Email
            // 
            Email.DataPropertyName = "Email";
            Email.HeaderText = "Email";
            Email.MinimumWidth = 24;
            Email.Name = "Email";
            Email.ReadOnly = true;
            Email.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // PhoneNumber
            // 
            PhoneNumber.DataPropertyName = "PhoneNumber";
            PhoneNumber.HeaderText = "PhoneNumber";
            PhoneNumber.MinimumWidth = 24;
            PhoneNumber.Name = "PhoneNumber";
            PhoneNumber.ReadOnly = true;
            PhoneNumber.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // Status
            // 
            Status.DataPropertyName = "Status";
            Status.HeaderText = "Status";
            Status.MinimumWidth = 24;
            Status.Name = "Status";
            Status.ReadOnly = true;
            Status.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // MembershipType
            // 
            MembershipType.DataPropertyName = "MembershipType";
            MembershipType.HeaderText = "MembershipType";
            MembershipType.MinimumWidth = 24;
            MembershipType.Name = "MembershipType";
            MembershipType.ReadOnly = true;
            MembershipType.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // AttendanceDate
            // 
            AttendanceDate.DataPropertyName = "AttendanceDate";
            AttendanceDate.HeaderText = "AttendanceDate";
            AttendanceDate.MinimumWidth = 24;
            AttendanceDate.Name = "AttendanceDate";
            AttendanceDate.ReadOnly = true;
            AttendanceDate.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // StartDate
            // 
            StartDate.DataPropertyName = "StartDate";
            StartDate.HeaderText = "StartDate";
            StartDate.MinimumWidth = 24;
            StartDate.Name = "StartDate";
            StartDate.ReadOnly = true;
            StartDate.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // EndDate
            // 
            EndDate.DataPropertyName = "EndDate";
            EndDate.HeaderText = "EndDate";
            EndDate.MinimumWidth = 24;
            EndDate.Name = "EndDate";
            EndDate.ReadOnly = true;
            EndDate.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // cuiPanel12
            // 
            cuiPanel12.Controls.Add(cuiPanel13);
            cuiPanel12.Dock = DockStyle.Top;
            cuiPanel12.Location = new Point(0, 0);
            cuiPanel12.Margin = new Padding(3, 2, 3, 2);
            cuiPanel12.Name = "cuiPanel12";
            cuiPanel12.OutlineThickness = 1F;
            cuiPanel12.Padding = new Padding(0, 5, 5, 5);
            cuiPanel12.PanelColor = Color.FromArgb(248, 250, 252);
            cuiPanel12.PanelOutlineColor = Color.Black;
            cuiPanel12.Rounding = new Padding(8, 8, 0, 0);
            cuiPanel12.Size = new Size(723, 47);
            cuiPanel12.TabIndex = 16;
            // 
            // cuiPanel13
            // 
            cuiPanel13.Controls.Add(scanQrBtn);
            cuiPanel13.Controls.Add(cuiPictureBox3);
            cuiPanel13.Controls.Add(searchBarMemberAttendance);
            cuiPanel13.Dock = DockStyle.Right;
            cuiPanel13.Location = new Point(399, 5);
            cuiPanel13.Margin = new Padding(3, 2, 3, 2);
            cuiPanel13.Name = "cuiPanel13";
            cuiPanel13.OutlineThickness = 0F;
            cuiPanel13.PanelColor = Color.FromArgb(248, 250, 252);
            cuiPanel13.PanelOutlineColor = Color.FromArgb(248, 250, 252);
            cuiPanel13.Rounding = new Padding(8, 8, 0, 0);
            cuiPanel13.Size = new Size(319, 37);
            cuiPanel13.TabIndex = 34;
            // 
            // scanQrBtn
            // 
            scanQrBtn.Anchor = AnchorStyles.None;
            scanQrBtn.AutoSize = true;
            scanQrBtn.BackColor = Color.Transparent;
            scanQrBtn.Checked = false;
            scanQrBtn.CheckedBackground = Color.White;
            scanQrBtn.CheckedForeColor = Color.Black;
            scanQrBtn.CheckedImageTint = Color.White;
            scanQrBtn.CheckedOutline = Color.Transparent;
            scanQrBtn.Content = "Scan QR";
            scanQrBtn.Font = new Font("Microsoft Sans Serif", 9F);
            scanQrBtn.ForeColor = Color.White;
            scanQrBtn.Group = 0;
            scanQrBtn.HoverBackground = Color.FromArgb(22, 36, 39);
            scanQrBtn.HoveredImageTint = Color.Transparent;
            scanQrBtn.HoverForeColor = Color.White;
            scanQrBtn.HoverOutline = Color.FromArgb(22, 36, 39);
            scanQrBtn.Image = null;
            scanQrBtn.ImageAutoCenter = true;
            scanQrBtn.ImageExpand = new Point(0, 0);
            scanQrBtn.ImageOffset = new Point(0, 0);
            scanQrBtn.Location = new Point(3, 3);
            scanQrBtn.Name = "scanQrBtn";
            scanQrBtn.NormalBackground = Color.FromArgb(50, 81, 88);
            scanQrBtn.NormalForeColor = Color.White;
            scanQrBtn.NormalImageTint = Color.Black;
            scanQrBtn.NormalOutline = Color.FromArgb(50, 81, 88);
            scanQrBtn.OutlineThickness = 1F;
            scanQrBtn.PressedBackground = Color.FromArgb(22, 36, 39);
            scanQrBtn.PressedForeColor = Color.White;
            scanQrBtn.PressedImageTint = Color.White;
            scanQrBtn.PressedOutline = Color.FromArgb(22, 36, 39);
            scanQrBtn.Rounding = new Padding(10);
            scanQrBtn.Size = new Size(74, 30);
            scanQrBtn.TabIndex = 26;
            scanQrBtn.TextAlignment = StringAlignment.Center;
            scanQrBtn.TextOffset = new Point(0, 0);
            scanQrBtn.Click += scanQrBtn_Click;
            // 
            // cuiPictureBox3
            // 
            cuiPictureBox3.BackColor = Color.White;
            cuiPictureBox3.BackgroundImage = (Image)resources.GetObject("cuiPictureBox3.BackgroundImage");
            cuiPictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            cuiPictureBox3.Content = null;
            cuiPictureBox3.ImageTint = Color.White;
            cuiPictureBox3.Location = new Point(102, 8);
            cuiPictureBox3.Margin = new Padding(4, 3, 4, 3);
            cuiPictureBox3.Name = "cuiPictureBox3";
            cuiPictureBox3.OutlineThickness = 1F;
            cuiPictureBox3.PanelOutlineColor = Color.Empty;
            cuiPictureBox3.Rotation = 0;
            cuiPictureBox3.Rounding = new Padding(8);
            cuiPictureBox3.Size = new Size(27, 21);
            cuiPictureBox3.TabIndex = 16;
            // 
            // searchBarMemberAttendance
            // 
            searchBarMemberAttendance.AutoSize = true;
            searchBarMemberAttendance.BackColor = Color.Transparent;
            searchBarMemberAttendance.BackgroundColor = Color.White;
            searchBarMemberAttendance.BorderColor = Color.FromArgb(50, 81, 88);
            searchBarMemberAttendance.Content = "";
            searchBarMemberAttendance.FocusBackgroundColor = Color.White;
            searchBarMemberAttendance.FocusBorderColor = Color.FromArgb(50, 81, 88);
            searchBarMemberAttendance.FocusImageTint = Color.White;
            searchBarMemberAttendance.Font = new Font("Microsoft Sans Serif", 9F);
            searchBarMemberAttendance.ForeColor = Color.Black;
            searchBarMemberAttendance.Image = null;
            searchBarMemberAttendance.ImageExpand = new Point(10, 10);
            searchBarMemberAttendance.ImageOffset = new Point(250, 0);
            searchBarMemberAttendance.Location = new Point(90, 1);
            searchBarMemberAttendance.Margin = new Padding(0);
            searchBarMemberAttendance.Multiline = false;
            searchBarMemberAttendance.Name = "searchBarMemberAttendance";
            searchBarMemberAttendance.NormalImageTint = Color.White;
            searchBarMemberAttendance.Padding = new Padding(44, 10, 44, 0);
            searchBarMemberAttendance.PasswordChar = false;
            searchBarMemberAttendance.PlaceholderColor = Color.DimGray;
            searchBarMemberAttendance.PlaceholderText = "Search...";
            searchBarMemberAttendance.Rounding = new Padding(10);
            searchBarMemberAttendance.Size = new Size(223, 35);
            searchBarMemberAttendance.TabIndex = 15;
            searchBarMemberAttendance.TabStop = false;
            searchBarMemberAttendance.TextOffset = new Size(30, 0);
            searchBarMemberAttendance.UnderlinedStyle = false;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(tableLayoutPanel7);
            tabPage2.Location = new Point(4, 46);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(737, 342);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Trainer";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.BackColor = Color.White;
            tableLayoutPanel7.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel7.ColumnCount = 1;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.Controls.Add(panel3, 0, 0);
            tableLayoutPanel7.Controls.Add(cuiPanel14, 0, 1);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(3, 3);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 2;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel7.Size = new Size(731, 336);
            tableLayoutPanel7.TabIndex = 11;
            // 
            // panel3
            // 
            panel3.Controls.Add(label7);
            panel3.Controls.Add(trainerAttendanceLabel);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(4, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(204, 60);
            panel3.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(51, 81, 88);
            label7.ImeMode = ImeMode.NoControl;
            label7.Location = new Point(13, 12);
            label7.Name = "label7";
            label7.Size = new Size(189, 24);
            label7.TabIndex = 24;
            label7.Text = "Trainer Attendance";
            // 
            // trainerAttendanceLabel
            // 
            trainerAttendanceLabel.AutoSize = true;
            trainerAttendanceLabel.BackColor = Color.Transparent;
            trainerAttendanceLabel.ForeColor = Color.Gray;
            trainerAttendanceLabel.ImeMode = ImeMode.NoControl;
            trainerAttendanceLabel.Location = new Point(14, 41);
            trainerAttendanceLabel.Name = "trainerAttendanceLabel";
            trainerAttendanceLabel.Size = new Size(65, 15);
            trainerAttendanceLabel.TabIndex = 25;
            trainerAttendanceLabel.Text = "17/06/2025";
            // 
            // cuiPanel14
            // 
            cuiPanel14.Controls.Add(trainerAttendanceDataGridView);
            cuiPanel14.Controls.Add(cuiPanel8);
            cuiPanel14.Dock = DockStyle.Fill;
            cuiPanel14.Location = new Point(4, 71);
            cuiPanel14.Name = "cuiPanel14";
            cuiPanel14.OutlineThickness = 1F;
            cuiPanel14.PanelColor = Color.White;
            cuiPanel14.PanelOutlineColor = Color.White;
            cuiPanel14.Rounding = new Padding(8);
            cuiPanel14.Size = new Size(723, 261);
            cuiPanel14.TabIndex = 11;
            // 
            // trainerAttendanceDataGridView
            // 
            trainerAttendanceDataGridView.AllowUserToAddRows = false;
            trainerAttendanceDataGridView.AllowUserToDeleteRows = false;
            trainerAttendanceDataGridView.AllowUserToResizeRows = false;
            trainerAttendanceDataGridView.BackgroundColor = Color.White;
            trainerAttendanceDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(50, 81, 88);
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            trainerAttendanceDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            trainerAttendanceDataGridView.ColumnHeadersHeight = 40;
            trainerAttendanceDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            trainerAttendanceDataGridView.Columns.AddRange(new DataGridViewColumn[] { TrainerId, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, Availability, dataGridViewTextBoxColumn9 });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(50, 81, 88);
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            trainerAttendanceDataGridView.DefaultCellStyle = dataGridViewCellStyle6;
            trainerAttendanceDataGridView.Dock = DockStyle.Fill;
            trainerAttendanceDataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            trainerAttendanceDataGridView.FilterAndSortEnabled = true;
            trainerAttendanceDataGridView.FilterStringChangedInvokeBeforeDatasourceUpdate = false;
            trainerAttendanceDataGridView.GridColor = Color.DimGray;
            trainerAttendanceDataGridView.Location = new Point(0, 47);
            trainerAttendanceDataGridView.MaxFilterButtonImageHeight = 23;
            trainerAttendanceDataGridView.Name = "trainerAttendanceDataGridView";
            trainerAttendanceDataGridView.ReadOnly = true;
            trainerAttendanceDataGridView.RightToLeft = RightToLeft.No;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.ButtonFace;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(50, 81, 88);
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            trainerAttendanceDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            trainerAttendanceDataGridView.RowHeadersVisible = false;
            trainerAttendanceDataGridView.RowHeadersWidth = 120;
            dataGridViewCellStyle8.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = Color.Black;
            dataGridViewCellStyle8.Padding = new Padding(0, 5, 0, 5);
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(50, 81, 88);
            trainerAttendanceDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle8;
            trainerAttendanceDataGridView.RowTemplate.Height = 40;
            trainerAttendanceDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            trainerAttendanceDataGridView.Size = new Size(723, 214);
            trainerAttendanceDataGridView.SortStringChangedInvokeBeforeDatasourceUpdate = false;
            trainerAttendanceDataGridView.TabIndex = 17;
            // 
            // TrainerId
            // 
            TrainerId.DataPropertyName = "TrainerId";
            TrainerId.HeaderText = "TrainerId";
            TrainerId.MinimumWidth = 24;
            TrainerId.Name = "TrainerId";
            TrainerId.ReadOnly = true;
            TrainerId.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "FirstName";
            dataGridViewTextBoxColumn3.HeaderText = "FirstName";
            dataGridViewTextBoxColumn3.MinimumWidth = 24;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "LastName";
            dataGridViewTextBoxColumn4.HeaderText = "LastName";
            dataGridViewTextBoxColumn4.MinimumWidth = 24;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "Email";
            dataGridViewTextBoxColumn5.HeaderText = "Email";
            dataGridViewTextBoxColumn5.MinimumWidth = 24;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            dataGridViewTextBoxColumn5.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.DataPropertyName = "PhoneNumber";
            dataGridViewTextBoxColumn6.HeaderText = "PhoneNumber";
            dataGridViewTextBoxColumn6.MinimumWidth = 24;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            dataGridViewTextBoxColumn6.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.DataPropertyName = "Status";
            dataGridViewTextBoxColumn7.HeaderText = "Status";
            dataGridViewTextBoxColumn7.MinimumWidth = 24;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            dataGridViewTextBoxColumn7.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // Availability
            // 
            Availability.DataPropertyName = "Availability";
            Availability.HeaderText = "Availability";
            Availability.MinimumWidth = 24;
            Availability.Name = "Availability";
            Availability.ReadOnly = true;
            Availability.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.DataPropertyName = "AttendanceDate";
            dataGridViewTextBoxColumn9.HeaderText = "AttendanceDate";
            dataGridViewTextBoxColumn9.MinimumWidth = 24;
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            dataGridViewTextBoxColumn9.ReadOnly = true;
            dataGridViewTextBoxColumn9.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // cuiPanel8
            // 
            cuiPanel8.Controls.Add(cuiPanel10);
            cuiPanel8.Dock = DockStyle.Top;
            cuiPanel8.Location = new Point(0, 0);
            cuiPanel8.Margin = new Padding(3, 2, 3, 2);
            cuiPanel8.Name = "cuiPanel8";
            cuiPanel8.OutlineThickness = 1F;
            cuiPanel8.Padding = new Padding(0, 5, 5, 5);
            cuiPanel8.PanelColor = Color.FromArgb(248, 250, 252);
            cuiPanel8.PanelOutlineColor = Color.Black;
            cuiPanel8.Rounding = new Padding(8, 8, 0, 0);
            cuiPanel8.Size = new Size(723, 47);
            cuiPanel8.TabIndex = 16;
            // 
            // cuiPanel10
            // 
            cuiPanel10.Controls.Add(cuiPictureBox2);
            cuiPanel10.Controls.Add(searchBarTrainerAttendance);
            cuiPanel10.Dock = DockStyle.Right;
            cuiPanel10.Location = new Point(399, 5);
            cuiPanel10.Margin = new Padding(3, 2, 3, 2);
            cuiPanel10.Name = "cuiPanel10";
            cuiPanel10.OutlineThickness = 0F;
            cuiPanel10.PanelColor = Color.FromArgb(248, 250, 252);
            cuiPanel10.PanelOutlineColor = Color.FromArgb(248, 250, 252);
            cuiPanel10.Rounding = new Padding(8, 8, 0, 0);
            cuiPanel10.Size = new Size(319, 37);
            cuiPanel10.TabIndex = 34;
            // 
            // cuiPictureBox2
            // 
            cuiPictureBox2.BackColor = Color.White;
            cuiPictureBox2.BackgroundImage = (Image)resources.GetObject("cuiPictureBox2.BackgroundImage");
            cuiPictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            cuiPictureBox2.Content = null;
            cuiPictureBox2.ImageTint = Color.White;
            cuiPictureBox2.Location = new Point(102, 8);
            cuiPictureBox2.Margin = new Padding(4, 3, 4, 3);
            cuiPictureBox2.Name = "cuiPictureBox2";
            cuiPictureBox2.OutlineThickness = 1F;
            cuiPictureBox2.PanelOutlineColor = Color.Empty;
            cuiPictureBox2.Rotation = 0;
            cuiPictureBox2.Rounding = new Padding(8);
            cuiPictureBox2.Size = new Size(27, 21);
            cuiPictureBox2.TabIndex = 16;
            // 
            // searchBarTrainerAttendance
            // 
            searchBarTrainerAttendance.AutoSize = true;
            searchBarTrainerAttendance.BackColor = Color.Transparent;
            searchBarTrainerAttendance.BackgroundColor = Color.White;
            searchBarTrainerAttendance.BorderColor = Color.FromArgb(50, 81, 88);
            searchBarTrainerAttendance.Content = "";
            searchBarTrainerAttendance.FocusBackgroundColor = Color.White;
            searchBarTrainerAttendance.FocusBorderColor = Color.FromArgb(50, 81, 88);
            searchBarTrainerAttendance.FocusImageTint = Color.White;
            searchBarTrainerAttendance.Font = new Font("Microsoft Sans Serif", 9F);
            searchBarTrainerAttendance.ForeColor = Color.Black;
            searchBarTrainerAttendance.Image = null;
            searchBarTrainerAttendance.ImageExpand = new Point(10, 10);
            searchBarTrainerAttendance.ImageOffset = new Point(250, 0);
            searchBarTrainerAttendance.Location = new Point(90, 1);
            searchBarTrainerAttendance.Margin = new Padding(0);
            searchBarTrainerAttendance.Multiline = false;
            searchBarTrainerAttendance.Name = "searchBarTrainerAttendance";
            searchBarTrainerAttendance.NormalImageTint = Color.White;
            searchBarTrainerAttendance.Padding = new Padding(44, 10, 44, 0);
            searchBarTrainerAttendance.PasswordChar = false;
            searchBarTrainerAttendance.PlaceholderColor = Color.DimGray;
            searchBarTrainerAttendance.PlaceholderText = "Search...";
            searchBarTrainerAttendance.Rounding = new Padding(10);
            searchBarTrainerAttendance.Size = new Size(223, 35);
            searchBarTrainerAttendance.TabIndex = 15;
            searchBarTrainerAttendance.TabStop = false;
            searchBarTrainerAttendance.TextOffset = new Size(30, 0);
            searchBarTrainerAttendance.UnderlinedStyle = false;
            // 
            // Attendance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(785, 432);
            Controls.Add(cuiTabControl1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Attendance";
            Padding = new Padding(20);
            Text = "Attendance";
            Load += Attendance_Load;
            ((System.ComponentModel.ISupportInitialize)trainerAttendanceBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)memberAttendanceBindingSource).EndInit();
            cuiTabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tableLayoutPanel8.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            cuiPanel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)memberAttendanceDataGridView).EndInit();
            cuiPanel12.ResumeLayout(false);
            cuiPanel13.ResumeLayout(false);
            cuiPanel13.PerformLayout();
            tabPage2.ResumeLayout(false);
            tableLayoutPanel7.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            cuiPanel14.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)trainerAttendanceDataGridView).EndInit();
            cuiPanel8.ResumeLayout(false);
            cuiPanel10.ResumeLayout(false);
            cuiPanel10.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private BindingSource trainerAttendanceBindingSource;
        private BindingSource memberAttendanceBindingSource;
        private CuoreUI.Controls.cuiTabControl cuiTabControl1;
        private TabPage tabPage1;
        private TableLayoutPanel tableLayoutPanel8;
        private Panel panel5;
        private Label label8;
        private Label memberAttendanceLabel;
        private CuoreUI.Controls.cuiPanel cuiPanel11;
        private Zuby.ADGV.AdvancedDataGridView memberAttendanceDataGridView;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn PhoneNumber;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn MembershipType;
        private DataGridViewTextBoxColumn AttendanceDate;
        private DataGridViewTextBoxColumn StartDate;
        private DataGridViewTextBoxColumn EndDate;
        private CuoreUI.Controls.cuiPanel cuiPanel12;
        private CuoreUI.Controls.cuiPanel cuiPanel13;
        private CuoreUI.Controls.cuiButtonGroup scanQrBtn;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox3;
        private CuoreUI.Controls.cuiTextBox searchBarMemberAttendance;
        private TabPage tabPage2;
        private TableLayoutPanel tableLayoutPanel7;
        private Panel panel3;
        private Label label7;
        private Label trainerAttendanceLabel;
        private CuoreUI.Controls.cuiPanel cuiPanel14;
        private Zuby.ADGV.AdvancedDataGridView trainerAttendanceDataGridView;
        private DataGridViewTextBoxColumn TrainerId;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn Availability;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private CuoreUI.Controls.cuiPanel cuiPanel8;
        private CuoreUI.Controls.cuiPanel cuiPanel10;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox2;
        private CuoreUI.Controls.cuiTextBox searchBarTrainerAttendance;
    }
}