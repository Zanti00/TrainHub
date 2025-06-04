namespace TrainHub
{
    partial class PasswordResetSuccessful
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordResetSuccessful));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            successContinueBtn = new CuoreUI.Controls.cuiButton();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(successContinueBtn);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(748, 455);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(314, 80);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(153, 112);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // successContinueBtn
            // 
            successContinueBtn.Anchor = AnchorStyles.None;
            successContinueBtn.BackColor = Color.Transparent;
            successContinueBtn.CheckButton = false;
            successContinueBtn.Checked = false;
            successContinueBtn.CheckedBackground = Color.FromArgb(50, 81, 88);
            successContinueBtn.CheckedForeColor = Color.White;
            successContinueBtn.CheckedImageTint = Color.White;
            successContinueBtn.CheckedOutline = Color.FromArgb(50, 81, 88);
            successContinueBtn.Content = "CONTINUE";
            successContinueBtn.DialogResult = DialogResult.None;
            successContinueBtn.Font = new Font("Microsoft Sans Serif", 8F);
            successContinueBtn.ForeColor = Color.White;
            successContinueBtn.HoverBackground = Color.FromArgb(22, 36, 39);
            successContinueBtn.HoveredImageTint = Color.White;
            successContinueBtn.HoverForeColor = Color.White;
            successContinueBtn.HoverOutline = Color.FromArgb(22, 36, 39);
            successContinueBtn.Image = null;
            successContinueBtn.ImageAutoCenter = true;
            successContinueBtn.ImageExpand = new Point(0, 0);
            successContinueBtn.ImageOffset = new Point(0, 0);
            successContinueBtn.Location = new Point(231, 275);
            successContinueBtn.Name = "successContinueBtn";
            successContinueBtn.NormalBackground = Color.FromArgb(50, 81, 88);
            successContinueBtn.NormalForeColor = Color.White;
            successContinueBtn.NormalImageTint = Color.White;
            successContinueBtn.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            successContinueBtn.OutlineThickness = 1F;
            successContinueBtn.PressedBackground = Color.FromArgb(22, 36, 39);
            successContinueBtn.PressedForeColor = Color.White;
            successContinueBtn.PressedImageTint = Color.White;
            successContinueBtn.PressedOutline = Color.FromArgb(22, 36, 39);
            successContinueBtn.Rounding = new Padding(3);
            successContinueBtn.Size = new Size(313, 35);
            successContinueBtn.TabIndex = 5;
            successContinueBtn.TextAlignment = StringAlignment.Center;
            successContinueBtn.TextOffset = new Point(0, 0);
            successContinueBtn.Click += successContinueBtn_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(130, 130, 130);
            label3.Location = new Point(278, 247);
            label3.Margin = new Padding(10, 15, 3, 0);
            label3.Name = "label3";
            label3.Size = new Size(228, 15);
            label3.TabIndex = 3;
            label3.Text = "Your password has been reset successfully";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 25F);
            label2.ForeColor = Color.FromArgb(0, 0, 64);
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(307, 195);
            label2.Margin = new Padding(5, 0, 3, 0);
            label2.Name = "label2";
            label2.Size = new Size(173, 46);
            label2.TabIndex = 2;
            label2.Text = "Successful";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // PasswordResetSuccessful
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(748, 455);
            Controls.Add(panel1);
            Name = "PasswordResetSuccessful";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label3;
        private CuoreUI.Controls.cuiButton successContinueBtn;
        private PictureBox pictureBox1;
    }
}