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
            ShowSortingOptions();
        }

        private void ShowSortingOptions()
        {
            // Create a context menu with sorting options
            ContextMenuStrip sortMenu = new ContextMenuStrip();

            // Add sorting options
            ToolStripMenuItem sortByName = new ToolStripMenuItem("Sort by Name (A-Z)");
            sortByName.Click += (s, e) => SortDataGrid("Name", ListSortDirection.Ascending);
            sortMenu.Items.Add(sortByName);

            ToolStripMenuItem sortByNameDesc = new ToolStripMenuItem("Sort by Name (Z-A)");
            sortByNameDesc.Click += (s, e) => SortDataGrid("Name", ListSortDirection.Descending);
            sortMenu.Items.Add(sortByNameDesc);

            sortMenu.Items.Add(new ToolStripSeparator());

            ToolStripMenuItem sortByAge = new ToolStripMenuItem("Sort by Age (Youngest First)");
            sortByAge.Click += (s, e) => SortDataGrid("Age", ListSortDirection.Ascending);
            sortMenu.Items.Add(sortByAge);

            ToolStripMenuItem sortByAgeDesc = new ToolStripMenuItem("Sort by Age (Oldest First)");
            sortByAgeDesc.Click += (s, e) => SortDataGrid("Age", ListSortDirection.Descending);
            sortMenu.Items.Add(sortByAgeDesc);

            sortMenu.Items.Add(new ToolStripSeparator());

            ToolStripMenuItem sortByExperience = new ToolStripMenuItem("Sort by Experience (Least First)");
            sortByExperience.Click += (s, e) => SortDataGrid("Experience", ListSortDirection.Ascending);
            sortMenu.Items.Add(sortByExperience);

            ToolStripMenuItem sortByExperienceDesc = new ToolStripMenuItem("Sort by Experience (Most First)");
            sortByExperienceDesc.Click += (s, e) => SortDataGrid("Experience", ListSortDirection.Descending);
            sortMenu.Items.Add(sortByExperienceDesc);

            sortMenu.Items.Add(new ToolStripSeparator());

            ToolStripMenuItem sortByDateHired = new ToolStripMenuItem("Sort by Date Hired (Newest First)");
            sortByDateHired.Click += (s, e) => SortDataGrid("DateHired", ListSortDirection.Descending);
            sortMenu.Items.Add(sortByDateHired);

            ToolStripMenuItem sortByDateHiredAsc = new ToolStripMenuItem("Sort by Date Hired (Oldest First)");
            sortByDateHiredAsc.Click += (s, e) => SortDataGrid("DateHired", ListSortDirection.Ascending);
            sortMenu.Items.Add(sortByDateHiredAsc);

            sortMenu.Items.Add(new ToolStripSeparator());

            ToolStripMenuItem resetSort = new ToolStripMenuItem("Reset to Default Order");
            resetSort.Click += (s, e) => ResetSorting();
            sortMenu.Items.Add(resetSort);

            // Show the menu near the button
            // You might need to adjust the location based on your button's position
            sortMenu.Show(Cursor.Position);
        }

        private void SortDataGrid(string columnName, ListSortDirection direction)
        {
            try
            {
                // Check if the DataGridView has a data source
                if (dataGridView2.DataSource != null)
                {
                    // If using DataTable or BindingSource
                    if (dataGridView2.DataSource is DataTable dataTable)
                    {
                        string sortExpression = direction == ListSortDirection.Ascending ?
                            $"{columnName} ASC" : $"{columnName} DESC";
                        dataTable.DefaultView.Sort = sortExpression;
                    }
                    else if (dataGridView2.DataSource is BindingSource bindingSource)
                    {
                        bindingSource.Sort = direction == ListSortDirection.Ascending ?
                            $"{columnName} ASC" : $"{columnName} DESC";
                    }
                }
                else
                {
                    // If directly adding rows to DataGridView without data source
                    // Sort by column index (you'll need to adjust column indices)
                    int columnIndex = GetColumnIndex(columnName);
                    if (columnIndex >= 0)
                    {
                        dataGridView2.Sort(dataGridView2.Columns[columnIndex], direction);
                    }
                }

                // Show feedback to user
                string directionText = direction == ListSortDirection.Ascending ? "ascending" : "descending";
                MessageBox.Show($"Sorted by {columnName} in {directionText} order.", "Sorting Complete",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error sorting data: {ex.Message}", "Sorting Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int GetColumnIndex(string columnName)
        {
            // Map column names to indices - adjust these based on your actual column setup
            switch (columnName.ToLower())
            {
                case "name": return 0;  // Assuming name is in column 0
                case "age": return 1;   // Assuming age is in column 1
                case "experience": return 2; // Assuming experience is in column 2
                case "datehired": return 3;  // Assuming date hired is in column 3
                // Add more cases as needed for your columns
                default: return -1;
            }
        }

        private void ResetSorting()
        {
            try
            {
                if (dataGridView2.DataSource != null)
                {
                    if (dataGridView2.DataSource is DataTable dataTable)
                    {
                        dataTable.DefaultView.Sort = "";
                    }
                    else if (dataGridView2.DataSource is BindingSource bindingSource)
                    {
                        bindingSource.RemoveSort();
                    }
                }

                MessageBox.Show("Sorting has been reset to default order.", "Reset Complete",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error resetting sort: {ex.Message}", "Reset Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
