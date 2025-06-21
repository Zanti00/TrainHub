using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TrainHub.Models;

namespace TrainHub.Data
{
    public class TrainHubContext : DbContext
    {
        public DbSet<User> User { get; set; } = null;
        public DbSet<Member> Member { get; set; } = null;
        public DbSet<Trainer> Trainer { get; set; } = null;
        public DbSet<MemberAttendances> MemberAttendances { get; set; } = null;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.\\sqlexpress;Initial Catalog=TrainHub;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
        }
    }
}
