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
    public partial class table_trainer : Form
    {
        public table_trainer()
        {
            InitializeComponent();
        }

        private void cuiPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void advancedDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cuiButton1_Click(object sender, EventArgs e)
        {
            add_trainer addForm = new add_trainer();

            // ShowDialog() will wait for the form to close before continuing
            DialogResult result = addForm.ShowDialog();

            // Optional: Handle the result if needed
            if (result == DialogResult.OK)
            {
                // Refresh data or perform other actions after adding trainer
                // RefreshTrainerData();
            }
        }

        private void searchbar_ContentChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
