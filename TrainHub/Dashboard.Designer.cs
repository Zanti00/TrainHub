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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            cuiPanel1 = new CuoreUI.Controls.cuiPanel();
            advancedDataGridView1 = new Zuby.ADGV.AdvancedDataGridView();
            Edit = new DataGridViewImageColumn();
            Delete = new DataGridViewImageColumn();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            firstNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lastNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            phoneNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateOfBirthDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            startDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            endDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            createdDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            softDeleteDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            daysToExpiryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            isDeletedDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            statusDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            membershipTypeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            expiryDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            memberBindingSource = new BindingSource(components);
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
            cuiChartLine1 = new CuoreUI.Controls.Charts.cuiChartLine();
            bindingSource1 = new BindingSource(components);
            bindingSource2 = new BindingSource(components);
            cuiPanel8 = new CuoreUI.Controls.cuiPanel();
            cuiChartLine2 = new CuoreUI.Controls.Charts.cuiChartLine();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            tableLayoutPanel1.SuspendLayout();
            cuiPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)advancedDataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)memberBindingSource).BeginInit();
            cuiPanel2.SuspendLayout();
            cuiPanel7.SuspendLayout();
            cuiPanel3.SuspendLayout();
            cuiPanel6.SuspendLayout();
            cuiPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            cuiPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource2).BeginInit();
            cuiPanel8.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(tableLayoutPanel1, "tableLayoutPanel1");
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.Controls.Add(cuiPanel1, 0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // cuiPanel1
            // 
            resources.ApplyResources(cuiPanel1, "cuiPanel1");
            cuiPanel1.BackColor = Color.Transparent;
            cuiPanel1.Controls.Add(advancedDataGridView1);
            cuiPanel1.Controls.Add(cuiPanel2);
            cuiPanel1.Name = "cuiPanel1";
            cuiPanel1.OutlineThickness = 1F;
            cuiPanel1.PanelColor = Color.Transparent;
            cuiPanel1.PanelOutlineColor = Color.Transparent;
            cuiPanel1.Rounding = new Padding(8);
            // 
            // advancedDataGridView1
            // 
            resources.ApplyResources(advancedDataGridView1, "advancedDataGridView1");
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
            advancedDataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            advancedDataGridView1.Columns.AddRange(new DataGridViewColumn[] { Edit, Delete, idDataGridViewTextBoxColumn, firstNameDataGridViewTextBoxColumn, lastNameDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, phoneNumberDataGridViewTextBoxColumn, dateOfBirthDataGridViewTextBoxColumn, startDateDataGridViewTextBoxColumn, endDateDataGridViewTextBoxColumn, createdDateDataGridViewTextBoxColumn, softDeleteDateDataGridViewTextBoxColumn, daysToExpiryDataGridViewTextBoxColumn, isDeletedDataGridViewCheckBoxColumn, statusDataGridViewTextBoxColumn, membershipTypeDataGridViewTextBoxColumn, expiryDateDataGridViewTextBoxColumn });
            advancedDataGridView1.DataSource = memberBindingSource;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(50, 81, 88);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            advancedDataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            advancedDataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            advancedDataGridView1.FilterAndSortEnabled = true;
            advancedDataGridView1.FilterStringChangedInvokeBeforeDatasourceUpdate = false;
            advancedDataGridView1.GridColor = Color.DimGray;
            advancedDataGridView1.MaxFilterButtonImageHeight = 23;
            advancedDataGridView1.Name = "advancedDataGridView1";
            advancedDataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.ButtonFace;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(50, 81, 88);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            advancedDataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            advancedDataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.Padding = new Padding(0, 5, 0, 5);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(50, 81, 88);
            advancedDataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            advancedDataGridView1.RowTemplate.Height = 40;
            advancedDataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            advancedDataGridView1.SortStringChangedInvokeBeforeDatasourceUpdate = false;
            advancedDataGridView1.CellFormatting += advancedDataGridView1_CellFormatting;
            // 
            // Edit
            // 
            resources.ApplyResources(Edit, "Edit");
            Edit.Image = (Image)resources.GetObject("Edit.Image");
            Edit.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Edit.Name = "Edit";
            Edit.ReadOnly = true;
            Edit.Resizable = DataGridViewTriState.False;
            Edit.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // Delete
            // 
            resources.ApplyResources(Delete, "Delete");
            Delete.Image = (Image)resources.GetObject("Delete.Image");
            Delete.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Delete.Name = "Delete";
            Delete.ReadOnly = true;
            Delete.Resizable = DataGridViewTriState.False;
            Delete.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            resources.ApplyResources(idDataGridViewTextBoxColumn, "idDataGridViewTextBoxColumn");
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            resources.ApplyResources(firstNameDataGridViewTextBoxColumn, "firstNameDataGridViewTextBoxColumn");
            firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            firstNameDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            resources.ApplyResources(lastNameDataGridViewTextBoxColumn, "lastNameDataGridViewTextBoxColumn");
            lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            lastNameDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            resources.ApplyResources(emailDataGridViewTextBoxColumn, "emailDataGridViewTextBoxColumn");
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            emailDataGridViewTextBoxColumn.ReadOnly = true;
            emailDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            resources.ApplyResources(phoneNumberDataGridViewTextBoxColumn, "phoneNumberDataGridViewTextBoxColumn");
            phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            phoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
            phoneNumberDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // dateOfBirthDataGridViewTextBoxColumn
            // 
            dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "DateOfBirth";
            resources.ApplyResources(dateOfBirthDataGridViewTextBoxColumn, "dateOfBirthDataGridViewTextBoxColumn");
            dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
            dateOfBirthDataGridViewTextBoxColumn.ReadOnly = true;
            dateOfBirthDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            resources.ApplyResources(startDateDataGridViewTextBoxColumn, "startDateDataGridViewTextBoxColumn");
            startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            startDateDataGridViewTextBoxColumn.ReadOnly = true;
            startDateDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // endDateDataGridViewTextBoxColumn
            // 
            endDateDataGridViewTextBoxColumn.DataPropertyName = "EndDate";
            resources.ApplyResources(endDateDataGridViewTextBoxColumn, "endDateDataGridViewTextBoxColumn");
            endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
            endDateDataGridViewTextBoxColumn.ReadOnly = true;
            endDateDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // createdDateDataGridViewTextBoxColumn
            // 
            createdDateDataGridViewTextBoxColumn.DataPropertyName = "CreatedDate";
            resources.ApplyResources(createdDateDataGridViewTextBoxColumn, "createdDateDataGridViewTextBoxColumn");
            createdDateDataGridViewTextBoxColumn.Name = "createdDateDataGridViewTextBoxColumn";
            createdDateDataGridViewTextBoxColumn.ReadOnly = true;
            createdDateDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // softDeleteDateDataGridViewTextBoxColumn
            // 
            softDeleteDateDataGridViewTextBoxColumn.DataPropertyName = "SoftDeleteDate";
            resources.ApplyResources(softDeleteDateDataGridViewTextBoxColumn, "softDeleteDateDataGridViewTextBoxColumn");
            softDeleteDateDataGridViewTextBoxColumn.Name = "softDeleteDateDataGridViewTextBoxColumn";
            softDeleteDateDataGridViewTextBoxColumn.ReadOnly = true;
            softDeleteDateDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // daysToExpiryDataGridViewTextBoxColumn
            // 
            daysToExpiryDataGridViewTextBoxColumn.DataPropertyName = "DaysToExpiry";
            resources.ApplyResources(daysToExpiryDataGridViewTextBoxColumn, "daysToExpiryDataGridViewTextBoxColumn");
            daysToExpiryDataGridViewTextBoxColumn.Name = "daysToExpiryDataGridViewTextBoxColumn";
            daysToExpiryDataGridViewTextBoxColumn.ReadOnly = true;
            daysToExpiryDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // isDeletedDataGridViewCheckBoxColumn
            // 
            isDeletedDataGridViewCheckBoxColumn.DataPropertyName = "IsDeleted";
            resources.ApplyResources(isDeletedDataGridViewCheckBoxColumn, "isDeletedDataGridViewCheckBoxColumn");
            isDeletedDataGridViewCheckBoxColumn.Name = "isDeletedDataGridViewCheckBoxColumn";
            isDeletedDataGridViewCheckBoxColumn.ReadOnly = true;
            isDeletedDataGridViewCheckBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            resources.ApplyResources(statusDataGridViewTextBoxColumn, "statusDataGridViewTextBoxColumn");
            statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            statusDataGridViewTextBoxColumn.ReadOnly = true;
            statusDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // membershipTypeDataGridViewTextBoxColumn
            // 
            membershipTypeDataGridViewTextBoxColumn.DataPropertyName = "MembershipType";
            resources.ApplyResources(membershipTypeDataGridViewTextBoxColumn, "membershipTypeDataGridViewTextBoxColumn");
            membershipTypeDataGridViewTextBoxColumn.Name = "membershipTypeDataGridViewTextBoxColumn";
            membershipTypeDataGridViewTextBoxColumn.ReadOnly = true;
            membershipTypeDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // expiryDateDataGridViewTextBoxColumn
            // 
            expiryDateDataGridViewTextBoxColumn.DataPropertyName = "ExpiryDate";
            resources.ApplyResources(expiryDateDataGridViewTextBoxColumn, "expiryDateDataGridViewTextBoxColumn");
            expiryDateDataGridViewTextBoxColumn.Name = "expiryDateDataGridViewTextBoxColumn";
            expiryDateDataGridViewTextBoxColumn.ReadOnly = true;
            expiryDateDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // memberBindingSource
            // 
            memberBindingSource.DataSource = typeof(Models.Member);
            // 
            // cuiPanel2
            // 
            resources.ApplyResources(cuiPanel2, "cuiPanel2");
            cuiPanel2.Controls.Add(cuiPanel7);
            cuiPanel2.Name = "cuiPanel2";
            cuiPanel2.OutlineThickness = 1F;
            cuiPanel2.PanelColor = Color.FromArgb(248, 250, 252);
            cuiPanel2.PanelOutlineColor = Color.Black;
            cuiPanel2.Rounding = new Padding(8, 8, 0, 0);
            // 
            // cuiPanel7
            // 
            resources.ApplyResources(cuiPanel7, "cuiPanel7");
            cuiPanel7.Controls.Add(cuiPictureBox1);
            cuiPanel7.Controls.Add(searchBar);
            cuiPanel7.Name = "cuiPanel7";
            cuiPanel7.OutlineThickness = 0F;
            cuiPanel7.PanelColor = Color.FromArgb(248, 250, 252);
            cuiPanel7.PanelOutlineColor = Color.FromArgb(248, 250, 252);
            cuiPanel7.Rounding = new Padding(8, 8, 0, 0);
            // 
            // cuiPictureBox1
            // 
            resources.ApplyResources(cuiPictureBox1, "cuiPictureBox1");
            cuiPictureBox1.BackColor = Color.White;
            cuiPictureBox1.Content = null;
            cuiPictureBox1.ImageTint = Color.White;
            cuiPictureBox1.Name = "cuiPictureBox1";
            cuiPictureBox1.OutlineThickness = 1F;
            cuiPictureBox1.PanelOutlineColor = Color.Empty;
            cuiPictureBox1.Rotation = 0;
            cuiPictureBox1.Rounding = new Padding(8);
            // 
            // searchBar
            // 
            resources.ApplyResources(searchBar, "searchBar");
            searchBar.BackColor = Color.Transparent;
            searchBar.BackgroundColor = Color.White;
            searchBar.BorderColor = Color.FromArgb(50, 81, 88);
            searchBar.Content = "";
            searchBar.FocusBackgroundColor = Color.White;
            searchBar.FocusBorderColor = Color.FromArgb(50, 81, 88);
            searchBar.FocusImageTint = Color.White;
            searchBar.ForeColor = Color.Black;
            searchBar.Image = null;
            searchBar.ImageExpand = new Point(10, 10);
            searchBar.ImageOffset = new Point(250, 0);
            searchBar.Multiline = false;
            searchBar.Name = "searchBar";
            searchBar.NormalImageTint = Color.White;
            searchBar.PasswordChar = false;
            searchBar.PlaceholderColor = Color.DimGray;
            searchBar.PlaceholderText = "Search...";
            searchBar.Rounding = new Padding(10);
            searchBar.TabStop = false;
            searchBar.TextOffset = new Size(30, 0);
            searchBar.UnderlinedStyle = false;
            searchBar.ContentChanged += searchBar_ContentChanged;
            // 
            // cuiPanel3
            // 
            resources.ApplyResources(cuiPanel3, "cuiPanel3");
            cuiPanel3.Controls.Add(cuiPanel6);
            cuiPanel3.Name = "cuiPanel3";
            cuiPanel3.OutlineThickness = 1F;
            cuiPanel3.PanelColor = Color.White;
            cuiPanel3.PanelOutlineColor = Color.LightGray;
            cuiPanel3.Rounding = new Padding(8);
            // 
            // cuiPanel6
            // 
            resources.ApplyResources(cuiPanel6, "cuiPanel6");
            cuiPanel6.Controls.Add(label2);
            cuiPanel6.Controls.Add(label1);
            cuiPanel6.Name = "cuiPanel6";
            cuiPanel6.OutlineThickness = 0F;
            cuiPanel6.PanelColor = Color.White;
            cuiPanel6.PanelOutlineColor = Color.White;
            cuiPanel6.Rounding = new Padding(8, 8, 0, 0);
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.Gray;
            label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.FromArgb(51, 81, 88);
            label1.Name = "label1";
            // 
            // cuiPanel5
            // 
            resources.ApplyResources(cuiPanel5, "cuiPanel5");
            cuiPanel5.Controls.Add(cuiPanel9);
            cuiPanel5.Controls.Add(label6);
            cuiPanel5.Controls.Add(label5);
            cuiPanel5.Controls.Add(pictureBox1);
            cuiPanel5.Name = "cuiPanel5";
            cuiPanel5.OutlineThickness = 1F;
            cuiPanel5.PanelColor = Color.FromArgb(51, 81, 88);
            cuiPanel5.PanelOutlineColor = Color.FromArgb(51, 81, 88);
            cuiPanel5.Rounding = new Padding(8);
            // 
            // cuiPanel9
            // 
            resources.ApplyResources(cuiPanel9, "cuiPanel9");
            cuiPanel9.Name = "cuiPanel9";
            cuiPanel9.OutlineThickness = 1F;
            cuiPanel9.PanelColor = Color.White;
            cuiPanel9.PanelOutlineColor = Color.LightGray;
            cuiPanel9.Rounding = new Padding(0, 0, 8, 8);
            // 
            // label6
            // 
            resources.ApplyResources(label6, "label6");
            label6.BackColor = Color.Transparent;
            label6.ForeColor = Color.White;
            label6.Name = "label6";
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.BackColor = Color.Transparent;
            label5.ForeColor = Color.White;
            label5.Name = "label5";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // cuiPanel4
            // 
            resources.ApplyResources(cuiPanel4, "cuiPanel4");
            cuiPanel4.Controls.Add(label4);
            cuiPanel4.Controls.Add(label3);
            cuiPanel4.Name = "cuiPanel4";
            cuiPanel4.OutlineThickness = 1F;
            cuiPanel4.PanelColor = Color.White;
            cuiPanel4.PanelOutlineColor = Color.LightGray;
            cuiPanel4.Rounding = new Padding(8);
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.BackColor = Color.Transparent;
            label4.ForeColor = Color.FromArgb(51, 81, 88);
            label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.BackColor = Color.Transparent;
            label3.ForeColor = Color.FromArgb(51, 81, 88);
            label3.Name = "label3";
            // 
            // cuiChartLine1
            // 
            resources.ApplyResources(cuiChartLine1, "cuiChartLine1");
            cuiChartLine1.AutoMaxValue = false;
            cuiChartLine1.AxisColor = Color.Gray;
            cuiChartLine1.BackColor = Color.White;
            cuiChartLine1.ChartLineColor = Color.FromArgb(51, 81, 88);
            cuiChartLine1.ChartPadding = 40;
            cuiChartLine1.CustomXAxis = new string[]
    {
    "Monthly",
    "",
    "Quarterly",
    "",
    "Yearly"
    };
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
            cuiChartLine1.GradientBackground = true;
            cuiChartLine1.MaxValue = 100F;
            cuiChartLine1.Name = "cuiChartLine1";
            cuiChartLine1.PointColor = Color.FromArgb(51, 81, 88);
            cuiChartLine1.ShortDates = true;
            cuiChartLine1.ShowLines = true;
            cuiChartLine1.UseBezier = false;
            cuiChartLine1.UsePercent = true;
            cuiChartLine1.Load += cuiChartLine1_Load;
            // 
            // cuiPanel8
            // 
            resources.ApplyResources(cuiPanel8, "cuiPanel8");
            cuiPanel8.Controls.Add(cuiChartLine2);
            cuiPanel8.Name = "cuiPanel8";
            cuiPanel8.OutlineThickness = 1F;
            cuiPanel8.PanelColor = Color.White;
            cuiPanel8.PanelOutlineColor = Color.LightGray;
            cuiPanel8.Rounding = new Padding(8);
            // 
            // cuiChartLine2
            // 
            resources.ApplyResources(cuiChartLine2, "cuiChartLine2");
            cuiChartLine2.AutoMaxValue = false;
            cuiChartLine2.AxisColor = Color.Gray;
            cuiChartLine2.BackColor = Color.White;
            cuiChartLine2.ChartLineColor = Color.FromArgb(51, 81, 88);
            cuiChartLine2.ChartPadding = 40;
            cuiChartLine2.DataPoints = new float[]
    {
    100F,
    90F,
    80F,
    75F,
    70F,
    65F,
    60F
    };
            cuiChartLine2.DayColor = Color.FromArgb(51, 81, 88);
            cuiChartLine2.GradientBackground = true;
            cuiChartLine2.MaxValue = 100F;
            cuiChartLine2.Name = "cuiChartLine2";
            cuiChartLine2.PointColor = Color.FromArgb(51, 81, 88);
            cuiChartLine2.ShortDates = true;
            cuiChartLine2.ShowLines = true;
            cuiChartLine2.UseBezier = false;
            cuiChartLine2.UsePercent = true;
            cuiChartLine2.Load += cuiChartLine2_Load_1;
            // 
            // Dashboard
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.WhiteSmoke;
            ControlBox = false;
            Controls.Add(cuiPanel5);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(cuiPanel4);
            Controls.Add(cuiPanel3);
            Controls.Add(cuiPanel8);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dashboard";
            Load += Dashboard_Load_1;
            tableLayoutPanel1.ResumeLayout(false);
            cuiPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)advancedDataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)memberBindingSource).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource2).EndInit();
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
        private CuoreUI.Controls.cuiPanel cuiPanel6;
        private Label label2;
        private Label label4;
        private Label label3;
        private CuoreUI.Controls.Charts.cuiChartLine cuiChartLine1;
        private Label label6;
        private Label label5;
        private PictureBox pictureBox1;
        private CuoreUI.Controls.cuiPanel cuiPanel9;
        private BindingSource memberBindingSource;
        private BindingSource bindingSource1;
        private BindingSource bindingSource2;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn createdDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn softDeleteDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn daysToExpiryDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn isDeletedDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn membershipTypeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn expiryDateDataGridViewTextBoxColumn;
        private CuoreUI.Controls.cuiPanel cuiPanel8;
        private CuoreUI.Controls.Charts.cuiChartLine cuiChartLine2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}