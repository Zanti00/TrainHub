
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle20 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle18 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle19 = new DataGridViewCellStyle();
            label2 = new Label();
            cuiPanel2 = new CuoreUI.Controls.cuiPanel();
            label1 = new Label();
            cuiPanel4 = new CuoreUI.Controls.cuiPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            advancedDataGridView1 = new Zuby.ADGV.AdvancedDataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            firstNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lastNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            usernameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            mobileNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateOfBirthDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            addressDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            createdDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            userBindingSource = new BindingSource(components);
            panel1 = new Panel();
            searchTextBox = new CuoreUI.Controls.cuiTextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            cuiPanel3 = new CuoreUI.Controls.cuiPanel();
            addStaffBtn = new CuoreUI.Controls.cuiButton();
            panel2 = new Panel();
            cuiTextBox1 = new CuoreUI.Controls.cuiTextBox();
            panel3 = new Panel();
            cuiTextBox2 = new CuoreUI.Controls.cuiTextBox();
            cuiPanel1 = new CuoreUI.Controls.cuiPanel();
            cuiPanel2.SuspendLayout();
            cuiPanel4.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)advancedDataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).BeginInit();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            cuiPanel3.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            cuiPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(51, 20);
            label2.Name = "label2";
            label2.Size = new Size(133, 15);
            label2.TabIndex = 25;
            label2.Text = "View and Manage Staffs";
            // 
            // cuiPanel2
            // 
            cuiPanel2.Controls.Add(label1);
            cuiPanel2.Controls.Add(label2);
            cuiPanel2.Location = new Point(3, 2);
            cuiPanel2.Margin = new Padding(3, 2, 3, 2);
            cuiPanel2.Name = "cuiPanel2";
            cuiPanel2.OutlineThickness = 1F;
            cuiPanel2.PanelColor = Color.FromArgb(248, 250, 252);
            cuiPanel2.PanelOutlineColor = Color.Black;
            cuiPanel2.Rounding = new Padding(8, 8, 0, 0);
            cuiPanel2.Size = new Size(319, 41);
            cuiPanel2.TabIndex = 16;
            cuiPanel2.Paint += cuiPanel2_Paint;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(51, 81, 88);
            label1.Location = new Point(51, -2);
            label1.Name = "label1";
            label1.Size = new Size(59, 24);
            label1.TabIndex = 24;
            label1.Text = "Staffs";
            // 
            // cuiPanel4
            // 
            cuiPanel4.Controls.Add(tableLayoutPanel2);
            cuiPanel4.Dock = DockStyle.Fill;
            cuiPanel4.Location = new Point(3, 92);
            cuiPanel4.Margin = new Padding(3, 2, 3, 2);
            cuiPanel4.Name = "cuiPanel4";
            cuiPanel4.OutlineThickness = 1F;
            cuiPanel4.PanelColor = Color.FromArgb(248, 250, 252);
            cuiPanel4.PanelOutlineColor = Color.FromArgb(248, 250, 252);
            cuiPanel4.Rounding = new Padding(8, 8, 0, 0);
            cuiPanel4.Size = new Size(779, 361);
            cuiPanel4.TabIndex = 37;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(advancedDataGridView1, 0, 1);
            tableLayoutPanel2.Controls.Add(panel1, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 12F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 88F));
            tableLayoutPanel2.Size = new Size(779, 361);
            tableLayoutPanel2.TabIndex = 38;
            // 
            // advancedDataGridView1
            // 
            advancedDataGridView1.AutoGenerateColumns = false;
            advancedDataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            advancedDataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, firstNameDataGridViewTextBoxColumn, lastNameDataGridViewTextBoxColumn, usernameDataGridViewTextBoxColumn, mobileNumberDataGridViewTextBoxColumn, dateOfBirthDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, addressDataGridViewTextBoxColumn, createdDateDataGridViewTextBoxColumn });
            advancedDataGridView1.DataSource = userBindingSource;
            dataGridViewCellStyle20.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = SystemColors.Window;
            dataGridViewCellStyle20.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle20.ForeColor = Color.White;
            dataGridViewCellStyle20.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = DataGridViewTriState.False;
            advancedDataGridView1.DefaultCellStyle = dataGridViewCellStyle20;
            advancedDataGridView1.Dock = DockStyle.Fill;
            advancedDataGridView1.FilterAndSortEnabled = true;
            advancedDataGridView1.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            advancedDataGridView1.Location = new Point(3, 46);
            advancedDataGridView1.MaxFilterButtonImageHeight = 23;
            advancedDataGridView1.Name = "advancedDataGridView1";
            advancedDataGridView1.RightToLeft = RightToLeft.No;
            advancedDataGridView1.Size = new Size(773, 312);
            advancedDataGridView1.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            advancedDataGridView1.TabIndex = 37;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            dataGridViewCellStyle11.ForeColor = Color.Black;
            dataGridViewCellStyle11.SelectionForeColor = Color.White;
            idDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle11;
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 24;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            dataGridViewCellStyle12.ForeColor = Color.Black;
            firstNameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle12;
            firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            firstNameDataGridViewTextBoxColumn.MinimumWidth = 24;
            firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            firstNameDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            dataGridViewCellStyle13.ForeColor = Color.Black;
            lastNameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle13;
            lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            lastNameDataGridViewTextBoxColumn.MinimumWidth = 24;
            lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            lastNameDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            dataGridViewCellStyle14.ForeColor = Color.Black;
            dataGridViewCellStyle14.SelectionForeColor = Color.White;
            usernameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle14;
            usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            usernameDataGridViewTextBoxColumn.MinimumWidth = 24;
            usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            usernameDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // mobileNumberDataGridViewTextBoxColumn
            // 
            mobileNumberDataGridViewTextBoxColumn.DataPropertyName = "MobileNumber";
            dataGridViewCellStyle15.ForeColor = Color.Black;
            mobileNumberDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle15;
            mobileNumberDataGridViewTextBoxColumn.HeaderText = "MobileNumber";
            mobileNumberDataGridViewTextBoxColumn.MinimumWidth = 24;
            mobileNumberDataGridViewTextBoxColumn.Name = "mobileNumberDataGridViewTextBoxColumn";
            mobileNumberDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // dateOfBirthDataGridViewTextBoxColumn
            // 
            dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "DateOfBirth";
            dataGridViewCellStyle16.ForeColor = Color.Black;
            dateOfBirthDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle16;
            dateOfBirthDataGridViewTextBoxColumn.HeaderText = "DateOfBirth";
            dateOfBirthDataGridViewTextBoxColumn.MinimumWidth = 24;
            dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
            dateOfBirthDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            dataGridViewCellStyle17.ForeColor = Color.Black;
            emailDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle17;
            emailDataGridViewTextBoxColumn.HeaderText = "Email";
            emailDataGridViewTextBoxColumn.MinimumWidth = 24;
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            emailDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            dataGridViewCellStyle18.ForeColor = Color.Black;
            addressDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle18;
            addressDataGridViewTextBoxColumn.HeaderText = "Address";
            addressDataGridViewTextBoxColumn.MinimumWidth = 24;
            addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            addressDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // createdDateDataGridViewTextBoxColumn
            // 
            createdDateDataGridViewTextBoxColumn.DataPropertyName = "CreatedDate";
            dataGridViewCellStyle19.ForeColor = Color.Black;
            createdDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle19;
            createdDateDataGridViewTextBoxColumn.HeaderText = "CreatedDate";
            createdDateDataGridViewTextBoxColumn.MinimumWidth = 24;
            createdDateDataGridViewTextBoxColumn.Name = "createdDateDataGridViewTextBoxColumn";
            createdDateDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // userBindingSource
            // 
            userBindingSource.DataSource = typeof(Models.User);
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(248, 250, 252);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(searchTextBox);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(773, 37);
            panel1.TabIndex = 37;
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
            searchTextBox.Location = new Point(473, 1);
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
            searchTextBox.ContentChanged += searchTextBox_TextChanged;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(248, 250, 252);
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(cuiPanel4, 0, 2);
            tableLayoutPanel1.Controls.Add(cuiPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(cuiPanel3, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 187F));
            tableLayoutPanel1.Size = new Size(785, 455);
            tableLayoutPanel1.TabIndex = 10;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // cuiPanel3
            // 
            cuiPanel3.BackColor = Color.White;
            cuiPanel3.Controls.Add(addStaffBtn);
            cuiPanel3.Dock = DockStyle.Right;
            cuiPanel3.Location = new Point(448, 47);
            cuiPanel3.Margin = new Padding(3, 2, 3, 2);
            cuiPanel3.Name = "cuiPanel3";
            cuiPanel3.OutlineThickness = 1F;
            cuiPanel3.PanelColor = Color.FromArgb(248, 250, 252);
            cuiPanel3.PanelOutlineColor = Color.FromArgb(248, 250, 252);
            cuiPanel3.Rounding = new Padding(8, 8, 0, 0);
            cuiPanel3.Size = new Size(334, 41);
            cuiPanel3.TabIndex = 36;
            // 
            // addStaffBtn
            // 
            addStaffBtn.CheckButton = false;
            addStaffBtn.Checked = false;
            addStaffBtn.CheckedBackground = Color.FromArgb(255, 106, 0);
            addStaffBtn.CheckedForeColor = Color.White;
            addStaffBtn.CheckedImageTint = Color.White;
            addStaffBtn.CheckedOutline = Color.FromArgb(255, 106, 0);
            addStaffBtn.Content = "Your text here!";
            addStaffBtn.DialogResult = DialogResult.None;
            addStaffBtn.Font = new Font("Microsoft Sans Serif", 9.75F);
            addStaffBtn.ForeColor = Color.White;
            addStaffBtn.HoverBackground = Color.White;
            addStaffBtn.HoveredImageTint = Color.White;
            addStaffBtn.HoverForeColor = Color.Black;
            addStaffBtn.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            addStaffBtn.Image = null;
            addStaffBtn.ImageAutoCenter = true;
            addStaffBtn.ImageExpand = new Point(0, 0);
            addStaffBtn.ImageOffset = new Point(0, 0);
            addStaffBtn.Location = new Point(221, 3);
            addStaffBtn.Name = "addStaffBtn";
            addStaffBtn.NormalBackground = Color.FromArgb(50, 81, 88);
            addStaffBtn.NormalForeColor = Color.White;
            addStaffBtn.NormalImageTint = Color.White;
            addStaffBtn.NormalOutline = Color.FromArgb(50, 81, 88);
            addStaffBtn.OutlineThickness = 1F;
            addStaffBtn.PressedBackground = Color.WhiteSmoke;
            addStaffBtn.PressedForeColor = Color.FromArgb(32, 32, 32);
            addStaffBtn.PressedImageTint = Color.White;
            addStaffBtn.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            addStaffBtn.Rounding = new Padding(8);
            addStaffBtn.Size = new Size(106, 32);
            addStaffBtn.TabIndex = 24;
            addStaffBtn.TextAlignment = StringAlignment.Center;
            addStaffBtn.TextOffset = new Point(0, 0);
            addStaffBtn.Click += addStaffBtn_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(248, 250, 252);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(cuiTextBox1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(773, 37);
            panel2.TabIndex = 38;
            // 
            // cuiTextBox1
            // 
            cuiTextBox1.AutoSize = true;
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
            cuiTextBox1.Location = new Point(473, 1);
            cuiTextBox1.Margin = new Padding(4);
            cuiTextBox1.Multiline = false;
            cuiTextBox1.Name = "cuiTextBox1";
            cuiTextBox1.NormalImageTint = Color.White;
            cuiTextBox1.Padding = new Padding(14, 9, 14, 0);
            cuiTextBox1.PasswordChar = false;
            cuiTextBox1.PlaceholderColor = Color.DimGray;
            cuiTextBox1.PlaceholderText = "Search";
            cuiTextBox1.Rounding = new Padding(10);
            cuiTextBox1.Size = new Size(296, 32);
            cuiTextBox1.TabIndex = 15;
            cuiTextBox1.TextOffset = new Size(0, 0);
            cuiTextBox1.UnderlinedStyle = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(248, 250, 252);
            panel3.Controls.Add(cuiPanel1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(773, 37);
            panel3.TabIndex = 38;
            // 
            // cuiTextBox2
            // 
            cuiTextBox2.AutoSize = true;
            cuiTextBox2.BackColor = Color.Transparent;
            cuiTextBox2.BackgroundColor = Color.White;
            cuiTextBox2.BorderColor = Color.FromArgb(50, 81, 88);
            cuiTextBox2.Content = "";
            cuiTextBox2.FocusBackgroundColor = Color.White;
            cuiTextBox2.FocusBorderColor = Color.FromArgb(50, 81, 88);
            cuiTextBox2.FocusImageTint = Color.White;
            cuiTextBox2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiTextBox2.ForeColor = Color.Black;
            cuiTextBox2.Image = null;
            cuiTextBox2.ImageExpand = new Point(0, 0);
            cuiTextBox2.ImageOffset = new Point(0, 0);
            cuiTextBox2.Location = new Point(46, 2);
            cuiTextBox2.Margin = new Padding(4);
            cuiTextBox2.Multiline = false;
            cuiTextBox2.Name = "cuiTextBox2";
            cuiTextBox2.NormalImageTint = Color.White;
            cuiTextBox2.Padding = new Padding(14, 9, 14, 0);
            cuiTextBox2.PasswordChar = false;
            cuiTextBox2.PlaceholderColor = Color.DimGray;
            cuiTextBox2.PlaceholderText = "Search";
            cuiTextBox2.Rounding = new Padding(10);
            cuiTextBox2.Size = new Size(296, 32);
            cuiTextBox2.TabIndex = 15;
            cuiTextBox2.TextOffset = new Size(0, 0);
            cuiTextBox2.UnderlinedStyle = false;
            // 
            // cuiPanel1
            // 
            cuiPanel1.Controls.Add(cuiTextBox2);
            cuiPanel1.Dock = DockStyle.Right;
            cuiPanel1.Location = new Point(427, 0);
            cuiPanel1.Name = "cuiPanel1";
            cuiPanel1.OutlineThickness = 1F;
            cuiPanel1.PanelColor = Color.FromArgb(248, 250, 252);
            cuiPanel1.PanelOutlineColor = Color.FromArgb(248, 250, 252);
            cuiPanel1.Rounding = new Padding(8);
            cuiPanel1.Size = new Size(346, 37);
            cuiPanel1.TabIndex = 16;
            // 
            // StaffTable
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(785, 455);
            Controls.Add(tableLayoutPanel1);
            ForeColor = Color.White;
            Margin = new Padding(3, 2, 3, 2);
            Name = "StaffTable";
            Text = "Form2";
            Load += StaffTable_Load;
            cuiPanel2.ResumeLayout(false);
            cuiPanel2.PerformLayout();
            cuiPanel4.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)advancedDataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            cuiPanel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            cuiPanel1.ResumeLayout(false);
            cuiPanel1.PerformLayout();
            ResumeLayout(false);
        }

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label label2;
        private CuoreUI.Controls.cuiPanel cuiPanel2;
        private Label label1;
        private CuoreUI.Controls.cuiPanel cuiPanel4;
        private CuoreUI.Controls.cuiTextBox searchTextBox;
        private BindingSource userBindingSource;
        private Zuby.ADGV.AdvancedDataGridView advancedDataGridView1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mobileNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn createdDateDataGridViewTextBoxColumn;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private CuoreUI.Controls.cuiPanel cuiPanel3;
        private TableLayoutPanel tableLayoutPanel2;
        private CuoreUI.Controls.cuiButton addStaffBtn;
        private Panel panel2;
        private Panel panel3;
        private CuoreUI.Controls.cuiPanel cuiPanel1;
        private CuoreUI.Controls.cuiTextBox cuiTextBox2;
        private CuoreUI.Controls.cuiTextBox cuiTextBox1;
    }
}