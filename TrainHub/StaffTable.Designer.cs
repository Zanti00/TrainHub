
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffTable));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
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
            dataGridView2 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column11d = new DataGridViewImageColumn();
            Column12 = new DataGridViewImageColumn();
            cuiPanel1 = new CuoreUI.Controls.cuiPanel();
            cuiPanel3 = new CuoreUI.Controls.cuiPanel();
            addStaffBtn = new CuoreUI.Controls.cuiButtonGroup();
            flowLayoutPanel1 = new FlowLayoutPanel();
            cuiPanel2.SuspendLayout();
            cuiPanel4.SuspendLayout();
            cuiPanel7.SuspendLayout();
            cuiPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            cuiPanel1.SuspendLayout();
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
            searchTextBox.ContentChanged += searchTextBox_ContentChanged;
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
            sortBtn.Click += sortBtn_Click;
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
            // dataGridView2
            // 
            dataGridView2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 250, 252);
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column11d, Column12 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView2.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.GridColor = SystemColors.HighlightText;
            dataGridView2.Location = new Point(38, 165);
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
            dataGridView2.Size = new Size(878, 375);
            dataGridView2.TabIndex = 35;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // Column1
            // 
            Column1.FillWeight = 120F;
            Column1.Frozen = true;
            Column1.HeaderText = "Trainer ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 130;
            // 
            // Column2
            // 
            Column2.HeaderText = "Name";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Email Address";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Contact No.";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Date of birth";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.HeaderText = "Address";
            Column6.MinimumWidth = 10;
            Column6.Name = "Column6";
            Column6.Width = 125;
            // 
            // Column11d
            // 
            Column11d.HeaderText = "Edit";
            Column11d.Image = (Image)resources.GetObject("Column11d.Image");
            Column11d.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Column11d.MinimumWidth = 6;
            Column11d.Name = "Column11d";
            Column11d.Resizable = DataGridViewTriState.True;
            Column11d.SortMode = DataGridViewColumnSortMode.Automatic;
            Column11d.Width = 125;
            // 
            // Column12
            // 
            Column12.HeaderText = "Delete";
            Column12.Image = (Image)resources.GetObject("Column12.Image");
            Column12.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Column12.MinimumWidth = 6;
            Column12.Name = "Column12";
            Column12.Resizable = DataGridViewTriState.True;
            Column12.SortMode = DataGridViewColumnSortMode.Automatic;
            Column12.Width = 125;
            // 
            // cuiPanel1
            // 
            cuiPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cuiPanel1.Controls.Add(dataGridView2);
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
            addStaffBtn.BackColor = Color.Transparent;
            addStaffBtn.Checked = false;
            addStaffBtn.CheckedBackground = Color.White;
            addStaffBtn.CheckedForeColor = Color.Black;
            addStaffBtn.CheckedImageTint = Color.White;
            addStaffBtn.CheckedOutline = Color.Transparent;
            addStaffBtn.Content = "+ Add Staff";
            addStaffBtn.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addStaffBtn.ForeColor = Color.White;
            addStaffBtn.Group = 0;
            addStaffBtn.HoverBackground = Color.Transparent;
            addStaffBtn.HoveredImageTint = Color.Transparent;
            addStaffBtn.HoverForeColor = Color.Black;
            addStaffBtn.HoverOutline = Color.White;
            addStaffBtn.Image = null;
            addStaffBtn.ImageAutoCenter = true;
            addStaffBtn.ImageExpand = new Point(0, 0);
            addStaffBtn.ImageOffset = new Point(0, 0);
            addStaffBtn.Location = new Point(22, 8);
            addStaffBtn.Name = "addStaffBtn";
            addStaffBtn.NormalBackground = Color.FromArgb(50, 81, 88);
            addStaffBtn.NormalForeColor = Color.White;
            addStaffBtn.NormalImageTint = Color.Black;
            addStaffBtn.NormalOutline = Color.Transparent;
            addStaffBtn.OutlineThickness = 1F;
            addStaffBtn.PressedBackground = Color.White;
            addStaffBtn.PressedForeColor = Color.White;
            addStaffBtn.PressedImageTint = Color.White;
            addStaffBtn.PressedOutline = Color.White;
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
            cuiPanel2.ResumeLayout(false);
            cuiPanel4.ResumeLayout(false);
            cuiPanel4.PerformLayout();
            cuiPanel7.ResumeLayout(false);
            cuiPanel7.PerformLayout();
            cuiPanel8.ResumeLayout(false);
            cuiPanel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            cuiPanel1.ResumeLayout(false);
            cuiPanel1.PerformLayout();
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
        private DataGridView dataGridView2;
        private CuoreUI.Controls.cuiPanel cuiPanel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private CuoreUI.Controls.cuiPanel cuiPanel3;
        private CuoreUI.Controls.cuiButtonGroup addStaffBtn;
        private CuoreUI.Controls.cuiPanel cuiPanel4;
        private CuoreUI.Controls.cuiTextBox searchTextBox;
        private CuoreUI.Controls.cuiButtonGroup sortBtn;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewImageColumn Column11d;
        private DataGridViewImageColumn Column12;
    }
}