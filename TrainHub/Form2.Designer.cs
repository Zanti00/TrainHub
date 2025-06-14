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
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            cuiPanel1 = new CuoreUI.Controls.cuiPanel();
            cuiButton1 = new CuoreUI.Controls.cuiButton();
            cuiPanel2 = new CuoreUI.Controls.cuiPanel();
            cuiPanel3 = new CuoreUI.Controls.cuiPanel();
            searchbar = new CuoreUI.Controls.cuiTextBox();
            advancedDataGridView1 = new Zuby.ADGV.AdvancedDataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewImageColumn();
            Column8 = new DataGridViewImageColumn();
            cuiPictureBox1 = new CuoreUI.Controls.cuiPictureBox();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            cuiPanel1.SuspendLayout();
            cuiPanel2.SuspendLayout();
            cuiPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)advancedDataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(cuiPanel1, 0, 1);
            tableLayoutPanel1.Controls.Add(cuiPanel2, 0, 2);
            tableLayoutPanel1.Location = new Point(-1, 1);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(10, 0, 10, 10);
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 47.5247536F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 52.4752464F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 329F));
            tableLayoutPanel1.Size = new Size(804, 451);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(13, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 41);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(3, 29);
            label2.Name = "label2";
            label2.Size = new Size(144, 15);
            label2.TabIndex = 26;
            label2.Text = "View and Manage Trainers";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(51, 81, 88);
            label1.Location = new Point(3, 5);
            label1.Name = "label1";
            label1.Size = new Size(87, 24);
            label1.TabIndex = 25;
            label1.Text = "Trainers\r\n";
            // 
            // cuiPanel1
            // 
            cuiPanel1.Controls.Add(cuiButton1);
            cuiPanel1.Dock = DockStyle.Right;
            cuiPanel1.Location = new Point(599, 56);
            cuiPanel1.Name = "cuiPanel1";
            cuiPanel1.OutlineThickness = 1F;
            cuiPanel1.PanelColor = SystemColors.Control;
            cuiPanel1.PanelOutlineColor = SystemColors.Control;
            cuiPanel1.Rounding = new Padding(8);
            cuiPanel1.Size = new Size(192, 52);
            cuiPanel1.TabIndex = 1;
            // 
            // cuiButton1
            // 
            cuiButton1.CheckButton = false;
            cuiButton1.Checked = false;
            cuiButton1.CheckedBackground = Color.White;
            cuiButton1.CheckedForeColor = Color.Black;
            cuiButton1.CheckedImageTint = Color.White;
            cuiButton1.CheckedOutline = Color.White;
            cuiButton1.Content = "+ Add Trainers";
            cuiButton1.DialogResult = DialogResult.None;
            cuiButton1.Font = new Font("Microsoft Sans Serif", 10.2F);
            cuiButton1.ForeColor = Color.White;
            cuiButton1.HoverBackground = Color.FromArgb(22, 36, 29);
            cuiButton1.HoveredImageTint = Color.Transparent;
            cuiButton1.HoverForeColor = Color.Black;
            cuiButton1.HoverOutline = Color.FromArgb(22, 36, 29);
            cuiButton1.Image = null;
            cuiButton1.ImageAutoCenter = true;
            cuiButton1.ImageExpand = new Point(0, 0);
            cuiButton1.ImageOffset = new Point(0, 0);
            cuiButton1.Location = new Point(75, 0);
            cuiButton1.Name = "cuiButton1";
            cuiButton1.NormalBackground = Color.FromArgb(51, 81, 88);
            cuiButton1.NormalForeColor = Color.White;
            cuiButton1.NormalImageTint = Color.Black;
            cuiButton1.NormalOutline = Color.FromArgb(51, 81, 88);
            cuiButton1.OutlineThickness = 1F;
            cuiButton1.PressedBackground = Color.FromArgb(22, 36, 29);
            cuiButton1.PressedForeColor = Color.White;
            cuiButton1.PressedImageTint = Color.White;
            cuiButton1.PressedOutline = Color.FromArgb(22, 36, 29);
            cuiButton1.Rounding = new Padding(10);
            cuiButton1.Size = new Size(113, 43);
            cuiButton1.TabIndex = 0;
            cuiButton1.TextAlignment = StringAlignment.Center;
            cuiButton1.TextOffset = new Point(0, 0);
            cuiButton1.Click += cuiButton1_Click;
            // 
            // cuiPanel2
            // 
            cuiPanel2.BackColor = SystemColors.ControlLight;
            cuiPanel2.Controls.Add(advancedDataGridView1);
            cuiPanel2.Controls.Add(cuiPanel3);
            cuiPanel2.Dock = DockStyle.Fill;
            cuiPanel2.Location = new Point(13, 114);
            cuiPanel2.Name = "cuiPanel2";
            cuiPanel2.OutlineThickness = 1F;
            cuiPanel2.Padding = new Padding(0, 10, 10, 10);
            cuiPanel2.PanelColor = Color.White;
            cuiPanel2.PanelOutlineColor = Color.Black;
            cuiPanel2.Rounding = new Padding(10, 10, 0, 0);
            cuiPanel2.Size = new Size(778, 324);
            cuiPanel2.TabIndex = 2;
            // 
            // cuiPanel3
            // 
            cuiPanel3.Controls.Add(cuiPictureBox1);
            cuiPanel3.Controls.Add(searchbar);
            cuiPanel3.Location = new Point(349, 1);
            cuiPanel3.Name = "cuiPanel3";
            cuiPanel3.OutlineThickness = 1F;
            cuiPanel3.PanelColor = Color.White;
            cuiPanel3.PanelOutlineColor = Color.White;
            cuiPanel3.Rounding = new Padding(8);
            cuiPanel3.Size = new Size(423, 41);
            cuiPanel3.TabIndex = 0;
            cuiPanel3.Paint += cuiPanel3_Paint;
            // 
            // searchbar
            // 
            searchbar.BackColor = Color.Transparent;
            searchbar.BackgroundColor = Color.White;
            searchbar.BorderColor = Color.FromArgb(50, 81, 88);
            searchbar.Content = "";
            searchbar.FocusBackgroundColor = Color.White;
            searchbar.FocusBorderColor = Color.FromArgb(50, 81, 88);
            searchbar.FocusImageTint = Color.White;
            searchbar.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchbar.ForeColor = Color.Black;
            searchbar.Image = null;
            searchbar.ImageExpand = new Point(5, 5);
            searchbar.ImageOffset = new Point(0, 0);
            searchbar.Location = new Point(123, 2);
            searchbar.Margin = new Padding(4);
            searchbar.Multiline = false;
            searchbar.Name = "searchbar";
            searchbar.NormalImageTint = Color.White;
            searchbar.Padding = new Padding(13, 11, 13, 0);
            searchbar.PasswordChar = false;
            searchbar.PlaceholderColor = SystemColors.WindowFrame;
            searchbar.PlaceholderText = "";
            searchbar.Rounding = new Padding(10);
            searchbar.Size = new Size(296, 35);
            searchbar.TabIndex = 12;
            searchbar.TextOffset = new Size(0, 0);
            searchbar.UnderlinedStyle = false;
            searchbar.ContentChanged += searchbar_ContentChanged;
            // 
            // advancedDataGridView1
            // 
            advancedDataGridView1.AllowUserToAddRows = false;
            advancedDataGridView1.AllowUserToDeleteRows = false;
            advancedDataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            advancedDataGridView1.BackgroundColor = Color.White;
            advancedDataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            advancedDataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8 });
            advancedDataGridView1.FilterAndSortEnabled = true;
            advancedDataGridView1.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            advancedDataGridView1.GridColor = Color.DimGray;
            advancedDataGridView1.Location = new Point(0, 45);
            advancedDataGridView1.MaxFilterButtonImageHeight = 23;
            advancedDataGridView1.Name = "advancedDataGridView1";
            advancedDataGridView1.ReadOnly = true;
            advancedDataGridView1.RightToLeft = RightToLeft.No;
            advancedDataGridView1.RowHeadersVisible = false;
            advancedDataGridView1.Size = new Size(778, 268);
            advancedDataGridView1.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            advancedDataGridView1.TabIndex = 1;
            // 
            // Column1
            // 
            Column1.HeaderText = "Trainer ID";
            Column1.MinimumWidth = 24;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // Column2
            // 
            Column2.HeaderText = "Name";
            Column2.MinimumWidth = 24;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // Column3
            // 
            Column3.HeaderText = "Email Address";
            Column3.MinimumWidth = 24;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // Column4
            // 
            Column4.HeaderText = "Contact Number";
            Column4.MinimumWidth = 24;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // Column5
            // 
            Column5.HeaderText = "Date of Birth";
            Column5.MinimumWidth = 24;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // Column6
            // 
            Column6.HeaderText = "Address";
            Column6.MinimumWidth = 24;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // Column7
            // 
            Column7.HeaderText = "Edit";
            Column7.MinimumWidth = 24;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // Column8
            // 
            Column8.HeaderText = "Delete";
            Column8.MinimumWidth = 24;
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            Column8.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // cuiPictureBox1
            // 
            cuiPictureBox1.BackColor = Color.White;
            cuiPictureBox1.Content = null;
            cuiPictureBox1.ImageTint = Color.White;
            cuiPictureBox1.Location = new Point(137, 10);
            cuiPictureBox1.Margin = new Padding(4, 3, 4, 3);
            cuiPictureBox1.Name = "cuiPictureBox1";
            cuiPictureBox1.OutlineThickness = 1F;
            cuiPictureBox1.PanelOutlineColor = Color.Empty;
            cuiPictureBox1.Rotation = 0;
            cuiPictureBox1.Rounding = new Padding(8);
            cuiPictureBox1.Size = new Size(129, 20);
            cuiPictureBox1.TabIndex = 13;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            ShowInTaskbar = false;
            Text = "Form2";
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            cuiPanel1.ResumeLayout(false);
            cuiPanel2.ResumeLayout(false);
            cuiPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)advancedDataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private CuoreUI.Controls.cuiPanel cuiPanel1;
        private CuoreUI.Controls.cuiButton cuiButton1;
        private CuoreUI.Controls.cuiPanel cuiPanel2;
        private CuoreUI.Controls.cuiPanel cuiPanel3;
        private CuoreUI.Controls.cuiTextBox searchbar;
        private Zuby.ADGV.AdvancedDataGridView advancedDataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewImageColumn Column7;
        private DataGridViewImageColumn Column8;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox1;
    }
}