namespace TrainHub
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            welcomeLabel = new Label();
            forgotPasswordLink = new LinkLabel();
            label2 = new Label();
            cuiPanel1 = new CuoreUI.Controls.cuiPanel();
            showPassBtn = new PictureBox();
            loginBtn = new CuoreUI.Controls.cuiButtonGroup();
            passwordTxt = new CuoreUI.Controls.cuiTextBox();
            emailTxt = new CuoreUI.Controls.cuiTextBox();
            cuiPictureBox1 = new CuoreUI.Controls.cuiPictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            cuiPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)showPassBtn).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // welcomeLabel
            // 
            welcomeLabel.AutoSize = true;
            welcomeLabel.BackColor = Color.White;
            welcomeLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            welcomeLabel.ForeColor = Color.FromArgb(50, 81, 88);
            welcomeLabel.Location = new Point(96, 188);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(110, 20);
            welcomeLabel.TabIndex = 6;
            welcomeLabel.Text = "Welcome back";
            welcomeLabel.Click += welcomeLabel_Click;
            // 
            // forgotPasswordLink
            // 
            forgotPasswordLink.AutoSize = true;
            forgotPasswordLink.LinkColor = Color.FromArgb(50, 81, 88);
            forgotPasswordLink.Location = new Point(150, 289);
            forgotPasswordLink.Name = "forgotPasswordLink";
            forgotPasswordLink.Size = new Size(95, 15);
            forgotPasswordLink.TabIndex = 5;
            forgotPasswordLink.TabStop = true;
            forgotPasswordLink.Text = "Forgot Password";
            forgotPasswordLink.LinkClicked += forgotPasswordLink_LinkClicked;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
            label2.ForeColor = SystemColors.Window;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(408, 543);
            label2.TabIndex = 1;
            label2.Text = resources.GetString("label2.Text");
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cuiPanel1
            // 
            cuiPanel1.Anchor = AnchorStyles.None;
            cuiPanel1.BackColor = Color.Transparent;
            cuiPanel1.Controls.Add(showPassBtn);
            cuiPanel1.Controls.Add(loginBtn);
            cuiPanel1.Controls.Add(passwordTxt);
            cuiPanel1.Controls.Add(emailTxt);
            cuiPanel1.Controls.Add(cuiPictureBox1);
            cuiPanel1.Controls.Add(welcomeLabel);
            cuiPanel1.Controls.Add(forgotPasswordLink);
            cuiPanel1.Location = new Point(471, 30);
            cuiPanel1.Name = "cuiPanel1";
            cuiPanel1.OutlineThickness = 1F;
            cuiPanel1.PanelColor = Color.White;
            cuiPanel1.PanelOutlineColor = Color.White;
            cuiPanel1.Rounding = new Padding(20);
            cuiPanel1.Size = new Size(299, 489);
            cuiPanel1.TabIndex = 2;
            cuiPanel1.Paint += cuiPanel1_Paint;
            // 
            // showPassBtn
            // 
            showPassBtn.BackColor = Color.White;
            showPassBtn.BackgroundImage = (Image)resources.GetObject("showPassBtn.BackgroundImage");
            showPassBtn.BackgroundImageLayout = ImageLayout.Zoom;
            showPassBtn.Location = new Point(216, 261);
            showPassBtn.Name = "showPassBtn";
            showPassBtn.Size = new Size(21, 23);
            showPassBtn.TabIndex = 13;
            showPassBtn.TabStop = false;
            showPassBtn.Click += showPassBtn_Click;
            // 
            // loginBtn
            // 
            loginBtn.BackColor = Color.Transparent;
            loginBtn.Checked = false;
            loginBtn.CheckedBackground = Color.FromArgb(50, 81, 88);
            loginBtn.CheckedForeColor = Color.White;
            loginBtn.CheckedImageTint = Color.White;
            loginBtn.CheckedOutline = Color.FromArgb(50, 81, 88);
            loginBtn.Content = "LOGIN";
            loginBtn.Font = new Font("Microsoft Sans Serif", 9.75F);
            loginBtn.ForeColor = Color.White;
            loginBtn.Group = 0;
            loginBtn.HoverBackground = Color.FromArgb(22, 36, 39);
            loginBtn.HoveredImageTint = Color.White;
            loginBtn.HoverForeColor = Color.White;
            loginBtn.HoverOutline = Color.FromArgb(22, 36, 39);
            loginBtn.Image = null;
            loginBtn.ImageAutoCenter = true;
            loginBtn.ImageExpand = new Point(0, 0);
            loginBtn.ImageOffset = new Point(0, 0);
            loginBtn.Location = new Point(82, 336);
            loginBtn.Name = "loginBtn";
            loginBtn.NormalBackground = Color.FromArgb(50, 81, 88);
            loginBtn.NormalForeColor = Color.White;
            loginBtn.NormalImageTint = Color.White;
            loginBtn.NormalOutline = Color.FromArgb(50, 81, 88);
            loginBtn.OutlineThickness = 1F;
            loginBtn.PressedBackground = Color.FromArgb(22, 36, 39);
            loginBtn.PressedForeColor = Color.White;
            loginBtn.PressedImageTint = Color.White;
            loginBtn.PressedOutline = Color.FromArgb(22, 36, 39);
            loginBtn.Rounding = new Padding(3);
            loginBtn.Size = new Size(141, 28);
            loginBtn.TabIndex = 12;
            loginBtn.TextAlignment = StringAlignment.Center;
            loginBtn.TextOffset = new Point(0, 0);
            loginBtn.Click += loginBtn_Click;
            // 
            // passwordTxt
            // 
            passwordTxt.BackColor = Color.Transparent;
            passwordTxt.BackgroundColor = Color.White;
            passwordTxt.BorderColor = Color.FromArgb(50, 81, 88);
            passwordTxt.Content = "";
            passwordTxt.FocusBackgroundColor = Color.White;
            passwordTxt.FocusBorderColor = Color.FromArgb(50, 81, 88);
            passwordTxt.FocusImageTint = Color.White;
            passwordTxt.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordTxt.ForeColor = Color.Black;
            passwordTxt.Image = null;
            passwordTxt.ImageExpand = new Point(0, 0);
            passwordTxt.ImageOffset = new Point(0, 0);
            passwordTxt.Location = new Point(54, 258);
            passwordTxt.Margin = new Padding(4);
            passwordTxt.Multiline = false;
            passwordTxt.Name = "passwordTxt";
            passwordTxt.NormalImageTint = Color.White;
            passwordTxt.Padding = new Padding(13, 7, 13, 0);
            passwordTxt.PasswordChar = true;
            passwordTxt.PlaceholderColor = SystemColors.ScrollBar;
            passwordTxt.PlaceholderText = "Password";
            passwordTxt.Rounding = new Padding(6);
            passwordTxt.Size = new Size(191, 27);
            passwordTxt.TabIndex = 11;
            passwordTxt.TextOffset = new Size(0, 0);
            passwordTxt.UnderlinedStyle = false;
            // 
            // emailTxt
            // 
            emailTxt.BackColor = Color.Transparent;
            emailTxt.BackgroundColor = Color.White;
            emailTxt.BorderColor = Color.FromArgb(50, 81, 88);
            emailTxt.Content = "";
            emailTxt.FocusBackgroundColor = Color.White;
            emailTxt.FocusBorderColor = Color.FromArgb(50, 81, 88);
            emailTxt.FocusImageTint = Color.White;
            emailTxt.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailTxt.ForeColor = Color.Black;
            emailTxt.Image = null;
            emailTxt.ImageExpand = new Point(0, 0);
            emailTxt.ImageOffset = new Point(0, 0);
            emailTxt.Location = new Point(54, 223);
            emailTxt.Margin = new Padding(4);
            emailTxt.Multiline = false;
            emailTxt.Name = "emailTxt";
            emailTxt.NormalImageTint = Color.White;
            emailTxt.Padding = new Padding(13, 7, 13, 0);
            emailTxt.PasswordChar = false;
            emailTxt.PlaceholderColor = SystemColors.ScrollBar;
            emailTxt.PlaceholderText = "Email";
            emailTxt.Rounding = new Padding(6);
            emailTxt.Size = new Size(191, 27);
            emailTxt.TabIndex = 10;
            emailTxt.TextOffset = new Size(0, 0);
            emailTxt.UnderlinedStyle = false;
            emailTxt.ContentChanged += emailTxt_ContentChanged;
            // 
            // cuiPictureBox1
            // 
            cuiPictureBox1.BackgroundImage = (Image)resources.GetObject("cuiPictureBox1.BackgroundImage");
            cuiPictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            cuiPictureBox1.Content = null;
            cuiPictureBox1.Dock = DockStyle.Top;
            cuiPictureBox1.ImageTint = Color.Transparent;
            cuiPictureBox1.ImeMode = ImeMode.Hiragana;
            cuiPictureBox1.Location = new Point(0, 0);
            cuiPictureBox1.Margin = new Padding(4, 3, 4, 3);
            cuiPictureBox1.Name = "cuiPictureBox1";
            cuiPictureBox1.OutlineThickness = 1F;
            cuiPictureBox1.PanelOutlineColor = Color.Empty;
            cuiPictureBox1.Rotation = 0;
            cuiPictureBox1.Rounding = new Padding(8);
            cuiPictureBox1.Size = new Size(299, 166);
            cuiPictureBox1.TabIndex = 9;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackgroundImage = (Image)resources.GetObject("tableLayoutPanel1.BackgroundImage");
            tableLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(cuiPanel1, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(828, 549);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(408, 543);
            panel1.TabIndex = 6;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(828, 549);
            Controls.Add(tableLayoutPanel1);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Form1_Load;
            cuiPanel1.ResumeLayout(false);
            cuiPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)showPassBtn).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private LinkLabel forgotPasswordLink;
        private Label welcomeLabel;
        private Label label2;
        private CuoreUI.Controls.cuiPanel cuiPanel1;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox1;
        private CuoreUI.Controls.cuiTextBox emailTxt;
        private CuoreUI.Controls.cuiTextBox passwordTxt;
        private CuoreUI.Controls.cuiButtonGroup loginBtn;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private PictureBox showPassBtn;
    }
}
