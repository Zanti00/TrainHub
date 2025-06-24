using Microsoft.EntityFrameworkCore;
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
using TrainHub.Models;

namespace TrainHub
{
    public partial class TrainerTablePage : Form
    {
        public TrainHubContext dataContext;
        public TrainerTablePage()
        {
            InitializeComponent();
            dataContext = new TrainHubContext();

            advancedDataGridView1.CellFormatting += advancedDataGridView1_CellFormatting;
        }

        private void addTrainerButton_Click(object sender, EventArgs e)
        {
            TrainerForm addTrainer = new TrainerForm(this, FormMode.Add);
            addTrainer.ShowDialog();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 15 && e.RowIndex >= 0)
            {
                int trainerID = Convert.ToInt32(advancedDataGridView1.Rows[e.RowIndex].Cells[0].Value);
                TrainerForm viewTrainer = new TrainerForm(this, FormMode.View, trainerID);
                viewTrainer.ShowDialog();
            }
            if (e.ColumnIndex == 16 && e.RowIndex >= 0)
            {
                int trainerID = Convert.ToInt32(advancedDataGridView1.Rows[e.RowIndex].Cells[0].Value);
                TrainerForm editTrianer = new TrainerForm(this, FormMode.Edit, trainerID);
                editTrianer.ShowDialog();
            }

            if (e.ColumnIndex == 17 && e.RowIndex >= 0)
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
            if (e.ColumnIndex == 7 && e.Value != null)
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

        private DataTable CreateTrainerDataTable()
        {
            var dataTable = new DataTable();
            dataTable.Columns.Add("Id", typeof(int));
            dataTable.Columns.Add("FirstName", typeof(string));
            dataTable.Columns.Add("LastName", typeof(string));
            dataTable.Columns.Add("Gender", typeof(string));
            dataTable.Columns.Add("Email", typeof(string));
            dataTable.Columns.Add("PhoneNumber", typeof(string));
            dataTable.Columns.Add("Address", typeof(string));
            dataTable.Columns.Add("Status", typeof(string));
            dataTable.Columns.Add("IsDeleted", typeof(bool));
            dataTable.Columns.Add("Availability", typeof(string));
            dataTable.Columns.Add("YearsOfExperience", typeof(string));
            dataTable.Columns.Add("Specialization", typeof(string));
            dataTable.Columns.Add("HourlyRate", typeof(string));
            dataTable.Columns.Add("CreatedDate", typeof(DateTime));
            dataTable.Columns.Add("DateOfBirth", typeof(DateTime));

            return dataTable;
        }

        public void RefreshTrainerData()
        {
            try
            {
                dataContext.ChangeTracker.Clear();
                IQueryable<Trainer> trainers;
                if (deletedTrainerCheck.Checked)
                {
                    trainers = from trainer in dataContext.Trainer
                               select trainer;
                }
                else
                {
                    trainers = from trainer in dataContext.Trainer
                               where !trainer.IsDeleted // Only select non-deleted members
                               select trainer;
                }

                // Convert to DataTable for sorting/filtering support
                
                var dataTable = CreateTrainerDataTable();

                foreach (var trainer in trainers)
                {
                    dataTable.Rows.Add(
                        trainer.Id,
                        trainer.FirstName,
                        trainer.LastName,
                        trainer.Gender,
                        trainer.Email,
                        trainer.PhoneNumber,
                        trainer.Address,
                        trainer.Status,
                        trainer.IsDeleted,
                        trainer.Availability,
                        trainer.YearsOfExperience,
                        trainer.Specialization,
                        trainer.HourlyRate,
                        trainer.CreatedDate,
                        trainer.DateOfBirth
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
                    IQueryable<Trainer> trainers;
                    if (deletedTrainerCheck.Checked)
                    {
                        trainers = from trainer in dataContext.Trainer
                                   where trainer.FirstName.ToLower().Contains(trainerName.ToLower()) ||
                                         trainer.LastName.ToLower().Contains(trainerName.ToLower())
                                   select trainer;
                    }
                    else
                    {
                        trainers = from trainer in dataContext.Trainer
                                   where !trainer.IsDeleted &&
                                         (trainer.FirstName.ToLower().Contains(trainerName.ToLower()) ||
                                         trainer.LastName.ToLower().Contains(trainerName.ToLower()))
                                   select trainer;
                    }

                    // Convert to DataTable for sorting/filtering support
                    var dataTable = CreateTrainerDataTable();

                    foreach (var trainer in trainers)
                    {
                        dataTable.Rows.Add(
                            trainer.Id,
                            trainer.FirstName,
                            trainer.LastName,
                            trainer.Gender,
                            trainer.Email,
                            trainer.PhoneNumber,
                            trainer.Address,
                            trainer.Status,
                            trainer.IsDeleted,
                            trainer.Availability,
                            trainer.YearsOfExperience,
                            trainer.Specialization,
                            trainer.HourlyRate,
                            trainer.CreatedDate,
                            trainer.DateOfBirth

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

        private void table_trainer_Load(object sender, EventArgs e)
        {
            RefreshTrainerData();
        }

        private void deletedMemberCheck_CheckedChanged(object sender, EventArgs e)
        {
            RefreshTrainerData();
        }
    }
}