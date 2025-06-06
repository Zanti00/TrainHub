namespace TrainHub
{
    partial class trainer
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
            cuiPanel1 = new CuoreUI.Controls.cuiPanel();
            cuiPanel2 = new CuoreUI.Controls.cuiPanel();
            cuiPanel3 = new CuoreUI.Controls.cuiPanel();
            cuiButton2 = new CuoreUI.Controls.cuiButton();
            searchBox = new CuoreUI.Controls.cuiTextBox();
            cuiButton1 = new CuoreUI.Controls.cuiButton();
            label2 = new Label();
            label1 = new Label();
            cuiPanel2.SuspendLayout();
            cuiPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // cuiPanel1
            // 
            cuiPanel1.Dock = DockStyle.Left;
            cuiPanel1.Location = new Point(0, 0);
            cuiPanel1.Name = "cuiPanel1";
            cuiPanel1.OutlineThickness = 1F;
            cuiPanel1.PanelColor = Color.FromArgb(50, 81, 88);
            cuiPanel1.PanelOutlineColor = Color.White;
            cuiPanel1.Rounding = new Padding(8);
            cuiPanel1.Size = new Size(178, 461);
            cuiPanel1.TabIndex = 0;
            // 
            // cuiPanel2
            // 
            cuiPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cuiPanel2.Controls.Add(cuiPanel3);
            cuiPanel2.Controls.Add(cuiButton1);
            cuiPanel2.Controls.Add(label2);
            cuiPanel2.Controls.Add(label1);
            cuiPanel2.Location = new Point(214, 39);
            cuiPanel2.Name = "cuiPanel2";
            cuiPanel2.OutlineThickness = 1F;
            cuiPanel2.PanelColor = Color.White;
            cuiPanel2.PanelOutlineColor = Color.White;
            cuiPanel2.Rounding = new Padding(10);
            cuiPanel2.Size = new Size(700, 387);
            cuiPanel2.TabIndex = 1;
            // 
            // cuiPanel3
            // 
            cuiPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cuiPanel3.Controls.Add(cuiButton2);
            cuiPanel3.Controls.Add(searchBox);
            cuiPanel3.Location = new Point(15, 111);
            cuiPanel3.Name = "cuiPanel3";
            cuiPanel3.OutlineThickness = 1F;
            cuiPanel3.PanelColor = Color.FromArgb(224, 224, 224);
            cuiPanel3.PanelOutlineColor = Color.FromArgb(224, 224, 224);
            cuiPanel3.Rounding = new Padding(8);
            cuiPanel3.Size = new Size(671, 35);
            cuiPanel3.TabIndex = 9;
            cuiPanel3.Paint += cuiPanel3_Paint;
            // 
            // cuiButton2
            // 
            cuiButton2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cuiButton2.CheckButton = false;
            cuiButton2.Checked = false;
            cuiButton2.CheckedBackground = Color.FromArgb(255, 106, 0);
            cuiButton2.CheckedForeColor = Color.White;
            cuiButton2.CheckedImageTint = Color.White;
            cuiButton2.CheckedOutline = Color.FromArgb(255, 106, 0);
            cuiButton2.Content = "Sort by";
            cuiButton2.DialogResult = DialogResult.None;
            cuiButton2.Font = new Font("Microsoft Sans Serif", 8F);
            cuiButton2.ForeColor = Color.Black;
            cuiButton2.HoverBackground = Color.White;
            cuiButton2.HoveredImageTint = Color.White;
            cuiButton2.HoverForeColor = Color.Black;
            cuiButton2.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            cuiButton2.Image = null;
            cuiButton2.ImageAutoCenter = true;
            cuiButton2.ImageExpand = new Point(0, 0);
            cuiButton2.ImageOffset = new Point(0, 0);
            cuiButton2.Location = new Point(609, 6);
            cuiButton2.Name = "cuiButton2";
            cuiButton2.NormalBackground = Color.White;
            cuiButton2.NormalForeColor = Color.Black;
            cuiButton2.NormalImageTint = Color.White;
            cuiButton2.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            cuiButton2.OutlineThickness = 1F;
            cuiButton2.PressedBackground = Color.WhiteSmoke;
            cuiButton2.PressedForeColor = Color.FromArgb(32, 32, 32);
            cuiButton2.PressedImageTint = Color.White;
            cuiButton2.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            cuiButton2.Rounding = new Padding(8);
            cuiButton2.Size = new Size(59, 22);
            cuiButton2.TabIndex = 11;
            cuiButton2.TextAlignment = StringAlignment.Center;
            cuiButton2.TextOffset = new Point(0, 0);
            // 
            // searchBox
            // 
            searchBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            searchBox.BackgroundColor = Color.White;
            searchBox.BorderColor = Color.FromArgb(128, 128, 128, 128);
            searchBox.Content = "";
            searchBox.FocusBackgroundColor = Color.White;
            searchBox.FocusBorderColor = Color.FromArgb(255, 106, 0);
            searchBox.FocusImageTint = Color.White;
            searchBox.Font = new Font("Microsoft Sans Serif", 8F);
            searchBox.ForeColor = Color.Gray;
            searchBox.Image = null;
            searchBox.ImageExpand = new Point(0, 0);
            searchBox.ImageOffset = new Point(0, 0);
            searchBox.Location = new Point(456, 7);
            searchBox.Margin = new Padding(4);
            searchBox.Multiline = false;
            searchBox.Name = "searchBox";
            searchBox.NormalImageTint = Color.White;
            searchBox.Padding = new Padding(13, 5, 13, 0);
            searchBox.PasswordChar = false;
            searchBox.PlaceholderColor = SystemColors.WindowText;
            searchBox.PlaceholderText = "Search";
            searchBox.Rounding = new Padding(8);
            searchBox.Size = new Size(146, 22);
            searchBox.TabIndex = 10;
            searchBox.TextOffset = new Size(0, 0);
            searchBox.UnderlinedStyle = true;
            // 
            // cuiButton1
            // 
            cuiButton1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cuiButton1.CheckButton = false;
            cuiButton1.Checked = false;
            cuiButton1.CheckedBackground = Color.FromArgb(255, 106, 0);
            cuiButton1.CheckedForeColor = Color.White;
            cuiButton1.CheckedImageTint = Color.White;
            cuiButton1.CheckedOutline = Color.FromArgb(255, 106, 0);
            cuiButton1.Content = "+ Add Trainer";
            cuiButton1.DialogResult = DialogResult.None;
            cuiButton1.Font = new Font("Segoe UI Semilight", 8F);
            cuiButton1.ForeColor = Color.Black;
            cuiButton1.HoverBackground = Color.White;
            cuiButton1.HoveredImageTint = Color.White;
            cuiButton1.HoverForeColor = Color.Black;
            cuiButton1.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            cuiButton1.Image = null;
            cuiButton1.ImageAutoCenter = true;
            cuiButton1.ImageExpand = new Point(0, 0);
            cuiButton1.ImageOffset = new Point(0, 0);
            cuiButton1.Location = new Point(595, 45);
            cuiButton1.Name = "cuiButton1";
            cuiButton1.NormalBackground = Color.White;
            cuiButton1.NormalForeColor = Color.Black;
            cuiButton1.NormalImageTint = Color.White;
            cuiButton1.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            cuiButton1.OutlineThickness = 1F;
            cuiButton1.PressedBackground = Color.WhiteSmoke;
            cuiButton1.PressedForeColor = Color.FromArgb(32, 32, 32);
            cuiButton1.PressedImageTint = Color.White;
            cuiButton1.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            cuiButton1.Rounding = new Padding(8);
            cuiButton1.Size = new Size(91, 23);
            cuiButton1.TabIndex = 7;
            cuiButton1.TextAlignment = StringAlignment.Center;
            cuiButton1.TextOffset = new Point(0, 0);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonHighlight;
            label2.Font = new Font("Segoe UI Semilight", 8F);
            label2.ForeColor = Color.FromArgb(50, 81, 88);
            label2.Location = new Point(15, 55);
            label2.Name = "label2";
            label2.Size = new Size(131, 13);
            label2.TabIndex = 6;
            label2.Text = "View and manage trainers";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(50, 81, 88);
            label1.Location = new Point(15, 34);
            label1.Name = "label1";
            label1.Size = new Size(70, 21);
            label1.TabIndex = 5;
            label1.Text = "Trainers";
            label1.Click += label1_Click;
            // 
            // trainer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(943, 461);
            Controls.Add(cuiPanel2);
            Controls.Add(cuiPanel1);
            ForeColor = SystemColors.ControlText;
            Name = "trainer";
            Text = "trainer";
            Load += trainer_Load;
            cuiPanel2.ResumeLayout(false);
            cuiPanel2.PerformLayout();
            cuiPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private CuoreUI.Controls.cuiPanel cuiPanel1;
        private CuoreUI.Controls.cuiPanel cuiPanel2;
        private Label label1;
        private Label label2;
        private CuoreUI.Controls.cuiButton cuiButton1;
        private CuoreUI.Controls.cuiPanel cuiPanel3;
        private CuoreUI.Controls.cuiTextBox searchBox;
        private CuoreUI.Controls.cuiButton cuiButton2;
    }
}