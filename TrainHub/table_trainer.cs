using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrainHub.Data;

namespace TrainHub
{
    public partial class table_trainer : Form
    {
        public TrainHubContext dataContext;
        public table_trainer()
        {
            InitializeComponent();
            dataContext = new TrainHubContext();

            advancedDataGridView1.CellFormatting += advancedDataGridView1_CellFormatting;
        }

        private void addTrainerButton_Click(object sender, EventArgs e)
        {
            RegisterNewTrainer registerNewTrainer = new RegisterNewTrainer(this);
            registerNewTrainer.ShowDialog();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 11 && e.RowIndex >= 0)
            {
                int trainerID = Convert.ToInt32(advancedDataGridView1.Rows[e.RowIndex].Cells[0].Value);
                edit_trainer editForm = new edit_trainer(trainerID, this);
                editForm.ShowDialog();
            }

            if (e.ColumnIndex == 12 && e.RowIndex >= 0)
            {
                // Confirm deletion
                var result = MessageBox.Show($"Are you sure you want to delete trainer {advancedDataGridView1.Rows[e.RowIndex].Cells[1].Value} {advancedDataGridView1.Rows[e.RowIndex].Cells[2].Value}?", "Confirm Deletion",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        // Get the selected member's ID
                        int memberId = Convert.ToInt32(advancedDataGridView1.Rows[e.RowIndex].Cells[0].Value);
                        var memberToDelete = dataContext.Trainer.Find(memberId);
                        if (memberToDelete != null)
                        {
                            memberToDelete.IsDeleted = true; // Soft delete
                            memberToDelete.SoftDeleteDate = DateTime.Today;
                            dataContext.SaveChanges();
                            RefreshTrainerData(); // Refresh the DataGridView after deletion
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error deleting trainer: {ex.Message}", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void advancedDataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Check if this is column 11 (Status column) and has a value
            if (e.ColumnIndex == 11 && e.Value != null)
            {
                string status = e.Value.ToString();

                if (status.Equals("Active", StringComparison.OrdinalIgnoreCase))
                {
                    e.CellStyle.ForeColor = Color.Green;
                }
                else if (status.Equals("Inactive", StringComparison.OrdinalIgnoreCase))
                {
                    e.CellStyle.ForeColor = Color.Red;
                }
                else
                {
                    e.CellStyle.ForeColor = Color.Black; // Default color
                }
            }
        }


        public void RefreshTrainerData()
        {
            try
            {
                dataContext.ChangeTracker.Clear();
                var trainers = from trainer in dataContext.Trainer
                               where !trainer.IsDeleted // Only select non-deleted members
                               select trainer;

                // Convert to DataTable for sorting/filtering support
                var dataTable = new DataTable();
                dataTable.Columns.Add("Id", typeof(int));
                dataTable.Columns.Add("FirstName", typeof(string));
                dataTable.Columns.Add("LastName", typeof(string));
                dataTable.Columns.Add("Email", typeof(string));
                dataTable.Columns.Add("MobileNumber", typeof(string));
                dataTable.Columns.Add("Address", typeof(string));
                dataTable.Columns.Add("YearsOfExperience", typeof(string));
                dataTable.Columns.Add("DateOfBirth", typeof(DateTime));
                dataTable.Columns.Add("CreatedDate", typeof(DateTime));
                dataTable.Columns.Add("SoftDeleteDate", typeof(DateTime));
                dataTable.Columns.Add("IsDeleted", typeof(bool));


                foreach (var trainer in trainers)
                {
                    dataTable.Rows.Add(
                        trainer.Id,
                        trainer.FirstName,
                        trainer.LastName,
                        trainer.Email,
                        trainer.Address,
                        trainer.YearsOfExperience,
                        trainer.MobileNumber,
                        trainer.DateOfBirth,
                        trainer.CreatedDate,
                        trainer.SoftDeleteDate,
                        trainer.IsDeleted

                    );
                }

                this.trainerBindingSource.DataSource = dataTable;
                advancedDataGridView1.DataSource = trainerBindingSource;

                // to disable sort and filter for unbounded columns
                foreach (DataGridViewColumn col in advancedDataGridView1.Columns)
                {
                    if (string.IsNullOrEmpty(col.DataPropertyName))
                    {
                        advancedDataGridView1.SetFilterAndSortEnabled(col, false);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading member data: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            dataContext?.Dispose();
            base.OnFormClosed(e);
        }

        public void searchBar_ContentChanged(object sender, EventArgs e)
        {
            string trainerName = searchBar.Content.Trim();

            try
            {
                if (!string.IsNullOrEmpty(trainerName))
                {
                    var trainers = from trainer in dataContext.Trainer
                                   where trainer.FirstName.ToLower().Contains(trainerName.ToLower()) ||
                                         trainer.LastName.ToLower().Contains(trainerName.ToLower())
                                   select trainer;

                    // Convert to DataTable for sorting/filtering support
                    var dataTable = new DataTable();
                    dataTable.Columns.Add("Id", typeof(int));
                    dataTable.Columns.Add("FirstName", typeof(string));
                    dataTable.Columns.Add("LastName", typeof(string));
                    dataTable.Columns.Add("Email Address", typeof(string));
                    dataTable.Columns.Add("PhoneNumber", typeof(string));
                    dataTable.Columns.Add("DateOfBirth", typeof(DateTime));
                    dataTable.Columns.Add("CreatedDate", typeof(DateTime));
                    dataTable.Columns.Add("SoftDeleteDate", typeof(DateTime));
                    dataTable.Columns.Add("IsDeleted", typeof(bool));


                    foreach (var trainer in trainers)
                    {
                        dataTable.Rows.Add(
                            trainer.Id,
                            trainer.FirstName,
                            trainer.LastName,
                            trainer.Email,
                            trainer.MobileNumber,
                            trainer.DateOfBirth,
                            trainer.CreatedDate,
                            trainer.SoftDeleteDate,
                            trainer.IsDeleted

                        );
                    }

                    this.trainerBindingSource.DataSource = dataTable;
                }
                else
                {
                    // If search is empty, show all members
                    RefreshTrainerData();
                }
                advancedDataGridView1.DataSource = trainerBindingSource;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching trainer data: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }






        private void cuiPanel3_Paint(object sender, PaintEventArgs e)
        {

        }


        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void table_trainer_Load(object sender, EventArgs e)
        {
            RefreshTrainerData();
        }
    }
}