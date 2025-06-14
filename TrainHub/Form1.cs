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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cuiPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cuiPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void showPassBtn_Click(object sender, EventArgs e)
        {
            if (passwordTxt.PasswordChar)
            {
                passwordTxt.PasswordChar = false;
            }
            else
            {
                passwordTxt.PasswordChar = true;
            }
        }

    }
}
