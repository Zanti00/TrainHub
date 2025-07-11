namespace TrainHub
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            cuiPictureBox1 = new CuoreUI.Controls.cuiPictureBox();
            panel2 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            usernameTxt = new Label();
            panel4 = new Panel();
            panel5 = new Panel();
            label3 = new Label();
            panel6 = new Panel();
            dashboardBtn = new CuoreUI.Controls.cuiButton();
            trainerContainer = new Panel();
            panel11 = new Panel();
            trainerBtn = new CuoreUI.Controls.cuiButton();
            memberContainer = new Panel();
            memberBtn = new CuoreUI.Controls.cuiButton();
            staffContainer = new Panel();
            staffBtn = new CuoreUI.Controls.cuiButton();
            attendanceBtn = new CuoreUI.Controls.cuiButton();
            panel10 = new Panel();
            label4 = new Label();
            settingBtn = new CuoreUI.Controls.cuiButton();
            logOutBtn = new CuoreUI.Controls.cuiButton();
            trainerContainerExpand = new System.Windows.Forms.Timer(components);
            memberContainerExpand = new System.Windows.Forms.Timer(components);
            staffContainerExpand = new System.Windows.Forms.Timer(components);
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            trainerContainer.SuspendLayout();
            panel11.SuspendLayout();
            memberContainer.SuspendLayout();
            staffContainer.SuspendLayout();
            panel10.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(50, 81, 88);
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Controls.Add(panel3);
            flowLayoutPanel1.Controls.Add(panel4);
            flowLayoutPanel1.Controls.Add(panel5);
            flowLayoutPanel1.Controls.Add(panel6);
            flowLayoutPanel1.Controls.Add(trainerContainer);
            flowLayoutPanel1.Controls.Add(memberContainer);
            flowLayoutPanel1.Controls.Add(staffContainer);
            flowLayoutPanel1.Controls.Add(attendanceBtn);
            flowLayoutPanel1.Controls.Add(panel10);
            flowLayoutPanel1.Controls.Add(settingBtn);
            flowLayoutPanel1.Controls.Add(logOutBtn);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(201, 565);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(cuiPictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(197, 148);
            panel1.TabIndex = 1;
            // 
            // cuiPictureBox1
            // 
            cuiPictureBox1.BackgroundImage = (Image)resources.GetObject("cuiPictureBox1.BackgroundImage");
            cuiPictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            cuiPictureBox1.Content = null;
            cuiPictureBox1.ImageTint = Color.White;
            cuiPictureBox1.Location = new Point(0, 0);
            cuiPictureBox1.Margin = new Padding(4, 3, 4, 3);
            cuiPictureBox1.Name = "cuiPictureBox1";
            cuiPictureBox1.OutlineThickness = 1F;
            cuiPictureBox1.PanelOutlineColor = Color.Empty;
            cuiPictureBox1.Rotation = 0;
            cuiPictureBox1.Rounding = new Padding(8);
            cuiPictureBox1.Size = new Size(197, 145);
            cuiPictureBox1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Location = new Point(3, 157);
            panel2.Name = "panel2";
            panel2.Size = new Size(197, 23);
            panel2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Poppins", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(15, 0, 0, 0);
            label1.Size = new Size(125, 34);
            label1.TabIndex = 0;
            label1.Text = "TRAINHUB";
            // 
            // panel3
            // 
            panel3.Controls.Add(usernameTxt);
            panel3.Location = new Point(3, 186);
            panel3.Name = "panel3";
            panel3.Size = new Size(197, 23);
            panel3.TabIndex = 3;
            // 
            // usernameTxt
            // 
            usernameTxt.AutoSize = true;
            usernameTxt.Dock = DockStyle.Top;
            usernameTxt.Font = new Font("Inter Medium", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            usernameTxt.ForeColor = Color.White;
            usernameTxt.Location = new Point(0, 0);
            usernameTxt.Name = "usernameTxt";
            usernameTxt.Padding = new Padding(17, 0, 0, 0);
            usernameTxt.Size = new Size(101, 22);
            usernameTxt.TabIndex = 0;
            usernameTxt.Text = "Username";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 222);
            panel4.Margin = new Padding(0, 10, 0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(200, 1);
            panel4.TabIndex = 4;
            // 
            // panel5
            // 
            panel5.Controls.Add(label3);
            panel5.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel5.Location = new Point(3, 238);
            panel5.Margin = new Padding(3, 15, 3, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(197, 23);
            panel5.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("Inter Medium", 6.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Padding = new Padding(17, 7, 0, 0);
            label3.Size = new Size(47, 20);
            label3.TabIndex = 0;
            label3.Text = "MAIN";
            // 
            // panel6
            // 
            panel6.Controls.Add(dashboardBtn);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 270);
            panel6.Margin = new Padding(0, 6, 0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(200, 30);
            panel6.TabIndex = 4;
            // 
            // dashboardBtn
            // 
            dashboardBtn.CheckButton = false;
            dashboardBtn.Checked = false;
            dashboardBtn.CheckedBackground = Color.FromArgb(45, 47, 57);
            dashboardBtn.CheckedForeColor = Color.White;
            dashboardBtn.CheckedImageTint = Color.White;
            dashboardBtn.CheckedOutline = Color.FromArgb(45, 47, 57);
            dashboardBtn.Content = "Dashboard";
            dashboardBtn.DialogResult = DialogResult.None;
            dashboardBtn.Font = new Font("Inter", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dashboardBtn.ForeColor = Color.White;
            dashboardBtn.HoverBackground = Color.FromArgb(45, 47, 57);
            dashboardBtn.HoveredImageTint = Color.White;
            dashboardBtn.HoverForeColor = Color.White;
            dashboardBtn.HoverOutline = Color.FromArgb(45, 47, 57);
            dashboardBtn.Image = (Image)resources.GetObject("dashboardBtn.Image");
            dashboardBtn.ImageAutoCenter = false;
            dashboardBtn.ImageExpand = new Point(0, 0);
            dashboardBtn.ImageOffset = new Point(20, 0);
            dashboardBtn.ImeMode = ImeMode.NoControl;
            dashboardBtn.Location = new Point(0, 0);
            dashboardBtn.Margin = new Padding(0);
            dashboardBtn.Name = "dashboardBtn";
            dashboardBtn.NormalBackground = Color.FromArgb(50, 81, 88);
            dashboardBtn.NormalForeColor = Color.White;
            dashboardBtn.NormalImageTint = Color.White;
            dashboardBtn.NormalOutline = Color.FromArgb(50, 81, 88);
            dashboardBtn.OutlineThickness = 1F;
            dashboardBtn.PressedBackground = Color.WhiteSmoke;
            dashboardBtn.PressedForeColor = Color.FromArgb(32, 32, 32);
            dashboardBtn.PressedImageTint = Color.White;
            dashboardBtn.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            dashboardBtn.RightToLeft = RightToLeft.No;
            dashboardBtn.Rounding = new Padding(0);
            dashboardBtn.Size = new Size(200, 30);
            dashboardBtn.TabIndex = 0;
            dashboardBtn.TextAlignment = StringAlignment.Near;
            dashboardBtn.TextOffset = new Point(28, 0);
            dashboardBtn.Click += dashboardBtn_Click;
            // 
            // trainerContainer
            // 
            trainerContainer.Controls.Add(panel11);
            trainerContainer.Dock = DockStyle.Top;
            trainerContainer.Location = new Point(0, 306);
            trainerContainer.Margin = new Padding(0, 6, 0, 0);
            trainerContainer.Name = "trainerContainer";
            trainerContainer.Size = new Size(200, 30);
            trainerContainer.TabIndex = 5;
            // 
            // panel11
            // 
            panel11.Controls.Add(trainerBtn);
            panel11.Dock = DockStyle.Top;
            panel11.Location = new Point(0, 0);
            panel11.Name = "panel11";
            panel11.Size = new Size(200, 30);
            panel11.TabIndex = 0;
            // 
            // trainerBtn
            // 
            trainerBtn.CheckButton = false;
            trainerBtn.Checked = false;
            trainerBtn.CheckedBackground = Color.FromArgb(45, 47, 57);
            trainerBtn.CheckedForeColor = Color.White;
            trainerBtn.CheckedImageTint = Color.White;
            trainerBtn.CheckedOutline = Color.FromArgb(45, 47, 57);
            trainerBtn.Content = "Trainers";
            trainerBtn.DialogResult = DialogResult.None;
            trainerBtn.Dock = DockStyle.Fill;
            trainerBtn.Font = new Font("Inter", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            trainerBtn.ForeColor = Color.White;
            trainerBtn.HoverBackground = Color.FromArgb(45, 47, 57);
            trainerBtn.HoveredImageTint = Color.White;
            trainerBtn.HoverForeColor = Color.White;
            trainerBtn.HoverOutline = Color.FromArgb(45, 47, 57);
            trainerBtn.Image = (Image)resources.GetObject("trainerBtn.Image");
            trainerBtn.ImageAutoCenter = false;
            trainerBtn.ImageExpand = new Point(0, 0);
            trainerBtn.ImageOffset = new Point(20, 0);
            trainerBtn.Location = new Point(0, 0);
            trainerBtn.Name = "trainerBtn";
            trainerBtn.NormalBackground = Color.FromArgb(50, 81, 88);
            trainerBtn.NormalForeColor = Color.White;
            trainerBtn.NormalImageTint = Color.White;
            trainerBtn.NormalOutline = Color.FromArgb(50, 81, 88);
            trainerBtn.OutlineThickness = 1F;
            trainerBtn.PressedBackground = Color.WhiteSmoke;
            trainerBtn.PressedForeColor = Color.FromArgb(32, 32, 32);
            trainerBtn.PressedImageTint = Color.White;
            trainerBtn.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            trainerBtn.Rounding = new Padding(0);
            trainerBtn.Size = new Size(200, 30);
            trainerBtn.TabIndex = 0;
            trainerBtn.TextAlignment = StringAlignment.Near;
            trainerBtn.TextOffset = new Point(28, 0);
            trainerBtn.Click += trainerBtn_Click;
            // 
            // memberContainer
            // 
            memberContainer.Controls.Add(memberBtn);
            memberContainer.Dock = DockStyle.Top;
            memberContainer.Location = new Point(0, 342);
            memberContainer.Margin = new Padding(0, 6, 0, 0);
            memberContainer.Name = "memberContainer";
            memberContainer.Size = new Size(200, 30);
            memberContainer.TabIndex = 6;
            // 
            // memberBtn
            // 
            memberBtn.CheckButton = false;
            memberBtn.Checked = false;
            memberBtn.CheckedBackground = Color.FromArgb(45, 47, 57);
            memberBtn.CheckedForeColor = Color.White;
            memberBtn.CheckedImageTint = Color.White;
            memberBtn.CheckedOutline = Color.FromArgb(45, 47, 57);
            memberBtn.Content = "Members";
            memberBtn.DialogResult = DialogResult.None;
            memberBtn.Dock = DockStyle.Top;
            memberBtn.Font = new Font("Inter", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            memberBtn.ForeColor = Color.White;
            memberBtn.HoverBackground = Color.FromArgb(45, 47, 57);
            memberBtn.HoveredImageTint = Color.White;
            memberBtn.HoverForeColor = Color.White;
            memberBtn.HoverOutline = Color.FromArgb(45, 47, 57);
            memberBtn.Image = (Image)resources.GetObject("memberBtn.Image");
            memberBtn.ImageAutoCenter = false;
            memberBtn.ImageExpand = new Point(0, 0);
            memberBtn.ImageOffset = new Point(20, 0);
            memberBtn.ImeMode = ImeMode.NoControl;
            memberBtn.Location = new Point(0, 0);
            memberBtn.Margin = new Padding(0);
            memberBtn.Name = "memberBtn";
            memberBtn.NormalBackground = Color.FromArgb(50, 81, 88);
            memberBtn.NormalForeColor = Color.White;
            memberBtn.NormalImageTint = Color.White;
            memberBtn.NormalOutline = Color.FromArgb(50, 81, 88);
            memberBtn.OutlineThickness = 1F;
            memberBtn.PressedBackground = Color.WhiteSmoke;
            memberBtn.PressedForeColor = Color.FromArgb(32, 32, 32);
            memberBtn.PressedImageTint = Color.White;
            memberBtn.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            memberBtn.RightToLeft = RightToLeft.No;
            memberBtn.Rounding = new Padding(0);
            memberBtn.Size = new Size(200, 30);
            memberBtn.TabIndex = 0;
            memberBtn.TextAlignment = StringAlignment.Near;
            memberBtn.TextOffset = new Point(28, 0);
            memberBtn.Click += memberBtn_Click;
            // 
            // staffContainer
            // 
            staffContainer.Controls.Add(staffBtn);
            staffContainer.Dock = DockStyle.Top;
            staffContainer.Location = new Point(0, 378);
            staffContainer.Margin = new Padding(0, 6, 0, 0);
            staffContainer.Name = "staffContainer";
            staffContainer.Size = new Size(200, 30);
            staffContainer.TabIndex = 7;
            // 
            // staffBtn
            // 
            staffBtn.CheckButton = false;
            staffBtn.Checked = false;
            staffBtn.CheckedBackground = Color.FromArgb(45, 47, 57);
            staffBtn.CheckedForeColor = Color.White;
            staffBtn.CheckedImageTint = Color.White;
            staffBtn.CheckedOutline = Color.FromArgb(45, 47, 57);
            staffBtn.Content = "Staffs";
            staffBtn.DialogResult = DialogResult.None;
            staffBtn.Dock = DockStyle.Top;
            staffBtn.Font = new Font("Inter", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            staffBtn.ForeColor = Color.White;
            staffBtn.HoverBackground = Color.FromArgb(45, 47, 57);
            staffBtn.HoveredImageTint = Color.White;
            staffBtn.HoverForeColor = Color.White;
            staffBtn.HoverOutline = Color.FromArgb(45, 47, 57);
            staffBtn.Image = (Image)resources.GetObject("staffBtn.Image");
            staffBtn.ImageAutoCenter = false;
            staffBtn.ImageExpand = new Point(0, 0);
            staffBtn.ImageOffset = new Point(20, 0);
            staffBtn.ImeMode = ImeMode.NoControl;
            staffBtn.Location = new Point(0, 0);
            staffBtn.Margin = new Padding(0);
            staffBtn.Name = "staffBtn";
            staffBtn.NormalBackground = Color.FromArgb(50, 81, 88);
            staffBtn.NormalForeColor = Color.White;
            staffBtn.NormalImageTint = Color.White;
            staffBtn.NormalOutline = Color.FromArgb(50, 81, 88);
            staffBtn.OutlineThickness = 1F;
            staffBtn.PressedBackground = Color.WhiteSmoke;
            staffBtn.PressedForeColor = Color.FromArgb(32, 32, 32);
            staffBtn.PressedImageTint = Color.White;
            staffBtn.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            staffBtn.RightToLeft = RightToLeft.No;
            staffBtn.Rounding = new Padding(0);
            staffBtn.Size = new Size(200, 30);
            staffBtn.TabIndex = 0;
            staffBtn.TextAlignment = StringAlignment.Near;
            staffBtn.TextOffset = new Point(28, 0);
            staffBtn.Click += staffBtn_Click;
            // 
            // attendanceBtn
            // 
            attendanceBtn.CheckButton = false;
            attendanceBtn.Checked = false;
            attendanceBtn.CheckedBackground = Color.FromArgb(45, 47, 57);
            attendanceBtn.CheckedForeColor = Color.White;
            attendanceBtn.CheckedImageTint = Color.White;
            attendanceBtn.CheckedOutline = Color.FromArgb(45, 47, 57);
            attendanceBtn.Content = "Attendance";
            attendanceBtn.DialogResult = DialogResult.None;
            attendanceBtn.Dock = DockStyle.Top;
            attendanceBtn.Font = new Font("Inter", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            attendanceBtn.ForeColor = Color.White;
            attendanceBtn.HoverBackground = Color.FromArgb(45, 47, 57);
            attendanceBtn.HoveredImageTint = Color.White;
            attendanceBtn.HoverForeColor = Color.White;
            attendanceBtn.HoverOutline = Color.FromArgb(45, 47, 57);
            attendanceBtn.Image = (Image)resources.GetObject("attendanceBtn.Image");
            attendanceBtn.ImageAutoCenter = false;
            attendanceBtn.ImageExpand = new Point(0, 0);
            attendanceBtn.ImageOffset = new Point(20, 0);
            attendanceBtn.ImeMode = ImeMode.NoControl;
            attendanceBtn.Location = new Point(0, 408);
            attendanceBtn.Margin = new Padding(0);
            attendanceBtn.Name = "attendanceBtn";
            attendanceBtn.NormalBackground = Color.FromArgb(50, 81, 88);
            attendanceBtn.NormalForeColor = Color.White;
            attendanceBtn.NormalImageTint = Color.White;
            attendanceBtn.NormalOutline = Color.FromArgb(50, 81, 88);
            attendanceBtn.OutlineThickness = 1F;
            attendanceBtn.PressedBackground = Color.WhiteSmoke;
            attendanceBtn.PressedForeColor = Color.FromArgb(32, 32, 32);
            attendanceBtn.PressedImageTint = Color.White;
            attendanceBtn.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            attendanceBtn.RightToLeft = RightToLeft.No;
            attendanceBtn.Rounding = new Padding(0);
            attendanceBtn.Size = new Size(200, 30);
            attendanceBtn.TabIndex = 8;
            attendanceBtn.TextAlignment = StringAlignment.Near;
            attendanceBtn.TextOffset = new Point(28, 0);
            attendanceBtn.Click += attendanceBtn_Click;
            // 
            // panel10
            // 
            panel10.Controls.Add(label4);
            panel10.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel10.Location = new Point(3, 458);
            panel10.Margin = new Padding(3, 20, 3, 3);
            panel10.Name = "panel10";
            panel10.Size = new Size(197, 23);
            panel10.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("Inter Medium", 6.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Padding = new Padding(17, 7, 0, 0);
            label4.Size = new Size(69, 20);
            label4.TabIndex = 0;
            label4.Text = "SETTINGS";
            // 
            // settingBtn
            // 
            settingBtn.CheckButton = false;
            settingBtn.Checked = false;
            settingBtn.CheckedBackground = Color.FromArgb(45, 47, 57);
            settingBtn.CheckedForeColor = Color.White;
            settingBtn.CheckedImageTint = Color.White;
            settingBtn.CheckedOutline = Color.FromArgb(45, 47, 57);
            settingBtn.Content = "Settings";
            settingBtn.DialogResult = DialogResult.None;
            settingBtn.Dock = DockStyle.Top;
            settingBtn.Font = new Font("Inter", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            settingBtn.ForeColor = Color.White;
            settingBtn.HoverBackground = Color.FromArgb(45, 47, 57);
            settingBtn.HoveredImageTint = Color.White;
            settingBtn.HoverForeColor = Color.White;
            settingBtn.HoverOutline = Color.FromArgb(45, 47, 57);
            settingBtn.Image = (Image)resources.GetObject("settingBtn.Image");
            settingBtn.ImageAutoCenter = false;
            settingBtn.ImageExpand = new Point(0, 0);
            settingBtn.ImageOffset = new Point(20, 0);
            settingBtn.ImeMode = ImeMode.NoControl;
            settingBtn.Location = new Point(0, 484);
            settingBtn.Margin = new Padding(0);
            settingBtn.Name = "settingBtn";
            settingBtn.NormalBackground = Color.FromArgb(50, 81, 88);
            settingBtn.NormalForeColor = Color.White;
            settingBtn.NormalImageTint = Color.White;
            settingBtn.NormalOutline = Color.FromArgb(50, 81, 88);
            settingBtn.OutlineThickness = 1F;
            settingBtn.PressedBackground = Color.WhiteSmoke;
            settingBtn.PressedForeColor = Color.FromArgb(32, 32, 32);
            settingBtn.PressedImageTint = Color.White;
            settingBtn.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            settingBtn.RightToLeft = RightToLeft.No;
            settingBtn.Rounding = new Padding(0);
            settingBtn.Size = new Size(201, 30);
            settingBtn.TabIndex = 12;
            settingBtn.TextAlignment = StringAlignment.Near;
            settingBtn.TextOffset = new Point(28, 0);
            settingBtn.Click += settingBtn_Click;
            // 
            // logOutBtn
            // 
            logOutBtn.CheckButton = false;
            logOutBtn.Checked = false;
            logOutBtn.CheckedBackground = Color.FromArgb(45, 47, 57);
            logOutBtn.CheckedForeColor = Color.OrangeRed;
            logOutBtn.CheckedImageTint = Color.White;
            logOutBtn.CheckedOutline = Color.FromArgb(45, 47, 57);
            logOutBtn.Content = "Log Out";
            logOutBtn.DialogResult = DialogResult.None;
            logOutBtn.Dock = DockStyle.Top;
            logOutBtn.Font = new Font("Inter", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logOutBtn.ForeColor = Color.OrangeRed;
            logOutBtn.HoverBackground = Color.FromArgb(45, 47, 57);
            logOutBtn.HoveredImageTint = Color.White;
            logOutBtn.HoverForeColor = Color.OrangeRed;
            logOutBtn.HoverOutline = Color.FromArgb(45, 47, 57);
            logOutBtn.Image = (Image)resources.GetObject("logOutBtn.Image");
            logOutBtn.ImageAutoCenter = false;
            logOutBtn.ImageExpand = new Point(0, 0);
            logOutBtn.ImageOffset = new Point(20, 0);
            logOutBtn.ImeMode = ImeMode.NoControl;
            logOutBtn.Location = new Point(0, 514);
            logOutBtn.Margin = new Padding(0);
            logOutBtn.Name = "logOutBtn";
            logOutBtn.NormalBackground = Color.FromArgb(50, 81, 88);
            logOutBtn.NormalForeColor = Color.OrangeRed;
            logOutBtn.NormalImageTint = Color.White;
            logOutBtn.NormalOutline = Color.FromArgb(50, 81, 88);
            logOutBtn.OutlineThickness = 1F;
            logOutBtn.PressedBackground = Color.WhiteSmoke;
            logOutBtn.PressedForeColor = Color.OrangeRed;
            logOutBtn.PressedImageTint = Color.White;
            logOutBtn.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            logOutBtn.RightToLeft = RightToLeft.No;
            logOutBtn.Rounding = new Padding(0);
            logOutBtn.Size = new Size(201, 30);
            logOutBtn.TabIndex = 13;
            logOutBtn.TextAlignment = StringAlignment.Near;
            logOutBtn.TextOffset = new Point(28, 0);
            logOutBtn.Click += logOutBtn_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(786, 565);
            Controls.Add(flowLayoutPanel1);
            IsMdiContainer = true;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TrainHub";
            Load += dashboardBtn_Click;
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            trainerContainer.ResumeLayout(false);
            panel11.ResumeLayout(false);
            memberContainer.ResumeLayout(false);
            staffContainer.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox1;
        private Panel panel2;
        private Label label1;
        private Panel panel3;
        private Label usernameTxt;
        private Panel panel4;
        private Panel panel5;
        private Label label3;
        private Panel panel6;
        private CuoreUI.Controls.cuiButton dashboardBtn;
        private Panel trainerContainer;
        private Panel panel11;
        private CuoreUI.Controls.cuiButton trainerBtn;
        private Panel memberContainer;
        private CuoreUI.Controls.cuiButton memberBtn;
        private Panel staffContainer;
        private CuoreUI.Controls.cuiButton staffBtn;
        private System.Windows.Forms.Timer trainerContainerExpand;
        private System.Windows.Forms.Timer memberContainerExpand;
        private System.Windows.Forms.Timer staffContainerExpand;
        private Panel panel10;
        private Label label4;
        private CuoreUI.Controls.cuiButton attendanceBtn;
        private CuoreUI.Controls.cuiButton settingBtn;
        private CuoreUI.Controls.cuiButton logOutBtn;
    }
}