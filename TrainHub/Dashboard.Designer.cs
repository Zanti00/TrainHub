namespace TrainHub
{
    partial class Dashboard
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            tableLayoutPanel1 = new TableLayoutPanel();
            cuiPanel1 = new CuoreUI.Controls.cuiPanel();
            advancedDataGridView1 = new Zuby.ADGV.AdvancedDataGridView();
            Edit = new DataGridViewImageColumn();
            Delete = new DataGridViewImageColumn();
            cuiPanel2 = new CuoreUI.Controls.cuiPanel();
            cuiPanel7 = new CuoreUI.Controls.cuiPanel();
            cuiPictureBox1 = new CuoreUI.Controls.cuiPictureBox();
            searchBar = new CuoreUI.Controls.cuiTextBox();
            cuiPanel3 = new CuoreUI.Controls.cuiPanel();
            cuiPanel6 = new CuoreUI.Controls.cuiPanel();
            label2 = new Label();
            label1 = new Label();
            cuiPanel5 = new CuoreUI.Controls.cuiPanel();
            cuiPanel9 = new CuoreUI.Controls.cuiPanel();
            label6 = new Label();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            cuiPanel4 = new CuoreUI.Controls.cuiPanel();
            label4 = new Label();
            label3 = new Label();
            cuiPanel8 = new CuoreUI.Controls.cuiPanel();
            cuiChartLine1 = new CuoreUI.Controls.Charts.cuiChartLine();
            tableLayoutPanel1.SuspendLayout();
            cuiPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)advancedDataGridView1).BeginInit();
            cuiPanel2.SuspendLayout();
            cuiPanel7.SuspendLayout();
            cuiPanel3.SuspendLayout();
            cuiPanel6.SuspendLayout();
            cuiPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            cuiPanel4.SuspendLayout();
            cuiPanel8.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(cuiPanel1, 0, 0);
            tableLayoutPanel1.Location = new Point(19, 486);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(11, 0, 11, 0);
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1014, 207);
            tableLayoutPanel1.TabIndex = 9;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // cuiPanel1
            // 
            cuiPanel1.BackColor = Color.Transparent;
            cuiPanel1.Controls.Add(advancedDataGridView1);
            cuiPanel1.Controls.Add(cuiPanel2);
            cuiPanel1.Dock = DockStyle.Fill;
            cuiPanel1.Location = new Point(14, 3);
            cuiPanel1.Margin = new Padding(3, 3, 3, 20);
            cuiPanel1.Name = "cuiPanel1";
            cuiPanel1.OutlineThickness = 1F;
            cuiPanel1.PanelColor = Color.Transparent;
            cuiPanel1.PanelOutlineColor = Color.Transparent;
            cuiPanel1.Rounding = new Padding(8);
            cuiPanel1.Size = new Size(986, 184);
            cuiPanel1.TabIndex = 7;
            // 
            // advancedDataGridView1
            // 
            advancedDataGridView1.AllowUserToAddRows = false;
            advancedDataGridView1.AllowUserToDeleteRows = false;
            advancedDataGridView1.AllowUserToResizeRows = false;
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
            advancedDataGridView1.Columns.AddRange(new DataGridViewColumn[] { Edit, Delete });
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
            advancedDataGridView1.Location = new Point(0, 63);
            advancedDataGridView1.Margin = new Padding(3, 4, 3, 4);
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
            advancedDataGridView1.Size = new Size(986, 121);
            advancedDataGridView1.SortStringChangedInvokeBeforeDatasourceUpdate = false;
            advancedDataGridView1.TabIndex = 17;
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
            Edit.Width = 125;
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
            Delete.Width = 125;
            // 
            // cuiPanel2
            // 
            cuiPanel2.Controls.Add(cuiPanel7);
            cuiPanel2.Dock = DockStyle.Top;
            cuiPanel2.Location = new Point(0, 0);
            cuiPanel2.Name = "cuiPanel2";
            cuiPanel2.OutlineThickness = 1F;
            cuiPanel2.Padding = new Padding(0, 7, 6, 7);
            cuiPanel2.PanelColor = Color.FromArgb(248, 250, 252);
            cuiPanel2.PanelOutlineColor = Color.Black;
            cuiPanel2.Rounding = new Padding(8, 8, 0, 0);
            cuiPanel2.Size = new Size(986, 63);
            cuiPanel2.TabIndex = 16;
            // 
            // cuiPanel7
            // 
            cuiPanel7.Controls.Add(cuiPictureBox1);
            cuiPanel7.Controls.Add(searchBar);
            cuiPanel7.Dock = DockStyle.Right;
            cuiPanel7.Location = new Point(471, 7);
            cuiPanel7.Name = "cuiPanel7";
            cuiPanel7.OutlineThickness = 0F;
            cuiPanel7.PanelColor = Color.FromArgb(248, 250, 252);
            cuiPanel7.PanelOutlineColor = Color.FromArgb(248, 250, 252);
            cuiPanel7.Rounding = new Padding(8, 8, 0, 0);
            cuiPanel7.Size = new Size(509, 49);
            cuiPanel7.TabIndex = 34;
            // 
            // cuiPictureBox1
            // 
            cuiPictureBox1.BackColor = Color.White;
            cuiPictureBox1.BackgroundImage = (Image)resources.GetObject("cuiPictureBox1.BackgroundImage");
            cuiPictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            cuiPictureBox1.Content = null;
            cuiPictureBox1.ImageTint = Color.White;
            cuiPictureBox1.Location = new Point(174, 11);
            cuiPictureBox1.Margin = new Padding(5, 4, 5, 4);
            cuiPictureBox1.Name = "cuiPictureBox1";
            cuiPictureBox1.OutlineThickness = 1F;
            cuiPictureBox1.PanelOutlineColor = Color.Empty;
            cuiPictureBox1.Rotation = 0;
            cuiPictureBox1.Rounding = new Padding(8);
            cuiPictureBox1.Size = new Size(31, 28);
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
            searchBar.Location = new Point(161, 0);
            searchBar.Margin = new Padding(0);
            searchBar.Multiline = false;
            searchBar.Name = "searchBar";
            searchBar.NormalImageTint = Color.White;
            searchBar.Padding = new Padding(47, 15, 47, 0);
            searchBar.PasswordChar = false;
            searchBar.PlaceholderColor = Color.DimGray;
            searchBar.PlaceholderText = "Search...";
            searchBar.Rounding = new Padding(10);
            searchBar.Size = new Size(338, 47);
            searchBar.TabIndex = 15;
            searchBar.TabStop = false;
            searchBar.TextOffset = new Size(30, 0);
            searchBar.UnderlinedStyle = false;
            // 
            // cuiPanel3
            // 
            cuiPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cuiPanel3.Controls.Add(cuiPanel6);
            cuiPanel3.Location = new Point(12, 423);
            cuiPanel3.Name = "cuiPanel3";
            cuiPanel3.OutlineThickness = 1F;
            cuiPanel3.PanelColor = Color.White;
            cuiPanel3.PanelOutlineColor = Color.LightGray;
            cuiPanel3.Rounding = new Padding(8);
            cuiPanel3.Size = new Size(1024, 275);
            cuiPanel3.TabIndex = 26;
            // 
            // cuiPanel6
            // 
            cuiPanel6.Controls.Add(label2);
            cuiPanel6.Controls.Add(label1);
            cuiPanel6.Location = new Point(7, 17);
            cuiPanel6.Name = "cuiPanel6";
            cuiPanel6.OutlineThickness = 0F;
            cuiPanel6.PanelColor = Color.White;
            cuiPanel6.PanelOutlineColor = Color.White;
            cuiPanel6.Rounding = new Padding(8, 8, 0, 0);
            cuiPanel6.Size = new Size(558, 58);
            cuiPanel6.TabIndex = 35;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(16, 22);
            label2.Name = "label2";
            label2.Size = new Size(194, 20);
            label2.TabIndex = 28;
            label2.Text = "View and Manage Members";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(51, 81, 88);
            label1.Location = new Point(16, 0);
            label1.Name = "label1";
            label1.Size = new Size(248, 25);
            label1.TabIndex = 27;
            label1.Text = "Nearly Expired Members";
            // 
            // cuiPanel5
            // 
            cuiPanel5.Controls.Add(cuiPanel9);
            cuiPanel5.Controls.Add(label6);
            cuiPanel5.Controls.Add(label5);
            cuiPanel5.Controls.Add(pictureBox1);
            cuiPanel5.Location = new Point(12, 150);
            cuiPanel5.Name = "cuiPanel5";
            cuiPanel5.OutlineThickness = 1F;
            cuiPanel5.PanelColor = Color.FromArgb(51, 81, 88);
            cuiPanel5.PanelOutlineColor = Color.FromArgb(51, 81, 88);
            cuiPanel5.Rounding = new Padding(8);
            cuiPanel5.Size = new Size(363, 267);
            cuiPanel5.TabIndex = 28;
            // 
            // cuiPanel9
            // 
            cuiPanel9.Location = new Point(0, 221);
            cuiPanel9.Name = "cuiPanel9";
            cuiPanel9.OutlineThickness = 1F;
            cuiPanel9.PanelColor = Color.White;
            cuiPanel9.PanelOutlineColor = Color.LightGray;
            cuiPanel9.Rounding = new Padding(0, 0, 8, 8);
            cuiPanel9.Size = new Size(363, 46);
            cuiPanel9.TabIndex = 29;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Microsoft Sans Serif", 55.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(160, 78);
            label6.Name = "label6";
            label6.Size = new Size(200, 104);
            label6.TabIndex = 32;
            label6.Text = "100";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(176, 182);
            label5.Name = "label5";
            label5.Size = new Size(170, 18);
            label5.TabIndex = 31;
            label5.Text = "Nearly Expired Members";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(21, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(102, 67);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 30;
            pictureBox1.TabStop = false;
            // 
            // cuiPanel4
            // 
            cuiPanel4.Controls.Add(label4);
            cuiPanel4.Controls.Add(label3);
            cuiPanel4.Location = new Point(12, 12);
            cuiPanel4.Name = "cuiPanel4";
            cuiPanel4.OutlineThickness = 1F;
            cuiPanel4.PanelColor = Color.White;
            cuiPanel4.PanelOutlineColor = Color.LightGray;
            cuiPanel4.Rounding = new Padding(8);
            cuiPanel4.Size = new Size(363, 132);
            cuiPanel4.TabIndex = 27;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(51, 81, 88);
            label4.Location = new Point(19, 68);
            label4.Name = "label4";
            label4.Size = new Size(219, 23);
            label4.TabIndex = 29;
            label4.Text = "All systems are operational.";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(51, 81, 88);
            label3.Location = new Point(19, 39);
            label3.Name = "label3";
            label3.Size = new Size(278, 29);
            label3.TabIndex = 28;
            label3.Text = "Welcome back, Admin!";
            // 
            // cuiPanel8
            // 
            cuiPanel8.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cuiPanel8.Controls.Add(cuiChartLine1);
            cuiPanel8.Location = new Point(381, 12);
            cuiPanel8.Name = "cuiPanel8";
            cuiPanel8.OutlineThickness = 1F;
            cuiPanel8.PanelColor = Color.White;
            cuiPanel8.PanelOutlineColor = Color.LightGray;
            cuiPanel8.Rounding = new Padding(8);
            cuiPanel8.Size = new Size(655, 405);
            cuiPanel8.TabIndex = 29;
            // 
            // cuiChartLine1
            // 
            cuiChartLine1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cuiChartLine1.AutoMaxValue = false;
            cuiChartLine1.AxisColor = Color.Gray;
            cuiChartLine1.BackColor = Color.White;
            cuiChartLine1.ChartLineColor = Color.FromArgb(51, 81, 88);
            cuiChartLine1.ChartPadding = 40;
            cuiChartLine1.DataPoints = new float[]
    {
    100F,
    90F,
    80F,
    75F,
    70F,
    65F,
    60F
    };
            cuiChartLine1.DayColor = Color.FromArgb(51, 81, 88);
            cuiChartLine1.Font = new Font("Microsoft YaHei UI", 8.25F);
            cuiChartLine1.GradientBackground = true;
            cuiChartLine1.Location = new Point(4, 5);
            cuiChartLine1.Margin = new Padding(4, 5, 4, 5);
            cuiChartLine1.MaxValue = 100F;
            cuiChartLine1.Name = "cuiChartLine1";
            cuiChartLine1.PointColor = Color.FromArgb(51, 81, 88);
            cuiChartLine1.ShortDates = true;
            cuiChartLine1.ShowLines = true;
            cuiChartLine1.Size = new Size(647, 395);
            cuiChartLine1.TabIndex = 0;
            cuiChartLine1.UseBezier = false;
            cuiChartLine1.UsePercent = true;
            // 
            // Dashboard
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1045, 706);
            ControlBox = false;
            Controls.Add(cuiPanel5);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(cuiPanel8);
            Controls.Add(cuiPanel4);
            Controls.Add(cuiPanel3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            tableLayoutPanel1.ResumeLayout(false);
            cuiPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)advancedDataGridView1).EndInit();
            cuiPanel2.ResumeLayout(false);
            cuiPanel7.ResumeLayout(false);
            cuiPanel7.PerformLayout();
            cuiPanel3.ResumeLayout(false);
            cuiPanel6.ResumeLayout(false);
            cuiPanel6.PerformLayout();
            cuiPanel5.ResumeLayout(false);
            cuiPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            cuiPanel4.ResumeLayout(false);
            cuiPanel4.PerformLayout();
            cuiPanel8.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private CuoreUI.Controls.cuiPanel cuiPanel1;
        private Zuby.ADGV.AdvancedDataGridView advancedDataGridView1;
        private DataGridViewImageColumn Edit;
        private DataGridViewImageColumn Delete;
        private CuoreUI.Controls.cuiPanel cuiPanel2;
        private CuoreUI.Controls.cuiPanel cuiPanel7;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox1;
        private CuoreUI.Controls.cuiTextBox searchBar;
        private CuoreUI.Controls.cuiPanel cuiPanel3;
        private Label label1;
        private CuoreUI.Controls.cuiPanel cuiPanel4;
        private CuoreUI.Controls.cuiPanel cuiPanel5;
        private CuoreUI.Controls.cuiPanel cuiPanel8;
        private CuoreUI.Controls.cuiPanel cuiPanel6;
        private Label label2;
        private Label label4;
        private Label label3;
        private CuoreUI.Controls.Charts.cuiChartLine cuiChartLine1;
        private Label label6;
        private Label label5;
        private PictureBox pictureBox1;
        private CuoreUI.Controls.cuiPanel cuiPanel9;
    }
}