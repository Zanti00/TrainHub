namespace TrainHub
{
    partial class ForgotPassword
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
            panel1 = new Panel();
            emailTxt = new TrainHub.User_Controls.CustomTextFields();
            sendEmailBtn = new CustomButton();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            backBtn = new TrainHub.User_Controls.CustomBackButton();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Window;
            panel1.Controls.Add(emailTxt);
            panel1.Controls.Add(sendEmailBtn);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(73, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(635, 502);
            panel1.TabIndex = 0;
            // 
            // emailTxt
            // 
            emailTxt.Anchor = AnchorStyles.None;
            emailTxt.BackColor = Color.Transparent;
            emailTxt.Location = new Point(101, 234);
            emailTxt.Name = "emailTxt";
            emailTxt.PasswordChar = false;
            emailTxt.PlaceHolderText = "Enter your text";
            emailTxt.Size = new Size(317, 42);
            emailTxt.TabIndex = 5;
            emailTxt.TextContent = "";
            // 
            // sendEmailBtn
            // 
            sendEmailBtn.AccessibleName = "";
            sendEmailBtn.Anchor = AnchorStyles.None;
            sendEmailBtn.BackColor = Color.Transparent;
            sendEmailBtn.ButtonContent = "BUTTON";
            sendEmailBtn.Location = new Point(99, 282);
            sendEmailBtn.Name = "sendEmailBtn";
            sendEmailBtn.Size = new Size(321, 43);
            sendEmailBtn.TabIndex = 4;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(130, 130, 130);
            label3.Location = new Point(102, 213);
            label3.Margin = new Padding(10, 15, 3, 0);
            label3.Name = "label3";
            label3.Size = new Size(172, 15);
            label3.TabIndex = 2;
            label3.Text = "Please enter your email address";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(50, 81, 88);
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(96, 133);
            label1.Name = "label1";
            label1.Size = new Size(142, 37);
            label1.TabIndex = 0;
            label1.Text = "TrainHub";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.ForeColor = Color.FromArgb(0, 0, 64);
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(98, 170);
            label2.Margin = new Padding(5, 0, 3, 0);
            label2.Name = "label2";
            label2.Size = new Size(158, 28);
            label2.TabIndex = 1;
            label2.Text = "Forgot Password";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 70F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel1, 1, 0);
            tableLayoutPanel1.Controls.Add(backBtn, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(711, 508);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // backBtn
            // 
            backBtn.BackColor = Color.Transparent;
            backBtn.Location = new Point(3, 3);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(64, 52);
            backBtn.TabIndex = 1;
            // 
            // ForgotPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(711, 508);
            Controls.Add(tableLayoutPanel1);
            Name = "ForgotPassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Forgot Password";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private CuoreUI.Controls.cuiButtonGroup cuiButtonGroup1;
        private TableLayoutPanel tableLayoutPanel1;
        private CustomButton sendEmailBtn;
        private User_Controls.CustomTextFields emailTxt;
        private User_Controls.CustomBackButton backBtn;
    }
}