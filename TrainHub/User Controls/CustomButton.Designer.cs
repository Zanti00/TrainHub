using CuoreUI;
namespace TrainHub
{
    partial class CustomButton
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
            btn = new CuoreUI.Controls.cuiButton();
            SuspendLayout();
            // 
            // btn
            // 
            btn.Anchor = AnchorStyles.None;
            btn.BackColor = Color.Transparent;
            btn.CheckButton = false;
            btn.Checked = false;
            btn.CheckedBackground = Color.FromArgb(50, 81, 88);
            btn.CheckedForeColor = Color.White;
            btn.CheckedImageTint = Color.White;
            btn.CheckedOutline = Color.FromArgb(50, 81, 88);
            btn.Content = "BUTTON";
            btn.DialogResult = DialogResult.None;
            btn.Font = new Font("Microsoft Sans Serif", 8F);
            btn.ForeColor = Color.White;
            btn.HoverBackground = Color.FromArgb(22, 36, 39);
            btn.HoveredImageTint = Color.White;
            btn.HoverForeColor = Color.White;
            btn.HoverOutline = Color.FromArgb(22, 36, 39);
            btn.Image = null;
            btn.ImageAutoCenter = true;
            btn.ImageExpand = new Point(0, 0);
            btn.ImageOffset = new Point(0, 0);
            btn.Location = new Point(4, 4);
            btn.Name = "btn";
            btn.NormalBackground = Color.FromArgb(50, 81, 88);
            btn.NormalForeColor = Color.White;
            btn.NormalImageTint = Color.White;
            btn.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btn.OutlineThickness = 1F;
            btn.PressedBackground = Color.FromArgb(22, 36, 39);
            btn.PressedForeColor = Color.White;
            btn.PressedImageTint = Color.White;
            btn.PressedOutline = Color.FromArgb(22, 36, 39);
            btn.Rounding = new Padding(3);
            btn.Size = new Size(313, 35);
            btn.TabIndex = 7;
            btn.TextAlignment = StringAlignment.Center;
            btn.TextOffset = new Point(0, 0);
            // 
            // CustomButton
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(btn);
            Name = "CustomButton";
            Size = new Size(321, 43);
            ResumeLayout(false);
        }

        #endregion

        private CuoreUI.Controls.cuiButton btn;
    }
}
