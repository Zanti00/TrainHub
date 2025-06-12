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
            dataGridView2 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            firstNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lastNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            phoneNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateOfBirthDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            startDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            endDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            createdDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            softDeleteDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            isDeletedDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            statusDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            membershipTypeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            editBtn = new DataGridViewImageColumn();
            deleteBtn = new DataGridViewImageColumn();
            memberBindingSource = new BindingSource(components);
            cuiPanel2 = new CuoreUI.Controls.cuiPanel();
            cuiPanel7 = new CuoreUI.Controls.cuiPanel();
            searchBar = new CuoreUI.Controls.cuiTextBox();
            cuiButtonGroup1 = new CuoreUI.Controls.cuiButtonGroup();
            label2 = new Label();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            cuiPanel8 = new CuoreUI.Controls.cuiPanel();
            cuiButtonGroup2 = new CuoreUI.Controls.cuiButtonGroup();
            cuiPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
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
            cuiPanel1.Controls.Add(dataGridView2);
            cuiPanel1.Controls.Add(cuiPanel2);
            cuiPanel1.Dock = DockStyle.Fill;
            cuiPanel1.Location = new Point(13, 100);
            cuiPanel1.Margin = new Padding(3, 2, 3, 2);
            cuiPanel1.Name = "cuiPanel1";
            cuiPanel1.OutlineThickness = 1F;
            cuiPanel1.PanelColor = Color.Transparent;
            cuiPanel1.PanelOutlineColor = Color.Transparent;
            cuiPanel1.Rounding = new Padding(8);
            cuiPanel1.Size = new Size(780, 396);
            cuiPanel1.TabIndex = 7;
            // 
            // dataGridView2
            // 
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 250, 252);
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, firstNameDataGridViewTextBoxColumn, lastNameDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, phoneNumberDataGridViewTextBoxColumn, dateOfBirthDataGridViewTextBoxColumn, startDateDataGridViewTextBoxColumn, endDateDataGridViewTextBoxColumn, createdDateDataGridViewTextBoxColumn, softDeleteDateDataGridViewTextBoxColumn, isDeletedDataGridViewCheckBoxColumn, statusDataGridViewTextBoxColumn, membershipTypeDataGridViewTextBoxColumn, editBtn, deleteBtn });
            dataGridView2.DataSource = memberBindingSource;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView2.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.GridColor = SystemColors.HighlightText;
            dataGridView2.Location = new Point(0, 47);
            dataGridView2.Margin = new Padding(3, 2, 3, 2);
            dataGridView2.Name = "dataGridView2";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new Padding(5, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.RowHeadersWidth = 51;
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.Padding = new Padding(2, 0, 0, 0);
            dataGridViewCellStyle4.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView2.RowTemplate.DefaultCellStyle.Padding = new Padding(0, 10, 0, 10);
            dataGridView2.RowTemplate.DividerHeight = 1;
            dataGridView2.RowTemplate.Height = 60;
            dataGridView2.RowTemplate.Resizable = DataGridViewTriState.False;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(780, 349);
            dataGridView2.TabIndex = 35;
            dataGridView2.CellClick += dataGridView2_CellClick;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Member ID";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            firstNameDataGridViewTextBoxColumn.HeaderText = "First Name";
            firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            firstNameDataGridViewTextBoxColumn.Width = 130;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            lastNameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            lastNameDataGridViewTextBoxColumn.Width = 130;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.HeaderText = "Email";
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            emailDataGridViewTextBoxColumn.ReadOnly = true;
            emailDataGridViewTextBoxColumn.Width = 130;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            phoneNumberDataGridViewTextBoxColumn.HeaderText = "Phone Number";
            phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            phoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateOfBirthDataGridViewTextBoxColumn
            // 
            dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "DateOfBirth";
            dateOfBirthDataGridViewTextBoxColumn.HeaderText = "Date of Birth";
            dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
            dateOfBirthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            startDateDataGridViewTextBoxColumn.HeaderText = "Start Date";
            startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            startDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // endDateDataGridViewTextBoxColumn
            // 
            endDateDataGridViewTextBoxColumn.DataPropertyName = "EndDate";
            endDateDataGridViewTextBoxColumn.HeaderText = "End Date";
            endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
            endDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // createdDateDataGridViewTextBoxColumn
            // 
            createdDateDataGridViewTextBoxColumn.DataPropertyName = "CreatedDate";
            createdDateDataGridViewTextBoxColumn.HeaderText = "Created Date";
            createdDateDataGridViewTextBoxColumn.Name = "createdDateDataGridViewTextBoxColumn";
            createdDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // softDeleteDateDataGridViewTextBoxColumn
            // 
            softDeleteDateDataGridViewTextBoxColumn.DataPropertyName = "SoftDeleteDate";
            softDeleteDateDataGridViewTextBoxColumn.HeaderText = "SoftDeleteDate";
            softDeleteDateDataGridViewTextBoxColumn.Name = "softDeleteDateDataGridViewTextBoxColumn";
            softDeleteDateDataGridViewTextBoxColumn.Visible = false;
            // 
            // isDeletedDataGridViewCheckBoxColumn
            // 
            isDeletedDataGridViewCheckBoxColumn.DataPropertyName = "IsDeleted";
            isDeletedDataGridViewCheckBoxColumn.HeaderText = "IsDeleted";
            isDeletedDataGridViewCheckBoxColumn.Name = "isDeletedDataGridViewCheckBoxColumn";
            isDeletedDataGridViewCheckBoxColumn.Visible = false;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            statusDataGridViewTextBoxColumn.HeaderText = "Status";
            statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // membershipTypeDataGridViewTextBoxColumn
            // 
            membershipTypeDataGridViewTextBoxColumn.DataPropertyName = "MembershipType";
            membershipTypeDataGridViewTextBoxColumn.HeaderText = "Membership Type";
            membershipTypeDataGridViewTextBoxColumn.Name = "membershipTypeDataGridViewTextBoxColumn";
            membershipTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // editBtn
            // 
            editBtn.HeaderText = "Edit";
            editBtn.Image = (Image)resources.GetObject("editBtn.Image");
            editBtn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            editBtn.MinimumWidth = 6;
            editBtn.Name = "editBtn";
            editBtn.Resizable = DataGridViewTriState.False;
            editBtn.SortMode = DataGridViewColumnSortMode.Automatic;
            editBtn.Width = 80;
            // 
            // deleteBtn
            // 
            deleteBtn.HeaderText = "Delete";
            deleteBtn.Image = (Image)resources.GetObject("deleteBtn.Image");
            deleteBtn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            deleteBtn.MinimumWidth = 6;
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Resizable = DataGridViewTriState.False;
            deleteBtn.SortMode = DataGridViewColumnSortMode.Automatic;
            deleteBtn.Width = 80;
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
            cuiPanel2.Size = new Size(780, 47);
            cuiPanel2.TabIndex = 16;
            // 
            // cuiPanel7
            // 
            cuiPanel7.Controls.Add(searchBar);
            cuiPanel7.Controls.Add(cuiButtonGroup1);
            cuiPanel7.Dock = DockStyle.Right;
            cuiPanel7.Location = new Point(330, 5);
            cuiPanel7.Margin = new Padding(3, 2, 3, 2);
            cuiPanel7.Name = "cuiPanel7";
            cuiPanel7.OutlineThickness = 0F;
            cuiPanel7.PanelColor = Color.FromArgb(248, 250, 252);
            cuiPanel7.PanelOutlineColor = Color.FromArgb(248, 250, 252);
            cuiPanel7.Rounding = new Padding(8, 8, 0, 0);
            cuiPanel7.Size = new Size(445, 37);
            cuiPanel7.TabIndex = 34;
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
            searchBar.ImageExpand = new Point(0, 0);
            searchBar.ImageOffset = new Point(0, 0);
            searchBar.Location = new Point(41, 3);
            searchBar.Margin = new Padding(4);
            searchBar.Multiline = false;
            searchBar.Name = "searchBar";
            searchBar.NormalImageTint = Color.White;
            searchBar.Padding = new Padding(14, 9, 14, 0);
            searchBar.PasswordChar = false;
            searchBar.PlaceholderColor = Color.DimGray;
            searchBar.PlaceholderText = "Search...";
            searchBar.Rounding = new Padding(10);
            searchBar.Size = new Size(296, 32);
            searchBar.TabIndex = 15;
            searchBar.TextOffset = new Size(0, 0);
            searchBar.UnderlinedStyle = false;
            searchBar.ContentChanged += searchBar_ContentChanged;
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
            cuiButtonGroup1.Location = new Point(344, 3);
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
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(0, 28);
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
            label1.Location = new Point(0, 4);
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
            tableLayoutPanel1.Size = new Size(806, 498);
            tableLayoutPanel1.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(13, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 43);
            panel1.TabIndex = 9;
            // 
            // cuiPanel8
            // 
            cuiPanel8.BackColor = Color.Transparent;
            cuiPanel8.Controls.Add(cuiButtonGroup2);
            cuiPanel8.Dock = DockStyle.Right;
            cuiPanel8.Location = new Point(644, 51);
            cuiPanel8.Margin = new Padding(3, 2, 3, 2);
            cuiPanel8.Name = "cuiPanel8";
            cuiPanel8.OutlineThickness = 1F;
            cuiPanel8.PanelColor = Color.Transparent;
            cuiPanel8.PanelOutlineColor = Color.Transparent;
            cuiPanel8.Rounding = new Padding(8, 8, 0, 0);
            cuiPanel8.Size = new Size(149, 45);
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
            // ShowMembersTablePageForm1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(806, 498);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ShowMembersTablePageForm1";
            Text = "ShowMembersTablePageForm1";
            Load += ShowMembersTablePageForm1_Load;
            cuiPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
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
        private CuoreUI.Controls.cuiButtonGroup cuiButtonGroup1;
        private DataGridView dataGridView2;
        private BindingSource memberBindingSource;
        private DataGridViewTextBoxColumn updatedDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn createdDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn softDeleteDateDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn isDeletedDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn membershipTypeDataGridViewTextBoxColumn;
        private DataGridViewImageColumn editBtn;
        private DataGridViewImageColumn deleteBtn;
    }
}