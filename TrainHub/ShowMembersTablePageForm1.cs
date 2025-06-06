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
    public partial class ShowMembersTablePageForm1 : Form
    {
        public ShowMembersTablePageForm1()
        {
            InitializeComponent();

            // Convert columns to image columns
            DataGridViewImageColumn statusColumn = new DataGridViewImageColumn();
            statusColumn.Name = "Status";
            statusColumn.HeaderText = "Status";
            statusColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dataGridView1.Columns.Remove("Column8");
            dataGridView1.Columns.Insert(7, statusColumn);

            DataGridViewImageColumn editColumn = new DataGridViewImageColumn();
            editColumn.Name = "Edit";
            editColumn.HeaderText = "Edit";
            editColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dataGridView1.Columns.Remove("Column11");
            dataGridView1.Columns.Insert(10, editColumn);

            DataGridViewImageColumn deleteColumn = new DataGridViewImageColumn();
            deleteColumn.Name = "Delete";
            deleteColumn.HeaderText = "Delete";
            deleteColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dataGridView1.Columns.Remove("Column12");
            dataGridView1.Columns.Insert(11, deleteColumn);

            // Add a sample row with images
            int rowIndex = dataGridView1.Rows.Add();
            DataGridViewRow row = dataGridView1.Rows[rowIndex];

            // Add your images here - replace the file paths with your actual image paths
            row.Cells[0].Value = "M001";                    // Member ID
            row.Cells[1].Value = "John Doe";                // Name
            row.Cells[2].Value = "john@email.com";          // Email
            row.Cells[3].Value = "1234567890";             // Mobile
            row.Cells[4].Value = "P001";                   // Program ID
            row.Cells[5].Value = "2024-03-01";             // Start Date
            row.Cells[6].Value = "2024-12-31";             // End Date
            row.Cells[7].Value = Image.FromFile(@"C:\Users\MicaellaEliab\Downloads\pencil.png");    // Status image
            row.Cells[8].Value = "Premium";                // Member Type
            row.Cells[9].Value = "T001";                   // Trainer ID
            row.Cells[10].Value = Image.FromFile(@"C:\Users\MicaellaEliab\Downloads\pencil.png");     // Edit image
            row.Cells[11].Value = Image.FromFile(@"C:\Users\MicaellaEliab\Downloads\trash.png");   // Delete image
        }
    }
}