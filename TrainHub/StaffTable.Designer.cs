
namespace TrainHub
{
    partial class StaffTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffTable));
            label2 = new Label();
            cuiPanel2 = new CuoreUI.Controls.cuiPanel();
            cuiPanel4 = new CuoreUI.Controls.cuiPanel();
            searchTextBox = new CuoreUI.Controls.cuiTextBox();
            sortBtn = new CuoreUI.Controls.cuiButtonGroup();
            cuiTextBox4 = new CuoreUI.Controls.cuiTextBox();
            cuiButtonGroup1 = new CuoreUI.Controls.cuiButtonGroup();
            cuiPanel7 = new CuoreUI.Controls.cuiPanel();
            cuiButtonGroup2 = new CuoreUI.Controls.cuiButtonGroup();
            cuiPanel8 = new CuoreUI.Controls.cuiPanel();
            label1 = new Label();
            cuiPanel1 = new CuoreUI.Controls.cuiPanel();
            advancedDataGridView1 = new Zuby.ADGV.AdvancedDataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            firstNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lastNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            usernameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            mobileNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateOfBirthDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            passwordDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            addressDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            isAdminDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            isDeletedDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            softDeleteDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            createdDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            userBindingSource = new BindingSource(components);
            cuiPanel3 = new CuoreUI.Controls.cuiPanel();
            addStaffBtn = new CuoreUI.Controls.cuiButtonGroup();
            flowLayoutPanel1 = new FlowLayoutPanel();
            cuiPanel2.SuspendLayout();
            cuiPanel4.SuspendLayout();
            cuiPanel7.SuspendLayout();
            cuiPanel8.SuspendLayout();
            cuiPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)advancedDataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).BeginInit();
            cuiPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(81, 52);
            label2.Name = "label2";
            label2.Size = new Size(133, 15);
            label2.TabIndex = 25;
            label2.Text = "View and Manage Staffs";
            // 
            // cuiPanel2
            // 
            cuiPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            cuiPanel2.Controls.Add(cuiPanel4);
            cuiPanel2.Location = new Point(38, 109);
            cuiPanel2.Margin = new Padding(3, 2, 3, 2);
            cuiPanel2.Name = "cuiPanel2";
            cuiPanel2.OutlineThickness = 1F;
            cuiPanel2.PanelColor = Color.FromArgb(248, 250, 252);
            cuiPanel2.PanelOutlineColor = Color.Black;
            cuiPanel2.Rounding = new Padding(8, 8, 0, 0);
            cuiPanel2.Size = new Size(878, 58);
            cuiPanel2.TabIndex = 16;
            // 
            // cuiPanel4
            // 
            cuiPanel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cuiPanel4.Controls.Add(searchTextBox);
            cuiPanel4.Controls.Add(sortBtn);
            cuiPanel4.Location = new Point(434, 9);
            cuiPanel4.Margin = new Padding(3, 2, 3, 2);
            cuiPanel4.Name = "cuiPanel4";
            cuiPanel4.OutlineThickness = 1F;
            cuiPanel4.PanelColor = Color.FromArgb(248, 250, 252);
            cuiPanel4.PanelOutlineColor = Color.FromArgb(248, 250, 252);
            cuiPanel4.Rounding = new Padding(8, 8, 0, 0);
            cuiPanel4.Size = new Size(433, 43);
            cuiPanel4.TabIndex = 37;
            // 
            // searchTextBox
            // 
            searchTextBox.AutoSize = true;
            searchTextBox.BackColor = Color.Transparent;
            searchTextBox.BackgroundColor = Color.White;
            searchTextBox.BorderColor = Color.FromArgb(50, 81, 88);
            searchTextBox.Content = "";
            searchTextBox.FocusBackgroundColor = Color.White;
            searchTextBox.FocusBorderColor = Color.FromArgb(50, 81, 88);
            searchTextBox.FocusImageTint = Color.White;
            searchTextBox.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchTextBox.ForeColor = Color.Black;
            searchTextBox.Image = null;
            searchTextBox.ImageExpand = new Point(0, 0);
            searchTextBox.ImageOffset = new Point(0, 0);
            searchTextBox.Location = new Point(38, 4);
            searchTextBox.Margin = new Padding(4);
            searchTextBox.Multiline = false;
            searchTextBox.Name = "searchTextBox";
            searchTextBox.NormalImageTint = Color.White;
            searchTextBox.Padding = new Padding(14, 9, 14, 0);
            searchTextBox.PasswordChar = false;
            searchTextBox.PlaceholderColor = Color.DimGray;
            searchTextBox.PlaceholderText = "Search";
            searchTextBox.Rounding = new Padding(10);
            searchTextBox.Size = new Size(296, 32);
            searchTextBox.TabIndex = 15;
            searchTextBox.TextOffset = new Size(0, 0);
            searchTextBox.UnderlinedStyle = false;
            // 
            // sortBtn
            // 
            sortBtn.BackColor = Color.Transparent;
            sortBtn.Checked = false;
            sortBtn.CheckedBackground = Color.FromArgb(50, 81, 88);
            sortBtn.CheckedForeColor = Color.White;
            sortBtn.CheckedImageTint = Color.White;
            sortBtn.CheckedOutline = Color.FromArgb(50, 81, 88);
            sortBtn.Content = "  Sort By";
            sortBtn.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sortBtn.ForeColor = Color.DimGray;
            sortBtn.Group = 0;
            sortBtn.HoverBackground = Color.FromArgb(51, 81, 88);
            sortBtn.HoveredImageTint = Color.White;
            sortBtn.HoverForeColor = Color.White;
            sortBtn.HoverOutline = Color.FromArgb(51, 81, 88);
            sortBtn.Image = (Image)resources.GetObject("sortBtn.Image");
            sortBtn.ImageAutoCenter = true;
            sortBtn.ImageExpand = new Point(0, 0);
            sortBtn.ImageOffset = new Point(0, 0);
            sortBtn.Location = new Point(341, 4);
            sortBtn.MaximumSize = new Size(127, 32);
            sortBtn.Name = "sortBtn";
            sortBtn.NormalBackground = Color.White;
            sortBtn.NormalForeColor = Color.DimGray;
            sortBtn.NormalImageTint = Color.White;
            sortBtn.NormalOutline = Color.FromArgb(50, 81, 88);
            sortBtn.OutlineThickness = 1F;
            sortBtn.PressedBackground = Color.FromArgb(22, 36, 39);
            sortBtn.PressedForeColor = Color.White;
            sortBtn.PressedImageTint = Color.White;
            sortBtn.PressedOutline = Color.FromArgb(22, 36, 39);
            sortBtn.Rounding = new Padding(10);
            sortBtn.Size = new Size(92, 32);
            sortBtn.TabIndex = 22;
            sortBtn.TextAlignment = StringAlignment.Center;
            sortBtn.TextOffset = new Point(0, 0);
            // 
            // cuiTextBox4
            // 
            cuiTextBox4.AutoSize = true;
            cuiTextBox4.BackColor = Color.Transparent;
            cuiTextBox4.BackgroundColor = Color.White;
            cuiTextBox4.BorderColor = Color.FromArgb(50, 81, 88);
            cuiTextBox4.Content = "";
            cuiTextBox4.FocusBackgroundColor = Color.White;
            cuiTextBox4.FocusBorderColor = Color.FromArgb(50, 81, 88);
            cuiTextBox4.FocusImageTint = Color.White;
            cuiTextBox4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiTextBox4.ForeColor = Color.Black;
            cuiTextBox4.Image = null;
            cuiTextBox4.ImageExpand = new Point(0, 0);
            cuiTextBox4.ImageOffset = new Point(0, 0);
            cuiTextBox4.Location = new Point(38, 4);
            cuiTextBox4.Margin = new Padding(4);
            cuiTextBox4.Multiline = false;
            cuiTextBox4.Name = "cuiTextBox4";
            cuiTextBox4.NormalImageTint = Color.White;
            cuiTextBox4.Padding = new Padding(15, 10, 15, 0);
            cuiTextBox4.PasswordChar = false;
            cuiTextBox4.PlaceholderColor = Color.DimGray;
            cuiTextBox4.PlaceholderText = "Search";
            cuiTextBox4.Rounding = new Padding(10);
            cuiTextBox4.Size = new Size(296, 32);
            cuiTextBox4.TabIndex = 15;
            cuiTextBox4.TextOffset = new Size(0, 0);
            cuiTextBox4.UnderlinedStyle = false;
            // 
            // cuiButtonGroup1
            // 
            cuiButtonGroup1.BackColor = Color.Transparent;
            cuiButtonGroup1.Checked = false;
            cuiButtonGroup1.CheckedBackground = Color.FromArgb(50, 81, 88);
            cuiButtonGroup1.CheckedForeColor = Color.White;
            cuiButtonGroup1.CheckedImageTint = Color.White;
            cuiButtonGroup1.CheckedOutline = Color.FromArgb(50, 81, 88);
            cuiButtonGroup1.Content = "  Sort By";
            cuiButtonGroup1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiButtonGroup1.ForeColor = Color.DimGray;
            cuiButtonGroup1.Group = 0;
            cuiButtonGroup1.HoverBackground = Color.FromArgb(51, 81, 88);
            cuiButtonGroup1.HoveredImageTint = Color.White;
            cuiButtonGroup1.HoverForeColor = Color.White;
            cuiButtonGroup1.HoverOutline = Color.FromArgb(51, 81, 88);
            cuiButtonGroup1.Image = (Image)resources.GetObject("cuiButtonGroup1.Image");
            cuiButtonGroup1.ImageAutoCenter = true;
            cuiButtonGroup1.ImageExpand = new Point(0, 0);
            cuiButtonGroup1.ImageOffset = new Point(0, 0);
            cuiButtonGroup1.Location = new Point(341, 4);
            cuiButtonGroup1.MaximumSize = new Size(127, 32);
            cuiButtonGroup1.Name = "cuiButtonGroup1";
            cuiButtonGroup1.NormalBackground = Color.White;
            cuiButtonGroup1.NormalForeColor = Color.DimGray;
            cuiButtonGroup1.NormalImageTint = Color.White;
            cuiButtonGroup1.NormalOutline = Color.FromArgb(50, 81, 88);
            cuiButtonGroup1.OutlineThickness = 1F;
            cuiButtonGroup1.PressedBackground = Color.FromArgb(22, 36, 39);
            cuiButtonGroup1.PressedForeColor = Color.White;
            cuiButtonGroup1.PressedImageTint = Color.White;
            cuiButtonGroup1.PressedOutline = Color.FromArgb(22, 36, 39);
            cuiButtonGroup1.Rounding = new Padding(10);
            cuiButtonGroup1.Size = new Size(92, 32);
            cuiButtonGroup1.TabIndex = 22;
            cuiButtonGroup1.TextAlignment = StringAlignment.Center;
            cuiButtonGroup1.TextOffset = new Point(0, 0);
            // 
            // cuiPanel7
            // 
            cuiPanel7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cuiPanel7.Controls.Add(cuiTextBox4);
            cuiPanel7.Controls.Add(cuiButtonGroup1);
            cuiPanel7.Location = new Point(1212, 118);
            cuiPanel7.Margin = new Padding(3, 2, 3, 2);
            cuiPanel7.Name = "cuiPanel7";
            cuiPanel7.OutlineThickness = 1F;
            cuiPanel7.PanelColor = Color.FromArgb(248, 250, 252);
            cuiPanel7.PanelOutlineColor = Color.FromArgb(248, 250, 252);
            cuiPanel7.Rounding = new Padding(8, 8, 0, 0);
            cuiPanel7.Size = new Size(433, 43);
            cuiPanel7.TabIndex = 33;
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
            cuiButtonGroup2.ForeColor = Color.Black;
            cuiButtonGroup2.Group = 0;
            cuiButtonGroup2.HoverBackground = Color.Transparent;
            cuiButtonGroup2.HoveredImageTint = Color.Transparent;
            cuiButtonGroup2.HoverForeColor = Color.Black;
            cuiButtonGroup2.HoverOutline = Color.White;
            cuiButtonGroup2.Image = null;
            cuiButtonGroup2.ImageAutoCenter = true;
            cuiButtonGroup2.ImageExpand = new Point(0, 0);
            cuiButtonGroup2.ImageOffset = new Point(0, 0);
            cuiButtonGroup2.Location = new Point(36, 11);
            cuiButtonGroup2.Name = "cuiButtonGroup2";
            cuiButtonGroup2.NormalBackground = Color.White;
            cuiButtonGroup2.NormalForeColor = Color.Black;
            cuiButtonGroup2.NormalImageTint = Color.Black;
            cuiButtonGroup2.NormalOutline = Color.Transparent;
            cuiButtonGroup2.OutlineThickness = 1F;
            cuiButtonGroup2.PressedBackground = Color.White;
            cuiButtonGroup2.PressedForeColor = Color.White;
            cuiButtonGroup2.PressedImageTint = Color.White;
            cuiButtonGroup2.PressedOutline = Color.White;
            cuiButtonGroup2.Rounding = new Padding(10);
            cuiButtonGroup2.Size = new Size(113, 32);
            cuiButtonGroup2.TabIndex = 23;
            cuiButtonGroup2.TextAlignment = StringAlignment.Center;
            cuiButtonGroup2.TextOffset = new Point(0, 0);
            // 
            // cuiPanel8
            // 
            cuiPanel8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cuiPanel8.BackColor = Color.White;
            cuiPanel8.Controls.Add(cuiButtonGroup2);
            cuiPanel8.Location = new Point(1508, 62);
            cuiPanel8.Margin = new Padding(3, 2, 3, 2);
            cuiPanel8.Name = "cuiPanel8";
            cuiPanel8.OutlineThickness = 1F;
            cuiPanel8.PanelColor = Color.White;
            cuiPanel8.PanelOutlineColor = Color.White;
            cuiPanel8.Rounding = new Padding(8, 8, 0, 0);
            cuiPanel8.Size = new Size(149, 43);
            cuiPanel8.TabIndex = 34;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(51, 81, 88);
            label1.Location = new Point(81, 30);
            label1.Name = "label1";
            label1.Size = new Size(59, 24);
            label1.TabIndex = 24;
            label1.Text = "Staffs";
            // 
            // cuiPanel1
            // 
            cuiPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cuiPanel1.Controls.Add(advancedDataGridView1);
            cuiPanel1.Controls.Add(cuiPanel3);
            cuiPanel1.Controls.Add(cuiPanel8);
            cuiPanel1.Controls.Add(cuiPanel7);
            cuiPanel1.Controls.Add(label2);
            cuiPanel1.Controls.Add(label1);
            cuiPanel1.Controls.Add(cuiPanel2);
            cuiPanel1.Location = new Point(312, 64);
            cuiPanel1.Margin = new Padding(1, 2, 3, 2);
            cuiPanel1.Name = "cuiPanel1";
            cuiPanel1.OutlineThickness = 1F;
            cuiPanel1.PanelColor = Color.White;
            cuiPanel1.PanelOutlineColor = Color.Black;
            cuiPanel1.Rounding = new Padding(8);
            cuiPanel1.Size = new Size(955, 563);
            cuiPanel1.TabIndex = 9;
            // 
            // advancedDataGridView1
            // 
            advancedDataGridView1.AutoGenerateColumns = false;
            advancedDataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            advancedDataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, firstNameDataGridViewTextBoxColumn, lastNameDataGridViewTextBoxColumn, usernameDataGridViewTextBoxColumn, mobileNumberDataGridViewTextBoxColumn, dateOfBirthDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, passwordDataGridViewTextBoxColumn, addressDataGridViewTextBoxColumn, isAdminDataGridViewCheckBoxColumn, isDeletedDataGridViewCheckBoxColumn, softDeleteDateDataGridViewTextBoxColumn, createdDateDataGridViewTextBoxColumn });
            advancedDataGridView1.DataSource = userBindingSource;
            advancedDataGridView1.FilterAndSortEnabled = true;
            advancedDataGridView1.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            advancedDataGridView1.Location = new Point(38, 166);
            advancedDataGridView1.MaxFilterButtonImageHeight = 23;
            advancedDataGridView1.Name = "advancedDataGridView1";
            advancedDataGridView1.RightToLeft = RightToLeft.No;
            advancedDataGridView1.Size = new Size(878, 366);
            advancedDataGridView1.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            advancedDataGridView1.TabIndex = 37;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 24;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            firstNameDataGridViewTextBoxColumn.MinimumWidth = 24;
            firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            firstNameDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            lastNameDataGridViewTextBoxColumn.MinimumWidth = 24;
            lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            lastNameDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            usernameDataGridViewTextBoxColumn.MinimumWidth = 24;
            usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            usernameDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // mobileNumberDataGridViewTextBoxColumn
            // 
            mobileNumberDataGridViewTextBoxColumn.DataPropertyName = "MobileNumber";
            mobileNumberDataGridViewTextBoxColumn.HeaderText = "MobileNumber";
            mobileNumberDataGridViewTextBoxColumn.MinimumWidth = 24;
            mobileNumberDataGridViewTextBoxColumn.Name = "mobileNumberDataGridViewTextBoxColumn";
            mobileNumberDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // dateOfBirthDataGridViewTextBoxColumn
            // 
            dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "DateOfBirth";
            dateOfBirthDataGridViewTextBoxColumn.HeaderText = "DateOfBirth";
            dateOfBirthDataGridViewTextBoxColumn.MinimumWidth = 24;
            dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
            dateOfBirthDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.HeaderText = "Email";
            emailDataGridViewTextBoxColumn.MinimumWidth = 24;
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            emailDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            passwordDataGridViewTextBoxColumn.MinimumWidth = 24;
            passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            passwordDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            addressDataGridViewTextBoxColumn.HeaderText = "Address";
            addressDataGridViewTextBoxColumn.MinimumWidth = 24;
            addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            addressDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // isAdminDataGridViewCheckBoxColumn
            // 
            isAdminDataGridViewCheckBoxColumn.DataPropertyName = "isAdmin";
            isAdminDataGridViewCheckBoxColumn.HeaderText = "isAdmin";
            isAdminDataGridViewCheckBoxColumn.MinimumWidth = 24;
            isAdminDataGridViewCheckBoxColumn.Name = "isAdminDataGridViewCheckBoxColumn";
            isAdminDataGridViewCheckBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // isDeletedDataGridViewCheckBoxColumn
            // 
            isDeletedDataGridViewCheckBoxColumn.DataPropertyName = "isDeleted";
            isDeletedDataGridViewCheckBoxColumn.HeaderText = "isDeleted";
            isDeletedDataGridViewCheckBoxColumn.MinimumWidth = 24;
            isDeletedDataGridViewCheckBoxColumn.Name = "isDeletedDataGridViewCheckBoxColumn";
            isDeletedDataGridViewCheckBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // softDeleteDateDataGridViewTextBoxColumn
            // 
            softDeleteDateDataGridViewTextBoxColumn.DataPropertyName = "softDeleteDate";
            softDeleteDateDataGridViewTextBoxColumn.HeaderText = "softDeleteDate";
            softDeleteDateDataGridViewTextBoxColumn.MinimumWidth = 24;
            softDeleteDateDataGridViewTextBoxColumn.Name = "softDeleteDateDataGridViewTextBoxColumn";
            softDeleteDateDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // createdDateDataGridViewTextBoxColumn
            // 
            createdDateDataGridViewTextBoxColumn.DataPropertyName = "CreatedDate";
            createdDateDataGridViewTextBoxColumn.HeaderText = "CreatedDate";
            createdDateDataGridViewTextBoxColumn.MinimumWidth = 24;
            createdDateDataGridViewTextBoxColumn.Name = "createdDateDataGridViewTextBoxColumn";
            createdDateDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // userBindingSource
            // 
            userBindingSource.DataSource = typeof(Models.User);
            // 
            // cuiPanel3
            // 
            cuiPanel3.Anchor = AnchorStyles.Top;
            cuiPanel3.BackColor = Color.White;
            cuiPanel3.Controls.Add(addStaffBtn);
            cuiPanel3.Location = new Point(757, 62);
            cuiPanel3.Margin = new Padding(3, 2, 3, 2);
            cuiPanel3.Name = "cuiPanel3";
            cuiPanel3.OutlineThickness = 1F;
            cuiPanel3.PanelColor = Color.White;
            cuiPanel3.PanelOutlineColor = Color.White;
            cuiPanel3.Rounding = new Padding(8, 8, 0, 0);
            cuiPanel3.Size = new Size(149, 43);
            cuiPanel3.TabIndex = 36;
            // 
            // addStaffBtn
            // 
            addStaffBtn.Anchor = AnchorStyles.Top;
            addStaffBtn.AutoSize = true;
            addStaffBtn.BackColor = Color.FromArgb(50, 81, 88);
            addStaffBtn.BorderStyle = BorderStyle.FixedSingle;
            addStaffBtn.Checked = false;
            addStaffBtn.CheckedBackground = Color.FromArgb(50, 81, 88);
            addStaffBtn.CheckedForeColor = Color.Black;
            addStaffBtn.CheckedImageTint = Color.FromArgb(50, 81, 88);
            addStaffBtn.CheckedOutline = Color.Transparent;
            addStaffBtn.Content = "+ Add Staff";
            addStaffBtn.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addStaffBtn.ForeColor = Color.White;
            addStaffBtn.Group = 0;
            addStaffBtn.HoverBackground = Color.FromArgb(50, 81, 88);
            addStaffBtn.HoveredImageTint = Color.White;
            addStaffBtn.HoverForeColor = Color.White;
            addStaffBtn.HoverOutline = Color.FromArgb(50, 81, 88);
            addStaffBtn.Image = null;
            addStaffBtn.ImageAutoCenter = true;
            addStaffBtn.ImageExpand = new Point(0, 0);
            addStaffBtn.ImageOffset = new Point(0, 0);
            addStaffBtn.Location = new Point(22, 8);
            addStaffBtn.Name = "addStaffBtn";
            addStaffBtn.NormalBackground = Color.Empty;
            addStaffBtn.NormalForeColor = Color.White;
            addStaffBtn.NormalImageTint = Color.Black;
            addStaffBtn.NormalOutline = Color.Transparent;
            addStaffBtn.OutlineThickness = 1F;
            addStaffBtn.PressedBackground = Color.FromArgb(50, 81, 88);
            addStaffBtn.PressedForeColor = Color.FromArgb(50, 81, 88);
            addStaffBtn.PressedImageTint = Color.FromArgb(50, 81, 88);
            addStaffBtn.PressedOutline = Color.FromArgb(50, 81, 88);
            addStaffBtn.Rounding = new Padding(10);
            addStaffBtn.Size = new Size(113, 32);
            addStaffBtn.TabIndex = 23;
            addStaffBtn.TextAlignment = StringAlignment.Center;
            addStaffBtn.TextOffset = new Point(0, 0);
            addStaffBtn.Click += addStaffBtn_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            flowLayoutPanel1.BackColor = Color.FromArgb(51, 81, 88);
            flowLayoutPanel1.ForeColor = SystemColors.ControlLightLight;
            flowLayoutPanel1.Location = new Point(3, -8);
            flowLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(265, 679);
            flowLayoutPanel1.TabIndex = 8;
            // 
            // StaffTable
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1380, 664);
            Controls.Add(cuiPanel1);
            Controls.Add(flowLayoutPanel1);
            ForeColor = Color.White;
            Margin = new Padding(3, 2, 3, 2);
            Name = "StaffTable";
            Text = "Form2";
            Load += StaffTable_Load;
            cuiPanel2.ResumeLayout(false);
            cuiPanel4.ResumeLayout(false);
            cuiPanel4.PerformLayout();
            cuiPanel7.ResumeLayout(false);
            cuiPanel7.PerformLayout();
            cuiPanel8.ResumeLayout(false);
            cuiPanel8.PerformLayout();
            cuiPanel1.ResumeLayout(false);
            cuiPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)advancedDataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).EndInit();
            cuiPanel3.ResumeLayout(false);
            cuiPanel3.PerformLayout();
            ResumeLayout(false);
        }

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label label2;
        private CuoreUI.Controls.cuiPanel cuiPanel2;
        private CuoreUI.Controls.cuiTextBox cuiTextBox4;
        private CuoreUI.Controls.cuiButtonGroup cuiButtonGroup1;
        private CuoreUI.Controls.cuiPanel cuiPanel7;
        private CuoreUI.Controls.cuiButtonGroup cuiButtonGroup2;
        private CuoreUI.Controls.cuiPanel cuiPanel8;
        private Label label1;
        private CuoreUI.Controls.cuiPanel cuiPanel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private CuoreUI.Controls.cuiPanel cuiPanel3;
        private CuoreUI.Controls.cuiButtonGroup addStaffBtn;
        private CuoreUI.Controls.cuiPanel cuiPanel4;
        private CuoreUI.Controls.cuiTextBox searchTextBox;
        private CuoreUI.Controls.cuiButtonGroup sortBtn;
        private BindingSource userBindingSource;
        private Zuby.ADGV.AdvancedDataGridView advancedDataGridView1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mobileNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn isAdminDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn isDeletedDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn softDeleteDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn createdDateDataGridViewTextBoxColumn;
    }
}