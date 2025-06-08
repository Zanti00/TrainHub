using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainHub
{
    public partial class EditMemberForm1 : Form
    {
        public EditMemberForm1()
        {
            InitializeComponent();

            // to prevent resizing
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ControlBox = true;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void cuiButton2_Click(object sender, EventArgs e)
        {
            this.Close(); // closes form
        }

        private void cuiButtonGroup1_Click(object sender, EventArgs e)
        {
            this.Close(); // closes form
        }
    }
}