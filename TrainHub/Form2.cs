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
    public partial class Form2 : Form
    {
        public Form2()
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
            // Check if the clicked column is column 11 (index 10, since index is zero-based)
            if (e.ColumnIndex == 10 && e.RowIndex >= 0)
            {
                edit_staff editForm = new edit_staff();
                editForm.ShowDialog();
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cuiButtonGroup4_Click(object sender, EventArgs e)
        {

        }

        private void cuiButtonGroup2_Click(object sender, EventArgs e)
        {
            add_newstaff f1 = new add_newstaff();
            f1.ShowDialog();
        }

        private void cuiButtonGroup1_Click(object sender, EventArgs e)
        {

        }

        private void cuiPanel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
