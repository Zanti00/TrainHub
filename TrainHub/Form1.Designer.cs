namespace TrainHub
{
    partial class Form1
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
            passwordTxt = new CuoreUI.Controls.cuiTextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cuiPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // cuiPanel1
            // 
            cuiPanel1.BackColor = SystemColors.ButtonHighlight;
            cuiPanel1.Controls.Add(passwordTxt);
            cuiPanel1.Controls.Add(label4);
            cuiPanel1.Controls.Add(label3);
            cuiPanel1.Controls.Add(label2);
            cuiPanel1.Controls.Add(label1);
            cuiPanel1.Location = new Point(76, 29);
            cuiPanel1.Name = "cuiPanel1";
            cuiPanel1.OutlineThickness = 1F;
            cuiPanel1.PanelColor = Color.White;
            cuiPanel1.PanelOutlineColor = Color.Black;
            cuiPanel1.Rounding = new Padding(8);
            cuiPanel1.Size = new Size(659, 619);
            cuiPanel1.TabIndex = 9;
            // 
            // passwordTxt
            // 
            passwordTxt.BackColor = Color.Transparent;
            passwordTxt.BackgroundColor = Color.WhiteSmoke;
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
            passwordTxt.Location = new Point(118, 313);
            passwordTxt.Margin = new Padding(5);
            passwordTxt.Multiline = false;
            passwordTxt.Name = "passwordTxt";
            passwordTxt.NormalImageTint = Color.White;
            passwordTxt.Padding = new Padding(16, 7, 16, 0);
            passwordTxt.PasswordChar = true;
            passwordTxt.PlaceholderColor = SystemColors.ScrollBar;
            passwordTxt.PlaceholderText = "Please enter your new phone number...";
            passwordTxt.Rounding = new Padding(6);
            passwordTxt.Size = new Size(336, 31);
            passwordTxt.TabIndex = 17;
            passwordTxt.TextOffset = new Size(0, 0);
            passwordTxt.UnderlinedStyle = false;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(0, 0, 64);
            label4.ImageAlign = ContentAlignment.MiddleLeft;
            label4.Location = new Point(118, 277);
            label4.Margin = new Padding(6, 0, 3, 0);
            label4.Name = "label4";
            label4.Size = new Size(180, 20);
            label4.TabIndex = 16;
            label4.Text = "Enter New Phone Number";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(130, 130, 130);
            label3.Location = new Point(118, 222);
            label3.Margin = new Padding(11, 20, 3, 0);
            label3.Name = "label3";
            label3.Size = new Size(144, 20);
            label3.TabIndex = 15;
            label3.Text = "Set a New Password.";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 0, 64);
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(118, 151);
            label2.Margin = new Padding(6, 0, 3, 0);
            label2.Name = "label2";
            label2.Size = new Size(312, 40);
            label2.TabIndex = 14;
            label2.Text = "Update Phone Number";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(50, 81, 88);
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(118, 88);
            label1.Name = "label1";
            label1.Size = new Size(177, 46);
            label1.TabIndex = 13;
            label1.Text = "TrainHub";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(831, 724);
            Controls.Add(cuiPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            cuiPanel1.ResumeLayout(false);
            cuiPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private CuoreUI.Controls.cuiPanel cuiPanel1;
        private CuoreUI.Controls.cuiTextBox passwordTxt;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}