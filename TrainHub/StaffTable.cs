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
    public partial class StaffTable : Form
    {
        public StaffTable()
        {
            InitializeComponent();
            // make the form full screen
            this.WindowState = FormWindowState.Maximized;

            // add test rows to the DataGridView
            dataGridView2.Rows.Add("M001", "Alice Rivera", "alice@example.com", "09171234567", "P001", "2025-01-01");
            dataGridView2.Rows.Add("M001", "Alice Rivera", "alice@example.com", "09171234567", "P001", "2025-01-01");
            dataGridView2.Rows.Add("M001", "Alice Rivera", "alice@example.com", "09171234567", "P001", "2025-01-01");
            dataGridView2.Rows.Add("M001", "Alice Rivera", "alice@example.com", "09171234567", "P001", "2025-01-01");

        }
        private void cuiButtonGroup2_Click(object sender, EventArgs e)
        {
            add_newstaff f1 = new add_newstaff();
            f1.ShowDialog();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked column is column 11 (index 10, since index is zero-based)
            if (e.ColumnIndex == 6 && e.RowIndex >= 0)
            {
                edit_staff editForm = new edit_staff();
                editForm.ShowDialog();
            }
        }

        private void cuiButtonGroup3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
