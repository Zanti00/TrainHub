using Microsoft.EntityFrameworkCore; // Correct namespace for DbSet
using System;
using System.Collections.Generic;
// Removed System.Data.Entity to avoid ambiguity
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainHub.Models;

namespace TrainHub.Data
{
    public class TrainHubContext : DbContext
    {
        public DbSet<User> User { get; set; } = null!; // Fixed null initialization

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.\\sqlexpress;Initial Catalog=TrainHub;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
        }
    }
}