namespace TrainHub
{
    partial class table_trainer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(table_trainer));
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            cuiPanel1 = new CuoreUI.Controls.cuiPanel();
            addTrainerButton = new CuoreUI.Controls.cuiButton();
            cuiPanel2 = new CuoreUI.Controls.cuiPanel();
            advancedDataGridView1 = new Zuby.ADGV.AdvancedDataGridView();
            trainerBindingSource = new BindingSource(components);
            cuiPanel3 = new CuoreUI.Controls.cuiPanel();
            searchBar = new CuoreUI.Controls.cuiTextBox();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            firstNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lastNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            addressDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            isDeletedDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            mobileNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            yearsOfExperienceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            createdDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            softDeleteDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateOfBirthDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewImageColumn();
            Column8 = new DataGridViewImageColumn();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            cuiPanel1.SuspendLayout();
            cuiPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)advancedDataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trainerBindingSource).BeginInit();
            cuiPanel3.SuspendLayout();
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
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 339F));
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
            label2.Size = new Size(145, 15);
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
            cuiPanel1.Controls.Add(addTrainerButton);
            cuiPanel1.Dock = DockStyle.Right;
            cuiPanel1.Location = new Point(599, 51);
            cuiPanel1.Name = "cuiPanel1";
            cuiPanel1.OutlineThickness = 1F;
            cuiPanel1.PanelColor = SystemColors.Control;
            cuiPanel1.PanelOutlineColor = SystemColors.Control;
            cuiPanel1.Rounding = new Padding(8);
            cuiPanel1.Size = new Size(192, 47);
            cuiPanel1.TabIndex = 1;
            // 
            // addTrainerButton
            // 
            addTrainerButton.CheckButton = false;
            addTrainerButton.Checked = false;
            addTrainerButton.CheckedBackground = Color.White;
            addTrainerButton.CheckedForeColor = Color.Black;
            addTrainerButton.CheckedImageTint = Color.White;
            addTrainerButton.CheckedOutline = Color.White;
            addTrainerButton.Content = "+ Add Trainers";
            addTrainerButton.DialogResult = DialogResult.None;
            addTrainerButton.Font = new Font("Microsoft Sans Serif", 10.2F);
            addTrainerButton.ForeColor = Color.White;
            addTrainerButton.HoverBackground = Color.FromArgb(22, 36, 29);
            addTrainerButton.HoveredImageTint = Color.Transparent;
            addTrainerButton.HoverForeColor = Color.Black;
            addTrainerButton.HoverOutline = Color.FromArgb(22, 36, 29);
            addTrainerButton.Image = null;
            addTrainerButton.ImageAutoCenter = true;
            addTrainerButton.ImageExpand = new Point(0, 0);
            addTrainerButton.ImageOffset = new Point(0, 0);
            addTrainerButton.Location = new Point(75, 0);
            addTrainerButton.Name = "addTrainerButton";
            addTrainerButton.NormalBackground = Color.FromArgb(51, 81, 88);
            addTrainerButton.NormalForeColor = Color.White;
            addTrainerButton.NormalImageTint = Color.Black;
            addTrainerButton.NormalOutline = Color.FromArgb(51, 81, 88);
            addTrainerButton.OutlineThickness = 1F;
            addTrainerButton.PressedBackground = Color.FromArgb(22, 36, 29);
            addTrainerButton.PressedForeColor = Color.White;
            addTrainerButton.PressedImageTint = Color.White;
            addTrainerButton.PressedOutline = Color.FromArgb(22, 36, 29);
            addTrainerButton.Rounding = new Padding(10);
            addTrainerButton.Size = new Size(113, 43);
            addTrainerButton.TabIndex = 0;
            addTrainerButton.TextAlignment = StringAlignment.Center;
            addTrainerButton.TextOffset = new Point(0, 0);
            addTrainerButton.Click += addTrainerButton_Click;
            // 
            // cuiPanel2
            // 
            cuiPanel2.BackColor = SystemColors.ControlLight;
            cuiPanel2.Controls.Add(advancedDataGridView1);
            cuiPanel2.Controls.Add(cuiPanel3);
            cuiPanel2.Dock = DockStyle.Fill;
            cuiPanel2.Location = new Point(13, 104);
            cuiPanel2.Name = "cuiPanel2";
            cuiPanel2.OutlineThickness = 1F;
            cuiPanel2.Padding = new Padding(0, 10, 10, 10);
            cuiPanel2.PanelColor = Color.White;
            cuiPanel2.PanelOutlineColor = Color.Black;
            cuiPanel2.Rounding = new Padding(10, 10, 0, 0);
            cuiPanel2.Size = new Size(778, 334);
            cuiPanel2.TabIndex = 2;
            // 
            // advancedDataGridView1
            // 
            advancedDataGridView1.AllowUserToAddRows = false;
            advancedDataGridView1.AllowUserToDeleteRows = false;
            advancedDataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            advancedDataGridView1.AutoGenerateColumns = false;
            advancedDataGridView1.BackgroundColor = Color.White;
            advancedDataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            advancedDataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, firstNameDataGridViewTextBoxColumn, lastNameDataGridViewTextBoxColumn, addressDataGridViewTextBoxColumn, isDeletedDataGridViewCheckBoxColumn, emailDataGridViewTextBoxColumn, mobileNumberDataGridViewTextBoxColumn, yearsOfExperienceDataGridViewTextBoxColumn, createdDateDataGridViewTextBoxColumn, softDeleteDateDataGridViewTextBoxColumn, dateOfBirthDataGridViewTextBoxColumn, Column7, Column8 });
            advancedDataGridView1.DataSource = trainerBindingSource;
            advancedDataGridView1.FilterAndSortEnabled = true;
            advancedDataGridView1.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            advancedDataGridView1.GridColor = Color.DimGray;
            advancedDataGridView1.Location = new Point(0, 48);
            advancedDataGridView1.MaxFilterButtonImageHeight = 23;
            advancedDataGridView1.Name = "advancedDataGridView1";
            advancedDataGridView1.ReadOnly = true;
            advancedDataGridView1.RightToLeft = RightToLeft.No;
            advancedDataGridView1.RowHeadersVisible = false;
            advancedDataGridView1.Size = new Size(778, 275);
            advancedDataGridView1.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            advancedDataGridView1.TabIndex = 1;
            advancedDataGridView1.CellClick += dataGridView2_CellClick;
            advancedDataGridView1.CellFormatting += advancedDataGridView1_CellFormatting;
            // 
            // trainerBindingSource
            // 
            trainerBindingSource.DataSource = typeof(Models.Trainer);
            // 
            // cuiPanel3
            // 
            cuiPanel3.Controls.Add(searchBar);
            cuiPanel3.Location = new Point(349, 1);
            cuiPanel3.Name = "cuiPanel3";
            cuiPanel3.OutlineThickness = 1F;
            cuiPanel3.PanelColor = Color.White;
            cuiPanel3.PanelOutlineColor = Color.White;
            cuiPanel3.Rounding = new Padding(8);
            cuiPanel3.Size = new Size(423, 49);
            cuiPanel3.TabIndex = 0;
            cuiPanel3.Paint += cuiPanel3_Paint;
            // 
            // searchBar
            // 
            searchBar.BackColor = Color.Transparent;
            searchBar.BackgroundColor = Color.White;
            searchBar.BorderColor = Color.FromArgb(50, 81, 88);
            searchBar.Content = "";
            searchBar.FocusBackgroundColor = Color.White;
            searchBar.FocusBorderColor = Color.FromArgb(50, 81, 88);
            searchBar.FocusImageTint = Color.White;
            searchBar.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchBar.ForeColor = Color.Black;
            searchBar.Image = null;
            searchBar.ImageExpand = new Point(3, 3);
            searchBar.ImageOffset = new Point(0, 0);
            searchBar.Location = new Point(123, 6);
            searchBar.Margin = new Padding(4);
            searchBar.Multiline = false;
            searchBar.Name = "searchBar";
            searchBar.NormalImageTint = Color.White;
            searchBar.Padding = new Padding(13, 11, 13, 0);
            searchBar.PasswordChar = false;
            searchBar.PlaceholderColor = SystemColors.WindowFrame;
            searchBar.PlaceholderText = "Search...";
            searchBar.Rounding = new Padding(10);
            searchBar.Size = new Size(296, 35);
            searchBar.TabIndex = 12;
            searchBar.TextOffset = new Size(0, 0);
            searchBar.UnderlinedStyle = false;
            searchBar.ContentChanged += searchBar_ContentChanged;
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
            // firstNameDataGridViewTextBoxColumn
            // 
            firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            firstNameDataGridViewTextBoxColumn.MinimumWidth = 24;
            firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            firstNameDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            lastNameDataGridViewTextBoxColumn.MinimumWidth = 24;
            lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            lastNameDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            addressDataGridViewTextBoxColumn.HeaderText = "Address";
            addressDataGridViewTextBoxColumn.MinimumWidth = 24;
            addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            addressDataGridViewTextBoxColumn.ReadOnly = true;
            addressDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // isDeletedDataGridViewCheckBoxColumn
            // 
            isDeletedDataGridViewCheckBoxColumn.DataPropertyName = "IsDeleted";
            isDeletedDataGridViewCheckBoxColumn.HeaderText = "IsDeleted";
            isDeletedDataGridViewCheckBoxColumn.MinimumWidth = 24;
            isDeletedDataGridViewCheckBoxColumn.Name = "isDeletedDataGridViewCheckBoxColumn";
            isDeletedDataGridViewCheckBoxColumn.ReadOnly = true;
            isDeletedDataGridViewCheckBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.HeaderText = "Email";
            emailDataGridViewTextBoxColumn.MinimumWidth = 24;
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            emailDataGridViewTextBoxColumn.ReadOnly = true;
            emailDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // mobileNumberDataGridViewTextBoxColumn
            // 
            mobileNumberDataGridViewTextBoxColumn.DataPropertyName = "MobileNumber";
            mobileNumberDataGridViewTextBoxColumn.HeaderText = "MobileNumber";
            mobileNumberDataGridViewTextBoxColumn.MinimumWidth = 24;
            mobileNumberDataGridViewTextBoxColumn.Name = "mobileNumberDataGridViewTextBoxColumn";
            mobileNumberDataGridViewTextBoxColumn.ReadOnly = true;
            mobileNumberDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // yearsOfExperienceDataGridViewTextBoxColumn
            // 
            yearsOfExperienceDataGridViewTextBoxColumn.DataPropertyName = "YearsOfExperience";
            yearsOfExperienceDataGridViewTextBoxColumn.HeaderText = "YearsOfExperience";
            yearsOfExperienceDataGridViewTextBoxColumn.MinimumWidth = 24;
            yearsOfExperienceDataGridViewTextBoxColumn.Name = "yearsOfExperienceDataGridViewTextBoxColumn";
            yearsOfExperienceDataGridViewTextBoxColumn.ReadOnly = true;
            yearsOfExperienceDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // createdDateDataGridViewTextBoxColumn
            // 
            createdDateDataGridViewTextBoxColumn.DataPropertyName = "CreatedDate";
            createdDateDataGridViewTextBoxColumn.HeaderText = "CreatedDate";
            createdDateDataGridViewTextBoxColumn.MinimumWidth = 24;
            createdDateDataGridViewTextBoxColumn.Name = "createdDateDataGridViewTextBoxColumn";
            createdDateDataGridViewTextBoxColumn.ReadOnly = true;
            createdDateDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // softDeleteDateDataGridViewTextBoxColumn
            // 
            softDeleteDateDataGridViewTextBoxColumn.DataPropertyName = "SoftDeleteDate";
            softDeleteDateDataGridViewTextBoxColumn.HeaderText = "SoftDeleteDate";
            softDeleteDateDataGridViewTextBoxColumn.MinimumWidth = 24;
            softDeleteDateDataGridViewTextBoxColumn.Name = "softDeleteDateDataGridViewTextBoxColumn";
            softDeleteDateDataGridViewTextBoxColumn.ReadOnly = true;
            softDeleteDateDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // dateOfBirthDataGridViewTextBoxColumn
            // 
            dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "DateOfBirth";
            dateOfBirthDataGridViewTextBoxColumn.HeaderText = "DateOfBirth";
            dateOfBirthDataGridViewTextBoxColumn.MinimumWidth = 24;
            dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
            dateOfBirthDataGridViewTextBoxColumn.ReadOnly = true;
            dateOfBirthDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // Column7
            // 
            Column7.HeaderText = "Edit";
            Column7.Image = (Image)resources.GetObject("Column7.Image");
            Column7.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Column7.MinimumWidth = 24;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // Column8
            // 
            Column8.HeaderText = "Delete";
            Column8.Image = (Image)resources.GetObject("Column8.Image");
            Column8.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Column8.MinimumWidth = 24;
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            Column8.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // table_trainer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "table_trainer";
            ShowInTaskbar = false;
            Text = "Form2";
            Load += table_trainer_Load;
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            cuiPanel1.ResumeLayout(false);
            cuiPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)advancedDataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trainerBindingSource).EndInit();
            cuiPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private CuoreUI.Controls.cuiPanel cuiPanel1;
        private CuoreUI.Controls.cuiButton addTrainerButton;
        private CuoreUI.Controls.cuiPanel cuiPanel2;
        private CuoreUI.Controls.cuiPanel cuiPanel3;
        private CuoreUI.Controls.cuiTextBox searchBar;
        private Zuby.ADGV.AdvancedDataGridView advancedDataGridView1;
        private BindingSource trainerBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn isDeletedDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mobileNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn yearsOfExperienceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn createdDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn softDeleteDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private DataGridViewImageColumn Column7;
        private DataGridViewImageColumn Column8;
    }
}