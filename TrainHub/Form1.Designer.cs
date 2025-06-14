namespace TrainHub
{
    partial class Form1
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
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new TableLayoutPanel();
            this.panel1 = new Panel();
            label3 = new Label();
            this.label1 = new Label();
            this.label2 = new Label();
            this.cuiPanel1 = new CuoreUI.Controls.cuiPanel();
            advancedDataGridView1 = new Zuby.ADGV.AdvancedDataGridView();
            Edit = new DataGridViewImageColumn();
            Delete = new DataGridViewImageColumn();
            cuiPanel2 = new CuoreUI.Controls.cuiPanel();
            cuiPanel7 = new CuoreUI.Controls.cuiPanel();
            cuiPictureBox1 = new CuoreUI.Controls.cuiPictureBox();
            searchBar = new CuoreUI.Controls.cuiTextBox();
            cuiPanel8 = new CuoreUI.Controls.cuiPanel();
            cuiButtonGroup2 = new CuoreUI.Controls.cuiButtonGroup();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.cuiPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)advancedDataGridView1).BeginInit();
            cuiPanel2.SuspendLayout();
            cuiPanel7.SuspendLayout();
            cuiPanel8.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cuiPanel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(cuiPanel8, 0, 1);
            this.tableLayoutPanel1.Dock = DockStyle.Fill;
            this.tableLayoutPanel1.Location = new Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new Padding(10, 0, 10, 0);
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            this.tableLayoutPanel1.Size = new Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = DockStyle.Left;
            this.panel1.Location = new Point(13, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(200, 39);
            this.panel1.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(51, 81, 88);
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(87, 24);
            label3.TabIndex = 26;
            label3.Text = "Trainers\r\n";
            // 
            // label1
            // 
            this.label1.Anchor = AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = Color.Transparent;
            this.label1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.label1.ForeColor = Color.FromArgb(51, 81, 88);
            this.label1.Location = new Point(0, -30);
            this.label1.Name = "label1";
            this.label1.Size = new Size(97, 24);
            this.label1.TabIndex = 24;
            this.label1.Text = "Members";
            // 
            // label2
            // 
            this.label2.Anchor = AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = Color.Transparent;
            this.label2.ForeColor = Color.Gray;
            this.label2.Location = new Point(-1, 24);
            this.label2.Name = "label2";
            this.label2.Size = new Size(154, 15);
            this.label2.TabIndex = 25;
            this.label2.Text = "View and Manage Members";
            // 
            // cuiPanel1
            // 
            this.cuiPanel1.BackColor = Color.Transparent;
            this.cuiPanel1.Controls.Add(advancedDataGridView1);
            this.cuiPanel1.Controls.Add(cuiPanel2);
            this.cuiPanel1.Dock = DockStyle.Fill;
            this.cuiPanel1.Location = new Point(13, 92);
            this.cuiPanel1.Margin = new Padding(3, 2, 3, 15);
            this.cuiPanel1.Name = "cuiPanel1";
            this.cuiPanel1.OutlineThickness = 1F;
            this.cuiPanel1.PanelColor = Color.Transparent;
            this.cuiPanel1.PanelOutlineColor = Color.Transparent;
            this.cuiPanel1.Rounding = new Padding(8);
            this.cuiPanel1.Size = new Size(774, 343);
            this.cuiPanel1.TabIndex = 7;
            // 
            // advancedDataGridView1
            // 
            advancedDataGridView1.AllowUserToAddRows = false;
            advancedDataGridView1.AllowUserToDeleteRows = false;
            advancedDataGridView1.AllowUserToResizeRows = false;
            advancedDataGridView1.BackgroundColor = Color.White;
            advancedDataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(50, 81, 88);
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            advancedDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            advancedDataGridView1.ColumnHeadersHeight = 40;
            advancedDataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            advancedDataGridView1.Columns.AddRange(new DataGridViewColumn[] { Edit, Delete });
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = SystemColors.Window;
            dataGridViewCellStyle10.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle10.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = Color.FromArgb(50, 81, 88);
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.False;
            advancedDataGridView1.DefaultCellStyle = dataGridViewCellStyle10;
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
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = SystemColors.ButtonFace;
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle11.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = Color.FromArgb(50, 81, 88);
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            advancedDataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            advancedDataGridView1.RowHeadersVisible = false;
            advancedDataGridView1.RowHeadersWidth = 120;
            dataGridViewCellStyle12.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle12.ForeColor = Color.Black;
            dataGridViewCellStyle12.Padding = new Padding(0, 5, 0, 5);
            dataGridViewCellStyle12.SelectionBackColor = Color.FromArgb(50, 81, 88);
            advancedDataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle12;
            advancedDataGridView1.RowTemplate.Height = 40;
            advancedDataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            advancedDataGridView1.Size = new Size(774, 296);
            advancedDataGridView1.SortStringChangedInvokeBeforeDatasourceUpdate = false;
            advancedDataGridView1.TabIndex = 17;
            advancedDataGridView1.CellContentClick += advancedDataGridView1_CellContentClick;
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
            cuiPanel2.Size = new Size(774, 47);
            cuiPanel2.TabIndex = 16;
            // 
            // cuiPanel7
            // 
            cuiPanel7.Controls.Add(cuiPictureBox1);
            cuiPanel7.Controls.Add(searchBar);
            cuiPanel7.Dock = DockStyle.Right;
            cuiPanel7.Location = new Point(324, 5);
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
            // cuiPanel8
            // 
            cuiPanel8.BackColor = Color.Transparent;
            cuiPanel8.Controls.Add(cuiButtonGroup2);
            cuiPanel8.Dock = DockStyle.Right;
            cuiPanel8.Location = new Point(638, 47);
            cuiPanel8.Margin = new Padding(3, 2, 3, 2);
            cuiPanel8.Name = "cuiPanel8";
            cuiPanel8.OutlineThickness = 1F;
            cuiPanel8.PanelColor = Color.Transparent;
            cuiPanel8.PanelOutlineColor = Color.Transparent;
            cuiPanel8.Rounding = new Padding(8, 8, 0, 0);
            cuiPanel8.Size = new Size(149, 41);
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(this.tableLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.cuiPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)advancedDataGridView1).EndInit();
            cuiPanel2.ResumeLayout(false);
            cuiPanel7.ResumeLayout(false);
            cuiPanel7.PerformLayout();
            cuiPanel8.ResumeLayout(false);
            cuiPanel8.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Zuby.ADGV.AdvancedDataGridView advancedDataGridView1;
        private DataGridViewImageColumn Edit;
        private DataGridViewImageColumn Delete;
        private CuoreUI.Controls.cuiPanel cuiPanel2;
        private CuoreUI.Controls.cuiPanel cuiPanel7;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox1;
        private CuoreUI.Controls.cuiTextBox searchBar;
        private CuoreUI.Controls.cuiPanel cuiPanel8;
        private CuoreUI.Controls.cuiButtonGroup cuiButtonGroup2;
        private Label label3;
    }
}