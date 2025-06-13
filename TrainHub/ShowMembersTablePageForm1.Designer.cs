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
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
            dataGridViewCheckBoxColumn1 = new DataGridViewCheckBoxColumn();
            dataGridViewTextBoxColumn11 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn12 = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewImageColumn();
            Delete = new DataGridViewImageColumn();
            memberBindingSource = new BindingSource(components);
            cuiPanel2 = new CuoreUI.Controls.cuiPanel();
            cuiPanel7 = new CuoreUI.Controls.cuiPanel();
            cuiPictureBox1 = new CuoreUI.Controls.cuiPictureBox();
            searchBar = new CuoreUI.Controls.cuiTextBox();
            label2 = new Label();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            cuiPanel8 = new CuoreUI.Controls.cuiPanel();
            cuiButtonGroup2 = new CuoreUI.Controls.cuiButtonGroup();
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
            cuiPanel1.Margin = new Padding(3, 2, 3, 2);
            cuiPanel1.Name = "cuiPanel1";
            cuiPanel1.OutlineThickness = 1F;
            cuiPanel1.PanelColor = Color.Transparent;
            cuiPanel1.PanelOutlineColor = Color.Transparent;
            cuiPanel1.Rounding = new Padding(8);
            cuiPanel1.Size = new Size(778, 346);
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
            advancedDataGridView1.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8, dataGridViewTextBoxColumn9, dataGridViewTextBoxColumn10, dataGridViewCheckBoxColumn1, dataGridViewTextBoxColumn11, dataGridViewTextBoxColumn12, Edit, Delete });
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
            advancedDataGridView1.Size = new Size(778, 299);
            advancedDataGridView1.SortStringChangedInvokeBeforeDatasourceUpdate = false;
            advancedDataGridView1.TabIndex = 17;
            advancedDataGridView1.CellClick += dataGridView2_CellClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            dataGridViewTextBoxColumn1.HeaderText = "Member ID";
            dataGridViewTextBoxColumn1.MinimumWidth = 24;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "FirstName";
            dataGridViewTextBoxColumn2.HeaderText = "First Name";
            dataGridViewTextBoxColumn2.MinimumWidth = 24;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.SortMode = DataGridViewColumnSortMode.Programmatic;
            dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "LastName";
            dataGridViewTextBoxColumn3.HeaderText = "Last Name";
            dataGridViewTextBoxColumn3.MinimumWidth = 24;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.SortMode = DataGridViewColumnSortMode.Programmatic;
            dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "Email";
            dataGridViewTextBoxColumn4.HeaderText = "Email";
            dataGridViewTextBoxColumn4.MinimumWidth = 24;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.SortMode = DataGridViewColumnSortMode.Programmatic;
            dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "PhoneNumber";
            dataGridViewTextBoxColumn5.HeaderText = "Phone Number";
            dataGridViewTextBoxColumn5.MinimumWidth = 24;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            dataGridViewTextBoxColumn5.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.DataPropertyName = "DateOfBirth";
            dataGridViewTextBoxColumn6.HeaderText = "Date of Birth";
            dataGridViewTextBoxColumn6.MinimumWidth = 24;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            dataGridViewTextBoxColumn6.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.DataPropertyName = "StartDate";
            dataGridViewTextBoxColumn7.HeaderText = "Start Date";
            dataGridViewTextBoxColumn7.MinimumWidth = 24;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            dataGridViewTextBoxColumn7.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.DataPropertyName = "EndDate";
            dataGridViewTextBoxColumn8.HeaderText = "End Date";
            dataGridViewTextBoxColumn8.MinimumWidth = 24;
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.ReadOnly = true;
            dataGridViewTextBoxColumn8.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.DataPropertyName = "CreatedDate";
            dataGridViewTextBoxColumn9.HeaderText = "Created Date";
            dataGridViewTextBoxColumn9.MinimumWidth = 24;
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            dataGridViewTextBoxColumn9.ReadOnly = true;
            dataGridViewTextBoxColumn9.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn10
            // 
            dataGridViewTextBoxColumn10.DataPropertyName = "SoftDeleteDate";
            dataGridViewTextBoxColumn10.HeaderText = "Soft Delete Date";
            dataGridViewTextBoxColumn10.MinimumWidth = 24;
            dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            dataGridViewTextBoxColumn10.ReadOnly = true;
            dataGridViewTextBoxColumn10.SortMode = DataGridViewColumnSortMode.Programmatic;
            dataGridViewTextBoxColumn10.Visible = false;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            dataGridViewCheckBoxColumn1.DataPropertyName = "IsDeleted";
            dataGridViewCheckBoxColumn1.HeaderText = "IsDeleted";
            dataGridViewCheckBoxColumn1.MinimumWidth = 24;
            dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            dataGridViewCheckBoxColumn1.ReadOnly = true;
            dataGridViewCheckBoxColumn1.SortMode = DataGridViewColumnSortMode.Programmatic;
            dataGridViewCheckBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn11
            // 
            dataGridViewTextBoxColumn11.DataPropertyName = "Status";
            dataGridViewTextBoxColumn11.HeaderText = "Status";
            dataGridViewTextBoxColumn11.MinimumWidth = 24;
            dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            dataGridViewTextBoxColumn11.ReadOnly = true;
            dataGridViewTextBoxColumn11.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewTextBoxColumn12
            // 
            dataGridViewTextBoxColumn12.DataPropertyName = "MembershipType";
            dataGridViewTextBoxColumn12.HeaderText = "Membership Type";
            dataGridViewTextBoxColumn12.MinimumWidth = 24;
            dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            dataGridViewTextBoxColumn12.ReadOnly = true;
            dataGridViewTextBoxColumn12.SortMode = DataGridViewColumnSortMode.Programmatic;
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
            cuiPanel7.Controls.Add(cuiPictureBox1);
            cuiPanel7.Controls.Add(searchBar);
            cuiPanel7.Dock = DockStyle.Right;
            cuiPanel7.Location = new Point(328, 5);
            cuiPanel7.Margin = new Padding(3, 2, 3, 2);
            cuiPanel7.Name = "cuiPanel7";
            cuiPanel7.OutlineThickness = 0F;
            cuiPanel7.PanelColor = Color.FromArgb(248, 250, 252);
            cuiPanel7.PanelOutlineColor = Color.FromArgb(248, 250, 252);
            cuiPanel7.Rounding = new Padding(8, 8, 0, 0);
            cuiPanel7.Size = new Size(445, 37);
            cuiPanel7.TabIndex = 34;
            // 
            // cuiPictureBox1
            // 
            cuiPictureBox1.BackColor = Color.White;
            cuiPictureBox1.BackgroundImage = (Image)resources.GetObject("cuiPictureBox1.BackgroundImage");
            cuiPictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            cuiPictureBox1.Content = null;
            cuiPictureBox1.ImageTint = Color.White;
            cuiPictureBox1.Location = new Point(152, 8);
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
            searchBar.Location = new Point(141, 0);
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
            // ShowMembersTablePageForm1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 436);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ShowMembersTablePageForm1";
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
        private DataGridViewImageColumn Edit;
        private DataGridViewImageColumn Delete;
    }
}