namespace TrainHub
{
    partial class ReadQRForm
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
            pictureBox1 = new PictureBox();
            readBtn = new CuoreUI.Controls.cuiButtonGroup();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackColor = Color.White;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(64, 54);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(640, 360);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // readBtn
            // 
            readBtn.Anchor = AnchorStyles.None;
            readBtn.AutoSize = true;
            readBtn.BackColor = Color.Transparent;
            readBtn.Checked = false;
            readBtn.CheckedBackground = Color.FromArgb(22, 36, 39);
            readBtn.CheckedForeColor = Color.White;
            readBtn.CheckedImageTint = Color.FromArgb(22, 36, 39);
            readBtn.CheckedOutline = Color.White;
            readBtn.Content = "Read";
            readBtn.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            readBtn.ForeColor = Color.White;
            readBtn.Group = 0;
            readBtn.HoverBackground = Color.FromArgb(22, 36, 39);
            readBtn.HoveredImageTint = Color.Transparent;
            readBtn.HoverForeColor = Color.White;
            readBtn.HoverOutline = Color.FromArgb(22, 36, 39);
            readBtn.Image = null;
            readBtn.ImageAutoCenter = true;
            readBtn.ImageExpand = new Point(0, 0);
            readBtn.ImageOffset = new Point(0, 0);
            readBtn.Location = new Point(591, 429);
            readBtn.Name = "readBtn";
            readBtn.NormalBackground = Color.FromArgb(50, 81, 88);
            readBtn.NormalForeColor = Color.White;
            readBtn.NormalImageTint = Color.Black;
            readBtn.NormalOutline = Color.FromArgb(50, 81, 88);
            readBtn.OutlineThickness = 1F;
            readBtn.PressedBackground = Color.FromArgb(22, 36, 39);
            readBtn.PressedForeColor = Color.White;
            readBtn.PressedImageTint = Color.White;
            readBtn.PressedOutline = Color.FromArgb(22, 36, 39);
            readBtn.Rounding = new Padding(10);
            readBtn.Size = new Size(113, 31);
            readBtn.TabIndex = 24;
            readBtn.TextAlignment = StringAlignment.Center;
            readBtn.TextOffset = new Point(0, 0);
            readBtn.Click += readBtn_Click;
            // 
            // ReadQRForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 479);
            Controls.Add(readBtn);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ReadQRForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ReadQRForm";
            FormClosing += ReadQRForm_FormClosing;
            Load += ReadQRForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private CuoreUI.Controls.cuiButtonGroup readBtn;
    }
}