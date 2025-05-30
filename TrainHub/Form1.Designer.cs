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
            loginPanel = new Panel();
            linkLabel1 = new LinkLabel();
            loginBtn = new Button();
            welcomeLabel = new Label();
            forgotPasswordLink = new LinkLabel();
            passwordTxt = new TextBox();
            emailTxt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            loginPanel.SuspendLayout();
            SuspendLayout();
            // 
            // loginPanel
            // 
            loginPanel.BackColor = Color.White;
            loginPanel.Controls.Add(linkLabel1);
            loginPanel.Controls.Add(loginBtn);
            loginPanel.Controls.Add(welcomeLabel);
            loginPanel.Controls.Add(forgotPasswordLink);
            loginPanel.Controls.Add(passwordTxt);
            loginPanel.Controls.Add(emailTxt);
            loginPanel.Controls.Add(label1);
            loginPanel.Cursor = Cursors.IBeam;
            loginPanel.Dock = DockStyle.Right;
            loginPanel.Location = new Point(380, 50);
            loginPanel.Name = "loginPanel";
            loginPanel.Size = new Size(318, 350);
            loginPanel.TabIndex = 0;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.FromArgb(50, 81, 88);
            linkLabel1.Location = new Point(168, 247);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(88, 15);
            linkLabel1.TabIndex = 8;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Login as admin";
            // 
            // loginBtn
            // 
            loginBtn.BackColor = Color.FromArgb(50, 81, 88);
            loginBtn.FlatAppearance.BorderSize = 0;
            loginBtn.FlatStyle = FlatStyle.Flat;
            loginBtn.ForeColor = SystemColors.Window;
            loginBtn.Location = new Point(93, 285);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(141, 23);
            loginBtn.TabIndex = 7;
            loginBtn.Text = "LOGIN";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += loginBtn_Click;
            // 
            // welcomeLabel
            // 
            welcomeLabel.AutoSize = true;
            welcomeLabel.BackColor = Color.White;
            welcomeLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            welcomeLabel.ForeColor = Color.FromArgb(50, 81, 88);
            welcomeLabel.Location = new Point(107, 135);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(110, 20);
            welcomeLabel.TabIndex = 6;
            welcomeLabel.Text = "Welcome back";
            // 
            // forgotPasswordLink
            // 
            forgotPasswordLink.AutoSize = true;
            forgotPasswordLink.LinkColor = Color.FromArgb(50, 81, 88);
            forgotPasswordLink.Location = new Point(122, 311);
            forgotPasswordLink.Name = "forgotPasswordLink";
            forgotPasswordLink.Size = new Size(95, 15);
            forgotPasswordLink.TabIndex = 5;
            forgotPasswordLink.TabStop = true;
            forgotPasswordLink.Text = "Forgot Password";
            // 
            // passwordTxt
            // 
            passwordTxt.BackColor = SystemColors.Window;
            passwordTxt.BorderStyle = BorderStyle.FixedSingle;
            passwordTxt.Location = new Point(65, 221);
            passwordTxt.Name = "passwordTxt";
            passwordTxt.PlaceholderText = "Password";
            passwordTxt.Size = new Size(191, 23);
            passwordTxt.TabIndex = 3;
            passwordTxt.Tag = "";
            passwordTxt.UseSystemPasswordChar = true;
            // 
            // emailTxt
            // 
            emailTxt.BackColor = SystemColors.Window;
            emailTxt.BorderStyle = BorderStyle.FixedSingle;
            emailTxt.Location = new Point(65, 183);
            emailTxt.Name = "emailTxt";
            emailTxt.PlaceholderText = "Email";
            emailTxt.Size = new Size(191, 23);
            emailTxt.TabIndex = 1;
            emailTxt.Tag = "";
            // 
            // label1
            // 
            label1.AccessibleRole = AccessibleRole.SplitButton;
            label1.Font = new Font("Segoe UI", 20F);
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(93, 52);
            label1.Name = "label1";
            label1.Size = new Size(137, 41);
            label1.TabIndex = 0;
            label1.Text = "Logo here";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            label2.ForeColor = SystemColors.Window;
            label2.Location = new Point(31, 196);
            label2.Name = "label2";
            label2.Size = new Size(332, 60);
            label2.TabIndex = 1;
            label2.Text = resources.GetString("label2.Text");
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.garrett_butler_UrJ_fn2iRUM_unsplash;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(728, 450);
            Controls.Add(label2);
            Controls.Add(loginPanel);
            Name = "Login";
            Padding = new Padding(0, 50, 30, 50);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            loginPanel.ResumeLayout(false);
            loginPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel loginPanel;
        private Label label1;
        private TextBox emailTxt;
        private TextBox passwordTxt;
        private LinkLabel forgotPasswordLink;
        private Label welcomeLabel;
        private Button loginBtn;
        private LinkLabel linkLabel1;
        private Label label2;
    }
}
