namespace TrainHub
{
    partial class Dashboar
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
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboar));
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel2 = new Panel();
            label1 = new Label();
            label2 = new Label();
            cuiPanel1 = new CuoreUI.Controls.cuiPanel();
            attendanceDataGridView = new Zuby.ADGV.AdvancedDataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            memberIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            FirstName = new DataGridViewTextBoxColumn();
            LastName = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            PhoneNumber = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            MembershipType = new DataGridViewTextBoxColumn();
            AttendanceDate = new DataGridViewTextBoxColumn();
            checkInTimeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            StartDate = new DataGridViewTextBoxColumn();
            EndDate = new DataGridViewTextBoxColumn();
            checkOutTimeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            memberAttendanceBindingSource = new BindingSource(components);
            cuiPanel2 = new CuoreUI.Controls.cuiPanel();
            panel1 = new Panel();
            cuiButtonGroup2 = new CuoreUI.Controls.cuiButtonGroup();
            cuiPanel7 = new CuoreUI.Controls.cuiPanel();
            cuiPictureBox1 = new CuoreUI.Controls.cuiPictureBox();
            searchBarAttendance = new CuoreUI.Controls.cuiTextBox();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel2.SuspendLayout();
            cuiPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)attendanceDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)memberAttendanceBindingSource).BeginInit();
            cuiPanel2.SuspendLayout();
            panel1.SuspendLayout();
            cuiPanel7.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(10, 0, 10, 10);
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.Size = new Size(799, 413);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.White;
            tableLayoutPanel2.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(panel2, 0, 0);
            tableLayoutPanel2.Controls.Add(cuiPanel1, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(13, 83);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel2.Size = new Size(773, 317);
            tableLayoutPanel2.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(4, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 56);
            panel2.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(51, 81, 88);
            label1.Location = new Point(13, 12);
            label1.Name = "label1";
            label1.Size = new Size(116, 24);
            label1.TabIndex = 24;
            label1.Text = "Attendance";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(14, 41);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 25;
            label2.Text = "17/06/2025";
            // 
            // cuiPanel1
            // 
            cuiPanel1.BackColor = Color.Transparent;
            cuiPanel1.Controls.Add(attendanceDataGridView);
            cuiPanel1.Controls.Add(cuiPanel2);
            cuiPanel1.Dock = DockStyle.Fill;
            cuiPanel1.Location = new Point(4, 67);
            cuiPanel1.Name = "cuiPanel1";
            cuiPanel1.OutlineThickness = 1F;
            cuiPanel1.PanelColor = Color.Transparent;
            cuiPanel1.PanelOutlineColor = Color.Transparent;
            cuiPanel1.Rounding = new Padding(8);
            cuiPanel1.Size = new Size(765, 246);
            cuiPanel1.TabIndex = 8;
            // 
            // attendanceDataGridView
            // 
            attendanceDataGridView.AllowUserToAddRows = false;
            attendanceDataGridView.AllowUserToDeleteRows = false;
            attendanceDataGridView.AllowUserToResizeRows = false;
            attendanceDataGridView.AutoGenerateColumns = false;
            attendanceDataGridView.BackgroundColor = Color.White;
            attendanceDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(50, 81, 88);
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            attendanceDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            attendanceDataGridView.ColumnHeadersHeight = 40;
            attendanceDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            attendanceDataGridView.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, memberIdDataGridViewTextBoxColumn, FirstName, LastName, Email, PhoneNumber, Status, MembershipType, AttendanceDate, checkInTimeDataGridViewTextBoxColumn, StartDate, EndDate, checkOutTimeDataGridViewTextBoxColumn });
            attendanceDataGridView.DataSource = memberAttendanceBindingSource;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = SystemColors.Window;
            dataGridViewCellStyle10.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle10.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = Color.FromArgb(50, 81, 88);
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.False;
            attendanceDataGridView.DefaultCellStyle = dataGridViewCellStyle10;
            attendanceDataGridView.Dock = DockStyle.Fill;
            attendanceDataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            attendanceDataGridView.FilterAndSortEnabled = true;
            attendanceDataGridView.FilterStringChangedInvokeBeforeDatasourceUpdate = false;
            attendanceDataGridView.GridColor = Color.DimGray;
            attendanceDataGridView.Location = new Point(0, 47);
            attendanceDataGridView.MaxFilterButtonImageHeight = 23;
            attendanceDataGridView.Name = "attendanceDataGridView";
            attendanceDataGridView.ReadOnly = true;
            attendanceDataGridView.RightToLeft = RightToLeft.No;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = SystemColors.ButtonFace;
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle11.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = Color.FromArgb(50, 81, 88);
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            attendanceDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            attendanceDataGridView.RowHeadersVisible = false;
            attendanceDataGridView.RowHeadersWidth = 120;
            dataGridViewCellStyle12.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle12.ForeColor = Color.Black;
            dataGridViewCellStyle12.Padding = new Padding(0, 5, 0, 5);
            dataGridViewCellStyle12.SelectionBackColor = Color.FromArgb(50, 81, 88);
            attendanceDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle12;
            attendanceDataGridView.RowTemplate.Height = 40;
            attendanceDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            attendanceDataGridView.Size = new Size(765, 199);
            attendanceDataGridView.SortStringChangedInvokeBeforeDatasourceUpdate = false;
            attendanceDataGridView.TabIndex = 17;
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
            // memberIdDataGridViewTextBoxColumn
            // 
            memberIdDataGridViewTextBoxColumn.DataPropertyName = "MemberId";
            memberIdDataGridViewTextBoxColumn.HeaderText = "MemberId";
            memberIdDataGridViewTextBoxColumn.MinimumWidth = 24;
            memberIdDataGridViewTextBoxColumn.Name = "memberIdDataGridViewTextBoxColumn";
            memberIdDataGridViewTextBoxColumn.ReadOnly = true;
            memberIdDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
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
            // checkInTimeDataGridViewTextBoxColumn
            // 
            checkInTimeDataGridViewTextBoxColumn.DataPropertyName = "CheckInTime";
            checkInTimeDataGridViewTextBoxColumn.HeaderText = "CheckInTime";
            checkInTimeDataGridViewTextBoxColumn.MinimumWidth = 24;
            checkInTimeDataGridViewTextBoxColumn.Name = "checkInTimeDataGridViewTextBoxColumn";
            checkInTimeDataGridViewTextBoxColumn.ReadOnly = true;
            checkInTimeDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
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
            // checkOutTimeDataGridViewTextBoxColumn
            // 
            checkOutTimeDataGridViewTextBoxColumn.DataPropertyName = "CheckOutTime";
            checkOutTimeDataGridViewTextBoxColumn.HeaderText = "CheckOutTime";
            checkOutTimeDataGridViewTextBoxColumn.MinimumWidth = 24;
            checkOutTimeDataGridViewTextBoxColumn.Name = "checkOutTimeDataGridViewTextBoxColumn";
            checkOutTimeDataGridViewTextBoxColumn.ReadOnly = true;
            checkOutTimeDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            checkOutTimeDataGridViewTextBoxColumn.Visible = false;
            // 
            // memberAttendanceBindingSource
            // 
            memberAttendanceBindingSource.DataSource = typeof(Models.MemberAttendances);
            // 
            // cuiPanel2
            // 
            cuiPanel2.Controls.Add(panel1);
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
            cuiPanel2.Size = new Size(765, 47);
            cuiPanel2.TabIndex = 16;
            // 
            // panel1
            // 
            panel1.Controls.Add(cuiButtonGroup2);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(359, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(92, 37);
            panel1.TabIndex = 17;
            // 
            // cuiButtonGroup2
            // 
            cuiButtonGroup2.Anchor = AnchorStyles.None;
            cuiButtonGroup2.AutoSize = true;
            cuiButtonGroup2.BackColor = Color.Transparent;
            cuiButtonGroup2.Checked = false;
            cuiButtonGroup2.CheckedBackground = Color.White;
            cuiButtonGroup2.CheckedForeColor = Color.Black;
            cuiButtonGroup2.CheckedImageTint = Color.White;
            cuiButtonGroup2.CheckedOutline = Color.Transparent;
            cuiButtonGroup2.Content = "Scan QR";
            cuiButtonGroup2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
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
            cuiButtonGroup2.Location = new Point(13, 3);
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
            cuiButtonGroup2.Size = new Size(74, 30);
            cuiButtonGroup2.TabIndex = 24;
            cuiButtonGroup2.TextAlignment = StringAlignment.Center;
            cuiButtonGroup2.TextOffset = new Point(0, 0);
            cuiButtonGroup2.Click += cuiButtonGroup2_Click;
            // 
            // cuiPanel7
            // 
            cuiPanel7.Controls.Add(cuiPictureBox1);
            cuiPanel7.Controls.Add(searchBarAttendance);
            cuiPanel7.Dock = DockStyle.Right;
            cuiPanel7.Location = new Point(451, 5);
            cuiPanel7.Margin = new Padding(3, 2, 3, 2);
            cuiPanel7.Name = "cuiPanel7";
            cuiPanel7.OutlineThickness = 0F;
            cuiPanel7.PanelColor = Color.FromArgb(248, 250, 252);
            cuiPanel7.PanelOutlineColor = Color.FromArgb(248, 250, 252);
            cuiPanel7.Rounding = new Padding(8, 8, 0, 0);
            cuiPanel7.Size = new Size(309, 37);
            cuiPanel7.TabIndex = 34;
            // 
            // cuiPictureBox1
            // 
            cuiPictureBox1.BackColor = Color.White;
            cuiPictureBox1.BackgroundImage = (Image)resources.GetObject("cuiPictureBox1.BackgroundImage");
            cuiPictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            cuiPictureBox1.Content = null;
            cuiPictureBox1.ImageTint = Color.White;
            cuiPictureBox1.Location = new Point(20, 10);
            cuiPictureBox1.Margin = new Padding(4, 3, 4, 3);
            cuiPictureBox1.Name = "cuiPictureBox1";
            cuiPictureBox1.OutlineThickness = 1F;
            cuiPictureBox1.PanelOutlineColor = Color.Empty;
            cuiPictureBox1.Rotation = 0;
            cuiPictureBox1.Rounding = new Padding(8);
            cuiPictureBox1.Size = new Size(27, 21);
            cuiPictureBox1.TabIndex = 16;
            // 
            // searchBarAttendance
            // 
            searchBarAttendance.AutoSize = true;
            searchBarAttendance.BackColor = Color.Transparent;
            searchBarAttendance.BackgroundColor = Color.White;
            searchBarAttendance.BorderColor = Color.FromArgb(50, 81, 88);
            searchBarAttendance.Content = "";
            searchBarAttendance.FocusBackgroundColor = Color.White;
            searchBarAttendance.FocusBorderColor = Color.FromArgb(50, 81, 88);
            searchBarAttendance.FocusImageTint = Color.White;
            searchBarAttendance.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchBarAttendance.ForeColor = Color.Black;
            searchBarAttendance.Image = null;
            searchBarAttendance.ImageExpand = new Point(10, 10);
            searchBarAttendance.ImageOffset = new Point(250, 0);
            searchBarAttendance.Location = new Point(10, 2);
            searchBarAttendance.Margin = new Padding(0);
            searchBarAttendance.Multiline = false;
            searchBarAttendance.Name = "searchBarAttendance";
            searchBarAttendance.NormalImageTint = Color.White;
            searchBarAttendance.Padding = new Padding(44, 10, 44, 0);
            searchBarAttendance.PasswordChar = false;
            searchBarAttendance.PlaceholderColor = Color.DimGray;
            searchBarAttendance.PlaceholderText = "Search...";
            searchBarAttendance.Rounding = new Padding(10);
            searchBarAttendance.Size = new Size(296, 35);
            searchBarAttendance.TabIndex = 15;
            searchBarAttendance.TabStop = false;
            searchBarAttendance.TextOffset = new Size(30, 0);
            searchBarAttendance.UnderlinedStyle = false;
            searchBarAttendance.ContentChanged += searchBarAttendance_ContentChanged;
            // 
            // Dashboar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 413);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dashboar";
            Text = "dash";
            Load += Dashboar_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            cuiPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)attendanceDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)memberAttendanceBindingSource).EndInit();
            cuiPanel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            cuiPanel7.ResumeLayout(false);
            cuiPanel7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private CuoreUI.Controls.cuiPanel cuiPanel1;
        private Zuby.ADGV.AdvancedDataGridView attendanceDataGridView;
        private CuoreUI.Controls.cuiPanel cuiPanel2;
        private CuoreUI.Controls.cuiPanel cuiPanel7;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox1;
        private CuoreUI.Controls.cuiTextBox searchBarAttendance;
        private CuoreUI.Controls.cuiButtonGroup cuiButtonGroup2;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private BindingSource memberAttendanceBindingSource;
        private DataGridViewTextBoxColumn createdDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn memberIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn PhoneNumber;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn MembershipType;
        private DataGridViewTextBoxColumn AttendanceDate;
        private DataGridViewTextBoxColumn checkInTimeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn StartDate;
        private DataGridViewTextBoxColumn EndDate;
        private DataGridViewTextBoxColumn checkOutTimeDataGridViewTextBoxColumn;
    }
}