namespace TrainHub.User_Controls
{
    partial class CustomBackButton
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomBackButton));
            backBtn = new CuoreUI.Controls.cuiButton();
            SuspendLayout();
            // 
            // backBtn
            // 
            backBtn.BackColor = Color.Transparent;
            backBtn.CheckButton = false;
            backBtn.Checked = false;
            backBtn.CheckedBackground = Color.Transparent;
            backBtn.CheckedForeColor = Color.Black;
            backBtn.CheckedImageTint = Color.Black;
            backBtn.CheckedOutline = Color.Transparent;
            backBtn.Content = "back";
            backBtn.DialogResult = DialogResult.None;
            backBtn.Font = new Font("Microsoft Sans Serif", 9.75F);
            backBtn.ForeColor = Color.Black;
            backBtn.HoverBackground = Color.Transparent;
            backBtn.HoveredImageTint = Color.Black;
            backBtn.HoverForeColor = Color.Black;
            backBtn.HoverOutline = Color.Transparent;
            backBtn.Image = (Image)resources.GetObject("backBtn.Image");
            backBtn.ImageAutoCenter = true;
            backBtn.ImageExpand = new Point(3, 3);
            backBtn.ImageOffset = new Point(-3, 0);
            backBtn.Location = new Point(3, 3);
            backBtn.Name = "backBtn";
            backBtn.NormalBackground = Color.Transparent;
            backBtn.NormalForeColor = Color.Black;
            backBtn.NormalImageTint = Color.Black;
            backBtn.NormalOutline = Color.Transparent;
            backBtn.OutlineThickness = 1F;
            backBtn.PressedBackground = Color.Transparent;
            backBtn.PressedForeColor = Color.Black;
            backBtn.PressedImageTint = Color.Black;
            backBtn.PressedOutline = Color.Transparent;
            backBtn.Rounding = new Padding(8);
            backBtn.Size = new Size(64, 45);
            backBtn.TabIndex = 7;
            backBtn.TextAlignment = StringAlignment.Center;
            backBtn.TextOffset = new Point(0, 0);
            // 
            // CustomBackButton
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(backBtn);
            Name = "CustomBackButton";
            Size = new Size(73, 52);
            ResumeLayout(false);
        }

        #endregion

        private CuoreUI.Controls.cuiButton backBtn;
    }
}
