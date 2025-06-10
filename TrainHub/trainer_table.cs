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
    public partial class trainer_table : Form
    {
        public trainer_table()
        {
            InitializeComponent();
            // make the form full screen
            this.WindowState = FormWindowState.Maximized;

            // add test rows to the DataGridView
            dataGridView2.Rows.Add("M001", "Alice Rivera", "alice@example.com", "09171234567", "P001", "2025-01-01");
            dataGridView2.Rows.Add("M001", "Alice Rivera", "alice@example.com", "09171234567", "P001", "2025-01-01");
            dataGridView2.Rows.Add("M001", "Alice Rivera", "alice@example.com", "09171234567", "P001", "2025-01-01");
            dataGridView2.Rows.Add("M001", "Alice Rivera", "alice@example.com", "09171234567", "P001", "2025-01-01");

            // Add CellContentClick event handler
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 10 && e.RowIndex >= 0)
            {
                edit_trainer editForm = new edit_trainer();
                editForm.ShowDialog();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cuiButtonGroup4_Click(object sender, EventArgs e)
        {
            
        }
       

        private void cuiButtonGroup3_Click(object sender, EventArgs e)
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

        private void cuiTextBox1_ContentChanged(object sender, EventArgs e)
        {

        }
    }
}
