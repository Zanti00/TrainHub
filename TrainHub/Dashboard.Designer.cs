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
            memberBindingSource = new BindingSource(components);
            cuiChartLine1 = new CuoreUI.Controls.Charts.cuiChartLine();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel5 = new TableLayoutPanel();
            welcomeLabel = new Label();
            label4 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            cuiPanel8 = new CuoreUI.Controls.cuiPanel();
            tableLayoutPanel8 = new TableLayoutPanel();
            pictureBox3 = new PictureBox();
            tableLayoutPanel9 = new TableLayoutPanel();
            totalMemberTodayLbl = new Label();
            label9 = new Label();
            cuiPanel10 = new CuoreUI.Controls.cuiPanel();
            cuiPanel1 = new CuoreUI.Controls.cuiPanel();
            tableLayoutPanel6 = new TableLayoutPanel();
            pictureBox2 = new PictureBox();
            tableLayoutPanel7 = new TableLayoutPanel();
            totalTrainerTodayLbl = new Label();
            label7 = new Label();
            cuiPanel4 = new CuoreUI.Controls.cuiPanel();
            cuiPanel5 = new CuoreUI.Controls.cuiPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            nearlyExpiredMembersLbl = new Label();
            label5 = new Label();
            cuiPanel9 = new CuoreUI.Controls.cuiPanel();
            panel1 = new Panel();
            panel2 = new Panel();
            tableLayoutPanel11 = new TableLayoutPanel();
            cuiPanel3 = new CuoreUI.Controls.cuiPanel();
            nearlyExpiredMembersAdvancedDataGridView1 = new Zuby.ADGV.AdvancedDataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            firstNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lastNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Gender = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            phoneNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateOfBirthDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            startDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            endDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            createdDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            statusDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            membershipTypeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cuiPanel2 = new CuoreUI.Controls.cuiPanel();
            cuiPanel6 = new CuoreUI.Controls.cuiPanel();
            label2 = new Label();
            label1 = new Label();
            cuiPanel7 = new CuoreUI.Controls.cuiPanel();
            cuiPictureBox1 = new CuoreUI.Controls.cuiPictureBox();
            searchBar = new CuoreUI.Controls.cuiTextBox();
            trainerAttendanceBindingSource = new BindingSource(components);
            memberAttendanceBindingSource = new BindingSource(components);
            subscriptionChartLine = new CuoreUI.Controls.Charts.cuiChartLine();
            ((System.ComponentModel.ISupportInitialize)memberBindingSource).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            cuiPanel8.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            tableLayoutPanel9.SuspendLayout();
            cuiPanel1.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tableLayoutPanel7.SuspendLayout();
            cuiPanel5.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel4.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel11.SuspendLayout();
            cuiPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nearlyExpiredMembersAdvancedDataGridView1).BeginInit();
            cuiPanel2.SuspendLayout();
            cuiPanel6.SuspendLayout();
            cuiPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trainerAttendanceBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)memberAttendanceBindingSource).BeginInit();
            SuspendLayout();
            // 
            // memberBindingSource
            // 
            memberBindingSource.DataSource = typeof(Models.Member);
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
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(tableLayoutPanel2, "tableLayoutPanel2");
            tableLayoutPanel2.Controls.Add(tableLayoutPanel5, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel1, 0, 1);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // tableLayoutPanel5
            // 
            resources.ApplyResources(tableLayoutPanel5, "tableLayoutPanel5");
            tableLayoutPanel5.BackColor = Color.Transparent;
            tableLayoutPanel5.Controls.Add(welcomeLabel, 0, 0);
            tableLayoutPanel5.Controls.Add(label4, 0, 1);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            // 
            // welcomeLabel
            // 
            resources.ApplyResources(welcomeLabel, "welcomeLabel");
            welcomeLabel.BackColor = Color.Transparent;
            welcomeLabel.ForeColor = Color.FromArgb(51, 81, 88);
            welcomeLabel.Name = "welcomeLabel";
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.BackColor = Color.Transparent;
            label4.ForeColor = Color.FromArgb(51, 81, 88);
            label4.Name = "label4";
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(tableLayoutPanel1, "tableLayoutPanel1");
            tableLayoutPanel1.Controls.Add(cuiPanel8, 2, 0);
            tableLayoutPanel1.Controls.Add(cuiPanel1, 1, 0);
            tableLayoutPanel1.Controls.Add(cuiPanel5, 0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // cuiPanel8
            // 
            resources.ApplyResources(cuiPanel8, "cuiPanel8");
            cuiPanel8.Controls.Add(tableLayoutPanel8);
            cuiPanel8.Controls.Add(cuiPanel10);
            cuiPanel8.Name = "cuiPanel8";
            cuiPanel8.OutlineThickness = 1F;
            cuiPanel8.PanelColor = Color.FromArgb(51, 81, 88);
            cuiPanel8.PanelOutlineColor = Color.FromArgb(51, 81, 88);
            cuiPanel8.Rounding = new Padding(8);
            // 
            // tableLayoutPanel8
            // 
            resources.ApplyResources(tableLayoutPanel8, "tableLayoutPanel8");
            tableLayoutPanel8.BackColor = Color.Transparent;
            tableLayoutPanel8.Controls.Add(pictureBox3, 0, 0);
            tableLayoutPanel8.Controls.Add(tableLayoutPanel9, 1, 0);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            // 
            // pictureBox3
            // 
            resources.ApplyResources(pictureBox3, "pictureBox3");
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Name = "pictureBox3";
            pictureBox3.TabStop = false;
            // 
            // tableLayoutPanel9
            // 
            resources.ApplyResources(tableLayoutPanel9, "tableLayoutPanel9");
            tableLayoutPanel9.Controls.Add(totalMemberTodayLbl, 0, 0);
            tableLayoutPanel9.Controls.Add(label9, 0, 1);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            // 
            // totalMemberTodayLbl
            // 
            resources.ApplyResources(totalMemberTodayLbl, "totalMemberTodayLbl");
            totalMemberTodayLbl.BackColor = Color.Transparent;
            totalMemberTodayLbl.ForeColor = Color.White;
            totalMemberTodayLbl.Name = "totalMemberTodayLbl";
            // 
            // label9
            // 
            resources.ApplyResources(label9, "label9");
            label9.BackColor = Color.Transparent;
            label9.ForeColor = Color.White;
            label9.Name = "label9";
            // 
            // cuiPanel10
            // 
            resources.ApplyResources(cuiPanel10, "cuiPanel10");
            cuiPanel10.Name = "cuiPanel10";
            cuiPanel10.OutlineThickness = 1F;
            cuiPanel10.PanelColor = Color.White;
            cuiPanel10.PanelOutlineColor = Color.LightGray;
            cuiPanel10.Rounding = new Padding(0, 0, 8, 8);
            // 
            // cuiPanel1
            // 
            resources.ApplyResources(cuiPanel1, "cuiPanel1");
            cuiPanel1.Controls.Add(tableLayoutPanel6);
            cuiPanel1.Controls.Add(cuiPanel4);
            cuiPanel1.Name = "cuiPanel1";
            cuiPanel1.OutlineThickness = 1F;
            cuiPanel1.PanelColor = Color.FromArgb(51, 81, 88);
            cuiPanel1.PanelOutlineColor = Color.FromArgb(51, 81, 88);
            cuiPanel1.Rounding = new Padding(8);
            // 
            // tableLayoutPanel6
            // 
            resources.ApplyResources(tableLayoutPanel6, "tableLayoutPanel6");
            tableLayoutPanel6.BackColor = Color.Transparent;
            tableLayoutPanel6.Controls.Add(pictureBox2, 0, 0);
            tableLayoutPanel6.Controls.Add(tableLayoutPanel7, 1, 0);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            // 
            // pictureBox2
            // 
            resources.ApplyResources(pictureBox2, "pictureBox2");
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Name = "pictureBox2";
            pictureBox2.TabStop = false;
            // 
            // tableLayoutPanel7
            // 
            resources.ApplyResources(tableLayoutPanel7, "tableLayoutPanel7");
            tableLayoutPanel7.Controls.Add(totalTrainerTodayLbl, 0, 0);
            tableLayoutPanel7.Controls.Add(label7, 0, 1);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            // 
            // totalTrainerTodayLbl
            // 
            resources.ApplyResources(totalTrainerTodayLbl, "totalTrainerTodayLbl");
            totalTrainerTodayLbl.BackColor = Color.Transparent;
            totalTrainerTodayLbl.ForeColor = Color.White;
            totalTrainerTodayLbl.Name = "totalTrainerTodayLbl";
            // 
            // label7
            // 
            resources.ApplyResources(label7, "label7");
            label7.BackColor = Color.Transparent;
            label7.ForeColor = Color.White;
            label7.Name = "label7";
            // 
            // cuiPanel4
            // 
            resources.ApplyResources(cuiPanel4, "cuiPanel4");
            cuiPanel4.Name = "cuiPanel4";
            cuiPanel4.OutlineThickness = 1F;
            cuiPanel4.PanelColor = Color.White;
            cuiPanel4.PanelOutlineColor = Color.LightGray;
            cuiPanel4.Rounding = new Padding(0, 0, 8, 8);
            // 
            // cuiPanel5
            // 
            resources.ApplyResources(cuiPanel5, "cuiPanel5");
            cuiPanel5.Controls.Add(tableLayoutPanel3);
            cuiPanel5.Controls.Add(cuiPanel9);
            cuiPanel5.Name = "cuiPanel5";
            cuiPanel5.OutlineThickness = 1F;
            cuiPanel5.PanelColor = Color.FromArgb(51, 81, 88);
            cuiPanel5.PanelOutlineColor = Color.FromArgb(51, 81, 88);
            cuiPanel5.Rounding = new Padding(8);
            // 
            // tableLayoutPanel3
            // 
            resources.ApplyResources(tableLayoutPanel3, "tableLayoutPanel3");
            tableLayoutPanel3.BackColor = Color.Transparent;
            tableLayoutPanel3.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 1, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel4
            // 
            resources.ApplyResources(tableLayoutPanel4, "tableLayoutPanel4");
            tableLayoutPanel4.Controls.Add(nearlyExpiredMembersLbl, 0, 0);
            tableLayoutPanel4.Controls.Add(label5, 0, 1);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            // 
            // nearlyExpiredMembersLbl
            // 
            resources.ApplyResources(nearlyExpiredMembersLbl, "nearlyExpiredMembersLbl");
            nearlyExpiredMembersLbl.BackColor = Color.Transparent;
            nearlyExpiredMembersLbl.ForeColor = Color.White;
            nearlyExpiredMembersLbl.Name = "nearlyExpiredMembersLbl";
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.BackColor = Color.Transparent;
            label5.ForeColor = Color.White;
            label5.Name = "label5";
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
            // panel1
            // 
            resources.ApplyResources(panel1, "panel1");
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(cuiPanel3);
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Name = "panel1";
            // 
            // panel2
            // 
            resources.ApplyResources(panel2, "panel2");
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(tableLayoutPanel11);
            panel2.Name = "panel2";
            // 
            // tableLayoutPanel11
            // 
            resources.ApplyResources(tableLayoutPanel11, "tableLayoutPanel11");
            tableLayoutPanel11.Controls.Add(subscriptionChartLine, 0, 0);
            tableLayoutPanel11.Name = "tableLayoutPanel11";
            // 
            // cuiPanel3
            // 
            resources.ApplyResources(cuiPanel3, "cuiPanel3");
            cuiPanel3.Controls.Add(nearlyExpiredMembersAdvancedDataGridView1);
            cuiPanel3.Controls.Add(cuiPanel2);
            cuiPanel3.Name = "cuiPanel3";
            cuiPanel3.OutlineThickness = 1F;
            cuiPanel3.PanelColor = Color.White;
            cuiPanel3.PanelOutlineColor = Color.LightGray;
            cuiPanel3.Rounding = new Padding(8);
            // 
            // nearlyExpiredMembersAdvancedDataGridView1
            // 
            resources.ApplyResources(nearlyExpiredMembersAdvancedDataGridView1, "nearlyExpiredMembersAdvancedDataGridView1");
            nearlyExpiredMembersAdvancedDataGridView1.AllowUserToAddRows = false;
            nearlyExpiredMembersAdvancedDataGridView1.AllowUserToDeleteRows = false;
            nearlyExpiredMembersAdvancedDataGridView1.AllowUserToResizeRows = false;
            nearlyExpiredMembersAdvancedDataGridView1.AutoGenerateColumns = false;
            nearlyExpiredMembersAdvancedDataGridView1.BackgroundColor = Color.White;
            nearlyExpiredMembersAdvancedDataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(50, 81, 88);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            nearlyExpiredMembersAdvancedDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            nearlyExpiredMembersAdvancedDataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            nearlyExpiredMembersAdvancedDataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, firstNameDataGridViewTextBoxColumn, lastNameDataGridViewTextBoxColumn, Gender, emailDataGridViewTextBoxColumn, phoneNumberDataGridViewTextBoxColumn, dateOfBirthDataGridViewTextBoxColumn, startDateDataGridViewTextBoxColumn, endDateDataGridViewTextBoxColumn, createdDateDataGridViewTextBoxColumn, statusDataGridViewTextBoxColumn, membershipTypeDataGridViewTextBoxColumn });
            nearlyExpiredMembersAdvancedDataGridView1.DataSource = memberBindingSource;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(50, 81, 88);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            nearlyExpiredMembersAdvancedDataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            nearlyExpiredMembersAdvancedDataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            nearlyExpiredMembersAdvancedDataGridView1.FilterAndSortEnabled = true;
            nearlyExpiredMembersAdvancedDataGridView1.FilterStringChangedInvokeBeforeDatasourceUpdate = false;
            nearlyExpiredMembersAdvancedDataGridView1.GridColor = Color.DimGray;
            nearlyExpiredMembersAdvancedDataGridView1.MaxFilterButtonImageHeight = 23;
            nearlyExpiredMembersAdvancedDataGridView1.Name = "nearlyExpiredMembersAdvancedDataGridView1";
            nearlyExpiredMembersAdvancedDataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.ButtonFace;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(50, 81, 88);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            nearlyExpiredMembersAdvancedDataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            nearlyExpiredMembersAdvancedDataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.Padding = new Padding(0, 5, 0, 5);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(50, 81, 88);
            nearlyExpiredMembersAdvancedDataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            nearlyExpiredMembersAdvancedDataGridView1.RowTemplate.Height = 40;
            nearlyExpiredMembersAdvancedDataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            nearlyExpiredMembersAdvancedDataGridView1.SortStringChangedInvokeBeforeDatasourceUpdate = false;
            nearlyExpiredMembersAdvancedDataGridView1.CellFormatting += advancedDataGridView1_CellFormatting;
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
            // Gender
            // 
            Gender.DataPropertyName = "Gender";
            resources.ApplyResources(Gender, "Gender");
            Gender.Name = "Gender";
            Gender.ReadOnly = true;
            Gender.SortMode = DataGridViewColumnSortMode.Programmatic;
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
            // cuiPanel2
            // 
            resources.ApplyResources(cuiPanel2, "cuiPanel2");
            cuiPanel2.Controls.Add(cuiPanel6);
            cuiPanel2.Controls.Add(cuiPanel7);
            cuiPanel2.Name = "cuiPanel2";
            cuiPanel2.OutlineThickness = 1F;
            cuiPanel2.PanelColor = Color.FromArgb(248, 250, 252);
            cuiPanel2.PanelOutlineColor = Color.Black;
            cuiPanel2.Rounding = new Padding(8, 8, 0, 0);
            // 
            // cuiPanel6
            // 
            resources.ApplyResources(cuiPanel6, "cuiPanel6");
            cuiPanel6.BackColor = Color.Transparent;
            cuiPanel6.Controls.Add(label2);
            cuiPanel6.Controls.Add(label1);
            cuiPanel6.Name = "cuiPanel6";
            cuiPanel6.OutlineThickness = 0F;
            cuiPanel6.PanelColor = Color.Transparent;
            cuiPanel6.PanelOutlineColor = Color.Transparent;
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
            // trainerAttendanceBindingSource
            // 
            trainerAttendanceBindingSource.DataSource = typeof(Models.TrainerAttendances);
            // 
            // memberAttendanceBindingSource
            // 
            memberAttendanceBindingSource.DataSource = typeof(Models.MemberAttendances);
            // 
            // subscriptionChartLine
            // 
            resources.ApplyResources(subscriptionChartLine, "subscriptionChartLine");
            subscriptionChartLine.AutoMaxValue = false;
            subscriptionChartLine.AxisColor = Color.Gray;
            subscriptionChartLine.BackColor = Color.White;
            subscriptionChartLine.ChartLineColor = Color.FromArgb(51, 81, 88);
            subscriptionChartLine.ChartPadding = 40;
            subscriptionChartLine.CustomXAxis = new string[]
    {
    "Monthly",
    "Quarterly",
    "Yearly"
    };
            subscriptionChartLine.DataPoints = new float[]
    {
    100F,
    90F,
    80F,
    75F,
    70F,
    65F,
    60F
    };
            subscriptionChartLine.DayColor = Color.FromArgb(51, 81, 88);
            subscriptionChartLine.GradientBackground = true;
            subscriptionChartLine.MaxValue = 100F;
            subscriptionChartLine.Name = "subscriptionChartLine";
            subscriptionChartLine.PointColor = Color.FromArgb(51, 81, 88);
            subscriptionChartLine.ShortDates = true;
            subscriptionChartLine.ShowLines = true;
            subscriptionChartLine.UseBezier = false;
            subscriptionChartLine.UsePercent = true;
            // 
            // Dashboard
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.WhiteSmoke;
            ControlBox = false;
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dashboard";
            Load += Dashboard_Load_1;
            ((System.ComponentModel.ISupportInitialize)memberBindingSource).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            cuiPanel8.ResumeLayout(false);
            tableLayoutPanel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            tableLayoutPanel9.ResumeLayout(false);
            tableLayoutPanel9.PerformLayout();
            cuiPanel1.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            cuiPanel5.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            tableLayoutPanel11.ResumeLayout(false);
            cuiPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nearlyExpiredMembersAdvancedDataGridView1).EndInit();
            cuiPanel2.ResumeLayout(false);
            cuiPanel6.ResumeLayout(false);
            cuiPanel6.PerformLayout();
            cuiPanel7.ResumeLayout(false);
            cuiPanel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trainerAttendanceBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)memberAttendanceBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private CuoreUI.Controls.Charts.cuiChartLine cuiChartLine1;
        private BindingSource memberBindingSource;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel1;
        private BindingSource trainerAttendanceBindingSource;
        private BindingSource memberAttendanceBindingSource;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel5;
        private Label welcomeLabel;
        private Label label4;
        private TableLayoutPanel tableLayoutPanel1;
        private CuoreUI.Controls.cuiPanel cuiPanel5;
        private TableLayoutPanel tableLayoutPanel3;
        private PictureBox pictureBox1;
        private TableLayoutPanel tableLayoutPanel4;
        private Label nearlyExpiredMembersLbl;
        private Label label5;
        private CuoreUI.Controls.cuiPanel cuiPanel9;
        private CuoreUI.Controls.cuiPanel cuiPanel8;
        private TableLayoutPanel tableLayoutPanel8;
        private PictureBox pictureBox3;
        private TableLayoutPanel tableLayoutPanel9;
        private Label totalMemberTodayLbl;
        private Label label9;
        private CuoreUI.Controls.cuiPanel cuiPanel10;
        private CuoreUI.Controls.cuiPanel cuiPanel1;
        private TableLayoutPanel tableLayoutPanel6;
        private PictureBox pictureBox2;
        private TableLayoutPanel tableLayoutPanel7;
        private Label totalTrainerTodayLbl;
        private Label label7;
        private CuoreUI.Controls.cuiPanel cuiPanel4;
        private CuoreUI.Controls.cuiPanel cuiPanel3;
        private Zuby.ADGV.AdvancedDataGridView nearlyExpiredMembersAdvancedDataGridView1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Gender;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn createdDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn membershipTypeDataGridViewTextBoxColumn;
        private CuoreUI.Controls.cuiPanel cuiPanel2;
        private CuoreUI.Controls.cuiPanel cuiPanel6;
        private Label label2;
        private Label label1;
        private CuoreUI.Controls.cuiPanel cuiPanel7;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox1;
        private CuoreUI.Controls.cuiTextBox searchBar;
        private TableLayoutPanel tableLayoutPanel11;
        private CuoreUI.Controls.Charts.cuiChartLine subscriptionChartLine;
    }
}