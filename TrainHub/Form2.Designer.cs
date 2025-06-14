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
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
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
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 47.8632469F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 52.1367531F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 350F));
            tableLayoutPanel1.Size = new Size(800, 453);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 42);
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
            cuiPanel1.Location = new Point(605, 52);
            cuiPanel1.Name = "cuiPanel1";
            cuiPanel1.OutlineThickness = 1F;
            cuiPanel1.PanelColor = SystemColors.Control;
            cuiPanel1.PanelOutlineColor = SystemColors.Control;
            cuiPanel1.Rounding = new Padding(8);
            cuiPanel1.Size = new Size(192, 47);
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
            // 
            // cuiPanel2
            // 
            cuiPanel2.BackColor = SystemColors.ControlLight;
            cuiPanel2.Controls.Add(advancedDataGridView1);
            cuiPanel2.Controls.Add(cuiPanel3);
            cuiPanel2.Location = new Point(3, 105);
            cuiPanel2.Name = "cuiPanel2";
            cuiPanel2.OutlineThickness = 1F;
            cuiPanel2.Padding = new Padding(0, 10, 10, 10);
            cuiPanel2.PanelColor = Color.White;
            cuiPanel2.PanelOutlineColor = Color.Black;
            cuiPanel2.Rounding = new Padding(10, 10, 0, 0);
            cuiPanel2.Size = new Size(794, 340);
            cuiPanel2.TabIndex = 2;
            // 
            // cuiPanel3
            // 
            cuiPanel3.Controls.Add(searchbar);
            cuiPanel3.Location = new Point(368, 3);
            cuiPanel3.Name = "cuiPanel3";
            cuiPanel3.OutlineThickness = 1F;
            cuiPanel3.PanelColor = Color.White;
            cuiPanel3.PanelOutlineColor = Color.White;
            cuiPanel3.Rounding = new Padding(8);
            cuiPanel3.Size = new Size(423, 41);
            cuiPanel3.TabIndex = 0;
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
            searchbar.Image = (Image)resources.GetObject("searchbar.Image");
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
            searchbar.PlaceholderText = "Search...";
            searchbar.Rounding = new Padding(10);
            searchbar.Size = new Size(296, 35);
            searchbar.TabIndex = 12;
            searchbar.TextOffset = new Size(0, 0);
            searchbar.UnderlinedStyle = false;
            // 
            // advancedDataGridView1
            // 
            advancedDataGridView1.AllowUserToAddRows = false;
            advancedDataGridView1.AllowUserToDeleteRows = false;
            advancedDataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            advancedDataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column2, Column3 });
            advancedDataGridView1.FilterAndSortEnabled = true;
            advancedDataGridView1.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            advancedDataGridView1.Location = new Point(-3, 47);
            advancedDataGridView1.MaxFilterButtonImageHeight = 23;
            advancedDataGridView1.Name = "advancedDataGridView1";
            advancedDataGridView1.ReadOnly = true;
            advancedDataGridView1.RightToLeft = RightToLeft.No;
            advancedDataGridView1.RowHeadersVisible = false;
            advancedDataGridView1.RowHeadersWidth = 20;
            advancedDataGridView1.Size = new Size(797, 293);
            advancedDataGridView1.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            advancedDataGridView1.TabIndex = 1;
            // 
            // Column2
            // 
            Column2.HeaderText = "Column2";
            Column2.MinimumWidth = 24;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // Column3
            // 
            Column3.HeaderText = "Column3";
            Column3.MinimumWidth = 24;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.SortMode = DataGridViewColumnSortMode.Programmatic;
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
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
    }
}