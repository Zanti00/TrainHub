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

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cuiTextBox4_ContentChanged(object sender, EventArgs e)
        {

        }

        private void cuiButtonGroup2_Click(object sender, EventArgs e)
        {
           
            add_trainer addTrainerForm = new add_trainer();
            addTrainerForm.Show(); // use ShowDialog() if you want it to block until closed
        }

        private void button3_Click(object sender, EventArgs e)
        {
            edit_trainer editTrainerForm = new edit_trainer();
            editTrainerForm.Show(); // Or ShowDialog() if you want it modal
        }

        private void button1_Click(object sender, EventArgs e)
        {
            edit_trainer editTrainerForm = new edit_trainer();
            editTrainerForm.Show(); // Or ShowDialog() if you want it modal
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void cuiPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cuiPanel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cuiPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cuiPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
