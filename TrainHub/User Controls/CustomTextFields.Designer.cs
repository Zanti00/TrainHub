namespace TrainHub.User_Controls
{
    partial class CustomTextFields
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txt = new CuoreUI.Controls.cuiTextBox();
            SuspendLayout();
            // 
            // txt
            // 
            txt.Anchor = AnchorStyles.None;
            txt.BackColor = Color.Transparent;
            txt.BackgroundColor = Color.White;
            txt.BorderColor = Color.FromArgb(128, 128, 128, 128);
            txt.Content = "";
            txt.FocusBackgroundColor = Color.White;
            txt.FocusBorderColor = Color.FromArgb(50, 81, 88);
            txt.FocusImageTint = Color.White;
            txt.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt.ForeColor = Color.Gray;
            txt.Image = null;
            txt.ImageExpand = new Point(0, 0);
            txt.ImageOffset = new Point(0, 0);
            txt.Location = new Point(2, 4);
            txt.Margin = new Padding(4);
            txt.Multiline = false;
            txt.Name = "txt";
            txt.NormalImageTint = Color.White;
            txt.Padding = new Padding(15, 10, 15, 0);
            txt.PasswordChar = false;
            txt.PlaceholderColor = SystemColors.InactiveCaption;
            txt.PlaceholderText = "Enter your text";
            txt.Rounding = new Padding(8);
            txt.Size = new Size(313, 35);
            txt.TabIndex = 4;
            txt.TextOffset = new Size(0, 0);
            txt.UnderlinedStyle = false;
            // 
            // CustomTextFields
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(txt);
            Name = "CustomTextFields";
            Size = new Size(317, 42);
            ResumeLayout(false);
        }

        #endregion

        private CuoreUI.Controls.cuiTextBox txt;
    }
}
