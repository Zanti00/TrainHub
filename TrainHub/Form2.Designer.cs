namespace TrainHub
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            label1 = new Label();
            label2 = new Label();
            cuiPanel7 = new CuoreUI.Controls.cuiPanel();
            cuiTextBox4 = new CuoreUI.Controls.cuiTextBox();
            cuiButtonGroup1 = new CuoreUI.Controls.cuiButtonGroup();
            cuiPanel8 = new CuoreUI.Controls.cuiPanel();
            cuiButtonGroup2 = new CuoreUI.Controls.cuiButtonGroup();
            cuiPanel1 = new CuoreUI.Controls.cuiPanel();
            cuiButtonGroup3 = new CuoreUI.Controls.cuiButtonGroup();
            dataGridView2 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column11d = new DataGridViewImageColumn();
            Column12 = new DataGridViewImageColumn();
            cuiPanel2 = new CuoreUI.Controls.cuiPanel();
            cuiButtonGroup4 = new CuoreUI.Controls.cuiButtonGroup();
            cuiTextBox1 = new CuoreUI.Controls.cuiTextBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            cuiPanel7.SuspendLayout();
            cuiPanel8.SuspendLayout();
            cuiPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            cuiPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(51, 81, 88);
            label1.Location = new Point(34, 44);
            label1.Name = "label1";
            label1.Size = new Size(87, 24);
            label1.TabIndex = 24;
            label1.Text = "Trainers\r\n";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(34, 65);
            label2.Name = "label2";
            label2.Size = new Size(144, 15);
            label2.TabIndex = 25;
            label2.Text = "View and Manage Trainers";
            // 
            // cuiPanel7
            // 
            cuiPanel7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cuiPanel7.Controls.Add(cuiTextBox4);
            cuiPanel7.Controls.Add(cuiButtonGroup1);
            cuiPanel7.Location = new Point(1452, 118);
            cuiPanel7.Margin = new Padding(3, 2, 3, 2);
            cuiPanel7.Name = "cuiPanel7";
            cuiPanel7.OutlineThickness = 1F;
            cuiPanel7.PanelColor = Color.FromArgb(248, 250, 252);
            cuiPanel7.PanelOutlineColor = Color.FromArgb(248, 250, 252);
            cuiPanel7.Rounding = new Padding(8, 8, 0, 0);
            cuiPanel7.Size = new Size(433, 43);
            cuiPanel7.TabIndex = 33;
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
            cuiTextBox4.Padding = new Padding(14, 9, 14, 0);
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
            // cuiPanel8
            // 
            cuiPanel8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cuiPanel8.BackColor = Color.White;
            cuiPanel8.Controls.Add(cuiButtonGroup2);
            cuiPanel8.Location = new Point(1749, 62);
            cuiPanel8.Margin = new Padding(3, 2, 3, 2);
            cuiPanel8.Name = "cuiPanel8";
            cuiPanel8.OutlineThickness = 1F;
            cuiPanel8.PanelColor = Color.White;
            cuiPanel8.PanelOutlineColor = Color.White;
            cuiPanel8.Rounding = new Padding(8, 8, 0, 0);
            cuiPanel8.Size = new Size(149, 43);
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
            // cuiPanel1
            // 
            cuiPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cuiPanel1.Controls.Add(cuiButtonGroup3);
            cuiPanel1.Controls.Add(dataGridView2);
            cuiPanel1.Controls.Add(cuiPanel2);
            cuiPanel1.Controls.Add(cuiPanel8);
            cuiPanel1.Controls.Add(cuiPanel7);
            cuiPanel1.Controls.Add(label2);
            cuiPanel1.Controls.Add(label1);
            cuiPanel1.Location = new Point(275, 43);
            cuiPanel1.Margin = new Padding(3, 2, 3, 2);
            cuiPanel1.Name = "cuiPanel1";
            cuiPanel1.OutlineThickness = 1F;
            cuiPanel1.PanelColor = Color.White;
            cuiPanel1.PanelOutlineColor = Color.Black;
            cuiPanel1.Rounding = new Padding(8);
            cuiPanel1.Size = new Size(1067, 571);
            cuiPanel1.TabIndex = 9;
            // 
            // cuiButtonGroup3
            // 
            cuiButtonGroup3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cuiButtonGroup3.BackColor = Color.Transparent;
            cuiButtonGroup3.Checked = false;
            cuiButtonGroup3.CheckedBackground = Color.White;
            cuiButtonGroup3.CheckedForeColor = Color.Black;
            cuiButtonGroup3.CheckedImageTint = Color.White;
            cuiButtonGroup3.CheckedOutline = Color.Transparent;
            cuiButtonGroup3.Content = "+ Add Trainer";
            cuiButtonGroup3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiButtonGroup3.ForeColor = Color.Black;
            cuiButtonGroup3.Group = 0;
            cuiButtonGroup3.HoverBackground = Color.LightGray;
            cuiButtonGroup3.HoveredImageTint = Color.Transparent;
            cuiButtonGroup3.HoverForeColor = Color.Black;
            cuiButtonGroup3.HoverOutline = Color.White;
            cuiButtonGroup3.Image = null;
            cuiButtonGroup3.ImageAutoCenter = true;
            cuiButtonGroup3.ImageExpand = new Point(0, 0);
            cuiButtonGroup3.ImageOffset = new Point(0, 0);
            cuiButtonGroup3.Location = new Point(923, 72);
            cuiButtonGroup3.Name = "cuiButtonGroup3";
            cuiButtonGroup3.NormalBackground = Color.White;
            cuiButtonGroup3.NormalForeColor = Color.Black;
            cuiButtonGroup3.NormalImageTint = Color.Black;
            cuiButtonGroup3.NormalOutline = Color.Transparent;
            cuiButtonGroup3.OutlineThickness = 1F;
            cuiButtonGroup3.PressedBackground = Color.White;
            cuiButtonGroup3.PressedForeColor = Color.White;
            cuiButtonGroup3.PressedImageTint = Color.White;
            cuiButtonGroup3.PressedOutline = Color.White;
            cuiButtonGroup3.Rounding = new Padding(10);
            cuiButtonGroup3.Size = new Size(113, 32);
            cuiButtonGroup3.TabIndex = 38;
            cuiButtonGroup3.TextAlignment = StringAlignment.Center;
            cuiButtonGroup3.TextOffset = new Point(0, 0);
            cuiButtonGroup3.Click += cuiButtonGroup3_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = Color.FromArgb(248, 250, 252);
            dataGridViewCellStyle13.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle13.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = Color.White;
            dataGridViewCellStyle13.SelectionForeColor = Color.Black;
            dataGridViewCellStyle13.WrapMode = DataGridViewTriState.True;
            dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column11d, Column12 });
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = SystemColors.Window;
            dataGridViewCellStyle14.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle14.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle14.SelectionForeColor = Color.Black;
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.False;
            dataGridView2.DefaultCellStyle = dataGridViewCellStyle14;
            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.GridColor = SystemColors.HighlightText;
            dataGridView2.Location = new Point(34, 174);
            dataGridView2.Margin = new Padding(3, 2, 3, 2);
            dataGridView2.Name = "dataGridView2";
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = SystemColors.Control;
            dataGridViewCellStyle15.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle15.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle15.Padding = new Padding(5, 0, 0, 0);
            dataGridViewCellStyle15.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle15.SelectionForeColor = Color.Black;
            dataGridViewCellStyle15.WrapMode = DataGridViewTriState.True;
            dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.RowHeadersWidth = 51;
            dataGridViewCellStyle16.ForeColor = Color.Black;
            dataGridViewCellStyle16.Padding = new Padding(2, 0, 0, 0);
            dataGridViewCellStyle16.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle16.SelectionForeColor = Color.Black;
            dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle16;
            dataGridView2.RowTemplate.DefaultCellStyle.Padding = new Padding(0, 10, 0, 10);
            dataGridView2.RowTemplate.DividerHeight = 1;
            dataGridView2.RowTemplate.Height = 60;
            dataGridView2.RowTemplate.Resizable = DataGridViewTriState.False;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(1002, 369);
            dataGridView2.TabIndex = 37;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick_1;
            // 
            // Column1
            // 
            Column1.HeaderText = "Trainer ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
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
            Column3.HeaderText = "Email";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Mobile No.";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Date of Birth";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.HeaderText = "Address";
            Column6.MinimumWidth = 6;
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
            Column11d.Resizable = DataGridViewTriState.False;
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
            Column12.Resizable = DataGridViewTriState.False;
            Column12.SortMode = DataGridViewColumnSortMode.Automatic;
            Column12.Width = 125;
            // 
            // cuiPanel2
            // 
            cuiPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cuiPanel2.Controls.Add(cuiButtonGroup4);
            cuiPanel2.Controls.Add(cuiTextBox1);
            cuiPanel2.Location = new Point(34, 109);
            cuiPanel2.Margin = new Padding(3, 2, 3, 2);
            cuiPanel2.Name = "cuiPanel2";
            cuiPanel2.OutlineThickness = 1F;
            cuiPanel2.PanelColor = Color.FromArgb(248, 250, 252);
            cuiPanel2.PanelOutlineColor = Color.Black;
            cuiPanel2.Rounding = new Padding(8, 8, 0, 0);
            cuiPanel2.Size = new Size(1002, 82);
            cuiPanel2.TabIndex = 36;
            // 
            // cuiButtonGroup4
            // 
            cuiButtonGroup4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cuiButtonGroup4.BackColor = Color.Transparent;
            cuiButtonGroup4.Checked = false;
            cuiButtonGroup4.CheckedBackground = Color.FromArgb(50, 81, 88);
            cuiButtonGroup4.CheckedForeColor = Color.White;
            cuiButtonGroup4.CheckedImageTint = Color.White;
            cuiButtonGroup4.CheckedOutline = Color.FromArgb(50, 81, 88);
            cuiButtonGroup4.Content = "  Sort By";
            cuiButtonGroup4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiButtonGroup4.ForeColor = Color.DimGray;
            cuiButtonGroup4.Group = 0;
            cuiButtonGroup4.HoverBackground = Color.FromArgb(51, 81, 88);
            cuiButtonGroup4.HoveredImageTint = Color.White;
            cuiButtonGroup4.HoverForeColor = Color.White;
            cuiButtonGroup4.HoverOutline = Color.FromArgb(51, 81, 88);
            cuiButtonGroup4.Image = (Image)resources.GetObject("cuiButtonGroup4.Image");
            cuiButtonGroup4.ImageAutoCenter = true;
            cuiButtonGroup4.ImageExpand = new Point(0, 0);
            cuiButtonGroup4.ImageOffset = new Point(0, 0);
            cuiButtonGroup4.Location = new Point(901, 13);
            cuiButtonGroup4.Name = "cuiButtonGroup4";
            cuiButtonGroup4.NormalBackground = Color.White;
            cuiButtonGroup4.NormalForeColor = Color.DimGray;
            cuiButtonGroup4.NormalImageTint = Color.White;
            cuiButtonGroup4.NormalOutline = Color.FromArgb(50, 81, 88);
            cuiButtonGroup4.OutlineThickness = 1F;
            cuiButtonGroup4.PressedBackground = Color.FromArgb(22, 36, 39);
            cuiButtonGroup4.PressedForeColor = Color.White;
            cuiButtonGroup4.PressedImageTint = Color.White;
            cuiButtonGroup4.PressedOutline = Color.FromArgb(22, 36, 39);
            cuiButtonGroup4.Rounding = new Padding(10);
            cuiButtonGroup4.Size = new Size(89, 32);
            cuiButtonGroup4.TabIndex = 24;
            cuiButtonGroup4.TextAlignment = StringAlignment.Center;
            cuiButtonGroup4.TextOffset = new Point(0, 0);
            cuiButtonGroup4.Click += cuiButtonGroup4_Click;
            // 
            // cuiTextBox1
            // 
            cuiTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cuiTextBox1.BackColor = Color.Transparent;
            cuiTextBox1.BackgroundColor = Color.White;
            cuiTextBox1.BorderColor = Color.FromArgb(50, 81, 88);
            cuiTextBox1.Content = "";
            cuiTextBox1.FocusBackgroundColor = Color.White;
            cuiTextBox1.FocusBorderColor = Color.FromArgb(50, 81, 88);
            cuiTextBox1.FocusImageTint = Color.White;
            cuiTextBox1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiTextBox1.ForeColor = Color.Black;
            cuiTextBox1.Image = null;
            cuiTextBox1.ImageExpand = new Point(0, 0);
            cuiTextBox1.ImageOffset = new Point(0, 0);
            cuiTextBox1.Location = new Point(582, 13);
            cuiTextBox1.Margin = new Padding(4);
            cuiTextBox1.Multiline = false;
            cuiTextBox1.Name = "cuiTextBox1";
            cuiTextBox1.NormalImageTint = Color.White;
            cuiTextBox1.Padding = new Padding(14, 9, 14, 0);
            cuiTextBox1.PasswordChar = false;
            cuiTextBox1.PlaceholderColor = Color.DimGray;
            cuiTextBox1.PlaceholderText = "Search";
            cuiTextBox1.Rounding = new Padding(10);
            cuiTextBox1.Size = new Size(312, 32);
            cuiTextBox1.TabIndex = 16;
            cuiTextBox1.TextOffset = new Size(0, 0);
            cuiTextBox1.UnderlinedStyle = false;
            cuiTextBox1.ContentChanged += cuiTextBox1_ContentChanged;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = Color.FromArgb(50, 81, 88);
            flowLayoutPanel2.Dock = DockStyle.Left;
            flowLayoutPanel2.Location = new Point(0, 0);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(239, 638);
            flowLayoutPanel2.TabIndex = 31;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 638);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(cuiPanel1);
            Name = "Form2";
            Text = "Form2";
            cuiPanel7.ResumeLayout(false);
            cuiPanel7.PerformLayout();
            cuiPanel8.ResumeLayout(false);
            cuiPanel8.PerformLayout();
            cuiPanel1.ResumeLayout(false);
            cuiPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            cuiPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Label label2;
        private CuoreUI.Controls.cuiPanel cuiPanel7;
        private CuoreUI.Controls.cuiTextBox cuiTextBox4;
        private CuoreUI.Controls.cuiButtonGroup cuiButtonGroup1;
        private CuoreUI.Controls.cuiPanel cuiPanel8;
        private CuoreUI.Controls.cuiButtonGroup cuiButtonGroup2;
        private CuoreUI.Controls.cuiPanel cuiPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private CuoreUI.Controls.cuiPanel cuiPanel2;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewImageColumn Column11d;
        private DataGridViewImageColumn Column12;
        private CuoreUI.Controls.cuiButtonGroup cuiButtonGroup3;
        private CuoreUI.Controls.cuiTextBox cuiTextBox1;
        private CuoreUI.Controls.cuiButtonGroup cuiButtonGroup4;
    }
}