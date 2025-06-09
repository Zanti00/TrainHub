namespace TrainHub
{
    partial class logoutConfirm
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
            label1 = new Label();
            label2 = new Label();
            logOutBtn = new CuoreUI.Controls.cuiButton();
            cancelLogOutBtn = new CuoreUI.Controls.cuiButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Open Sans", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(50, 81, 88);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(242, 42);
            label1.TabIndex = 0;
            label1.Text = "Confirm Log Out";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Inter Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(50, 81, 88);
            label2.Location = new Point(18, 51);
            label2.Name = "label2";
            label2.Size = new Size(265, 23);
            label2.TabIndex = 1;
            label2.Text = "Are you sure you want to log out?";
            // 
            // logOutBtn
            // 
            logOutBtn.BackColor = Color.White;
            logOutBtn.CheckButton = false;
            logOutBtn.Checked = false;
            logOutBtn.CheckedBackground = Color.FromArgb(50, 81, 88);
            logOutBtn.CheckedForeColor = Color.White;
            logOutBtn.CheckedImageTint = Color.White;
            logOutBtn.CheckedOutline = Color.FromArgb(50, 81, 88);
            logOutBtn.Content = "Log out";
            logOutBtn.DialogResult = DialogResult.None;
            logOutBtn.Font = new Font("Microsoft Sans Serif", 9.75F);
            logOutBtn.ForeColor = Color.White;
            logOutBtn.HoverBackground = Color.FromArgb(22, 36, 39);
            logOutBtn.HoveredImageTint = Color.White;
            logOutBtn.HoverForeColor = Color.White;
            logOutBtn.HoverOutline = Color.FromArgb(22, 36, 39);
            logOutBtn.Image = null;
            logOutBtn.ImageAutoCenter = true;
            logOutBtn.ImageExpand = new Point(0, 0);
            logOutBtn.ImageOffset = new Point(0, 0);
            logOutBtn.Location = new Point(224, 90);
            logOutBtn.Name = "logOutBtn";
            logOutBtn.NormalBackground = Color.FromArgb(50, 81, 88);
            logOutBtn.NormalForeColor = Color.White;
            logOutBtn.NormalImageTint = Color.White;
            logOutBtn.NormalOutline = Color.FromArgb(50, 81, 88);
            logOutBtn.OutlineThickness = 1F;
            logOutBtn.PressedBackground = Color.FromArgb(22, 36, 39);
            logOutBtn.PressedForeColor = Color.White;
            logOutBtn.PressedImageTint = Color.White;
            logOutBtn.PressedOutline = Color.FromArgb(22, 36, 39);
            logOutBtn.RightToLeft = RightToLeft.No;
            logOutBtn.Rounding = new Padding(8);
            logOutBtn.Size = new Size(82, 41);
            logOutBtn.TabIndex = 2;
            logOutBtn.TextAlignment = StringAlignment.Center;
            logOutBtn.TextOffset = new Point(0, 0);
            logOutBtn.Click += logOutBtn_Click;
            // 
            // cancelLogOutBtn
            // 
            cancelLogOutBtn.CheckButton = false;
            cancelLogOutBtn.Checked = false;
            cancelLogOutBtn.CheckedBackground = Color.White;
            cancelLogOutBtn.CheckedForeColor = Color.Black;
            cancelLogOutBtn.CheckedImageTint = Color.White;
            cancelLogOutBtn.CheckedOutline = Color.WhiteSmoke;
            cancelLogOutBtn.Content = "Cancel";
            cancelLogOutBtn.DialogResult = DialogResult.None;
            cancelLogOutBtn.Font = new Font("Microsoft Sans Serif", 9.75F);
            cancelLogOutBtn.ForeColor = Color.Black;
            cancelLogOutBtn.HoverBackground = Color.WhiteSmoke;
            cancelLogOutBtn.HoveredImageTint = Color.White;
            cancelLogOutBtn.HoverForeColor = Color.Black;
            cancelLogOutBtn.HoverOutline = Color.WhiteSmoke;
            cancelLogOutBtn.Image = null;
            cancelLogOutBtn.ImageAutoCenter = true;
            cancelLogOutBtn.ImageExpand = new Point(0, 0);
            cancelLogOutBtn.ImageOffset = new Point(0, 0);
            cancelLogOutBtn.Location = new Point(127, 90);
            cancelLogOutBtn.Name = "cancelLogOutBtn";
            cancelLogOutBtn.NormalBackground = Color.White;
            cancelLogOutBtn.NormalForeColor = Color.Black;
            cancelLogOutBtn.NormalImageTint = Color.White;
            cancelLogOutBtn.NormalOutline = Color.WhiteSmoke;
            cancelLogOutBtn.OutlineThickness = 2F;
            cancelLogOutBtn.PressedBackground = Color.WhiteSmoke;
            cancelLogOutBtn.PressedForeColor = Color.Black;
            cancelLogOutBtn.PressedImageTint = Color.White;
            cancelLogOutBtn.PressedOutline = Color.WhiteSmoke;
            cancelLogOutBtn.Rounding = new Padding(8);
            cancelLogOutBtn.Size = new Size(82, 41);
            cancelLogOutBtn.TabIndex = 3;
            cancelLogOutBtn.TextAlignment = StringAlignment.Center;
            cancelLogOutBtn.TextOffset = new Point(0, 0);
            cancelLogOutBtn.Click += cancelLogOutBtn_Click;
            // 
            // logoutConfirm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(329, 152);
            Controls.Add(cancelLogOutBtn);
            Controls.Add(logOutBtn);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "logoutConfirm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "logoutConfirm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private CuoreUI.Controls.cuiButton logOutBtn;
        private CuoreUI.Controls.cuiButton cancelLogOutBtn;
    }
}