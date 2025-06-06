using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace TrainHub
{
    public partial class trainer : Form
    {
        // Trainer list
        List<Trainer> allTrainers = new List<Trainer>();

        public trainer()
        {
            InitializeComponent();
        }

        private void trainer_Load(object sender, EventArgs e)
        {
            LoadSampleData();
            DisplayTrainers(allTrainers);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Label click event — optional
        }

        private void cuiDataGridView1_Click(object sender, EventArgs e)
        {
            // Custom UI click — optional
        }

        private void cuiListbox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Custom UI listbox — optional
        }

        private void cuiPanel3_Paint(object sender, PaintEventArgs e)
        {
            // Panel paint — optional
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Optional click handling
        }

        // Load sample trainers
        private void LoadSampleData()
        {
            allTrainers.Add(new Trainer
            {
                TrainerID = "121948ASH3",
                Name = "Jane Cooper",
                Email = "janecooper@gmail.com",
                ContactNumber = "+639123456789",
                DateOfBirth = "Feb 23, 2025",
                Address = "106 Doyersds St."
            });

            // Add more trainers if needed
        }

        // Display trainers in DataGridView
        private void DisplayTrainers(List<Trainer> trainers)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("TrainerID", "Trainer ID");
            dataGridView1.Columns.Add("Name", "Name");
            dataGridView1.Columns.Add("Email", "Email Address");
            dataGridView1.Columns.Add("ContactNumber", "Contact Number");
            dataGridView1.Columns.Add("DateOfBirth", "Date of Birth");
            dataGridView1.Columns.Add("Address", "Address");

            foreach (var t in trainers)
            {
                dataGridView1.Rows.Add(t.TrainerID, t.Name, t.Email, t.ContactNumber, t.DateOfBirth, t.Address);
            }
        }
    }

    // Trainer model
    public class Trainer
    {
        public string TrainerID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string ContactNumber { get; set; }
        public string DateOfBirth { get; set; }
        public string Address { get; set; }
    }
}
