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
        private void cuiButtonGroup3_Click(object sender, EventArgs e)
        {
            add_newstaff f1 = new add_newstaff();
            f1.ShowDialog();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6 && e.RowIndex >= 0)
            {
                // Assuming you have a way to retrieve the userID and pass the current StaffTable reference
                int userID = GetUserIDFromRow(e.RowIndex); // Replace with actual logic to fetch userID
                edit_staff editForm = new edit_staff(userID, this);
                editForm.ShowDialog();
            }
        }

        // Example method to retrieve userID from the DataGridView row
        private int GetUserIDFromRow(int rowIndex)
        {
            // Replace with actual logic to fetch userID from the DataGridView row
            string userIDString = dataGridView2.Rows[rowIndex].Cells[0].Value.ToString();
            return int.TryParse(userIDString, out int userID) ? userID : 0;
        }

        private void cuiButtonGroup2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
