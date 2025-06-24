namespace TrainHub
{
    partial class ShowMembersTablePageForm1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowMembersTablePageForm1));
            cuiPanel1 = new CuoreUI.Controls.cuiPanel();
            advancedDataGridView1 = new Zuby.ADGV.AdvancedDataGridView();
            memberBindingSource = new BindingSource(components);
            cuiPanel2 = new CuoreUI.Controls.cuiPanel();
            cuiPanel7 = new CuoreUI.Controls.cuiPanel();
            deletedMemberCheck = new CuoreUI.Controls.cuiCheckbox();
            cuiPictureBox1 = new CuoreUI.Controls.cuiPictureBox();
            searchBar = new CuoreUI.Controls.cuiTextBox();
            label2 = new Label();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            cuiPanel8 = new CuoreUI.Controls.cuiPanel();
            cuiButtonGroup2 = new CuoreUI.Controls.cuiButtonGroup();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            firstNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lastNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Gender = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            phoneNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateOfBirthDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            startDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            endDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            createdDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            statusDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            IsDeleted = new DataGridViewCheckBoxColumn();
            membershipTypeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            TrainerFullName = new DataGridViewTextBoxColumn();
            View = new DataGridViewImageColumn();
            Edit = new DataGridViewImageColumn();
            Delete = new DataGridViewImageColumn();
            cuiPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)advancedDataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)memberBindingSource).BeginInit();
            cuiPanel2.SuspendLayout();
            cuiPanel7.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            cuiPanel8.SuspendLayout();
            SuspendLayout();
            // 
            // cuiPanel1
            // 
            cuiPanel1.BackColor = Color.Transparent;
            cuiPanel1.Controls.Add(advancedDataGridView1);
            cuiPanel1.Controls.Add(cuiPanel2);
            cuiPanel1.Dock = DockStyle.Fill;
            cuiPanel1.Location = new Point(13, 88);
            cuiPanel1.Margin = new Padding(3, 2, 3, 15);
            cuiPanel1.Name = "cuiPanel1";
            cuiPanel1.OutlineThickness = 1F;
            cuiPanel1.PanelColor = Color.Transparent;
            cuiPanel1.PanelOutlineColor = Color.Transparent;
            cuiPanel1.Rounding = new Padding(8);
            cuiPanel1.Size = new Size(778, 333);
            cuiPanel1.TabIndex = 7;
            // 
            // advancedDataGridView1
            // 
            advancedDataGridView1.AllowUserToAddRows = false;
            advancedDataGridView1.AllowUserToDeleteRows = false;
            advancedDataGridView1.AllowUserToResizeRows = false;
            advancedDataGridView1.AutoGenerateColumns = false;
            advancedDataGridView1.BackgroundColor = Color.White;
            advancedDataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(50, 81, 88);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            advancedDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            advancedDataGridView1.ColumnHeadersHeight = 40;
            advancedDataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            advancedDataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, firstNameDataGridViewTextBoxColumn, lastNameDataGridViewTextBoxColumn, Gender, emailDataGridViewTextBoxColumn, phoneNumberDataGridViewTextBoxColumn, dateOfBirthDataGridViewTextBoxColumn, startDateDataGridViewTextBoxColumn, endDateDataGridViewTextBoxColumn, createdDateDataGridViewTextBoxColumn, statusDataGridViewTextBoxColumn, IsDeleted, membershipTypeDataGridViewTextBoxColumn, TrainerFullName, View, Edit, Delete });
            advancedDataGridView1.DataSource = memberBindingSource;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(50, 81, 88);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            advancedDataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            advancedDataGridView1.Dock = DockStyle.Fill;
            advancedDataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            advancedDataGridView1.FilterAndSortEnabled = true;
            advancedDataGridView1.FilterStringChangedInvokeBeforeDatasourceUpdate = false;
            advancedDataGridView1.GridColor = Color.DimGray;
            advancedDataGridView1.Location = new Point(0, 47);
            advancedDataGridView1.MaxFilterButtonImageHeight = 23;
            advancedDataGridView1.Name = "advancedDataGridView1";
            advancedDataGridView1.ReadOnly = true;
            advancedDataGridView1.RightToLeft = RightToLeft.No;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.ButtonFace;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(50, 81, 88);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            advancedDataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            advancedDataGridView1.RowHeadersVisible = false;
            advancedDataGridView1.RowHeadersWidth = 120;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.Padding = new Padding(0, 5, 0, 5);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(50, 81, 88);
            advancedDataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            advancedDataGridView1.RowTemplate.Height = 40;
            advancedDataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            advancedDataGridView1.Size = new Size(778, 286);
            advancedDataGridView1.SortStringChangedInvokeBeforeDatasourceUpdate = false;
            advancedDataGridView1.TabIndex = 17;
            advancedDataGridView1.CellClick += dataGridView2_CellClick;
            // 
            // memberBindingSource
            // 
            memberBindingSource.AllowNew = true;
            memberBindingSource.DataSource = typeof(Models.Member);
            // 
            // cuiPanel2
            // 
            cuiPanel2.Controls.Add(cuiPanel7);
            cuiPanel2.Dock = DockStyle.Top;
            cuiPanel2.Location = new Point(0, 0);
            cuiPanel2.Margin = new Padding(3, 2, 3, 2);
            cuiPanel2.Name = "cuiPanel2";
            cuiPanel2.OutlineThickness = 1F;
            cuiPanel2.Padding = new Padding(0, 5, 5, 5);
            cuiPanel2.PanelColor = Color.FromArgb(248, 250, 252);
            cuiPanel2.PanelOutlineColor = Color.Black;
            cuiPanel2.Rounding = new Padding(8, 8, 0, 0);
            cuiPanel2.Size = new Size(778, 47);
            cuiPanel2.TabIndex = 16;
            // 
            // cuiPanel7
            // 
            cuiPanel7.Controls.Add(deletedMemberCheck);
            cuiPanel7.Controls.Add(cuiPictureBox1);
            cuiPanel7.Controls.Add(searchBar);
            cuiPanel7.Dock = DockStyle.Right;
            cuiPanel7.Location = new Point(275, 5);
            cuiPanel7.Margin = new Padding(3, 2, 3, 2);
            cuiPanel7.Name = "cuiPanel7";
            cuiPanel7.OutlineThickness = 0F;
            cuiPanel7.PanelColor = Color.FromArgb(248, 250, 252);
            cuiPanel7.PanelOutlineColor = Color.FromArgb(248, 250, 252);
            cuiPanel7.Rounding = new Padding(8, 8, 0, 0);
            cuiPanel7.Size = new Size(498, 37);
            cuiPanel7.TabIndex = 34;
            // 
            // deletedMemberCheck
            // 
            deletedMemberCheck.BackColor = Color.FromArgb(248, 250, 252);
            deletedMemberCheck.Checked = false;
            deletedMemberCheck.CheckedForeground = Color.FromArgb(50, 81, 88);
            deletedMemberCheck.CheckedOutlineColor = Color.FromArgb(50, 81, 88);
            deletedMemberCheck.CheckedSymbolColor = Color.White;
            deletedMemberCheck.Content = "Include deleted members";
            deletedMemberCheck.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deletedMemberCheck.Location = new Point(38, 17);
            deletedMemberCheck.MinimumSize = new Size(16, 16);
            deletedMemberCheck.Name = "deletedMemberCheck";
            deletedMemberCheck.OutlineStyle = true;
            deletedMemberCheck.OutlineThickness = 1F;
            deletedMemberCheck.Rounding = 5;
            deletedMemberCheck.ShowSymbols = true;
            deletedMemberCheck.Size = new Size(149, 16);
            deletedMemberCheck.TabIndex = 17;
            deletedMemberCheck.Text = "Include deleted members";
            deletedMemberCheck.UncheckedForeground = Color.Empty;
            deletedMemberCheck.UncheckedOutlineColor = Color.Gray;
            deletedMemberCheck.UncheckedSymbolColor = Color.Empty;
            deletedMemberCheck.CheckedChanged += deletedMemberCheck_Click;
            // 
            // cuiPictureBox1
            // 
            cuiPictureBox1.BackColor = Color.White;
            cuiPictureBox1.BackgroundImage = (Image)resources.GetObject("cuiPictureBox1.BackgroundImage");
            cuiPictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            cuiPictureBox1.Content = null;
            cuiPictureBox1.ImageTint = Color.White;
            cuiPictureBox1.Location = new Point(201, 8);
            cuiPictureBox1.Margin = new Padding(4, 3, 4, 3);
            cuiPictureBox1.Name = "cuiPictureBox1";
            cuiPictureBox1.OutlineThickness = 1F;
            cuiPictureBox1.PanelOutlineColor = Color.Empty;
            cuiPictureBox1.Rotation = 0;
            cuiPictureBox1.Rounding = new Padding(8);
            cuiPictureBox1.Size = new Size(27, 21);
            cuiPictureBox1.TabIndex = 16;
            // 
            // searchBar
            // 
            searchBar.AutoSize = true;
            searchBar.BackColor = Color.Transparent;
            searchBar.BackgroundColor = Color.White;
            searchBar.BorderColor = Color.FromArgb(50, 81, 88);
            searchBar.Content = "";
            searchBar.FocusBackgroundColor = Color.White;
            searchBar.FocusBorderColor = Color.FromArgb(50, 81, 88);
            searchBar.FocusImageTint = Color.White;
            searchBar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchBar.ForeColor = Color.Black;
            searchBar.Image = null;
            searchBar.ImageExpand = new Point(10, 10);
            searchBar.ImageOffset = new Point(250, 0);
            searchBar.Location = new Point(190, 0);
            searchBar.Margin = new Padding(0);
            searchBar.Multiline = false;
            searchBar.Name = "searchBar";
            searchBar.NormalImageTint = Color.White;
            searchBar.Padding = new Padding(44, 10, 44, 0);
            searchBar.PasswordChar = false;
            searchBar.PlaceholderColor = Color.DimGray;
            searchBar.PlaceholderText = "Search...";
            searchBar.Rounding = new Padding(10);
            searchBar.Size = new Size(296, 35);
            searchBar.TabIndex = 15;
            searchBar.TabStop = false;
            searchBar.TextOffset = new Size(30, 0);
            searchBar.UnderlinedStyle = false;
            searchBar.ContentChanged += searchBar_ContentChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(0, 25);
            label2.Name = "label2";
            label2.Size = new Size(154, 15);
            label2.TabIndex = 25;
            label2.Text = "View and Manage Members";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(51, 81, 88);
            label1.Location = new Point(0, 1);
            label1.Name = "label1";
            label1.Size = new Size(97, 24);
            label1.TabIndex = 24;
            label1.Text = "Members";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(cuiPanel1, 0, 2);
            tableLayoutPanel1.Controls.Add(cuiPanel8, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(10, 0, 10, 0);
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.Size = new Size(804, 436);
            tableLayoutPanel1.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(13, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 37);
            panel1.TabIndex = 9;
            // 
            // cuiPanel8
            // 
            cuiPanel8.BackColor = Color.Transparent;
            cuiPanel8.Controls.Add(cuiButtonGroup2);
            cuiPanel8.Dock = DockStyle.Right;
            cuiPanel8.Location = new Point(642, 45);
            cuiPanel8.Margin = new Padding(3, 2, 3, 2);
            cuiPanel8.Name = "cuiPanel8";
            cuiPanel8.OutlineThickness = 1F;
            cuiPanel8.PanelColor = Color.Transparent;
            cuiPanel8.PanelOutlineColor = Color.Transparent;
            cuiPanel8.Rounding = new Padding(8, 8, 0, 0);
            cuiPanel8.Size = new Size(149, 39);
            cuiPanel8.TabIndex = 34;
            // 
            // cuiButtonGroup2
            // 
            cuiButtonGroup2.AutoSize = true;
            cuiButtonGroup2.BackColor = Color.Transparent;
            cuiButtonGroup2.Checked = false;
            cuiButtonGroup2.CheckedBackground = Color.White;
            cuiButtonGroup2.CheckedForeColor = Color.Black;
            cuiButtonGroup2.CheckedImageTint = Color.White;
            cuiButtonGroup2.CheckedOutline = Color.Transparent;
            cuiButtonGroup2.Content = "+ Add Member";
            cuiButtonGroup2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiButtonGroup2.ForeColor = Color.White;
            cuiButtonGroup2.Group = 0;
            cuiButtonGroup2.HoverBackground = Color.FromArgb(22, 36, 39);
            cuiButtonGroup2.HoveredImageTint = Color.Transparent;
            cuiButtonGroup2.HoverForeColor = Color.White;
            cuiButtonGroup2.HoverOutline = Color.FromArgb(22, 36, 39);
            cuiButtonGroup2.Image = null;
            cuiButtonGroup2.ImageAutoCenter = true;
            cuiButtonGroup2.ImageExpand = new Point(0, 0);
            cuiButtonGroup2.ImageOffset = new Point(0, 0);
            cuiButtonGroup2.Location = new Point(36, 0);
            cuiButtonGroup2.Name = "cuiButtonGroup2";
            cuiButtonGroup2.NormalBackground = Color.FromArgb(50, 81, 88);
            cuiButtonGroup2.NormalForeColor = Color.White;
            cuiButtonGroup2.NormalImageTint = Color.Black;
            cuiButtonGroup2.NormalOutline = Color.FromArgb(50, 81, 88);
            cuiButtonGroup2.OutlineThickness = 1F;
            cuiButtonGroup2.PressedBackground = Color.FromArgb(22, 36, 39);
            cuiButtonGroup2.PressedForeColor = Color.White;
            cuiButtonGroup2.PressedImageTint = Color.White;
            cuiButtonGroup2.PressedOutline = Color.FromArgb(22, 36, 39);
            cuiButtonGroup2.Rounding = new Padding(10);
            cuiButtonGroup2.Size = new Size(113, 43);
            cuiButtonGroup2.TabIndex = 23;
            cuiButtonGroup2.TextAlignment = StringAlignment.Center;
            cuiButtonGroup2.TextOffset = new Point(0, 0);
            cuiButtonGroup2.Click += cuiButtonGroup2_Click;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 24;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            firstNameDataGridViewTextBoxColumn.MinimumWidth = 24;
            firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            firstNameDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            lastNameDataGridViewTextBoxColumn.MinimumWidth = 24;
            lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            lastNameDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // Gender
            // 
            Gender.DataPropertyName = "Gender";
            Gender.HeaderText = "Gender";
            Gender.MinimumWidth = 24;
            Gender.Name = "Gender";
            Gender.ReadOnly = true;
            Gender.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.HeaderText = "Email";
            emailDataGridViewTextBoxColumn.MinimumWidth = 24;
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            emailDataGridViewTextBoxColumn.ReadOnly = true;
            emailDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            phoneNumberDataGridViewTextBoxColumn.MinimumWidth = 24;
            phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            phoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
            phoneNumberDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // dateOfBirthDataGridViewTextBoxColumn
            // 
            dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "DateOfBirth";
            dateOfBirthDataGridViewTextBoxColumn.HeaderText = "DateOfBirth";
            dateOfBirthDataGridViewTextBoxColumn.MinimumWidth = 24;
            dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
            dateOfBirthDataGridViewTextBoxColumn.ReadOnly = true;
            dateOfBirthDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            startDateDataGridViewTextBoxColumn.HeaderText = "StartDate";
            startDateDataGridViewTextBoxColumn.MinimumWidth = 24;
            startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            startDateDataGridViewTextBoxColumn.ReadOnly = true;
            startDateDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // endDateDataGridViewTextBoxColumn
            // 
            endDateDataGridViewTextBoxColumn.DataPropertyName = "EndDate";
            endDateDataGridViewTextBoxColumn.HeaderText = "EndDate";
            endDateDataGridViewTextBoxColumn.MinimumWidth = 24;
            endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
            endDateDataGridViewTextBoxColumn.ReadOnly = true;
            endDateDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // createdDateDataGridViewTextBoxColumn
            // 
            createdDateDataGridViewTextBoxColumn.DataPropertyName = "CreatedDate";
            createdDateDataGridViewTextBoxColumn.HeaderText = "CreatedDate";
            createdDateDataGridViewTextBoxColumn.MinimumWidth = 24;
            createdDateDataGridViewTextBoxColumn.Name = "createdDateDataGridViewTextBoxColumn";
            createdDateDataGridViewTextBoxColumn.ReadOnly = true;
            createdDateDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            statusDataGridViewTextBoxColumn.HeaderText = "Status";
            statusDataGridViewTextBoxColumn.MinimumWidth = 24;
            statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            statusDataGridViewTextBoxColumn.ReadOnly = true;
            statusDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // IsDeleted
            // 
            IsDeleted.DataPropertyName = "IsDeleted";
            IsDeleted.HeaderText = "IsDeleted";
            IsDeleted.MinimumWidth = 24;
            IsDeleted.Name = "IsDeleted";
            IsDeleted.ReadOnly = true;
            IsDeleted.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // membershipTypeDataGridViewTextBoxColumn
            // 
            membershipTypeDataGridViewTextBoxColumn.DataPropertyName = "MembershipType";
            membershipTypeDataGridViewTextBoxColumn.HeaderText = "MembershipType";
            membershipTypeDataGridViewTextBoxColumn.MinimumWidth = 24;
            membershipTypeDataGridViewTextBoxColumn.Name = "membershipTypeDataGridViewTextBoxColumn";
            membershipTypeDataGridViewTextBoxColumn.ReadOnly = true;
            membershipTypeDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // TrainerFullName
            // 
            TrainerFullName.DataPropertyName = "TrainerFullName";
            TrainerFullName.HeaderText = "TrainerFullName";
            TrainerFullName.MinimumWidth = 24;
            TrainerFullName.Name = "TrainerFullName";
            TrainerFullName.ReadOnly = true;
            TrainerFullName.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // View
            // 
            View.HeaderText = "View";
            View.Image = (Image)resources.GetObject("View.Image");
            View.ImageLayout = DataGridViewImageCellLayout.Zoom;
            View.MinimumWidth = 24;
            View.Name = "View";
            View.ReadOnly = true;
            View.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // Edit
            // 
            Edit.HeaderText = "Edit";
            Edit.Image = (Image)resources.GetObject("Edit.Image");
            Edit.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Edit.MinimumWidth = 24;
            Edit.Name = "Edit";
            Edit.ReadOnly = true;
            Edit.Resizable = DataGridViewTriState.False;
            Edit.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // Delete
            // 
            Delete.HeaderText = "Delete";
            Delete.Image = (Image)resources.GetObject("Delete.Image");
            Delete.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Delete.MinimumWidth = 24;
            Delete.Name = "Delete";
            Delete.ReadOnly = true;
            Delete.Resizable = DataGridViewTriState.False;
            Delete.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // ShowMembersTablePageForm1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 436);
            ControlBox = false;
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ShowMembersTablePageForm1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ShowMembersTablePageForm1";
            Load += ShowMembersTablePageForm1_Load;
            cuiPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)advancedDataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)memberBindingSource).EndInit();
            cuiPanel2.ResumeLayout(false);
            cuiPanel7.ResumeLayout(false);
            cuiPanel7.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            cuiPanel8.ResumeLayout(false);
            cuiPanel8.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private CuoreUI.Controls.cuiPanel cuiPanel1;
        private CuoreUI.Controls.cuiPanel cuiPanel2;
        private Label label2;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private CuoreUI.Controls.cuiPanel cuiPanel8;
        private CuoreUI.Controls.cuiButtonGroup cuiButtonGroup2;
        private CuoreUI.Controls.cuiPanel cuiPanel7;
        private CuoreUI.Controls.cuiTextBox searchBar;
        private BindingSource memberBindingSource;
        private DataGridViewTextBoxColumn updatedDateDataGridViewTextBoxColumn;
        private Zuby.ADGV.AdvancedDataGridView advancedDataGridView1;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private CuoreUI.Controls.cuiCheckbox deletedMemberCheck;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Gender;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn createdDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn IsDeleted;
        private DataGridViewTextBoxColumn membershipTypeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn TrainerFullName;
        private DataGridViewImageColumn View;
        private DataGridViewImageColumn Edit;
        private DataGridViewImageColumn Delete;
    }
}